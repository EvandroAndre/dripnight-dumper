using System.Collections.Generic;

namespace tcp;

public class AccountMatchInfo
{
	public ulong account_id;

	public string nickname;

	public string lock_region;

	public uint level;

	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public List<LoadoutInfo> loadouts;

	public uint banner_id;

	public uint head_pic;

	public uint[] slots;

	public uint[] skills;

	public string clan_name;

	public List<MMRInfo> mmr_info;

	public uint rank;

	public uint ranking_points;

	public uint role;

	public bool has_elite_pass;

	public uint badge_cnt;

	public uint badge_id;

	public uint ep_goldlimit_bonus;

	public List<RoomCardInfo> room_cards;

	public bool show_rank;

	public List<EmoteInfo> emotes;

	public List<RedEnvelopeInfo> red_envelopes;

	public uint[] shows;

	public PetInfo pet_info;

	public uint pve_primary_weapon_skin;

	public List<ReviveTokenInfo> revive_tokens;

	public WalletInfo wallet;

	public uint platform_type;

	public ChipInfo chips;

	public WarmGameInfo warm_game;

	public AccountAntiAddictionInfo anti_addiction_info;

	public ChampionshipInfo championship_info;

	public LinkageInfo linkage_info;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint pin_id;

	public bool is_cs_ranking_ban;

	public bool is_trial_avatar;

	public AccountHackerTagInfo hacker_tag;

	public long create_at;

	public TrainingTokenInfo training_token_info;

	public uint ranking_bot_points;

	public List<IntimacyRelation> intimacy_relation_info;

	public string mem_value;

	public WorkshopInfo workshop;

	public CupMatchInfo cup_match_info;

	public uint game_bag_show;

	public List<IngameItem> ingame_items;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public uint clan_badge;

	public StatsInfo cs_ranking_stats;

	public uint[] cs_heroic_seasons;

	public List<BattleTagInfo> battle_tags;

	public AccountPrefersInfo prefers_info;

	public ulong clan_id;

	public uint periodic_rank;

	public uint periodic_ranking_points;

	public MaxLobbyDisplayInfo max_lobby_display_info;

	public uint cs_ranking_bot_points;

	public List<CreditPunishInfo> credit_punish_info;

	public List<AccountMatchBanInfo> match_ban_info;

	public uint cs_ranking_battle_points;

	public List<RandomSlotInfo> random_slots;

	public uint cs_ranking_streak_wins;

	public WorkshopRoomFreeInfo workshop_room_free_info;

	public uint credit_score;

	public uint cs_ranking_actual_battle_points;

	public uint[] clothes_tailor_effects;

	public AccountPVEInfo pve_info;

	public uint[] user_tags;

	public bool use_battle_points;

	public WorkshopTagMatchInfo workshop_tag_match_info;

	public uint periodic_ranking_bot_points;

	public BRStatsInfo br_ranking_stats;

	public uint[] br_heroic_seasons;

	public uint[] buddy_shared_skills;

	public uint ranking_streak_wins;

	public List<WeaponSkinStat> wp_skin_stat;

	public uint title;

	public bool is_sixthb_distributor;

	public ExternalIconInfo external_icon_info;

	public MetropolisInfo metropolis_info;

	public MetropolisTokenInfo metropolis_token_info;

	public uint ranking_max_rank;

	public uint cs_ranking_max_rank;

	public AccountMatchVeteranData veteran_data;

	public PVEReviveTokenInfo pve_revive_token_info;

	public List<PVEBuffTokenInfo> pve_buff_token_info;

	public uint rank_sort;

	public uint cs_rank_sort;

	public uint ranking_max_rank_sort;

	public uint cs_ranking_max_rank_sort;

	public List<PVESlotInfo> pve_slots;

	public LeaderboardTitleInfo leaderboard_titles;

	public uint last_round_guild_war_point;

	public uint current_round_guild_war_point;

	public uint[] collection_actions;

	public QuickMsgSettings quick_msg_settings;

	public uint battle_point_lower;

	public uint battle_point_upper;

	public uint[] collection_skill_skins;

	public int cs_streak_result_total;

	public uint clan_frame_id;

	public string clan_custom_badge;

	public bool use_clan_custom_badge;

	public List<GuildWarLeaderboardInfo> guild_war_leaderboard_info;

	public uint clan_level;

	public uint total_guild_war_point;

	public uint season_id;

	public uint cs_season_id;

	public uint periodic_season_id;

	public uint ranking_mmr;

	public uint load_out_v2;

	public uint cs_ranking_mmr;

	public MatchTag match_tag;

	public RankingFixedMMRInfo ranking_fixed_mmr_info;

	public byte[] mocha_bot_points_kv;

	public uint monster_invasion_boss_progress;

	public uint monster_invasion_slay_dragon_cnt;

	public List<AccountOccupationData> occupations;

