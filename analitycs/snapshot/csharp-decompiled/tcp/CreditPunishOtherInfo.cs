using ProtoBuf;

namespace tcp;

public class CreditPunishOtherInfo : IMessage
{
	public uint punish_type;

	public ulong sub_type;

	public long punish_until;

	public uint match_mode;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
