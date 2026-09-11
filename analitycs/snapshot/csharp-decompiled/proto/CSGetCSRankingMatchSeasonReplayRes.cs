using System.Collections.Generic;

namespace proto;

public class CSGetCSRankingMatchSeasonReplayRes
{
	public uint season_id;

	public uint rank;

	public uint rank_master_level;

	public List<RankingSeasonRankRecord> rank_record;

	public List<RankingSeasonReplayEvent> season_events;

	public List<RankingSeasonFriendStats> season_friends;

	public AccountInfoWithTCStats cs_ranking_stats;

	public List<RankingSeasonWeaponStats> season_weapons;

	public List<RankingSeasonRecommendFriend> recommend_friends;

	public List<RankingSeasonLeaderboardInfo> leaderboards;

	public List<WeaponPowerTitleInfo> weapon_power_titles;

	public List<OccupationHistory> occupations;

	public List<CSPlayerCSRankingSeasonStatsRes> season_stats;

	public uint peak_rank_pos;
}
