namespace bExcelRegex
{
	partial class bExcelRegexRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public bExcelRegexRibbon()
			: base(Globals.Factory.GetRibbonFactory())
		{
			InitializeComponent();
		}

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
			this.tab1 = this.Factory.CreateRibbonTab();
			this.group1 = this.Factory.CreateRibbonGroup();
			this.buttonGroup2 = this.Factory.CreateRibbonButtonGroup();
			this.buttonFind = this.Factory.CreateRibbonButton();
			this.buttonReplace = this.Factory.CreateRibbonButton();
			this.buttonGroup1 = this.Factory.CreateRibbonButtonGroup();
			this.buttonPrev = this.Factory.CreateRibbonButton();
			this.buttonNext = this.Factory.CreateRibbonButton();
			this.tab1.SuspendLayout();
			this.group1.SuspendLayout();
			this.buttonGroup2.SuspendLayout();
			this.buttonGroup1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tab1
			// 
			this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
			this.tab1.Groups.Add(this.group1);
			this.tab1.Label = "TabAddIns";
			this.tab1.Name = "tab1";
			// 
			// group1
			// 
			this.group1.Items.Add(this.buttonGroup2);
			this.group1.Items.Add(this.buttonGroup1);
			this.group1.Label = "bExcelRegex";
			this.group1.Name = "group1";
			// 
			// buttonGroup2
			// 
			this.buttonGroup2.Items.Add(this.buttonFind);
			this.buttonGroup2.Items.Add(this.buttonReplace);
			this.buttonGroup2.Name = "buttonGroup2";
			// 
			// buttonFind
			// 
			this.buttonFind.Label = "Find";
			this.buttonFind.Name = "buttonFind";
			this.buttonFind.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonFind_Click);
			// 
			// buttonReplace
			// 
			this.buttonReplace.Label = "Replace";
			this.buttonReplace.Name = "buttonReplace";
			this.buttonReplace.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonReplace_Click);
			// 
			// buttonGroup1
			// 
			this.buttonGroup1.Items.Add(this.buttonPrev);
			this.buttonGroup1.Items.Add(this.buttonNext);
			this.buttonGroup1.Name = "buttonGroup1";
			// 
			// buttonPrev
			// 
			this.buttonPrev.Label = "Previous";
			this.buttonPrev.Name = "buttonPrev";
			this.buttonPrev.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonPrev_Click);
			// 
			// buttonNext
			// 
			this.buttonNext.Label = "Next";
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonNext_Click);
			// 
			// bExcelRegexRibbon
			// 
			this.Name = "bExcelRegexRibbon";
			this.RibbonType = "Microsoft.Excel.Workbook";
			this.Tabs.Add(this.tab1);
			this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
			this.tab1.ResumeLayout(false);
			this.tab1.PerformLayout();
			this.group1.ResumeLayout(false);
			this.group1.PerformLayout();
			this.buttonGroup2.ResumeLayout(false);
			this.buttonGroup2.PerformLayout();
			this.buttonGroup1.ResumeLayout(false);
			this.buttonGroup1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
		internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup2;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonFind;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonReplace;
		internal Microsoft.Office.Tools.Ribbon.RibbonButtonGroup buttonGroup1;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonPrev;
		internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonNext;
	}

	partial class ThisRibbonCollection
	{
		internal bExcelRegexRibbon Ribbon1
		{
			get { return this.GetRibbon<bExcelRegexRibbon>(); }
		}
	}
}
