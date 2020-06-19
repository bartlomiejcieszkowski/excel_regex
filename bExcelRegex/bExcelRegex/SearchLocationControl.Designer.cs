namespace bExcelRegex
{
	partial class SearchLocationControl
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
			this.radioButtonBook = new System.Windows.Forms.RadioButton();
			this.radioButtonSheet = new System.Windows.Forms.RadioButton();
			this.radioButtonSelection = new System.Windows.Forms.RadioButton();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox
			// 
			this.groupBox.AutoSize = true;
			this.groupBox.Controls.Add(this.radioButtonBook);
			this.groupBox.Controls.Add(this.radioButtonSheet);
			this.groupBox.Controls.Add(this.radioButtonSelection);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(150, 84);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Where?";
			// 
			// radioButtonBook
			// 
			this.radioButtonBook.AutoSize = true;
			this.radioButtonBook.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonBook.Location = new System.Drawing.Point(3, 60);
			this.radioButtonBook.Name = "radioButtonBook";
			this.radioButtonBook.Size = new System.Drawing.Size(144, 21);
			this.radioButtonBook.TabIndex = 2;
			this.radioButtonBook.TabStop = true;
			this.radioButtonBook.Text = "Workbook";
			this.radioButtonBook.UseVisualStyleBackColor = true;
			// 
			// radioButtonSheet
			// 
			this.radioButtonSheet.AutoSize = true;
			this.radioButtonSheet.Checked = true;
			this.radioButtonSheet.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonSheet.Location = new System.Drawing.Point(3, 39);
			this.radioButtonSheet.Name = "radioButtonSheet";
			this.radioButtonSheet.Size = new System.Drawing.Size(144, 21);
			this.radioButtonSheet.TabIndex = 1;
			this.radioButtonSheet.TabStop = true;
			this.radioButtonSheet.Text = "Worksheet";
			this.radioButtonSheet.UseVisualStyleBackColor = true;
			// 
			// radioButtonSelection
			// 
			this.radioButtonSelection.AutoSize = true;
			this.radioButtonSelection.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonSelection.Location = new System.Drawing.Point(3, 18);
			this.radioButtonSelection.Name = "radioButtonSelection";
			this.radioButtonSelection.Size = new System.Drawing.Size(144, 21);
			this.radioButtonSelection.TabIndex = 0;
			this.radioButtonSelection.TabStop = true;
			this.radioButtonSelection.Text = "Selection";
			this.radioButtonSelection.UseVisualStyleBackColor = true;
			// 
			// SearchLocationControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.groupBox);
			this.Name = "SearchLocationControl";
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.RadioButton radioButtonBook;
		private System.Windows.Forms.RadioButton radioButtonSheet;
		private System.Windows.Forms.RadioButton radioButtonSelection;
	}
}
