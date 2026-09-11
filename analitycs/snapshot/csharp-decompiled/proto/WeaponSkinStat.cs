using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class WeaponSkinStat : IMessage
{
	public uint weapon_skin_id;

	public PString weapon_name;

	public PUint32 weapon_power_skin_id;

	public PUint32 weapon_skill_skin_id;

	public List<PUint32KeyVal> rights;

	public List<PUint32KeyVal> counters;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
