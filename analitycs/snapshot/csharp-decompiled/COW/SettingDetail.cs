using System.Collections.Generic;

namespace COW;

public class SettingDetail
{
	public string hud_pos;

	public int quality;

	public int language;

	public int brightness;

	public int FPSSetting;

	public int shadow;

	public int resolution;

	public int minimapMode;

	public bool minimapScale;

	public float sensitivity;

	public float aux_aim_sensitivity;

	public float scope_sensitivity_1x;

	public float scope_sensitivity_2x;

	public float scope_sensitivity_4x;

	public float scope_sensitivity_8x;

	public int aim_assist;

	public int left_fire;

	public int change_weapon;

	public int reload;

	public int open_scope_operate;

	public int vehicle_control_mode;

	public int auto_slide;

	public int auto_pickup;

	public int use_auxaim;

	public int ingame_tips_mode;

	public int damage_setting;

	public bool auto_switch_weapon;

	public bool hit_hint;

	public int blood_mode;

	public int auto_pickup_weapon;

	public int auto_pickup_armor;

	public int auto_pickup_medkit;

	public int auto_pickup_bullet;

	public int auto_pickup_attachment;

	public int auto_pickup_throws;

	public int auto_pickup_special;

	public int auto_pickup_actitem;

	public int auto_pickup_speed;

	public float music_volume;

	public float sound_effect_volume;

	public float game_voice_volume;

	public bool should_notify;

	public bool should_notify_free_gachas;

	public bool accept_unknown_player_group_invite;

	public bool download_centre_need_show;

	public string hud_new_pos;

	public int hud_selected;

	public int grenade_direction;

	public int grenade_direction_new;

	public bool accept_group_invite;

	public bool accept_reservation_invite;

	public bool name_classic_enable;

	public int filter_type;

	public int grenade2_direction;

	public int grenade2_direction_new;

	public byte[] hud_1_zip;

	public byte[] hud_2_zip;

	public int grenade_slot_count;

	public int auto_pickup_FFToken;

	public bool RunningSettingMode;

	public int stacked_kill_mode;

	public int RunningNewSettingMode;

	public int use_auxaim_parachute;

	public int use_auxaim_dash;

	public int use_auxaim_drive;

	public float kill_sound_effect_volume;

	public List<AutoPickupPreferenceInfo> autopick_setting;

	public float ugc_camera_move_speed;

	public bool ugc_accept_friend_group_invite;

	public bool auto_equip_default_music;

	public bool smart_ice_wall;

	public bool special_character_voice;

	public byte[] hud_3_zip;

	public string hud_three_pos;

	public bool auto_download_in_wifi_state;

	public float game_voice_balance;

	public int grenade_direction_three;

	public int grenade2_direction_three;

	public bool network_optimize_multi_session;

	public int cross_hair_mode;

	public int cross_hair_reload;

	public bool br_scoreboard;

	public bool br_scoreboard_open_mode;

	public bool auto_hide_pet_on_start;

	public bool hit_armor_hint;

	public bool smart_icewall_show;

	public int item_finder_mode;

	public bool enable_mobile_replay;

	public bool game_voice_background;

	public bool game_voice_auto_balance;

	public int inventory_combine_state;

	public bool cs_shop_show_teammate_weapon_info;

	public bool invite_notify_state;

	public bool hide_teammate_name;

	public string hud_vehicle_pos;

	public byte[] hud_vehicle_zip;

	public int CollectionEffect;

	public int ugc_subscribe_recommend;

	public bool player_outline;

	public bool send_remind_notify_state;

	public bool HD_login_video;

	public int HD_show_max_lobby_state;

	public int HD_audio_engine;

	public int HD_show_my_lobby_on;

	public int HD_show_captain_lobby_on;

	public bool HD_use_Animation;

	public int HD_weapon_effect_on;

	public int HD_texture_on;

	public int HD_vehicle_vfx_on;

	public bool HD_max_setting_was_uploaded;

	public bool player_stats_show_sp;

	public int player_hint_type;

	public bool lobby_vibrate;

	public bool friend_invitation_push;

	public bool friend_recommend;

	public bool chat_bubble;

	public bool gameresult_friend_recommend;

	public bool gameresult_invite_recommend;

	public bool cupmatch_accept_invitation;

	public bool request_joincupteam_notification;

	public bool emoji_recieve;

	public bool barrage_friendship;

	public bool barrage_guildwar;

	public float gamevoice_volume_balance;

	public int vibrate_footsteps;

	public int vibrate_gunshoots;

	public int vibrate_takingdamage;

	public int vibrate_weapondamage;

	public int vibrate_invehicledamage;

	public int vibrate_collision;

	public int vibrate_roulette;

	public int vibrate_pickupitem;

	public float sensitivity_preset;

	public float aux_aim_sensitivity_preset;

	public float scope_sensitivity_1x_preset;

	public float scope_sensitivity_2x_preset;

	public float scope_sensitivity_4x_preset;

	public float scope_sensitivity_8x_preset;

	public int sensitivity_using_preset;

	public bool is_OB48_setting_uploaded;

	public bool Receive_TeamUpRecommend;

	public bool team_outline;

	public bool bot_agent_switch;

	public float bot_agent_voice_volume;

	public bool bot_agent_cat_feedback;

	public bool bot_agent_cat_loot;

	public bool bot_agent_cat_operation;

	public bool bot_agent_cat_gunhelper;

	public bool bot_agent_cat_survivetip;

	public bool bot_agent_cat_cooperation;

	public int auto_upload_switch_open;

	public bool smart_icewall_change_back_weapon;

	public int smooth_high_frame;

	public bool hud_button_hit;

	public bool damage_label_total;

	public bool ffo_porting_flag_50;

	public bool ai_chat_in_game_switch;

	public bool ai_chat_in_ugc_switch;

	public bool show_cd_time_txt;

	public byte[] hud_4_zip;

	public bool ff_porting_flag_51;

	public bool is_nortch_screen;

	public float screen_width;

	public float screen_height;

	public float NGUI_screen_width;

	public float NGUI_screen_height;

	public bool bot_agent_cs_switch;

	public float bot_agent_cs_voice_volume;

	public bool bot_agent_cs_rule;

	public bool bot_agent_cs_shop;

	public bool bot_agent_cs_battle;

	public bool bot_agent_cs_map;

	public bool sound_voice_hold_talk;

	public bool sound_voice_hold_talk_privacy;

	public bool in_game_quick_chat_v2;

	public bool mute_non_pre_match_teammate;

	public bool nearby_people_discoverable;

	public bool nearby_people_location_precision;

	public bool is_OB53_setting_uploaded;

	public int moving_joystick_mode;

	public bool is_OB54_setting_uploaded;

	public int vibrate_driving;

	public int enemy_fire_hint;

	public int auto_quick_message;

	public bool emote_only_1p_audio;

	public void InitDefaultSetting()
	{
	}
}
