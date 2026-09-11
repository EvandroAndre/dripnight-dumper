using System.Collections.Generic;

namespace tcp;

public class MatchmakingPlayer
{
	public ulong account_id;

	public ulong conn_id;

	public ulong group_id;

	public string noti_region;

	public AccountMatchInfo basic_info;

	public bool is_hacker;

	public uint using_version;

	public string ip_region;

	public uint emulator_score;

	public uint hacker_cdt_id;

	public List<AccountIDCPingInfo> ping_list;

	public string pre_group_idc;

	public uint plat_id;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<AccountIDCPingInfo> voice_ping_list;

	public List<AccountIDCPingInfo> pre_group_ping_list;

	public string gp_player_id;

	public string ugc_social_url;
}
