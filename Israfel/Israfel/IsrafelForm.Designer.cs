namespace Israfel
{
	partial class IsrafelForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.maxShipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.minShipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.deltaExpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shipGroupBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
			this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupIdDataGridViewTextBoxColumn,
            this.maxShipDataGridViewTextBoxColumn,
            this.minShipDataGridViewTextBoxColumn,
            this.deltaLevelDataGridViewTextBoxColumn,
            this.deltaExpDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.shipGroupBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(284, 261);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellToolTipTextNeeded += new System.Windows.Forms.DataGridViewCellToolTipTextNeededEventHandler(this.dataGridView_CellToolTipTextNeeded);
			this.dataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ColumnHeaderMouseClick);
			// 
			// groupIdDataGridViewTextBoxColumn
			// 
			this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "GroupId";
			this.groupIdDataGridViewTextBoxColumn.HeaderText = "ID";
			this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
			this.groupIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.groupIdDataGridViewTextBoxColumn.Width = 5;
			// 
			// maxShipDataGridViewTextBoxColumn
			// 
			this.maxShipDataGridViewTextBoxColumn.DataPropertyName = "MaxShip";
			this.maxShipDataGridViewTextBoxColumn.HeaderText = "↑";
			this.maxShipDataGridViewTextBoxColumn.Name = "maxShipDataGridViewTextBoxColumn";
			this.maxShipDataGridViewTextBoxColumn.ReadOnly = true;
			this.maxShipDataGridViewTextBoxColumn.Width = 5;
			// 
			// minShipDataGridViewTextBoxColumn
			// 
			this.minShipDataGridViewTextBoxColumn.DataPropertyName = "MinShip";
			this.minShipDataGridViewTextBoxColumn.HeaderText = "↓";
			this.minShipDataGridViewTextBoxColumn.Name = "minShipDataGridViewTextBoxColumn";
			this.minShipDataGridViewTextBoxColumn.ReadOnly = true;
			this.minShipDataGridViewTextBoxColumn.Width = 5;
			// 
			// deltaLevelDataGridViewTextBoxColumn
			// 
			this.deltaLevelDataGridViewTextBoxColumn.DataPropertyName = "DeltaLevel";
			this.deltaLevelDataGridViewTextBoxColumn.HeaderText = "ΔLv";
			this.deltaLevelDataGridViewTextBoxColumn.Name = "deltaLevelDataGridViewTextBoxColumn";
			this.deltaLevelDataGridViewTextBoxColumn.ReadOnly = true;
			this.deltaLevelDataGridViewTextBoxColumn.Width = 5;
			// 
			// deltaExpDataGridViewTextBoxColumn
			// 
			this.deltaExpDataGridViewTextBoxColumn.DataPropertyName = "DeltaExp";
			this.deltaExpDataGridViewTextBoxColumn.HeaderText = "ΔExp";
			this.deltaExpDataGridViewTextBoxColumn.Name = "deltaExpDataGridViewTextBoxColumn";
			this.deltaExpDataGridViewTextBoxColumn.ReadOnly = true;
			this.deltaExpDataGridViewTextBoxColumn.Width = 5;
			// 
			// shipGroupBindingSource
			// 
			this.shipGroupBindingSource.DataSource = typeof(Israfel.ShipGroup);
			// 
			// IsrafelForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.dataGridView);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HideOnClose = true;
			this.Name = "IsrafelForm";
			this.Text = "Israfel";
			this.Load += new System.EventHandler(this.IsrafelForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shipGroupBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.BindingSource shipGroupBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn maxShipDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn minShipDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaLevelDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deltaExpDataGridViewTextBoxColumn;
	}
}