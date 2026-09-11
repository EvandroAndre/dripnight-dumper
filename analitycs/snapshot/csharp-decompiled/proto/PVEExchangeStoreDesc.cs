using ProtoBuf;

namespace proto;

public class PVEExchangeStoreDesc : IMessage
{
	public uint store_id;

	public uint commodity_id;

	public uint store_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
