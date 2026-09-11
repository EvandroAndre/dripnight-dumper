using COW.GamePlay;

namespace COW;

public static class UIHudLobbySocialPrivilegeUtil
{
	internal static bool TryGetLobbySocialPropType(NAELPAAELNO item, out LobbySocialPropType propType)
	{
		propType = default(LobbySocialPropType);
		return false;
	}

	internal static bool IsLobbySocialPrivilegeItem(NAELPAAELNO item)
	{
		return false;
	}

	internal static void TryRecord9AnniversaryPrivilegeItemUse(NAELPAAELNO item)
	{
	}

	internal static void TryExitGrenadeAndFireworkPrivilegeReleaseStateAfterUse(NAELPAAELNO item)
	{
	}

	internal static bool IsLobbySocialGrenadeOrFireworkPrivilegeItem(NAELPAAELNO item)
	{
		return false;
	}

	internal static bool IsLobbySocialDeformPrivilege(LobbySocialPropType slotType)
	{
		return false;
	}

	internal static bool ShouldHideLobbySocialPrivilegeCount(LobbySocialPropType slotType)
	{
		return false;
	}

	internal static bool TryGetLobbySocialPropType(HENEHAGJCLI itemData, out LobbySocialPropType propType)
	{
		propType = default(LobbySocialPropType);
		return false;
	}

	internal static bool TryGetLobbySocialPropType(GMECHKEDOJP grenadeData, out LobbySocialPropType propType)
	{
		propType = default(LobbySocialPropType);
		return false;
	}

	public static bool TryGetLobbySocialFireHudSpriteName(LobbySocialPropType type, out string spriteName)
	{
		spriteName = null;
		return false;
	}

	public static string GetHudIconSpriteNameForSlot(LobbySocialPropType slot)
	{
		return null;
	}
}
