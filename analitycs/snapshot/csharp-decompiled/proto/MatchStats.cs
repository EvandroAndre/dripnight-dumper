using System.Collections.Generic;

namespace proto;

public class MatchStats
{
	public ulong account_id;

	public ulong group_id;

	public uint survival_time;

	public uint rank;

	public uint kills;

	public uint damage;

	public uint moving_distance;

	public uint revival_count;

	public uint vehicle_kills;

	public uint headshot_count;

	public uint headshot_kills;

	public uint knockdown_count;

	public uint pickup_count;

	public uint assists;

	public bool is_survive;

	public uint out_index;

	public int ranking_points;

	public MatchPlayer killer;

	public List<MatchPlayer> killed_players;

	public uint down_count;

	public uint[] achievements;

	public uint kill_bots;

	public bool enable_achievements;

	public uint avatar_id;

	public List<TeammateStats> teammates;

	public int avg_ranking_points;

	public uint fratricide_damage;

	public uint direct_kills;

	public uint group_mode;

	public uint match_mode;

	public uint player_count;

	public uint banner_id;

	public uint head_pic;

	public string clan_name;

	public uint level;

	public uint season_rank;

	public uint game_mode;

	public uint map_id;

	public bool has_elite_pass;

	public uint badge_id;

	public uint badge_cnt;

	public uint[] clothes_id;

	public uint ep_goldlimit_bonus;

	public uint liked;

	public uint real_player_rank;

	public uint real_player_count;

	public bool show_rank;

	public List<RedEnvelope> use_red_envelope;

	public List<ReceivedRedEnvelope> received_red_envelope;

	public uint pet_id;

	public string pet_name;

	public List<Item> ingame_items;

	public uint difficulty;

	public uint ai_type;

	public uint pve_primary_weapon_skin;

	public uint pet_skin_id;

	public ReviveTokenUsed used_revive_tokens;

	public uint hack_reason;

	public bool sit_on_throne;

	public WarmGameInfo warm_game;

	public uint role;

	public uint championship_type;

	public LinkageInfo linkage_info;

	public uint revenge_success_times;

	public uint game_round;

	public uint[] teams_game_point;

	public List<TeammateStats> opponents;

	public EAuth.ClientUsingVersion using_version;

	public uint real_damage;

	public uint settle_bomb;

	public uint remove_bomb;

	public uint deaths;

	public uint mvp_count;

	public uint double_kills;

	public uint triple_kills;

	public uint four_kills;

	public uint newbie_choice;

	public uint pin_id;

	public uint cs_ranking_hang_ups;

	public uint random_map_cnt;

	public int cs_star_protect_points;

	public uint hacker_tag;

	public uint banned_duration;

	public bool online_cs_rank_settle;

	public uint battle_time;

	public uint society_time;

	public bool is_cs_rank_draw;

	public uint num_kill_smaller_than_1m;

	public uint num_kill_smaller_than_2m;

	public uint num_kill_greater_than_10m;

	public uint num_kill_greater_than_50m;

	public uint num_kill_greater_than_100m;

	public uint num_kill_greater_than_500m;

	public uint num_different_weapon_kill;

	public uint num_kill_better_rank_player;

	public uint avg_kill_rest_hp;

	public uint total_shot;

	public bool has_swum;

	public uint grenade_use;

	public uint kill_swimming_count;

	public uint medkit_use;

	public uint mushroom_recovery;

	public uint mushroom_use;

	public uint ob_count;

	public uint offline_seconds;

	public uint offline_times;

	public uint vehicle_time;

	public uint strop_use_count;

	public float aim_rot_speed;

	public float auto_aim_count;

	public GainedTrainingToken gained_training_token;

	public uint[] kills_distance;

	public string group_name;

	public uint group_icon;

	public uint[] battle_tags;

	public uint restore_count;

	public uint be_restored_count;

	public uint in_videozone_time;

	public uint cup_type;

	public WerewolvesInfo werewolves_info;

	public ulong pre_group_id;

	public int periodic_ranking_protect_points;

	public uint finish_chess_time;

	public uint finish_chess_num;

	public uint total_chess_num;

	public UGCMatchStats ugc_matchstats;

	public uint killed_npc_num;

	public uint damage_include_overflow;

	public uint hurts_include_overflow;

	public uint win_rounds;

	public uint healing_amount;

	public uint resurrect_teammate_count;

	public List<CreditPunishInfo> credit_punish_info;

	public uint ingame_level;

	public MatchPlayer knockdowner;

	public uint cs_protect_compensation_points;

	public uint player_proficiency_type;

	public uint kill_ai;

	public uint match_start_buff_id;

