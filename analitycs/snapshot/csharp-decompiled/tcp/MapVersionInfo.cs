using ProtoBuf;

namespace tcp;

public class MapVersionInfo : IMessage
{
	public uint map_id;

	public uint map_version;

	public bool resource_released;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
