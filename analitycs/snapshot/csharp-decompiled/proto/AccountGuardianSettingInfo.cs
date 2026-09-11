using ProtoBuf;

namespace proto;

public class AccountGuardianSettingInfo : IMessage
{
	public AccountGuardianTimeLimitSetting time_limit_setting;

	public AccountGuardianTextChatSetting text_chat_setting;

	public AccountGuardianVoiceChatSetting voice_chat_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
