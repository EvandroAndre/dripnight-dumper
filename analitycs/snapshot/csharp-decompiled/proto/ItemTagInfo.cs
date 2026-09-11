using ProtoBuf;
using tcp;

namespace proto;

public class ItemTagInfo : IMessage
{
	public uint item_id;

	public uint series_id;

	public uint num_id;

	public void ParseFrom(ProtoReader reader)
	{
	}

	public static implicit operator ItemTagInfo(global::tcp.ItemTagInfo tcp)
	{
		return null;
	}
}
