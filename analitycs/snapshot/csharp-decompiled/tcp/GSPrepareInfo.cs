using System.Collections.Generic;

namespace tcp;

public class GSPrepareInfo
{
	public string export_settings_url;

	public EMatch.MatchMode match_mode;

	public EMatch.GameMode game_mode;

	public EMatch.GroupMode group_mode;

	public uint difficulty;

	public uint map_id;

	public ulong room_id;

	public ulong room_creator_id;

	public uint room_type;

	public uint room_setting;

	public uint room_setting2;

	public uint room_max_mmr;

	public uint room_min_mmr;

	public uint max_level;

	public uint level_of_min_mmr_player;

	public bool enable_death_spectate;

	public bool enable_group_icon;

	public uint wait_join_time;

	public uint bot_cnt_lv1;

	public uint bot_cnt_lv2;

	public uint bot_cnt_lv3;

	public uint bot_cnt_lv4;

	public uint bot_cnt_lv5;

	public uint bot_cnt_lv6;

	public List<AIInfo> ai_infos;

	public byte[] cs_advanced_setting;

	public uint werewolves_room_param;

	public uint werewolves_room_param2;

	public uint werewolves_room_param3;

	public CustomRoomSinglePlayerMatchStats custom_room_match_stats;

	public uint casual_player_safe_zone_switch;

	public ReviveTokenCost revive_token_cost;

	public uint bot_cnt;

	public uint ai_cnt;

	public ulong match_id;

	public byte[] workshop_settings;

	public byte[] object_attribute_settings;

	public List<GSPlayerPrepareInfo> gs_player_prepare_infos;

	public string workshop_code;

	public string workshop_name;

	public byte[] mode_settings;

	public byte[] workshop_room_settings;

	public bool is_debug_gs;

	public bool is_half_join;

	public ShortWorkshopCodeInfo short_workshop_code_info;

	public uint workshop_resource_perm_mark;

	public bool is_spectator_join;

	public ulong shard_key;

	public uint room_setting3;

	public uint genre_id;

	public bool enable_cs_zone_select;

	public byte[] cs_zone_select;
}
