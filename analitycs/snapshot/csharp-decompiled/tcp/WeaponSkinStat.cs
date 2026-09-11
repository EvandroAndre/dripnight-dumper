using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class WeaponSkinStat : IMessage
{
	public uint weapon_skin_id;

	public uint weapon_power_skin_id;

	public uint weapon_skill_skin_id;

	public List<PUint32KeyVal> rights;

	public List<PUint32KeyVal> counters;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
