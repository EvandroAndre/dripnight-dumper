using ProtoBuf;

namespace proto;

public class WebLimitDesc : IMessage
{
	public string host;

	public uint limit_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
