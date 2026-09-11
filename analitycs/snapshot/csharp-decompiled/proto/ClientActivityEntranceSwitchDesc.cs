using ProtoBuf;

namespace proto;

public class ClientActivityEntranceSwitchDesc : IMessage
{
	public uint id;

	public long show_time;

	public long start_time_stamp;

	public long end_time_stamp;

	public string go_url;

	public uint go_pos;

	public string cdn_url;

	public string tip_cdn_url;

	public string start_time;

	public string end_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
