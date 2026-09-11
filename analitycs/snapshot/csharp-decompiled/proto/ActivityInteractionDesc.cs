using ProtoBuf;

namespace proto;

public class ActivityInteractionDesc : IMessage
{
	public uint activity_id;

	public ulong interaction_id;

	public uint component_type;

	public string component_param1;

	public string component_param2;

	public uint component_posx;

	public uint component_posy;

	public uint height_size;

	public uint width_size;

	public uint interaction_type;

	public string interaction_param1;

	public string interaction_param2;

	public string language;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
