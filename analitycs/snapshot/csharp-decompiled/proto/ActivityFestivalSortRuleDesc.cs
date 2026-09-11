using ProtoBuf;

namespace proto;

public class ActivityFestivalSortRuleDesc : IMessage
{
	public uint table_type_id;

	public uint weight;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
