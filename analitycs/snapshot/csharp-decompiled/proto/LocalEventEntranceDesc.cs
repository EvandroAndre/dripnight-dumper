using ProtoBuf;

namespace proto;

public class LocalEventEntranceDesc : IMessage
{
	public uint event_id;

	public string event_info;

	public long start_time;

	public long end_time;

	public string event_url;

	public string entry_cdn;

	public uint red_dot_refresh_interval;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
