using System.Collections.Generic;

namespace proto;

public class TeammateStats
{
	public ulong account_id;

	public string nickname;

	public uint kills;

	public uint avatar_id;

	public uint banner_id;

	public uint head_pic;

	public string clan_name;

	public uint season_rank;

	public uint level;

	public bool has_elite_pass;

	public uint badge_id;

	public uint badge_cnt;

	public bool show_rank;

	public string lock_region;

	public uint pve_damage;

	public uint pve_primary_weapon_skin;

	public uint role;

	public uint damage;

	public uint deads;

	public uint score;

	public uint assists;

	public uint rank;

	public uint settle_bomb;

	public uint remove_bomb;

	public uint[] big_head_level_and_count;

	public uint token_pick_count;

	public uint escort_time;

	public uint on_zone_time;

	public uint buff_trigger_count;

	public uint pin_id;

	public uint team_score;

	public uint headshot_kills;

	public uint hp_used_count;

	public uint survival_time;

	public string group_name;

	public uint group_icon;

	public uint[] battle_tags;

	public uint liked;

	public uint relation_mask;

	public uint finish_chess_time;

	public uint finish_chess_num;

	public uint total_chess_num;

	public uint peak_rank_pos;

	public uint killed_npc_num;

	public uint knockdown_count;

	public uint healing_amount;

	public uint revival_count;

	public uint resurrect_teammate_count;

	public uint ingame_level;

	public uint infection_score;

	public uint avatar_transform;

	public uint kill_streak_count;

	public uint battle_points;

	public uint veteran_leave_days_tag;

	public uint player_proficiency_type;

	public uint streak_wins;

	public FootballDetail football_detail;

	public uint[] skill_ids;

	public ulong real_group_id;

	public List<CriticalBehaviorInfo> critical_behaviors;

	public uint team_index;

	public uint[] pve_avatar_attributes;

	public uint[] match_event_achievements;

	public bool be_restored;

	public List<MatchEventAchievementArgs> match_event_achievement_args;

	public bool is_social_player;

	public List<CriticalBehaviorInfo> liked_critical_behaviors;

	public bool is_logout;

	public TeammateInteractionDetail interaction_detail;

	public uint title_id;

	public uint perm_shield_damage;

	public uint temp_shield_damage;

	public BotDetail bot_detail;

	public uint[] personal_medals;

	public uint ranking_points;

	public bool cs_loser_protect_star;

	public bool cs_loser_add_star;

	public bool is_pre_toxic_check_success;

	public int hippo_crisis_bring_in;

	public int hippo_crisis_loss;

	public int hippo_crisis_bring_out;

	public BadgeInfo badge_info;

	public bool membership_privilege;

	public PrimePrivilegeDetail prime_privilege_detail;

	public float cs_ranking_rating_point;

	public bool is_team_mvp;

	public uint knockdown_real_damage;

	public uint buy_hitlist_count;

	public uint[] detected_behaviors;

	public uint cs_peak_points;

	public float cs_peak_rating_point;

	public string client_version;

	public uint avatar_frame;

	public List<InGameReport> reports_from_others;

	public float br_ranking_rating_point;

	public float player_percentile;

	public uint using_version;
}
