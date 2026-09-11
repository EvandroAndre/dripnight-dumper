using ProtoBuf;

namespace proto;

public class GoogleRewardsDesc : IMessage
{
	public uint id;

	public string region;

	public uint is_paid;

	public uint is_ep_unlock;

	public uint action_type;

	public string task_desc;

	public string reward_desc;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
