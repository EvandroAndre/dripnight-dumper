using ProtoBuf;

namespace proto;

public class RoleDebrisPurchaseDesc : IMessage
{
	public uint debris_id;

	public uint purchase_count;

	public uint gold_price;

	public uint diamond_price;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
