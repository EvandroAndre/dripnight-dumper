using ProtoBuf;

namespace proto;

public class WorkshopAccountSummaryInfo : IMessage
{
	public ulong account_id;

	public uint exp;

	public uint creator_level;

	public CreatorPrivilegeSwitches privilege_switches;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
