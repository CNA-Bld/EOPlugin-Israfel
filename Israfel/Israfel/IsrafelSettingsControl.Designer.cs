namespace Israfel
{
	partial class IsrafelSettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
			this.buttonNewGroup = new System.Windows.Forms.Button();
			this.buttonRemoveGroup = new System.Windows.Forms.Button();
			this.buttonAddShips = new System.Windows.Forms.Button();
			this.buttonMoveUp = new System.Windows.Forms.Button();
			this.buttonMoveDown = new System.Windows.Forms.Button();
			this.listBoxShipGroups = new System.Windows.Forms.ListBox();
			this.tableLayoutPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			this.tableLayoutPanel.ColumnCount = 5;
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel.Controls.Add(this.buttonNewGroup, 0, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonRemoveGroup, 1, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonAddShips, 2, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonMoveUp, 3, 1);
			this.tableLayoutPanel.Controls.Add(this.buttonMoveDown, 4, 1);
			this.tableLayoutPanel.Controls.Add(this.listBoxShipGroups, 0, 0);
			this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel.Name = "tableLayoutPanel";
			this.tableLayoutPanel.RowCount = 2;
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel.Size = new System.Drawing.Size(150, 150);
			this.tableLayoutPanel.TabIndex = 0;
			// 
			// buttonNewGroup
			// 
			this.buttonNewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonNewGroup.Location = new System.Drawing.Point(3, 124);
			this.buttonNewGroup.Name = "buttonNewGroup";
			this.buttonNewGroup.Size = new System.Drawing.Size(24, 23);
			this.buttonNewGroup.TabIndex = 0;
			this.buttonNewGroup.Text = "+ Group";
			this.buttonNewGroup.UseVisualStyleBackColor = true;
			this.buttonNewGroup.Click += new System.EventHandler(this.buttonNewGroup_Click);
			// 
			// buttonRemoveGroup
			// 
			this.buttonRemoveGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonRemoveGroup.Location = new System.Drawing.Point(33, 124);
			this.buttonRemoveGroup.Name = "buttonRemoveGroup";
			this.buttonRemoveGroup.Size = new System.Drawing.Size(24, 23);
			this.buttonRemoveGroup.TabIndex = 1;
			this.buttonRemoveGroup.Text = "- Group";
			this.buttonRemoveGroup.UseVisualStyleBackColor = true;
			this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
			// 
			// buttonAddShips
			// 
			this.buttonAddShips.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonAddShips.Location = new System.Drawing.Point(63, 124);
			this.buttonAddShips.Name = "buttonAddShips";
			this.buttonAddShips.Size = new System.Drawing.Size(24, 23);
			this.buttonAddShips.TabIndex = 2;
			this.buttonAddShips.Text = "+= Fleet 1";
			this.buttonAddShips.UseVisualStyleBackColor = true;
			this.buttonAddShips.Click += new System.EventHandler(this.buttonAddShips_Click);
			// 
			// buttonMoveUp
			// 
			this.buttonMoveUp.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonMoveUp.Location = new System.Drawing.Point(93, 124);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(24, 23);
			this.buttonMoveUp.TabIndex = 3;
			this.buttonMoveUp.Text = "↑";
			this.buttonMoveUp.UseVisualStyleBackColor = true;
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			// 
			// buttonMoveDown
			// 
			this.buttonMoveDown.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonMoveDown.Location = new System.Drawing.Point(123, 124);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(24, 23);
			this.buttonMoveDown.TabIndex = 4;
			this.buttonMoveDown.Text = "↓";
			this.buttonMoveDown.UseVisualStyleBackColor = true;
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			// 
			// listBoxShipGroups
			// 
			this.tableLayoutPanel.SetColumnSpan(this.listBoxShipGroups, 5);
			this.listBoxShipGroups.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBoxShipGroups.FormattingEnabled = true;
			this.listBoxShipGroups.Location = new System.Drawing.Point(3, 3);
			this.listBoxShipGroups.Name = "listBoxShipGroups";
			this.listBoxShipGroups.Size = new System.Drawing.Size(144, 115);
			this.listBoxShipGroups.TabIndex = 5;
			// 
			// IsrafelSettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel);
			this.Name = "IsrafelSettingsControl";
			this.Load += new System.EventHandler(this.IsrafelSettingsControl_Load);
			this.tableLayoutPanel.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
		private System.Windows.Forms.Button buttonNewGroup;
		private System.Windows.Forms.Button buttonRemoveGroup;
		private System.Windows.Forms.Button buttonAddShips;
		private System.Windows.Forms.Button buttonMoveUp;
		private System.Windows.Forms.Button buttonMoveDown;
		private System.Windows.Forms.ListBox listBoxShipGroups;
	}
}
