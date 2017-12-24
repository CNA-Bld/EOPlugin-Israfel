using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicObserver.Data;
using ElectronicObserver.Window.Plugins;

namespace Israfel
{
	public partial class IsrafelSettingsControl : PluginSettingControl
	{
		private IsrafelPlugin plugin;
		private BindingList<SettingsShipGroup> settingsShipGroups;

		private class SettingsShipGroup
		{
			public HashSet<int> ShipIds = new HashSet<int>();

			public string DisplayName => ShipIds.Count == 0 ? "<Empty>" : string.Join(", ", ShipIds.Select(i => $"[{i}] {KCDatabase.Instance.Ships[i].NameWithLevel}"));

		}

		public IsrafelSettingsControl(IsrafelPlugin plugin)
		{
			this.plugin = plugin;
			InitializeComponent();
		}

		public override bool Save()
		{
			plugin.Settings.Ships = settingsShipGroups.ToList().Select(i => i.ShipIds.ToList()).Where(l => l.Count > 0).ToList();
			plugin.SaveSettings();
			return true;
		}

		private void IsrafelSettingsControl_Load(object sender, EventArgs e)
		{
			try
			{
				settingsShipGroups = new BindingList<SettingsShipGroup>(plugin.Settings.Ships
					.Select(shipList => new SettingsShipGroup { ShipIds = new HashSet<int>(shipList) }).ToList());
				listBoxShipGroups.DataSource = settingsShipGroups;
			}
			catch (NullReferenceException)
			{

			}
			listBoxShipGroups.DisplayMember = "DisplayName";
		}

		private void buttonNewGroup_Click(object sender, EventArgs e)
		{
			settingsShipGroups.Add(new SettingsShipGroup());
			listBoxShipGroups.SelectedIndex = settingsShipGroups.Count - 1;
		}

		private void buttonRemoveGroup_Click(object sender, EventArgs e)
		{
			settingsShipGroups.RemoveAt(listBoxShipGroups.SelectedIndex);
		}

		private void buttonAddShips_Click(object sender, EventArgs e)
		{
			settingsShipGroups[listBoxShipGroups.SelectedIndex].ShipIds.UnionWith(KCDatabase.Instance.Fleet[1].Members.Where(i => i != -1));
			listBoxShipGroups.ResetBindings();
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			if (listBoxShipGroups.SelectedIndex > 0)
			{
				var temp = settingsShipGroups[listBoxShipGroups.SelectedIndex];
				settingsShipGroups[listBoxShipGroups.SelectedIndex] = settingsShipGroups[listBoxShipGroups.SelectedIndex - 1];
				settingsShipGroups[listBoxShipGroups.SelectedIndex - 1] = temp;
				listBoxShipGroups.SelectedIndex -= 1;
			}
		}

		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			if (listBoxShipGroups.SelectedIndex < settingsShipGroups.Count - 1)
			{
				var temp = settingsShipGroups[listBoxShipGroups.SelectedIndex];
				settingsShipGroups[listBoxShipGroups.SelectedIndex] = settingsShipGroups[listBoxShipGroups.SelectedIndex + 1];
				settingsShipGroups[listBoxShipGroups.SelectedIndex + 1] = temp;
				listBoxShipGroups.SelectedIndex += 1;
			}
		}
	}
}
