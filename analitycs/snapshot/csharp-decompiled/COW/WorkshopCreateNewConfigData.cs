using GCommon;

namespace COW;

public class WorkshopCreateNewConfigData : CSVBaseData
{
	public uint ID;

	public uint Type;

	public uint MainID;

	public uint Template;

	public uint OptionID;

	public bool ShowTutorial;

	public bool EnableFullCustom;

	public bool IsHot;

	public bool IsNew;

	public bool IsDefault;

	public string MainKey;

	public string ModeCDN;

	public string ModeCDNBg;

	public string DescKey;

	public string TutorialURL;

	public string SizeKey;

	public string MapSize;

	public string ModeLoadingCDN;

	public uint[] ActiveMapArray;

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
