using ProtoBuf;

namespace proto;

public class GuardianVoiceChatSetting : IMessage
{
	public GuardianChatSetting chat_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
