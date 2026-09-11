using System.Collections.Generic;

namespace tcp;

public class MatchPregameInfo
{
	public ulong account_id;

	public uint head_pic;

	public string nickname;

	public uint avatar_id;

	public bool has_elite_pass;

	public uint badge_cnt;

	public uint badge_id;

	public List<BattleTagInfo> battle_tags;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint[] cs_heroic_seasons;

	public StatsInfo cs_ranking_stats;

	public AccountPrefersInfo prefers;

	public uint[] skills;

	public uint[] br_heroic_seasons;

	public BRStatsInfo br_ranking_stats;

	public uint br_rank;

	public uint br_ranking_points;

	public uint title_id;

	public LeaderboardTitleInfo leaderboard_titles;

	public string clan_name;

	public List<AccountOccupationData> occupations;

	public bool is_ai;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public uint loading_card;

	public uint loading_card_tag_series_id;

	public ulong group_id;

	public HippoInventoryGSEnterInfo hippo_equip_info;

	public uint[] permanent_weapon_skin_ids;

	public BadgeInfo badge_info;

	public uint role;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint avatar_frame;

	public CSPeakIconicWeaponInfo cs_peak_iconic_weapon_info;

	public CSPeakStatsInfo cs_peak_stats_info;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;

	public uint periodic_summary_level;

	public string Region;
}
