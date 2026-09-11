using ProtoBuf;

namespace proto;

public class PrimeEventDesc : IMessage
{
	public uint event_id;

	public string event_start_time;

	public string event_end_time;

	public uint event_rate;

	public uint max_event_gems;

	public long event_start_timestamp;

	public long event_end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
