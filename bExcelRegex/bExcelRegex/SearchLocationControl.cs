using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bExcelRegex.Search;

namespace bExcelRegex
{
	public partial class SearchLocationControl : UserControl
	{
		public SearchLocationControl()
		{
			InitializeComponent();
		}

		internal SearchLocation GetLocation()
		{
			SearchLocation location = SearchLocation.Invalid;

			if (radioButtonSelection.Checked)
			{
				location = SearchLocation.Selection;
			}
			else if (radioButtonBook.Checked)
			{
				location = SearchLocation.Workbook;
			}
			else if (radioButtonSheet.Checked)
			{
				location = SearchLocation.Worksheet;
			}

			return location;
		}
	}
}
