using ProtoBuf;

namespace proto;

public class AvatarProficiencyRewardDesc : IMessage
{
	public uint avatar_id;

	public uint reward_level;

	public AwardDesc reward;

	public bool is_new;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
