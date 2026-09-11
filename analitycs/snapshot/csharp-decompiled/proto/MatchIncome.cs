using System.Collections.Generic;

namespace proto;

public class MatchIncome
{
	public uint exp;

	public uint coins;

	public uint rank_points;

	public uint kill_points;

	public uint damage_points;

	public uint level_before;

	public uint level_after;

	public uint exp_before;

	public uint exp_after;

	public uint coins_before;

	public uint coins_after;

	public uint coins_gained_today;

	public uint coins_gain_limit;

	public int mmr_delta;

	public int ranking_points_delta;

	public int ranking_points_before;

	public int ranking_points_after;

	public AwardData level_rewards;

	public uint daily_reward_exp;

	public uint daily_reward_coins;

	public uint rank_before;

	public uint rank_after;

	public bool has_rank_upgrade_rewards;

	public bool is_rank;

	public bool is_logout_match;

	public uint honor_point_delta;

	public List<GameDrop> game_drops;

	public bool is_loss_prevented;

	public uint coin_limit_event_bonus;

	public RankingPointsDetail ranking_points_detail;

	public uint race_point_delta;

	public uint ranking_token_id;

	public uint ranking_token_delta;

	public uint ranking_token_num;

	public CoinsDetail coins_detail;

	public ExpDetail exp_detail;

	public PetExpDetail pet_exp_detail;

	public List<IngameItem> ingame_items;

	public uint ranking_token_max;

	public bool is_double_ranking_point_activity;

	public bool is_double_token_activity;

	public uint double_ranking_point_card_id;

	public uint chip_num;

	public uint no_deduct_card_id;

	public bool is_championship;

	public uint[] linkage_award_ids;

	public bool is_cs_rank;

	public bool is_cs_rank_protect;

	public bool is_cs_streak_bonus;

	public float random_map_rp_param;

	public uint pre_cs_star_protect_points;

	public uint cur_cs_star_protect_points;

	public bool is_cs_star_protect;

	public uint pre_br_heroic_count;

	public uint after_br_heroic_count;

	public uint pre_cs_heroic_count;

	public uint after_cs_heroic_count;

	public bool is_periodic_rank;

	public bool is_periodic_rank_protect;

	public bool is_periodic_streak_bonus;

	public uint pre_periodic_ranking_protect_points;

	public uint cur_periodic_ranking_protect_points;

	public bool is_periodic_ranking_protect;

	public bool is_anti_hack_protect;

	public uint cs_protect_compensation_points;

	public AwardData ranking_task_award;

	public TeamUpTokenDetail team_up_token_detail;

	public float br_multi_map_buff_ratio;

	public float cs_multi_map_buff_ratio;

	public uint cs_delta_points_before_multi_map_buff;

	public bool map_rp_protect;

	public bool map_rp_protect_task;

	public uint protect_points_add_stars;

	public uint cs_task_protect_points;

	public bool is_cs_special_mode_protect;

	public uint cs_special_mode_protect_times;

	public bool is_battle_points_rank_upgrade;

	public VeteranRankProtectInfo vrp_info;

	public bool vrp_effect;

	public uint protection_battle_points;

	public uint pre_max_rank;

	public uint rank_sort_after;

	public uint clan_bonus_ranking_card_id;

	public bool has_first_rank_rewards;

	public uint pre_battle_points;

	public uint cur_battle_points;

	public GuildWarDetail guild_war_detail;

	public uint clan_match_activeness_delta;

	public TeamUpTokenDetail team_up_clan_activeness_detail;

	public ExchangeChangeData exchange_data;

	public ExchangeChangeData ranking_task_exchange_data;

	public int clan_ranking_card_award_protect_points;

	public bool first_reach;

	public uint cs_ranking_draw_protect_points;

	public uint cs_special_task_id;

	public uint cs_special_task_protect_points;

	public uint br_special_task_id;

	public bool behavior_ban_drop;

	public RankingCreditPunish ranking_credit_punish;

	public bool credit_score_reduce;

	public uint win_pass_progress;

	public bool br_ranking_is_streak_pos_rp;

	public List<IngameDropItemInfo> ingame_drop_info;

	public uint cs_multi_mode_protect_points;

	public float br_multi_mode_bonus_ratio;

	public List<ExchangedAward> level_exchanged_awards;

	public uint spectate_reward_coins;

	public bool is_hippo_crisis_rank;

	public HippoRankingPointsDetail hippo_ranking_points_detail;

	public bool is_hippo_crisis_tutorial;

	public uint cs_supreme_sword_king_kill_asst_protect_points;

	public bool is_pre_toxic_check_success;

	public bool is_cs_peak_rank;

	public int cs_peak_energy_before;

	public int cs_peak_energy_after;

	public bool first_frozen_peak_energy;

	public uint consumed_peak_energy;

	public uint ranking_point_bonus_card_id;

	public int cs_peak_detected_behavior_penalty;

	public int cs_peak_teammate_behavior_compensation;

	public int d_dos_compensation_points;

	public uint cs_peak_mvp_bonus;

	public uint cs_peak_daily_task_bonus;

	public bool is_daily_exp_limit_exceeded;

	public uint ranking_streak_gold;

	public uint ranking_streak_silver;

	public bool is_gold_medal_quick_upgrade;

	public bool is_silver_medal_quick_upgrade;

	public uint gold_medals_needed_to_upgrade;

	public uint silver_medals_needed_to_upgrade;

	public bool teaming_isolation_triggered;

	public int teaming_discount_points;

	public bool teaming_star_suppressed;
}
