using ProtoBuf;

namespace tcp;

public class WorkshopVipInfo : IMessage
{
	public long start_time;

	public long end_time;

	public uint vip_type;

	public uint subscribe_type;

	public long try_renew_at;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
