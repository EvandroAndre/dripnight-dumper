using ProtoBuf;

namespace proto;

public class ItemIntimacyOverrideDesc : IMessage
{
	public uint item_id;

	public string item_name;

	public uint item_intimacy_value;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
