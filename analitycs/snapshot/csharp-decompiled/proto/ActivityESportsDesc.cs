using ProtoBuf;

namespace proto;

public class ActivityESportsDesc : IMessage
{
	public string esports_url;

	public bool is_open;

	public uint cache_time;

	public string api_token;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
