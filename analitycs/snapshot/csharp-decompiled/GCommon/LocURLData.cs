using System.Collections.Generic;

namespace GCommon;

public class LocURLData : CSVBaseData
{
	public static class Keys
	{
		public const string TERMS_OF_SERVICE = "LOC_URL_TERMS_OF_SERVICE";

		public const string TERMS_OF_PRIVACY = "LOC_URL_TERMS_OF_PRIVACY";
	}

	private Dictionary<int, string> keyToURL;

	private string key;

	public string Key => null;

	// C# has no syntax for parameterized property 'Item'.
	public string get_Item(LocLang locLang)
	{
		return null;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
