using tcp;

namespace COW;

public class BattleStatsInfo
{
	public uint Wins;

	public uint Kills;

	public uint Deaths;

	public uint MvpCount;

	public uint Damage;

	public uint GamesPlayed;

	public uint DoubleKills;

	public uint TripleKills;

	public uint FourKills;

	public uint HeadShotKills;

	public uint Assists;

	public uint Top10PercentTimes;

	public uint SurvivalTime;

	public uint OneGameMostKills;

	public uint OneGameMostDamage;

	public double BRRating;

	public double CSRating;

	public uint IconicWeaponID;

	public uint IconicWeaponKill;

	public uint IconicWeaponHeadshotKill;

	public uint IconicWeaponDamage;

	public uint MaxStreakGoldMedal;

	public uint MaxStreakSilverMedal;

	public static implicit operator BattleStatsInfo(StatsInfo info)
	{
		return null;
	}

	public BattleStatsInfo()
	{
	}

	public BattleStatsInfo(CSPeakIconicWeaponInfo info, uint gamesPlayed)
	{
	}

	public static implicit operator BattleStatsInfo(BRStatsInfo info)
	{
		return null;
	}
}
