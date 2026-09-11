using System.Collections.Generic;

namespace tcp;

public class GroupStartReq
{
	public ulong group_id;

	public uint workshop_group_mode;

	public List<string> workshop_codes;

	public bool is_workshop_team_contest;

	public string workshop_name;

	public uint[] workshop_team_counts;

	public List<AccountIDCPingInfo> ping_list;

	public ulong[] in_social_friends;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public List<AccountIDCPingInfo> voice_ping_list;

	public uint matchmaking_reason;
}
