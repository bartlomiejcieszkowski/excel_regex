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
	public partial class SearchControl : UserControl
	{
		public SearchControl()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SearchParams searchParams = new SearchParams();

			searchParams.type = SearchType.Find;
			searchParams.location = searchLocation1.GetLocation();
			searchParams.mode = searchModeControl1.GetMode();
			searchParams.order = searchOrder1.GetOrder();
			searchParams.order_backward = searchOrder1.GetBackward();
			searchParams.find_text = textBoxFind.Text;

			Globals.ThisAddIn.GetSearchEngine().Search(searchParams);
		}
	}
}
