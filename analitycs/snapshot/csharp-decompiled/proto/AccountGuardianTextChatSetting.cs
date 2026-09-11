using ProtoBuf;

namespace proto;

public class AccountGuardianTextChatSetting : IMessage
{
	public bool init;

	public GuardianTextChatSetting setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
