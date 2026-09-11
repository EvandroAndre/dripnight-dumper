using ProtoBuf;

namespace proto;

public class BlacklistRes : IMessage
{
	public ulong account_id;

	public string device_id;

	public uint ban_reason;

	public uint ban_time;

	public string ban_reason_detail;

	public bool is_in_blacklist;

	public uint ban_expire_duration;

	public string ban_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
