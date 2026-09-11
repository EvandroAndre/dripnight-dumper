using GCommon;

namespace COW;

public class CSSharedLoadoutData : CSVBaseData, IGetId
{
	public uint iID;

	public int pageID;

	public bool isSold;

	public uint playCardID;

	public string playCardSprite;

	public string br_desc;

	public string cs_desc;

	public uint[] tagsId;

	public uint AdjustType;

	public string AdjustDescKey;

	public string iconRes;

	public string CSGrowIngameIconRes;

	public string tutorialsBRUrl;

	public string tutorialsCSUrl;

	public string CdnBRUrl;

	public string CdnCSUrl;

	public string SpIconBgColor;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
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
