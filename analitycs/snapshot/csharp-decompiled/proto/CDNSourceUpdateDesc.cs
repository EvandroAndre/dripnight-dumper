using ProtoBuf;

namespace proto;

public class CDNSourceUpdateDesc : IMessage
{
	public uint id;

	public string url;

	public uint version_index;

	public uint type;

	public string version;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
