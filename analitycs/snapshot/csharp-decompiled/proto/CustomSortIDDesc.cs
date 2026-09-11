using ProtoBuf;

namespace proto;

public class CustomSortIDDesc : IMessage
{
	public uint sort_id;

	public uint sort_type;

	public string resource_name;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
