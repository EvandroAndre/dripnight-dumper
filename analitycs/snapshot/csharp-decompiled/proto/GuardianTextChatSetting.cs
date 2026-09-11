using ProtoBuf;

namespace proto;

public class GuardianTextChatSetting : IMessage
{
	public GuardianChatSetting chat_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
