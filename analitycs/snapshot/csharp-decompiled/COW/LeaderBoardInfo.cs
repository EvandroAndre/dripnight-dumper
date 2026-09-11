using System.Collections.Generic;
using message;
using proto;

namespace COW;

public class LeaderBoardInfo
{
	public ulong account_id;

	public string name;

	public uint badge_id;

	public uint current_rank;

	public uint last_rank;

	public float score;

	public long play_time;

	public uint win_times;

	public uint kill_times;

	public float win_rating;

	public float kill_rating;

	public float kda;

	public string portrait;

	public uint ladder_rank;

	public uint peak_rank_pos;

	public uint ep_Badge_cnt;

	public int has_EP;

	public string region;

	public uint honor;

	public uint clanlevel;

	public double leaderboard_score;

	public float kill_death_rating;

	public uint external_type;

	public uint cs_rank;

	public uint cs_rankpoint;

	public uint cs_peak_rank_pos;

	public uint br_rank;

	public uint br_rankpoint;

	public uint periodic_rank;

	public uint periodic_ranking_points;

	public uint cs_peak_tournament_points;

	public uint cs_peak_tournament_pos;

	public ulong clan_id;

	public uint clan_active_points;

	public uint clan_active_points_total;

	public uint clanArms;

	public BaseProfileInfo profile_info;

	public TeamLeaderboardProfile team_profile_info;

	public uint[] SelectedItemSlots;

	public ulong limited_event_score;

	public Dictionary<uint, Dictionary<uint, HuntingGroundLikePVERecords>> HGSnowFriendsRecordDict;

	public bool hideInfo;

	public proto.ClanInfo clan_info;

	public uint m_nofityID;

	public uint RankIconDisplayType;

	public string custom_badge;

	public bool use_custom_badge;

	public uint realScore;

	public uint realRank;

	public bool IsFriendLeaderBoard;

	public uint hippo_rank;

	public uint hippo_ranking_points;

	public uint hippo_total_profit;

	public uint hippo_total_worth;

	public Dictionary<uint, uint> LimitedTimeRankScore;

	public bool PrimeLeaderboardAnonymous;

	public uint PrimeLevel;

	public int PrimePointsMonthly;

	public int PrimePointsYearly;

	public int PrimePointsTotally;

	public uint headshot_kills;

	public uint headshots;

	public uint hitCount;

	public bool isAccountProfileNull;

	public HuntingGroundLikePVERecords GetHGSnowFriendsRecordByGameModeAndDifficulty(uint gamemode, uint difficulty)
	{
		return null;
	}

	private static void SetLeaderBoardInfo(LeaderBoardInfo info, AccountLeaderboardItem item)
	{
	}

	private static void SetLeaderBoardInfo(LeaderBoardInfo info, proto.ClanInfo item)
	{
	}

	private static void SetLeaderBoardInfo(LeaderBoardInfo info, ClanLeaderboardItem item)
	{
	}

	private static void SetLeaderBoardInfo(LeaderBoardInfo info, TeamLeaderboardItem item)
	{
	}

	private static void SetLeaderBoardStatsData(LeaderBoardInfo info, AccountInfoWithStats stat)
	{
	}

	public static DetailedTCStats parseDetailTcStats(string detailed_stats)
	{
		return null;
	}

	private static DetailStats parseDetailStats(string detailed_stats)
	{
		return null;
	}

	public static implicit operator LeaderBoardInfo(AccountLeaderboardItem item)
	{
		return null;
	}

	public static implicit operator LeaderBoardInfo(proto.ClanInfo item)
	{
		return null;
	}

	public static implicit operator LeaderBoardInfo(ClanLeaderboardItem item)
	{
		return null;
	}

	public static implicit operator LeaderBoardInfo(TeamLeaderboardItem item)
	{
		return null;
	}

	public LeaderBoardInfo(FriendAccountInfo info, uint type, bool is_ranking)
	{
	}

	public LeaderBoardInfo(FriendAccountInfo info)
	{
	}

	public LeaderBoardInfo()
	{
	}

	public uint GetChampionshipTrailKills()
	{
		return 0u;
	}
}
