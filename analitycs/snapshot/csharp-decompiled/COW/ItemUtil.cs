using System.Collections.Generic;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public static class ItemUtil
{
	public enum ItemShareType
	{
		None
	}

	public enum ItemQualityType
	{
		Grey = 1,
		Green = 2,
		Blue = 3,
		Purple = 4,
		Orange = 5,
		Red = 7,
		PurplePlus = 8,
		OrangePlus = 9
	}

	public const int INVALID = 0;

	public const uint UNLIMITED = uint.MaxValue;

	public const string GOLDRES = "Icon_Signin_Gold";

	public const string GOLDBIGRES = "Icon_Signin_Gold_big";

	public const string DIAMOND_RES = "Icon_Signin_Diamond";

	public const string DIAMOND_BIGRES = "Icon_Signin_Diamond_big";

	public const string SPECIAL_RES = "Icon_Signin_CBelite";

	public const string SPECIAL_BIGRES = "Icon_Signin_CBelite_big";

	public const string EXP_RES = "Icon_Exp";

	public const string EXP_BIGRES = "Icon_Exp_big";

	public const string GOLD_NAME = "TXT_CURRENCY_GOLD_TITLE";

	public const string DIAMOND_NAME = "TXT_CURRENCY_DIAMOND_TITLE";

	public const string SPECIAL_NAME = "TXT_ANNOUCEMENT_REWARD_SPECIAL";

	public const string EXP_NAME = "TXT_EXP_TITLE";

	public const string DIAMOND_DESC = "TXT_OB7_GXQ_CURRENCY_DIAMOND_DESC";

	public const string GOLD_DESC = "TXT_OB7_GXQ_CURRENCY_GOLD_DESC";

	public const string EXP_DESC = "TXT_OB7_GXQ_EXP_DESC";

	public const string BP_EMOTE_RES = "UI_BP_New_Icon01";

	public const string BP_EMOTE_NAME = "T_43_C_BP_EMOTE";

	public const string BP_EMOTE_DESC = "T_43_C_BP_EMOTE_TEXT";

	public const string BP_REPURCHASE_RES = "UI_BP_New_Icon02";

	public const string BP_REPURCHASE_NAME = "T_43_C_BP_REPURCHASE";

	public const string BP_REPURCHASE_DESC = "T_43_C_BP_REPURCHASE_TEXT";

	public const string BP_KILL_RES = "UI_BP_New_Icon03";

	public const string BP_KILL_NAME = "T_43_C_BP_ELIMINATION";

	public const string BP_KILL_DESC = "T_37_FH_BP_PREMIUM_RULE2";

	public const string BP_COLLECTION_NAME = "T_43_C_BP_BADGE";

	public const string BP_COLLECTION_DESC = "T_37_FH_BP_PREMIUM_RULE1";

	public const int SIGHT_HOLOGRAPHIC_ID = 533;

	public const int SIGHT_RED_DOT_ID = 532;

	public const int SIGHT_2_ID = 534;

	public const int SIGHT_4_ID = 535;

	public const int SIGHT_8_ID = 536;

	public static void SetQuantityString(UILabel m_Label, BaseItemInfo data, bool ShowExpireDayOnly = false, bool IsShowExpireTime = true, bool isCheckBundleTimeExternal = false)
	{
	}

	public static void SetQuantityString(UILabel time, UILabel num, BaseItemInfo data, bool ignoreOne = true, bool forceShowtime = false)
	{
	}

	public static void SetQuantityLimitString(UILabel time, BaseItemInfo data, bool isCheckBundleTimeExternal = false)
	{
	}

	public static string GetLimitStringByTime(uint deltaTime)
	{
		return null;
	}

	public static string GetExpireTimeString(uint expireTime, bool showExpireDayOnly = true, bool needAddOneDay = false)
	{
		return null;
	}

	public static string GetItemAvalibleTime(uint expireTime)
	{
		return null;
	}

	public static List<BaseItemInfo> GetBaseItemInfoListByTcpAward(AwardDataTCP award)
	{
		return null;
	}

	public static bool CheckHasAward(AwardData a)
	{
		return false;
	}

	public static List<BaseItemInfo> GetBaseItemInfoListByAward(AwardData a)
	{
		return null;
	}

	public static List<BooyahPassBaseItemData> MergeSameItemInfo(List<BooyahPassBaseItemData> list)
	{
		return null;
	}

	public static List<BaseItemInfo> MergeSameItemInfo(List<BaseItemInfo> list)
	{
		return null;
	}

	public static bool IsBigAwardshow(uint itemid, bool isBundleItem = false)
	{
		return false;
	}

	public static bool IsCommonFeatureShowItem(uint itemid)
	{
		return false;
	}

	public static List<AwardDesc> MergeSameItemInfo(List<AwardDesc> list)
	{
		return null;
	}

	public static List<CommonRewardItemInfo> MergeOptionalBundle(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	public static void SetItemDataForRewardList(List<CommonRewardItemInfo> list)
	{
	}

	public static List<CommonRewardItemInfo> MergeSameItemInfo(List<CommonRewardItemInfo> list, bool needMergeWeaponSkin = false)
	{
		return null;
	}

	private static void MergeSameSourceItemNew(Dictionary<ulong, CommonRewardItemInfo> mergeInfoIDIdToRewardInfo, CommonRewardItemInfo item)
	{
	}

	public static ulong GetOptionalTaskExchangePrizeItemID(AwardDesc award, uint rowID)
	{
		return 0uL;
	}

	public static ulong ProcessOptionalTaskExchangePrizeItemID(uint itemID, uint rowID)
	{
		return 0uL;
	}

	public static void ProcessCommonRewardItemID(CommonRewardItemInfo info)
	{
	}

	public static string GetLabelColor(int type)
	{
		return null;
	}

	public static Color GetColorByQuality(int q)
	{
		return default(Color);
	}

	public static bool IsSightingTelescope(int itemID)
	{
		return false;
	}

	public static string SightScopeDisplayName(int itemID)
	{
		return null;
	}

	public static bool IsStackItem(BaseItemInfo data)
	{
		return false;
	}

	public static bool IsOnlyShowNumItem(uint itemID)
	{
		return false;
	}

	public static bool IsShowNumAndHideTimeItem(uint itemID)
	{
		return false;
	}

	public static bool IsShowItemEndTimeWithDesc(byte itemSubType)
	{
		return false;
	}

	public static BaseItemInfo GetDiffInfoByType(ESpecialItemWithoutDataType type, uint count)
	{
		return null;
	}

	public static bool CheckShowCdnBySpecialType(ESpecialItemWithoutDataType type)
	{
		return false;
	}

	public static Color GetInGameShopItemRareColor(uint rare)
	{
		return default(Color);
	}

	public static string GetRareTypeLabelColor(proto.EInventory.RareType rare)
	{
		return null;
	}

	public static List<CommonRewardItemInfo> GetItemListFromExchangeAwardData(ExchangeChangeData exchangeChangeData, out AutoOpenBoxBundleData autoOpenBoxBundleData, out string transferHint, bool protectBPCards = false)
	{
		autoOpenBoxBundleData = null;
		transferHint = null;
		return null;
	}

	public static List<CommonRewardItemInfo> GetItemListFromExchangeAwardData(List<ExchangedAward> exchangeAwardList, AwardData awardData, out AutoOpenBoxBundleData autoOpenBoxBundleData, out string transferHint)
	{
		autoOpenBoxBundleData = null;
		transferHint = null;
		return null;
	}

	private static void GetResFromExchangeAwardData(List<ExchangedAward> exchangeAwardList, AutoOpenBoxBundleData autoOpenBoxBundleData, List<CommonRewardItemInfo> originAwardList, List<CommonRewardItemInfo> fromBoxAwardList, List<CommonRewardItemInfo> fromBundleAwardList, Dictionary<uint, int> dicReturnIDToReturnNum, out int bundleBoxCoinNum, out int bundleBoxGemNum)
	{
		bundleBoxCoinNum = default(int);
		bundleBoxGemNum = default(int);
	}

	public static List<CommonRewardItemInfo> FilterRwardList(List<CommonRewardItemInfo> originRewardList, List<Item> delAwardsList, bool protectBPCards = false)
	{
		return null;
	}

	public static List<CommonRewardItemInfo> CommonRewardItemInfosDeepCopy(List<CommonRewardItemInfo> commonRewardItemInfoList)
	{
		return null;
	}
}
