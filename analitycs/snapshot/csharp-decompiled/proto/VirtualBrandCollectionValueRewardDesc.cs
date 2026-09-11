using ProtoBuf;

namespace proto;

public class VirtualBrandCollectionValueRewardDesc : IMessage
{
	public uint brand_id;

	public uint unlock_condition_id;

	public uint unlock_condition;

	public uint award_id;

	public uint award_num;

	public EInventory.AwardType award_type;

	public uint expire_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
