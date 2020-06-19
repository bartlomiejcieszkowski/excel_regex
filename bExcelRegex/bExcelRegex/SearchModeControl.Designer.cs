namespace bExcelRegex
{
	partial class SearchModeControl
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
			this.radioButtonRegex = new System.Windows.Forms.RadioButton();
			this.radioButtonNormal = new System.Windows.Forms.RadioButton();
			this.groupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox
			// 
			this.groupBox.AutoSize = true;
			this.groupBox.Controls.Add(this.radioButtonRegex);
			this.groupBox.Controls.Add(this.radioButtonNormal);
			this.groupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox.Location = new System.Drawing.Point(0, 0);
			this.groupBox.Name = "groupBox";
			this.groupBox.Size = new System.Drawing.Size(164, 63);
			this.groupBox.TabIndex = 0;
			this.groupBox.TabStop = false;
			this.groupBox.Text = "Search Mode";
			// 
			// radioButtonRegex
			// 
			this.radioButtonRegex.AutoSize = true;
			this.radioButtonRegex.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonRegex.Location = new System.Drawing.Point(3, 39);
			this.radioButtonRegex.Name = "radioButtonRegex";
			this.radioButtonRegex.Size = new System.Drawing.Size(158, 21);
			this.radioButtonRegex.TabIndex = 1;
			this.radioButtonRegex.Text = "Regular Expression";
			this.radioButtonRegex.UseVisualStyleBackColor = true;
			// 
			// radioButtonNormal
			// 
			this.radioButtonNormal.AutoSize = true;
			this.radioButtonNormal.Checked = true;
			this.radioButtonNormal.Dock = System.Windows.Forms.DockStyle.Top;
			this.radioButtonNormal.Location = new System.Drawing.Point(3, 18);
			this.radioButtonNormal.Name = "radioButtonNormal";
			this.radioButtonNormal.Size = new System.Drawing.Size(158, 21);
			this.radioButtonNormal.TabIndex = 0;
			this.radioButtonNormal.TabStop = true;
			this.radioButtonNormal.Text = "Normal";
			this.radioButtonNormal.UseVisualStyleBackColor = true;
			// 
			// SearchModeControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.groupBox);
			this.Name = "SearchModeControl";
			this.Size = new System.Drawing.Size(164, 150);
			this.groupBox.ResumeLayout(false);
			this.groupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox;
		private System.Windows.Forms.RadioButton radioButtonNormal;
		private System.Windows.Forms.RadioButton radioButtonRegex;
	}
}
