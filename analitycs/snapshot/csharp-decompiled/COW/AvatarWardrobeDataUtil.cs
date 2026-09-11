using System.Collections.Generic;

namespace COW;

public static class AvatarWardrobeDataUtil
{
	private static Dictionary<int, string> m_SlotNameDic;

	public static AvatarWardrobeData GetWardrobeData(uint id)
	{
		return null;
	}

	public static string GetSlot(AvatarWardrobeData wData)
	{
		return null;
	}

	public static string GetSlot(UIModelAvatarBase.EWardrobeType t)
	{
		return null;
	}

	public static string GetConflictSlot(string selectSlot, Dictionary<string, AvatarWardrobeData> slots, bool isFemale, uint avatarId)
	{
		return null;
	}

	public static void RemoveConflictSlot(AvatarWardrobeData wData, List<uint> cs, bool isFemale, uint avatarId, bool considerHidingTarget)
	{
	}

	private static string GetPotentialConflictSlot(string slot)
	{
		return null;
	}

	public static bool IsConflict(AvatarWardrobeData selectData, AvatarWardrobeData targetData, bool considerHidingTarget, bool isFemale, uint avatarId)
	{
		return false;
	}

	public static bool CheckCanEquipHair(AvatarWardrobeData data)
	{
		return false;
	}

	public static bool CheckCanEquipFace(AvatarWardrobeData data)
	{
		return false;
	}

	public static bool DoesLegendClothHaveTip(int legendType)
	{
		return false;
	}

	public static void SetLegendClothTipCount(int legendType, bool haveNew)
	{
	}
}
