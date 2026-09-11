using System;
using GCommon;

namespace COW;

public class CSRankingSeasonInfoData : CSVBaseData
{
	public int Index;

	public string SeasonName;

	public DateTime StartTime;

	public DateTime EndTime;

	public string SeasonRewardBgUrl;

	public uint EndCountdown;

	public bool ShowSeasonTheme;

	public string SeasonThemeName;

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
