using ProtoBuf;

namespace proto;

public class StoreTableDesc : IMessage
{
	public uint table_type;

	public string language;

	public string table_name;

	public uint mall_type;

	public uint sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
