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
	public partial class SearchOrderControl : UserControl
	{
		public SearchOrderControl()
		{
			InitializeComponent();
		}

		internal SearchOrder GetOrder()
		{
			SearchOrder order = SearchOrder.Invalid;

			if (radioButtonColumns.Checked)
			{
				order = SearchOrder.Columns;
			}
			else if (radioButtonRows.Checked)
			{
				order = SearchOrder.Rows;
			}

			return order;
		}

		internal bool GetBackward()
		{
			return checkBoxBackward.Checked;
		}
	}
}
