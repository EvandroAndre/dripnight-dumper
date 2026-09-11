using ProtoBuf;

namespace tcp;

public class GroupDismissNtf : IMessage
{
	public ulong leaver_id;

	public ulong group_id;

	public EGroup.LeaveReason reason;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
