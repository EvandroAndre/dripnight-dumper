using ProtoBuf;

namespace proto;

public class EsportsWebLinkDesc : IMessage
{
	public uint id;

	public string web_link;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
