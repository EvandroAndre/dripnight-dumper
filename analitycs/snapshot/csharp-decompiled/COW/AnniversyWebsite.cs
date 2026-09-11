using System.Collections.Generic;
using GCommon;

namespace COW;

public class AnniversyWebsite : CSVBaseData
{
	public enum Type
	{
		None,
		Main,
		Invitation
	}

	private const string REGION_DEFAULT = "default";

	private const string LANGUAGE_DEFAULT = "default";

	private const int TYPE_DEFAULT = 1;

	private static Dictionary<string, Dictionary<string, Dictionary<int, AnniversyWebsite>>> _Data;

	private int _003CID_003Ek__BackingField;

	private int _003CTitleType_003Ek__BackingField;

	private string _003CRegion_003Ek__BackingField;

	private string _003CLanguageAbbr_003Ek__BackingField;

	private string _003CWebUrl_003Ek__BackingField;

	public int ID
	{
		get
		{
			return _003CID_003Ek__BackingField;
		}
		private set
		{
			_003CID_003Ek__BackingField = value;
		}
	}

	public int TitleType
	{
		get
		{
			return _003CTitleType_003Ek__BackingField;
		}
		private set
		{
			_003CTitleType_003Ek__BackingField = value;
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

	public string LanguageAbbr
	{
		get
		{
			return _003CLanguageAbbr_003Ek__BackingField;
		}
		private set
		{
			_003CLanguageAbbr_003Ek__BackingField = value;
		}
	}

	public string WebUrl
	{
		get
		{
			return _003CWebUrl_003Ek__BackingField;
		}
		private set
		{
			_003CWebUrl_003Ek__BackingField = value;
		}
	}

	public static AnniversyWebsite Get(string region, string language, Type type = Type.Main)
	{
		return null;
	}

	private static Dictionary<string, Dictionary<int, AnniversyWebsite>> Get(string region)
	{
		return null;
	}

	private static Dictionary<int, AnniversyWebsite> Get(string language, Dictionary<string, Dictionary<int, AnniversyWebsite>> data)
	{
		return null;
	}

	private static AnniversyWebsite Get(int type, Dictionary<int, AnniversyWebsite> data)
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

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
