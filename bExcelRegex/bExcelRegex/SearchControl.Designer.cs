namespace bExcelRegex
{
	partial class SearchControl
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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageFind = new System.Windows.Forms.TabPage();
			this.searchOrder1 = new bExcelRegex.SearchOrderControl();
			this.searchLocation1 = new bExcelRegex.SearchLocationControl();
			this.searchModeControl1 = new bExcelRegex.SearchModeControl();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBoxFind = new System.Windows.Forms.TextBox();
			this.tabPageReplace = new System.Windows.Forms.TabPage();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.tabControl.SuspendLayout();
			this.tabPageFind.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPageReplace.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageFind);
			this.tabControl.Controls.Add(this.tabPageReplace);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(500, 500);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageFind
			// 
			this.tabPageFind.Controls.Add(this.searchOrder1);
			this.tabPageFind.Controls.Add(this.searchLocation1);
			this.tabPageFind.Controls.Add(this.searchModeControl1);
			this.tabPageFind.Controls.Add(this.button1);
			this.tabPageFind.Controls.Add(this.groupBox1);
			this.tabPageFind.Location = new System.Drawing.Point(4, 25);
			this.tabPageFind.Name = "tabPageFind";
			this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFind.Size = new System.Drawing.Size(492, 471);
			this.tabPageFind.TabIndex = 0;
			this.tabPageFind.Text = "Find";
			this.tabPageFind.UseVisualStyleBackColor = true;
			// 
			// searchOrder1
			// 
			this.searchOrder1.AutoSize = true;
			this.searchOrder1.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchOrder1.Location = new System.Drawing.Point(3, 216);
			this.searchOrder1.Name = "searchOrder1";
			this.searchOrder1.Size = new System.Drawing.Size(486, 84);
			this.searchOrder1.TabIndex = 7;
			// 
			// searchLocation1
			// 
			this.searchLocation1.AutoSize = true;
			this.searchLocation1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.searchLocation1.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchLocation1.Location = new System.Drawing.Point(3, 132);
			this.searchLocation1.Name = "searchLocation1";
			this.searchLocation1.Size = new System.Drawing.Size(486, 84);
			this.searchLocation1.TabIndex = 0;
			// 
			// searchModeControl1
			// 
			this.searchModeControl1.AutoSize = true;
			this.searchModeControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.searchModeControl1.Location = new System.Drawing.Point(3, 69);
			this.searchModeControl1.Name = "searchModeControl1";
			this.searchModeControl1.Size = new System.Drawing.Size(486, 63);
			this.searchModeControl1.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.Dock = System.Windows.Forms.DockStyle.Top;
			this.button1.Location = new System.Drawing.Point(3, 46);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(486, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Find";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSize = true;
			this.groupBox1.Controls.Add(this.textBoxFind);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(486, 43);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Find";
			// 
			// textBoxFind
			// 
			this.textBoxFind.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxFind.Location = new System.Drawing.Point(3, 18);
			this.textBoxFind.Name = "textBoxFind";
			this.textBoxFind.Size = new System.Drawing.Size(480, 22);
			this.textBoxFind.TabIndex = 0;
			// 
			// tabPageReplace
			// 
			this.tabPageReplace.Controls.Add(this.button4);
			this.tabPageReplace.Controls.Add(this.button3);
			this.tabPageReplace.Controls.Add(this.button2);
			this.tabPageReplace.Controls.Add(this.groupBox4);
			this.tabPageReplace.Controls.Add(this.groupBox3);
			this.tabPageReplace.Location = new System.Drawing.Point(4, 25);
			this.tabPageReplace.Name = "tabPageReplace";
			this.tabPageReplace.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageReplace.Size = new System.Drawing.Size(492, 471);
			this.tabPageReplace.TabIndex = 1;
			this.tabPageReplace.Text = "Replace";
			this.tabPageReplace.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Dock = System.Windows.Forms.DockStyle.Top;
			this.button4.Location = new System.Drawing.Point(3, 249);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(486, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Dock = System.Windows.Forms.DockStyle.Top;
			this.button3.Location = new System.Drawing.Point(3, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(486, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Dock = System.Windows.Forms.DockStyle.Top;
			this.button2.Location = new System.Drawing.Point(3, 203);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(486, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.textBox3);
			this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox4.Location = new System.Drawing.Point(3, 103);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(486, 100);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "groupBox4";
			// 
			// textBox3
			// 
			this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox3.Location = new System.Drawing.Point(3, 18);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(480, 22);
			this.textBox3.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(3, 3);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(486, 100);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBox2.Location = new System.Drawing.Point(3, 18);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(480, 22);
			this.textBox2.TabIndex = 0;
			// 
			// SearchControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.tabControl);
			this.Name = "SearchControl";
			this.Size = new System.Drawing.Size(500, 500);
			this.tabControl.ResumeLayout(false);
			this.tabPageFind.ResumeLayout(false);
			this.tabPageFind.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPageReplace.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageFind;
		private System.Windows.Forms.TabPage tabPageReplace;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxFind;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private SearchModeControl searchModeControl1;
		private SearchLocationControl searchLocation1;
		private SearchOrderControl searchOrder1;
	}
}
