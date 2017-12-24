using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicObserver.Window;
using WeifenLuo.WinFormsUI.Docking;

namespace Israfel
{
	public partial class IsrafelForm : DockContent
	{
		public Boolean Initialized { get; private set; }

		public IsrafelForm(FormMain formMain)
		{
			InitializeComponent();
			Initialized = false;
			IsrafelPlugin.Singleton.Form = this;
		}

		private void IsrafelForm_Load(object sender, EventArgs e)
		{
			// UpdateShipGroups();
		}

		public void UpdateShipGroups()
		{
			Initialized = true;
			shipGroupBindingSource.DataSource = new SortableBindingList<ShipGroup>(IsrafelPlugin.Singleton.ShipGroups);
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var data = dataGridView.Rows[e.RowIndex].DataBoundItem as ShipGroup;
			if (data.DeltaLevel > 0)
			{
				e.CellStyle.BackColor = Color.Moccasin;
			}
		}

		private void dataGridView_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				var data = dataGridView.Rows[e.RowIndex].DataBoundItem as ShipGroup;
				e.ToolTipText = data.AllShips;
			}
		}

		private void dataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			//shipGroupBindingSource
		}
	}
}
