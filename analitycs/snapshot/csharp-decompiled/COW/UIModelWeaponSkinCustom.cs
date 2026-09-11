using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelWeaponSkinCustom : UIBaseModel
{
	private Dictionary<uint, List<uint>> m_WeaponIdToCustomKeys;

	private Dictionary<uint, WeaponSkinCustom> m_WeaponSkinCustomDic;

	private const uint m_CustomWeaponCount = 1u;

	public const string WEAPON_SKIN_CUSTOM_GUIDE = "WEAPON_SKIN_CUSTOM_GUIDE";

	public const string SAVE_TIMELIMIT_CUSTOM_SKIN = "SAVE_TIME_LIMIT_CUSTOM_SKIN";

	public bool RequestData;

	public override uint GetModelType()
	{
		return 0u;
	}

	public uint GetCustomKey(uint weaponId, uint uniqueId)
	{
		return 0u;
	}

	public uint GetEquipCustomWeaponUniqueId(uint weaponId)
	{
		return 0u;
	}

	public bool IsWeaponHaveCustomSkin(uint weaponId)
	{
		return false;
	}

	public bool hasCustomSkinExpired()
	{
		return false;
	}

	public bool IsCustomSkinTimeLimit(uint weaponId, uint uniqueId)
	{
		return false;
	}

	public Item GetCustomLimitItem(uint weaponId, uint uniqueId)
	{
		return null;
	}

	public void RefreshWeaponSkinCustomData(List<WeaponSkinCustom> weaponList)
	{
	}

	public uint GetCustomWeaponCountLimit()
	{
		return 0u;
	}

	public WeaponSkinCustom GetWeaponSkinCustomByWeaponIdAndUniqueId(uint weaponId, uint uniqueId)
	{
		return null;
	}

	public List<WeaponSkinCustom> GetWeaponSkinCustomsByWeaponId(uint weaponId)
	{
		return null;
	}

	public void SaveEmptyWeaponSkinCustom(WeaponSkinCustom weapon)
	{
	}

	public Dictionary<uint, List<uint>> GetWeaponIdToCustomKeysDic()
	{
		return null;
	}

	public override void Logout(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
