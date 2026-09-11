using ProtoBuf;

namespace proto;

public class WeaponPowerSettingDesc : IMessage
{
	public uint weapon_num_limit;

	public uint active_increase_param;

	public uint weapon_exp_inherit_limit;

	public uint weapon_unlock_num;

	public uint br_weapon_power_inherit_limit;

	public uint cs_weapon_power_inherit_limit;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
