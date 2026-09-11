using ProtoBuf;

namespace proto;

public class CupSettingDesc : IMessage
{
	public uint cup_type;

	public uint cup_id;

	public uint game_mode;

	public string cup_name;

	public string mode_name;

	public bool disable_weapon_skin;

	public bool is_new;

	public bool tier_inherit;

	public uint[] ticket_item_id;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
