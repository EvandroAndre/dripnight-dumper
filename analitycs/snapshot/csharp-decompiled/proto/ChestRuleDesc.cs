using ProtoBuf;

namespace proto;

public class ChestRuleDesc : IMessage
{
	public uint chest_id;

	public uint chest_sub_id;

	public string language;

	public string chest_name;

	public string chest_rule;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
