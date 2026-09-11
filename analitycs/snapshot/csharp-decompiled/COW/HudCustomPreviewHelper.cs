using System.Collections.Generic;

namespace COW;

public class HudCustomPreviewHelper
{
	public static string ChangeWeaponName;

	public static string ReloadName;

	public static string AuxAimName;

	public static string GrenadeChangeName;

	public static bool NeedShow(CustomHudItem hudItem)
	{
		return false;
	}

	public static string GetPresetKey(int index)
	{
		return null;
	}

	public static void ModifyHudByGameMode(List<CustomHudItem> customHudList)
	{
	}
}
