using System.Collections.Generic;

namespace tcp;

public class GroupCreateReq
{
	public uint[] map_ids;

	public uint game_mode;

	public uint group_mode;

	public string language;

	public uint difficulty;

	public List<AccountIDCPingInfo> ping_list;

	public uint match_mode;

	public uint[] available_maps;

	public EGroup.CreateFromType from_type;

	public uint system_platform;

	public MatchClientInfo client_info;

	public uint required_rank;

	public string group_tag;

	public string workshop_code;

	public string workshop_name;

	public uint max_required_rank;

	public uint special_mode_event_id;

	public uint[] unavailable_game_modes;

	public bool is_intra_team_battle;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<MapVersionInfo> map_versions;

	public List<AccountIDCPingInfo> voice_ping_list;

	public TransformEmoteInfo transform_emote_info;

	public string gp_player_id;

	public ulong rematch_team_id;

	public long rematch_end_timestamp;

	public string ugc_social_url;
}
