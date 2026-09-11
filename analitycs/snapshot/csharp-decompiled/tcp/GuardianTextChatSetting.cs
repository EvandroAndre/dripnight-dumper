using ProtoBuf;

namespace tcp;

public class GuardianTextChatSetting : IMessage
{
	public bool init;

	public GuardianChatSetting chat_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
