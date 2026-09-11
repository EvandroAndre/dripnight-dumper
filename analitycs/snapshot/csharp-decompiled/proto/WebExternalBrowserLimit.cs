using ProtoBuf;

namespace proto;

public class WebExternalBrowserLimit : IMessage
{
	public string host;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
