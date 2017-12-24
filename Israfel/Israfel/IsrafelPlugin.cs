using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Codeplex.Data;
using ElectronicObserver.Data;
using ElectronicObserver.Observer;
using ElectronicObserver.Window.Plugins;

namespace Israfel
{
	public class IsrafelPlugin : DockPlugin
	{
		public override string MenuTitle => "Israfel";

		public override string Version => "<BUILD_VERSION>";

		private const string SettingsPath = @"Settings\Israfel.json";

		public IsrafelSettings Settings;

		public List<ShipGroup> ShipGroups;

		public IsrafelForm Form { get; set; }

		public static IsrafelPlugin Singleton { get; private set; }

		public IsrafelPlugin()
		{
			LoadSettings();

			APIObserver.Instance.APIList["api_port/port"].ResponseReceived += DataUpdated;

			Singleton = this;
		}

		public override PluginSettingControl GetSettings()
		{
			return new IsrafelSettingsControl(this);
		}

		private void DataUpdated(string apiname, dynamic data)
		{
			if (Form?.Initialized == false)
				Form.UpdateShipGroups();
			HashSet<int> membersToUpdate = new HashSet<int>(KCDatabase.Instance.Fleet.Fleets.Values.SelectMany(f => f.Members.Where(i => i != -1)));
			ShipGroups.ForEach(shipGroup => shipGroup.NotifyChange(membersToUpdate));
		}

		private void UpdateShipGroups()
		{
			ShipGroups = Settings.Ships.Select((l, i) => new ShipGroup(i, l)).ToList();
		}

		private void LoadSettings()
		{
			if (File.Exists(SettingsPath))
			{
				Settings = DynamicJson.Parse(File.ReadAllText(SettingsPath)).Deserialize<IsrafelSettings>();
			}
			else
			{
				Settings = new IsrafelSettings();
			}

			UpdateShipGroups();
		}

		public void SaveSettings()
		{
			File.WriteAllText(SettingsPath, DynamicJson.Serialize(Settings));

			UpdateShipGroups();
			Form?.UpdateShipGroups();
		}
	}
}