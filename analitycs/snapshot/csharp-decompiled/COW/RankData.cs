using GCommon;

namespace COW;

public class RankData : CSVBaseData
{
	public uint SeasonStart;

	public uint SeasonEnd;

	public int Rank;

	public int RankSortID;

	public string RankName;

	public int LowerBound;

	public int UpperBound;

	public ResourceID IconRes;

	public ResourceID BigIconRes;

	public ResourceID LobbyIconRes;

	public ResourceID LadderSeasonRes;

	public int RankAnimationSwitch;

	public int RankGroup;

	public ResourceID FullScreenRankUpRes;

	public string FullScreenRankUpClipName;

	public string FullScreenRankUpCrossModeClipName;

	public int LobbyIconVFX;

	public uint RankStage;

	public uint StarCount;

	public ResourceID ColorResource;

	public ResourceID LadderIconUIFXRes;

	public ResourceID CrossMatchModeIconRes;

	public ResourceID CrossMatchModeUIFXRes;

	public string RankDetailedName;

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
