using ProtoBuf;

namespace proto;

public class WeaponPowerSwitchDesc : IMessage
{
	public uint id;

	public uint match_mode;

	public uint id_weapon_skin;

	public uint type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
