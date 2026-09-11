using ProtoBuf;

namespace tcp;

public class GroupLeaveNtf : IMessage
{
	public ulong leaver_id;

	public EGroup.LeaveReason reason;

	public GroupInfo group_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
