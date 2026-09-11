using System.Collections.Generic;

namespace proto;

public class TopUpTeam
{
	public ulong team_id;

	public uint team_state;

	public uint activate_status;

	public ulong leader_account_id;

	public List<TopUpMember> members;

	public long unlock_deadline_setting;

	public long team_create_timestamp;

	public ulong creator_account_id;
}
