using System;
using proto;

namespace COW;

public class WeaponSkinBaseInfo : CollectionBaseInfo, IComparable<WeaponSkinBaseInfo>
{
	public WeaponSkinData weapon_skin_data;

	public uint weapon_id;

	public uint custom_unique_id;

	public WeaponSkinBaseInfo()
	{
	}

	public WeaponSkinBaseInfo(uint itemid)
	{
	}

	public static implicit operator WeaponSkinBaseInfo(Item it)
	{
		return null;
	}

	public static implicit operator WeaponSkinBaseInfo(WeaponSkinData data)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public int CompareTo(WeaponSkinBaseInfo other)
	{
		return 0;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
