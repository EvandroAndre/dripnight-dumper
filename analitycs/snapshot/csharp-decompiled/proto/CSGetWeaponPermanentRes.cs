using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetWeaponPermanentRes : IMessage
{
	public List<WeaponSkinPermanentDesc> weapon_skin_permanent;

	public List<WeaponPokedexDesc> weapon_pokedex;

	public List<WeaponSkinPermanentGoPosDesc> weapon_skin_permanent_go_pos;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
