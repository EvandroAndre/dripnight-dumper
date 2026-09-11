using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class LoginDescRes : IMessage
{
	public CSGetAdvertRes advert_res;

	public CSGetAllSwitchsRes switchs_res;

	public CSGetActivityDescRes activity_res;

	public CSGetGachaDescRes gacha_res;

	public CSGetCurrentOrRecentRankingSeasonConfigRes ranking_res;

	public CSGetHideAvatarRes hide_res;

	public CSGetTreasureBoxRes treasure_res;

	public CSGetBundleRes bundle_res;

	public CSGetGiftStoreRes gift_store_res;

	public RankingMatchParam ranking_match_param;

	public GetRankingItemRankConfigRes ranking_item_rank;

	public CSGetDiscountStoreDescRes discount_store_res;

	public CSGetRankingActivityConfigRes ranking_activity_config_res;

	public CSGetGoogleRewardsDescRes google_rewards_desc;

	public CSGetFullscreenCgRes fullscreen_cg_res;

	public CSGetGameBonusEventDescRes game_bonus_event_res;

	public CSChampionshipBasicInfoRes championship_basic_info_res;

	public CSGetStoreTabRes store_tab_res;

	public CSGetFullscreenItemRes fullscreen_item_res;

	public CSGetAvatarAwakenRes avatar_awaken_res;

	public DiamondCostRes diamond_cost_res;

	public CSGetIPTagConfigRes ip_tag_config_res;

	public CSGetCurrentOrRecentCSRankingSeasonConfigRes cs_ranking_res;

	public CSGetGoPosRes gopos_res;

	public CSGetMysteryExpressionRes mystery_expression_res;

	public CSGetExchangeCurrencyAllDescRes exchange_currency_all_res;

	public CSGetPayLevelConfigRes pay_level_config_res;

	public CSGetRoleDebrisDescRes role_debris_desc;

	public GetOppositeSexModelRes opposite_sex_model_res;

	public long weapon_skin_system_time;

	public CSGetRateAppSwitchRes rate_app_switch_res;

	public CSGetLiveDescRes live_desc_res;

	public CSGetAndroidApplicationToDetectRes android_apps_to_detect_res;

	public CSGetOptionalBundleRes optional_bundle_res;

	public CSGetExchangeCurrencyLocalRes exchange_currency_local;

	public CSClanLuckyBagInfoDescRes clan_lucky_bag_info;

	public CSGetUniversalLinkSettingRes universal_link_setting_res;

	public CSShareSettingDescRes share_setting_desc;

	public CSGetAllFriendDescRes friend_desc;

	public CSSkinTimelineDescRes skin_timeline_res;

	public CSQuitControlDescRes quit_control_desc;

	public GetPatchOptionalResManagerUpdateRes patch_optional_res_manager_update_res;

	public CSGetPreviewWebDescRes preview_web_desc;

	public CSGetChatWebWhiteListRes chat_web_white_list_res;

	public CSGetFullscreenABTestRes fullscreen_ab_test_res;

	public CSGetTeamingRankRuleDescRes teaming_rank_rule_desc;

	public List<BonusCardDesc> bonus_cards;

	public CSGetWeaponPermanentRes weapon_permanent_res;

	public List<RankingCardDesc> ranking_card_descs;

	public List<CSRankingCardDesc> cs_ranking_card_descs;

	public CSGetCustomerReportRes customer_report_res;

	public CSAntiHackCenterDescRes anti_hack_center_desc;

	public List<WeaponExpLevelDesc> weapon_exp_level_desc;

	public BuddySkillSettingDesc buddy_skill_setting;

	public List<ReleaseVersion> release_version_list;

	public CSGameCloseInfoDescRes game_close_info;

	public List<ItemNumLimitDesc> item_num_limit_descs;

	public CSWebViewSettingDescRes web_view_setting_desc;

	public CSNewModeBubbleDescRes new_mode_bubble_descs;

	public List<PrivilegeConfigDesc> privilege_config;

	public List<AvatarProficiencyRewardDesc> avatar_proficiency_reward_descs;

	public List<AvatarProficiencyLevelDesc> avatar_proficiency_level_descs;

	public List<RandomSkinSwitchDesc> random_skin_switches;

	public CSGetShoppingMallScreenRes shopping_mall_screen_res;

	public CSGetRevenueEntranceShowDescRes revenue_entrance_show_res;

	public List<VeteranRankBuffTimeDesc> veteran_rank_buff_time_desc;

	public uint coins_limit_out_game_weekly;

	public CSGetIAPStoreDescRes iap_store_desc;

	public List<GameplayFeedbackDesc> gameplay_feedback_descs;

	public List<ClanActivenessAwardDesc> clan_activeness_award;

	public CSGetSeasonYearDescRes season_year_desc;

	public CSGuildWarBasicInfoRes guild_war_basic_info;

	public List<ClanActiveShowDesc> clan_active_show;

	public CSGetNewPlayerSurveyEntranceDescRes new_player_survey_entrance_desc;

	public List<AvatarJumpDesc> avatar_jump_descs;

	public List<InGameQuickChatItemDesc> in_game_quick_chat_items;

	public InventorySwitchDesc inventory_switch_desc;

	public CSGetMatchmakingTipsNewDescRes matchmaking_tips_new_desc;

	public WishSettingDesc wish_setting_desc;

	public CSGetGameplayAffixDescRes gameplay_affix_desc;

	public List<NewTeamLabelDesc> new_team_label_descs;

	public RecruitVarDesc recruit_var_desc;

	public CSAccountCenterDescRes acct_center_desc;

	public List<SpectateRankLimitDesc> spectate_rank_limit_descs;

	public CSGetOccupationDescRes occupation_desc;

	public List<LocalEventEntranceDesc> local_event_entrance_descs;

	public uint warn_window_min_ping;

	public List<HelperMessageDesc> helper_message_descs;

	public List<WorkshopFriendStatesSwitchDesc> friend_states_switch_desc;

	public List<profileModuleSwitchDesc> profile_module_switch_res;

	public List<GamePatternConfigDesc> game_pattern_configs;

	public NewbieBundleDesc newbie_bundle_config;

	public bool awaken_switch;

	public uint[] wish_hot_items;

	public List<OgTagConfigDesc> og_tag_config_descs;

	public bool login_desc_get_account_switch;

	public List<OgTagItemDesc> og_tag_item_descs;

	public List<SpectateCurrencyRewardDesc> spectate_currency_rewards;

	public SpectateCurrencySettingDesc spectate_currency_setting;

	public List<NewPlayerUnlockFeatureDesc> new_player_unlock_feature_desc;

	public List<AppIconRegionDesc> app_icon_region_desc;

	public uint winter_land_24b_weather_id;

	public List<RebateCardDesc> rebate_card_descs;

	public ClanDiamondAwardSettingDesc clan_diamond_award_setting;

	public CSGetHippoInventoryBaseDescRes hippo_inventory_desc;

	public CSGetCurrentOrRecentHippoRankingSeasonConfigRes hippo_ranking_desc;

	public RankingTipsABTestDesc ranking_tips_ab_test_desc;

	public uint[] create_25b_building_ids;

	public ReturnPlayerConfigDesc return_player_config_desc;

	public List<TeamUpRecommendConfigDesc> team_up_recommend_config_desc;

	public List<AIAssistantSuggestedQuestionsTableDesc> ai_assistant_suggested_questions_desc;

	public List<LoadoutModePresetCorrelationDesc> loadout_mode_preset_correlation_list;

	public List<GroupPhotoTemplateDesc> group_photo_template_desc;

	public List<PhotoFrameConfigDesc> photo_frame_config_desc;

	public List<StickerConfigDesc> sticker_config_desc;

	public List<MapProtectionDesc> map_protection_descs;

	public CSGetPrimeDescsRes prime_desc;

	public List<TreasureTable> treasure_table_desc;

	public List<InGameBonusDesc> in_game_bonus;

	public List<WebLimitDesc> web_limit_descs;

	public List<SeasonLimitedItemDesc> season_limited_items;

	public CSGetCurrentOrRecentCSPeakSeasonConfigRes cs_peak_desc;

	public List<LeaderboardRankingCdtDesc> leaderboard_ranking_cdt_desc;

	public CSSquadTreasureDescsRes squad_treasure_desc;

	public List<WebExternalBrowserLimit> web_external_browser_limit;

	public GiftStoreCDNDesc gift_store_cdn_desc;

	public List<PhotoDecoretonsConfigDesc> photo_decoretons_config_desc;

	public CSGetCDNSourceUpdateRes cdn_source_update_res;

	public List<GroupPhotoModelSettingDesc> group_photo_model_setting_desc;

	public CSGetRelayMartDescRes relay_mart_desc;

	public List<VoicePackageDesc> voice_package_desc;

	public List<AvatarNewDesc> avatar_new_descs;

	public List<PhotoFilterSettingDesc> photo_filter_setting_desc;

	public List<AgePolicyPreCheckDesc> age_policy_pre_checks;

	public List<FirstTabDesc> first_tab_desc;

	public List<SecondTabDesc> second_tab_desc;

	public List<GroupPhotoTemplateConfigDesc> group_photo_template_config_desc;

	public List<CollectionCustomDesc> collection_custom_descs;

	public CSGetDrawShopDescRes draw_shop_desc;

	public WebViewRegionalSettingsDesc web_view_regional_settings_desc;

	public List<CustomSortIDDesc> custom_sort_id_descs;

	public List<RecommendShowDesc> recommend_show_desc;

	public CSGetTeamingScoreRuleDescRes teaming_score_rule_desc;

	public List<NewHelperParamDesc> new_helper_param_desc;

	public List<EsportsWebLinkDesc> esports_web_link_descs;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
