using ProtoBuf;

namespace proto;

public class BuddySkillSettingDesc : IMessage
{
	public string region;

	public bool is_open;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
