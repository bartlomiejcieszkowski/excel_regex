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
	public partial class SearchModeControl : UserControl
	{
		public SearchModeControl()
		{
			InitializeComponent();
		}

		internal SearchMode GetMode()
		{
			SearchMode mode = SearchMode.Invalid;

			if (radioButtonNormal.Checked)
			{
				mode = SearchMode.Normal;
			}
			else if (radioButtonRegex.Checked)
			{
				mode = SearchMode.RegularExpression;
			}

			return mode;
		}
	}
}
