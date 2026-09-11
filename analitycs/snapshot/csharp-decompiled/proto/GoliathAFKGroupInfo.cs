using System.Collections.Generic;

namespace proto;

public class GoliathAFKGroupInfo
{
	public ulong group_id;

	public ulong captain_id;

	public List<GoliathAFKGroupMember> members;

	public uint task_id;

	public long start_time_stamp;

	public long create_time_stamp;
}
