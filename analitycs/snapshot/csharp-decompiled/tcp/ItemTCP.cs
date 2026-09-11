using ProtoBuf;

namespace tcp;

public class ItemTCP : IMessage
{
	public uint id;

	public uint cnt;

	public uint expire_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
