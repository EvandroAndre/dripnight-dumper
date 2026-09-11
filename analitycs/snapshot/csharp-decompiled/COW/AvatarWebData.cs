using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarWebData : CSVBaseData
{
	public uint AvatarID;

	public string WebLink;

	private const string REGION_DEFAULT = "default";

	private const string LANGUAGE_DEFAULT = "default";

	private static Dictionary<uint, Dictionary<string, Dictionary<string, AvatarWebData>>> _Data;

	private string _003CRegion_003Ek__BackingField;

	private string _003CLanguageAbbr_003Ek__BackingField;

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
