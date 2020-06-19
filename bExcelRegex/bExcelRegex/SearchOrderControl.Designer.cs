namespace bExcelRegex
{
	partial class SearchOrderControl
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
			this.groupBox = new System.Windows.Forms.GroupBox();
			this.checkBoxBackward = new System.Windows.Forms.CheckBox();
			this.radioButtonColumns = new System.Windows.Forms.RadioButton();
			this.radioButtonRows = new System.Windows.Forms.RadioButton();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox
			// 
			this.groupBox.AutoSize = true;
			this.groupBox.Controls.Add(this.checkBoxBackward);
			this.groupBox.Controls.Add(this.radioButtonColumns);
			this.groupBox.Controls.Add(this.radioButtonRows);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(183, 84);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Search order";
			// 
			// checkBoxBackward
			// 
			this.checkBoxBackward.AutoSize = true;
			this.checkBoxBackward.Dock = System.Windows.Forms.DockStyle.Top;
			this.checkBoxBackward.Location = new System.Drawing.Point(3, 60);
			this.checkBoxBackward.Name = "checkBoxBackward";
			this.checkBoxBackward.Size = new System.Drawing.Size(177, 21);
			this.checkBoxBackward.TabIndex = 2;
			this.checkBoxBackward.Text = "Backward direction";
			this.checkBoxBackward.UseVisualStyleBackColor = true;
			// 
			// radioButtonColumns
			// 
			this.radioButtonColumns.AutoSize = true;
			this.radioButtonColumns.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonColumns.Location = new System.Drawing.Point(3, 39);
			this.radioButtonColumns.Name = "radioButtonColumns";
			this.radioButtonColumns.Size = new System.Drawing.Size(177, 21);
			this.radioButtonColumns.TabIndex = 1;
			this.radioButtonColumns.Text = "Columns";
			this.radioButtonColumns.UseVisualStyleBackColor = true;
			// 
			// radioButtonRows
			// 
			this.radioButtonRows.AutoSize = true;
			this.radioButtonRows.Checked = true;
			this.radioButtonRows.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonRows.Location = new System.Drawing.Point(3, 18);
			this.radioButtonRows.Name = "radioButtonRows";
			this.radioButtonRows.Size = new System.Drawing.Size(177, 21);
			this.radioButtonRows.TabIndex = 0;
			this.radioButtonRows.TabStop = true;
			this.radioButtonRows.Text = "Rows";
			this.radioButtonRows.UseVisualStyleBackColor = true;
			// 
			// SearchOrderControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox);
			this.Name = "SearchOrderControl";
			this.Size = new System.Drawing.Size(183, 150);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.RadioButton radioButtonColumns;
		private System.Windows.Forms.RadioButton radioButtonRows;
		private System.Windows.Forms.CheckBox checkBoxBackward;
	}
}
