using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class PrimePrivilegeDetail : IMessage
{
	public ulong account_id;

	public uint prime_level;

	public List<EPrime.PrivilegeID> privilege_id_list;

	public int monthly_points;

	public int annually_points;

	public int sum_points;

	public uint sharee_remain_times;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
