using ProtoBuf;

namespace tcp;

public class PrimePrivilegeDetail : IMessage
{
	public ulong account_id;

	public uint prime_level;

	public uint[] privilege_id_list;

	public int monthly_points;

	public int annually_points;

	public int sum_points;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
