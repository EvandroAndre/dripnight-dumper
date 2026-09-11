using GCommon;

namespace COW;

public class UGCRemarkRuleData : CSVBaseData
{
	public uint ID;

	public uint SortID;

	public uint RuleType1;

	public uint RuleValue1;

	public uint RuleType2;

	public uint RuleValue2;

	public uint RuleType3;

	public uint RuleValue3;

	public uint DisplayData1;

	public uint DisplayData2;

	public uint RemarkID;

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
