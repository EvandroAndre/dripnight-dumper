using System.Collections.Generic;

namespace tcp;

public class MatchmakingStartReq
{
	public uint[] map_ids;

	public uint game_mode;

	public uint difficulty;

	public List<AccountIDCPingInfo> ping_list;

	public uint match_mode;

	public uint[] available_maps;

	public uint system_platform;

	public MatchClientInfo client_info;

	public List<string> workshop_codes;

	public EMatch.GroupMode workshop_group_mode;

	public bool is_workshop_team_contest;

	public uint[] workshop_team_counts;

	public uint special_mode_event_id;

	public ulong[] in_social_friends;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<MapVersionInfo> map_versions;

	public string gp_player_id;

	public string ugc_social_url;

	public ulong group_id;
}
