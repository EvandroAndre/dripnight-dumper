using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class LadderLevelData
{
	public int Rank;

	public int RankSortID;

	public string RankName;

	public int LowerBound;

	public int UpperBound;

	public List<AwardDesc> AchieveAwardItemList;

	public AwardDesc FirstRankRewardItem;

	public uint RewardedRankSort;

	public bool IsShowFirstRankReward;

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

	public bool IsPlayerLevel;

	public bool IsCurrentPlayerRankHigherThenRank;

	public bool IsShowNotClaimLight;

	public uint CachedMaxRank;

	public int RankMasterLevel;

	public uint RankMasterUpperBound;

	public string RankMasterText;

	public bool IsReachGrandMasterLevel;

	public uint RankStage;

	public uint StarCount;

	public ResourceID ColorResource;

	public ResourceID LadderIconUIFXRes;

	public bool HasClaimedResetMatchReward;

	public uint SeasonResetRank;

	public DLBMPCCFKKM RankMatchMode;

	public int PreviewRewardListCount;

	public ResourceID CrossMatchModeIconRes;

	public ResourceID CrossMatchModeUIFXRes;

	public string RankDetailedName;

	public LadderLevelData(RankData rank_data)
	{
	}

	public LadderLevelData(CSRankData rank_data)
	{
	}

	public LadderLevelData(PeriodicRankData rank_data)
	{
	}

	public LadderLevelData(HippoCrisisRankData rank_data)
	{
	}

	public LadderLevelData(CSPeakRankData rank_data)
	{
	}
}
