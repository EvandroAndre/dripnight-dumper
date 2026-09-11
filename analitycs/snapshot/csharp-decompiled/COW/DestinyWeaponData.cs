using System.Collections.Generic;
using proto;

namespace COW;

public class DestinyWeaponData
{
	public uint weaponId;

	public uint weaponCollectionId;

	public uint weaponType;

	public uint tilteId;

	public string region;

	public uint rank;

	public List<ERanking.SeasonReplayWeaponTag> weaponTags;

	public uint totalDamage;

	public uint totalkills;

	public bool isDefault;

	public uint useTimes;
}
