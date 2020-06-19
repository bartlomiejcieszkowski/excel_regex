using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bExcelRegex.Search
{
	public enum SearchType
	{
		Find,
		Replace
	}

	public enum SearchMode
	{
		Invalid,
		Normal,
		RegularExpression,
	}

	public enum SearchLocation
	{
		Invalid,
		Selection,
		Worksheet,
		Workbook,
	}

	public enum SearchOrder
	{
		Invalid,
		Rows,
		Columns,
	}

	public class SearchParams
	{
		public SearchType type;
		public SearchMode mode;
		public SearchLocation location;
		public SearchOrder order;
		public bool order_backward;
		public string find_text;
		public string replace_text;
	}

	public static class Helpers
	{
		public static bool AreEqual(this SearchParams a, SearchParams b)
		{
			if (a == null && b == null)
			{
				return true;
			}

			if (a == null || b == null)
			{
				return false;
			}
			return (a.type == b.type
				&& a.mode == b.mode
				&& a.location == b.location
				&& a.order == b.order
				&& a.order_backward == b.order_backward
				&& a.find_text == b.find_text
				&& a.replace_text == b.replace_text);
		}
	}

	public class SearchResult
	{
		string result;
	}

	public class SearchEngine
	{
		SearchParams searchParams;

		public SearchEngine()
		{

		}

		public SearchResult Search(SearchParams _searchParams)
		{
			bool continue_search = false;
			if (searchParams.AreEqual(_searchParams))
			{
				continue_search = true;
			}
			else
			{
				searchParams = _searchParams;
			}

			if (searchParams.find_text == null || searchParams.find_text.Length == 0)
			{
				return null;
			}

			return null;
		}
		
	}
}
