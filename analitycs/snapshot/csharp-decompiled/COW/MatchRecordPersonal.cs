using System.Collections.Generic;
using proto;

namespace COW;

public class MatchRecordPersonal
{
	public uint Ranking;

	public ulong MatchID;

	public uint MatchMode;

	public uint GameMode;

	public uint MapID;

	public uint GroupMode;

	public uint TotalRanking;

	public int Rating;

	public int DeltaRating;

	public uint Kills;

	public ulong EndMatchTimeStamp;

	public uint Revive;

	public uint Knockdown;

	public uint Healing;

	public uint Resurrect;

	public uint SurvivalTime;

	public uint HeadShoot;

	public uint Damage;

	public bool IsAlive;

	public uint Deaths;

	public uint Arms;

	public AchievementData AchvData;

	public List<TeammateStats> TeammateList;

	public uint championshipType;

	public MatchStats mystats;

	public MatchIncome MatchIncome;

	public WerewolvesInfo werewolvesInfo;

	public ERanking.RankingMedalType BrRankMedalType;

	public ERanking.RankingMedalType CsRankMedalType;

	public string MapName => null;

	public MatchRecordPersonal(MatchAccountStats matchAccountStats)
	{
	}

	private ERanking.RankingMedalType SetRatingBoardType(MatchIncome income)
	{
		return ERanking.RankingMedalType.RankingMedalType_NONE;
	}
}
