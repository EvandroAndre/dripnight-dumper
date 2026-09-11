using ProtoBuf;

namespace proto;

public class WeaponSkinCustom : IMessage
{
	public uint weapon_id;

	public uint unique_id;

	public uint skin_id;

	public uint power_id;

	public uint skill_id;

	public bool is_selected;

	public uint[] random_skin_ids;

	public bool hasCustomed;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
