using System.Collections.Generic;
using GCommon;

namespace COW;

public class TutorialURLData : CSVBaseData
{
	private const string DEFAULT_LANG_REGION = "default";

	private static Dictionary<string, Dictionary<string, TutorialURLData>> _Data;

	private string _003CLanguage_003Ek__BackingField;

	private string _003CTutorialURL_003Ek__BackingField;

	private string _003CVideoURL_003Ek__BackingField;

	private string _003CRegion_003Ek__BackingField;

	public string Language
	{
		get
		{
			return _003CLanguage_003Ek__BackingField;
		}
		private set
		{
			_003CLanguage_003Ek__BackingField = value;
		}
	}

	public string TutorialURL
	{
		get
		{
			return _003CTutorialURL_003Ek__BackingField;
		}
		private set
		{
			_003CTutorialURL_003Ek__BackingField = value;
		}
	}

	public string VideoURL
	{
		get
		{
			return _003CVideoURL_003Ek__BackingField;
		}
		private set
		{
			_003CVideoURL_003Ek__BackingField = value;
		}
	}

	public string Region
	{
		get
		{
			return _003CRegion_003Ek__BackingField;
		}
		private set
		{
			_003CRegion_003Ek__BackingField = value;
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static string FormatPrimaryKey(string region, string language)
	{
		return null;
	}

	public static TutorialURLData Get(string region, string language)
	{
		return null;
	}

	public static void Clear()
	{
	}

	private static Dictionary<string, TutorialURLData> Get(string region)
	{
		return null;
	}

	private static TutorialURLData Get(string language, Dictionary<string, TutorialURLData> data)
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
