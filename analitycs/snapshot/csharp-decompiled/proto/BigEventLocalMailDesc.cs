using ProtoBuf;

namespace proto;

public class BigEventLocalMailDesc : IMessage
{
	public ELimitedEvent.EventID event_id;

	public uint mail_id;

	public long start_time;

	public long end_time;

	public string title;

	public string content;

	public uint cdnid;

	public string icon_cdn;

	public uint go_pos;

	public string sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
