using ProtoBuf;

namespace proto;

public class ChestLayoutDesc : IMessage
{
	public uint layout_id;

	public float layout_posx;

	public float layout_posy;

	public uint layout_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
