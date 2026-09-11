using ProtoBuf;

namespace proto;

public class CustomEventCDNDesc : IMessage
{
	public uint cdn_id;

	public string language;

	public string cdn_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
