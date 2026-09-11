using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public static class PreviewUtil
{
	private static readonly Color32 GREEN;

	private static readonly Color32 YELLOW;

	private static readonly Color32 RED;

	public static EInventory.AwardType GetBaseItemInfoAwardType(BaseItemInfo info)
	{
		return EInventory.AwardType.AwardType_NONE;
	}

	public static bool IsAvatarCantWearHeadAdditive(uint avatarId, AvatarWardrobeData clothes, bool canEquipDefault = true)
	{
		return false;
	}

	public static Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2)
	{
		return default(Vector3);
	}

	public static bool IsItemABReady(uint item_id)
	{
		return false;
	}

	public static bool IsItemABReady(CSSharedItemData item_data)
	{
		return false;
	}

	public static bool IsTriggerEffectAnimABReady(ClothTriggerEffectPreviewData data)
	{
		return false;
	}

	public static void FindTriggerEffectAnimNeedDownloadRes(ClothTriggerEffectPreviewData data, List<ResourceID> resList)
	{
	}

	public static List<CSSharedItemData> TransformBundle2ItemList(CSSharedItemData item_data)
	{
		return null;
	}

	public static void FindItemNeedDownloadRes(uint itemId, ref List<ResourceID> need_download_res_list)
	{
	}

	public static void FindItemNeedDownloadRes(CSSharedItemData item_data, ref List<ResourceID> need_download_res_list)
	{
	}

	public static List<uint> GetAvatarClothList()
	{
		return null;
	}

	public static Vector3 TransStringToVector3(string str)
	{
		return default(Vector3);
	}

	public static Color32 GetSkillBgColor(char type)
	{
		return default(Color32);
	}

	public static uint GetBundleNoAvatarShowId(uint bundleID)
	{
		return 0u;
	}

	public static bool IsSpecialPreviewBundle(uint itemID, bool checkOwned = false)
	{
		return false;
	}

	public static bool IsSpecialPreviewBundle(List<BundleShowData> bundleList, bool checkOwned = false)
	{
		return false;
	}

	public static uint GetPreviewAvatarId(uint clothesID)
	{
		return 0u;
	}

	private static uint GetPreviewAvatarId(AvatarWardrobeData wData, uint bundleShowFemale, uint bundleShowMale)
	{
		return 0u;
	}

	private static uint GetPreviewAvatarId(uint bundleShowFemale, uint bundleShowMale)
	{
		return 0u;
	}

	public static List<uint> GetClothEffectTriggerIDsFromBundle(CSSharedItemData itemData)
	{
		return null;
	}

	public static void GetClothListInBundle(CSSharedItemData itemData, ref List<uint> clothList)
	{
	}

	public static uint GetClothIDWithEffectWithoutAvatarFromBundle(CSSharedItemData itemData, uint curTriggerID)
	{
		return 0u;
	}

	public static List<uint> TransformBundleID2PreviewList(uint bundleid)
	{
		return null;
	}

	public static List<uint> TransformBundleList2PreviewList(List<BaseBundleItemInfo> bundle)
	{
		return null;
	}

	public static UIModelAvatarBase.EClothGenderType GetGenderTypeById(uint id)
	{
		return UIModelAvatarBase.EClothGenderType.GENDERTYPENONE;
	}

	public static UIModelAvatarBase.EClothGenderType GetBundleGenderType(uint id)
	{
		return UIModelAvatarBase.EClothGenderType.GENDERTYPENONE;
	}

	public static UIModelAvatarBase.EClothGenderType GetBundleGenderTypeOnlyClothes(uint id)
	{
		return UIModelAvatarBase.EClothGenderType.GENDERTYPENONE;
	}

	public static void SkipModelAnimation(GameObject model)
	{
	}
}