	public string map_name;

	public uint heal_teammate_amount;

	public uint veteran_leave_days_tag;

	public uint streak_wins;

	public uint cs_ladder_protection_rank_dvalue;

	public uint periodic_ladder_protection_rank_dvalue;

	public bool online_periodic_rank_settle;

	public bool multi_map_buff_bonus;

	public uint[] match_event_achievements;

	public uint[] avatar_skill_ids;

	public uint cs_battle_protect_points;

	public uint cs_mvp_protect_points;

	public uint cs_revive_and_heal_protect_points;

	public uint cs_streak_win_protect_points;

	public uint periodic_battle_protect_points;

	public uint periodic_mvp_protect_points;

	public uint periodic_revive_and_heal_protect_points;

	public bool is_ingame_join;

	public uint game_past_time;

	public uint cs_multi_map_protect_points;

	public MetropolisMatchStats metropolis_match_stats;

	public GainedMetropolisToken gained_metropolis_token;

	public uint special_mode_event_id;

	public bool veteran_force_bot;

	public bool veteran_force_bot_player;

	public ulong real_match_id;

	public bool veteran_social_match;

	public List<MatchEventAchievementArgs> match_event_achievement_args;

	public bool is_social_player;

	public bool is_ugc_free_quit;

	public int cs_negative_behavior_protect_points;

	public uint title_id;

	public PveReviveTokenUsed pve_revive_token_used;

	public List<PveBuffTokenUsed> pve_buff_token_used;

	public uint season_rank_sort;

	public uint open_lock_air_drop_number;

	public uint vault_open;

	public uint special_mode_config_id;

	public uint team_count_with_bot;

	public uint team_count_without_bot;

	public bool enable_halfway_join;

	public List<MatchStatsShieldDamage> shield_damage;

	public uint first_stop_parachuting_time;

	public ulong clan_id;

	public uint bot_knockdown_count;

	public uint bot_direct_kills;

	public uint bot_game_type;

	public uint king_and_clown_behavior;

	public EStats.CSRankingDrawType cs_ranking_draw_type;

	public uint ingame_rank_percentage;

	public int receive_protect_points;

	public int healing_protect_points;

	public int cooperate_protect_points;

	public uint cyber_mushroom_use;

	public uint cs_special_mode_protection_points;

	public MonsterInvasionInfo monster_invasion_info;

	public uint[] personal_medals;

	public uint[] group_medals;

	public MatchTag match_tag;

	public uint team_ace;

	public uint pve_score;

	public bool cs_loser_protect_star;

	public bool cs_loser_add_star;

	public uint cs_long_game_protect_points;

	public uint cs_medal_protect_points;

	public ShortWorkshopCodeInfo short_workshop_code_info;

	public uint knockdown_real_damage;

	public List<BooyahDay24BDimensionInfo> dimension_infos;

	public List<SpectatorInteractionInfo> spectator_interaction_info;

	public uint cs_constant_goods_id;

	public MultiModeInfo multi_mode_info;

	public int hippo_crisis_delta_price;

	public uint hippo_crisis_bring_in;

	public uint hippo_crisis_loss;

	public uint hippo_crisis_bring_out;

	public List<ItemCollect> hippo_crisis_items;

	public uint hippo_crisis_pre_equipment_value;

	public uint hippo_crisis_cur_equipment_value;

	public uint hippo_crisis_born_area_id;

	public uint hippo_crisis_kill_pve_bots;

	public uint bot_damage;

	public uint ai_damage;

	public uint cs_eighth_gp_protect_points;

	public uint br_supreme_sword_king_kill_num;

	public uint br_supreme_sword_team_kill_king_num;

	public uint cs_supreme_sword_king_kill_asst_num;

	public List<BriefClanInfo> guild_war_clan_info;

	public float cs_ranking_rating_point;

	public float player_percentile;

	public uint buy_hitlist_count;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint hit_count;

	public float cs_peak_rating;

	public uint match_result_poster_weapon_id;

	public uint match_result_poster_comments_id;

	public uint match_result_poster_weapon_skin_id;

	public uint avatar_frame;

	public bool is_d_dos;

	public float br_ranking_rating_point;

	public uint flame25b_progress;

	public uint flame25b_level;

	public bool is_ai;

	public uint cs_peak_points;

	public uint coin_gained_ingame;

	public ERanking.RankingMedalType br_ranking_medal_type;

	public ERanking.RankingMedalType cs_ranking_medal_type;

	public bool is_emulator;

	public List<MatchPlayer> attackers;

	public uint room_type;

	public ulong room_creator_id;

	public bool is_friend_half_join;
}
