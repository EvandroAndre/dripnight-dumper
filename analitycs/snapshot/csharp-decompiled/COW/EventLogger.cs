using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using COW.GamePlay;
using COW.Gameplay.UGC;
using COW.Gameplay.UGC.BlockEdit;
using COW.OpSysExt;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

public static class EventLogger
{
	public class EventLoggerBase
	{
		public string region;

		public ulong account_id;
	}

	public class QuickFeedbackAnswerRecord
	{
		public uint QuestionId;

		public uint PreQuestionId;

		public uint OptionType;

		public int AnswerValue;
	}

	public class EventTypeQuickFeedbackQuest : EventLoggerBase
	{
		public uint stage;

		public ulong match_id;

		public uint game_mode;

		public uint match_mode;

		public uint player_type;

		public bool is_filled;

		public List<EventTypeQuickFeedbackQuestInfo> quick_quest_info;
	}

	public class EventTypeQuickFeedbackQuestInfo
	{
		public uint quest_id;

		public uint pre_quest_id;

		public uint option_type;

		public int choice;
	}

	public class EventTypeFightOnInfo : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public ulong match_id;

		public ulong group_id;

		public int team_member_count;

		public bool is_fight_on;

		public int choice;

		public int result;

		public ulong fight_on_group_id;

		public FightOnResult fight_on_result;
	}

	public class FightOnResult
	{
		public int result;

		public int reason;
	}

	public class EventTypeSettlementInvite : EventLoggerBase
	{
		public int account_damage;

		public int account_real_damage;

		public int account_kill_cnt;

		public int account_knockdown_cnt;

		public int account_death_cnt;

		public int account_assist_cnt;

		public int account_relife_cnt;

		public int account_revive_cnt;

		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public ulong match_id;

		public uint map_id;

		public ulong target_id;

		public int target_damage;

		public int target_real_damage;

		public int target_kill_cnt;

		public int target_knockdown_cnt;

		public int target_death_cnt;

		public int target_assist_cnt;

		public int target_relife_cnt;

		public int target_revive_cnt;

		public int op_type;
	}

	public class SettlementInvitePopupKDAInfo
	{
		public int kill;

		public int dmg;

		public int help_up;

		public int assist;
	}

	public class EventTypeSettlementInvitePopup : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public ulong match_id;

		public ulong target_id;

		public int op_type;

		public int team_size;

		public List<SettlementInvitePopupKDAInfo> kda_info;
	}

	public class EventTypeMagicVoiceInit : EventLoggerBase
	{
		public int effect_id;
	}

	public class EventNaviTabViewTime : EventLoggerBase
	{
		public string page_name;

		public List<TabViewInfo> tab_view_infos;
	}

	public class TabViewInfo
	{
		public string tab_name;

		public ulong tab_view_time;
	}

	public static class ClickEntryMatcher
	{
		public static string Name;

		public static Predicate<ClickEntry> MatchClickEntryByNameImpl;

		private static bool MatchClickEntryByName(ClickEntry entry)
		{
			return false;
		}
	}

	public class EventTypeVeteranSplashBanner : EventLoggerBase
	{
		public uint goto_pos;
	}

	public class EventTypeVeteranGamePlayMatchTrigger : EventLoggerBase
	{
		public char process_type;

		public ulong first_match_id;

		public uint first_match_mode;

		public uint first_game_mode;

		public ulong second_match_id;

		public uint second_match_mode;

		public uint second_game_mode;

		public bool if_open_second_game;

		public bool if_cancel_second_matching;

		public void Clear()
		{
		}
	}

	public class EventTypeVeteranGamePlayTrigger : EventLoggerBase
	{
		public char process_type;

		public bool if_pop_banner;

		public bool if_click_play_game;

		public bool if_close_banner;

		public bool if_open_mode_selection_interface;

		public bool if_enter_default_selection;

		public bool if_enter_auto_matching;

		public bool if_choose_mode;

		public bool if_close_mode_selection_interface;

		public bool if_click_start_game;

		public bool if_open_first_game;

		public bool if_cancel_first_matching;

		public bool if_finish_challenge_task;

		public bool if_pop_challenge_page;

		public bool if_award_challenge_task;

		public bool if_pop_first_match_link_page;

		public bool if_pop_award_first_match;

		public bool if_pop_character_skill_bubble;

		public bool if_click_character_skill_bubble;

		public bool character_recommend_equip_success;

		public bool skill_recommend_equip_success;

		public uint choose_match_mode;

		public uint choose_game_mode;

		public void Clear()
		{
		}
	}

	public class EventTypeClipboardFeedback : EventLoggerBase
	{
		public int timing;

		public int process_method;

		public int area;
	}

	public class EventTypeForceTutorialPhaseInfo
	{
		public uint id;

		public float time;
	}

	public class EventTypeForceTutorialEvaluateInfo
	{
		public uint id;

		public float value;

		public float score;
	}

	public class EventTypeForceGuideProcedureInfo : EventLoggerBase
	{
		public List<EventTypeForceTutorialPhaseInfo> phase_infos;

		public List<EventTypeForceTutorialEvaluateInfo> evaluate_infos;

		public uint choice;

		public uint adjust_choice;

		public float total_score;

		public int fail_type;

		public bool in_game;
	}

	public class EventTypeForceGuideEnter : EventLoggerBase
	{
		public uint choice;
	}

	public class EventTypeForceGuideDownloadInfo : EventLoggerBase
	{
		public uint choice;

		public int fail_type;
	}

	public class EventTypeForceGuidePhaseInfo : EventLoggerBase
	{
		public uint phase_id;

		public float phase_time;
	}

	public class EventTypeForceGuideFpsInfo : EventLoggerBase
	{
		public bool if_trigger;

		public bool if_choose;
	}

	public class EventTypeVeteranIntimacyInfo : EventLoggerBase
	{
		public uint leave_days;

		public List<IntimacyInfo> intimacy_info;
	}

	public class ContinuousLikesInfo
	{
		public ulong got_like_account_id;

		public bool is_friend;

		public int type;

		public int reason;

		public int cnt;
	}

	public class IntimacyInfo
	{
		public int rank;

		public bool is_online;

		public int intimacy_value;
	}

	public enum EventTypeReservationChannel
	{
		FrontEndGame,
		InGame
	}

	public enum EventTypeReservationGameType
	{
		Default,
		SceneEditGame,
		InGame
	}

	public class EventTypeReservationSent : EventLoggerBase
	{
		public ulong received_account_id;

		public uint channel;

		public ulong match_id;

		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public bool is_receiver_in_cl_editor;
	}

	public class EventTypeReservationReply : EventLoggerBase
	{
		public ulong send_account_id;

		public bool action;

		public bool if_shield;

		public bool is_timeout;

		public uint channel;

		public ulong match_id;

		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public bool is_receiver_in_cl_editor;
	}

	public class EventTypeReservationConfirm : EventLoggerBase
	{
		public ulong received_account_id;

		public bool if_confirm;
	}

	public class EventTypeReservationResult : EventLoggerBase
	{
		public ulong send_account_id;

		public ulong received_account_id;

		public bool result;

		public uint channel;

		public ulong match_id;

		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public bool is_receiver_in_cl_editor;
	}

	public class EventTypeLimitedEventShare : EventLoggerBase
	{
		public bool share_out;

		public uint platform;

		public uint event_id;

		public uint page_id;

		public uint type;
	}

	public class EventTypeSplashBannerPopup : EventLoggerBase
	{
		public uint id;

		public string network;

		public string network_type_a;

		public string system_software;
	}

	public class EventTypeNewbieSplashBannerPopUp : EventLoggerBase
	{
		public string network;

		public string network_type_a;

		public string system_software;
	}

	public enum EGuildWarSplashBannerType
	{
		TournamentInLobby = 1,
		TournamentInClan
	}

	public class EventTypeGuildWarSplashBannerPopup : EventLoggerBase
	{
		public int position;

		public string network;

		public string network_type_a;

		public string system_software;
	}

	public class EventTypeCloseUpShare : EventLoggerBase
	{
		public bool share_out;

		public uint platform;

		public uint item_id;
	}

	public class EventBannerClickLog : EventLoggerBase
	{
		public uint banner_type;

		public uint banner_id;

		public bool is_effect;

		public uint tag_id;

		public uint sort_id;
	}

	public class EventObserverLog : EventLoggerBase
	{
		public float observer_time;

		public uint switch_count;

		public bool click_close;

		public int group_mode;

		public uint match_mode;

		public uint game_mode;

		public ulong match_id;

		public List<ContinuousLikesInfo> streak_likes;
	}

	public class EventTypeDefaultMusicClick : EventLoggerBase
	{
		public bool click_state;
	}

	public class EventTypeHackClientFix : EventLoggerBase
	{
		public uint fix_type;
	}

	public class EventTypeUGCImportProjectReview : EventLoggerBase
	{
		public new ulong account_id;

		public new string region;

		public uint slot_id;

		public ulong imported_project_uid;

		public bool is_success;

		public int import_reason;

		public int scene_id;
	}

	public class EventTypeDigitalUniverseConcertStats : EventLoggerBase
	{
		public class MiniGameInfo
		{
			public int type;

			public int sub_type;
		}

		public bool is_drop;

		public readonly List<MiniGameInfo> game_infos;
	}

	public class EventTypeVeteranTagMatchStats : EventLoggerBase
	{
		public uint main_group_id;

		public uint[] sub_group_ids;

		public uint[] barrage_type;

		public uint is_group_highlight;

		public uint player_choice;

		public uint mode_trend_tag;

		public bool pre_group_tag;

		public string real_mode;
	}

	public class EventTypeVeteranNewHotTagTrigger : EventLoggerBase
	{
		public uint game_mode;

		public string tag;

		public int type;
	}

	public class EventLogPageDetentionTimeCached : EventLoggerBase
	{
		public List<EventLogPageDetentionTimeItem> views;
	}

	public class EventLogPageDetentionTimeItem
	{
		public string page_name;

		public int view_time;

		public int cnt;
	}

	public class EventPageDetentionTime : EventLoggerBase
	{
		public string page_name;

		public int view_time;
	}

	public class EventTypeTrainingCenterStage : EventLoggerBase
	{
		public int id;

		public int sort_id;

		public int tag;

		public int tabs;

		public int pre_process;
	}

	public class EventProfilePageViewTime : EventPageDetentionTime
	{
		public ulong viewed_id;
	}

	public class EventIOSIDFA : EventLoggerBase
	{
		public string open_id;

		public string idfa;
	}

	public class EventGroupInvite : EventLoggerBase
	{
		public ulong inviter;

		public ulong invitee;
	}

	public class EventTypeRecommendGroupInvite : EventLoggerBase
	{
		public ulong invitee;

		public ulong inviter;

		public new string region;

		public uint[] recommend_reason;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public ulong match_id;

		public ulong inviter_group_id;

		public uint group_type;

		public uint group_size;

		public uint result;
	}

	public class EventTypeGroupInviteWithinClient : EventGroupInvite
	{
		public uint channel;

		public uint invitee_type;

		public ulong group_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint[] map_ids;

		public uint group_type;

		public uint group_size;

		public uint result;
	}

	public class EventSplashBannerGoto : EventLoggerBase
	{
		public uint id;

		public uint goto_pos;

		public string goto_url;
	}

	public class EventNewBieSplashBannerGoto : EventLoggerBase
	{
		public uint goto_pos;
	}

	public class EventSplashBannerPush : EventLoggerBase
	{
		public bool state;

		public uint entry_id;

		public uint event_id;
	}

	public class EventTemplateSplashBannerPush : EventLoggerBase
	{
		public bool state;

		public uint entry_id;

		public uint event_id;
	}

	public class EventWaitingForMatchmaking_RuntimeData
	{
		public float TimeStart;

		public uint GroupMode;
	}

	public class EventReturnLobbyAfterDeath_RuntimeData
	{
		public float TimeDeath;
	}

	public class EventOpOnBag_RuntimeData
	{
		public float TimePickup;

		public uint PickupItemDataID;
	}

	public class EventLogBRTutorialLobbyGuide : EventLoggerBase
	{
		public bool if_force;

		public bool if_second_open;

		public bool if_second_match_making;
	}

	public class EventTypeBRTutorialGoal : EventLoggerBase
	{
		public uint goal_id;
	}

	public class EventNewbieMatchMakingInfo : EventLoggerBase
	{
		public uint game_mode;
	}

	public class EventNewbieMatchMakingCancelInfo : EventLoggerBase
	{
	}

	public class EventLogBRRankLevelChange : EventLoggerBase
	{
		public ulong match_id;

		public uint pre_rank;

		public uint pre_level;

		public int pre_ranking_points;

		public uint cur_rank;

		public uint cur_level;

		public int cur_ranking_points;

		public uint season_id;
	}

	public class EventAddFriendActively_RuntimeData
	{
		public bool IsSearch;
	}

	public class EventReport : EventLoggerBase
	{
		public ulong reportee;

		public uint reason;

		public ulong match_id;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;

		public ulong teammate_1;

		public ulong teammate_2;

		public ulong teammate_3;

		public uint is_special;

		public uint[] sub_reason;

		public bool is_emulator;

		public uint report_scene;

		public uint reportee_type;

		public int method;

		public string workshop_code;
	}

	public class EventSettingChangeLog : EventLoggerBase
	{
		public List<string> changed_settings;

		public bool is_ingame;
	}

	public class EventTypeAutoPopupWindowCtrl : EventLoggerBase
	{
		public uint random_result;
	}

	public class EventTypeItemsLoveChange : EventLoggerBase
	{
		public class ItemChangeInfo
		{
			public uint type;

			public uint sub_type;

			public uint collection_type;

			public uint item_id;

			public uint change;
		}

		public enum LoveChangeType
		{
			DEFAULT,
			ADD,
			REMOVE,
			REMOVE_BY_SYSTEM
		}

		public List<ItemChangeInfo> item_change_info;
	}

	public class FrontEndGameFPSLogDataContext
	{
		public float LastFrameTimesSum;

		public float LastFrameTimes;

		public uint TotalFPSCount;

		public float JankLimitSecs;

		public float JankLimitRatio;

		public void ClearAll()
		{
		}
	}

	public class JankPage
	{
		public string page_type;

		public uint jank_times;

		public Dictionary<Type, JankPopup> jank_popups;
	}

	public class JankPopup
	{
		public string page_type;

		public uint jank_times;
	}

	public class EventTypeBundleRepair : EventLoggerBase
	{
		public string reason;

		public int bundle_id;

		public string optional_version;
	}

	public class EventTypeBundleRepairClick : EventLoggerBase
	{
		public string repair_result;
	}

	public class EventTypeBundleSize : EventLoggerBase
	{
		public class BundleSizeInfoData
		{
			public uint optional_re_def_id;

			public string size;
		}

		public List<BundleSizeInfoData> bundle_size_info;
	}

	public class EventLoggerClanWarTitleChange : EventLoggerBase
	{
		public uint preTitleId;

		public uint curTitleId;
	}

	public class EventTypeOptionalDownloadInfo : EventLoggerBase
	{
		public uint[] bundle;

		public string[] ab_pack;

		public uint[] failed_bundle;

		public string[] failed_pack;

		public uint auto_download;

		public uint auto_delete;
	}

	public class EventTypeBigEventFirstView : EventLoggerBase
	{
		public uint event_id;

		public string from_page_id;
	}

	public class EventTypeBigEventVideoStats : EventLoggerBase
	{
		public uint view_time;

		public bool if_complete;

		public uint event_id;
	}

	public class EventTypeMatchNPCDialog : EventLoggerBase
	{
		public uint story_id;

		public double dialog_time;

		public uint custom_event_id;
	}

	public class EventFPS_RuntimeData
	{
		public enum FPSTrackingStep
		{
			OnBoard,
			InGame,
			Initial,
			Cabin,
			NB
		}

		public struct JankTime
		{
			public float RealTime;

			public float DeltaTime;
		}

		public FPSTrackingStep FPSStep;

		public float m_LastRealtimeSinceStartup;

		public float m_RealtimeDelta;

		public float EndTime;

		public float TotalFPSValueCount;

		public float TotalFPSValuePowerCount;

		public double TotalCPUTimeFrameValue;

		public uint TotalFPSCount;

		public float KillCamFPSValueCount;

		public uint KillCamFPSCount;

		public float KillCamTime;

		public uint TotalFPSB10Count;

		public uint TotalFPSB20Count;

		public uint SuccessiveFPSB10Count;

		public uint MaxSuccessiveFPSB10Count;

		public bool IsRecording;

		public int JitterCount;

		public float JankLimitRatio;

		public float JankLimitSecs;

		public float BigJankLimitRatio;

		public float BigJankLimitSecs;

		public float[] LastFrameTimes;

		public float LastFrameTimesSum;

		public uint JankCount;

		public uint BigJankCount;

		public double TotalBigJankTime;

		public List<BigJankInfo> BigJankInfos;

		public uint big_jank_count_deathreplay;

		public double TotalJankTime;

		public double TotalTime;

		public float MaxJankDuration;

		public float MaxJankGameTime;

		public uint BigJankCountOnBoard;

		public uint BigJankCountParachute;

		public uint BigJankCountBr;

		public uint BigJankCountInteraction;

		public uint BigJankCountOb;

		public bool NeedPlayerNumFPS;

		public float LastRecordTime;

		public List<PlayerNumFPS> PlayerNumFPSList;

		public bool LogJankTimesForKnockdownOrKill;

		public bool LogJankTimesForKnockdownOrKillSinglePhase;

		public Queue<JankTime> JankTimesForKnockdownOrKill;

		public int KnockdownOrKillCount;

		public int KnockdownOrKillHasJankCount;

		public int KnockdownOrKillTotalJankCount;

		public List<float> KnockdownOrKillStutters;

		public float KnockdownOrKillStartTime;

		public void StartRecording(FPSTrackingStep step, float gameTime, float duration)
		{
		}

		public void Clear(bool leaveGame)
		{
		}

		public bool IsExpired(float gameTime)
		{
			return false;
		}

		public void OnLocalPlayerKnockdownOrKilled()
		{
		}

		public void GetKnockdownOrKillInfo(out float jankRate, out float jankCount, List<float> stutters)
		{
			jankRate = default(float);
			jankCount = default(float);
		}
	}

	public class EventGameLag_RuntimeData
	{
		public float TotalLagTime;

		public int TotalLagFrameCount;

		public float MatchTime;

		public int FrameCount;

		public bool isStart;

		public void Clear()
		{
		}
	}

	public class EventGameMemory_RuntimeData
	{
		public int Enter_PVP_Memory;

		public int Leave_PVP_Memory;

		public int Enter_PVP_AvailMemory;

		public int Leave_PVP_AvailMemory;

		public int Enter_PVP_VSSMemory;

		public int Leave_PVP_VSSMemory;

		public void Clear()
		{
		}
	}

	public class EventGameLag : EventLoggerBase
	{
		public int frame_count;

		public float match_time;

		public float lag_time;

		public int lag_count;

		public int quality;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;
	}

	public class EventBillboardInfo : EventLoggerBase
	{
		public float currenct_time;

		public uint announcement_id;

		public uint activity_id;

		public string url;
	}

	public class EventDisconnectFromNetwork : EventLoggerBase
	{
		public int game_mode;

		public int match_mode;

		public int map_id;

		public int group_mode;

		public int match_number;

		public string system_software;

		public string system_hardware;

		public int screen_width;

		public int screen_hight;

		public string dpi;

		public string cpu_hardware;

		public int memory;

		public string gl_render;

		public string gl_version;

		public string network;

		public bool is_mudp;

		public int quality;

		public int disconnection_type;

		public int disconnect_reason;

		public string gameserver_ip;

		public string proxyserver_ip;

		public int gameserver_proxy_port;

		public ulong match_id;

		public bool is_vpn;

		public string phone_carrier;

		public string client_ip;

		public string network_operator_a;

		public string network_type_a;
	}

	public enum EventShareAction
	{
		OpenUI = 1
	}

	public class EventShare : EventLoggerBase
	{
		public int action;

		public bool share_out;

		public int platform;

		public int page_id;

		public string extra_info;

		public uint frame_id;

		public List<uint> sticker_list;

		public uint is_use_qr_code;
	}

	public class EventShareRecordExtraInfo : EventShareExtraInfoBase
	{
		public int record_highlight_type;

		public ulong match_id;

		public uint game_mode;

		public uint match_mode;
	}

	public class EventTypeShareFrameStickerUse : EventLoggerBase
	{
		public bool share_out;

		public int platform;

		public int page_id;

		public List<EventTypeShareStickerClickInfo> sticker_click_info;

		public List<EventTypeShareFrameClickInfo> frame_click_info;
	}

	public class EventTypeShareStickerClickInfo
	{
		public int sticker_id;

		public int cnt;

		public int is_equip;
	}

	public class EventTypeShareFrameClickInfo
	{
		public int frame_id;

		public int cnt;

		public int is_equip;
	}

	public class EventShareInGameTakePhotoExtraInfo : EventShareExtraInfoBase
	{
		public uint match_mode;

		public uint game_mode;

		public ulong match_id;

		public int zone_id;

		public int photo_template;
	}

	public class EventShareOutGameTakePhotoExtraInfo : EventShareExtraInfoBase
	{
		public uint template_id;

		public List<ulong> account_ids;

		public string from;
	}

	public class EventShareOutGameTakePhotoSeasonReplaySocialExtraInfo : EventShareOutGameTakePhotoExtraInfo
	{
		public List<uint> relationids;
	}

	public class EventShareGachaFeatureExtraInfoBase : EventShareExtraInfoBase
	{
		public uint gachaid;

		public uint itemid;

		public int pagetype;

		public uint luckyid;
	}

	public class EventShareExtraInfoBase
	{
	}

	public class EventShareMatchResultPosterExtraInfo : EventShareExtraInfoBase
	{
		public uint match_mode;

		public uint game_mode;

		public ulong match_id;

		public uint match_result_poster_comments_id;
	}

	public class EventShareAlbumExtraInfo : EventShareExtraInfoBase
	{
		public string photo_time;
	}

	public class EventShareHighlightPhotoExtraInfo : EventShareExtraInfoBase
	{
		public uint channel;

		public ulong match_id;

		public uint highlight_type;
	}

	public class EventSharePrimeLeaderBoardExtraInfo : EventShareExtraInfoBase
	{
		public uint leaderBoardType;

		public uint rank;

		public bool is_friend;
	}

	public class EventUGCShareTakePhotoExtraInfo : EventShareExtraInfoBase
	{
		public ulong match_id;

		public string workshop_code;

		public uint genre_id;
	}

	public class EventShareRelayMartDiscountCodeExtraInfo : EventShareExtraInfoBase
	{
		public string discount_code;
	}

	public class EventShareWebViewScreenShotExtraInfo : EventShareExtraInfoBase
	{
		public string url;

		public string activity_name;
	}

	public class EventShareSparkPetExtraInfo : EventShareExtraInfoBase
	{
		public ulong growth_value;

		public uint growth_level;

		public uint cur_streak_days;

		public int active_state;

		public int form;

		public uint personality;
	}

	public class EventUGCShare : EventLoggerBase
	{
		public bool share_out;

		public int platform;

		public string workshop_code;

		public ulong shared_uid;
	}

	public class EventShareChat : EventLoggerBase
	{
		public bool share_out;

		public int chat_type;

		public int page_id;
	}

	public enum EEventTypeTakePhotoType
	{
		Photo = 1,
		Video
	}

	public enum EEventTypeTakePhotoSource
	{
		None,
		InGame_Cabin,
		InGame_SkyDiving,
		InGame_Normal,
		OutGame_Lobby_PreTeam,
		OutGame_Lobby_MatchWaiting,
		OutGame_Lobby_Idle,
		OutGame_Profile,
		OutGame_GroupPhoto_Studio,
		OutGame_BigEvent_Photo,
		LobbySocialAreaOffline
	}

	public class EventTypeTakePhoto : EventLoggerBase
	{
		public int type;

		public int source;

		public int photo_template;

		public int background_id;

		public List<int> emote_list;

		public EventTypeTakePhotoExtraInfo extra_info;
	}

	public class EventTypeConnectNotiFail : EventLoggerBase
	{
		public string noti_region;

		public string ip_region;

		public string client_ip;

		public string noti_ip;

		public string country;

		public bool conn_success;

		public string exception;
	}

	public class EventTypeTakePhotoExtraInfo
	{
		public float focal_length;

		public uint game_mode;

		public uint match_mode;

		public ulong match_id;

		public int zone_id;

		public List<ulong> group_photo_account_ids;

		public bool is_vertical;

		public int video_duration_sec;

		public int weapon_setting_type;

		public int bag_setting_type;

		public int pet_setting_type;

		public List<uint> background_objects_list;

		public int player_setting_type;

		public int teammate_setting_type;

		public int enemy_setting_type;

		public int filter_id;

		public string from;

		public int is_photo_check_in_point;

		public int photo_check_in_point_id;

		public int is_use_free_lens;
	}

	public class EventIAPResult : EventLoggerBase
	{
		public int error_code;

		public string error_message;

		public string item_identifier;

		public bool is_first_topup;

		public uint ui_from;
	}

	public class EventScanIAPResult : EventLoggerBase
	{
		public string results;
	}

	public class EventOpenRewardPoolCount : EventLoggerBase
	{
	}

	public class EventTypeLimitLotteryDefaultRemove : EventLoggerBase
	{
		public int lottery_id;

		public int lottery_sub_id;

		public bool is_default;

		public uint[] default_remove_items;
	}

	public class EventElitePassEntry : EventLoggerBase
	{
		public uint ep_main_entry_count;

		public uint ep_challenge_entry_count;
	}

	public enum EEventTypeReceiveGiftSource
	{
		None,
		Popup,
		Notification,
		GameAssistant,
		Mail
	}

	public class EventGiftReceive : EventLoggerBase
	{
		public uint item_id;

		public uint expire_time;

		public uint source;
	}

	public class EventMailSendSuccessfullyClient : EventLoggerBase
	{
		public string local_mail_id;

		public long mail_ts;

		public int mail_type;

		public string extra_info;
	}

	public class EventChat : EventLoggerBase
	{
		public ulong group_chan_id;

		public uint group_chat_num;

		public ulong clan_chan_id;

		public uint clan_chat_num;

		public uint whisper_chat_num;

		public ulong room_chan_id;

		public uint room_chat_num;

		public uint use_sticker_times;

		public ulong world_chan_id;

		public uint world_chat_num;

		public ulong mentor_chan_id;

		public uint mentor_chat_num;

		public uint block_list_size;

		public ulong social_island_chan_id;

		public uint social_island_chan_num;

		public ulong newbie_chat_id;

		public uint newbie_chat_num;
	}

	public class EventTypeWhisperChat : EventLoggerBase
	{
		public List<EventTypeWhisperChatItem> receiver_infos;
	}

	public class EventTypeWhisperChatItem
	{
		public ulong receiver_id;

		public uint online_chat_num;

		public uint offline_chat_num;
	}

	public class EventTypeClientSettingChange : EventLoggerBase
	{
		public int is_max;

		public bool is_ingame_change;

		public string cur_general_sensitivity;

		public string pre_general_sensitivity;

		public string cur_free_look_sensitivity;

		public string pre_free_look_sensitivity;

		public string cur_music;

		public string pre_music;

		public string cur_sound_effects;

		public string pre_sound_effects;

		public string cur_voice;

		public string pre_voice;

		public int cur_voice_changer_is_open;

		public int pre_voice_changer_is_open;

		public int cur_voice_changer;

		public int pre_voice_changer;

		public string cur_graphics;

		public string pre_graphics;

		public int cur_high_res;

		public int pre_high_res;

		public int cur_high_fps;

		public int pre_high_fps;

		public int cur_shadow;

		public int pre_shadow;

		public int cur_free_look;

		public int pre_free_look;

		public int cur_free_look_parachute;

		public int pre_free_look_parachute;

		public int pre_free_look_dash;

		public int cur_free_look_dash;

		public int pre_free_look_drive;

		public int cur_free_look_drive;

		public int cur_hitmarker;

		public int pre_hitmarker;

		public int cur_team_reserve;

		public int pre_team_reserve;

		public int cur_team_block;

		public int pre_team_block;

		public int cur_run;

		public int pre_run;

		public int cur_grenade_slot;

		public int pre_grenade_slot;

		public int cur_chatbubble;

		public int pre_chatbubble;

		public int pre_phone_vibration;

		public int cur_phone_vibration;

		public int pre_external_sound_vibration;

		public int cur_external_sound_vibration;

		public int pre_character_vibration;

		public int cur_character_vibration;

		public int pre_weapon_vibration;

		public int cur_weapon_vibration;

		public int pre_vehicle_vibration;

		public int cur_vehicle_vibration;

		public int pre_push_friend_request;

		public int cur_push_friend_request;

		public int pre_editor_friend_message;

		public int cur_editor_friend_message;

		public int pre_warning_foot;

		public int cur_warning_foot;

		public int pre_warning_gun;

		public int cur_warning_gun;

		public int pre_lobby_gyro;

		public int cur_lobby_gyro;

		public int pre_gloo_wall_smart_release;

		public int cur_gloo_wall_smart_release;

		public int pre_gloo_wall_auto_switch;

		public int cur_gloo_wall_auto_switch;

		public int cur_character_voice;

		public int pre_character_voice;

		public int pre_automatic_download_in_wifi_state;

		public int cur_automatic_download_in_wifi_state;

		public int pre_hide_location;

		public int cur_hide_location;

		public int pre_damage_tip;

		public int cur_damage_tip;

		public int pre_hit_shield;

		public int cur_hit_shield;

		public int pre_backend_audio;

		public int cur_backend_audio;

		public string pre_voice_balance;

		public string cur_voice_balance;

		public int pre_voice_balance_state;

		public int cur_voice_balance_state;

		public int pre_invite_notify;

		public int cur_invite_notify;

		public int pre_disable_friend_spectate;

		public int cur_disable_friend_spectate;

		public int pre_send_remind_notify;

		public int cur_send_remind_notify;

		public int cur_in_game_smart_bubble;

		public int pre_in_game_smart_bubble;

		public int pre_bullet_screen_guild_war;

		public int cur_bullet_screen_guild_war;

		public int pre_bullet_screen_dynamic_duo;

		public int cur_bullet_screen_dynamic_duo;

		public float cur_red_dot_sensitivity;

		public float pre_red_dot_sensitivity;

		public float cur_double_scope_sensitivity;

		public float pre_double_scope_sensitivity;

		public float cur_quad_scope_sensitivity;

		public float pre_quad_scope_sensitivity;

		public float cur_sniper_scope_sensitivity;

		public float pre_sniper_scope_sensitivity;

		public float cur_first_person_sensitivity;

		public float pre_first_person_sensitivity;

		public int pre_outline;

		public int cur_outline;

		public int pre_teammate_outline;

		public int cur_teammate_outline;

		public int pre_aim_assist;

		public int cur_aim_assist;

		public int pre_left_fire;

		public int cur_left_fire;

		public int pre_scope_operate;

		public int cur_scope_operate;

		public int pre_change_weapon;

		public int cur_change_weapon;

		public int pre_reload;

		public int cur_reload;

		public int pre_crosshair_reload;

		public int cur_crosshair_reload;

		public bool pre_auto_switch_weapon;

		public bool cur_auto_switch_weapon;

		public bool pre_br_scoreboard;

		public bool cur_br_scoreboard;

		public bool pre_br_scoreboard_mode;

		public bool cur_br_scoreboard_mode;

		public int pre_item_finder_mode;

		public int cur_item_finder_mode;

		public int pre_smart_ice_wall_show;

		public int cur_smart_ice_wall_show;

		public int pre_vehicle_control_mode;

		public int cur_vehicle_control_mode;

		public int pre_safe_zone_mode;

		public int cur_safe_zone_mode;

		public int pre_stacked_kill_mode;

		public int cur_stacked_kill_mode;

		public int pre_crosshair_mode;

		public int cur_crosshair_mode;

		public int pre_damage_setting;

		public int cur_damage_setting;

		public int pre_blood_mode;

		public int cur_blood_mode;

		public bool pre_name_alpha_group;

		public bool cur_name_alpha_group;

		public int pre_hide_teammate_name;

		public int cur_hide_teammate_name;

		public int pre_lbs;

		public int cur_lbs;

		public int pre_lbs_blur_level;

		public int cur_lbs_blur_level;

		public int pre_collection_effect;

		public int cur_collection_effect;

		public int pre_ingame_filter;

		public int cur_ingame_filter;

		public bool pre_minimap_scale;

		public bool cur_minimap_scale;

		public int pre_notch_screen;

		public int cur_notch_screen;

		public int pre_minimap_mode;

		public int cur_minimap_mode;

		public bool cur_energy_saving_mode;

		public bool pre_energy_saving_mode;

		public float pre_kill_sound_effect;

		public float cur_kill_sound_effect;

		public int pre_auto_quick_message;

		public int cur_auto_quick_message;

		public bool pre_replaykit_enable;

		public bool cur_replaykit_enable;

		public int pre_replaykit_video_quality;

		public int cur_replaykit_video_quality;

		public bool pre_network_optimize;

		public bool cur_network_optimize;

		public int pre_network_show_self_damage;

		public int cur_network_show_self_damage;

		public bool pre_stranger_invite;

		public bool cur_stranger_invite;

		public bool pre_friend_recommend;

		public bool cur_friend_recommend;

		public bool pre_cup_invite;

		public bool cur_cup_invite;

		public bool pre_cup_join;

		public bool cur_cup_join;

		public bool pre_matchend_friend_recommend;

		public bool cur_matchend_friend_recommend;

		public bool pre_matchend_team_recommend;

		public bool cur_matchend_team_recommend;

		public bool pre_rebatecard_noti;

		public bool cur_rebatecard_noti;

		public bool pre_friend_msg_noti;

		public bool cur_friend_msg_noti;

		public int pre_ingame_emoji_noti;

		public int cur_ingame_emoji_noti;

		public int pre_vibration_foot_step;

		public int cur_vibration_foot_step;

		public int pre_vibration_gun_shoot;

		public int cur_vibration_gun_shoot;

		public int pre_vibration_player_interaction;

		public int cur_vibration_player_interaction;

		public int pre_vibration_taking_damage;

		public int cur_vibration_taking_damage;

		public int pre_vibration_automatic_guns;

		public int cur_vibration_automatic_guns;

		public int pre_vibration_semi_automatic_guns;

		public int cur_vibration_semi_automatic_guns;

		public int pre_vibration_bolt_action_guns;

		public int cur_vibration_bolt_action_guns;

		public int pre_vibration_other_guns;

		public int cur_vibration_other_guns;

		public int pre_vibration_driving;

		public int cur_vibration_driving;

		public int pre_vibration_vehicle_damage;

		public int cur_vibration_vehicle_damage;

		public int pre_vibration_collision;

		public int cur_vibration_collision;

		public bool pre_vibration_lobby;

		public bool cur_vibration_lobby;

		public int pre_vibration_ui;

		public int cur_vibration_ui;

		public int pre_vibration_roulette;

		public int cur_vibration_roulette;

		public int pre_vibration_pickup;

		public int cur_vibration_pickup;

		public int pre_recommend_group_notify;

		public int cur_recommend_group_notify;

		public int pre_max_login_vedio;

		public int cur_max_login_vedio;

		public int pre_max_lobby_style;

		public int cur_max_lobby_style;

		public int pre_max_audio_style;

		public int cur_max_audio_style;

		public int pre_max_own_lobby;

		public int cur_max_own_lobby;

		public int pre_max_teammate_lobby;

		public int cur_max_teammate_lobby;

		public int pre_max_animation;

		public int cur_max_animation;

		public int pre_max_visual_effects;

		public int cur_max_visual_effects;

		public int pre_max_hd_texture;

		public int cur_max_hd_texture;

		public int pre_max_vehicle_effects;

		public int cur_max_vehicle_effects;

		public int pre_blood_hud_style;

		public int cur_blood_hud_style;

		public int pre_auto_upload_setting;

		public int cur_auto_upload_setting;

		public int cur_real_60fps;

		public int pre_real_60fps;

		public int pre_ai_bot_agent;

		public int cur_ai_bot_agent;

		public float pre_ai_voice;

		public float cur_ai_voice;

		public int pre_ai_cat_feedback;

		public int cur_ai_cat_feedback;

		public int pre_ai_cat_loot;

		public int cur_ai_cat_loot;

		public int pre_ai_cat_operation;

		public int cur_ai_cat_operation;

		public int pre_ai_cat_gun;

		public int cur_ai_cat_gun;

		public int pre_ai_cat_survive;

		public int cur_ai_cat_survive;

		public int pre_ai_cat_cooperation;

		public int cur_ai_cat_cooperation;

		public bool pre_highlight_record;

		public bool cur_highlight_record;

		public int pre_hud_button_hint;

		public int cur_hud_button_hint;

		public int pre_language;

		public int cur_language;

		public int pre_cs_bot_agent;

		public int cur_cs_bot_agent;

		public float pre_cs_voice;

		public float cur_cs_voice;

		public int pre_cs_shop;

		public int cur_cs_shop;

		public int pre_cs_rule;

		public int cur_cs_rule;

		public int pre_cs_map;

		public int cur_cs_map;

		public int pre_cs_battle;

		public int cur_cs_battle;

		public int pre_sound_voice_hold_talk;

		public int cur_sound_voice_hold_talk;

		public int pre_sound_voice_hold_talk_privacy;

		public int cur_sound_voice_hold_talk_privacy;

		public int change_type;

		public bool IsChange()
		{
			return false;
		}
	}

	public class EventAutoPickUpSettingChangeLog : EventLoggerBase
	{
		public class PickUpItem
		{
			public int id;

			public int setting;
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Comparison<PickUpItem> _003C_003E9__7_0;

			public static Comparison<PickUpItem> _003C_003E9__7_1;

			public static Comparison<PickUpItem> _003C_003E9__7_2;

			public static Comparison<PickUpItem> _003C_003E9__7_3;

			internal int _003CNeedSend_003Eb__7_0(PickUpItem x, PickUpItem y)
			{
				return 0;
			}

			internal int _003CNeedSend_003Eb__7_1(PickUpItem x, PickUpItem y)
			{
				return 0;
			}

			internal int _003CNeedSend_003Eb__7_2(PickUpItem x, PickUpItem y)
			{
				return 0;
			}

			internal int _003CNeedSend_003Eb__7_3(PickUpItem x, PickUpItem y)
			{
				return 0;
			}
		}

		public int pre_pickup_speed;

		public int cur_pickup_speed;

		public List<PickUpItem> pre_br_setting;

		public List<PickUpItem> cur_br_setting;

		public List<PickUpItem> pre_cs_setting;

		public List<PickUpItem> cur_cs_setting;

		public bool NeedSend()
		{
			return false;
		}

		public void InitPreSetting()
		{
		}

		public void InitCurSetting()
		{
		}

		private List<PickUpItem> GetAutoPickupItemSettingByType(int type)
		{
			return null;
		}
	}

	public class EventTypeCraftlandTemplateSave : EventLoggerBase
	{
		public class ItemInfo
		{
			public uint item_id;

			public uint item_cnt;
		}

		public string template_uuid;

		public string template_name;

		public ItemInfo[] item_info;

		public uint user_block_cnt;
	}

	public class EventTypeCraftlandTemplateDel : EventLoggerBase
	{
		public string template_uuid;
	}

	public class EventTypeCraftlandTemplateUpload : EventLoggerBase
	{
		public string template_uuid;

		public ulong resource_id;

		public string name;

		public int category_id;

		public int main_category_id;

		public string description;

		public int is_public;

		public int allow_recreation;

		public uint cost;
	}

	public class EventTypeCraftlandAssetUploadSuccess : EventLoggerBase
	{
		public ulong resource_id;
	}

	public class EventTypeCraftlandAssetReport : EventLoggerBase
	{
		public ulong resource_id;

		public string asset_code;

		public int update_time;

		public int ob_version;

		public int editor_type;

		public ulong creator_id;

		public string creator_region;

		public uint[] violation_issues;

		public string violation_issue_text;

		public uint[] other_issues;

		public string other_issue_text;
	}

	public class EventTypeCraftlandSearchPageAssetPurchase : EventLoggerBase
	{
		public ulong resource_id;

		public string asset_code;

		public int update_time;

		public int ob_version;

		public int editor_type;

		public int main_category_id;

		public int cl_category_id;

		public int purchase_index;

		public bool is_ai_result;

		public int type_id;

		public int event_id;
	}

	public class EventTypeCraftlandAssetStoreClick : EventLoggerBase
	{
		public List<EventTypeCraftlandAssetStoreClickInfo> click_info;
	}

	public class EventTypeCraftlandAssetStoreClickInfo
	{
		public ulong resource_id;

		public string asset_code;

		public int type_id;

		public int event_id;

		public int click_cnt;
	}

	public class EventTypeCraftlandAssetStoreExposure : EventLoggerBase
	{
		public List<EventTypeCraftlandAssetStoreExposureInfo> exposure_info;
	}

	public class EventTypeCraftlandAssetStoreExposureInfo
	{
		public ulong resource_id;

		public string asset_code;

		public int type_id;

		public int event_id;

		public int exposure_cnt;
	}

	public class EventUGCNavigate : EventLoggerBase
	{
		public List<EventUGCNavigateInfo> navigate_info;
	}

	public class EventUGCNavigateInfo
	{
		public string from;

		public string to;

		public string from_info;

		public string to_info;
	}

	public class EventNavigate : EventLoggerBase
	{
		public List<EventNavigateClick> clicks;
	}

	public class EventNavigateClick
	{
		public string from;

		public string to;

		public int cnt;
	}

	[Serializable]
	public class EventClick : EventLoggerBase
	{
		public List<ClickEntry> clicks;
	}

	[Serializable]
	public class ClickEntry
	{
		public string name;

		public uint cnt;
	}

	public class EventBriefBoxClick : EventLoggerBase
	{
		public List<BriefBoxClickEntry> detail_info;
	}

	public class BriefBoxClickEntry
	{
		public ulong target_id;

		public int module;

		public int submodule;

		public int detail;

		public bool is_guild;

		public int cnt;
	}

	public class BriefBoxClickData
	{
		public ulong target_id;

		public int module;

		public int submodule;

		public int detail;
	}

	public class EventTypeRelayMartAddCart : EventLoggerBase
	{
		public List<EventTypeRelayMartAddCartEntry> relay_mart_add_cart_infos;
	}

	public class EventTypeRelayMartAddCartEntry
	{
		public int relay_mart_id;

		public List<EventTypeRelayMartAddCartGoodsInfo> item_info;

		public int discount_price;

		public bool is_use_coupon;

		public EventTypeRelayMartUsedCouponInfo used_coupon_info;
	}

	public class EventTypeRelayMartAddCartGoodsInfo
	{
		public int item_id;

		public int item_num;
	}

	public class EventTypeRelayMartUsedCouponInfo
	{
		public string coupon_code;

		public ulong coupon_account_id;

		public int add_from;
	}

	public enum EBriefBoxModule
	{
		LobbyGroupList = 1,
		Friend,
		Chat,
		Clan,
		LeaderBoard,
		HistoryRecord,
		LobbyTeamInvite,
		LobbyTeamWait,
		Room,
		SocialIsland,
		ClanBriefBox,
		QRCode,
		UGCSocial,
		LobbySocialArea,
		UGCLeaderBoard
	}

	public enum EBriefBoxSubModule_LobbyGroupList
	{
		InviteList = 1,
		LeaderBoard,
		NewBeeRecommend
	}

	public enum EBriefBoxSubModule_Friend
	{
		FrinedTab = 1,
		BlackList
	}

	public enum EBriefBoxSubModule_Chat
	{
		None,
		World,
		GroupFast,
		Clan,
		Newbie
	}

	public enum EBriefBoxSubModule_Clan
	{
		ClanList = 1,
		ClanEdit
	}

	public enum EBriefBoxSubModule_TeamInvite
	{
		InviteTipsBox = 1,
		ExpireTeamInvite
	}

	public enum EBriefBoxSubModule_LeaderBoard
	{
		None,
		Rank,
		Weapon,
		Kill,
		Win,
		Clan,
		KDA,
		BP,
		PVE,
		NK,
		Peak
	}

	public enum EBriefBoxSubModule_UGCSocial
	{
		FriendList = 1,
		SceneClick
	}

	public class EventIAPBundlePurchase : EventLoggerBase
	{
		public int store_id;

		public int bundle_id;

		public float price_usd;

		public int discount;

		public int rebate_id;

		public string product_identifier;

		public uint ui_from;
	}

	public class EventBroadCastTypeCnt : EventLoggerBase
	{
		public List<EventBroadCastEntry> entries;
	}

	public class EventBroadCastEntry
	{
		public EventBroadCastType type;

		public int cnt;
	}

	public class EventPopularList
	{
		public string workshop_code;

		public int cnt;
	}

	public class EventWeekList
	{
		public string workshop_code;

		public int cnt;
	}

	public class RecommendItemLog
	{
		public string workshop_code;

		public ulong author_id;

		public bool has_custom_cover;

		public int cnt;
	}

	public class EventTypeClickWorkshopMapExposed : EventLoggerBase
	{
		public List<EventPopularList> popular_list;

		public List<EventWeekList> week_list;

		public List<RecommendItemLog> recommend_list;
	}

	public class EventAndroidApplicationDetection : EventLoggerBase
	{
		public string detection;
	}

	[Serializable]
	public class EventNavigationClickCount : EventLoggerBase
	{
		public uint activity_id;

		public uint navigation_clicks;
	}

	public class EventGotoOthersPersonalShowTimes : EventLoggerBase
	{
		public uint group_list;

		public uint clan_members;

		public uint friend_list;

		public uint search_account;

		public uint friend_application;

		public uint leaderboard;

		public uint chat;
	}

	public class EventEnterGame : EventLoggerBase
	{
		public string system_software;

		public string system_hardware;

		public string dpi;

		public string cpu_hardware;

		public int memory;

		public string gl_render;

		public string gl_version;

		public string device_model;

		public ulong match_id;

		public int is_night_mode;

		public uint tick_count;

		public uint group_mode;

		public uint time_to_wait;

		public string lib_path;

		public uint quality;

		public uint game_mode;

		public uint match_mode;

		public string lib_token;

		public uint map_id;

		public uint shadow_option;

		public uint loading_time;

		public uint fake_loading_time;

		public uint cpu_type;

		public string ip_region;

		public uint loadingscene_time;

		public uint gamescene_time;

		public uint connect_gs_time;

		public bool connected_gs;

		public uint loading_time_nopause;

		public uint loading_awaketodestroy;

		public bool is_charge;

		public uint joinmatch_rtt;

		public uint joinmatch_msgtime;

		public uint match_num;

		public int enter_pvp_memory;

		public int enter_pvp_avail_memory;

		public int enter_pvp_vss;

		public bool is_ob;

		public int lobby_battery_consumption;

		public int lobby_time;

		public string gameserver_ip;

		public string proxyserver_ip;

		public int gameserver_proxy_port;

		public string extra_info;
	}

	public class FramerateInfo
	{
		public int frame_type;

		public int framerate;
	}

	public enum BigJankInfoType
	{
		BigJank,
		FPS_DATA_B10
	}

	public class BigJankInfo
	{
		public uint frame_tick_count;

		public int frame_time_ms;

		public List<ushort> udp_cmds;

		public int handle_udp_time_ms;

		public int interaction_ui_mask;

		public bool is_manual_gc;

		public bool is_observer;

		public int sync_load_time;

		public List<string> sync_load_urls;

		public int status;

		public string shader_info;

		public int info_type;

		public BigJankInfo Clone(BigJankInfo org)
		{
			return null;
		}
	}

	public class EventLeaveSceneEditGame : EventLoggerBase
	{
		public uint slot_id;

		public uint map_id;

		public string system_software;

		public string system_hardware;

		public int screen_width;

		public int screen_hight;

		public string dpi;

		public string cpu_hardware;

		public int memory;

		public int total_memory;

		public int memory_level;

		public string gl_render;

		public string gl_version;

		public string device_model;

		public int quality;

		public int recommend_quality;

		public string client_version_code;

		public int fps;

		public float fps_devi;

		public uint fps_data_total_count;

		public uint fps_data_b10_count;

		public uint fps_data_b10_conti_count;

		public uint fps_data_b20_count;

		public int jitter_count;

		public uint jank_count;

		public uint big_jank_count;

		public float max_jank_game_time;

		public float max_jank_duration;

		public float stutter_percent;

		public int avg_jank_time;

		public int avg_big_jank_time;

		public uint big_jank_interaction_count;

		public float cpu_frame_time;

		public FramerateInfo framerate_info;
	}

	public class EventLeaveGame : EventLoggerBase
	{
		public ulong match_id;

		public uint tick_count;

		public string system_software;

		public string system_hardware;

		public int screen_width;

		public int screen_hight;

		public string dpi;

		public string cpu_hardware;

		public int memory;

		public int total_memory;

		public int memory_level;

		public string gl_render;

		public string gl_version;

		public string device_model;

		public int quality;

		public int recommend_quality;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;

		public string client_version_code;

		public bool disable_auto_gc;

		public int fps0;

		public uint fps_data_total_count0;

		public uint fps_data_b10_count0;

		public uint fps_data_b10_conti_count0;

		public uint fps_data_b20_count0;

		public uint jank_count0;

		public uint big_jank_count0;

		public int fps1;

		public int step1;

		public float fps_devi1;

		public uint fps_data_total_count1;

		public uint fps_data_b10_count1;

		public uint fps_data_b10_conti_count1;

		public uint fps_data_b20_count1;

		public int jitter_count1;

		public uint jank_count1;

		public uint big_jank_count1;

		public float max_jank_game_time1;

		public float max_jank_duration1;

		public float stutter_percent1;

		public int fps2;

		public int step2;

		public float fps_devi2;

		public uint fps_data_total_count2;

		public uint fps_data_b10_count2;

		public uint fps_data_b10_conti_count2;

		public uint fps_data_b20_count2;

		public int jitter_count2;

		public uint jank_count2;

		public uint big_jank_count2;

		public uint big_jank_count_deathreplay;

		public float max_jank_game_time2;

		public float max_jank_duration2;

		public float stutter_percent2;

		public int avg_big_jank2_time;

		public int avg_jank2_time;

		public uint big_jank_count_onboard;

		public uint big_jank_count_parachute;

		public uint big_jank_count_br;

		public uint big_jank_interaction_count2;

		public uint big_jank_spectator_count2;

		public float cpu_frame_time;

		public float knockdown10s_jank_rate0;

		public float knockdown10s_jank_count0;

		public List<float> knockdown10s_stutters0;

		public float knockdown10s_jank_rate1;

		public float knockdown10s_jank_count1;

		public List<float> knockdown10s_stutters1;

		public float knockdown10s_jank_rate2;

		public float knockdown10s_jank_count2;

		public List<float> knockdown10s_stutters2;

		public int unload_normal_count;

		public int unload_emergency_count;

		public int unload_force_count;

		public int low_memory_count;

		public uint match_num;

		public int unload_unused_resource_count;

		public int shader_compile_count;

		public int shader_parse_count;

		public string chipset;

		public List<BigJankInfo> big_jank_infos;

		public int ping;

		public int maxping;

		public int ping_total;

		public int ping_b500;

		public int ping_a500;

		public int ping100200;

		public int ping200300;

		public int ping300400;

		public int ping400500;

		public string gameserver_ip;

		public string proxyserver_ip;

		public int gameserver_proxy_port;

		public string phone_carrier;

		public string country;

		public ulong packet_sent;

		public ulong rudp_packet_sent;

		public ulong rudp_packet_resent;

		public uint rudp_resent_start_fire;

		public uint rudp_resent_take_damage;

		public string rudp_top10_resent_cmds;

		public uint player_state_sync_stall_count;

		public float player_state_sync_stall_total_sec;

		public int player_state_sync_stall_avg_ping;

		public ulong pri_received;

		public ulong pri_handled;

		public float rudp_max_delaytime;

		public float rudp_avg_delaytime;

		public float rudp_all_avg_delaytime;

		public ulong rudp_received_count;

		public ulong rudp_delay_received_count;

		public int enter_pvp_memory;

		public int leave_pvp_memory;

		public int enter_pvp_avail_memory;

		public int leave_pvp_avail_memory;

		public int low_memory_threshold;

		public int max_avail_memory;

		public int min_avail_memory;

		public int unload_unused_count;

		public int enter_pvp_vss;

		public int leave_pvp_vss;

		public int job_worker_count;

		public float used_mono_memory;

		public float total_mono_memory;

		public float enter_battery;

		public float leave_battery;

		public bool is_charge;

		public uint resource_load_count;

		public uint game_time;

		public uint sep_game_time;

		public int global_fps;

		public float global_fps2;

		public int trigger_near_count;

		public int trigger_far_count;

		public List<uint> trigger_id_list;

		public List<string> scene_object_pin_list;

		public int default_pin_count;

		public int enemy_pin_count;

		public int supplies_pin_count;

		public int pet_id;

		public uint pet_click_cnt;

		public uint shadow_option;

		public uint loading_time;

		public uint cpu_type;

		public bool is_high_framerate;

		public FramerateInfo framerate_info;

		public uint click_map_cnt;

		public uint waiting_map_click;

		public uint waiting_map_mark;

		public bool is_emulator;

		public uint sub_mode;

		public int scoreboard_click_cnt;

		public int weapon_skill_click_cnt;

		public int scoreboard_view_time;

		public float map_view_time;

		public bool is_airline_click;

		public bool is_popup;

		public int is_framerate_popup;

		public bool network_multi_session;

		public float auto_find_items_time;

		public int auto_find_items_close;

		public int auto_find_items_cnt;

		public List<AutoFindItemsInfo> auto_find_items_info;

		public List<AutoFindItemsInfo> auto_find_items_pick;

		public int auto_find_items_distance;

		public int drive_mode;

		public int gc_cnt;

		public int gc_mannual_cnt;

		public int gc_ms;

		public int bag_stack;

		public List<BagThrowItem> bag_throw_items;

		public int bag_throw_all;

		public List<BagOpenTime> bag_open_time;

		public int backpack_on_strop;

		public FPSData floating_land_performance;

		public List<PlayerNumFPS> fps_player_num_monitor;

		public uint coin_remind_cnt;

		public uint teammate_weapon_page_status;

		public string workshop_code;

		public float unnecessary_res_size;

		public bool is_unnecessary_res_downloaded;

		public int unnecessary_res_download_time;

		public string network;

		public BlockQuickChat block_stats;

		public uint ingame_item_transfer_failure;

		public bool is_ob;

		public int alone_action_popup_cnt;

		public int auto_enemy_pin_count;

		public bool is_click_fighting;

		public uint game_sub_mode;

		public List<DeathReplayInfo> death_replay_info;

		public List<int> map_click_pin_time;

		public int slide_joystick_use_cnt;

		public bool is_trigger_save_replay;

		public List<WeaponExectuionTrigger> weapon_execution_trigger;

		public int cdn_view_time;

		public int map_resource_loading_failed_cnt;

		public string extra_info;

		public bool is_disable_friend_spectate;

		public int slide_get_on_click;

		public int slide_jump_on_click;

		public int slide_turn_on_click;

		public int slide_get_off_click;

		public int slide_jump_off_click;

		public List<SlideInfo> slide_info;

		public List<BotAgentAction> bot_agent_action;

		public List<BotAgentPlay> bot_agent_play;

		public List<BotAgentSetting> bot_agent_setting;

		public List<BotAgentSetting> cs_bot_agent_setting;

		public int highlight_type;

		public HighlightTriggerInfo highlight_trigger_info;

		public List<VoiceToTextInfo> voice_to_text_info;

		public List<SmartBubbleInfo> smart_bubble_info;

		public FistEmojiSmartTriggerInfo fist_emoji_smart_trigger_info;

		public List<EmojiUseInfo> emoji_use_info;

		public int one_tap_teamrally_num;
	}

	public class SmartBubbleInfo
	{
		public int type;

		public int bubble_id;

		public int trigger_num;

		public int click_num;
	}

	public class FistEmojiSmartTriggerInfo
	{
		public int trigger_num;

		public int click_num;

		public int succ_num;
	}

	public class EmojiUseInfo
	{
		public int emoji_id;

		public int use_num;
	}

	public class EventResourceRecord : EventLoggerBase
	{
		public int quality;

		public int total_memory;

		public uint game_mode;

		public uint map_id;

		public bool is_max;

		public List<ResourceInfoAudio> res_audio;
	}

	public class EventResourceRecord_RuntimeData
	{
		public Dictionary<int, ResourceInfoAudio> res_audio;
	}

	public class ResourceInfoAudio
	{
		public string name;

		public int load_type;

		public int play_times;
	}

	public class HighlightTriggerInfo
	{
		public int info_type;

		public string info_detail;
	}

	public class EventLeaveGameExtraInfo
	{
		public class WeaponSkinSwitchInfo
		{
			public uint weapon_id;

			public uint pre_skin_id;

			public uint cur_skin_id;
		}

		public class InstantiateJankInfo
		{
			public string name;

			public int time;
		}

		public bool first_start_up;

		public int overhead_rays_trigger;

		public int diving_use;

		public int diving_joystick_use;

		public int lead_jumpoff_cnt;

		public int bag_device_click;

		public int new_system_jank;

		public int animation_jank;

		public int msggroup_jank;

		public int cdn_jank;

		public int ngui_dc_avg;

		public int opaque_obj_avg;

		public int transparent_obj_avg;

		public int particle_simulation_count_avg;

		public float wait_for_present_avg;

		public List<WeaponSkinSwitchInfo> weapon_skin_switch;

		public int leave_pvp_memory;

		public int leave_pvp_avail_memory;

		public int leave_pvp_vss;

		public int leave_pvp_swapmem;

		public int leave_pvp_swapfrequency;

		public int leave_pvp_pss;

		public int lock_mutex_5ms_times;

		public int lock_mutex_25ms_times;

		public int lock_mutex_50ms_times;

		public int QTE_trigger;

		public int QTE_early;

		public int QTE_success;

		public int QTE_late;

		public int growth_panel_click;

		public int driver_cnt;

		public int passenger_cnt;

		public int cabin_driver_cnt;

		public int cabin_passenger_cnt;

		public List<InstantiateJankInfo> instantiate_jank_infos;
	}

	public class EventCompleteGame : EventLoggerBase
	{
		public ulong match_id;
	}

	public class DeathReplayInfo
	{
		public int stage;

		public int replay_cnt;

		public int return_cnt;

		public int complete_cnt;

		public int interrupt_cnt;

		public List<int> return_time;
	}

	public class SlideInfo
	{
		public int slide_id;

		public int get_on_click;

		public int jump_on_click;

		public int get_off_click;

		public int jump_off_click;

		public int turn_on_click;
	}

	public class WeaponExectuionTrigger
	{
		public int weapon_id;

		public int execution_id;

		public int trigger_cnt;
	}

	public class BlockQuickChat
	{
		public int block_all_cnt;

		public int block_icon_click;

		public int block_single_cnt;
	}

	public class VoiceToTextInfo
	{
		public int quick_message_click_num;

		public int text_click_num;

		public int text_sent_num;

		public int voice_to_text_click_num;

		public int voice_to_text_retried_num;

		public int voice_to_text_convert_num;

		public int voice_to_text_completed_num;

		public int voice_to_text_sent_num;
	}

	public class BotAgentAction
	{
		public int id;

		public int cnt;
	}

	public class BotAgentPlay
	{
		public int id;

		public int cnt;
	}

	public class BotAgentSetting
	{
		public bool cur_switch;

		public int pre_voice;

		public int cur_voice;
	}

	public class BagThrowItem
	{
		public uint item_id;

		public int item_num;

		public int is_stack;

		public int is_split;

		public int is_throw_all;
	}

	public class BagOpenTime
	{
		public int open_time;

		public int is_stack;
	}

	public class AutoFindItemsInfo
	{
		public uint item_id;

		public int item_num;
	}

	public class PlayerNumFPS
	{
		public byte player_num;

		public int fps;

		public bool ob;
	}

	public class EventBRDeadInfo : EventLoggerBase
	{
		public ulong match_id;

		public int quality;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;

		public int dead_reason;

		public int dead_time;
	}

	public class EventHighFPSSwitch : EventLoggerBase
	{
		public string device_model;

		public bool switch_highfps;
	}

	public class EventTypeGuideTrigger : EventLoggerBase
	{
		public uint guide_id;
	}

	public class EventTypeCSGuideTrigger : EventLoggerBase
	{
		public uint guide_id;

		public uint tag;
	}

	public class EventTypeGuideCloseInfo : EventLoggerBase
	{
		public uint guide_id;

		public uint close_type;
	}

	public class EventTypeUGCMapDetailsPopup : EventLoggerBase
	{
		public class ClickInfo
		{
			public uint map_scene;

			public string workshop_code;

			public ulong author_id;

			public uint cnt;
		}

		public readonly List<ClickInfo> click_infos;
	}

	public class AbNameInfo
	{
		public string package_name;

		public int download_type;

		public bool complete_result;

		public string optional_version;
	}

	public class EventTypeOptionalBundleDownload : EventLoggerBase
	{
		public class SingleEvent
		{
			public uint bundle_id;

			public string package_name;

			public uint download_network_status;

			public uint[] download_type;

			public string complete_result;

			public string optional_version;

			public bool download_source;

			public string download_entry;
		}

		public List<SingleEvent> bundle_download_info;
	}

	public class EventTypetOptionalBundleDelete : EventLoggerBase
	{
		public uint bundle_id;

		public uint[] download_type;

		public string optional_version;

		public bool delete_recommend;
	}

	public class EventTypeTeamDownload : EventLoggerBase
	{
		public uint member_cnt;

		public bool if_team;
	}

	public class EventTypeVehicleHUDSettingChange : EventLoggerBase
	{
		public class SimpleVehicleHudChange
		{
			public string name;

			public double size;

			public double pos_x;

			public double pos_y;

			public double opacity;
		}

		public int mode;

		public List<SimpleVehicleHudChange> hud;
	}

	public class EventTypeHudSettingChange : EventLoggerBase
	{
		public class SimpleHudChange
		{
			public string name;

			public double size;

			public double pos_x;

			public double pos_y;

			public bool if_hide;

			public double opacity;

			public bool hide_func_on;

			public bool left_aligned_func_on;

			public bool separated_func_on;
		}

		public int pre_preset;

		public int cur_preset;

		public List<SimpleHudChange> hud;

		public bool is_smart_adjust;
	}

	public class EventClickGetAvatarBtn : EventLoggerBase
	{
		public uint avatar_id;

		public uint get_times;

		public uint bundle_times;
	}

	public class EventBackMallCount : EventLoggerBase
	{
		public uint back_mall_count;
	}

	public class EventBooyahClickEquip : EventLoggerBase
	{
		public uint after_emote_id;

		public uint before_emote_id;
	}

	public class EventBooyahEmotePlay : EventLoggerBase
	{
		public uint emote_id;

		public uint play_num;
	}

	public class EventChampionshipClickCount : EventLoggerBase
	{
		public uint championshipType;

		public uint championshipID;

		public uint teamClick;

		public uint entranceClick;
	}

	public class EventRejectGroupInvite : EventLoggerBase
	{
		public ulong inviter_id;

		public ulong group_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint[] map_ids;

		public uint reject_reason;
	}

	public class EventRejectJoinGroup : EventLoggerBase
	{
		public ulong applier_id;

		public ulong group_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint[] map_ids;

		public uint group_type;

		public uint group_size;
	}

	public class EventSystemScreenShot : EventLoggerBase
	{
		public List<string> tags;
	}

	public enum EventLogScene
	{
		None,
		Login,
		Lobby,
		MatchStart,
		InGame,
		MatchEnd
	}

	public enum EventBroadCastType
	{
		None,
		Friends,
		LoudSpeaker,
		Gacha,
		EP,
		InGameDrop
	}

	public enum EventUGCCoverSettingType
	{
		None,
		Scene,
		Local
	}

	public enum EventUGCCoverActionType
	{
		None,
		Add,
		Modify,
		Delete
	}

	public class EventFFAnti : EventLoggerBase
	{
		public uint tick_count;

		public string info;

		public int scene;
	}

	public class EventTypePrimeShare : EventLoggerBase
	{
		public ulong other_account_id;

		public bool is_share_active;

		public bool is_prime;

		public bool is_friend;

		public int remain_times;

		public uint[] item_info;

		public bool is_social_hub;
	}

	public class EventTypePrimeShareSuccess : EventLoggerBase
	{
		public ulong other_account_id;

		public bool is_share_active;

		public bool is_friend;

		public int remain_times;

		public uint[] item_info;

		public bool is_social_hub;
	}

	public enum EPrimeCancelSource
	{
		Vault,
		AvatarInfo,
		EmotePanel,
		CommonReward,
		EmoteDressUpExchange,
		LeaveGroup,
		SharerLeaveGroup
	}

	public class EventTypePrimeShareCancel : EventLoggerBase
	{
		public int source;

		public int remain_times;

		public uint[] item_info;

		public bool is_social_hub;
	}

	public class EventIngameTips : EventLoggerBase
	{
		public uint value;
	}

	public class EventEnterWaitingIsland : EventEnterGame
	{
	}

	public class EventLeaveWaitingIsland : EventLoggerBase
	{
		public ulong match_id;

		public uint tick_count;

		public uint quality;

		public float enter_battery;

		public float leave_battery;

		public bool is_charge;

		public bool is_battle_started;

		public uint resource_load_count;

		public uint game_time;

		public uint group_mode;

		public int ping;

		public int maxping;

		public int ping_total;

		public int ping_b500;

		public int ping_a500;

		public int ping100200;

		public int ping200300;

		public int ping300400;

		public int ping400500;

		public string client_ip;

		public string country;

		public string gameserver_ip;

		public string proxyserver_ip;

		public int gameserver_proxy_port;
	}

	public class IngameEnterGameData
	{
		public int frameCount;

		public float time;

		public float realTime;
	}

	public class EventTrainingLocalGame : EventLoggerBase
	{
		[Serializable]
		public class ShootGameScore
		{
			public int level;

			public uint score;
		}

		public uint shooting_game_play_time;

		public uint ttl_game_play_time;

		public uint boxing_game_play_time;

		public uint vehicle_speed_game_play_time;

		public uint ice_wall_game_play_time;

		public uint ferris_wheel_use_time;

		public uint take_photo_time;

		public uint game_result_share_time;

		public uint craft_gun_use_time;

		public uint zepplin_use_time;

		public uint grenade_game_play_time;

		public uint video_room_play_time;

		public uint stage_visit_time;

		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public uint map_id;

		public uint football_game_play_time;

		public uint football_game_survival_time;

		public uint square_dance_time;

		public List<ShootGameScore> shooting_game_score;
	}

	public class EventCustomRoomVoiceChat : EventLoggerBase
	{
		public ulong room_id;

		public ulong match_id;

		public uint room_type;

		public uint game_mode;

		public uint group_mode;

		public bool is_ob;

		public uint click_mic_cnt;

		public uint click_horn_cnt;

		public bool is_mic_on;

		public bool is_horn_on;

		public CustomRoomVoiceStats voice_stats;
	}

	public class EventGatewayReportFailed : EventLoggerBase
	{
		public string target;

		public string phone_carrier;

		public string client_ip;

		public List<EventGatewayError> errors;
	}

	public class EventGatewayError
	{
		public string error;

		public int cnt;
	}

	public class EventNotificationPopUp : EventLoggerBase
	{
		public List<NoficationPopUpInfo> info;
	}

	public class NoficationPopUpInfo
	{
		public string window_name;

		public uint choice;

		public uint cnt;
	}

	public class EventTrialPickUpWeapon : EventLoggerBase
	{
		public uint item_id;

		public List<uint> pick_up_weapons;

		public int trigger_final_shot_cnt;
	}

	public class EventWereWolvesGame : EventLoggerBase
	{
		public ulong match_id;

		public uint mic_count;
	}

	public class EventLocalNotificationStats : EventLoggerBase
	{
		public class Channel
		{
			public string type;

			public bool if_enable;
		}

		public class TypeCount
		{
			public string type;

			public int cnt;

			public TypeCount(string k, int v)
			{
			}
		}

		public bool if_enable;

		public List<Channel> channels;

		public List<TypeCount> notifies;

		public List<TypeCount> clicks;
	}

	public class EventRemoteNotification : EventLoggerBase
	{
		public string env_name;

		public string task_id;
	}

	public class EventFcmRmtNtfRecv : EventLoggerBase
	{
		public class FcmRmtNtf
		{
			public string env_name;

			public string task_id;

			public long recv_time;
		}

		public FcmRmtNtf[] notifies;
	}

	public class EventTypeEventPushLinkReturn : EventLoggerBase
	{
		public string return_from_url;

		public EEventPush.EventPushType event_push_type;
	}

	public class EventRecruitInfoSend : EventLoggerBase
	{
		public uint account_type;

		public uint active_days;

		public uint active_time;

		public uint mode;

		public uint declaration_type;

		public uint[] send_channel;
	}

	public class EventRecruitQuickSwitchTeam : EventLoggerBase
	{
	}

	public class EventReplaySetting : EventLoggerBase
	{
		public bool if_open;

		public bool if_available;
	}

	public class EventUniversalLinkGoto : EventLoggerBase
	{
		public string universal_link;
	}

	public class EventTypeNewModeGoto : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public uint from;
	}

	public class EventUGCLoginInfo : EventLoggerBase
	{
		public uint ugc_level;

		public uint ugc_exp;
	}

	public class EventTypeCupLoginAnimation : EventLoggerBase
	{
		public bool is_click;

		public uint cup_type;

		public uint cup_id;

		public uint animation_type;
	}

	public class EventTypeVoiceConnectInfo : EventLoggerBase
	{
		public string channel_id;

		public int sdk_tag;

		public bool is_for_loading_channel;

		public int call_join_time_stamp;

		public int call_leave_time_stamp;

		public List<VoiceConnectInfo> info_list;
	}

	public class VoiceConnectInfo
	{
		public bool is_disconnected;

		public int time_stamp;
	}

	public class EventTypeFullScreenAnimation : EventLoggerBase
	{
		public uint id;

		public uint anim_id;

		public uint anim_type;

		public uint system_pos;

		public uint go_pos;

		public string full_screen_resource_id;

		public string skin_resource_list;

		public uint lottery_id;

		public uint lottery_sub_id;

		public uint season;

		public float play_time;

		public float animation_time;

		public uint is_play_actively;
	}

	public class EventTypeGuestSAFPermission : EventLoggerBase
	{
		public int migrate_result;
	}

	public class EventTypeMapSelected : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint[] map_id_list;

		public int rank;

		public int rankPoints;

		public uint level;
	}

	public class EventTypeMatchMakingCancel : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public float wait_time_secs;
	}

	public class EventTypeBanVoice : EventLoggerBase
	{
		public new ulong account_id;

		public new string region;

		public uint behavior_rule_id;
	}

	public class EventTypePopupWindowViewTime : EventLoggerBase
	{
		public class SinglePopupWindowViewTime
		{
			public string window_name;

			public int view_time;

			public int cnt;
		}

		public List<SinglePopupWindowViewTime> views;
	}

	public class EventTypeFriendRecommendPopup : EventLoggerBase
	{
		public ulong recommend_account_id;

		public int status;
	}

	public class EventTypeGroupReadyRemind : EventLoggerBase
	{
		public ulong group_id;

		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public ulong receiver_id;

		public uint receiver_type;

		public bool is_room_match;
	}

	public class EventTypeClickFunnelEnterUGC : EventLoggerBase
	{
		public class SessionInfos
		{
			public string click_name;

			public ulong click_ts;

			public SessionInfos(string name, ulong time)
			{
			}
		}

		public ulong session_id;

		public List<SessionInfos> session_infos;
	}

	public class EventTypeUGCMapComment : EventLoggerBase
	{
		public class CommentInfo
		{
			public uint comment_id;

			public uint comment_num;
		}

		public string workshop_code;

		public List<uint> comment_ids;

		public uint comment_scene;

		public List<CommentInfo> cur_displayed_comments;
	}

	public class EventTypeClickFunnelCreateMap : EventLoggerBase
	{
		public class SessionInfos
		{
			public string click_name;

			public ulong click_ts;

			public SessionInfos(string name, ulong time)
			{
			}
		}

		public ulong session_id;

		public List<SessionInfos> session_infos;
	}

	public enum ECupLoginAnimationType
	{
		BeforeMatchStart,
		AfterMatchStart
	}

	public enum ERecommendPopupStatus
	{
		PopUp,
		Confirm,
		Cancle
	}

	public class EventTypeGroupAnimMVP : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint map_id;

		public ulong match_id;

		public uint anim_id;

		public float play_time;

		public int play_type;

		public bool is_skip;
	}

	public class EventTypeCDNDownloadFail : EventLoggerBase
	{
		public string country;

		public uint platform;

		public List<CdnErrorRequest> cdn_error_requests;
	}

	public class CdnErrorRequest
	{
		public string target_url;

		public string client_ip;

		public string network_type;

		public int fail_type;

		public string fail_reason;

		public CdnErrorRequest(string targetUrl, string clientIP, string networkType, int failType, string failReason)
		{
		}
	}

	public class EventTypeProtocolStats : EventLoggerBase
	{
		public List<ProtocolStats> stats;
	}

	public class ProtocolStats
	{
		public string protocol;

		public List<ProtocolInfo> protocol_info;
	}

	public class ProtocolInfo
	{
		public uint return_time;

		public uint status_code;
	}

	public enum EKellyRunEndReason
	{
		LoadComplete = 1,
		ClickClose
	}

	public class EventTypeKellyRunWebPage : EventLoggerBase
	{
		public List<ClickInfo> click_info;

		public long loading_time;

		public long open_time;

		public uint end_reason;

		public string url;
	}

	public class ClickInfo
	{
		public string click_name;

		public uint cnt;

		public ClickInfo(string clickName, uint cnt)
		{
		}
	}

	public class EventTypeSplashBannerClose : EventLoggerBase
	{
		public uint id;

		public bool if_check;
	}

	public enum PageType
	{
		None,
		Lobby,
		Group,
		Mall,
		GameMode,
		Gacha,
		AvatarProfile,
		Vault,
		Weapon,
		ElitePass,
		Pay,
		Mail,
		Activity,
		Task,
		Pet,
		Lab,
		Profile,
		Chat,
		LeaderBoard,
		Friend,
		Setting,
		Clan,
		ESport,
		LadderMatch,
		Login,
		Build,
		LobbyV2,
		MallV2,
		Gift,
		ClanMainPage,
		ClanActive,
		ClanMember,
		ClanWar1,
		ClanWar2
	}

	public class PageInfo
	{
		public uint page_type;

		public int avg_fps;

		public int min_fps;

		public int fps_count;

		public int max_load_time;

		public int avg_load_time;

		public int load_count;

		public float avg_wait_net_time;

		public int max_wait_net_time;
	}

	public class EventTypeScreenShotShareBarTime : EventLoggerBase
	{
		public uint time;

		public List<string> tags;
	}

	public class EventTypeLobbyPerformanceStats : EventLoggerBase
	{
		public List<PageInfo> page_infos;

		public string cpu_hardware;

		public string gl_render;

		public string gl_version;

		public string device_model;

		public string jank_info;
	}

	public class EventTypeUGCCreatorRecreationSetting : EventLoggerBase
	{
		public uint slot_id;

		public string workshop_code;

		public bool is_allow_recreation;
	}

	public class EventTypeUGCDownloadToRecreation : EventLoggerBase
	{
		public string workshop_code;

		public ulong author_id;

		public uint map_scene;

		public uint slot_id;
	}

	public enum UGCSurveySceneType : uint
	{
		PlatformHome = 1u,
		EditorModeSetting,
		EditorMoreFeedback,
		EditorSaveErrorFeedback,
		EditorDebugErrorFeedback
	}

	public class EventTypeUGCSurveyFeedback : EventLoggerBase
	{
		public uint issue1_option_id;

		public uint[] issue2_option_ids;

		public string detail_comments;

		public uint survey_scene;

		public string[] screenshot_urls;

		public string[] video_urls;

		public string language;

		public string platform;

		public string device_model;

		public string os_version;

		public string project_id;

		public string project_name;

		public string project_url;

		public uint mode_template_id;

		public uint group_mode;

		public string editor_version;

		public string game_version;

		public string resource_version;

		public string network_type;

		public string report_log;
	}

	public class EventTypeUGCMapSurveyURLExposed : EventLoggerBase
	{
		public string workshop_code;

		public uint map_scene;

		public ulong match_id;

		public uint accu_match_cnt;

		public uint click_survey_cnt;
	}

	public class EventTypeUGCOutGameMatchResultPage : EventLoggerBase
	{
		public string workshop_code;

		public ulong match_id;

		public ulong group_id;

		public bool is_like;

		public bool is_dislike;

		public bool is_subs_before;

		public uint subs_action;

		public bool is_click_mapcomment;

		public bool is_click_moremaps;

		public bool is_click_newgame;

		public ulong author_id;
	}

	public class EventTypeUGCCreatorNewbieTask : EventLoggerBase
	{
		public string level_id;

		public string task_id;

		public uint task_status;

		public uint duration;

		public uint entry_source;
	}

	public class EventTypeWeaponExpAddFavorites : EventLoggerBase
	{
		public uint weapon_id;

		public uint weapon_level;

		public uint operation;

		public uint oper_view;
	}

	public class EventTypeEmoteChange : EventLoggerBase
	{
		public uint type;

		public uint position;

		public uint after_emote_id;

		public uint before_emote_id;
	}

	public class EventTypeSuperEmotePlay : EventLoggerBase
	{
		public ulong match_id;

		public uint game_mode;

		public uint match_mode;

		public uint super_emote_id;

		public float play_time;

		public uint type;

		public uint join_play_role_num;
	}

	public class EventTypeSlopeSlideDownDetection : EventLoggerBase
	{
		public class SlidePosition
		{
			public float pos_x;

			public float pos_y;

			public float pos_z;
		}

		public ulong match_id;

		public uint game_mode;

		public uint match_mode;

		public uint map_id;

		public List<SlidePosition> pos_info;
	}

	public class EventTypeMMTotalTime : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public ulong group_id;

		public ulong match_id;

		public uint team_member_count;

		public int ranking_points;

		public double start_time;

		public int total_time_secs;

		public int map_id;

		public uint result;

		public uint build_game_mode;

		public bool is_cs_special_pool;

		public bool is_quick_match;

		public uint cs_special_mode_id;

		public uint mm_place;

		public bool is_fight_on_match;
	}

	public class EventTypeEnterLeaveLobby : EventLoggerBase
	{
		public int quality;

		public int enter_memory;

		public int leave_memory;

		public int fps;

		private static EventTypeEnterLeaveLobby instance;

		public static EventTypeEnterLeaveLobby GetInstance()
		{
			return null;
		}

		public static void EnterLobby()
		{
		}

		public static void LeaveLobby()
		{
		}
	}

	public class EventTypeLoginTime : EventLoggerBase
	{
		public int engine_startup_time;

		public int launcher_loading_time;

		public int sdk_login_time;

		public int server_login_time;

		public int retrieve_version_time;

		public int hotupdate_download_time;

		public string system_software;

		public string system_hardware;

		public string cpu_hardware;

		public int memory;

		public string gl_render;

		public string gl_version;

		public string device_model;

		public int quality;
	}

	public class EventTypeWebViewMemoryOptimization : EventLoggerBase
	{
		public string err_step;

		public string err_msg;

		public ulong size;

		public long time;
	}

	private class EventTypeNetworkSetting : EventLoggerBase
	{
		public bool network_multi_session;
	}

	public class EventTypePreloadResourceStaticsInfo : EventLoggerBase
	{
		public class PreloadResourceInfo
		{
			public string res_path;

			public int get_count;

			public PreloadResourceInfo(string path, int count)
			{
			}
		}

		public int memory_level;

		public int game_mode;

		public int game_time;

		public List<PreloadResourceInfo> preload_infos;
	}

	public class EventTypePoolStaticsInfo : EventLoggerBase
	{
		public class PoolInfo
		{
			public string res_path;

			public int init_count;

			public int free_count;

			public int get_time;

			public int return_time;

			public int pool_size;

			public int instant_new_time;
		}

		public int memory_level;

		public int game_mode;

		public int game_time;

		public List<PoolInfo> pool_infos;
	}

	public class EventTypeApplyLoadoutPlan : EventLoggerBase
	{
		public uint plan_type;

		public uint plan_id;

		public uint avatar_status;

		public uint loadout_status;

		public uint pet_status;

		public bool if_copy;
	}

	public class EventTypeLoadoutPlanRename : EventLoggerBase
	{
		public string name;
	}

	public class EventTypeLocTranslationUseInfo : EventLoggerBase
	{
		public int game_mode;

		public int game_time;

		public List<uint> loc_trans_use_list;
	}

	public class EventTypeWeaponGlorySetting : EventLoggerBase
	{
		public uint cfg_id;

		public ulong leaderboard_id;

		public uint weapon_id;

		public uint rank;

		public bool is_active;
	}

	public class EventTypeUGCCustomCoverSetting : EventLoggerBase
	{
		public uint slot_id;

		public uint slot_type;

		public string workshop_code;

		public uint setting_scene;

		public uint setting_mode;

		public uint action;
	}

	public class EventTypeUGCPlatformStudioSetting : EventLoggerBase
	{
		public bool pre_allow_maps_viewed;

		public bool cur_allow_maps_viewed;
	}

	public class EventTypeAITextFuzzySearchDetail : EventLoggerBase
	{
		public class SearchInfo
		{
			public uint target_item_id;

			public uint target_item_rank;
		}

		public string input_text;

		public List<uint> output_item_ids;

		public uint target_item_id;

		public uint target_item_rank;

		public uint selection_order;

		public List<SearchInfo> target_item_info;

		private static EventTypeAITextFuzzySearchDetail eventLog;

		public static void Record(uint target_item_id, uint target_item_rank)
		{
		}

		public static void SendLog(string input_text, List<uint> output_item_ids)
		{
		}
	}

	public class EventTypeAIThemeGenerationInfo : EventLoggerBase
	{
		public class ItemInfo
		{
			public uint item_id;

			public string position_x;

			public string position_y;

			public string position_z;
		}

		public class PointInfo
		{
			public string point_x;

			public string point_y;

			public string point_z;
		}

		public uint slot_id;

		public string workshop_code;

		public uint theme_id;

		public List<ItemInfo> item_info;

		public List<PointInfo> generation_area_info;

		public bool is_refreshed;

		public uint map_id;

		public uint map_area_id;

		public uint plan_slot_id;

		public uint slot1_refresh_cnt;

		public uint slot2_refresh_cnt;
	}

	public class EventTypeAIAssistantModeParaTuning : EventLoggerBase
	{
		public class ParaNavigateInfo
		{
			public int para_id;

			public int para_cnt;

			public int navigate_cnt;
		}

		private sealed class _003C_003Ec__DisplayClass2_0
		{
			public int id;

			internal bool _003CRecord_003Eb__0(ParaNavigateInfo info)
			{
				return false;
			}
		}

		public List<ParaNavigateInfo> para_navigate_info;

		public static void Record(int id, bool parse, bool navigate)
		{
		}

		public static void SendCacheLog()
		{
		}
	}

	public class EventTypeLLMResponseTimeClient : EventLoggerBase
	{
		public class ResponseInfo
		{
			public string persona_id;

			public int response_time;
		}

		public string workshop_code;

		public ulong match_id;

		public string chat_room_id;

		public List<ResponseInfo> response_info;

		private static EventTypeLLMResponseTimeClient eventLog;

		public static void Record(string personaID, int responseTime)
		{
		}

		public static void SendLog(string roomID)
		{
		}
	}

	public class EventTypeAITextFuzzySearchDetailBlock : EventLoggerBase
	{
		public class SearchInfo
		{
			public string target_block_name;

			public uint target_block_rank;
		}

		public string input_text;

		public List<string> output_block_names;

		public string target_block_name;

		public uint target_block_rank;

		public uint selection_order;

		public List<SearchInfo> target_block_info;

		private static EventTypeAITextFuzzySearchDetailBlock eventLog;

		public static void Record(string target_block_name, uint target_block_rank)
		{
		}

		public static void SendLog(string input_text, List<string> output_block_names)
		{
		}
	}

	public class EventTypeUGCSubscribeToCraftlandUpdate : EventLoggerBase
	{
		public ulong match_id;

		public bool if_like;

		public bool if_subs;

		public int choose;
	}

	public class EventTypeUGCPlatformHomeSettingChange : EventLoggerBase
	{
		public bool pre_subs_to_update;

		public bool cur_subs_to_update;

		public uint pre_subs_to_update_new;

		public uint cur_subs_to_update_new;

		public bool pre_translate;

		public bool cur_translate;
	}

	public class EventTypeMicVoiceSetting : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public ulong match_id;

		public int rank;

		public uint level;

		public bool if_ingame;

		public uint mic_setting;

		public uint voice_setting;

		public VoiceChangerInfo voice_changer_info;
	}

	public class VoiceChangerInfo
	{
		public int is_open;

		public int voice_changer;
	}

	public class EventTypeRoomStatusChange : EventLoggerBase
	{
		public ulong room_id;

		public uint game_mode;

		public uint group_mode;

		public uint room_type;

		public int pre_active_status;

		public int cur_active_status;
	}

	public class EventTypeBuildSystemSetting : EventLoggerBase
	{
		public int build_id;

		public bool is_paste;

		public bool is_recommend;

		public uint recommend_type;

		public uint recommend_id;

		public string pre_build_name;

		public string cur_build_name;

		public uint pre_game_mode;

		public uint cur_game_mode;

		public uint pre_avatar_id;

		public uint cur_avatar_id;

		public uint[] pre_equipped_skills;

		public uint[] cur_equipped_skills;

		public uint pre_pet_id;

		public uint cur_pet_id;

		public uint pre_pet_skill;

		public uint cur_pet_skill;

		public uint pre_loadout_id;

		public uint cur_loadout_id;

		public uint recommend_game_mode;

		public uint recommend_role;

		public ulong recommend_account_id;
	}

	public class EventTypeBuildSystemApply : EventLoggerBase
	{
		public int build_id;

		public uint build_game_mode;

		public uint avatar_id;

		public uint[] equipped_skills;

		public uint pet_id;

		public uint pet_skill;

		public uint loadout_id;
	}

	public class EventTypePackCheckBoxStats : EventLoggerBase
	{
		public bool is_show_in_lobby;

		public bool is_show_in_cs_game;

		public bool is_show_in_other_game;
	}

	public class EventTypeTrainingStats : EventLoggerBase
	{
		public uint train_time;

		public uint target_dmg;

		public uint real_target_kills;

		public uint real_target_dmg;
	}

	public class EventTypeSocialIslandInvite : EventLoggerBase
	{
		public ulong invitee;

		public ulong inviter;
	}

	public class EventTypeTrainingInvite : EventLoggerBase
	{
		public ulong invitee;

		public ulong inviter;
	}

	public class EventTypeAcceptSocialIslandInvite : EventLoggerBase
	{
		public ulong invitee;

		public ulong inviter;
	}

	public class EventTypeAcceptTrainingInvite : EventLoggerBase
	{
		public ulong invitee;

		public ulong inviter;
	}

	public class EventTypeJoinOtherSocialIsland : EventLoggerBase
	{
		public ulong target_id;
	}

	public class EventTypeJoinOtherTraining : EventLoggerBase
	{
		public ulong target_id;
	}

	public class EventTypeGuildWarCabinPanelViewTime : EventLoggerBase
	{
		public ulong clan_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public ulong group_id;

		public ulong match_id;

		public ulong view_time;
	}

	public class EventTypeExpansionGroupMode : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public uint before_group_mode;

		public uint after_group_mode;

		public uint type;

		public ulong receiver_id;

		public ulong group_id;
	}

	public class EventTypeOutGameReport : EventLoggerBase
	{
		public uint report_scene;

		public ulong reportee;

		public uint reason;

		public string extra_info;
	}

	public class EventTypeClanReport : EventLoggerBase
	{
		public ulong clan_id;

		public string clan_name;

		public uint report_reason;

		public string slogan;
	}

	public class EventTypeFFAssist : EventLoggerBase
	{
		public List<EventTypeAssistInfos> assist_infos;
	}

	public class EventTypeAssistInfos
	{
		public uint name;

		public uint type;
	}

	public class EventTypeFFAssistNotice : EventLoggerBase
	{
		public enum EAssistTabType
		{
			NONE,
			REWARD,
			FRIEND_REQUEST,
			CLAN_INVITE,
			CLAN_REQUEST,
			BUSINESS_TIPS,
			WISHITEM,
			EXPIREDTEAMUP,
			GETGIFT,
			EXPIREDTOURNAMENT,
			BATTLE_REPORT
		}

		public List<EventTypeAssistNoticeInfos> notice_infos;
	}

	public class EventTypeAssistNoticeInfos
	{
		public uint tab_id;

		public uint cnt;

		public List<string> id_list;
	}

	public class EventTypeReturnUserRemind : EventLoggerBase
	{
		public ulong[] reminded_ids;
	}

	public class EventTypeLoginSummary : EventLoggerBase
	{
		public int br_ranking_points;

		public int cs_ranking_points;

		public string br_ranking_name;

		public string cs_ranking_name;

		public string AHLR;

		public string AHLC;
	}

	public class EventTypeUGCCreateRoomParamSetting : EventLoggerBase
	{
		public ulong room_id;

		public string workshop_code;

		public bool is_locked;

		public List<EventLogRoomParamSettingItem> room_param_setting;
	}

	public class EventLogRoomParamSettingItem
	{
		public long id;

		public int value_type;

		public int value_1;

		public float value_2;

		public int[] value_3;

		public bool value_4;
	}

	public class EventTypeUGCConfirmResDownload : EventLoggerBase
	{
		public uint download_scene;

		public uint tag_type_id;

		public string workshop_code;

		public float res_size;
	}

	public class EventTypeHUDSettingInfo : EventLoggerBase
	{
		public int preset_apply;

		public bool is_preset_modify;
	}

	public class SettingContentBase : EventLoggerBase
	{
		public int local_version;

		public int server_version;

		public string MD5;

		public string base_code;
	}

	public class EventTypeClientSettingDownloadInfo : SettingContentBase
	{
		public int type;

		public bool is_success;

		public int reason;
	}

	public class EventTypeClientSettingUploadInfo : SettingContentBase
	{
		public int upload_type;

		public bool is_success;

		public int reason;
	}

	public class EventTypeFirstLaunchLocalSetting : SettingContentBase
	{
	}

	public class EventTypeQuickMessageSetting : EventLoggerBase
	{
		public uint pre_vocal;

		public uint cur_vocal;

		public List<EventTypeQuickMessageSettingItem> message_info;

		public int entrance;
	}

	public class EventTypeQuickMessageSettingItem
	{
		public uint message_game_mode;

		public uint[] pre_list_message_ids;

		public uint[] cur_list_message_ids;

		public uint[] pre_roulette_message_ids;

		public uint[] cur_roulette_message_ids;
	}

	public class EventTypeStoreVersion : EventLoggerBase
	{
		public string start_time;

		public string end_time;
	}

	public enum ELobbyMessageSceneId
	{
		Chat = 1,
		Team,
		TeamInfo
	}

	public class EventTypeLobbyMessage : EventLoggerBase
	{
		public uint message_id;

		public uint channel_type;

		public uint scene_id;
	}

	public class EventTypePlayerSurvey : EventLoggerBase
	{
		public uint game_mode;

		public ulong match_id;

		public uint type;

		public List<EventTypePlayerSurveyIssueInfo> issue1_info;

		public List<EventTypePlayerSurveyIssueInfo> issue2_info;
	}

	public class EventTypeAntiAddictionBindPhone : EventLoggerBase
	{
		public int oper_type;

		public string phone;

		public string original_phone;

		public string result;
	}

	public class EventTypeAntiAddictionChoose : EventLoggerBase
	{
		public bool if_age;

		public bool if_first;
	}

	public class EventTypeAntiAddictionChooseBR : EventLoggerBase
	{
		public bool is_skipped;

		public string age_group;

		public string verification_status;

		public int trigger_scene;

		public string ip_region;

		public int age_state;
	}

	public class EventTypeAntiAddictionPrecheckIPUS : EventLoggerBase
	{
		public string ip_region;

		public bool is_minor;

		public bool is_valid_region;
	}

	public class EventTypeAntiAddictionChooseIPUS : EventLoggerBase
	{
		public class ExtraInfo
		{
			public bool is_error_login;
		}

		public string device_id;

		public string ip_region;

		public string api_type;

		public string install_id;

		public string age;

		public string result;

		public bool is_allowed;

		public string extra_info;
	}

	public class EventTypeAntiAddictionBanAckIPUS : EventLoggerBase
	{
		public string ip_region;

		public string install_id;
	}

	public class EventTypeAntiAddictionBan : EventLoggerBase
	{
		public bool if_play;

		public int trigger_scene;
	}

	public class EventTypePlayerSurveyIssueInfo
	{
		public uint pre_question_id;

		public uint id;

		public uint[] options;

		public string text;
	}

	public class EventTypeScanQRCodeInfo : EventLoggerBase
	{
		public uint scan_source;

		public uint qr_code_type;

		public uint op_result;

		public uint qr_code_source;

		public uint qr_code_generation_channel;
	}

	public enum UserActionUI
	{
		Inventory,
		BigMap,
		Setting,
		InGameShop,
		SwitchOB,
		EnterSap,
		Leaderboard,
		Emote,
		Medkit,
		RouletteMedkit,
		CameraSystem,
		PickUpList,
		SwitchUIGroup,
		TcpHttp,
		CSRoundResult,
		LuckyDrawBox,
		ExecuteSkill,
		AIAgent,
		CollectionTransformer,
		CollectionAction,
		Chat,
		PetAnim,
		ReportFeedBack,
		Custom,
		HurtHint,
		DeadUI,
		ReviveUI,
		CabinWaitingWish,
		VehicleObserverHud
	}

	public enum JankStatus
	{
		CreateShader,
		ParseShader,
		UnloadUnusedAssets
	}

	public enum EGameTimeType
	{
		EnterPVP,
		LeavePVP
	}

	public enum EDisconnectionType
	{
		TCP,
		UDP_ENTER,
		UDP_INGAME,
		UDP_LOGIN_GS_LOADING_TIMEOUT,
		LOADING_SCENE_FAILED
	}

	public enum BuildVariantType
	{
		Normal,
		Max
	}

	public class ExtraInfo
	{
		public int[] cur_rate;

		public bool support_etc2;
	}

	public class EventLoginInfo
	{
		public ulong account_id;

		public string game_server_id;

		public string event_time;

		public string game_id;

		public int plat_id;

		public int zone_area_id;

		public string client_version;

		public string client_version_code;

		public string system_software;

		public string system_hardware;

		public string system_graphics_api;

		public uint supported_astc_bitset;

		public string telecom_oper;

		public string network;

		public int screen_width;

		public int screen_hight;

		public string dpi;

		public string cpu_hardware;

		public int memory;

		public string gl_render;

		public string gl_version;

		public string device_id;

		public string client_ip;

		public string language;

		public string open_id;

		public string open_id_type;

		public string device_type;

		public string device_model;

		public string region;

		public string others;

		public int sdcard_total_storage;

		public int sdcard_avail_storage;

		public int inner_total_storage;

		public int inner_avail_storage;

		public string lib_token;

		public bool if_push;

		public bool is_vpn;

		public string network_operator_a;

		public string network_type_a;

		public string signature_md5;

		public int game_installed_disk_avail_storage;

		public int game_installed_disk_total_storage;

		public int external_sdcard_avail_storage;

		public int external_sdcard_total_storage;

		public string cpu_architecture;

		public uint android_engine_init_flag;

		public uint channel_type;

		public uint cpu_type;

		public uint loading_time;

		public string extra_info;
	}

	public enum SharePlatform
	{
		None = 0,
		Garena = 1,
		Facebook = 2,
		VKontakte = 3,
		Line = 4,
		FacebookMessenger = 5,
		CopyLink = 6,
		WorldChannel = 7,
		GuildChannel = 8,
		Download = 9,
		WhatsApp = 10,
		Instagram = 11,
		FriendChannel = 12,
		CopyShareCode = 13,
		TipTok = 14,
		System = 99
	}

	[Serializable]
	public class ScanIAPInventoryResult
	{
		public string item_identifier;

		public string error;

		public bool success;

		public int amount;

		public bool promotion;
	}

	public enum ChampioshipClickType
	{
		Entrance,
		Team
	}

	public enum ClickType
	{
		None = 0,
		Setting = 1,
		Pay = 2,
		Lobby = 3,
		Integrate = 4,
		Avatar = 5,
		AvatarProfile = 6,
		Inventory = 7,
		UniversalDebrisWindow = 8,
		Friend = 9,
		Chat = 10,
		IAP = 11,
		Activity = 12,
		ElitePass = 14,
		Mall = 15,
		Gacha = 17,
		WeaponSkinLobby = 19,
		Championship = 20,
		WeaponSkinUpgrader = 21,
		Profile = 22,
		Pet = 25,
		Clan = 26,
		LiveTv = 27,
		LeaderBoard = 29,
		CommonPopMenu = 30,
		Reservation = 31,
		HudVehicleHorn = 32,
		WeaponRack = 33,
		Forge = 34,
		PortraitCloseup = 35,
		DriftBottleAddFriend = 38,
		FFWS = 39,
		CSWebTutorial = 40,
		TokenTips = 42,
		HDVehicleDisplay = 43,
		HDWeaponRack = 44,
		MatchResult = 45,
		CupMatch = 46,
		HDIceWallDisplay = 47,
		Sutorito = 48,
		Workshop = 49,
		FourSymbols = 50,
		TopUpEvent = 53,
		MallPurchaseWnd = 54,
		HDSkyboardDisplay = 56,
		ClanWarRecruit = 57,
		CSWeaponShop = 58,
		Veteran = 59,
		NewPlayer = 60,
		NewVault = 61,
		TutorialInGame = 62,
		AvatarLink = 63,
		DressUp = 64,
		MatchResultReward = 65,
		HudInGame = 66,
		TraningCamp = 67,
		BigEvent = 77,
		BigEventTemplate = 78,
		QuitInGame = 79,
		Mail = 80,
		LadderMatch = 81,
		Preview = 82,
		HyperBook = 83,
		Lab = 84,
		FlashStore = 85,
		SecretMessage = 86,
		Medkit = 87,
		Grenade = 88,
		SingersBMatchMakingType = 89,
		SingersMoiveCamera = 90,
		Replay = 91,
		VirtualBrand = 92,
		WeaponSkinPokedex = 93,
		WebEvent = 94,
		BooyahPass = 95,
		MileStone = 96,
		WeaponProficiency = 97,
		Achievement = 98,
		WorldChannelSloganBubble = 99,
		AntiHackCenter = 100,
		VerticalPreview = 101,
		VerticalPreviewShare = 102,
		Tailor = 103,
		HuntingGround = 104,
		ScreenShotMessageWindow = 105,
		ElitePassChallenge = 106,
		SettingAdvice = 107,
		SettingPage = 108,
		NetworkSettingAdvice = 109,
		Loadout = 110,
		EvoGun = 111,
		SkinModCheck = 112,
		ReplayKit = 113,
		BuildSystem = 114,
		RoomHangup = 115,
		ModeInfo = 116,
		LadderLeaderBoard = 117,
		ReconnectInGame = 118,
		TitleShow = 119,
		LobbyV2 = 120,
		ShoppingMall = 121,
		QuickMatch = 122,
		VeteranReview = 123,
		PatchNote = 124,
		HistoryUpdate = 125,
		TrainShop = 126,
		PreviewComponent = 127,
		DownloadCentre = 128,
		SeasonYear = 129,
		NewPlayerIAP = 130,
		GameAssistantLobbyEntry = 131,
		SeasonReplay = 132,
		VeteranStore = 133,
		WishList = 134,
		FriendReunion = 135,
		NewRecruit = 136,
		UIBigMap = 137,
		LobbyEmote = 138,
		Occupation = 139,
		EvoPass = 140,
		OTP = 141,
		NewPlayerSurveyPop = 142,
		MapLegend = 143,
		LadderMatchTask = 144,
		WeaponSkinCustom = 145,
		HudCDNGuide = 146,
		InGameSocialTrain = 147,
		ProfileCustom = 148,
		NewBieOffer = 149,
		LadderLeaderBoardTitleRewardWnd = 150,
		NBCollection = 151,
		CreateRoom = 152,
		CustomRoom = 153,
		NewCollectionPopWnd = 154,
		WeaponSkinNewbieRecommendWnd = 155,
		AIChat = 156,
		Gift = 157,
		CraftlandMembership = 158,
		UGCPremiumCenterBenefitMap = 159,
		LaunchTag = 160,
		HippoCrisis = 161,
		CollectionTrial = 162,
		Voice = 163,
		RankingTips = 164,
		QRCode = 165,
		Prime = 166,
		CameraMode = 167,
		CSPeakTournament = 168,
		IPCollab = 169,
		GameModeMain = 170,
		RoomList = 171,
		ItemGenMainEntrance = 172,
		ItemGenSlotEntrance = 173,
		TakePhotoGroup = 174,
		KolHud = 175,
		RelayMart = 176,
		TeamParachute = 177,
		DrawShop = 178,
		Rematch = 179,
		HUDShare = 180,
		CollectionCustom = 181,
		PresetPick = 182,
		SparkPet = 183,
		RoomOB = 184,
		BRMatchReview = 185
	}

	public enum EventLog_Optional_Operation
	{
		None,
		Delete
	}

	public enum ESingersBMiniGameLogType
	{
		ESingersBMiniGameLogType_Stick = 1,
		ESingersBMiniGameLogType_Buff,
		ESingersBMiniGameLogType_CallDance
	}

	public class EventClientPushSetting : EventLoggerBase
	{
		public bool friend_apply_push;

		public bool is_support_hardware_decoding;

		public int max_login_video;

		public int max_lobby;

		public int max_lobby_motion;

		public int max_audio_style;

		public int max_animation;

		public int max_special_effects;

		public int max_hd_texture;

		public int max_vehicle_VFX;

		public bool is_first_login;

		public string device_model;
	}

	public class EventTypeBigBannerGoto : EventLoggerBase
	{
		public int goto_pos;

		public string sub_goto_pos;
	}

	public class EventTypeFriendRecommend : EventLoggerBase
	{
		public int recommend_type;

		public ulong recommend_account_id;

		public int recommend_account_rank;

		public bool if_shield;

		public int choose;

		public int cur_friend_num;
	}

	public class EventTypeMaxLobbyYard : EventLoggerBase
	{
		public int edit_time;
	}

	public class EventTypeMVPInfo : EventLoggerBase
	{
		public ulong match_id;

		public string ip_region;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;

		public uint rank;

		public bool is_mvp;
	}

	public class EventTypeRegisterIntitle : EventLoggerBase
	{
		public uint intitle_time;
	}

	public class EventTypeNewbieTrigger : EventLoggerBase
	{
		public bool if_newbie_choice;
	}

	public class EventTypeReplaySaveStats : EventLoggerBase
	{
		public bool if_success;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public byte rank;
	}

	public class EventTypeBRTacticalReview : EventLoggerBase
	{
		public ulong match_id;

		public int duration_time;

		public int review_time;

		public int match_time;

		public int channel;
	}

	public class EventTypeHighlightsTrigger : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint map_id;

		public ulong match_id;

		public uint time;
	}

	public class EventTypeReplaySaveInfo : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint map_id;

		public ulong match_id;

		public uint channel;

		public bool if_highlights;

		public uint replay_time;

		public uint highlights_time;

		public byte rank;

		public List<HightlightEventInfoData> highlight_event_info;
	}

	public class HightlightEventInfoData
	{
		public uint event_type;

		public uint time;
	}

	public class HightlightEventPlayInfoData
	{
		public uint event_type;

		public uint play_cnt;

		public uint complete_cnt;
	}

	public class ReplayVideoInfo
	{
		public int video_type;

		public int total_time;

		public int video_time;

		public int stop_reason;
	}

	public class EventTypeReplayPlayInfo : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint map_id;

		public ulong match_id;

		public int channel;

		public uint play_type;

		public uint view_time;

		public uint total_time;

		public bool is_clicked_speed_playback;

		public bool is_cancel_music;

		public List<uint> total_highlight_event_list;

		public List<uint> play_highlight_event_list;

		public List<HightlightEventPlayInfoData> highlight_event_play_info;

		public List<ReplayVideoInfo> video_info;

		public bool is_video_met;

		public bool is_auto_video;

		public void SetHighlightEvent(List<ReplayHighlightEvent> evtList)
		{
		}

		public void SetPlayHighlightEvent(HashSet<uint> evtList)
		{
		}

		public void AddVideoInfo(ReplayVideoInfo videoInfo)
		{
		}
	}

	public class EventTypeHighLightFilterSetting : EventLoggerBase
	{
		public uint event_id;

		public ulong match_id;

		public bool if_check;
	}

	public class EventTypeCupLobbyResult : EventLoggerBase
	{
		public ulong match_id;

		public bool if_show;

		public bool is_draw;
	}

	public class EventTypeCDNTransferTrafficMonitor : EventLoggerBase
	{
		public uint type;

		public ulong transfer_size;

		public uint transfer_time;
	}

	public class EventTypeWorkshopSceneEdit : EventLoggerBase
	{
		public class SaveErrorInfo
		{
			public uint error_type;

			public uint cnt;
		}

		public class ExportBlockInfo
		{
			public string export_id;

			public uint block_cnt;
		}

		public class ImportBlockInfo
		{
			public string import_id;

			public uint block_cnt;

			public int result;
		}

		public class TimelineTrackInfo
		{
			public string parent_track_type;

			public string child_track_type;

			public uint track_count;
		}

		public class TimelineAnimationTrackInfo
		{
			public string resource_id;

			public uint resource_cnt;
		}

		public class TimelineAudioTrackInfo
		{
			public string resource_id;

			public uint resource_cnt;
		}

		public uint scene_edit_time;

		public uint close_shelf_cnt;

		public uint close_shelf_time;

		public uint change_camera_cnt;

		public uint free_camera_time;

		public uint adjust_floor_up_times;

		public uint adjust_floor_down_times;

		public float adjust_floor_max_height;

		public uint top_view_time;

		public uint top_view_cnt;

		public uint max_grouped_cnt;

		public uint slot_id;

		public string workshop_code;

		public uint game_mode;

		public uint debug_time;

		public uint debug_cnt;

		public uint save_cnt;

		public uint intersection_edit_time;

		public List<SaveErrorInfo> save_error_infos;

		public uint click_console_cnt;

		public uint click_console_link_cnt;

		public bool is_new_created;

		public bool is_change_items;

		public bool is_click_setting;

		public bool is_click_mode_setting;

		public bool is_enter_eca_edit;

		public int eca_edit_time;

		public bool is_enter_ui_edit;

		public int ui_edit_time;

		public List<ExportBlockInfo> export_block_infos;

		public List<ImportBlockInfo> import_block_infos;

		public uint custom_game_mode;

		public string original_workshop_code;

		public int edit_mode_when_enter;

		public int edit_mode_when_exit;

		public int edit_mode_switch_cnt;

		public int crosshair_edit_time;

		public int pointdrag_edit_time;

		public uint map_id;

		public uint map_area_id;

		public int move_edit_cnt;

		public int zoom_edit_cnt;

		public int rotate_edit_cnt;

		public int copy_btn_cnt;

		public int multi_choose_btn_cnt;

		public int combine_btn_cnt;

		public int uncombine_btn_cnt;

		public int axis_mode_edit_time;

		public int text_display_edit_time;

		public int grid_mode_edit_time;

		public int shelf_item_detail_btn_cnt;

		public int select_mode_btn_cnt;

		public int axis_mode_btn_cnt;

		public int text_display_btn_cnt;

		public int grid_mode_btn_cnt;

		public int mesh_granularity_btn_cnt;

		public int team_invite_btn_cnt;

		public int free_layout_btn_cnt;

		public int combine_mode_btn_cnt;

		public int clear_objects_btn_cnt;

		public int team_num_btn_cnt;

		public int team_member_btn_cnt;

		public int round_num_btn_cnt;

		public int preparation_time_btn_cnt;

		public int match_time_btn_cnt;

		public int max_hp_btn_cnt;

		public int move_speed_btn_cnt;

		public int unlimited_icewalls_btn_cnt;

		public int unlimited_ammo_btn_cnt;

		public int unlimited_throwables_btn_cnt;

		public int passive_skills_btn_cnt;

		public int active_skills_btn_cnt;

		public int pet_skills_btn_cnt;

		public int more_setting_btn_cnt;

		public uint resource_manager_usage_time;

		public uint pre_auto_save_setting;

		public uint cur_auto_save_setting;

		public uint auto_save_succes_cnt;

		public uint auto_save_fail_cnt;

		public uint timeline_asset_cnt;

		public List<TimelineTrackInfo> timeline_track_info;

		public uint timeline_track_edit_time;

		public uint timeline_scene_edit_time;

		public uint timeline_asset_avg_duration;

		public bool is_halfway_join_enabled;

		public List<uint> timeline_switch_camera_track_cnt;

		public uint timeline_camera_track_fpv_edit_time;

		public uint timeline_camera_track_normal_edit_time;

		public List<TimelineAnimationTrackInfo> timeline_animation_track_info;

		public List<TimelineAudioTrackInfo> timeline_audio_track_info;

		public uint timeline_event_track_send_cnt;

		public uint timeline_audience_pers_btn_cnt;
	}

	public class EventTypeUGCRequestGameDataURL : EventLoggerBase
	{
		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public ulong match_id;

		public bool is_ingame_join;

		public int memory;

		public long inner_avail_storage;

		public uint quality;

		public int retry_times;

		public int request_result;

		public ulong pre_match_id;

		public string pre_workshop_code;
	}

	public class EventTypeUGCLoadingGameDataDownload : EventLoggerBase
	{
		public enum DownloadResult
		{
			Success,
			LackOfStorage,
			NetworkError,
			Timeout,
			ForceEnded
		}

		public enum TimeoutErrorCode
		{
			Total,
			Connection,
			Progress
		}

		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public ulong match_id;

		public bool is_ingame_join;

		public bool is_ingame_join_allowed;

		public bool is_ingame_join_time_limit;

		public int ingame_join_time_limit;

		public bool is_ingame_join_num_limit;

		public int ingame_join_num_limit;

		public int memory;

		public long inner_avail_storage;

		public uint quality;

		public int retry_times;

		public ulong downloaded_size;

		public bool is_client_cache;

		public int downloaded_result;

		public int timeout_errorcode;

		public ulong pre_match_id;

		public string pre_workshop_code;
	}

	public class EventTypeUGCLoadingResDownload : EventLoggerBase
	{
		public enum DownloadResult
		{
			Success,
			LackOfStorage,
			Other
		}

		public uint match_mode;

		public uint game_mode;

		public string workshop_code;

		public ulong match_id;

		public bool is_ingame_join;

		public bool is_ingame_join_allowed;

		public bool is_ingame_join_time_limit;

		public int ingame_join_time_limit;

		public bool is_ingame_join_num_limit;

		public int ingame_join_num_limit;

		public int memory;

		public long inner_avail_storage;

		public uint quality;

		public int res_size;

		public uint downloaded_result;

		public ulong pre_match_id;

		public string pre_workshop_code;
	}

	public class EventTypeUGCCustomModeMapContent : EventLoggerBase
	{
		public class GraphInfo
		{
			public long entity_type;

			public string entity_id;

			public string graph_id;
		}

		public class BlockInfo
		{
			public int block_id;

			public int block_cnt;

			public string graph_id;
		}

		public class HudInfo
		{
			public uint hud_id;

			public bool is_bind_graph;

			public uint image_control_cnt;

			public uint text_control_cnt;

			public uint button_control_cnt;
		}

		public enum ResourceType
		{
			vfx = 1,
			audio,
			icon,
			item,
			ugcObject
		}

		public class ResourceInfo
		{
			public uint resource_type;

			public string resource_id;

			public uint resource_cnt;
		}

		public uint slot_id;

		public string workshop_code;

		public uint map_id;

		public uint game_mode;

		public uint custom_game_mode;

		public readonly List<GraphInfo> graph_infos;

		public readonly List<BlockInfo> block_infos;

		public readonly List<HudInfo> hud_infos;

		public readonly List<ResourceInfo> resource_infos;

		public bool is_eco_on;

		public void AddResourceInfo(ResourceInfo info)
		{
		}
	}

	public class EventTypePermanentValueToWeaponSkin : EventLoggerBase
	{
		public uint weapon_skin_id;

		public uint cur_permanent_value;

		public uint acc_permanent_value;
	}

	public enum MatchMakingPlaceEnum
	{
		None,
		Lobby,
		SocialArea,
		TrainingArea,
		QuickMatch,
		LobbySocialArea
	}

	public enum CPUFreqRecordType
	{
		ENTERGAME,
		LOCALPLAYERDEAD
	}

	public class EventCPUFreq : EventLoggerBase
	{
		public string device_model;

		public bool is_under_clock;

		public int cpu_index;

		public List<long> cpu_start_clock;

		public List<long> cpu_end_clock;
	}

	public class EventCPUFreq_RuntimeData
	{
		public static bool EnableLogCPU0or4;

		public static readonly int MaxSampleCPUNum;

		public static readonly int BigLittleCoreTestNum;

		public static readonly int CPUFreqSampleTimes;

		public static readonly int CPUFreqSampleIntervalFrames;

		public static readonly float FirstSampleDelaySec;

		public CPUFreqRecordType RecordType;

		public bool Recording;

		public bool IsUnderClock;

		public int LeftWaitingTimes;

		public int SampledCpuNum;

		public List<int> CpuIndices;

		public List<List<List<long>>> CpuFrequencies;

		public List<List<long>> CurSampleFreq;

		public List<uint> DelayCallSampleIDs;
	}

	public class EventTypeScreenRecordSaveStats : EventLoggerBase
	{
		public bool if_success;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public int video_time;

		public int type;
	}

	public class EventTypeScreenRecordSetting : EventLoggerBase
	{
		public bool if_available;

		public bool if_replay_voice;

		public bool if_gameplay_screen_record;

		public bool if_system_screen_record;

		public int type;
	}

	public class EventTypeHighPingPopUp : EventLoggerBase
	{
		public int group_mode;

		public uint choice;
	}

	public class EventTypeScreenRecordDeleteStats : EventLoggerBase
	{
		public int video_time;

		public int type;
	}

	public class EventTypeItemExposed : EventLoggerBase
	{
		public string first_tab;

		public List<ExposedItem> items;
	}

	public class ExposedItem
	{
		public uint item_id;

		public uint cnt;
	}

	public class FPSData
	{
		public int fps;

		public int step;

		public float fps_devi;

		public uint fps_data_total_count;

		public uint fps_data_b10_count;

		public uint fps_data_b10_conti_count;

		public uint fps_data_b20_count;

		public int jitter_count;

		public uint jank_count;

		public uint big_jank_count;

		public float max_jank_game_time;

		public float max_jank_duration;

		public float stutter_percent;
	}

	public enum ChooseBRTriggerScene
	{
		None,
		Login,
		InGame
	}

	public enum AntiAddictionBanTriggerScene
	{
		None,
		TimeLimit,
		PayLimit
	}

	public class EventTypeMinorChatReport : EventLoggerBase
	{
		public string nickname;

		public int chat_type;

		public List<AdultAccounts> adult_accounts;
	}

	public class AdultAccounts
	{
		public ulong adult_account_id;

		public string adult_account_nickname;

		public int channel_type;

		public ulong time;
	}

	public enum MinorChatType
	{
		Text = 1,
		Voice
	}

	public class EventTypeUGCCustom : EventLoggerBase
	{
		public ulong match_id;

		public uint round_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint custom_game_mode;

		public uint map_id;

		public string workshop_code;

		public string custom_infos;
	}

	public class EventTypeUGCCreativeModeRoundStatsClient : EventLoggerBase
	{
		public ulong match_id;

		public uint round_id;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public uint custom_game_mode;

		public uint map_id;

		public string workshop_code;

		public string custom_infos;
	}

	public class EventTypeMetropolisChatSummary : EventLoggerBase
	{
		public ulong match_id;

		public uint map_id;

		public uint level;

		public uint match_mode;

		public uint game_mode;

		public uint group_mode;

		public ulong group_id;

		public uint chat_click_cnt;

		public uint police_word_message_cnt;

		public uint criminal_word_message_cnt;

		public uint word_channel_shield_cnt;

		public uint word_channel_status;

		public uint police_message_cnt;

		public uint police_channel_shield_cnt;

		public uint police_channel_status;

		public uint criminal_message_cnt;

		public uint criminal_channel_shield_cnt;

		public uint criminal_channel_status;
	}

	public class CustomRoomVoiceStats
	{
		public uint team_channel_sec;

		public uint room_channel_sec;

		public List<uint> switch_channel_room_num;

		public void Reset()
		{
		}
	}

	public class EventVoiceTimeRecord
	{
		private bool speaking;

		private uint speak_on_time;

		private ulong speak_start_time;

		private bool micing;

		private uint mic_on_time;

		private ulong mic_start_time;

		public void StopRecord()
		{
		}

		public uint GetMicTime()
		{
			return 0u;
		}

		public uint GetVoiceOnTime()
		{
			return 0u;
		}

		public void MicrophoneChange(bool on)
		{
		}

		public void SpeakerChange(bool on)
		{
		}

		public void InitRecordData()
		{
		}
	}

	public enum ESocialHubPersonalInfoTriggerSource
	{
		None = 0,
		SelectByClick = 1,
		SelectByAim = 2,
		SelectByDistance = 3,
		ActionTriggerFollowEmote = 101,
		ActionTriggerDuoEmote = 102,
		ActionTriggerCooperateEmote = 103,
		ActionTriggerSuperEmote = 104,
		ActionTriggerSeesawOccupied = 105,
		ActionTriggerFollowMoveEmote = 106,
		InteractionDancePool = 201,
		InteractionCarryPlayer = 202,
		InteractionDuoEmote = 203,
		InteractionCooperateEmote = 204,
		InteractionFollowEmote = 205,
		InteractionSuperEmote = 206,
		InteractionSeesaw = 207,
		InteractionFollowMoveEmote = 208
	}

	public class EventTypeSocialHubPersonalInfoTrigger : EventLoggerBase
	{
		public class TriggerDetail
		{
			public int trigger_source;

			public int trigger_num;

			public int click_num;

			public List<ulong> trigger_account_list;

			public List<ulong> click_account_list;
		}

		public ulong match_id;

		public List<TriggerDetail> personal_info_trigger_detail;

		public List<TriggerDetail> add_friend_trigger_detail;

		public List<TriggerDetail> group_invite_trigger_detail;
	}

	public class EventTypeSocialHubSoftCloseChoice : EventLoggerBase
	{
		public ulong match_id;

		public ulong next_match_id;

		public bool is_active;
	}

	public class EventTypeSocialHubOffline : EventLoggerBase
	{
		public ulong enter_ts;

		public ulong exit_ts;
	}

	public class EventTypeSocialHubLWWatch : EventLoggerBase
	{
		public ulong match_id;

		public ulong start_ts;

		public ulong end_ts;

		public int watch_duration_times;
	}

	public class EventTypeSocialHubMicVoiceTime : EventLoggerBase
	{
		public ulong match_id;

		public bool is_switch;

		public uint nearby_voice_time;

		public uint team_voice_time;
	}

	private class EventSocialHubMicVoiceTimeRecord
	{
		private EventVoiceTimeRecord m_NearbyVoiceTimeRecord;

		private EventVoiceTimeRecord m_TeamVoiceTimeRecord;

		private EGameVoiceListenMode m_LastValidMode;

		private bool m_IsSwitch;

		public void MicrophoneChange(EGameVoiceListenMode mode)
		{
		}

		public void StopRecord()
		{
		}

		public uint GetNearbyVoiceTime()
		{
			return 0u;
		}

		public uint GetTeamVoiceTime()
		{
			return 0u;
		}

		public bool GetIsSwitch()
		{
			return false;
		}

		public void InitRecordData()
		{
		}
	}

	public class EventTypeSocialIsland : EventLoggerBase
	{
		public ulong match_id;

		public uint group_mode;

		public uint voice_on_time;

		public uint use_mic_time;

		public uint block_cnt;

		public uint enter_time;

		public ulong exit_time;

		public uint chat_cnt;

		public float vehicle_time;

		public byte use_portal_type;
	}

	public class EventTypeSpecialModeDisplayClick : EventLoggerBase
	{
		public ulong match_id;

		public EventTypScoreboardClick click;
	}

	public class EventTypScoreboardClick
	{
		public uint scoreboard_entrance_click;

		public uint scoreboard_region_click;
	}

	public class EventTypeMicVoiceTime : EventLoggerBase
	{
		public ulong match_id;

		public uint map_id;

		public uint game_mode;

		public uint group_mode;

		public uint match_mode;

		public uint survival_time;

		public bool voice_service_on;

		public bool is_offline;

		public uint mic_time;

		public uint receiver_time;

		public int is_choose_hold_talk_group;

		public int is_choose_hold_talk_all;

		public uint use_hold_talk_cnt;

		public uint low_volume_cnt;
	}

	public class CooperateEmoteAccountInfo
	{
		public ulong account_id;

		public bool if_join_success;
	}

	public class EventTypeMultiplayerEmotion : EventLoggerBase
	{
		public int emotion_id;

		public int type;

		public bool if_success;

		public ulong beinvited_account_id;

		public CooperateEmoteAccountInfo[] join_account_ids;
	}

	public class EventTypeBundleBoxClick : EventLoggerBase
	{
		public uint[] item_id;
	}

	public class EventTypeGuildWarBarrage : EventLoggerBase
	{
		public ulong clan_id;

		public uint pre_status;

		public uint cur_status;
	}

	public class EventTypeSpecialKill : EventLoggerBase
	{
		public ulong match_id;

		public List<SpecialKillEffectInfo> special_kill;
	}

	public class SpecialKillEffectInfo
	{
		public uint id;

		public uint kill_type;

		public int cnt;

		public SpecialKillEffectInfo(uint i, uint k, int c)
		{
		}
	}

	public class EventTypeAngelDevilBubbleClick : EventLoggerBase
	{
		public uint activity_id;

		public long award_time;

		public uint sub_type;

		public uint group_id;
	}

	public class EventTypeAngelDevilBubbleTeach : EventLoggerBase
	{
		public uint teach_cnt;
	}

	public class EventTypeOTPBind : EventLoggerBase
	{
		public int bind_type;

		public string bind_info;

		public int oper_type;
	}

	public class EventTypeOTPUnbind : EventLoggerBase
	{
		public int bind_type;

		public string bind_info;

		public int oper_type;
	}

	public class EventTypeOTPChangeBind : EventLoggerBase
	{
		public int original_bind_type;

		public string original_bind_info;

		public int bind_type;

		public string bind_info;

		public int oper_type;
	}

	public class EventTypeOTPAccountRecovery : EventLoggerBase
	{
		public int bind_type;
	}

	public class EventTypeMainPlatformChangeBind : EventLoggerBase
	{
		public string open_id;

		public uint platform;
	}

	public class EventTypeHippoCrisisPreStart : EventLoggerBase
	{
		public class EquipmentInfo
		{
			public uint id;

			public uint count;
		}

		public List<EquipmentInfo> equipment_info;

		public List<int> recommend_equipment;

		public bool is_equipment_met;

		public List<int> reason;
	}

	public class EventTypeBannedPlayerAppeal : EventLoggerBase
	{
		public int level;

		public int ban_reason;
	}

	public class EventTypeAddMatchMakingBlacklist : EventLoggerBase
	{
		public uint game_mode;

		public uint match_mode;

		public ulong match_id;

		public ulong blacklisted_id;

		public uint cur_blacklisted_num;

		public bool is_replaced;

		public string blacklisted_start_time;

		public string blacklisted_end_time;
	}

	public class EventTypeRemoveBlacklist : EventLoggerBase
	{
		public uint blacklisted_type;

		public ulong[] blacklisted_ids;

		public uint cur_blacklisted_num;
	}

	public class EventTypePotentiaBDimensionShare : EventLoggerBase
	{
		public uint level;

		public uint dimension_type;

		public uint platform;

		public string title;

		public string compare_result;
	}

	public class EventTypeTechBuildVote : EventLoggerBase
	{
		public uint stage_id;

		public uint option_id;

		public uint token_cnt;

		public string page_name;

		public bool is_allin;
	}

	public class EventTypeThumbsup : EventLoggerBase
	{
		public uint option_id;

		public string page_name;
	}

	public class EventTypePonyMapStartDownload : EventLoggerBase
	{
		public uint option_id;

		public string page_name;
	}

	public class EventTypeUGCGameDataDownloadOutGame : EventLoggerBase
	{
		public string[] workshop_codes;

		public int[] download_sizes;

		public uint download_time;

		public int download_result;
	}

	public class EventTypeUGCModePageResCheck : EventLoggerBase
	{
		public string[] workshop_codes;

		public uint check_time;
	}

	public class EventTypeUGCShowMapDownload : EventLoggerBase
	{
		public string workshop_code;

		public float res_size;

		public ulong ob_account_id;
	}

	public class EventTypeSetGallery : EventLoggerBase
	{
		public class GalleryInfo
		{
			public int info_type;

			public string info_detail;

			public int side;

			public int pos_x;

			public int pos_y;
		}

		public GalleryInfo[] gallery;

		public bool use_drag;

		public bool use_click;
	}

	public class EventTypeCraftlandSearchUsageRecord : EventLoggerBase
	{
		public class SearchResult
		{
			public string workshop_code;

			public int index;
		}

		public string search_query;

		public int search_mode;

		public SearchResult[] search_results;
	}

	public class EventTypeCraftlandMapObjectUsage : EventLoggerBase
	{
		public class AssetInfo
		{
			public ulong resource_id;

			public int version;

			public uint count;
		}

		public class ItemInfo
		{
			public uint item_id;

			public uint cnt;
		}

		public string workshop_code;

		public long map_update_ts;

		public List<AssetInfo> asset_info;

		public List<ItemInfo> item_info;
	}

	public class EventTypeSocialMediaBindGoto : EventLoggerBase
	{
		public string social_media_type;

		public string ip_region;
	}

	public class EventTypeSocialMediaBind : EventLoggerBase
	{
		public string social_media_type;

		public int op_result;

		public string ip_region;
	}

	private enum NativeDoneStages
	{
		kCreateLog,
		kUnityDeinitApplication,
		kNotifyPlayerQuit,
		kPreloadManagerStop,
		kCleanupEngine,
		kCleanupAllObjects,
		kCleanupEngineGraphics,
		kCleanupBatchDelete,
		kShutdownJobThreads,
		kCleanupPersistentManager,
		kCleanupAsyncReadManager,
		kCleanupIl2Cpp,
		kUnityFinalDeinitApplication,
		kRemoveLog,
		kNativeDoneStagesMax
	}

	public class EventTypeQuitTimeout : EventLoggerBase
	{
		public bool fail_creating_file;

		public bool fail_reading_file;

		public int invalid_stage_id;

		public float deinit_application_begin;

		public float deinit_application_end;

		public float notify_player_quit_begin;

		public float notify_player_quit_end;

		public float preload_manager_stop_begin;

		public float preload_manager_stop_end;

		public float cleanup_engine_begin;

		public float cleanup_engine_end;

		public float cleanup_all_objects_begin;

		public float cleanup_all_objects_end;

		public float cleanup_engine_graphics_begin;

		public float cleanup_engine_graphics_end;

		public float cleanup_batch_delete_begin;

		public float cleanup_batch_delete_end;

		public float shutdown_job_threads_begin;

		public float shutdown_job_threads_end;

		public float cleanup_persistent_manager_begin;

		public float cleanup_persistent_manager_end;

		public float cleanup_async_read_manager_begin;

		public float cleanup_async_read_manager_end;

		public float cleanup_il2cpp_begin;

		public float cleanup_il2cpp_end;

		public float final_deinit_application_begin;

		public float final_deinit_application_end;
	}

	public class EventTypeUGCMapTranslationFail : EventLoggerBase
	{
		public string workshop_code;

		public string lang;
	}

	public class EventTypeAIAssistantFAQ : EventLoggerBase
	{
		public ulong match_id;

		public uint game_mode;

		public uint match_mode;

		public uint group_mode;

		public bool is_ugc;

		public uint scene_id;

		public uint voice_input_cnt;

		public uint text_input_cnt;
	}

	public class EventTypeTargetTractionMission : EventLoggerBase
	{
		public uint game_mode;

		public uint cur_rank;

		public uint task_id;

		public uint reason;
	}

	public enum TargetTractionMissionReasonType
	{
		None,
		Login,
		ReturnToLobby,
		LobbyNextMission,
		ChangeMode,
		Observer,
		Booyah,
		MatchResult
	}

	public class EventTypeUGCPlatformMapsExposure : EventLoggerBase
	{
		public class ExposureInfo
		{
			public string from;

			public string from_info;

			public string workshop_code;

			public int exposure_cnt;
		}

		public List<ExposureInfo> exposure_info;

		private static string s_FromInfo;

		public static void CacheFromInfo(string from_info)
		{
		}

		public static void Record(UINavigationUtil.UINavigationFrom ui_from, string workshopCode, string from_info = null)
		{
		}
	}

	public class EventTypeMicAccessPopUp : EventLoggerBase
	{
		public int choice;
	}

	public class EventTypeUGCMonetizationTriggered : EventLoggerBase
	{
		public string workshop_code;

		public ulong match_id;

		public int iap_store_open_cnt;

		public int purchase_ui_cnt;

		public static void Record(string workshopCode, ulong matchId, bool isIapStoreOpen, bool isPurchaseUI)
		{
		}

		public static void Send()
		{
		}
	}

	public class EventTypeCDNDownloadInfo : EventLoggerBase
	{
		public class EventTypeCDNDownloadInfoDetail
		{
			public string url;

			public uint download_time;

			public int status_code;

			public int content_length;

			public EventTypeCDNDownloadInfoDetail(string textureUrl, uint downloadTime, int statusCode, int downloadTextureSize)
			{
			}
		}

		public string client_ip;

		public List<EventTypeCDNDownloadInfoDetail> download_info;
	}

	public class EventType8AnniversaryEdit : EventLoggerBase
	{
		public class EventType8AnniversaryEditDetail
		{
			public int pos_id;

			public int item_type;

			public int item_id;

			public int cnt;

			public bool is_save;
		}

		public List<EventType8AnniversaryEditDetail> change_info;
	}

	public enum ENinthAnniversarySceneType
	{
		Catapult = 1,
		Seesaw,
		Chair,
		CameraZone
	}

	public enum ENinthAnniversaryInteractionType
	{
		Use = 1,
		FireOrJoin
	}

	public class EventType9AnniversarySceneInteraction : EventLoggerBase
	{
		public int online_status;

		public ulong match_id;

		public int scene_type;

		public uint scene_id;

		public int interaction_type;
	}

	public class EventType9AnniversaryPrivilegeItemUse : EventLoggerBase
	{
		public class ItemClickInfo
		{
			public uint item_id;

			public int click_cnt;
		}

		public List<ItemClickInfo> item_click_info;
	}

	public class EventTypeUGCPreloadTimeout : EventLoggerBase
	{
		public string workshop_code;

		public string gameserver_ip;

		public string proxyserver_ip;

		public int gameserver_proxy_port;

		public int preload_phase;

		public int preload_duration;

		private static float m_StartTime;

		public static void Start(string workshop_code)
		{
		}

		public static void End(string workshop_code, int phase = 0)
		{
		}
	}

	public class EventTypeUGCViewMapLeaderboard : EventLoggerBase
	{
		public string workshop_code;

		public int request_type;

		public int refresh_cnt;

		public uint swipe_lowest_rank;
	}

	public enum InviteFriendTopupScene
	{
		MainPageInvite = 1,
		ShareWorld,
		ShareClan,
		ShareFriend
	}

	public class EventTypeInviteFriendTopup : EventLoggerBase
	{
		public ulong team_id;

		public ulong leader_id;

		public bool is_private;

		public uint attribute;

		public ulong invitee_id;

		public int scene;

		public int event_id;
	}

	public class EventTypeAIThreeDimItemGeneration : EventLoggerBase
	{
		public uint slot_id;

		public string workshop_code;

		public string input_text;

		public List<ulong> output_item_ids;

		public ulong target_item_id;
	}

	public class EventTypeFinishMoveChange : EventLoggerBase
	{
		public uint type;

		public uint after_finish_move_id;

		public uint before_finish_move_id;
	}

	public class EventTypeWinterland25EggGameStart : EventLoggerBase
	{
		public int game_id;

		public int process_id;
	}

	public class EventTypeWinterland25EggGameLeave : EventLoggerBase
	{
		public int game_id;

		public int type;

		public int per_process_id;

		public int cur_process_id;

		public int delta;

		public int click_candy_num;
	}

	public class EventTypeCraftlandBlockScriptTemplateSave : EventLoggerBase
	{
		public string template_uuid;

		public string template_name;

		public string template_description;
	}

	public class EventTypeCraftlandOperationLoadingDuration : EventLoggerBase
	{
		public class PhaseDuration
		{
			public string phase;

			public long duration;

			public PhaseDuration(string p)
			{
			}
		}

		public class PhaseConst
		{
			public const string PHASE_EXPORT_DATA = "export_data_phase";

			public const string PHASE_SAVE_DATA = "save_data_phase";

			public const string PHASE_PROTO_UGC_DEBUG = "proto_ugc_debug_phase";

			public const string PHASE_ENTER_UGC_GAME = "enter_ugc_game_phase";

			public const string PHASE_QUIT_MATCH = "quit_match_phase";

			public const string PHASE_RETURE_LOBBY = "return_lobby_phase";

			public const string PHASE_RE_ENTER_SCENE_EDIT = "re_enter_scene_edit_phase";
		}

		public enum OperationType
		{
			EnterSceneEdit = 1,
			EnterGraphEdit,
			EnterDebug,
			ExitDebug
		}

		private sealed class _003C_003Ec__DisplayClass16_0
		{
			public string phase;

			internal bool _003CEndPhase_003Eb__0(PhaseDuration x)
			{
				return false;
			}
		}

		public uint slot_id;

		public string workshop_code;

		public int operation_type;

		public List<PhaseDuration> duration_details;

		public ulong resource_statistics;

		public uint block_cnt;

		private static Stopwatch s_Watch;

		public EventTypeCraftlandOperationLoadingDuration(uint slotId)
		{
		}

		public void Reset()
		{
		}

		public static EventTypeCraftlandOperationLoadingDuration Init(uint slotId)
		{
			return null;
		}

		public static void BeginOperate(OperationType operationType)
		{
		}

		public static void EndOperate()
		{
		}

		public static void BeginPhase(string phase)
		{
		}

		public static void EndPhase(string phase)
		{
		}
	}

	public class EventTypeMsdkRegFormClosed : EventLoggerBase
	{
		public int popup_return_type;
	}

	public class EventTypeFightClubInviteDuel : EventLoggerBase
	{
		public ulong match_id;

		public uint match_mode;

		public uint game_mode;

		public bool is_initiate;
	}

	public class EventTypeTriggerLuckyRemind : EventLoggerBase
	{
		public enum PageType
		{
			None,
			Reward,
			GachaFeature
		}

		public uint lottery_id;

		public uint lottery_sub_id;

		public uint page_type;

		public uint lucky_id;
	}

	public class EventTypeFileInfoEncrypt : EventLoggerBase
	{
		public List<FileInfoEncryptResult> decrypt_results;

		public List<FileInfoEncryptResult> encrypt_results;
	}

	public class FileInfoEncryptResult
	{
		public int res_download_type;

		public int err_code;

		public bool can_parse;

		public int version;
	}

	public class EventTypeRelayMartShareCoupon : EventLoggerBase
	{
		public string coupon_code;

		public int relay_mart_id;

		public List<ulong> share_account_ids;

		public int share_scene;
	}

	public class EventTypeUGCDownloadCLBasicPackage : EventLoggerBase
	{
	}

	public class EventTypeUGCUnlockOfflineMode : EventLoggerBase
	{
	}

	public class EventTypeUGCPlayerEnterOfflineMode : EventLoggerBase
	{
		public string device_id;

		public int download_map_cnt;

		public int enter_ts;
	}

	public class EventTypeUGCOfflineMatchStats : EventLoggerBase
	{
		public string workshop_code;

		public uint survival_time;

		public bool is_drop;

		public long map_update_ts;

		public int match_ts;
	}

	public struct UGCPlatformStartSurveySubmitDetail
	{
		public int question_id;

		public int select_id;

		public int[] tag_ids;

		public int[] genre_ids;
	}

	public enum EventTypeUGCPlatformStartSurveySubmitTriggerReason
	{
		FirstTime = 1,
		ReturningUser
	}

	public enum EventTypeUGCPlatformStartSurveySubmitChoice
	{
		None,
		Left,
		Right
	}

	public class EventTypeUGCPlatformStartSurveySubmit : EventLoggerBase
	{
		public UGCPlatformStartSurveySubmitDetail[] select_details;

		public int trigger_reason;
	}

	public enum ENewbieTeamFloatingWindowType
	{
		TeamRecommend = 1,
		OneKeyRecruit
	}

	public class EventTypeNewbieTeamFloatingWindow : EventLoggerBase
	{
		public int floating_window_type;

		public int game_mode;

		public int match_mode;

		public int group_mode;
	}

	public enum ENewbieDailyQAResult
	{
		Correct = 1,
		Wrong
	}

	public class EventTypeNewbieDailyQA : EventLoggerBase
	{
		public int question_id;

		public int result;
	}

	public class NewbieFriendRecommendAccountInfo
	{
		public ulong account_id;

		public string recommend_tag;
	}

	public class EventTypeNewbieFriendRecommend : EventLoggerBase
	{
		public int cur_friend_num;

		public List<NewbieFriendRecommendAccountInfo> recommend_account_info;
	}

	public class EventTypeLBSNearbySearchUse : EventLoggerBase
	{
		public string ip_region;

		public int op_type;
	}

	public class EventTypeLBSNearbySearchFirstAuth : EventLoggerBase
	{
		public string ip_region;

		public int result;
	}

	public class EventTypeLBSNearbySearchRecommendInfo
	{
		public ulong account_id;

		public string distance;

		public string online_status;
	}

	public class EventTypeLBSNearbySearchRecommend : EventLoggerBase
	{
		public string ip_region;

		public List<EventTypeLBSNearbySearchRecommendInfo> recommend_account_info;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<EventLogPageDetentionTimeItem> _003C_003E9__949_1;

		public static Predicate<EventTypePopupWindowViewTime.SinglePopupWindowViewTime> _003C_003E9__949_0;

		public static Func<List<long>, bool> _003C_003E9__1222_1;

		public static Func<List<List<long>>, bool> _003C_003E9__1222_0;

		internal bool _003CSendCachedLogs_003Eb__949_1(EventLogPageDetentionTimeItem item)
		{
			return false;
		}

		internal bool _003CSendCachedLogs_003Eb__949_0(EventTypePopupWindowViewTime.SinglePopupWindowViewTime item)
		{
			return false;
		}

		internal bool _003CAnalyseAndSendCPUFrequencies_003Eb__1222_0(List<List<long>> curSample)
		{
			return false;
		}

		internal bool _003CAnalyseAndSendCPUFrequencies_003Eb__1222_1(List<long> perCPUSample)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1020_0
	{
		public string to;

		public string from;

		internal bool _003CLogNavigate_003Eb__0(EventNavigateClick e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1021_0
	{
		public UGCResourceShopMetaData metaData;

		public int type_id;

		public int event_id;

		internal bool _003CLogCraftlandAssetStoreClick_003Eb__0(EventTypeCraftlandAssetStoreClickInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1022_0
	{
		public UGCResourceShopMetaData metaData;

		public int type_id;

		public int event_id;

		internal bool _003CLogCraftlandAssetStoreExposure_003Eb__0(EventTypeCraftlandAssetStoreExposureInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1030_0
	{
		public string name;

		internal bool _003CLogClickByValue_003Eb__0(ClickEntry e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1039_0
	{
		public string page_name;

		internal bool _003CLogUINavigationClose_003Eb__0(EventLogPageDetentionTimeItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1044_0
	{
		public uint scene;

		public string code;

		internal bool _003CLogUGCMapDetailsPopup_003Eb__0(EventTypeUGCMapDetailsPopup.ClickInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1045_0
	{
		public string windowName;

		internal bool _003CLogPopupWindowClose_003Eb__0(EventTypePopupWindowViewTime.SinglePopupWindowViewTime e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1046_0
	{
		public string workshopname;

		internal bool _003CLogPopularUGCFirst_003Eb__0(EventPopularList e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1047_0
	{
		public string workshopname;

		internal bool _003CLogPopularUGC_003Eb__0(EventPopularList e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1048_0
	{
		public string workshopname;

		internal bool _003CLogWeekUGCFirst_003Eb__0(EventWeekList e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1049_0
	{
		public string workshopname;

		internal bool _003CLogWeekUGC_003Eb__0(EventWeekList e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1050_0
	{
		public SceneEditSlotInfo data;

		internal bool _003CLogRecommendList_003Eb__0(RecommendItemLog e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1051_0
	{
		public EventBroadCastType type;

		internal bool _003CLogBroadCastType_003Eb__0(EventBroadCastEntry e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1160_0
	{
		public string targetUrl;

		public int failType;

		public string failReason;

		public string clientIP;

		public string networkType;

		internal bool _003CCDNDownFail_003Eb__0(CdnErrorRequest e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1161_0
	{
		public string protocol;

		internal bool _003CLogProtocolStats_003Eb__0(ProtocolStats s)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1174_0
	{
		public ulong actionAccountID;

		internal bool _003CLogEventTypePrimeShare_003Eb__0(GroupMemberInfo member)
		{
			return false;
		}

		internal bool _003CLogEventTypePrimeShare_003Eb__1(GroupMemberInfo member)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1192_0
	{
		public uint itemDataID;

		internal bool _003CLogAutoSearchItemInfo_003Eb__0(AutoFindItemsInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1193_0
	{
		public uint itemDataID;

		internal bool _003CLogAutoSearchPickInfo_003Eb__0(AutoFindItemsInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass1214_0
	{
		public CPUFreqRecordType recordType;

		internal void _003CStartLogCPUFrequencies_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass1419_0
	{
		public uint itemId;

		internal bool _003CRecord9AnniversaryPrivilegeItemUse_003Eb__0(EventType9AnniversaryPrivilegeItemUse.ItemClickInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass895_0
	{
		public int stage;

		internal bool _003CLogEnterDeathReplayInfo_003Eb__0(DeathReplayInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass896_0
	{
		public int id;

		internal bool _003CLogTriggerBotAgent_003Eb__0(BotAgentPlay e)
		{
			return false;
		}

		internal bool _003CLogTriggerBotAgent_003Eb__1(BotAgentAction e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass899_0
	{
		public int stage;

		internal bool _003CLogExitDeathReplayInfo_003Eb__0(DeathReplayInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass900_0
	{
		public int stage;

		internal bool _003CLogRecoverFromDeathReplay_003Eb__0(DeathReplayInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass959_0
	{
		public PageType pageType;

		internal bool _003CLogLobbyPerformanceStatsLoadTime_003Eb__0(PageInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass960_0
	{
		public PageType pageType;

		internal bool _003CLogLobbyPerformanceWaitNetTime_003Eb__0(PageInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass961_0
	{
		public PageType pageType;

		internal bool _003CLogLobbyPerformanceStatsFPS_003Eb__0(PageInfo e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass973_0
	{
		public int weaponID;

		public int executionID;

		internal bool _003CAddWeaponExecutionTriggerCnt_003Eb__0(WeaponExectuionTrigger e)
		{
			return false;
		}
	}

	private sealed class _003CDelayFCoroutine_003Ed__1005 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayFCoroutine_003Ed__1005(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public const string EVENT_TYPE_MAGIC_VOICE_INIT = "EventTypeMagicVoiceInit";

	public const string EVENT_TYPE_DISCONNECTFROMNETWORK = "EventTypeDisconnectFromNetwork";

	public const string EVENT_TYPE_GAME_LAG = "EventTypeGameLag";

	public const string EVENT_TYPE_SHARE = "EventTypeShare";

	public const string EVENT_TYPE_UGC_SHARE = "EventTypeUGCShare";

	public const string EVENT_TYPE_SHARE_CHAT = "EventTypeShareChat";

	public const string EVENT_TYPE_IAP_RESULT = "EventTypeIAPResult";

	public const string EVENT_TYPE_SPLASHBANNER_GOTO = "EventTypeSplashBannerGoto";

	public const string EVENT_TYPE_NEWBIE_SPLASHBANNER_GOTO = "EventTypeNewbieSplashBannerGoto";

	public const string EVENT_TYPE_ANNIVERSARY_SPLASHBANNER_GOTO = "EventTypeLimitEventSplashBanner";

	public const string EVENT_TYPE_OBSERVER_LOG = "EventTypeObserverLog";

	public const string EVENT_TYPE_REPORT_CHEAT = "EventTypeReport";

	public const string EVENT_TYPE_GACHA_REWARDPOOL_OPEN = "EventTypeOpenRewardPoolCount";

	public const string EVENT_TYPE_LIMIT_LOTTERY_DEFAULT_REMOVE = "EventTypeLimitLotteryDefaultRemove";

	public const string EVENT_TYPE_GIFT_RECEIVE = "EventTypeGiftReceive";

	public const string EVENT_TYPE_CHAT = "EventTypeChat";

	public const string EVENT_TYPE_WHISPER_CHAT = "EventTypeWhisperChat";

	public const string EVENT_TYPE_BILLBOARD = "EventTypeBillboard";

	public const string EVENT_TYPE_IAP_BUNDLE_PAYMENT = "EventTypeIAPBundlePayment";

	public const string EVENT_TYPE_SCAN_IAP_INVENTORY_RESULT = "EventTypeScanIAPInventoryResult";

	public const string EVENT_TYPE_ANDROID_APPLICATION_DETECTION = "EventTypeAndroidApplicationDetection";

	public const string EVENT_TYPE_ENTER_GAME = "EventTypeEnterGame";

	public const string EVENT_TYPE_LEAVE_GAME = "EventTypeLeaveGame";

	public const string EVENT_TYPE_LEAVE_SCENEEDIT_GAME = "EventTypeLeaveSceneEditGame";

	public const string EVENT_TYPE_END_GAME = "EventTypeEndGame";

	public const string EVENT_TYPE_COMPLETE_GAME = "EventTypeCompleteGame";

	public const string EVENT_TYPE_HIGH_FRAME_SWITCH = "EventTypeHighFrameSwitch";

	public const string EVENT_TYPE_GETAVATAR_BUNDLE = "EventTypeGetAvatarBundleClick";

	public const string EVENT_TYPE_FFAnti = "EventTypeFFAnti";

	public const string EVENT_TYPE_BACK_MALL_COUNT = "EventTypeBackMallCount";

	public const string EVENT_TYPE_INGAME_TIPS = "EventTypeIngameTips";

	public const string EVENT_TYPE_CONNECT_NOTI_FAIL = "EventTypeConnectNotiFail";

	public const string EVENT_TYPE_SETTING_DOWNLOAD = "EventTypeClientSettingDownloadInfo";

	public const string EVENT_TYPE_SETTING_UPLOAD = "EventTypeClientSettingUploadInfo";

	public const string EVENT_TYPE_FIRST_LAUNCH_LOCAL_SETTING = "EventTypeFirstLaunchLocalSetting";

	public const string EVENT_TYPE_HUD_SETTING_INFO = "EventTypeHUDSettingInfo";

	public const string EVENT_TYPE_BASIC_SETTING = "EventTypeClientBasicSettingChange";

	public const string EVENT_TYPE_MAX_SETTING = "EventTypeClientMaxSettingChange";

	public const string EVENT_TYPE_OPERATION_SETTING = "EventTypeClientOperationSettingChange";

	public const string EVENT_TYPE_IOS_IDFA = "EventTypeIOSIDFA";

	public const string EVENT_TYPE_CHAMPIONSHIPCLIKC = "EventTypeChampionshipClick";

	public const string EVENT_TYPE_ENTER_WAITING_ISLAND = "EventTypeEnterWaitingIsland";

	public const string EVENT_TYPE_LEAVE_WAITING_ISLAND = "EventTypeLeaveWaitingIsland";

	public const string EVENT_TYPE_CLIENT_CLICK = "EventTypeClientClick";

	public const string EVENT_TYPE_PERSONAL_INFO_CLICK = "EventTypePersonalInfoClick";

	public const string EVENT_TYPE_SOCIAL_MEDIA_BIND_GOTO = "EventTypeSocialMediaBindGoto";

	public const string EVENT_TYPE_SOCIAL_MEDIA_BIND = "EventTypeSocialMediaBind";

	public const string EVENT_TYPE_NAVIGATION_BATCH = "EventTypeNavigateBatch";

	public const string EVENT_TYPE_UGCPLATFORM_NAVIGATION_BATCH = "EventTypeUGCPlatformNavigateBatch";

	public const string EVENT_TYPE_CLIENTSETTING = "EventTypeClientSetting";

	public const string EVENT_TYPE_REJECT_JOIN_GROUP = "EventTypeRejectJoinGroup";

	public const string EVENT_TYPE_REJECT_GROUP_INVITE = "EventTypeRejectGroupInvite";

	public const string EVENT_TYPE_GROUP_INVITE_WITHIN_CLIENT = "EventTypeGroupInviteWithinClient";

	public const string EVENT_TYPE_DEFAULT_MUSIC_CLICK = "EventTypeDefaultMusicClick";

	public const string EVENT_TYPE_RESERVATION_SENT = "EventTypeReservationSent";

	public const string EVENT_TYPE_RESERVATION_REPLY = "EventTypeReservationReply";

	public const string EVENT_TYPE_RESERVATION_CONFIRM = "EventTypeReservationConfirm";

	public const string EVENT_TYPE_RESERVATION_RESULT = "EventTypeReservationResult";

	public const string EVENT_TYPE_MALL_CLICK = "EventTypeShopClick";

	public const string EVENT_TYPE_BANNER_CLICK = "EventTypeBannerClick";

	public const string EVENT_TYPE_LIMITED_EVENT_SHARE = "EventTypeLimitedEventShare";

	public const string EVENT_TYPE_NAVI_PAGE_VIEW_TIME = "EventTypeNaviPageViewTime";

	public const string EVENT_TYPE_TRAINING_CENTER_ENTER = "EventTypeTrainingCenterEnter";

	public const string EVENT_TYPE_PROFILEPAGE_VIEW_TIME = "EventTypeProfilePageViewTime";

	public const string EVENT_TYPE_BOOYAH_EMOTE_EQUIP = "EventTypeBooyahEmoteEquip";

	public const string EVENT_TYPE_BOOYAH_EMOTE_PLAY = "EventTypeBooyahEmotePlay";

	public const string EVENT_TYPE_BIGEVENTSPLASH_PUSH = "EventTypeBigEventSplashPush";

	public const string EVENT_TYPE_BIGEVENTTEMPLATE_SPLASH_PUSH = "EventTypeBigEventTemplateSplashPush";

	public const string EVENT_TYPE_BROADCAST_TYPE_CNT = "EventTypeBroadCastTypeCnt";

	public const string EVENT_TYPE_CLOSE_UP_SHARE = "EventTypeCloseUpShare";

	public const string EVENT_TYPE_CLIENT_SETTING_CHANGE = "EventTypeClientSettingChange";

	public const string EVENT_TYPE_FRIEND_RECOMMEND = "EventTypeFriendRecommend";

	public const string EVENT_TYPE_BR_DEADINFO = "EventTypeBRDeadInfo";

	public const string EVENT_TYPE_SYSTEM_SCREENSHOT = "EventTypeSystemScreenShot";

	public const string EVENT_TYPE_MVPINFO = "EventTypeMVPInfo";

	public const string EVENT_TYPE_BIGBANNERGOTO = "EventTypeBigBannerGoto";

	public const string EVENT_TYPE_CSCUP_LOBBYRESULT = "EventTypeCupLobbyResult";

	public const string EVENT_TYPE_REGISTER_INTITLE = "EventTypeRegisterIntitle";

	public const string EVENT_TYPE_WORKSHOP_SCENEEDIT = "EventTypeWorkshopSceneEdit";

	public const string EVENT_TYPE_UGC_CUSTOM_MODE_MAP_CONTENT = "EventTypeUGCCustomModeMapContent";

	public const string EVENT_TYPE_CDN_TRANSFER_TRAFFICMONITOR = "EventTypeCDNTransferTrafficMonitor";

	public const string EVENT_TYPE_GUIDEWAR_CABINPANEL_VIEWTIME = "EventTypeGuildWarCabinPanelViewTime";

	public const string EVENT_TYPE_AutoPopupWindowCtrl = "EventTypeAutoPopupWindowCtrl";

	public const string EVENT_TYPE_SPLASHBANNERPOPUP = "EventTypeSplashBannerPopup";

	public const string EVENT_TYPE_NEWBIE_SPLASHBANNERPOPUP = "EventTypeNewbieSplashBannerPopup";

	public const string EVENT_TYPE_GUILDWAR_SPLASHBANNERPOPUP = "EventTypeGuildWarSplashBannerPopup";

	public const string EVENT_TYPE_GUIDE_TRIGGER = "EventTypeGuideTrigger";

	public const string EVENT_TYPE_CS_GUIDE_TRIGGER = "EventTypeCSGuideTrigger";

	public const string EVENT_TYPE_GUIDE_CLOSE_INFO = "EventTypeGuideCloseInfo";

	public const string EVENT_TYPE_CUSTOMROOM_VOICECHAT = "EventTypeCustomRoomVoiceChat";

	public const string EVENT_TYPE_ROOM_STATUS_CHANGE = "EventTypeRoomStatusChange";

	public const string EVENT_TYPE_OPTIONAL_BUNDLE_DOWNLOAD = "EventTypeOptionalBundleDownload";

	public const string EVENT_TYPE_OPTIONAL_BUNDLE_DELETE = "EventTypeOptionalBundleDelete";

	public const string EVENT_TYPE_TEAM_DOWNLOAD = "EventTypeTeamDownload";

	public const string EVENT_TYPE_HUD_SETTING_CHANGE = "EventTypeHUDSettingChange";

	public const string EVENT_TYPE_VEHICLE_HUD_SETTING_CHANGE = "EventTypeVehicleHUDSettingChange";

	public const string EVENT_TYPE_BRTUTORIAL_FORCEGUIDETRIGGER = "EventTypeBRTutorialForceGuideTrigger";

	public const string EVENT_TYPE_BRTUTORIAL_GOAL = "EventTypeBRTutorialGoal";

	public const string EVENT_TYPE_NEWBIE_MATCHMAKINGINFO = "EventTypeNewbieMatchMakingInfo";

	public const string EVENT_TYPE_NEWBIE_MATCHMAKING_CANCELINFO = "EventTypeNewbieMatchMakingCancelInfo";

	public const string EVENT_TYPE_TABVIEWTIME = "EventTypeNaviTabViewTime";

	public const string EVENT_TYPE_DIGITALUNIVERSEB_CONCERTSTATS = "EventTypeDigitalUniverseConcertStats";

	public const string EVENT_TYPE_HACK_CLIENT_FIX = "EventTypeHackClientFix";

	public const string EVENT_TYPE_UGC_IMPORT_PROJECT_REVIEW = "EventTypeUGCImportProjectReview";

	public const string EVENT_TYPE_MAX_LOBBY_YARD = "EventTypeMaxLobbyYard";

	public const string EVENT_TYPE_TRAINING_LOCAL_GAME = "EventTypeTrainingLocalGame";

	public const string EVENT_TYPE_WEREWOLVES_GAME = "EventTypeWereWolvesGame";

	public const string EVENT_TYPE_LOCAL_NOTIFICATION_STATS = "EventTypeLocalNotificationStats";

	public const string EVENT_TYPE_REMOTE_NOTIFICATION = "EventTypeRemoteNotification";

	public const string EVENT_TYPE_FCM_RMT_NTF_RECV = "EventTypeFcmRmtNtfRecv";

	public const string EVENT_TYPE_EVENT_PUSH_LINK_RETURN = "EventTypeEventPushLinkReturn";

	public const string EVENT_TYPE_REPLAY_SETTING = "EventTypeReplaySetting";

	public const string EVENT_TYPE_RECRUIT_INFO_SEND = "EventTypeRecruitInfoSend";

	public const string EVENT_TYPE_RECRUIT_QUICK_SWITCH_TEAM = "EventTypeRecruitQuickSwitchTeam";

	public const string EVENT_TYPE_REPLAY_SAVE_STATS = "EventTypeReplaySaveStats";

	public const string EVENT_TYPE_HIGHLIGHTS_TRIGGER = "EventTypeHighlightsTrigger";

	public const string EVENT_TYPE_REPLAY_SAVE_INFO = "EventTypeReplaySaveInfo";

	public const string EVENT_TYPE_REPLAY_PLAY_INFO = "EventTypeReplayPlayInfo";

	public const string EVENT_TYPE_REPLAY_HIGHLIGH_FILTER_SETTING = "EventTypeHighLightFilterSetting";

	public const string EVENT_TYPE_BR_TACTICAL_REVIEW = "EventTypeBRTacticalReview";

	public const string EVENT_TYPE_VETERAN_SPLASH_BANNER = "EventTypeVeteranSplashBanner";

	public const string EVENT_TYPE_AUTO_PICKUP_CHANGE = "EventTypeAutoPickSettingChange";

	public const string EVENT_TYPE_FORCE_TUTORIAL_INFO = "EventTypeForceGuideProcedureInfo";

	public const string EVENT_TYPE_FORCE_TUTORIAL_ENTER = "EventTypeForceGuideEnter";

	public const string EVENT_TYPE_FORCE_TUTORIAL_PHASE = "EventTypeForceGuidePhaseInfo";

	public const string EVENT_TYPE_FORCE_TUTORIAL_FPSINFO = "EventTypeForceGuideFpsInfo";

	public const string EVENT_TYPE_FORCE_TUTORIAL_DOWNLOADINFO = "EventTypeForceGuideDownloadInfo";

	public const string EVENT_TYPE_CLIPBOARD_FEED_BACK = "EventTypeClipboardFeedback";

	public const string EVENT_TYPE_UNIVERSAL_LINK_GOTO = "EventTypeUniversalLinkGoto";

	public const string EVENT_TYPE_NEWMODE_GOTO = "EventTypeNewModeGoto";

	public const string EVENT_TYPE_UGC_LOGIN_INFO = "EventTypeUGCLoginInfo";

	public const string Event_Type_ClickWorkshopMapExposed = "EventTypeClickWorkshopMapExposed";

	public const string EVENT_TYPE_CUP_LOGIN_ANIMATION = "EventTypeCupLoginAnimation";

	public const string EVENT_TYPE_FULL_SCREEN_ANIMATION = "EventTypeFullScreenAnimation";

	public const string EVENT_TYPE_GUEST_SAF_AUTHORIZATION = "EventTypeGuestAuthorization";

	public const string EVENT_TYPE_BAN_VOICE = "EVENT_TYPE_BAN_VOICE";

	public const string EVENT_TYPE_VOICE_CONNECT_INFO = "EventTypeVoiceConnectInfo";

	public const string EVENT_TYPE_BANVOICE = "EventTypeBanVoice";

	public const string EVENT_TYPE_POP_UP_WINDOW_VIEW_TIME = "EventTypePopupWindowViewTime";

	public const string EVENT_TYPE_RANKLEVEL_CHANGE = "EventTypeRankLevelChange";

	public const string EVENT_TYPE_EXPANSION_GROUP_MODE = "EventTypeExpansionGroupMode";

	public const string EVENT_TYPE_FRIENDR_ECOMMEND_POP_UP = "EventTypeFriendRecommendPopup";

	public const string EVENT_TYPE_GROUP_READY_REMIND = "EventTypeGroupReadyRemind";

	public const string EVENT_TYPE_MAP_SELECTED = "EventTypeMapSelected";

	public const string EVENT_TYPE_UGC_MAP_DETAILS_POPUP = "EventTypeUGCMapDetailsPopup";

	public const string EVENT_TYPE_BUNDLE_REPAIR = "EventTypeBundleRepair";

	public const string EVENT_TYPE_BUNDLE_REPAIR_CLICK = "EventTypeBundleRepairClick";

	public const string EVENT_TYPE_TRIAL_PICKUP_WEAPON = "EventTypeTrialPickUpWeapon";

	public const string EVENT_TYPE_BIGEVENT_FIRST_VIEW = "EventTypeBigEventFirstView";

	public const string EVENT_TYPE_BIGEVENT_VIDEO_STATS = "EventTypeBigEventVideoStats";

	public const string EVENT_TYPE_MATCHNPC_DIALOG = "EventTypeMatchNPCDialog";

	public const string EVENT_TYPE_GROUP_ANIM_MVP = "EventTypeGroupAnimMVP";

	public const string EVENT_TYPE_CLICK_FUNNEL_ENTERUGC = "EventTypeClickFunnelEnterUGC";

	public const string EVENT_TYPE_CLICK_FUNNEL_CREATE_MAP = "EventTypeClickFunnelCreateMap";

	public const string EVENT_TYPE_CDN_DOWNLOAD_FAIL = "EventTypeCDNDownloadFail";

	public const string EVENT_TYPE_PROTOCOL_STATS = "EventTypeProtocolStats";

	public const string EVENT_TYPE_VETERAN_GAMEPLAY_TRIGGER = "EventTypeVeteranGamePlayTrigger";

	public const string EVENT_TYPE_VETERAN_GAMEPLAY_MATCH_TRIGGER = "EventTypeVeteranGamePlayMatchTrigger";

	public const string EVENT_TYPE_VETERAN_TAG_MATCH_STATS = "EventTypeVeteranTagMatchStats";

	public const string EVENT_TYPE_VETERAN_NEWHOT_TAG_TRIGGER = "EventTypeVeteranNewHotTagTrigger";

	public const string EVENT_TYPE_UGC_MAP_COMMENT = "EventTypeUGCMapComment";

	public const string EVENT_TYPE_PERMANENT_VALUE_FULL = "EventTypePermanentValueToWeaponSkin";

	public const string EVENT_TYPE_KELLY_RUN_WEB_PAGE = "EventTypeKellyRunWebPage";

	public const string EVENT_TYPE_SPLASH_BANNER_CLOSE = "EventTypeSplashBannerClose";

	public const string EVENT_TYPE_LOBBY_PERFORMANCE_STATS = "EventTypeLobbyPerformanceStats";

	public const string EVENT_TYPE_ITEMS_LOVE_CHANGE = "EventTypeItemsLoveChange";

	public const string EVENT_TYPE_SCREENSHOT_SHAREBAR_TIME = "EventTypeScreenShotShareBarTime";

	public const string EVENT_TYPE_MATCHMAKING_CANCEL = "EventTypeMatchMakingCancel";

	public const string EVENT_TYPE_UGC_CREATOR_RECREATION_SETTING = "EventTypeUGCCreatorRecreationSetting";

	public const string EVENT_TYPE_UGC_DOWNLOAD_TO_RECREATION = "EventTypeUGCDownloadToRecreation";

	public const string EVENT_TYPE_UGC_SURVEY_FEEDBACK = "EventTypeUGCSurveyFeedback";

	public const string EVENT_TYPE_UGC_MAPSURVEY_URLEXPOSED = "EventTypeUGCMapSurveyURLExposed";

	public const string EVENT_TYPE_UGC_OUTGAME_MATCHRESULTPAGE = "EventTypeOutGameMatchResultPage";

	public const string EVENT_TYPE_WEAPON_EXP_ADDFAVORITES = "EventTypeWeaponExpAddFavorites";

	public const string Event_Type_MMTotalTime = "EventTypeMMTotalTime";

	public const string Event_Type_FFAssistant = "EventTypeFFAssist";

	public const string Event_Type_FFAssistant_Notice = "EventTypeFFAssistNotice";

	public const string Event_Type_VeteranIntimacyInfo = "EventTypeVeteranIntimacyInfo";

	public const string Event_Type_ReturnUserRemind = "EventTypeReturnUserRemind";

	public const string Event_Type_LoginSummary = "EventTypeLoginSummary";

	public const string EVENT_TYPE_ENTER_LEAVE_LOBBY = "EventTypeEnterLeaveLobby";

	public const string EVENT_TYPE_LOGINTIME = "EventTypeLoginTime";

	public const string EVENT_TYPE_OPTIONAL_DOWNLOADINFO = "OptionalDownloadInfo";

	private const string EVENT_TYPE_NETWORK_SETTING = "EventTypeNetworkSetting";

	public const string EVENT_TYPE_UGC_REQUEST_GAME_DATA_URL = "EventTypeUGCRequestGameDataURL";

	public const string EVENT_TYPE_UGC_LOADING_GAME_DATA_DOWNLOAD = "EventTypeUGCLoadingGameDataDownload";

	public const string EVENT_TYPE_UGC_LOADING_RES_DOWNLOAD = "EventTypeUGCLoadingResDownload";

	public const string EVENT_TYPE_RECOMMEND_GROUP_INVITE = "EventTypeRecommendGroupInvite";

	public const string EVENT_TYPE_APPLY_LOADOUT_PLAN = "EventTypeApplyLoadoutPlan";

	public const string EVENT_TYPE_LOADOUT_PLAN_RENAME = "EventTypeLoadoutPlanRename";

	public const string EVENT_TYPE_PRELOAD_STATICS_INFO = "EventTypePreloadResourceStaticsInfo";

	public const string EVENT_TYPE_POOL_STATICS_INFO = "EventTypePoolStaticsInfo";

	public const string EVENT_TYPE_LOC_USE_INFO = "EventTypeLocTranslationUseInfo";

	public const string EVENT_TYPE_EMOTE_CHANGE = "EventTypeEmoteChange";

	public const string EVENT_TYPE_SUPER_EMOTE_PLAY = "EventTypeSuperEmotePlay";

	public const string EVENT_TYPE_LBS_NEARBY_SEARCH_USE = "EventTypeLBSNearbySearchUse";

	public const string EVENT_TYPE_LBS_NEARBY_SEARCH_FIRST_AUTH = "EventTypeLBSNearbySearchFirstAuth";

	public const string EVENT_TYPE_LBS_NEARBY_SEARCH_RECOMMEND = "EventTypeLBSNearbySearchRecommend";

	public const string EVENT_TYPE_WEAPONGLORY_SETTING = "EventTypeWeaponGlorySetting";

	public const string EVENT_TYPE_SLOPE_SLIDE_DOWN_DETECTION = "EventTypeSlopeSlideDownDetection";

	public const string EVENT_TYPE_UGC_CUSTOM_COVER_SETTING = "EventTypeUGCCustomCoverSetting";

	public const string EVENT_TYPE_UGC_SUBSCRIBE_TO_CRAFTLAND_UPDATE = "EventTypeUGCSubscribeToCraftlandUpdate";

	public const string EVENT_TYPE_UGC_PLATFORM_HOME_SETTING_CHANGE = "EventTypeUGCPlatformHomeSettingChange";

	public const string EVENT_TYPE_MIC_VOICE_SETTING = "EventTypeMicVoiceSetting";

	public const string EVENT_TYPE_BUILD_SYSTEM_SETTING = "EventTypeBuildSystemSetting";

	public const string EVENT_TYPE_BUILD_SYSTEM_APPLY = "EventTypeBuildSystemApply";

	public const string EVENT_TYPE_PACK_CHECK_BOX_STATS = "EventTypePackCheckBoxStats";

	public const string EVENT_TYPE_PUBLISH_BUILD_SYSTEM = "EventTypePublishBuildSystem";

	public const string EVENT_TYPE_REPLAYKIT_RECORD_SETTING = "EventTypeScreenRecordSetting";

	public const string EVENT_TYPE_REPLAYKIT_SAVE_STATS = "EventTypeScreenRecordSaveStats";

	public const string EVENT_TYPE_REPLAYKIT_DELETE_STATS = "EventTypeScreenRecordDeleteStats";

	public const string EVENT_TYPE_TRAINING_STATS = "EventTypeTrainingStats";

	public const string EVENT_TYPE_OUT_GAME_REPORT = "EventTypeOutGameReport";

	public const string EVENT_TYPE_CLAN_REPORT = "EventTypeClanReport";

	public const string EVENT_TYPE_UGC_CREATE_ROOM_PARAM_SETTING = "EventTypeUGCCreateRoomParamSetting";

	public const string EVENT_CPU_FREQUENCIES = "EventTypeCPUFreq";

	public const string EVENT_RESOURCE_RECORD = "EventTypeResourceRecord";

	public const string EVENT_TYPE_UGC_CONFIRM_RES_DOWNLOAD = "EventTypeUGCConfirmResDownload";

	public const string EVENT_TYPE_QUICK_MSG_SETTING = "EventTypeQuickMessageSetting";

	public const string EVENT_TYPE_LOBBY_MESSAGE = "EventTypeLobbyMessage";

	public const string EVENT_TYPE_PLAYER_SURVEY = "EventTypePlayerSurvey";

	public const string EVENT_TYPE_QUICK_FEEDBACK_QUEST = "EventTypeQuickFeedbackQuest";

	public const string EVENT_TYPE_ANTI_ADDICTION_BIND_PHONE = "EventTypeAntiAddictionBindPhone";

	public const string EVENT_TYPE_ANTI_ADDICTION_CHOOSE = "EventTypeAntiAddictionChoose";

	public const string EVENT_TYPE_ANTI_ADDICTION_CHOOSE_BR = "EventTypeAntiAddictionChooseBR";

	public const string EVENT_TYPE_ANTI_ADDICTION_PRECHECK_IP_US = "EventTypeAntiAddictionPrecheckIPUS";

	public const string EVENT_TYPE_ANTI_ADDICTION_CHOOSE_IP_US = "EventTypeAntiAddictionChooseIPUS";

	public const string EVENT_TYPE_ANTI_ADDICTION_BAN_ACK_IP_US = "EventTypeAntiAddictionBanAckIPUS";

	public const string EVENT_TYPE_MINOR_CHAT_REPORT = "EventTypeMinorChatReport";

	public const string EVENT_TYPE_ANTI_ADDICTION_BAN = "EventTypeAntiAddictionBan";

	public const string EVENT_TYPE_BUNDLE_SIZE = "EventTypeBundleSize";

	public const string EVENT_TYPE_HIGH_PING_POPUP = "EventTypeHighPingPopUp";

	public const string EVENT_TYPE_METROPOLIS_CHAT = "EventTypeMetropolisChatSummary";

	public const string EVENT_TYPE_ITEM_EXPOSED = "EventTypeItemExposed";

	public const string EVENT_TYPE_PRIME_SHARE = "EventTypePrimeShare";

	public const string EVENT_TYPE_PRIME_SHARE_SUCCESS = "EventTypePrimeShareSuccess";

	public const string EVENG_TYPE_PRIME_SHARE_CANCEL = "EventTypePrimeShareCancel";

	public const string EVENT_TYPE_WEB_VIEW_MEMORY_OPTIMIZATION = "EventTypeWebViewMemOptAnd32";

	public const string EVENT_TYPE_SOCIAL_ISLAND = "EventTypeSocialIsland";

	public const string EVENT_TYPE_SPECIAL_MODE_DISPLAY_CLICK = "EventTypeSpecialModeDisplayClick";

	public const string EVENT_TYPE_UGC_GAME_CUSTOM = "EventTypeUGCCreativeModeRoundStatsClient";

	public const string EVENT_TYPE_UGC_PLAYER_CUSTOM = "EventTypeUGCCreativeModePlayerRoundStatsClient";

	public const string EVENT_TYPE_MIC_VOICE_TIME = "EventTypeMicVoiceTime";

	public const string EVENT_TYPE_MultiplayerEmotion = "EventTypeMultiplayerEmotion";

	public const string EVENT_TYPE_GUILD_WAR_BARRAGE = "EventTypeGuildWarBarrage";

	public const string EVENT_TYPE_BUNDLEBOX_CLICK = "EventTypeBundleboxClick";

	public const string EVENT_TYPE_SPECIAL_KILL = "EventTypeSpecialKill";

	public const string EVENT_TYPE_UGC_PLATFORM_STUDIO_SETTING = "EventTypeUGCPlatformStudioSettingChange";

	public const string Event_Type_AI_Theme_Generation = "EventTypeAIThemeGeneration";

	public const string EVENT_TYPE_AI_TEXT_FUZZY_SEARCH_DETAIL = "EventTypeAITextFuzzySearchDetail";

	public const string EVENT_TYPE_AI_TEXT_FUZZY_SEARCH_DETAIL_BLOCK = "EventTypeAITextFuzzySearchDetailBlock";

	public const string EVENT_TYPE_AI_ASSISTANT_MODE_PARA_TUNING = "EventTypeAIAssistantModeParaTuning";

	public const string EVENT_TYPE_LLM_RESPONSE_TIME = "EventTypeLLMResponseTimeClient";

	public const string EVENT_TYPE_ANGEL_DEVIL_CLICK = "EventTypeAngelDevilBubbleClick";

	public const string EVENT_TYPE_ANGEL_DEVIL_TEACH = "EventTypeAngelDevilBubbleTeach";

	public const string EVENT_TYPE_NOTIFICATION_POPUP = "EventTypeNotificationPopUp";

	public const string EVENT_TYPE_REPORT_GATEWAY_FAILED = "EventTypeEventGatewayReportFailed";

	public const string Prefs_Gateway_Failed_Detail = "Gateway_Failed_Detail";

	public const string EVENT_TYPE_OTP_BIND = "EventTypeOTPBind";

	public const string EVENT_TYPE_OTP_UNBIND = "EventTypeOTPUnbind";

	public const string EVENT_TYPE_OTP_CHANGE_BIND = "EventTypeOTPChangeBind";

	public const string EVENT_TYPE_OTP_ACCOUNT_RECOVERY = "EventTypeOTPAccountRecovery";

	public const string EVENT_TYPE_MAINPLATFORM_CHANGEBIND = "EventTypeMainPlatformChangeBind";

	public const string EVENT_TYPE_HIPPO_CRISIS_PRESTART = "EventTypeHippoCrisisPreStart";

	public const string EVENT_TYPE_BANNED_PLAYER_APPEAL = "EventTypeBannedPlayerAppeal";

	public const string EVENT_TYPE_ADDMATCHINGBLACKLIST = "EventTypeAddMatchMakingBlacklist";

	public const string EVENT_TYPE_REMOVEBLACKLIST = "EventTypeRemoveBlacklist";

	public const string EVENT_TYPE_SOCIAL_ISLAND_INVITE = "EventTypeSocialIslandInvite";

	public const string EVENT_TYPE_ACCEPT_SOCIAL_ISLAND_INVITE = "EventTypeAcceptSocialIslandInvite";

	public const string EVENT_TYPE_TRAINING_INVITE = "EventTypeTrainingInvite";

	public const string EVENT_TYPE_ACCEPT_TRAINING_INVITE = "EventTypeAcceptTrainingInvite";

	public const string EVENT_TYPE_JOIN_OTHER_SOCIAL_ISLAND = "EventTypeJoinOtherSocialIsland";

	public const string EVENT_TYPE_JOIN_OTHER_TRAINING = "EventTypeJoinOtherTraining";

	public const string EVENT_TYPE_POTENTIAB_DIMENSIONSHARE = "EventTypePotentiaBDimensionShare";

	public const string EVENT_TYPE_UGC_GAMEDATA_DOWNLOAD_OUT_GAME = "EventTypeUGCGameDataDownloadOutGame";

	public const string EVENT_TYPE_UGC_MODE_PAGE_RES_CHECK = "EventTypeUGCModePageResCheck";

	public const string EVENT_TYPE_UGC_SHOW_MAP_DOWNLOAD = "EventTypeUGCShowMapDownload";

	public const string EVENT_TYPE_SET_GALLERY = "EventTypeSetGallery";

	public const string EVENT_TYPE_QUIT_TIMEOUT = "EventTypeQuitTimeout";

	public const string EVENT_TYPE_UGC_PLATFORM_MAPS_EXPOSURE = "EventTypeUGCPlatformMapsExposure";

	public const string EVENT_TYPE_UGC_MONETIZATION_TRIGGERED = "EventTypeUGCMonetizationTriggered";

	public const string EVENT_TYPE_MIC_ACCESS_POPUP = "EventTypeMicAccessPopUp";

	public const string EVENT_TYPE_CDN_DOWNLOAD_INFO = "EventTypeCDNDownloadInfo";

	public const string EVENT_TYPE_AI_ASSISTANT_FAQ = "EventTypeAIAssistantFAQ";

	public const string EVENT_TYPE_CRAFTLAND_SEARCH_USAGE_RECORD = "EventTypeCraftlandSearchUsageRecord";

	public const string EVENT_TYPE_CRAFTLAND_TEMPLATE_SAVE = "EventTypeCraftlandTemplateSave";

	public const string EVENT_TYPE_CRAFTLAND_TEMPLATE_DEL = "EventTypeCraftlandTemplateDel";

	public const string EVENT_TYPE_CRAFTLAND_TEMPLATE_UPLOAD = "EventTypeCraftlandTemplateUpload";

	public const string EVENT_TYPE_CRAFTLAND_ASSET_UPLOAD_SUCCESS = "EventTypeCraftlandAssetUploadSuccess";

	public const string EVENT_TYPE_CRAFTLAND_SEARCH_PAGE_ASSET_PURCHASE = "EventTypeCraftlandSearchPageAssetPurchase";

	public const string EVENT_TYPE_CRAFTLAND_ASSET_STORE_CLICK = "EventTypeCraftlandAssetStoreClick";

	public const string EVENT_TYPE_CRAFTLAND_ASSET_STORE_EXPOSURE = "EventTypeCraftlandAssetStoreExposure";

	public const string EVENT_TYPE_CRAFTLAND_ASSET_REPORT = "EventTypeCraftlandAssetReport";

	public const string EVENT_TYPE_CRAFTLAND_MAP_OBJECT_USAGE = "EventTypeCraftlandMapObjectUsage";

	public const string EVENT_TYPE_TECH_BUILD_VOTE = "EventTypeTechBuildVote";

	public const string EVENT_TYPE_THUMBSUP = "EventTypePonyThumbsup";

	public const string EVENT_TYPE_PONY_MAP_START_DOWNLOAD = "EventTypePonyMapStartDownload";

	public const string EVENT_TYPE_CLANWAR_TITLE_EQUIP = "EventTypeClanWarTitleEquip";

	public const string EVENT_TYPE_TARGET_TRACTION_MISSION = "EventTypeTargetTractionMission";

	public const string EVENT_TYPE_SCAN_QRCODE_INFO = "EventTypeScanQRCodeInfo";

	public const string EVENT_TYPE_AI_BOTAGENT = "EventTypeAIBotAgent";

	public const string EVENT_TYPE_TAKE_PHOTO = "EventTypeTakePhoto";

	public const string EVENT_TYPE_UGC_PRELOAD_TIMEOUT = "EventTypeUGCPreloadTimeout";

	public const string EVENT_TYPE_UGC_MAP_TRANSLATION_FAIL = "EventTypeUGCMapTranslationFail";

	public const string EVENT_TYPE_SHARE_FRAME_STICKER_USE = "EventTypeShareFrameStickerUse";

	public const string EVENT_TYPE_UGC_VIEW_MAP_LEADERBOARD = "EventTypeUGCViewMapLeaderboard";

	public const string EVENT_TYPE_INVITE_FRIEND_TOPUP = "EventTypeInviteFriendTopup";

	public const string EVENT_TYPE_STORE_VERSION = "EventTypeStoreVersion";

	public const string EVENT_TYPE_AITHREEDIMITEMGENERATION = "EventTypeAIThreeDimItemGeneration";

	public const string EVENT_TYPE_CRAFTLAND_BLOCK_SCRIPT_TEMPLATE_SAVE = "EventTypeCraftlandBlockScriptTemplateSave";

	public const string EVENT_TYPE_CRAFTLAND_OPERATION_LOADING_DURATION = "EventTypeCraftlandOperationLoadingDuration";

	public const string EVENT_TYPE_FIGHT_CLUB_INVITE_DUEL = "EventTypeFightClubInviteDuel";

	public const string EVENT_TYPE_TRIGGER_LUCKY_REMIND = "EventTypeTriggerLuckyRemind";

	public const string EVENT_TYPE_RELAY_MART_ADD_CART = "EventTypeRelayMartAddCart";

	public const string EVENT_TYPE_RELAY_MART_SHARE_COUPON = "EventTypeRelayMartShareCoupon";

	public const string EVENT_TYPE_UGC_DOWNLOAD_CL_BASIC_PACKAGE = "EventTypeUGCDownloadCLBasicPackage";

	public const string EVENT_TYPE_UGC_UNLOCK_OFFLINE_MODE = "EventTypeUGCUnlockOfflineMode";

	public const string EVENT_TYPE_UGC_PLAYER_ENTER_OFFLINE_MODE = "EventTypeUGCPlayerEnterOfflineMode";

	public const string EVENT_TYPE_SOCIAL_HUB_PERSONAL_INFO_TRIGGER = "EventTypeSocialHubPersonalInfoTrigger";

	public const string EVENT_TYPE_SOCIAL_HUB_SOFT_CLOSE_CHOICE = "EventTypeSocialHubSoftCloseChoice";

	public const string EVENT_TYPE_SOCIAL_HUB_OFFLINE = "EventTypeSocialHubOffline";

	public const string EVENT_TYPE_SOCIAL_HUB_LW_WATCH = "EventTypeSocialHubLWWatch";

	public const string EVENT_TYPE_SOCIAL_HUB_MIC_VOICE_TIME = "EventTypeSocialHubMicVoiceTime";

	public const string EVENT_TYPE_UGC_OFFLINE_MATCH_STATS = "EventTypeUGCOfflineMatchStats";

	public const string EVENT_TYPE_FIGHT_ON_INFO = "EventTypeFightOnInfo";

	public const string EVENT_TYPE_NEWBIE_FRIEND_RECOMMEND = "EventTypeNewbieFriendRecommend";

	public const string EVENT_TYPE_NEWBIE_TEAM_FLOATING_WINDOW = "EventTypeNewbieTeamFloatingWindow";

	public const string EVENT_TYPE_NEWBIE_DAILY_QA = "EventTypeNewbieDailyQA";

	public const string EVENT_TPYE_UGC_PLATEFORM_START_SURVEY_SUBMIT = "EventTypeUGCPlatformStartSurveySubmit";

	public const string EVENT_TYPE_UGC_CREATOR_NEWBIE_TASK = "EventTypeUGCCreatorNewbieTask";

	public const string EVENT_TYPE_FILEINFO_ENCRYPT = "EventTypeFileInfoEncrypt";

	public const string EVENT_TYPE_SETTLEMENT_INVITE = "EventTypeSettlementInvite";

	public const string EVENT_TYPE_SETTLEMENT_INVITE_POPUP = "EventTypeSettlementInvitePopup";

	public const string EVENT_TYPE_MAIL_SEND_SUCCESSFULLY_CLIENT = "EventTypeMailSendSuccesslyClient";

	private static EventClick eventClick;

	private static EventType9AnniversaryPrivilegeItemUse eventType9AnniversaryPrivilegeItemUse;

	private static EventBriefBoxClick eventBriefBoxClick;

	private static EventTypeSocialHubPersonalInfoTrigger eventSocialHubPersonalInfoTrigger;

	private static EventTypeSocialHubMicVoiceTime eventSocialHubMicVoiceTime;

	private static EventNavigate eventNavigation;

	private static EventUGCNavigate eventUGCNavigation;

	private static EventTypeCraftlandAssetStoreClick eventTypeCraftlandAssetStoreClick;

	private static EventTypeCraftlandAssetStoreExposure eventTypeCraftlandAssetStoreExposure;

	private static EventTypeCraftlandTemplateSave eventTypeCraftlandTemplateSave;

	private static EventTypeCraftlandTemplateDel eventTypeCraftlandTemplateDel;

	private static EventBackMallCount eventBackMallCount;

	private static EventBroadCastTypeCnt eventBroadCast;

	private static EventTrainingLocalGame eventTrainingLocalGame;

	private static EventTypeTrainingStats eventTypeTrainingStats;

	private static EventWereWolvesGame eventWereWolvesGame;

	private static EventLogPageDetentionTimeCached eventLogPageDetentionTimeCached;

	private static EventTypePopupWindowViewTime eventTypePopupWindowViewTimeCached;

	private static EventCustomRoomVoiceChat eventCustomRoomVoiceChat;

	private static EventTypeClickWorkshopMapExposed eventtypeclickworkshpmapexposed;

	private static EventTypeRelayMartAddCart eventTypeRelayMartAddCart;

	public static int LastPauseFrame;

	private static EventTypeOptionalBundleDownload m_EventTypeOptionalBundleDownloadCache;

	private static EventTypeUGCMapDetailsPopup eventTypeUGCMapDetailsPopup;

	private static EventTypeDigitalUniverseConcertStats m_EventTypeDigitalUniverseConcertStats;

	private static EventTypeCDNDownloadFail eventTypeCDNDownloadFail;

	private static EventTypeProtocolStats eventTypeProtocolStats;

	private static EventTypeLobbyPerformanceStats eventLobbyPerformanceStats;

	private static EventTypeLoginTime eventLoginTime;

	private static EventTypeNetworkSetting eventNetworkSetting;

	private static EventTypeWeaponGlorySetting eventWeaponGlorySetting;

	private static EventTypeSpecialModeDisplayClick eventSpecialModeDisplayClick;

	private static EventTypeMicVoiceTime eventMicVoiceTime;

	private static EventTypeBundleBoxClick bundleBoxClick;

	private static EventNotificationPopUp eventNotificationPopUp;

	private static EventGatewayReportFailed eventGatewayFailed;

	private static EventTrialPickUpWeapon eventTrialPickUpWeapon;

	private static List<uint> bundleBoxClickIds;

	private static Dictionary<uint, uint> PerformanceWaitNetTimeCount;

	private static EventTypeUGCPlatformMapsExposure eventUGCMapExposure;

	private static EventTypeUGCMonetizationTriggered eventUGCMonetizationTriggered;

	private static EventTypeCDNDownloadInfo eventCDNDownloadInfo;

	private static EventTypeAIAssistantModeParaTuning eventAIAssistantModeParaTuning;

	private static EventTypeUGCPreloadTimeout eventUGCPreloadTimeout;

	private static EventTypeCraftlandOperationLoadingDuration eventCraftlandOperationDuration;

	private static EventTypeMinorChatReport eventTypeMinorChatReport;

	private static EventTypeMinorChatReport eventTypeMinorVoiceReport;

	private static EventShareWebViewScreenShotExtraInfo eventWebViewScreenshotInfo;

	private static MutableString m_MutableString;

	public static EventTypeMMTotalTime typeMMTotalTime;

	public static EventReturnLobbyAfterDeath_RuntimeData EventReturnLobbyAfterDeathRuntimeData;

	public static EventOpOnBag_RuntimeData EventOpOnBagRuntimeData;

	public static EventWaitingForMatchmaking_RuntimeData EventWaitingForMatchmakingRuntimeData;

	public static EventAddFriendActively_RuntimeData EventAddFriendActivelyRuntimeData;

	public static int BigJankInfoCount;

	public static EventFPS_RuntimeData EventFPSRuntimeData;

	public static EventFPS_RuntimeData EventFPSRuntimeDataCache;

	public static EventGameMemory_RuntimeData EventGameMemoryData;

	public static EventGameLag_RuntimeData EventGameLagData;

	public static EventObserverLog EventObserverLogData;

	public static bool HasStartObserver;

	public static EventElitePassEntry EventElitePassEntryLog;

	public static EventClientPushSetting EventClientPushSettingData;

	public static EventTypeClientSettingChange EventClientSettingChange;

	public static float JoinMatchStartTime;

	public static float ConnectGSStartTime;

	public static float LoadingStartTime;

	public static uint match_num;

	public static string Region;

	public static ulong UserID;

	public static uint AndroidEngineInitFlag;

	public static float m_sepctorTime;

	public static float m_sepctorStartTime;

	public static string m_chipset;

	public static EventEnterGame EnterGame;

	public static EventLeaveGame LeaveGame;

	public static EventLeaveGameExtraInfo LeaveGameExtraInfo;

	public static VoiceToTextInfo VoiceToTextInfoData;

	public static EventEnterWaitingIsland EnterWaitingIsland;

	public static EventLeaveWaitingIsland LeaveWaitingIsland;

	private static float m_RenderStateSampleTimer;

	private static int m_NguiDCTotalSum;

	private static int m_OpaqueObjCountSum;

	private static int m_TransparentObjCountSum;

	private static int m_ParticleSimulationCountSum;

	private static float m_WaitForPresentMsSum;

	private static int m_RenderStateSampleCount;

	public static EventIngameTips IngameTips;

	private static uint ingameTipsOrginal;

	public static IngameEnterGameData enterGameData;

	public static EventBRDeadInfo EventBRDead;

	public static EventTypeSlopeSlideDownDetection SlopeSlideDownDetection;

	public static EventTypeVeteranGamePlayTrigger VeteranGamePlayTriggerData;

	public static EventTypeVeteranGamePlayMatchTrigger VeteranGamePlayMatchTriggerData;

	public static EventTypePreloadResourceStaticsInfo PreloadResourceStaticsInfo;

	public static EventTypePoolStaticsInfo PoolStaticsInfo;

	public static EventTypeLocTranslationUseInfo LocTranslationUseInfo;

	public static EventTypeMicVoiceSetting MicVoiceSettings;

	public static FrontEndGameFPSLogDataContext FrontEndGameFPSContext;

	public static Dictionary<Type, JankPage> FrontEndGameJankPages;

	private static int s_AnimationJankCount;

	private static int s_MsgGroupJankCount;

	private static int s_CDNJankCount;

	private static int s_SyncNewSysFrameCount;

	private static List<string> s_AsyncNewSysPerfName;

	private static List<string> s_PrepareDelNewSysPerfName;

	private static float s_NewSysPerfTimeOut;

	private static int s_DuringFrameCount;

	private const int AutoResetUserActionUIMask = 16;

	private const int AutoResetUserActionUIMaskMedkit = 256;

	private const int AutoResetUserActionUIMaskPickupList = 2048;

	private const int AutoResetUserActionUIMaskSwitchUIGroup = 4096;

	private const int AutoResetUserActionUIMaskSwitchTCP = 8192;

	private const int AutoResetUserActionUIMaskCSRoundResult = 16384;

	private const int AutoResetUserActionUIMaskExecuteAIAgent = 131072;

	private const int AutoResetUserActionUIMaskExecuteCollectionTransformer = 262144;

	private const int AutoResetUserActionUIMaskExecuteCollectionAction = 524288;

	private const int AutoResetUserActionUIMaskChat = 1048576;

	private const int AutoResetUserActionUIMaskPetAnim = 2097152;

	private const int AutoResetUserActionUIMaskReportFeedBack = 4194304;

	private const int AutoResetUserActionUIMaskHurtHint = 16777216;

	private const int AutoResetUserActionUIMaskDeadUI = 33554432;

	private const int AutoResetUserActionUIMaskReviveUI = 67108864;

	private const int AutoResetUserActionLuckyDrawBox = 32768;

	private const int AutoResetUserActionVehicleObserverHud = 268435456;

	private static int s_OpenedUserActionUI;

	private static int s_OpenUserActionUIFc;

	private static int s_ClosedUserActionUI;

	private static int s_CloseUserActionUIFc;

	public static uint s_EnterSapDelayResetId;

	private static readonly List<KeyValuePair<uint, uint>> s_TopResentCmdsBuf;

	private static readonly StringBuilder s_TopResentCmdsSb;

	public static float LauncherLoadingTime;

	public static bool ServerLoginGetDescFailed;

	public static bool RequestedMSDKForm;

	private static Stopwatch stopWatch;

	private static Stopwatch s_InstantiateJankStopwatch;

	private static bool s_EnableLogInstantiateJank;

	private static IEnumerator DelayCoroutine;

	public static EventTypeVoiceConnectInfo EventVoiceConnectInfo;

	private static float m_SearchTimeDelta;

	public static EventCPUFreq RecordedCPUFrequencies;

	public static EventCPUFreq_RuntimeData CPUFreqRuntimeData;

	public static EventResourceRecord ResourceRecord;

	public static EventResourceRecord_RuntimeData ResourceRecordRuntimeData;

	private static EventVoiceTimeRecord m_RecordVoiceTime;

	private static EventSocialHubMicVoiceTimeRecord m_RecordSocialHubMicVoiceTime;

	private static EventVoiceTimeRecord m_RecordMicVoiceTime;

	private static EventTypeSpecialKill m_SpecialKillLog;

	private static EventTypeAngelDevilBubbleTeach eventTypeAngelDevilBubbleTeach;

	public const string EVENT_TYPE_8_ANNIVERAERY_EDIT = "EventType8AnniversaryEdit";

	public const string EVENT_TYPE_9_ANNIVERSARY_SCENE_INTERACTION = "EventType9AnniversarySceneInteraction";

	public const string EVENT_TYPE_9_ANNIVERSARY_PRIVILEGE_ITEM_USE = "EventType9AnniversaryPrivilegeItemUse";

	public const string EVENT_TYPE_WINTERLAND25_EGG_GAME_START = "EventTypeWinterland25EggGameStart";

	public const string EVENT_TYPE_WINTERLAND25_EGG_GAME_LEAVE = "EventTypeWinterland25EggGameLeave";

	public const string EVENT_TYPE_MSDK_REG_FORM_SHOWN = "EventTypeMinorLoginPopupAppear";

	public const string EVENT_TYPE_MSDK_REG_FORM_CLOSED = "EventTypeMinorLoginPopupReturn";

	private static MutableString mutableString => null;

	public static void LogSettlementInvite(EventTypeSettlementInvite log)
	{
	}

	public static void LogSettlementInvitePopup(EventTypeSettlementInvitePopup log)
	{
	}

	public static void SendBundleSizeInfo(float equippedSize, float ownedSize)
	{
	}

	public static void SendRepairClickLog(string repairResult)
	{
	}

	public static void SendRepairOccurErrorLog(string repairReason, int bundle_id, string optional_version)
	{
	}

	public static void SendOptionalDownloadInfo(List<uint> downloaded_bundle, List<string> downloaded_abPack, List<uint> unfinished_bundle, List<string> unfinished_abPack)
	{
	}

	public static void SendBigEventFirstViewLog(uint event_id, string from_page_id)
	{
	}

	public static void SendBigEventVideoStatsLog(uint view_time, bool if_complete, uint event_id)
	{
	}

	public static void OnLocalPlayerKnockdownOrKilled()
	{
	}

	public static void LogSuperEmotePlay(uint superEmoteId, uint type, float playTime, uint superEmoteJoinPlayRoleNum)
	{
	}

	public static void LogSlopeSlideDownDetection(Vector3 position)
	{
	}

	public static void OnLogin()
	{
	}

	public static void OnLogout()
	{
	}

	public static void AddContinuousLkesInfo(ulong getLikeAccountId, bool isFriend, int triggerType, int triggerReason, int likeCnt)
	{
	}

	public static void SwitchObserver()
	{
	}

	public static void StartObserver(int mode)
	{
	}

	public static void ClickEndObserver()
	{
	}

	public static void SendLogObserver()
	{
	}

	public static void LogWeaponExpAddFavorites(uint weapon_id, uint weapon_level, uint operation, uint oper_view)
	{
	}

	public static void LogSplashBannerGoto(uint id, string goto_url, uint goto_pos)
	{
	}

	public static void LogNewBieSplashBannerGoto(uint goto_pos)
	{
	}

	public static void LogAnniversaySplashBannerGoto(uint id, string goto_url, uint goto_pos)
	{
	}

	public static void LogVeteranSplashBannerGoto(uint gopos)
	{
	}

	public static void LogAnniversaySplashBannerPush(uint event_id, uint entry_id, bool state)
	{
	}

	public static void LogAnniversayTemplateSplashBannerPush(uint event_id, uint entry_id, bool state)
	{
	}

	public static void LogEventLoadingTimeUtilCloseMask(float time)
	{
	}

	public static void LogEventWaitingForMatchmaking(float currentTime)
	{
	}

	public static void LogBRTutorialLobbyGuide(bool guideWithMask)
	{
	}

	public static void LogBRTutorialABTest(bool abTestOpen)
	{
	}

	public static void LogBRTutorialABTestAutoMatch(bool autoMatch)
	{
	}

	public static void LogBRTutorialGoal(uint goalId)
	{
	}

	public static void LogNewbieMatchMakingInfo(uint gameMode)
	{
	}

	public static void LogNewbieMatchMakingCancelInfo()
	{
	}

	public static void LogAnimationJankInfo()
	{
	}

	private static bool IsAnimationJank()
	{
		return false;
	}

	public static void LogMsgGroupJankInfo()
	{
	}

	private static bool IsMsgGroupJank()
	{
		return false;
	}

	public static void LogCDNJankInfo()
	{
	}

	private static bool IsCDNJank()
	{
		return false;
	}

	public static void LogNewSystemPerfInfo()
	{
	}

	public static void BeginNewSystemPerfInfo(string perfname)
	{
	}

	public static void EndNewSystemPerfInfo(string perfname)
	{
	}

	private static bool DuringNewSystem()
	{
		return false;
	}

	public static void SendStoreEventLog()
	{
	}

	public static void StartLogFPS(EventFPS_RuntimeData.FPSTrackingStep step, float gameTime, float duration)
	{
	}

	public static void LogFPS(float currentTime, float fps)
	{
	}

	private static void SendFPSLog(bool leaveGame = false, bool isEndGameCall = false)
	{
	}

	public static void SampleRenderState()
	{
	}

	private static void ResetRenderStateSampling()
	{
	}

	public static void OnOpenOrCloseUI(UserActionUI ui, bool open)
	{
	}

	private static bool CheckUserActionUIJank(EventFPS_RuntimeData.FPSTrackingStep FPSStep, BigJankInfo bigJankInfo, bool record = true)
	{
		return false;
	}

	private static bool CheckUserActionUICloseJank(EventFPS_RuntimeData.FPSTrackingStep FPSStep, BigJankInfo bigJankInfo, bool record = true)
	{
		return false;
	}

	private static void CheckManualGCJank(BigJankInfo bigJankInfo)
	{
	}

	private static void CheckUdpCMD(BigJankInfo bigJankInfo)
	{
	}

	private static void CheckSyncLoadResource(BigJankInfo bigJankInfo)
	{
	}

	private static void CheckBigJankStatus(BigJankInfo bigJankInfo)
	{
	}

	public static void LogPlayerNumFPS(float currentTime, int fps)
	{
	}

	public static void LogGameMemory(EGameTimeType _type, bool completeLog = true)
	{
	}

	public static void RecordLeavePVPMemory()
	{
	}

	private static void SendGameMemoryLog()
	{
	}

	public static void StartLogGameLag()
	{
	}

	public static void SetGameItemMarkClickLog(EMEFBBBEPDG itemMarkType, EILKGGIDJEH pointType = EILKGGIDJEH.EItemMarkPointType_NB, bool isContainer = false)
	{
	}

	public static void SetGameItemMarkTypeLog(EMEFBBBEPDG itemMarkType, uint itemMarkId, bool isContainer = false)
	{
	}

	public static void SendGameLagLog()
	{
	}

	public static void LogPing(bool noPop = false, bool completeLog = true)
	{
	}

	private static string BuildTopResentCmdsString(int topN)
	{
		return null;
	}

	public static void ClearRudpDelayInfo()
	{
	}

	public static void LogRudpDelayInfo()
	{
	}

	public static void LogBillboard(uint announcementId = 0u, uint activityId = 0u, string url = "")
	{
	}

	public static void LogEnterDeathReplayInfo(int stage)
	{
	}

	public static void LogTriggerBotAgent(int id, bool play)
	{
	}

	public static void LogUIHudBotAgentMarkBtn(bool isshow, int preVol, int curVol)
	{
	}

	public static void LogCSUIHudBotAgentMarkBtn(bool isshow, int preVol, int curVol)
	{
	}

	public static void LogExitDeathReplayInfo(int stage, bool complete, int time = 0)
	{
	}

	public static void LogRecoverFromDeathReplay(int stage)
	{
	}

	public static void LogBigMapClickPinTime(int time)
	{
	}

	public static void LogDisconnectFromNetwork(EDisconnectionType disconnectionType, int reason)
	{
	}

	public static void SendProfilePageViewTime()
	{
	}

	public static bool SendEventLog(string eventType, EventLoggerBase payload)
	{
		return false;
	}

	public static void SendEventLogJson(string eventType, string payloadJson)
	{
	}

	private static bool IsOfflineCareLog(string eventType)
	{
		return false;
	}

	public static void SendCachedUGCNavigationLogs()
	{
	}

	private static void CacheOfflineCareLog(string eventType, EventLoggerBase payload)
	{
	}

	public static void SendBeforeLoginEventLog(string eventType, EventLoggerBase payload, string region = "", ulong accountId = 0uL)
	{
	}

	public static void SendFailedEventLog()
	{
	}

	private static void OnEventLogSent(HttpErrorCode errorCode, object obj)
	{
	}

	public static void SendNetworkEventLog(string eventType, object payload)
	{
	}

	public static void LogConnectNotiFail(string notiIp, bool connSuccess, string exceptionMsg)
	{
	}

	private static float ParseSwitchSampleRate(string content)
	{
		return 0f;
	}

	private static string GetCurrentDateTime()
	{
		return null;
	}

	public static EventLoginInfo LoginInfo()
	{
		return null;
	}

	public static void LogIAPResult(string item_identifier, int error_code, string error_message, bool is_first_time, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	public static void LogTakePhoto(EventTypeTakePhoto share)
	{
	}

	public static void LogShare(EventShare share)
	{
	}

	public static void LogShare(EventShare share, EventShareExtraInfoBase extraInfo)
	{
	}

	public static void LogUGCShare(EventUGCShare share)
	{
	}

	public static void LogShareChat(EventShareChat shareChat)
	{
	}

	public static void LogShareFrameStickerUse(EventTypeShareFrameStickerUse frameStickerUse)
	{
	}

	private static Dictionary<string, string> ProcessUrl(string url)
	{
		return null;
	}

	public static void LogReportCheat(ulong cheater, uint reason, BHGGAEEHJCO cheaterPlayerID, uint[] subReason = null, bool inGame = true, uint reporteeType = 4u, int reportScene = -1, string cheaterClientVersion = "", uint cheaterClientType = 0u, UIModelReport.EReportMethod reportMethod = UIModelReport.EReportMethod.Common)
	{
	}

	public static void LogReportCheatInHistory(ulong cheater, uint reason, MatchStats stats, ulong matchID = 0uL, uint[] subReason = null, uint reporteeType = 4u, string cheaterClientVersion = "", uint cheaterClientType = 0u)
	{
	}

	public static void LogBRMatchResult(uint pre_rank, uint pre_level, int pre_ranking_points, uint cur_rank, uint cur_level, int cur_ranking_points)
	{
	}

	public static void LogClanWarTitleEquip(uint preTitleId, uint curTitleId)
	{
	}

	public static void LogOpenGachaRewardPool()
	{
	}

	public static void LogLimitLotteryDefaultRemove(uint lotteryID, uint lotterySubID, bool isDefault, uint[] removeItems)
	{
	}

	public static void SendChatEvent(EventChat eventChat)
	{
	}

	public static void LogGiftReceive(uint itemId, uint expireTime, uint source)
	{
	}

	public static void LogMailSendSuccessfullyClient(string localMailId, long mailTs, int mailType, string extraInfo)
	{
	}

	public static void LogIAPBundlePurchase(int storeID, int bundleID, float priceUSD, int discount, int rebateID, string productIdentifier, UINavigationUtil.UINavigationFrom ui_from)
	{
	}

	public static void LogAndroidApplicationDetection(List<int> installedIDs)
	{
	}

	public static void LogChampionshipClick(ChampioshipClickType type, uint championshipType, uint championshipID)
	{
	}

	public static void InitCacheLogSend()
	{
	}

	private static void SendCachedLogs()
	{
	}

	public static void InitSceneEditCacheLogSend()
	{
	}

	public static void SendSceneEditCachedLogs()
	{
	}

	private static void ReportFailedLogs()
	{
	}

	public static void CacheFailedLogs()
	{
	}

	public static int StopWatchElapsedMilliseconds()
	{
		return 0;
	}

	public static void SampleLoadTimeBegin()
	{
	}

	public static void SampleLoadTimeEnd()
	{
	}

	private static void InitLogLobbyPerformanceStats()
	{
	}

	public static void LogLobbyPerformanceStatsLoadTime(PageType pageType)
	{
	}

	public static void LogLobbyPerformanceWaitNetTime(PageType pageType, float wait_time_float)
	{
	}

	public static void LogLobbyPerformanceStatsFPS(PageType pageType)
	{
	}

	public static void SendLobbyPerformanceStats()
	{
	}

	private static uint GetShadowOption()
	{
		return 0u;
	}

	public static void LogEnterGame()
	{
	}

	public static void LogCabinWaitingEnd()
	{
	}

	private static void InitLeaveGameLog()
	{
	}

	public static void LogIOSIDFA(string open_id, string idfa)
	{
	}

	public static void LogEnterBattery()
	{
	}

	public static void AddPetClickCnt()
	{
	}

	public static void AddScoreboardClickCnt()
	{
	}

	public static void AddScoreboardWeaponSkillSwitchClickCnt()
	{
	}

	public static void AddGrowthPanelClickCnt()
	{
	}

	public static void AddWeaponExecutionTriggerCnt(int weaponID, int executionID)
	{
	}

	public static void AddScoreboardViewTime(int deltaTime)
	{
	}

	public static void AddPetId(int id)
	{
	}

	public static void LogClickMiniMapCnt()
	{
	}

	public static void LogClickWaitingMapMarkCnt()
	{
	}

	public static void LogFollowEmoteBecomeDriver()
	{
	}

	public static void LogFollowEmoteJoinAsPassenger()
	{
	}

	public static void LogBigMapViewTimer(float timer)
	{
	}

	public static void LogCDNGuideViewTimer(ulong detalTime)
	{
	}

	public static void LogSlideUseMoveStickCnt()
	{
	}

	public static void LogBigMapIsAirLineClick()
	{
	}

	public static void LogSettingAdviceIsPopUp()
	{
	}

	public static void LogLeaveGame(bool isEndGameCall = false, bool completeLog = true)
	{
	}

	public static void TryLogLeaveLobbySocialArea()
	{
	}

	public static void SendLogSlopeSlideDownDetection()
	{
	}

	public static void SendLogLeaveSceneEditGame()
	{
	}

	private static void NormalizeNullPublicStringFields(object target)
	{
	}

	private static void NormalizeNullPublicStringFieldsInternal(object target, HashSet<object> visited)
	{
	}

	private static bool IsStringValueDictionaryType(Type targetType)
	{
		return false;
	}

	private static bool IsStringListType(Type targetType)
	{
		return false;
	}

	public static void SendLogLeaveGame()
	{
	}

	public static void LogLeaveVehicleByOverheadRayCast()
	{
	}

	public static void LogParachuteInfo(bool diving_use, bool diving_joystick_use, bool isLeadJumpOff)
	{
	}

	public static void LogTechDeviceDesInfo()
	{
	}

	public static void LogHudSwitchWeaponSkinClick(uint weapon_id, uint cur_skin_id, uint pre_skin_id)
	{
	}

	public static void EnableLogInstantiateJank(bool enable, bool clear)
	{
	}

	public static void StartLogInstantiateJank()
	{
	}

	public static void EndLogInstantiateJank(GameObject go)
	{
	}

	public static void SendLogEndGame(bool completeLog = true)
	{
	}

	private static IEnumerator DelayFCoroutine()
	{
		return null;
	}

	public static void SetLobbyBatteryConsumption(int batteryConsumption, int lobbyTime)
	{
	}

	public static void ResetLobbyBatteryConsumption()
	{
	}

	public static void LogHighFPSSwitch()
	{
	}

	public static void LogTabViewTime(EventNaviTabViewTime eventTypeFlashStoreTabInfo)
	{
	}

	public static AbNameInfo GetAbNameInfo(string package_name)
	{
		return null;
	}

	public static void LogIngameTutorialTrigger(uint id)
	{
	}

	public static void LogIngameCSGuideTrigger(uint guideId)
	{
	}

	public static void LogIngameTutorialCloseInfo(uint id, uint closeid)
	{
	}

	public static void LogOptionalBundleDownload(uint bundle_id, string package_name, uint download_network_status, List<uint> download_type, string complete_result, string optional_version, bool downloadSource = false, DownloadInfoSourceForm downloadForm = null)
	{
	}

	public static void LogHudSettingChange(List<HudConfigItem> configs, int prePreset, bool isSmartAdjust)
	{
	}

	public static void LogVehicleHudSettingChange(List<HudConfigItem> configs)
	{
	}

	public static void LogOptionalBundleDelete(uint bundle_id, List<uint> download_type, string optional_version, bool delete_recommend)
	{
	}

	public static void LogEventTypeTeamDownload(uint member_cnt, bool if_all_team)
	{
	}

	public static void LogNavigate(string from, string to)
	{
	}

	public static void LogCraftlandAssetStoreClick(UGCResourceShopMetaData metaData, int type_id = 0, int event_id = 0)
	{
	}

	public static void LogCraftlandAssetStoreExposure(UGCResourceShopMetaData metaData, int type_id = 0, int event_id = 0)
	{
	}

	public static void LogUGCNavigate(UINavigationUtil.UINavigationFrom ui_from, string from_info, UINavigationUtil.UINavigationFrom ui_to, string to_info)
	{
	}

	public static void LogTemplateSave(string uuid, string templateName, List<SceneEditObjectBase> objects, List<GraphData> graphs)
	{
	}

	public static void LogTemplateDel(string uuid)
	{
	}

	public static void LogTemplateUpload(string uuid, ulong resourceId, string resourceName, int mainCategory, int category, string desc, int bPublic, int recreation, uint cost)
	{
	}

	public static void LogAssetUploadSuccess(ulong resourceId)
	{
	}

	public static void LogAssetReport(UGCResourceShopMetaData metaData, List<uint> common_datas, string common_text, List<uint> other_datas, string other_text)
	{
	}

	public static void LogResoruceShopSearchPurchase(UGCResourceShopMetaData metaData, int cl_category_id, int purchase_index, bool is_ai_result, int type_id = 0, int event_id = 0)
	{
	}

	public static void LogClickByValue(ClickType clickType, uint value, string[] hierarchy)
	{
	}

	public static void LogClick(ClickType clickType, string[] hierarchy)
	{
	}

	public static void LogBriefBoxClick(ulong targetID, int module, int subModule, int detail, bool isGuild)
	{
	}

	public static void LogRelayMartAddCart(int relay_mart_id, List<EventTypeRelayMartAddCartGoodsInfo> item_info, int discount_price, bool is_use_coupon, EventTypeRelayMartUsedCouponInfo used_coupon_info)
	{
	}

	public static void LogNotificationPopUpInteraction(ENotificationPopUpType windowType, ENotificationPopUpInteractionType interactionType)
	{
	}

	public static void SendLogEventTypeTrialPickUpWeapon()
	{
	}

	public static void LogEventTypeTrialPickUpWeapon_TrialCollection(uint itemId)
	{
	}

	public static void LogEventTypeTrialPickUpWeapon_PickUpWeapon(uint weaponId)
	{
	}

	public static void LogEventTypeTrialPickUpWeapon_TriggerFinalShot()
	{
	}

	public static void LogUINavigationClose(string page_name, int view_time)
	{
	}

	public static void SendTrainingCenterEnter(int id, int sortId, int tag, int tabs, int preProcess)
	{
	}

	public static void LogEventTypeDigitalUniverseConcertStats(ESingersBMiniGameLogType type)
	{
	}

	public static void SendEventTypeDigitalUniverseConcertStats(bool isDrop)
	{
	}

	public static void LogUGCMapDetailsPopup(uint scene, string code, ulong id)
	{
	}

	public static void LogPopupWindowClose(string windowName, int viewTime)
	{
	}

	public static void LogPopularUGCFirst(string workshopname)
	{
	}

	public static void LogPopularUGC(string workshopname)
	{
	}

	public static void LogWeekUGCFirst(string workshopname)
	{
	}

	public static void LogWeekUGC(string workshopname)
	{
	}

	public static void LogRecommendList(SceneEditSlotInfo data, bool click)
	{
	}

	public static void LogBroadCastType(EventBroadCastType type)
	{
	}

	public static void CacheBackMall()
	{
	}

	public static void LogClickGetAvatarBtn(uint avatarID, bool isbundlebtn)
	{
	}

	public static void OnApplicationPause(bool paused)
	{
	}

	public static void OnApplicationQuit()
	{
	}

	public static void InitIngameTipsSetting(uint value)
	{
	}

	public static void LogIngameTipsSetting(uint value)
	{
	}

	public static void SendIngameTipsSetting()
	{
	}

	public static void SendBasicSettingLog(EventSettingChangeLog log)
	{
	}

	public static void SendMaxSettingLog(EventSettingChangeLog log)
	{
	}

	public static void SendOperationSettingLog(EventSettingChangeLog log)
	{
	}

	public static void LogEnterWaitingIslandBattery()
	{
	}

	public static void SendLogEnterWaitingIsland()
	{
	}

	public static void LogLeaveWaitingIslandBattleStarted(bool battleStarted)
	{
	}

	private static void InitLogLeaveWaitingIsland()
	{
	}

	public static void SendLogLeaveWaitingIsland()
	{
	}

	public static void LogLeaveWaitingIslandPing()
	{
	}

	public static void LogClientPushSetting(bool is_first_login = false)
	{
	}

	public static void LogClientSettingChange()
	{
	}

	public static void LogBigBannerGoto(int gopos, string subgopos)
	{
	}

	public static void LogFriendRecommend(RecommendFriendInfo recommendFriend, int choose)
	{
	}

	public static void LogMaxLobbyYardEditTime(int time)
	{
	}

	public static EventTrainingLocalGame GetTrainingLocalGameInfo()
	{
		return null;
	}

	public static void SendTrainingLocalGameLog()
	{
	}

	public static EventTypeTrainingStats GetTrainingStats()
	{
		return null;
	}

	public static void SendEventTypeTrainingStats()
	{
	}

	public static void StartCustomRoomVoiceChat(tcp.RoomInfo info)
	{
	}

	public static void LogCustomRoomVoiceMicClick(uint micClick, uint hornClick)
	{
	}

	public static void LogCustomRoomVoiceState(bool micOn, bool hornOn)
	{
	}

	public static void SendCustomRoomVoiceChat()
	{
	}

	public static EventWereWolvesGame GetEventWereWolvesGame()
	{
		return null;
	}

	public static void SendWereWolvesGameLog()
	{
	}

	public static void SendBRDeadInfo(int deadReason)
	{
	}

	public static EventShareWebViewScreenShotExtraInfo GetCurrentWebViewScreenshotInfo()
	{
		return null;
	}

	public static void SetCurrentWebViewScreenshotInfo(string url, string activityName)
	{
	}

	public static void ClearCurrentWebViewScreenshotInfo()
	{
	}

	public static void OnSystemScreenShot()
	{
	}

	public static void LogMatchSuccessLoading()
	{
	}

	public static void SendMVPInfoLog(uint rank, bool isMVP)
	{
	}

	public static void SendRegisterCreateNameLog(uint intitleTime)
	{
	}

	public static void SendBRTacticalReviewLog(ulong matchId, int durationTime, int reviewTime, int matchTime, int channel)
	{
	}

	public static void SendReplaySaveStatsLog(bool success, uint match, uint game, uint group, byte rank)
	{
	}

	public static void SendHighlightsTriggerLog(uint match, uint game, uint group, uint map, ulong matchID, float time)
	{
	}

	public static void SendReplaySaveInfoLog(uint match, uint game, uint group, uint map, ulong matchID, uint channel, bool highlight, float replayTime, float highlightTime, byte rank, List<HightlightEventInfoData> highlight_event_infos)
	{
	}

	public static void SendReplayHighlightFilterSetting(uint event_id, bool if_check, ulong match_id)
	{
	}

	public static void SendCupLobbyResultLog(bool isShow, bool isDraw)
	{
	}

	public static void SendWorkshopSceneEditLog(uint totalTime, uint closeCnt, uint closeTime, uint editCnt, uint freeTime, uint adjustFloorUpCnt, uint adjustFloorDownCnt, float adjustFloorMaxHeight, uint topViewTime, uint topViewCnt, uint maxGroupedCnt, uint slot_id, string workshop_code, uint game_mode, uint debug_time, uint debug_cnt, uint saveCount, Dictionary<uint, uint> saveErrorInfos, uint intersectionEditTime, uint clickConsoleCnt, uint clickConsoleLinkCnt, uint preAutoSaveSetting, uint curAutoSaveSetting, uint autoSaveSuccessCnt, uint autoSaveFailCnt, uint timeline_asset_cnt, List<EventTypeWorkshopSceneEdit.TimelineTrackInfo> timeline_track_info, uint timeline_track_edit_time, uint timeline_scene_edit_time, uint timeline_asset_avg_duration, bool is_halfway_join_enabled, List<uint> timeline_switch_camera_track_cnt, uint timeline_camera_track_fpv_edit_time, uint timeline_camera_track_normal_edit_time, List<EventTypeWorkshopSceneEdit.TimelineAnimationTrackInfo> timeline_animation_track_info, List<EventTypeWorkshopSceneEdit.TimelineAudioTrackInfo> timeline_audio_track_info, uint timeline_event_track_send_cnt, uint timeline_audience_pers_btn_cnt)
	{
	}

	public static void SendCDNTransferTrafficMonitor(uint type, ulong transfer_size, uint transfer_time)
	{
	}

	public static void SendGuildWarCabinPanelViewTime(ulong view_time)
	{
	}

	public static void SendEventRecruitInfoLog(uint account_type, uint active_days, uint active_time, uint mode, uint declaration_type, uint[] send_channel)
	{
	}

	public static void LogEventTypeRecruitQuickSwitchTeam()
	{
	}

	public static void SendSplashBannerPopupLog(uint id)
	{
	}

	public static void SendNewBieSplashBannerPopupLog()
	{
	}

	public static void SendGuildWarSplashBannerPopupLog(EGuildWarSplashBannerType type)
	{
	}

	public static void SendLocalNotificationStats(EventLocalNotificationStats stats)
	{
	}

	public static void SendEventRemoteNotification(string env_name, string task_id)
	{
	}

	public static void SendEventFcmRmtNtfRecv(EventFcmRmtNtfRecv e)
	{
	}

	public static void LogEventPushLinkReturn(string url, string pushType)
	{
	}

	public static void SendEventTypeDefaultMusicClick(bool click)
	{
	}

	public static void SendEventTypeHackClientFix(uint fix_type)
	{
	}

	public static void SendEventUniversalLinkGoto(string universal_link)
	{
	}

	public static void SendEventNewModeGoto(uint gameMode, uint matchMode, uint groupMode, uint from)
	{
	}

	public static bool SendUGCLoginInfo()
	{
		return false;
	}

	public static void LogEventTypeCupLoginAnimation(uint cup_type, uint cup_id, bool is_click, uint animation_type)
	{
	}

	public static void LogEventTypeFullScreenAnimation(FullscreenCgDesc cgDesc, uint lotteryID = 0u, uint lotterySubID = 0u, uint season = 0u, float playTime = 0f, float animTime = 0f, uint isPlayActively = 0u)
	{
	}

	public static void ConstructEventTypeVoiceConnectInfo(RoomInfo joinRequest)
	{
	}

	public static void AddVoiceConnectInfo(bool is_disconnect)
	{
	}

	public static void LogEventVoiceConnectInfo()
	{
	}

	public static void LogEventGuestSAFPermission(int result)
	{
	}

	public static void LogEventMapSelected(uint matchMode, uint gameMode, List<uint> mapIdList)
	{
	}

	public static void LogUGCTagSelected(List<uint> tagIds)
	{
	}

	public static void LogEventTypeMatchMakingCancel(uint gameMode, uint matchMode, uint groupMode, float waitTimeSecs)
	{
	}

	public static void LogEventTypeFriendRecommendPopup(ulong recommendAccountId, ERecommendPopupStatus status)
	{
	}

	public static void LogEventTypeExpansionGroupInvite(ulong account_id, string region, uint game_mode, uint match_mode, uint before_group_mode, uint after_group_mode, uint type, ulong receiverID, ulong group_id)
	{
	}

	public static void LogEventTypeFFAssist(List<EventTypeAssistInfos> assistInfos)
	{
	}

	public static void LogEventTypeFFAssistNotice(List<EventTypeAssistNoticeInfos> assistNoticeInfos)
	{
	}

	public static void LogEventTypeVeteranIntimacyInfo(List<IntimacyInfo> intimacyInfos, uint leaveDays)
	{
	}

	public static void LogEventTypeReturnUserRemind(ulong[] remindedIDs)
	{
	}

	public static void LogEventTypeLoginSummary(EventTypeLoginSummary data)
	{
	}

	public static void LogEventTypeVeteranGamePlayTrigger()
	{
	}

	public static void LogEventTypeVeteranGamePlayMatchTrigger()
	{
	}

	public static void LogEventTypeVeteranTagMatchStats(uint main_group_id, uint[] sub_group_ids, uint[] barrage_types, uint is_group_highlight, uint player_choice)
	{
	}

	public static void LogEventTypeVeteranNewHotTagTrigger(uint game_mode, string tag, int type)
	{
	}

	public static void LogSceneEditFunnelEnterUGCLog()
	{
	}

	public static void LogSceneEditFunnelCreateMap()
	{
	}

	public static void CDNDownFail(string targetUrl, int failType, string failReason)
	{
	}

	public static void LogProtocolStats(string protocol, uint returnTime, uint status_code)
	{
	}

	public static void LogSplashBannerClose(uint bannerId, bool isCheck)
	{
	}

	public static void LogUGCDownloadToRecreation(string workshopCode, ulong authorId, uint mapScene, uint slotID)
	{
	}

	public static void LogUGCSurveyFeedback(uint issue1_option_id, uint[] issue2_option_ids, string detail_comments, uint survey_scene, string[] screenshot_urls, string[] video_urls, string language, string platform, string device_model, string os_version, string project_id, string project_name, string project_url, uint mode_template_id, uint group_mode, string editor_version, string game_version, string resource_version, string network_type, string report_log)
	{
	}

	public static void LogUGCMapSurveyURLExposed(string workshop_code, uint map_scene, ulong match_id, uint accu_match_cnt, uint click_survey_cnt)
	{
	}

	public static void LogUGCOutGameMatchResultPage(string workshop_code, ulong match_id, ulong group_id, bool is_like, bool is_dislike, bool is_subs_before, uint subs_action, bool is_click_mapcomment, bool is_click_moremaps, bool is_click_newgame, ulong author_id)
	{
	}

	public static void SendPermanentValueToWeaponSkinLog(uint weapon_skin_id, uint cur_permanent_value, uint acc_permanent_value)
	{
	}

	public static void OnScreenShotMessageWindowClose(uint returnTime)
	{
	}

	public static void SendItemsLoveChangeLog(List<EventTypeItemsLoveChange.ItemChangeInfo> list)
	{
	}

	public static void SendMMTotalTimeLog()
	{
	}

	public static void SetMMTotalTimeLogsStartSolo()
	{
	}

	public static void LogEventTypePrimeShare(ulong actionAccountID, bool isShareActive)
	{
	}

	public static void LogEventTypePrimeShareSuccess(ulong actionAccountID, bool isShareActive, uint[] itemInfo, int shareeRemainsTime)
	{
	}

	public static void LogEventTypePrimeShareCancel(int source, int remainTimes, uint[] itemInfo)
	{
	}

	public static void SetMMTotalTimeLogsStartGroup()
	{
	}

	public static void SetMMTotalTimeLogsEnd(MMresult result, ulong matchId, int mapId)
	{
	}

	public static void InitEventLoginTime()
	{
	}

	public static void LogLoginSdkTime(float t)
	{
	}

	public static void LogLoginServerTime(float t)
	{
	}

	public static void LogTimeSinceGameStartup(int t)
	{
	}

	public static void LogLauncherLoadingTime(float t)
	{
	}

	public static void LogRetrieveVersionTime(float t)
	{
	}

	public static void LogHotUpdateDownloadTime(float t)
	{
	}

	public static void SendLoginTime(bool isEmulator)
	{
	}

	public static void SendWebViewMemoryOptimization()
	{
	}

	public static void LogNetworkSetting(bool isMultiSessionEnable)
	{
	}

	public static void LogEventTypePreloadResourceStaticsInfo()
	{
	}

	public static void LogEventTypePoolStaticsInfo()
	{
	}

	public static void LogEventTypeLocTransUseInfo()
	{
	}

	public static void LogAutoSearchItemInfo(uint itemDataID)
	{
	}

	public static void LogAutoSearchPickInfo(uint itemDataID)
	{
	}

	public static void LogBagThrowItems(uint itemDataID, int itemNum, int isStack, int isSplit, int isThrowAll)
	{
	}

	public static void LogBagOpenTime(int openTime, int isStack)
	{
	}

	public static void LogBagOpenOnStrop()
	{
	}

	public static void LogAutoSearchTime(bool resetSearchTime)
	{
	}

	public static void LogWeaponGlorySetting(uint cfg_id, ulong leaderboard_id, uint weapon_id, uint rank, bool is_active)
	{
	}

	public static void LogUGCCustomCoverSetting(SceneEditSlotInfo info, EUGCScene settingScene, EventUGCCoverSettingType settingMode, EventUGCCoverActionType action)
	{
	}

	public static void LogUGCPlatformStudioSetting(bool preValue, bool curValue)
	{
	}

	public static void LogUGCAIThemeGenerateInfo(uint slotid, uint themeid, string code, List<JLFABCODABC> itemList, List<Vector3> areaInfos, bool isrefresh, uint mapId, uint areaId, uint planId, uint s1Cnt, uint s2Cnt)
	{
	}

	public static void LogMicVoiceSetting(EGameVoiceListenMode speaker, EGameVoiceListenMode mic)
	{
	}

	public static void LogBagShowSetting(bool isShowLobby, bool isShowInCSGame, bool isShowInOtherGame)
	{
	}

	public static void LogOutGameReport(uint report_scene, ulong reportee, uint reason, string extra_info)
	{
	}

	public static void LogClanReport(ulong clan_id, uint reason, string clan_name, string slogan)
	{
	}

	public static void LogUGCCreateRoomParamSetting(DKPCAEMALDP roomParams, tcp.RoomInfo info)
	{
	}

	public static void EventLogUGCConfirmResDownload(UGCSimpleDownloadTask ugcDownloadTask)
	{
	}

	public static void StartLogCPUFrequencies(CPUFreqRecordType recordType)
	{
	}

	public static void ForceEndLogCPUFrequencies()
	{
	}

	public static void LogCPUFrequencies()
	{
	}

	private static void InitCPUFreqRecording(CPUFreqRecordType recordType)
	{
	}

	private static void RecordCPUFrequencies(List<List<long>> cpuFrequencies)
	{
	}

	private static void FindBigLittleCore(List<List<long>> cpuFrequencies)
	{
	}

	private static void PrepareCPUFreqReportData()
	{
	}

	private static void ResetCPUFreqData()
	{
	}

	private static void AnalyseAndSendCPUFrequencies()
	{
	}

	public static void RecordAudioInfo(AudioClip clip)
	{
	}

	public static void SendResourceInfo()
	{
	}

	public static void SendHighPingPopUpLog(int groupMode, uint choice)
	{
	}

	public static void SendReplaykitSettingLog(bool microphone, bool ingame, bool lobby, int type)
	{
	}

	public static void SendReplaykitDeleteLog(int video_time, int type)
	{
	}

	public static void SendReplaykitSaveLog(bool success, uint match_mode, uint game_mode, int video_time, int type)
	{
	}

	public static void OnJoinFloatingLand()
	{
	}

	public static void OnLeaveFloatingLand()
	{
	}

	public static void SendEventTypeLobbyMessage(uint channelType, uint messageId, uint sceneId)
	{
	}

	public static void LogEventTypeAntiAddictionBindPhone(EBindPhoneOpt opt, string oldNumber, string newNumber, string res)
	{
	}

	public static void LogEventTypeAntiAddictionChoose(bool isAdult, bool isFirst)
	{
	}

	public static void LogEventTypeAntiAddictionChooseBR(bool isSkipped, string ageGroup, string verificationStatus, ChooseBRTriggerScene triggerScene, int ageState)
	{
	}

	public static void LogEventTypeAntiAddictionPrecheck_IP_US(string ip_region, bool is_minor, bool is_valid_region)
	{
	}

	public static void LogEventTypeAntiAddictionChoose_IP_US(UserAgeMgr.AgeResult ageResult, bool isAllowed, bool isErrorLogin = false)
	{
	}

	public static void LogEventTypeAntiAddictionBanAck_IP_US(string installID)
	{
	}

	public static void LogEventTypeAntiAddictionBan(bool inLobby, AntiAddictionBanTriggerScene triggerScene = AntiAddictionBanTriggerScene.TimeLimit)
	{
	}

	public static void CacheMinorChatReport(ulong adultAccountId, string adultAccountNickname, int channelType, ulong time)
	{
	}

	public static void CacheMinorVoiceReport(ulong adultAccountId, string adultAccountNickname, int channelType, ulong time)
	{
	}

	public static void LogEventTypeMinorChatReport()
	{
	}

	public static void LogEventTypeMinorVoiceReport()
	{
	}

	public static void LogEventTypeUGCPlayerCustom(uint roundId, string[] keys, object[] values)
	{
	}

	public static void LogEventTypeUGCCreativeModeRoundStatsClient(uint roundId, string[] keys, object[] values)
	{
	}

	public static void LogEventTypeMetropolisChat(EventTypeMetropolisChatSummary log)
	{
	}

	public static void LogFrontEndGameFPS()
	{
	}

	public static void EndLogFrontEndGameFPS()
	{
	}

	public static string GetJankInfoJson()
	{
		return null;
	}

	public static void LogCustomRoomVoiceTime(uint roomTime, uint teamTime)
	{
	}

	public static void LogCustomRoomVoiceChange(uint count)
	{
	}

	public static void RegisterEventLogVoice(EventVoiceTimeRecord eventLog)
	{
	}

	public static void RecordVoiceTimeInfo(EGameVoiceListenMode speaker, EGameVoiceListenMode mic)
	{
	}

	public static void LogSocialHubSoftCloseChoice(ulong matchId, ulong nextMatchId, bool isActive)
	{
	}

	public static void LogSocialHubOffline(ulong enterTs, ulong exitTs)
	{
	}

	public static void LogSocialHubLWWatch(ulong matchId, ulong startTs, ulong endTs)
	{
	}

	public static void InitSocialHubMicVoiceTime(EGameVoiceListenMode microphoneMode)
	{
	}

	public static void RecordSocialHubMicVoiceMode(EGameVoiceListenMode microphoneMode)
	{
	}

	public static void SendSocialHubMicVoiceTime()
	{
	}

	private static EventTypeSocialHubPersonalInfoTrigger GetSocialHubPersonalInfoTriggerLog()
	{
		return null;
	}

	private static EventTypeSocialHubPersonalInfoTrigger.TriggerDetail GetOrCreateSocialHubTriggerDetail(List<EventTypeSocialHubPersonalInfoTrigger.TriggerDetail> list, int triggerSource)
	{
		return null;
	}

	private static void AddUniqueAccount(List<ulong> list, ulong accountId)
	{
	}

	private static void LogSocialHubPersonalInfoTriggerDetail(List<EventTypeSocialHubPersonalInfoTrigger.TriggerDetail> list, ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId, bool isClick)
	{
	}

	private static bool IsValidSocialHubPersonalInfoTriggerDetail(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
		return false;
	}

	public static void LogSocialHubPersonalInfoTrigger(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialHubPersonalInfoClick(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialHubAddFriendTrigger(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialHubAddFriendClick(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialHubGroupInviteTrigger(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialHubGroupInviteClick(ESocialHubPersonalInfoTriggerSource source, ulong targetAccountId)
	{
	}

	public static void LogSocialIslandVoice(uint enterTime, uint exitTime, uint voiceOnTime, uint voiceMicTime, uint chat, float vehicleTime, uint block)
	{
	}

	public static void LogSpecialModeDisplayClick(ulong matchid, bool isEntrance)
	{
	}

	public static void LogSpecialModeDisplaySend()
	{
	}

	public static void InitNewMicVoiceTime()
	{
	}

	public static void RecordMicTime(bool open)
	{
	}

	public static void RecordChangeToMicPressPrivacy(bool isChangeToAll)
	{
	}

	public static void RecordChangeToMicPressCnt()
	{
	}

	public static void RecordLowVolumeCnt()
	{
	}

	public static void RecordRecevierTime(bool open)
	{
	}

	public static void RecordMicVoiceServiceOK()
	{
	}

	public static void RecordMicVoiceOffline()
	{
	}

	public static void SendRecordMicVoiceLog()
	{
	}

	public static void LogEventDuoEmote(ulong inviter, uint emoteId, bool inLobby, bool success, ulong inviteeAccount)
	{
	}

	public static void LogEventCooperateEmote(ulong leader, List<ulong> servants, uint emoteId)
	{
	}

	public static void LogBundleBoxClick(uint[] itemIds)
	{
	}

	public static void LogEventGuildWarBarrage(bool curStatus)
	{
	}

	public static void RecordAloneActionPopupCnt()
	{
	}

	public static void RecordAutoEnemyPinCount()
	{
	}

	private static SmartBubbleInfo GetOrCreateSmartBubbleInfo(int type, int bubbleId)
	{
		return null;
	}

	public static void RecordFistEmojiSmartTrigger()
	{
	}

	public static void RecordFistEmojiSmartClick()
	{
	}

	public static void RecordFistEmojiSmartSuccess()
	{
	}

	public static void RecordEmojiUseInfo(int emojiId)
	{
	}

	public static void RecordSmartBubbleTrigger(int bubbleId)
	{
	}

	public static void RecordSmartBubbleClick(int bubbleId)
	{
	}

	public static void RecordResponseChatTrigger()
	{
	}

	public static void RecordResponseChatClick()
	{
	}

	public static void RecordThumbUpTrigger()
	{
	}

	public static void RecordThumbUpClick()
	{
	}

	public static void RecordOneTapTeamRally()
	{
	}

	private static SlideInfo GetSlideInfoByID(int slideID)
	{
		return null;
	}

	public static void RecordSlideGetOnClick(int slideID)
	{
	}

	public static void RecordSlideJumpOnClick(int slideID)
	{
	}

	public static void RecordSlideTurnOnClick(int slideID)
	{
	}

	public static void RecordSlideGetOffClick(int slideID)
	{
	}

	public static void RecordSlideJumpOffClick(int slideID)
	{
	}

	public static void RecordSpecialKill(uint itemID, uint killType)
	{
	}

	public static void SendSpecialKillLog()
	{
	}

	public static void RecordAngelDevilBubbleTeach()
	{
	}

	public static void SendAngelDevilBubbleTeachLog()
	{
	}

	public static void LogAngelDevilBubbleClick(uint activity_id, uint sub_type, uint group_id)
	{
	}

	public static void SendOTPBindLog(int bindType, string bindInfo, int operType)
	{
	}

	public static void SendOTPBindlogBeforeLogin(int bindType, string bindInfo, int operType, ulong accountId, string region)
	{
	}

	public static void SendOTPUnBindLog(int bindType, string bindInfo, int operType)
	{
	}

	public static void SendOTPUnBindlogBeforeLogin(int bindType, string bindInfo, int operType, ulong accountId, string region)
	{
	}

	public static void SendOTPChangeBindLog(int oriBindType, string oriBindInfo, int bindType, string bindInfo, int operType)
	{
	}

	public static void SendOTPChangeBindlogBeforeLogin(int oriBindType, string oriBindInfo, int bindType, string bindInfo, int operType, ulong accountId, string region)
	{
	}

	public static void SendOTPAccountRecoveryLog(int bindType, ulong accountId)
	{
	}

	public static void SendOTPMainPlatformChangeBindLog(uint platform, string openId, ulong accountId)
	{
	}

	public static void LogEventTypeBannedPlayerAppeal(ulong accountId, string region, int level, int banReason)
	{
	}

	public static void SendBooyahDay24BShareLog(uint level, uint dimension_type, uint platform, string title)
	{
	}

	public static void SendTechBuildVoteLog(uint peroid, uint buildingId, uint tokenCnt, string pageName, bool isAllIn)
	{
	}

	public static void SendThumbsupLog(uint optionId, string pageName)
	{
	}

	public static void SendPonyMapStartDownloadLog(uint optionId, string pageName)
	{
	}

	public static void SendSetGallaryLog(EventTypeSetGallery log)
	{
	}

	public static void SendCraftlandMapObjectUsageLog(string workshopCode, long mapUpdateTs, List<EIJCHJHFFGI> itemInfo, List<EBEIAALOCBN> resourceInfo)
	{
	}

	public static void SendSocialMediaBindGotoLog(string platform)
	{
	}

	public static void SendSocialMediaBindLog(string platform, UIModelProfileCustom.ProfileSocialMediaBindType bindType)
	{
	}

	public static void LogUGCMapTranslationFail(string workshopCode, string language)
	{
	}

	public static void LogAIAssistantFAQ(ulong matchId, uint gameMode, uint matchMode, uint groupMode, bool isUgc, uint sceneId, uint voiceInputCnt, uint textInputCnt)
	{
	}

	public static void LogTargetTractionMission(uint gameMode, uint curRank, uint taskId, uint reason)
	{
	}

	public static void LogScanQRCodeInfo(uint scanSource, uint codeType, uint result, uint isFromAlbum = 0u, uint qRCodeGenerationChannel = 0u)
	{
	}

	public static void CheckAndSendQuitTimes()
	{
	}

	public static void SendMicAccessPopUp(EventTypeMicAccessPopUp log)
	{
	}

	public static void RecordCDNDownloadInfo(string url, uint downloadTime, int statusCode, int downloadTextureSize)
	{
	}

	public static void Send8AnniversaryEditOp(List<EventType8AnniversaryEdit.EventType8AnniversaryEditDetail> ops)
	{
	}

	public static void Log9AnniversarySceneInteraction(ENinthAnniversarySceneType sceneType, uint sceneId, ENinthAnniversaryInteractionType interactionType)
	{
	}

	public static void Record9AnniversaryPrivilegeItemUse(uint itemId)
	{
	}

	public static void Send9AnniversaryPrivilegeItemUse()
	{
	}

	public static void SendInviteFriendTopup(ulong leaderId, bool isPrivate, ulong inviteeId, InviteFriendTopupScene scene)
	{
	}

	public static void SendAIThreeDimItemGeneration(uint slot_id, string workshop_code, string input_text, List<ulong> output_item_ids, ulong target_item_id)
	{
	}

	public static void LogMagicVoiceInit(int effectId)
	{
	}

	public static void SendWinterland25EggGameStart(int process_id)
	{
	}

	public static void SendWinterland25EggGameLeave(int type, int per_process_id, int cur_process_id, int delta, int click_candy_num)
	{
	}

	public static void SendCraftlandBlockScriptTemplateSave(string template_uuid, string template_name, string template_description)
	{
	}

	public static void SendMsdkRegFormShown()
	{
	}

	public static void SendMsdkRegFormClosed(int closeType)
	{
	}

	public static void SendFightClubInviteDuel(ulong matchId, uint matchMode, uint gameMode, bool isInitiate)
	{
	}

	public static void SendTriggerLuckyRemind(uint lotteryId, uint lotterySubId, uint pageType, uint luckyId)
	{
	}

	public static void SendTriggerFileInfoEncrypt(List<FileInfoEncryptResult> decryptResults, List<FileInfoEncryptResult> encryptResults)
	{
	}

	public static void SendUGCDownloadCLBasicPackage()
	{
	}

	public static void SendUGCUnlockOfflineMode()
	{
	}

	public static void SendUGCPlayerEnterOfflineMode(int downloadMapCnt)
	{
	}

	public static void SendUGCOfflineMatchStats(string workshopCode, uint survivalTime, bool isDrop, long mapUpdateTs)
	{
	}

	public static void SendRelayMartShareCoupon(string couponCode, int relayMartId, List<ulong> shareAccountIds, int shareScene)
	{
	}

	public static void SendNaviPageTimeNoCache(EventLogPageDetentionTimeCached logList)
	{
	}

	public static void SendRematchFinishLog()
	{
	}

	private static FightOnResult BuildFightOnResult(UIModelGroup modelGroup, tcp.RematchPlayer currentPlayer)
	{
		return null;
	}

	private static bool IsSystemSelfQuitReason(tcp.ERematch.QuitReason reason)
	{
		return false;
	}

	public static void SendUGCPlatformStartSurveySubmits(UGCPlatformStartSurveySubmitDetail[] details, EventTypeUGCPlatformStartSurveySubmitTriggerReason reason)
	{
	}

	public static void LogNewbieFriendRecommend(List<NewbieFriendRecommendAccountInfo> recList)
	{
	}

	public static void LogEventTypeNewbieTeamFloatingWindow(ENewbieTeamFloatingWindowType floatingType, uint gameMode, uint matchMode, uint groupMode)
	{
	}

	public static void LogEventTypeNewbieDailyQA(int questionId, ENewbieDailyQAResult result)
	{
	}

	public static void LogLBSNearbySearchUse(int opType)
	{
	}

	public static void LogLBSNearbySearchFirstAuth(int result)
	{
	}

	public static void LogLBSNearbySearchRecommend(List<EventTypeLBSNearbySearchRecommendInfo> recommendList)
	{
	}
}
