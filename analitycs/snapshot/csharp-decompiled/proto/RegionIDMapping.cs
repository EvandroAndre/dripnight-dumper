using ProtoBuf;

namespace proto;

public class RegionIDMapping : IMessage
{
	public uint id;

	public string region;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
