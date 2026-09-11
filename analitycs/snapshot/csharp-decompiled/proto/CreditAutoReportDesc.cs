using ProtoBuf;

namespace proto;

public class CreditAutoReportDesc : IMessage
{
	public uint behavior_rule_id;

	public uint report_type;

	public uint sort_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
