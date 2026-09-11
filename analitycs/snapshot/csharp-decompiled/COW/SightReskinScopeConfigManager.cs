using COW.GamePlay;
using GCommon;

namespace COW;

public static class SightReskinScopeConfigManager
{
	private static CSVAsyncDataMap<uint, WeaponScopeSkinData> s_configMap;

	public static void ClearCache()
	{
	}

	public static uint[] GetAvailableScopeIds(uint weaponSkinId)
	{
		return null;
	}

	public static bool HasAnyScopeReskin(uint weaponSkinId)
	{
		return false;
	}

	private static bool HasAnyScopeReskin(WeaponScopeSkinData config)
	{
		return false;
	}

	public static bool HasUnlockedScopeReskin(uint curWeaponSkinId, uint prevWeaponSkinId)
	{
		return false;
	}

	private static bool HasUnlockedScopeReskin(WeaponScopeSkinData curConfig, WeaponScopeSkinData prevConfig)
	{
		return false;
	}

	private static bool IsNewlyUnlocked(ResourceID cur, ResourceID prev)
	{
		return false;
	}

	public static ResourceID GetPreviewRes(uint weaponSkinId, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	internal static ResourceID GetReskinRes(uint weaponSkinId, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}

	public static ResourceID GetOpeningVFXRes(uint weaponSkinId, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	internal static ResourceID GetOpeningVFXRes(uint weaponSkinId, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}

	public static ResourceID GetSightVFXRes(uint weaponSkinId, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	internal static ResourceID GetSightVFXRes(uint weaponSkinId, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}

	public static WeaponScopeSkinData FindConfig(uint weaponSkinId)
	{
		return null;
	}

	private static ResourceID GetReskinResourceForScope(WeaponScopeSkinData config, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	private static ResourceID GetOpeningVFXResourceForScope(WeaponScopeSkinData config, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	private static ResourceID GetSightVFXResourceForScope(WeaponScopeSkinData config, uint scopeAttachmentId)
	{
		return default(ResourceID);
	}

	private static ResourceID GetReskinResourceForScope(WeaponScopeSkinData config, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}

	private static ResourceID GetOpeningVFXResourceForScope(WeaponScopeSkinData config, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}

	private static ResourceID GetSightVFXResourceForScope(WeaponScopeSkinData config, EJNFNOJNCPE attachData, bool forceThermal = false)
	{
		return default(ResourceID);
	}
}
