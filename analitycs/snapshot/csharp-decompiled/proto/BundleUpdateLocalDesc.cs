using ProtoBuf;

namespace proto;

public class BundleUpdateLocalDesc : IMessage
{
	public uint id;

	public uint award_unique_id;

	public EInventory.AwardType return_type;

	public uint return_id;

	public uint return_num;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
