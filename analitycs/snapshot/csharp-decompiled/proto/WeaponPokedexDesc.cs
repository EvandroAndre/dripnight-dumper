using ProtoBuf;

namespace proto;

public class WeaponPokedexDesc : IMessage
{
	public uint weapon_skin_id;

	public string name;

	public uint display_threshold;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
