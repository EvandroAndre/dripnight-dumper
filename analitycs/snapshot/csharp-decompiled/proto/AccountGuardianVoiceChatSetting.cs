using ProtoBuf;

namespace proto;

public class AccountGuardianVoiceChatSetting : IMessage
{
	public bool init;

	public GuardianVoiceChatSetting setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
