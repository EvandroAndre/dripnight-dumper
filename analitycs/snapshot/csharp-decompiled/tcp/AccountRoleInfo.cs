using ProtoBuf;

namespace tcp;

public class AccountRoleInfo : IMessage
{
	public ulong account_id;

	public uint role;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
