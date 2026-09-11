using ProtoBuf;

namespace proto;

public class CSGetHippoInventoryBaseDescRes : IMessage
{
	public uint default_bag_capacity;

	public uint default_safebox_capacity;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
