using ProtoBuf;

namespace proto;

public class PrimeCDNDesc : IMessage
{
	public uint privilege_id;

	public string language;

	public string advertisement_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
