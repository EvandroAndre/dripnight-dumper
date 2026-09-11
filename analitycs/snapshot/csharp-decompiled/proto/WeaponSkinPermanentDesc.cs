using ProtoBuf;

namespace proto;

public class WeaponSkinPermanentDesc : IMessage
{
	public uint weapon_skin_id;

	public string name;

	public bool has_permanent_value;

	public uint conversion_rate;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
