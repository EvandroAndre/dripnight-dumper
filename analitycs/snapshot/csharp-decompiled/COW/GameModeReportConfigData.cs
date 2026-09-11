using GCommon;

namespace COW;

internal class GameModeReportConfigData : CSVBaseData
{
	public uint ID;

	public uint GameMode;

	public uint[] MatchMode;

	public uint[] GroupMode;

	public uint[] ReportMainType;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
