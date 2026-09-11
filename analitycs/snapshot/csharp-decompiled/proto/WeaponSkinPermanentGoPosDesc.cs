using ProtoBuf;

namespace proto;

public class WeaponSkinPermanentGoPosDesc : IMessage
{
	public uint weapon_skin_id;

	public uint go_pos;

	public string sub_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
