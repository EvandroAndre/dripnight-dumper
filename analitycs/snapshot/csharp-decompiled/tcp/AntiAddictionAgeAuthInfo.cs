using ProtoBuf;

namespace tcp;

public class AntiAddictionAgeAuthInfo : IMessage
{
	public ulong account_id;

	public uint auth_state;

	public string age_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
