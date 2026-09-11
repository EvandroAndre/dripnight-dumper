using ProtoBuf;

namespace proto;

public class LikeItem : IMessage
{
	public EInventory.LikeItemType like_item_type;

	public uint cnt;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
