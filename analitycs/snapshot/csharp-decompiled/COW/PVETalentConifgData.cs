using GCommon;

namespace COW;

public class PVETalentConifgData : CSVBaseData
{
	public uint TalentId;

	public uint TalentGroup;

	public string TalentName;

	public string TalentSummary;

	public uint TalentLevel;

	public ResourceID TalentIcon;

	public string[] DescParams;

	public uint UpgradePrice;

	public uint UpgradeItem;

	public uint ReplaceID;

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
