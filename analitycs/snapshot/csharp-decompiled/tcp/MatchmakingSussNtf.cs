using System.Collections.Generic;

namespace tcp;

public class MatchmakingSussNtf
{
	public ulong match_id;

	public string server_addr;

	public string secret;

	public string prepare_token;

	public uint sleep_ms;

	public uint map_id;

	public uint game_mode;

	public uint match_mode;

	public bool use_cache;

	public uint level_visual_style;

	public uint difficulty;

	public bool first_login;

	public bool is_in_special_pool;

	public byte[] workshop_settings;

	public byte[] mode_settings;

	public byte[] object_attribute_settings;

	public List<MatchPregameInfo> pregame_infos;

	public string workshop_code;

	public string workshop_name;

	public EMatch.GroupMode group_mode;

	public bool is_in_emulator_pool;

	public uint mode_template_id;

	public byte[] mini_map_settings;

	public byte[] mini_map_object_settings;

	public string workshop_desc;

	public string map_cover_url;

	public bool is_reconnection;

	public bool is_halfway_join;

	public uint[] tags;

	public uint min_est_play_time;

	public uint max_est_play_time;

	public float like_rate;

	public string sub_desc;

	public uint[] time_limited_tags;

	public ulong voice_id;

	public long notify_subscriber_time;

	public List<ClanInfo> clan_infos;

	public string export_settings_url;

	public uint special_mode_event_id;

	public bool is_spectator;

	public string udp_mask;

	public uint workshop_resource_perm_mark;

	public uint layer_id;

	public ulong shard_key;

	public uint game_pattern_id;

	public string gs_proxy_addr;

	public string gs_proxy_secret;

	public string server_proxy_addr;

	public string gs_proxy_udp_mask;

	public AccountIDCPingInfo voice_ping_info;

	public string original_workshop_code;

	public bool is_friend_half_join;
}
