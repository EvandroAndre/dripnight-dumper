using ProtoBuf;

namespace tcp;

public class PVETalentInfo : IMessage
{
	public uint[] talent_ids;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
