using ProtoBuf;

namespace proto;

public class AndroidApplicationToDetectDesc : IMessage
{
	public uint id;

	public string bundle_identifier;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
