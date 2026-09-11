using System;
using System.Collections.Generic;
using UMA.Simple;

namespace UMA;

public static class UmaSimpleUtils
{
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public Func<string, int> strToIdx;

		public int ret;

		internal void _003CStringToBits_003Eb__0(string s)
		{
		}
	}

	public static Dictionary<string, int> RaceNameToEnums;

	public static Dictionary<string, int> BaseSlotNameToEnums;

	public static Dictionary<string, int> WardrobeSlotNameToEnums;

	public static void LogErrorNonLive(string msg)
	{
	}

	public static int StringToBits(List<string> ss, Func<string, int> strToIdx)
	{
		return 0;
	}

	private static int StringToBitsMasked(List<string> ss, Func<string, int> strToIdx, int invalidBits = 1)
	{
		return 0;
	}

	private static Dictionary<string, int> InitNameToEnumMap(string[] ss)
	{
		return null;
	}

	private static int GetEnumByName(Dictionary<string, int> dic, string s, int @default = 0)
	{
		return 0;
	}

	public static string GetRaceName(ERace e)
	{
		return null;
	}

	public static bool IsFemale(ERace e)
	{
		return false;
	}

	public static EBaseSlot GetBaseSlot(string s)
	{
		return EBaseSlot.None;
	}

	public static string GetWardrobeSlotName(EWardrobeSlot e)
	{
		return null;
	}

	public static EWardrobeSlot GetWardrobeSlot(string s)
	{
		return EWardrobeSlot.None;
	}

	public static string GetWardrobeSlotName(EAdditiveTargetSlot e)
	{
		return null;
	}

	public static EWardrobeSlot GetTargetWardrobeSlot(EAdditiveTargetSlot e)
	{
		return EWardrobeSlot.None;
	}

	public static int GetTargetBaseSlots(EAdditiveTargetSlot e)
	{
		return 0;
	}

	public static bool IsPotensialAdditiveSlot(string slotName)
	{
		return false;
	}

	public static bool IsPotensialAdditiveSrcSlot(string wardrobeSlot)
	{
		return false;
	}

	public static bool GetRecipe(int recipe, out UMATextRecipe textRecipe, out UmaRecipeSimple simpleRecipe)
	{
		textRecipe = null;
		simpleRecipe = default(UmaRecipeSimple);
		return false;
	}

	public static bool IsConflict(int selectRecipe, int targetRecipe, bool considerHidingTarget)
	{
		return false;
	}

	public static bool IsHidenByTarget(UmaRecipeSimple srcRecipe, UmaRecipeSimple targetRecipe)
	{
		return false;
	}

	public static bool IsHidenByTarget(UMATextRecipe srcRecipe, UMATextRecipe targetRecipe)
	{
		return false;
	}

	public static bool HasSuppress(int recipe, EWardrobeSlot slot)
	{
		return false;
	}

	public static bool HasSuppress(UmaRecipeSimple recipe, EWardrobeSlot slot)
	{
		return false;
	}

	public static bool HasSuppress(UMATextRecipe recipe, EWardrobeSlot slot)
	{
		return false;
	}

	public static void MergeAdditiveSlot(SlotData dst, OverlayData srcOverlay, AdditiveInfo srcInfo)
	{
	}

	public static void SortReplaceSlotsInNeed(List<KeyValuePair<SlotData, AdditiveInfo>> additiveSlots)
	{
	}

	public static bool NoClothTextureMerge(List<OverlayData> overlayList)
	{
		return false;
	}

	public static bool NoSkinTextureMerge(List<OverlayData> overlayList)
	{
		return false;
	}

	private static bool ShouldMergeTexAndMeshIgnoreColorMask(UMAData umaData, SlotData slotData)
	{
		return false;
	}

	public static bool ShouldUseRt(UMAData umaData, SlotData slotData, UMAMaterial.ChannelType channelType)
	{
		return false;
	}

	public static bool ShouldMergeTexAndMesh(UMAData umaData, SlotData slotData)
	{
		return false;
	}
}
