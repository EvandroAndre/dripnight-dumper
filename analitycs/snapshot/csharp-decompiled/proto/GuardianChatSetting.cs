using ProtoBuf;

namespace proto;

public class GuardianChatSetting : IMessage
{
	public uint[] age_group_whitelist;

	public ulong[] uid_whitelist;

	public bool uid_whitelist_enable;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
