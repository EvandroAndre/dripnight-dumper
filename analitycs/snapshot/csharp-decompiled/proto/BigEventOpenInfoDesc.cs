using ProtoBuf;

namespace proto;

public class BigEventOpenInfoDesc : IMessage
{
	public ELimitedEvent.EventID event_id;

	public ELimitedEvent.EventState event_state;

	public string start_time;

	public string end_time;

	public uint start_timestamp;

	public uint end_timestamp;

	public bool is_resend;

	public string resend_end_time;

	public uint resend_end_timestamp;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
