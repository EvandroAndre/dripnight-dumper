using GCommon;

namespace COW;

public class ChannelGoposSummaryData : CSVBaseData, IGetId
{
	public uint Channel;

	public uint Priority;

	public uint GoposFormat;

	public string SubgoposFormat;

	public string ChannelIcon;

	public string ChannelKEY;

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public uint GetId()
	{
		return 0u;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
