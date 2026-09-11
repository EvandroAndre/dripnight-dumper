using ProtoBuf;

namespace tcp;

public class GuardianVoiceChatSetting : IMessage
{
	public bool init;

	public GuardianChatSetting chat_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
