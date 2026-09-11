using System.Collections.Generic;

namespace tcp;

public class RoomInfo
{
	public ulong id;

	public string name;

	public ulong owner;

	public uint map_id;

	public uint game_mode;

	public uint group_mode;

	public uint max_member_num;

	public uint max_spectator_num;

	public uint state;

	public string code;

	public List<RoomGroupInfo> groups;

	public List<RoomPlayerInfo> spectators;

	public bool enable_death_spectate;

	public ERoom.Type room_type;

	public bool enable_group_icon;

	public uint match_times;

	public uint level_visual_style;

	public uint room_setting;

	public uint room_setting2;

	public bool enable_emulator_check;

	public bool is_cs_advanced;

	public byte[] cs_advanced_setting;

	public uint werewolves_room_param;

	public uint werewolves_room_param2;

	public uint language;

	public bool contestant_role_check;

	public WorkshopInfo workshop;

	public uint werewolves_room_param3;

	public bool enough_room_card;

	public bool owner_online;

	public ulong voice_id;

	public byte[] spectate_settings;

	public byte[] workshop_room_settings;

	public uint min_player_level;

	public ulong clan_id;

	public string channel_secret;

	public bool is_room_afk_open;

	public bool is_sole_active_skill;

	public uint room_setting3;

	public string room_qr_code;

	public ERoom.Class room_class;

	public List<RoomGroupMatchStatsInfo> group_match_stats_infos;

	public bool enable_score_board;

	public bool has_used_advanced_room_card;

	public long advanced_room_destroy_timestamp;

	public long auto_start_at;

	public uint round_id;

	public ulong esports_id;

	public string esports_icon;

	public long owner_inactive_timestamp;

	public bool enable_limited_event_gameplay;

	public bool enable_skill_bp;

	public RoomBPPhaseInfo bp_info;

	public bool enable_cs_zone_select;

	public byte[] cs_zone_select;

	public List<RoomWinStats> owner_win_stats;
}
