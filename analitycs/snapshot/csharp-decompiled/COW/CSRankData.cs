using GCommon;

namespace COW;

public class CSRankData : CSVBaseData
{
	public uint SeasonStart;

	public uint SeasonEnd;

	public int Rank;

	public int RankSortID;

	public string RankName;

	public uint RankUpStar;

	public uint LowerBound;

	public uint UpperBound;

	public bool IsRankProtect;

	public ResourceID IconRes;

	public ResourceID BigIconRes;

	public ResourceID LobbyIconRes;

	public ResourceID LadderSeasonRes;

	public ResourceID FullScreenRankUpRes;

	public string FullScreenRankUpClipName;

	public string FullScreenRankUpCrossModeClipName;

	public int RankAnimationSwitch;

	public int RankGroup;

	public int LobbyIconVFX;

	public uint AchieveProtectionScore;

	public uint RankStage;

	public uint FirstHeroicRank;

	public ResourceID LadderIconUIFXRes;

	public ResourceID CrossMatchModeIconRes;

	public ResourceID CrossMatchModeUIFXRes;

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
