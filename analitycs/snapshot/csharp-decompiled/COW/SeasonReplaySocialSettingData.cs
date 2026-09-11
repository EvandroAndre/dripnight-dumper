using GCommon;

namespace COW;

public class SeasonReplaySocialSettingData : CSVBaseData
{
	public uint SocialId;

	public uint GroupId;

	public uint OrderId;

	public uint NewOrderId;

	public uint NewGroupId;

	public string BRDataDesc;

	public string BRTitle;

	public string BRDesc;

	public string NewBRDesc;

	public string CSDataDesc;

	public string CSTitle;

	public string CSDesc;

	public string NewCSDesc;

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
