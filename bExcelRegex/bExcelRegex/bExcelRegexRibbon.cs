using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace bExcelRegex
{
	public partial class bExcelRegexRibbon
	{

		private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
		{

		}

		private void buttonReplace_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.ShowTaskPane(true, ThisAddIn.ShowSource.Replace);
		}

		private void buttonFind_Click(object sender, RibbonControlEventArgs e)
		{
			Globals.ThisAddIn.ShowTaskPane(true, ThisAddIn.ShowSource.Find);
		}

		private void buttonPrev_Click(object sender, RibbonControlEventArgs e)
		{

		}

		private void buttonNext_Click(object sender, RibbonControlEventArgs e)
		{

		}
	}
}
