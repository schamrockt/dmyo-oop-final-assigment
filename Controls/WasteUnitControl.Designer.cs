﻿namespace dmyo_oop_final_assigment.Controls
{
	partial class WasteUnitControl
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
			this.unitGrid = new System.Windows.Forms.DataGridView();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.abbreviation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.unitGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// unitGrid
			// 
			this.unitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.unitGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.abbreviation});
			this.unitGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.unitGrid.Location = new System.Drawing.Point(0, 0);
			this.unitGrid.Name = "unitGrid";
			this.unitGrid.Size = new System.Drawing.Size(586, 398);
			this.unitGrid.TabIndex = 0;
			this.unitGrid.TabStop = false;
			this.unitGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.unitGrid_CellValueChanged);
			this.unitGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.unitGrid_UserDeletedRow);
			// 
			// Id
			// 
			this.Id.DataPropertyName = "id";
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			this.Id.Visible = false;
			// 
			// name
			// 
			this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.name.DataPropertyName = "name";
			this.name.HeaderText = "Name";
			this.name.Name = "name";
			this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// abbreviation
			// 
			this.abbreviation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.abbreviation.DataPropertyName = "abbreviation";
			this.abbreviation.HeaderText = "Abbreviation";
			this.abbreviation.Name = "abbreviation";
			// 
			// WasteUnitControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.unitGrid);
			this.Name = "WasteUnitControl";
			this.Size = new System.Drawing.Size(586, 398);
			this.Load += new System.EventHandler(this.WasteUnitControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.unitGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView unitGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Id;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn abbreviation;
	}
}
