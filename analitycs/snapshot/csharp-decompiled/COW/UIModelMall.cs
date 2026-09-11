using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelMall : UIBaseModel
{
	private enum MallItemAnimState
	{
		NO_PLAYED,
		PLAYERD
	}

	public class ClanExchangeData
	{
		public ExchangeStoreItemDesc itemDesc;

		public ClanStoreCommodityConfigDesc commodityConfigDesc;
	}

	private class CompareData
	{
		public uint StoreID;

		public bool HasItemData;

		public bool IsCloth;

		public bool CanEquipCloth;

		public bool IsUniquedAndOwner;

		public bool BundleOwned;

		public bool BoxContainsAllItemOwned;

		public byte RareSort;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ExchangeStore> _003C_003E9__136_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__147_4;

		public static Comparison<ClanExchangeData> _003C_003E9__170_0;

		public static Converter<CommonRewardItemInfo, CommonRewardItemInfo> _003C_003E9__180_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__186_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__187_1;

		public static Predicate<uint> _003C_003E9__258_0;

		public static Converter<uint, string> _003C_003E9__274_0;

		internal int _003CProcessExchangeStore_003Eb__136_0(ExchangeStore a, ExchangeStore b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CShowPurchaseReward_003Eb__147_4(BaseItemInfo item)
		{
			return null;
		}

		internal int _003CHandleClanExchangeStoreConfigList_003Eb__170_0(ClanExchangeData x, ClanExchangeData y)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003COpenTreasureBoxes_003Eb__180_1(CommonRewardItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CPickOptionalBundle_003Eb__186_1(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003COpenBundle_003Eb__187_1(BaseItemInfo item)
		{
			return null;
		}

		internal bool _003CGetSecondExchangeTabList_003Eb__258_0(uint t)
		{
			return false;
		}

		internal string _003COnGetStoreResV2_003Eb__274_0(uint storeID)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public UIModelMall _003C_003E4__this;

		public bool refreshByItemInfoWrong;

		internal void _003CGetStoreRes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIModelMall _003C_003E4__this;

		public DiscountStoreDesc desc;

		public uint count;

		internal void _003CPurchaseDiscountItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public UIModelMall _003C_003E4__this;

		public VeteranStoreDesc desc;

		public uint count;

		internal void _003CPurchaseVeteranDiscountItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public UIModelMall _003C_003E4__this;

		public uint id;

		public WeakReference nextWeakRef;

		internal void _003CRequestTreasureBoxProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public UIModelMall _003C_003E4__this;

		public uint Id;

		public WeakReference nextWeakRef;

		internal void _003CRequestInGameBonusProbability_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIModelMall _003C_003E4__this;

		public bool refreshByItemInfoWrong;

		internal void _003CGetExchangeStoreRes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass144_0
	{
		public StoreDesc storeDesc;

		public uint count;

		public bool isIgnoreShowPurchaseReward;

		public UIModelMall _003C_003E4__this;

		public int targetPlanIndex;

		public uint targetSlot;

		internal void _003CPurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass145_0
	{
		public UIModelMall _003C_003E4__this;

		public ExchangeStoreItemDesc exchangeStoreItem;

		public uint count;

		internal void _003CExchange_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass146_0
	{
		public UIModelClan modelClan;

		public UIModelMall _003C_003E4__this;

		internal void _003CRequestPurchaseClanPrivilege_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass147_0
	{
		public UIModelMall _003C_003E4__this;

		public uint itemId;

		public uint count;

		internal void _003CShowPurchaseReward_003Eb__0()
		{
		}

		internal void _003CShowPurchaseReward_003Eb__1()
		{
		}

		internal void _003CShowPurchaseReward_003Eb__2()
		{
		}

		internal void _003CShowPurchaseReward_003Eb__3()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public BaseItemInfo award;

		internal bool _003CAssembleAwardList_003Eb__0(ItemTagInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass179_0
	{
		public bool showBoxTag;

		public UICommonRewardWndController.WndStyleEnum wndStyle;

		public Action closeAction;

		public UIModelMall _003C_003E4__this;

		public uint item_id;

		public bool isNeedPlayAnimation;

		internal void _003COpenGrate_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass180_0
	{
		public UICommonRewardWndController.WndStyleEnum wndStyle;

		public UIModelMall _003C_003E4__this;

		internal void _003COpenTreasureBoxes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass185_0
	{
		public UIModelMall _003C_003E4__this;

		public uint item_id;

		public OptionalRewardWndCfg cfg;

		internal void _003CShowOptionalBundleView_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public UICommonRewardWndController.WndStyleEnum wndStyle;

		public UIModelMall _003C_003E4__this;

		public uint item_id;

		internal void _003CPickOptionalBundle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UICommonRewardWndController.WndStyleEnum wndStyle;

		public UIModelMall _003C_003E4__this;

		internal void _003COpenBundle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass188_0
	{
		public bool showBundleTag;

		public UICommonRewardWndController.WndStyleEnum wndStyle;

		public Action closeAction;

		public UIModelMall _003C_003E4__this;

		public Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__1;

		internal void _003COpenBundleBatch_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal CommonRewardItemInfo _003COpenBundleBatch_003Eb__1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass226_0
	{
		public UIModelMall _003C_003E4__this;

		public StarterStoreItemDesc desc;

		public uint count;

		public Action closeAction;

		internal void _003CPurchaseStarterStoreItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass227_0
	{
		public UIModelMall _003C_003E4__this;

		public PrimeStoreItemDesc primeItemDesc;

		public uint count;

		internal void _003CBuyPrimeStoreItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private List<StoreDesc> m_StoreItemList;

	private Dictionary<uint, List<ExchangeStoreItemDesc>> m_ExchangeStoreItemIdDict;

	private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreDict;

	private List<ExchangeStoreItemDesc> m_ExchangeStoreItemList;

	private List<ClanStoreCommodityConfigDesc> m_ClanExchangeStoreConfigList;

	private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreBoxDict;

	public Dictionary<uint, CSGetTreasureBoxPRRes> m_TreasureBoxProbabilityDict;

	public Dictionary<uint, CSGetInGameBonusPRRes> m_InGameBonusProbabilityDict;

	private List<DiscountStoreDesc> m_StoreDiscountItemList;

	private List<VeteranStoreDesc> m_VeteranDiscountStoreItemList;

	private List<StarterStoreItemDesc> m_StarterStoreItemList;

	private Dictionary<uint, StarterStoreItemDesc> m_DictStoreIdToStoreDesc;

	private Dictionary<uint, List<StarterStoreItemDesc>> m_DictSubTypeToStoreDescList;

	private Dictionary<uint, string> m_DictNewBieStoreTypeToKey;

	private List<RankExchangeDisplayDesc> m_RankExchangeStoreDisplayItemList;

	private Dictionary<uint, PVEExchangeStoreDesc> m_PveExchangeStoreItemDic;

	private Dictionary<uint, RankExchangeLimitItemDesc> m_RankExchangeStoreCurrentSeasonItemDict;

	private Dictionary<uint, RankExchangeLimitItemDesc> m_RankExchangeStorePreviousSeasonItemDict;

	public Dictionary<int, OtherChannelInfo> OtherChannelInfo;

	private Dictionary<uint, Dictionary<uint, StoreTableDesc>> m_MallTabInfoDict;

	public const uint PropID_StoreItemListUpdate = 2u;

	public const uint PropID_PurchaseSuccess = 4u;

	public const uint PropID_GetAds = 16u;

	public const uint PropID_ExchangeStoreItemListUpdate = 32u;

	public const uint PropID_ExchangePurchaseSuccess = 64u;

	public const uint PropID_TreasureBoxProbability_Update = 128u;

	public const uint PropID_DiscountStoreItemListUpdate = 256u;

	public const uint PropID_DiscountItemPurchaseSuccess = 512u;

	public const uint PropID_TreasureBoxOpenSuccess = 4096u;

	public const uint PropID_TreasureBoxOpenFailed = 8192u;

	public const uint PropID_BundleOpenFailed = 16384u;

	public const uint PropID_BundleOpenSuccess = 32768u;

	public const uint PropID_PickOptionBundleSuccess = 65536u;

	public const uint PropID_InGameBonusProbabilityUpdate = 131072u;

	public const uint PropID_TreasureBoxOpenWithAnimation = 262144u;

	public const uint PropID_StoreMultipleStuffOK = 524288u;

	public const uint PropID_UnlockVeteranStoreDiscount = 1048576u;

	public const uint PropID_StarterStoreItemListUpdate = 2097152u;

	public const uint PropID_StarterStoreItemPurchaseSuccess = 4194304u;

	public const uint PropID_CheckOwnedBeforeSendGift = 8388608u;

	public const uint PropID_PrimeStoreItemPurchaseSuccess = 16777216u;

	public const uint PropID_PrimeStoreItemListUpdate = 33554432u;

	private float m_LastUpdateStoreResTime;

	private float m_LastUpdateDiscountResTime;

	private float m_LastUpdatePrimeStoreResTime;

	private float m_LastUpdateExchangeResTime;

	private float m_LastUpdateStarterResTime;

	private float m_LastUpdateStoreResStuffTime;

	private float m_LastUpdateFirstPayBonusInfoTime;

	private float m_LastUpdateCheckOwnedBeforeSendGiftTime;

	private bool m_RequestStoreResIsCD;

	private float m_GetStoreResCoolDown;

	private float m_GetFirstPayBonusInfoCoolDown;

	private float m_GetCheckOwnedBeforeSendGiftCoolDown;

	private bool m_IsNewbieOfferStoreOpen;

	public bool m_ActiveRefreshStoreRes;

	private const string m_MallItemAnimPrefix = "MALLITEM_FULLSCREEN_ANIM";

	private const string m_HASAUTODOWNLOADITEM = "HASAUTODOWNLOADITEM";

	private bool m_IsSendGiftRepeatRequesting;

	private UIModelInventory m_ModelInventory;

	private UIModelAvatarProfile m_ModelAvatarPorfile;

	private UIModelAvatar m_ModelAvatar;

	private UIModelStoreBox m_ModelStoreBox;

	public Dictionary<uint, List<ClanExchangeData>> CommodityGroup2ItemList;

	public Dictionary<uint, uint> CommodityId2CommodityGroupId;

	private Dictionary<uint, CompareData> m_CompareDataDict;

	private Dictionary<uint, MallV2TabData> m_dicTabCfg;

	private Dictionary<uint, MallV2SecondTabData> m_dicSecondTabCfg;

	private Dictionary<uint, List<uint>> m_dicFirstTabData;

	private Dictionary<uint, List<StoreDesc>> m_dicSecondTabData;

	private Dictionary<uint, List<StoreDesc>> m_MixCoinWeaponStores;

	private Dictionary<uint, List<StoreDesc>> m_MixGemWeaponStores;

	private List<uint> m_sortFirstTabList;

	public const uint Magic_Cube_Item = 800000304u;

	private const uint Magic_Cube_Debris_Item = 801000183u;

	public const uint Clan_Exchange_Item = 814000003u;

	private const uint NEW_BIE_OFFER_SUBTYPE_NORMAL_ITEM = 1u;

	public uint ClanExchangeStoreTokenID => 0u;

	public List<StoreDesc> StoreItemList => null;

	public Dictionary<uint, List<ExchangeStoreItemDesc>> ExchangeStoreItemDict => null;

	public Dictionary<uint, ExchangeStoreDesc> ExchangeStoreDict => null;

	public List<ExchangeStoreItemDesc> ExchangeStoreItemList => null;

	public List<ClanStoreCommodityConfigDesc> ClanExchangeStoreConfigList => null;

	public List<DiscountStoreDesc> StoreDiscountItemList => null;

	public List<VeteranStoreDesc> VeteranDiscountStoreItemList => null;

	public List<StarterStoreItemDesc> StarterStoreItemList => null;

	public Dictionary<uint, StarterStoreItemDesc> DictStoreIdToStoreDesc => null;

	public Dictionary<uint, string> DictNewBieStoreTypeToKey => null;

	public Dictionary<uint, RankExchangeLimitItemDesc> RankExchangeStoreCurrentSeasonItemDict => null;

	public Dictionary<uint, RankExchangeLimitItemDesc> RankExchangeStorePreviousSeasonItemDict => null;

	public bool IsNewbieOfferStoreOpen
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsSendGiftRepeatRequesting => false;

	private UIModelInventory ModelInventory => null;

	private UIModelAvatarProfile ModelAvatarProfile => null;

	private UIModelAvatar ModelAvatar => null;

	private UIModelStoreBox ModelStoreBox => null;

	public Dictionary<uint, List<uint>> FirstTabDataDic => null;

	public Dictionary<uint, List<StoreDesc>> SecondTabDataDic => null;

	public Dictionary<uint, MallV2TabData> FirstTabCfgDic => null;

	public Dictionary<uint, MallV2SecondTabData> SecondTabCfgDic => null;

	public List<uint> SortFirstTabList => null;

	public Dictionary<uint, List<StoreDesc>> MixCoinWeaponStores => null;

	public Dictionary<uint, List<StoreDesc>> MixGemWeaponStores => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public RankExchangeDisplayDesc GetRankExchangeStoreDisplayItem()
	{
		return null;
	}

	public void GetStoreMultipleStuff(LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, bool isStarter = false, bool sendImmediately = false)
	{
	}

	public void GetStoreRes(bool refreshByItemInfoWrong = false, LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, bool sendImmediately = false)
	{
	}

	public void UnlockVeteranStoreDiscount()
	{
	}

	private void OnGetStoreRes(CSGetStoreRes storeRes, bool refreshByItemInfoWrong = false)
	{
	}

	public uint GetBRRankLimit(ExchangeStoreItemDesc desc)
	{
		return 0u;
	}

	public uint GetCSRankLimit(ExchangeStoreItemDesc desc)
	{
		return 0u;
	}

	public bool IsReachRankLimit(ExchangeStoreItemDesc desc, uint currentBRRank, uint currentCSRank)
	{
		return false;
	}

	public void GetDiscountStoreDesc(bool force = false, uint option = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void GetPrimeStoreDesc(bool force = false, uint option = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void PurchaseDiscountItem(uint storeID, bool isFreeItem = false, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u)
	{
	}

	public void PurchaseVeteranDiscountItem(uint PoolID, uint discount, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u)
	{
	}

	private void UpdateMallTipsNum()
	{
	}

	private int NormalMallTipsNum()
	{
		return 0;
	}

	private int DiscountMallTipsNum()
	{
		return 0;
	}

	private int DiscountMallFreeItemTipsNum()
	{
		return 0;
	}

	public int DiscountMallUnClaimFreeItemNum()
	{
		return 0;
	}

	public void ProcessDiscountStoreDesc(CSGetDiscountStoreDescRes res)
	{
	}

	public void ProcessVeteranDiscountStoreDesc(CSGetVeteranStoreDescRes res)
	{
	}

	private void ResetRefreshStoreItemColdData()
	{
	}

	public void SaveData()
	{
	}

	public void LoadData()
	{
	}

	protected override void OnSceneChange(object[] data)
	{
	}

	public void RequestProbability(uint itemId, Action callback)
	{
	}

	public void RequestTreasureBoxProbability(uint id, Action next = null)
	{
	}

	public void RequestInGameBonusProbability(uint Id, Action next = null)
	{
	}

	private void ClearTreasureBoxProbabilityCache()
	{
	}

	public List<uint> GetOverrideTypeList(string overrideType)
	{
		return null;
	}

	public List<ExchangeStoreItemDesc> GetMallStoreItemList(uint storeID, uint currencyID, MallType storeType, uint tab)
	{
		return null;
	}

	public int SortExchangeStorePreviousSeasonRankItem(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	public int SortExchangeStoreCurrentSeasonRankItem(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	public void GetExchangeStoreRes(bool force = false, bool refreshByItemInfoWrong = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1)
	{
	}

	private void ProcessExchangeStore(CSGetExchangeStoreRes res, bool refreshByItemInfoWrong)
	{
	}

	public void ProcessRankExchangeStoreSeasonItemRankMapping()
	{
	}

	public ExchangeStoreDesc GetExchangeDescByBoxId(uint boxId)
	{
		return null;
	}

	public ExchangeStoreItemDesc GetExchangeItemDescBySotreId(uint storeId)
	{
		return null;
	}

	private void UpdateExchangeStore(ExchangeStore exchangeStore)
	{
	}

	public bool CheckHasEnoughCurrency(EInventory.CurrencyType currencyType, uint totalPrice)
	{
		return false;
	}

	public bool GetPriceAndTotlaPrice(uint itemId, uint itemCount = 1u, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint voucherID = 0u, bool isItemId = true)
	{
		return false;
	}

	public void Purchase(uint itemId, uint itemCount = 1u, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint voucherID = 0u, bool isOffer = true, bool isItemId = true, bool isQuickPurchase = false, bool isIgnoreShowPurchaseReward = false, int targetPlanIndex = -1, uint targetSlot = 0u)
	{
	}

	public void Purchase(StoreDesc storeDesc, uint count = 1u, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint voucherID = 0u, bool isOffer = true, bool isQuickPurchase = false, bool isIgnoreShowPurchaseReward = false, int targetPlanIndex = -1, uint targetSlot = 0u, Action<CSPurchaseReq> initReq = null)
	{
	}

	public void Exchange(ExchangeStoreItemDesc exchangeStoreItem, uint count = 1u, uint entryFrom = 1u)
	{
	}

	public void RequestPurchaseClanPrivilege()
	{
	}

	public void ShowPurchaseReward(uint itemId, List<BaseItemInfo> awardlist, uint count, int targetPlanIndex = -1, uint targetSlot = 0u, Action closeAction = null)
	{
	}

	public void RefreshStoreRes()
	{
	}

	public void RefreshExchangeStoreRes()
	{
	}

	public void RefreshDiscountStoreRes()
	{
	}

	public StoreDesc FindStoreItemDescById(uint id, uint awardTime = 0u, bool ignoreAwardTime = false)
	{
		return null;
	}

	public StoreDesc FindStoreItemDescByStoreId(uint storeId)
	{
		return null;
	}

	public ExchangeStoreItemDesc FindExchagneItemDescById(uint id)
	{
		return null;
	}

	public ExchangeStoreItemDesc FindExchagneItemDescByCommodityID(uint commodityId)
	{
		return null;
	}

	public DiscountStoreDesc FindDiscountItemDescById(uint id)
	{
		return null;
	}

	public bool IsSameAndCanPurchaseDiscountItem(uint id, uint storeId)
	{
		return false;
	}

	public DiscountStoreDesc FindDiscountItemDescByStoreId(uint id)
	{
		return null;
	}

	public VeteranStoreDesc FindVeteranItemDescByAwardId(uint id)
	{
		return null;
	}

	public VeteranStoreDesc FindVeteranItemDescByPoolId(uint id)
	{
		return null;
	}

	public bool CheckIsPreItemOwnedAndNotExpired(StoreDesc itemDesc, ulong curTime)
	{
		return false;
	}

	public bool CheckIsOwnedAndNotExpired(uint itemID, ulong curTime)
	{
		return false;
	}

	public bool CheckIsUniqueAndOwned(uint id)
	{
		return false;
	}

	public bool CheckIsUniqueAndOwned(CSSharedItemData itemData)
	{
		return false;
	}

	public bool ItemCanPurchase(StoreDesc storeDesc)
	{
		return false;
	}

	public uint GetItemLimitedPurchaseTime(ExchangeStoreItemDesc exchangeItemDesc)
	{
		return 0u;
	}

	public uint GetPrimeItemLimitedPurchaseTimes(PrimeStoreItemDesc primeItemDesc)
	{
		return 0u;
	}

	private void HandleClanExchangeStoreConfigList()
	{
	}

	public ExchangeStoreItemDesc FindExchagneItemDescByCommodityGroupId(uint groupId)
	{
		return null;
	}

	public bool ItemCanPurchase(ExchangeStoreItemDesc exchangeItemDesc)
	{
		return false;
	}

	public bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
	{
		return false;
	}

	public bool ReachItemLimitedCount(uint id)
	{
		return false;
	}

	private static bool IsBonusCardItem(uint itemId)
	{
		return false;
	}

	public static List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list, uint[] lengendClothesIDList = null, List<ItemTagInfo> launchTagInfoList = null, bool allowBPCardDisplay = false)
	{
		return null;
	}

	public static List<BaseItemInfo> AssembleAwardList(List<BaseItemInfo> add_list, List<BaseItemInfo> del_list)
	{
		return null;
	}

	public static List<CommonRewardItemInfo> AssembleAwardListNoLimit(List<CommonRewardItemInfo> add_list, List<BaseItemInfo> del_list)
	{
		return null;
	}

	public void OpenGrate(uint item_id, uint count = 1u, bool iscrate = false, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON, bool isNeedPlayAnimation = false, bool showBoxTag = true, Action closeAction = null)
	{
	}

	public void OpenTreasureBoxes(UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void GetItemNeedDownLoad()
	{
	}

	public void OpenOptionalBundle(uint itemId, uint autoOpenNum = 0u)
	{
	}

	public bool CheckOptionalBundleHasRepeatedOpen(uint itemID)
	{
		return false;
	}

	private void OpenOptionalBundleChooseNumWnd(Item item)
	{
	}

	private void ShowOptionalBundleView(uint item_id, uint count = 1u)
	{
	}

	public void PickOptionalBundle(uint item_id, List<uint> openOptionalBundleRequestList, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void OpenBundle(uint item_id, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	public void OpenBundleBatch(List<uint> bundleIDList, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON, bool showBundleTag = true, Action closeAction = null)
	{
	}

	public bool IsOtherChannelItem(StoreDesc desc)
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	private void ResetData()
	{
	}

	public StoreDesc GetLoadoutStoreItemInfo(uint id)
	{
		return null;
	}

	public FullscreenCgDesc GetFullScreenAnimdata(uint id)
	{
		return null;
	}

	public bool GetMallItemAnimIsPlayed(uint itemID)
	{
		return false;
	}

	public void SetMallItemAnimPlayed(uint itemID)
	{
	}

	private ulong GetRoomIDByItemList(List<uint> IDList)
	{
		return 0uL;
	}

	private ulong GetRoomIDByItemListNoLimit(uint[] IDList)
	{
		return 0uL;
	}

	private bool IsBuyRoomCard(uint itemID)
	{
		return false;
	}

	private CompareData ConstructCompareData(uint storeID, uint itemID, bool needCheckBundle = false, bool needCheckBox = false, bool checkCanEquipCloth = false)
	{
		return null;
	}

	public void SortExchangeStoreDataList(List<ExchangeStoreItemDesc> dataList)
	{
	}

	private int SortExchangeStoreItem(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return 0;
	}

	private int SortStoreItem(CompareData x, CompareData y, uint sortIDx, uint sortIDy, bool canPurchasex, bool canPurchasey, uint xItemID, uint yItemID, bool checkBundleOwned, bool checkBoxOwned, bool checkEquipCloth)
	{
		return 0;
	}

	public static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	private void FixTreasureBoxRewardLevel(uint treasureboxID, List<CommonRewardItemInfo> list)
	{
	}

	public bool CheckItemAndBundleOrBoxOwned(uint itemID)
	{
		return false;
	}

	public bool CheckOptionalBundleOwned(CSSharedItemData itemData)
	{
		return false;
	}

	public bool BoxContainsItemAllOwnerByItemData(CSSharedItemData itemData, bool ignoreNoUnique = false)
	{
		return false;
	}

	public bool BoxContainsItemAllOwned(uint itemID, bool ignoreNoUnique = false)
	{
		return false;
	}

	public bool CheckBundleOwned(uint itemID)
	{
		return false;
	}

	public bool CheckBundleOwned(CSSharedItemData itemData)
	{
		return false;
	}

	public uint GetRealGemPrice(StoreDesc storeDesc)
	{
		return 0u;
	}

	public bool IsItemOwnedInBundle(uint id)
	{
		return false;
	}

	public bool BundleContainsItemAllOwned(CSSharedItemData itemData)
	{
		return false;
	}

	public bool CheckIsInvisbleSkill(uint itemid)
	{
		return false;
	}

	public bool CheckIsInvisbleSkillAndNotExpried(uint itemid, ulong curTime)
	{
		return false;
	}

	public bool CheckIsHasAvatarSkillIncludeChip(uint avatarId)
	{
		return false;
	}

	public bool OptionalBundleContainsItemAllOwned(uint id)
	{
		return false;
	}

	public int GetDiscountItemPrice(uint price, float discountValue)
	{
		return 0;
	}

	public FullScreenAnimParams CreateFullScreenAnimParams(FullscreenCgDesc animData)
	{
		return null;
	}

	public bool IsShowDiscountTag(StoreDesc desc)
	{
		return false;
	}

	public bool IsDiscountItem(StoreDesc desc)
	{
		return false;
	}

	public void ProcessStarterStoreDesc(CSGetStarterStoreDescRes res)
	{
	}

	public List<StarterStoreItemDesc> GetStarterStoreItemDescListBySubType(ENewBieOfferSubType subType)
	{
		return null;
	}

	public void PurchaseStarterStoreItem(uint storeID, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u, Action closeAction = null)
	{
	}

	public void BuyPrimeStoreItem(PrimeStoreItemDesc primeItemDesc, uint count, uint voucherid)
	{
	}

	public void RefreshStarterStoreRes()
	{
	}

	public void GetStarterStoreDesc(bool force = false, uint option = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestCheckOwnedBeforeSendGift(ulong[] friendsList, uint commodity_id, bool isPrime)
	{
	}

	public override void Login(object[] data)
	{
	}

	public List<uint> GetSecondTabListByTabId(uint tabId)
	{
		return null;
	}

	public List<uint> GetSecondExchangeTabList()
	{
		return null;
	}

	private void InitTabCfg()
	{
	}

	private void ClearStoreCacheDataV2()
	{
	}

	private void UpdateItemsDictV2(StoreDesc item, CSSharedItemData itData, ref List<uint> unKnowTypeItemIDList)
	{
	}

	private void AddItemToDictV2(uint mallSubType, StoreDesc item, ref List<uint> unKnowTypeItemIDList)
	{
	}

	public bool IsAutoSelectTab(uint secondTabId)
	{
		return false;
	}

	public uint GetFirstTabIdBySecondTab(uint secondTabId)
	{
		return 0u;
	}

	public uint GetMallTypeByFirstTab(uint firstTabId)
	{
		return 0u;
	}

	public bool IsDiscountItem(ref uint itemId)
	{
		return false;
	}

	public uint GetExchangeTabIdByItemId(ref uint itemId)
	{
		return 0u;
	}

	public uint GetSecondTabIdByItemId(ref uint itemId)
	{
		return 0u;
	}

	public StoreDesc FindStoreItemDescByStoreOrItemId(ref uint id)
	{
		return null;
	}

	public StoreDesc FindStoreItemDescByStoreOrItemId(uint secondTabId, ref uint id)
	{
		return null;
	}

	public ExchangeStoreItemDesc FindExchagneItemDescByStoreOrItemId(ref uint id)
	{
		return null;
	}

	public ExchangeStoreItemDesc FindExchagneItemDescByStoreOrItemId(uint currencyId, ref uint id)
	{
		return null;
	}

	public UINavigationUtil.UINavigationMallV2SubTabType GetSecondTabByItem(CSSharedItemData itemData)
	{
		return UINavigationUtil.UINavigationMallV2SubTabType.None;
	}

	private void OnGetStoreResV2(CSGetStoreRes storeRes, bool refreshByItemInfoWrong = false)
	{
	}

	public bool CheckIsItemCanPurchase(uint itemId, uint limited_purchase_times, uint purchase_times)
	{
		return false;
	}

	public bool CheckIsWeaponItemCanPurchase(uint itemId)
	{
		return false;
	}

	public bool TryGetMixWeapinList(uint storeId, out List<StoreDesc> storeDescs)
	{
		storeDescs = null;
		return false;
	}

	private void MergeWeaponStoreItem()
	{
	}

	private int SortByAwardTime(StoreDesc x, StoreDesc y)
	{
		return 0;
	}

	public void ReloadStoreFirstTabList()
	{
	}

	public string GetFirstTabName(uint type)
	{
		return null;
	}

	public uint GetFirstTabIsDiscount(uint type)
	{
		return 0u;
	}

	public int GetTabPriority(uint tabID)
	{
		return 0;
	}

	public int GetSecondTabPriority(uint tabID)
	{
		return 0;
	}

	public uint GetChildWeaponItemId(uint itemId)
	{
		return 0u;
	}

	public bool CheckCanNewBieOfferOpen()
	{
		return false;
	}

	public bool CheckStarterStoreItemIsEmpty()
	{
		return false;
	}

	public bool ContainWeaponType(uint itemId, uint weaponType)
	{
		return false;
	}

	public bool ContainWeaponId(uint itemId, uint weaponId)
	{
		return false;
	}

	public bool IsWeaponTypeItem(uint itemId, uint weaponType)
	{
		return false;
	}

	public bool IsWeaponIdItem(uint itemId, uint weaponId)
	{
		return false;
	}

	public void SelectBundleWeaponItem(uint itemId, uint weaponType, uint weaponId)
	{
	}

	private bool DispatchWeaponSelect(uint itemId, uint weaponType, uint weaponId, int index)
	{
		return false;
	}

	public BaseItemInfo GetChildWeaponItem(uint itemId, uint weaponType = 99u, uint weaponId = 0u)
	{
		return null;
	}

	public bool HasWeaponProperty(uint itemId)
	{
		return false;
	}

	public WeaponSkinPropertyScore FindWeaponSkinScoreById(uint itemId, uint weaponType = 99u, uint weaponId = 0u)
	{
		return null;
	}

	private bool IsChildWeaponItem(uint itemId, uint weaponType, uint weaponId)
	{
		return false;
	}

	public void SetWeaponFilter(uint itemId, HashSet<uint> filterTypes, HashSet<uint> weaponIds)
	{
	}

	public bool AddWeaponFilter(uint itemId, HashSet<uint> filterTypes, HashSet<uint> weaponIds)
	{
		return false;
	}

	public bool ContainGenderId(uint itemId, uint genderType)
	{
		return false;
	}

	protected bool IsGenderTypeItem(uint id, uint genderType)
	{
		return false;
	}

	public void SetGnederFilter(uint itemId, HashSet<uint> filterTypes)
	{
	}

	public bool AddGnederFilter(uint itemId, HashSet<uint> filterTypes)
	{
		return false;
	}

	public bool ContainWeaponToken(uint itemId, uint tokenType)
	{
		return false;
	}

	protected bool IsWeaponTokenItem(uint itemId, uint tokenType)
	{
		return false;
	}

	public void SetWeaponTokenFilter(uint itemId, HashSet<uint> filterTypes)
	{
	}

	public bool AddWeaponTokenFilter(uint itemId, HashSet<uint> filterTypes)
	{
		return false;
	}

	public void ConvertNavigationOldToNew(UINavigationUtil.UINavigationMallType mallType, uint mallTabType, uint subType, out UINavigationUtil.UINavigationMallV2Type mallV2Type, out uint firstTab, out uint secondTab)
	{
		mallV2Type = default(UINavigationUtil.UINavigationMallV2Type);
		firstTab = default(uint);
		secondTab = default(uint);
	}

	private void _003CGetStoreMultipleStuff_003Eb__105_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CUnlockVeteranStoreDiscount_003Eb__107_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetDiscountStoreDesc_003Eb__112_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetPrimeStoreDesc_003Eb__113_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CGetStarterStoreDesc_003Eb__229_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCheckOwnedBeforeSendGift_003Eb__230_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CReloadStoreFirstTabList_003Eb__280_0(uint x, uint y)
	{
		return 0;
	}

	private int _003CReloadStoreFirstTabList_003Eb__280_1(uint x, uint y)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnSceneChange(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
