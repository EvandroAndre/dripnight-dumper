using message;
using proto;

namespace COW;

public class WeaponSkinRightStatus
{
	private readonly uint m_Type;

	private readonly uint m_Value;

	public WeaponSkinRightStatus(PUint32KeyVal keyValuePair)
	{
	}

	internal WeaponSkinRightStatus(OCKKBFNNIAO keyValuePair)
	{
	}

	public JLGHEEOJFOP GetRightType()
	{
		return JLGHEEOJFOP.None;
	}

	public WeaponSkinFireSoundType GetFireSoundStatus()
	{
		return WeaponSkinFireSoundType.NormalSound;
	}

	public bool SightReskinEnabled()
	{
		return false;
	}
}
