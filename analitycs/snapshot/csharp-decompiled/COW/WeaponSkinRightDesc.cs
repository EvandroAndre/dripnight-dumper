using message;

namespace COW;

public class WeaponSkinRightDesc
{
	private readonly uint m_WeaponPropertySkinID;

	private readonly uint m_WeaponBuffSkinID;

	private readonly WeaponSkinRightStatus[] m_WeaponSkinRightStatusArray;

	public uint WeaponPropertySkinID => 0u;

	public uint WeaponBuffSkinID => 0u;

	internal WeaponSkinRightDesc(JBEENOBHMGC weaponSkinStat)
	{
	}

	public WeaponSkinFireSoundType GetWeaponSkinFireSoundStatus()
	{
		return WeaponSkinFireSoundType.NormalSound;
	}

	public WeaponSkinFireSoundType GetWeaponSkinABStatus()
	{
		return WeaponSkinFireSoundType.NormalSound;
	}

	public bool IsSightReskinEnabled()
	{
		return false;
	}
}