	public List<SocialHighLight> social_high_lights;

	public bool is_dragon_fight;

	public int ranking_streak_result_total;

	public uint[] selected_final_shots;

	public List<WeaponSkinCustom> weapon_skin_customs;

	public ulong[] matchmaking_blacklist;

	public CSRankingFixedMMRInfo cs_ranking_fixed_mmr_info;

	public bool is_seventhb_distributor;

	public uint rank_group;

	public uint cs_rank_group;

	public uint cs_rank_stars;

	public uint cs_star_protect_points;

	public uint cs_star_protect_extra_score;

	public bool have_protect_card;

	public bool cs_have_protect_card;

	public bool have_full_pre_group_protect;

	public bool cs_have_full_pre_group_protect;

	public bool possible_upgrade_rank_group;

	public bool possible_upgrade_rank;

	public bool cs_possible_upgrade_rank_group;

	public bool cs_possible_upgrade_rank;

	public uint br_latest_max_rank;

	public uint cs_latest_max_rank;

	public CasualMatchTag casual_match_tag;

	public CasualMatchStats casual_match_stats;

	public uint seventhb_discount_weapon_id;

	public string booyahday24b_dimension_title;

	public RankingWarmMatchInfo ranking_warm_match_info;

	public CSRankingWarmMatchInfo cs_ranking_warm_match_info;

	public GlooWorldAccountInfo gloo_world_info;

	public AIStatsTotalInfo ai_stats_total_info;

	public uint clan_weekly_activeness;

	public bool is_guild_war_open;

	public uint selected_super_emote;

	public WorkshopVipInfoAndBenefit workshop_vip_and_benefit;

	public uint selected_loading_card;

	public uint newbie_choice;

	public uint periodic_summary_level;

	public long room_afk_punish_end_time;

	public List<ItemTagInfo> item_tag_info;

	public HippoInventoryGSEnterInfo hippo_equip_info;

	public List<GuildWarLeaderboardInfo> cur_guild_war_leaderboard_info;

	public uint hippo_rank;

	public uint hippo_ranking_points;

	public uint hippo_ranking_bot_points;

	public uint hippo_ranking_max_rank;

	public uint hippo_ranking_mmr;

	public uint hippo_rank_group;

	public uint hippo_season_id;

	public HippoRankingFixedMMRInfo hippo_ranking_fixed_mmr_info;

	public HippoStatsInfo hippo_ranking_stats;

	public HippoRankingWarmMatchInfo hippo_ranking_warm_match_info;

	public uint guild_war_tc_wins;

	public uint guild_war_tc_losses;

	public uint guild_war_tc_participation_limit;

	public bool is_tournament_qualified;

	public uint[] permanent_weapon_skin_ids;

	public uint cur_day_spec_reward_cnt;

	public long cur_day_spec_reward_cnt_time;

	public List<RankingStatsSummary> ranking_stats_summary;

	public bool guild_war_banned;

	public bool guild_tournament_banned;

	public uint current_round_tournament_point;

	public uint total_tournament_point;

	public List<GuildWarLeaderboardInfo> tournament_leaderboard_info;

	public EighthBApplyDecorationInfo eighthb_apply_decoration_info;

	public bool is_eighthb_distributor;

	public List<ModeStatsFullInfo> mode_stats_infos;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint prime_sharee_remain_times;

	public bool is_wearing_shared_set;

	public SharedSetInfo shared_set;

	public List<RandomSkinInfo> random_skins;

	public List<CreditPunishOtherInfo> credit_punish_other_info;

	public uint cs_peak_points;

	public List<SF50BCareerInfo> career_infos;

	public uint fixed_career_id;

	public bool display_cs_peak_point;

	public uint avatar_frame;

	public uint cs_peak_streak_wins;

	public Flame25BLoadingCardInfo loading_card_info;

	public CSPeakIconicWeaponInfo cs_peak_iconic_weapon_info;

	public uint br_last_season_ranking_points;

	public uint cs_last_season_ranking_points;

	public CSPeakStatsInfo cs_peak_stats_info;

	public List<WorkshopTokenInfo> workshop_token_infos;

	public uint selected_finish_move;

	public AntiAddictionAgeAuthInfo br_auth_info;

	public GuardianTextChatSetting text_chat_setting;

	public GuardianVoiceChatSetting voice_chat_setting;

	public List<GameModeStats> game_mode_stats_infos;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;

	public List<LoadoutInfo> all_loadouts;

	public List<BriefPresetSchema> preset_schemas;

	public List<PrepareMatchSkillInfo> all_skills;

	public List<PetSkillInfo> all_pet_skills;

	public List<PetInfo> all_pets;

	public AccountEmulatorTagInfo emulator_tag_info;

	public SocialHallInfo socialhall_info;

	public uint cs_ranking_games_played;

	public List<RoomWinStats> room_win_stats;
}
