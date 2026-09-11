using ProtoBuf;

namespace proto;

public class BlacklistInfoRes : IMessage
{
	public EAccount.BanReason ban_reason;

	public uint expire_duration;

	public uint ban_time;

	public string ban_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
