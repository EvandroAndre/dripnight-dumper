using ProtoBuf;

namespace proto;

public class AwardDesc : IMessage
{
	public EInventory.AwardType award_type;

	public uint award_id;

	public uint award_num;

	public uint award_max_num;

	public uint award_expire_time;

	public uint award_level;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public AwardDesc Clone()
	{
		return null;
	}
}
