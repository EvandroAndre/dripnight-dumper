using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelGacha : UIBaseModel
{
	private class GachaCachePref
	{
		public uint id;

		public uint subId;
	}

	private class GachaCachePrefs
	{
		public List<GachaCachePref> gachaCaches;
	}

	private enum GachaAnimState
	{
		NO_PLAYED,
		PLAYERD
	}

	public enum GachaOpenChestType
	{
		Default,
		OpenChest,
		LoopAnimation,
		OpenChestV2
	}

	private enum GachaFreeType
	{
		Free = 1
	}

	public enum LuckySpinState
	{
		None,
		Ready,
		Done
	}

	public enum GachaRewardPanelSource
	{
		GachaSpin,
		ExtraRewardClaim
	}

	public enum GachaActivityType
	{
		NONE,
		ACTIVITY_TYPE1,
		ACTIVITY_TYPE2
	}

	public enum LotteryTheme
	{
		THEME1 = 1,
		THEME2
	}

	public enum GachaDrawType
	{
		TYPE_NONE,
		TYPE_SINGLE,
		TYPE_MULTI,
		TYPE_BUFF_BUY
	}

	public enum ChestHintColor
	{
		WHITE,
		BLACK
	}

	public enum LimitResetType
	{
		NONE,
		DAILY,
		TERM
	}

	public enum ChestChangeTextType
	{
		TokenTowerPreviewPrizePool = 1,
		TokenTowerPreviewPrivilege,
		TokenTowerGuaranteedDrop,
		TokenTowerExtraListLock,
		TokenTowerExtraListUnLock,
		TokenWheelExchangButton,
		TokenTowerAvatarTransform
	}

	public enum GachaLuckyType
	{
		None,
		GainFirstSuperPrizeEarly,
		AccumulatedSuperPrizesMonthly,
		MultiplePrizesAtOnce
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<ChestLuckyRemindConfigDesc> _003C_003E9__172_0;

		public static Func<uint, bool> _003C_003E9__220_0;

		internal int _003CProcessGachaDes_003Eb__172_0(ChestLuckyRemindConfigDesc x, ChestLuckyRemindConfigDesc y)
		{
			return 0;
		}

		internal bool _003CGetLimitPurchaseCount_003Eb__220_0(uint priceType)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint gachaID;

		public List<uint> removeItems;

		internal void _003CRequestRemoveGachaLimitItems_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public ChestSpecialExchangeDesc exchangeDes;

		public UIModelGacha _003C_003E4__this;

		public GachaInfoDataBase gachaInfo;

		public Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__1;

		internal void _003CRequestDoGachaSpecialExchange_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal CommonRewardItemInfo _003CRequestDoGachaSpecialExchange_003Eb__1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass182_0
	{
		public UIModelGacha _003C_003E4__this;

		public bool needRefreshNowGachaView;

		public bool isSpecial;

		internal void _003CRequestGachaInfoRes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass183_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint gachaId;

		internal void _003CRequestGachaProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass186_0
	{
		public int round;

		internal bool _003CGetGachaRulesPriceString_003Eb__0(ClientDoubleWheelPrice x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass188_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint chestID;

		public uint condition_num;

		internal void _003CExchangeGachaExtraReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass191_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint chestID;

		public uint exchangeType;

		public uint couponCnt;

		public uint Price;

		public bool isRepurchase;

		internal void _003CMixedPurchase_003Eb__1()
		{
		}

		internal void _003CMixedPurchase_003Eb__2()
		{
		}

		internal void _003CMixedPurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass193_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint chestID;

		public GachaDrawType drawType;

		public bool isRepurchase;

		public ELottery.ConsumeType consumeType;

		public uint exchangeType;

		internal void _003CPurchase_003Eb__1(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CPurchase_003Eb__2()
		{
		}

		internal void _003CPurchase_003Eb__3()
		{
		}

		internal void _003CPurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass244_0
	{
		public KeyValuePair<uint, GachaPackageInfoData> gachaDesc;

		internal bool _003CHasNewGacha_003Eb__0(GachaCachePref item)
		{
			return false;
		}

		internal bool _003CHasNewGacha_003Eb__1(GachaCachePref item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass263_0
	{
		public uint gachaShowItemID;

		internal bool _003CGetGachaShowItemInfoByID_003Eb__0(GachaShowItem item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass265_0
	{
		public LimitedChestGoods good;

		internal bool _003CGetCurrentRewardPoolList_003Eb__0(GachaShowItem x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass271_0
	{
		public uint itemId;

		internal bool _003CIsItemInGachaShowItemList_003Eb__0(GachaShowItem reward)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass283_0
	{
		public uint chestID;

		internal bool _003CFindGachaIdListIdx_003Eb__0(uint item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass304_0
	{
		public GachaInfoDataBase gachaInfo;

		internal bool _003CIsGainFirstSuperPrizeEarly_003Eb__0(ChestLuckyRemindConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass305_0
	{
		public GachaInfoDataBase gachaInfo;

		internal bool _003CIsGainFirstPrizeEarly_003Eb__0(ChestLuckyRemindConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass306_0
	{
		public GachaInfoDataBase gachaInfo;

		internal bool _003CIsAccumulatedSuperPrizeMonthly_003Eb__0(ChestLuckyRemindConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass307_0
	{
		public GachaInfoDataBase gachaInfo;

		internal bool _003CIsMultiplePrizeAtOnce_003Eb__0(ChestLuckyRemindConfigDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass76_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint gachaID;

		internal bool _003CSortHackerStoreShowItem_003Eb__0(LimitedChestGoods good)
		{
			return false;
		}

		internal bool _003CSortHackerStoreShowItem_003Eb__1(LimitedChestGoods good)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public uint id;

		internal bool _003CGethackerStoreShowItemInfo_003Eb__0(GachaShowItem info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint chestID;

		internal void _003CRequestLimitedChestProbability_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIModelGacha _003C_003E4__this;

		public uint gachaID;

		internal void _003CSelectHackerStoreLimitedChestPrize_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private UIDataModelGacha m_DataModel;

	private bool _003CNoShowConfirmWnd_003Ek__BackingField;

	private uint _003CLobbyGachaId_003Ek__BackingField;

	private uint _003CLobbyGachaPrimeID_003Ek__BackingField;

	private uint _003CNewBieGachaId_003Ek__BackingField;

	private bool _003CIsInventoryBagPackReady_003Ek__BackingField;

	private List<uint> m_GachaSortedIDs;

	private Dictionary<uint, ulong> m_DicCouponDateTime;

	private Dictionary<uint, bool> m_IsResetEPDict;

	private Dictionary<uint, CSGetLotteryProbabilityRes> m_GachaRareProbability;

	private Dictionary<uint, uint> m_CurrentShowTypeDic;

	private Dictionary<uint, List<uint>> m_RemoveItemsDic;

	public const uint GACHALIMIT_REMOVE_COUNT = 2u;

	public const uint GACHALIMIT_ALL_COUNT = 10u;

	public const float GUARANTEED_DROP_HIGHLIGHT_THRESHOLD = 0.2f;

	private CSGetGachaInfoRes m_InfoRes;

	private GachaCachePrefs m_CacheGachaPrefs;

	private CSVAsyncDataMap<uint, ChestChangeSkinData> m_ChangeSkinCSV;

	private CSVAsyncDataMap<uint, ChestChangeTextData> m_ChangeTextCSV;

	private const string Prefs_CacheGachaIdSubIds = "CacheGachaIdSubIds";

	private const string m_GachaAnimPrefix = "GACHA_FULLSCREEN_ANIM";

	private const string m_HASAUTODOWNLOADITEM = "HASAUTODOWNLOADITEM";

	public const string Prefs_HasShownCompleteReminder = "Gacha_Shown_CompleteReminder";

	public const uint PropID_GachaAds_Update = 2u;

	public const uint PropID_GachaInfo_Update = 4u;

	public const uint PropID_PurchaseSuccess = 8u;

	public const uint PropID_GachaDesc_Update = 16u;

	public const uint PropID_NoGachaData = 32u;

	public const uint PropID_PurchaseFailed = 64u;

	public const uint PropID_Gacha_Probability_Getted = 128u;

	public const uint PropID_GachaSpDesc_Update = 256u;

	public const uint PropID_GachaSpExchange_Success = 512u;

	public const uint PropID_ShouldNotifyChange = 1024u;

	public const uint PropID_SpicalDrawDataUpdate = 2048u;

	public const uint PropID_GachaLimitPoolStateUpdate = 4096u;

	public const uint PropID_GachaLimitedChestInfoUpdate = 8192u;

	public const uint PropID_GachaLimitedChestProbabilityUpdate = 16384u;

	public const uint PropID_GachaInfo_Update_Failed = 32768u;

	private CSGetLimitedChestInfoRes m_hackerStoreInfo;

	private Dictionary<uint, List<LimitedChestGoods>> m_hackerStoreShowItemIDs;

	private Dictionary<uint, uint> m_hackerStoreCacheRewardID;

	private const string cm_strShowLimitChestSplashKey = "LimitChestSplash{0}_{1}";

	public const int HackerStoreRareTypeSuperRareIndex = 2;

	public const int HackerStoreRareTypeRareIndex = 3;

	private Dictionary<uint, CSGetLimitedChestProbabilityRes> m_limitChestRareProbabilitys;

	private const int MOCORAREITEMCOUNT = 8;

	public const string GACHA_RARE_EXCHANGE_DAILY_KEY = "Gacha_Rare_Exchange_Daily";

	public bool NoShowConfirmWnd
	{
		get
		{
			return _003CNoShowConfirmWnd_003Ek__BackingField;
		}
		set
		{
			_003CNoShowConfirmWnd_003Ek__BackingField = value;
		}
	}

	public uint LobbyGachaId
	{
		get
		{
			return _003CLobbyGachaId_003Ek__BackingField;
		}
		private set
		{
			_003CLobbyGachaId_003Ek__BackingField = value;
		}
	}

	public uint LobbyGachaPrimeID
	{
		get
		{
			return _003CLobbyGachaPrimeID_003Ek__BackingField;
		}
		private set
		{
			_003CLobbyGachaPrimeID_003Ek__BackingField = value;
		}
	}

	public uint NewBieGachaId
	{
		get
		{
			return _003CNewBieGachaId_003Ek__BackingField;
		}
		private set
		{
			_003CNewBieGachaId_003Ek__BackingField = value;
		}
	}

	public bool IsInventoryBagPackReady
	{
		get
		{
			return _003CIsInventoryBagPackReady_003Ek__BackingField;
		}
		set
		{
			_003CIsInventoryBagPackReady_003Ek__BackingField = value;
		}
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private void SortHackerStoreShowItem(uint gachaID)
	{
	}

	public GachaShowItem GethackerStoreShowItemInfo(uint gachaID, uint id)
	{
		return null;
	}

	public ELottery.RareType GetLimitChestGoodsStatus(uint gachaID, uint id)
	{
		return ELottery.RareType.RareType_NORMAL;
	}

	public uint GetLimitChestGoodIDByGachaIDAndRareType(uint gachaID, ELottery.RareType rareType)
	{
		return 0u;
	}

	public bool IsShowLimitChestSplashCDN(uint gachaID)
	{
		return false;
	}

	public void ShowedLimitChestSplashCDN(uint gachaID)
	{
	}

	public List<int> GetHackerStorePurchasedAnimatorIndexes(uint gachaID)
	{
		return null;
	}

	private uint GetHackerStorePurchaseCnt(uint gachaID)
	{
		return 0u;
	}

	public uint GetCacheHackerStoreLastGetID(uint gachaID)
	{
		return 0u;
	}

	private void CacheHackerStoreLastGetID(uint gachaID, uint gachaRewardID)
	{
	}

	private void RefreshHackerStoreShowItems()
	{
	}

	private void RefreshHackerStoreSuperGrandPrize()
	{
	}

	private void UpdateHackerStoreShowItemState(uint gachaID, uint gachaRewardID)
	{
	}

	private void RefreshHackerStoreShowItemsBySelectRes(uint chestID, uint[] goods)
	{
	}

	public bool IsPurchasedForHackerStore(uint chestID, uint id)
	{
		return false;
	}

	public bool IsAllPurchasedForHackerStore(uint chestID)
	{
		return false;
	}

	public void RequestLimitedChestProbability(uint chestID)
	{
	}

	public void RequestHackerStoreInfo(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false)
	{
	}

	public void SelectHackerStoreLimitedChestPrize(uint gachaID, uint firstItemID, uint secondItemID)
	{
	}

	public bool IsHackerStoreSelected(uint chestID)
	{
		return false;
	}

	public List<LimitedChestGoods> GetHackerStoreShowItemIDs(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetHackerStoreSelectPageItem1(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetHackerStoreSelectPageItem2(uint chestID)
	{
		return null;
	}

	private int SortGachaShowItemList(GachaShowItem itemA, GachaShowItem itemB)
	{
		return 0;
	}

	public string GetGachaTutorialWndKeyByType(ELottery.Type type)
	{
		return null;
	}

	public List<uint> GetAllRemoveItems(uint gachaID)
	{
		return null;
	}

	public bool CheckRemoveListFull(uint gachaID)
	{
		return false;
	}

	public bool GachaLimitRemoveListContain(uint gachaID, uint itemID)
	{
		return false;
	}

	public void SetCurrentShowType(uint gachaID, UIGachaSceneShowType sceneShowType)
	{
	}

	public int GetCurrentRemoveCnt(uint gachaID)
	{
		return 0;
	}

	public void SetGachaLimitRemoveItems(uint GachaID, uint itemID)
	{
	}

	public void SetGachaLimitRemoveItems(uint GachaID, List<uint> itemIDs, bool needNotify = true)
	{
	}

	public void CancelGachaLimitRemoveItems(uint GachaID, uint itemID)
	{
	}

	public void RequestRemoveGachaLimitItems(uint gachaID, uint subID)
	{
	}

	public void GetGachaAdRes()
	{
	}

	public List<AdvertDesc> GetCurAdList(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTabRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTurntableCDNRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GachaCDNBgCDNRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTitleCDNBgRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetFrontEndCDNBgRes(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetSplashCDNRes(uint chestID)
	{
		return null;
	}

	public List<AdvertDesc> GetUnlimtedCustomCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetUnlimtedCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetExchangeCDNIcon(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetOneBuyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetMultiBuyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaOneDiscountTagCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetGachaMultiDiscountTagCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetPurchaseConfirmationBoxCDNIcon(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPreviewBtnSmallCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPreviewBtnBigCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPrivilegePanelCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerPropertyBtnCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerAvatarTransformCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerGuaranteedDropCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNSpinForTokens(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerProgressBarCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarPoint(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment1(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment2(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment3(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment4(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerCDNProgressBarSegment5(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem1(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem2(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem3(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem4(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetTokenTowerExtraListItem5(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetFadedWheelRewardPoolCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetDoubleWheelCDNBg(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetDoubleWheelKeyCDN(uint chestID)
	{
		return null;
	}

	public List<AdvertDesc> GetUnlimitedChestInfoCDN(uint chestID)
	{
		return null;
	}

	public AdvertDesc GetSwitchBtnCDNBg(uint chestID)
	{
		return null;
	}

	public ChestChangeSkinData GetChestChangeSkinData(uint chestID)
	{
		return null;
	}

	public ChestChangeTextData GetChestChangeTextData(uint chestID, ChestChangeTextType type)
	{
		return null;
	}

	public ELottery.Type GetLotteryTypeByID(uint gachaID)
	{
		return ELottery.Type.Type_NORMAL;
	}

	public uint GetDefaultGachaID()
	{
		return 0u;
	}

	public GachaResultInfo GetGachaResultInfo(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetGachaGrandPrizePoolList(List<GachaShowItem> list)
	{
		return null;
	}

	public List<GachaShowItem> GetGachaCommonRewardPoolList(List<GachaShowItem> list)
	{
		return null;
	}

	public List<BaseItemInfo> GetGachaRewardPoolList(List<GachaShowItem> list)
	{
		return null;
	}

	public List<BaseItemInfo> GetGachaRewardPoolList(uint gachaID, uint rewardPoolID = 0u)
	{
		return null;
	}

	public bool HasRareRewardItem(uint gachaID)
	{
		return false;
	}

	public int GetGachaCnt()
	{
		return 0;
	}

	private void FilterInvalidLimitPoolGachaTabs()
	{
	}

	private bool IsInvalidLimitPoolGachaTab(uint gachaID)
	{
		return false;
	}

	public Dictionary<uint, GachaInfoDataBase> GetAllGachaInfo()
	{
		return null;
	}

	public bool GetCurGachaAnimIsPlayed(uint chestID)
	{
		return false;
	}

	public FullscreenCgDesc GetCurGachaAnimData(uint gachaID)
	{
		return null;
	}

	public void SetCurGachaAnimPlayed(uint chestID)
	{
	}

	private void InitCacheGachaIdSubId()
	{
	}

	public void ClearData()
	{
	}

	public void RequestGachaDescRes(uint httpOption = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false)
	{
	}

	public void ProcessGachaDes(CSGetGachaDescRes gachaRes)
	{
	}

	private bool FilterFresherGacha(GachaDesc gachaDesc)
	{
		return false;
	}

	public bool HasDrawnGacha(uint gachaID)
	{
		return false;
	}

	public void RequestGachaSpecialExchangeDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false)
	{
	}

	public void RequestDoGachaSpecialExchange(ChestSpecialExchangeDesc exchangeDes, uint count = 1u)
	{
	}

	private void UpdateSuperPrizeInfoByExchange(uint chestId, List<CommonRewardItemInfo> rewardList)
	{
	}

	private void UpdateSuperPrizeInfoByExchange(uint chestId, List<ExchangedAward> awardList)
	{
	}

	public void CheckLuckyDataByExchange(uint chestId, List<CommonRewardItemInfo> rewardList, bool includeType1 = false)
	{
	}

	private void GotSuperGrandPrizeByExchange(uint chestID)
	{
	}

	private List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
	{
		return null;
	}

	public void RequestGachaInfoRes(uint httpOption = 0u, bool isSpecial = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false, bool needRefreshNowGachaView = false)
	{
	}

	public void RequestGachaProbability(uint gachaId, uint httpOption = 0u, uint[] rounds = null)
	{
	}

	public void GetItemNeedDownLoad(uint chestID)
	{
	}

	public void GetMocoItemNeedDownLoad(uint chestID)
	{
	}

	public string GetGachaRulesPriceString(uint chestID)
	{
		return null;
	}

	private void ClearFirstSuperGrandPrizeByExchange(uint chestID)
	{
	}

	public void ExchangeGachaExtraReward(uint chestID, uint condition_num)
	{
	}

	private void UpdatePrizePreOwnedStatus(uint chestID)
	{
	}

	public bool IsPrizePreOwned(uint chestID, uint itemId)
	{
		return false;
	}

	public void MixedPurchase(uint chestID, uint exchangeType, uint couponCnt, uint Price, bool isRepurchase = false, bool ignoreTokenProgress = false)
	{
	}

	private void HackConsumeTypeForBackEnd(uint chestID, ref ELottery.ConsumeType consumeType)
	{
	}

	public void Purchase(uint chestID, GachaDrawType drawType, ELottery.ConsumeType consumeType, uint exchangeType, bool isRepurchase = false, bool ignoreTokenProgress = false)
	{
	}

	public void UpdateEPDict(uint chestID, bool IsReset)
	{
	}

	public bool IsEPReset(uint chestID)
	{
		return false;
	}

	public bool IsOnlySupportCoupon(uint gachaID)
	{
		return false;
	}

	public uint GetCouponCount(uint gachaID, uint exchangeType)
	{
		return 0u;
	}

	private bool HasCouponItemConfig(uint[] exchangeId)
	{
		return false;
	}

	private uint GetCouponCount(uint[] exchangeId)
	{
		return 0u;
	}

	public List<CSSharedItemData> GetCouponItemsInfo(uint gachaID, uint exchangeType, bool sort = true)
	{
		return null;
	}

	public List<CSSharedItemData> GetCouponItemsInfo(uint[] exchangId)
	{
		return null;
	}

	private int SortCouponItem(CSSharedItemData a, CSSharedItemData b)
	{
		return 0;
	}

	public uint GetExtraListCurCount(uint chestID)
	{
		return 0u;
	}

	public ExtraRewardDesc GetExtralRewardDesc(uint chestID, int index)
	{
		return null;
	}

	public LuckySpinState GetLuckySpinState(uint chestID)
	{
		return LuckySpinState.None;
	}

	public bool IsExtralRewardRecieved(uint chestID, int index)
	{
		return false;
	}

	public UIGachaBuyBtnController.BuyBtnState CalOneBuyBtnState(uint chestID)
	{
		return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
	}

	public UIGachaBuyBtnController.BuyBtnState CalTenBuyBtnState(uint chestID)
	{
		return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
	}

	public UIGachaBuyBtnController.BuyBtnState CalTenBuyBtnStateForCounts(uint chestID, uint drawCount, uint couponNeed1, uint couponNeed2)
	{
		return UIGachaBuyBtnController.BuyBtnState.STATE_NONE;
	}

	public uint GetExchangeType(uint chestID, GachaDrawType drawType)
	{
		return 0u;
	}

	public bool GetMixed_Coupon_Price(uint chestID, uint exchangeType, out uint couponConsumeCnt, out uint originalPrice, out uint discountPrice)
	{
		couponConsumeCnt = default(uint);
		originalPrice = default(uint);
		discountPrice = default(uint);
		return false;
	}

	public bool GetMixed_Coupon_Price(uint chestID, uint exchangeType, out uint couponConsumeCnt, out uint price)
	{
		couponConsumeCnt = default(uint);
		price = default(uint);
		return false;
	}

	public bool GetMixed_Price(uint chestID, uint exchangeType, out uint price)
	{
		price = default(uint);
		return false;
	}

	public uint GetCurrentPrice(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public uint GetOriginPrice(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public uint GetDiscountPrice(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public List<uint> GetAvatarList(uint chestID)
	{
		return null;
	}

	public uint GetAvatarModelId(uint chestID, bool isfemale)
	{
		return 0u;
	}

	public uint GetLimitPrice(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public uint GetLimitPurchaseCount(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public uint GetLimitPurchaseCurCount(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public int GetLuckyStep(uint chestID)
	{
		return 0;
	}

	public uint GetFirstDrawRewardCount(uint chestID)
	{
		return 0u;
	}

	public ChestHintColor GetHintColor(uint chestID)
	{
		return ChestHintColor.WHITE;
	}

	public LotteryTheme GetLotteryTheme(uint chestID)
	{
		return (LotteryTheme)0;
	}

	public bool IsInDiscountPeriod(uint chestID, GachaDrawType type)
	{
		return false;
	}

	public bool IsInLimitPeriod(uint chestID, GachaDrawType type)
	{
		return false;
	}

	public bool IsInDropUpPeriod(uint chestID)
	{
		return false;
	}

	public bool IsSupportExtraDraw(uint chestID)
	{
		return false;
	}

	public uint GetExtraDrawCount(uint chestID)
	{
		return 0u;
	}

	public LimitResetType GetLimitResetType(uint chestID)
	{
		return LimitResetType.NONE;
	}

	public uint GetDrawCount(uint chestID, GachaDrawType type)
	{
		return 0u;
	}

	public uint GetExchangeNeedCouponCount(uint chestID, GachaDrawType type, uint exchangeType)
	{
		return 0u;
	}

	public EInventory.CurrencyType GetCurrencyType(uint chestID)
	{
		return EInventory.CurrencyType.CurrencyType_NONE;
	}

	public ulong GetGachaEndTime(uint chestID)
	{
		return 0uL;
	}

	public bool CheckIsCurrencyEnough(uint chestID, GachaDrawType type, UIGachaBuyBtnController.BuyBtnState buyBtnState = UIGachaBuyBtnController.BuyBtnState.STATE_NONE)
	{
		return false;
	}

	public uint GetNeedGemsNumber(uint chestID, GachaDrawType type, UIGachaBuyBtnController.BuyBtnState buyBtnState = UIGachaBuyBtnController.BuyBtnState.STATE_NONE)
	{
		return 0u;
	}

	public bool CheckIsCouponEnough(uint chestID, GachaDrawType type, uint exchangeType)
	{
		return false;
	}

	private bool CheckIsCouponEnough(uint couponNeed, uint couponOwned)
	{
		return false;
	}

	public bool CheckIsPriceFreeByID(uint chestID)
	{
		return false;
	}

	public bool CheckIsPriceFreeByID(uint chestID, GachaDrawType drawType)
	{
		return false;
	}

	public bool CheckIsLimitCDFreeById(uint chestID)
	{
		return false;
	}

	public bool CheckHasPrimeLimitByID(uint chestID)
	{
		return false;
	}

	public bool HasNewGacha()
	{
		return false;
	}

	public bool CheckCanReceiveExtraReward(uint chestID)
	{
		return false;
	}

	public bool HasRareExchange(uint chestID)
	{
		return false;
	}

	public bool HasFreeGacha()
	{
		return false;
	}

	public void UpdateCacheGachaIdSubIds()
	{
	}

	public bool IsHasFreeGacha(uint chestID)
	{
		return false;
	}

	public bool IsCfgExtraReward(uint chestID)
	{
		return false;
	}

	public ResourceID GetPropIconRes(uint chestID, uint exchangeType)
	{
		return default(ResourceID);
	}

	private ResourceID GetPropIconRes(uint[] exchangeId)
	{
		return default(ResourceID);
	}

	private bool IsInTimePeriod(ulong begin, ulong end)
	{
		return false;
	}

	public uint GetPropsCntByID(uint id)
	{
		return 0u;
	}

	public GachaInfo GetGachaInfo(uint chestID)
	{
		return null;
	}

	public T GetGachaPackageInfo<T>(uint gachaID) where T : GachaInfoDataBase
	{
		return null;
	}

	public int ChestID2ForgeTabID(uint chestID)
	{
		return 0;
	}

	public bool IsRewardRemoved(uint chestID, uint rewardId)
	{
		return false;
	}

	public bool IsDoubleWheelRewardRemoved(uint chestID, uint rewardId)
	{
		return false;
	}

	public bool IsAllGrandPrizeRemovable(uint chestID)
	{
		return false;
	}

	public bool IsAllGrandPrizeRemoved(uint chestID)
	{
		return false;
	}

	public GachaShowItem GetGachaShowItemInfoByID(uint chestID, uint gachaShowItemID, uint rewardPoolID = 0u)
	{
		return null;
	}

	public GachaShowItem GetGachaShowItemInfoByGachaRewardIDFormServerDesc(uint chestID, uint GachaRewardID)
	{
		return null;
	}

	public List<GachaShowItem> GetCurrentRewardPoolList(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetGachaShowItemInfoList(uint chestID, uint rewardPoolID = 0u)
	{
		return null;
	}

	public List<GachaShowItem> GetDoubleWheelCurrentRewardList(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetDoubleWheelGrandPrizeList(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetDoubleWheelCurrentRoundCommonRewardList(uint chestID)
	{
		return null;
	}

	public List<GachaShowItem> GetGrandPrizeList(uint chestID, uint rewardPoolID = 0u)
	{
		return null;
	}

	public bool IsItemInGachaShowItemList(uint itemId, uint chestID, uint rewardPoolID = 0u)
	{
		return false;
	}

	public bool GachaDescHasData()
	{
		return false;
	}

	public bool GachaSpEchDescHasData()
	{
		return false;
	}

	public bool GachaInfoHasData()
	{
		return false;
	}

	public GachaSpDescData GetGachaSpDescData(uint forgeTabID)
	{
		return null;
	}

	public List<ChestSpecialExchangeDesc> GetGachaSpDescList(uint forgeTabID)
	{
		return null;
	}

	public ChestSpecialExchangeDesc FindChestSpecialExchangeDesc(uint forgeTabID, uint itemId, uint id = uint.MaxValue)
	{
		return null;
	}

	public bool CanSpecialExchangePurchase(ChestSpecialExchangeDesc item)
	{
		return false;
	}

	public Dictionary<uint, GachaSpDescData> GetGachaSpDescDict()
	{
		return null;
	}

	public Dictionary<uint, GachaSpDescData> GetGachaExchangeDescDict()
	{
		return null;
	}

	public GachaDesc GetGachaDesc(uint chestID)
	{
		return null;
	}

	public GachaDesc GetSortedGachaDesc(int index)
	{
		return null;
	}

	public int FindGachaIdListIdx(uint chestID)
	{
		return 0;
	}

	public uint GetTokenGachaExchangeItemID(uint chestID)
	{
		return 0u;
	}

	public uint GetLimitPoolTokenItemID(uint chestID)
	{
		return 0u;
	}

	public List<uint> GetAllTokenGachaExchangeItemID()
	{
		return null;
	}

	public bool IsItemOwned(uint id)
	{
		return false;
	}

	public int CompareLotteryItem(GachaShowItem a, GachaShowItem b)
	{
		return 0;
	}

	private int CalcLotteryItemSortWeight(GachaShowItem item)
	{
		return 0;
	}

	private int GetLotteryItemSortTypeWeight(CSSharedItemData baseitem)
	{
		return 0;
	}

	public uint WeightTypeToEnergyStar(ELottery.WeightType type)
	{
		return 0u;
	}

	private void UpdateNotifies()
	{
	}

	public ClientChestType GetClientChestTypeByID(uint gachaID)
	{
		return null;
	}

	public bool GetGachaTipsByID(uint chestID)
	{
		return false;
	}

	public uint GetDoubleWheelMultiSpinCount(uint chestID)
	{
		return 0u;
	}

	public bool IsGachaFinished(uint chestID)
	{
		return false;
	}

	public bool IsMocoStoreFinished(uint chestID)
	{
		return false;
	}

	public bool IsFadedWheelFinished(uint chestID)
	{
		return false;
	}

	public bool IsDoubleWheelFinished(uint chestID)
	{
		return false;
	}

	public uint GetDoubleWheelGuaranteedDropSpins(uint chestID)
	{
		return 0u;
	}

	public bool IsGuaranteedDropActiveInDoubleWheel(uint chestID)
	{
		return false;
	}

	public bool IsSuperGrandPrizeById(uint chestID, uint showItemId)
	{
		return false;
	}

	public bool IsSuperGrandPrizeByItemId(uint chestID, uint itemId, uint count, uint duration)
	{
		return false;
	}

	public bool IsGainFirstSuperPrizeEarly(uint chestID, GachaResultInfo info, out GachaLuckyData data)
	{
		data = null;
		return false;
	}

	public bool IsGainFirstPrizeEarly(uint chestID, uint showItemId, GachaResultInfo info, out GachaLuckyData data)
	{
		data = null;
		return false;
	}

	public bool IsAccumulatedSuperPrizeMonthly(uint chestID, GachaResultInfo info, out GachaLuckyData data)
	{
		data = null;
		return false;
	}

	public bool IsMultiplePrizeAtOnce(uint chestID, GachaResultInfo info, out GachaLuckyData data)
	{
		data = null;
		return false;
	}

	public GachaLuckyData GetPriorityGachaLuckyDataExcludeMultiplePrize(uint chestID, GachaResultInfo info)
	{
		return null;
	}

	public string GetDefaultChestName(uint chestID, ELottery.Type type)
	{
		return null;
	}

	public string GetDefaultChestRule(uint chestID, ELottery.Type type)
	{
		return null;
	}

	public GachaRuleInfo GetGachaRuleInfo(uint chestID)
	{
		return null;
	}

	public bool IsItemNeedShowRemoved(uint chestID, uint id)
	{
		return false;
	}

	public bool IsItemNeedShowFinished(uint chestID, uint id, bool isDoubleWheelGrandPrize = false)
	{
		return false;
	}

	public bool IsItemNeedShowObtained(uint chestID, uint itemID, bool isDoubleWheelGrandPrize = false)
	{
		return false;
	}

	public bool IsItemNeedShowMax1(uint chestID, uint id)
	{
		return false;
	}

	public bool IsGuaranteedDropNeedShowHighlight(uint chestID, uint currentPoint, uint totalPoint)
	{
		return false;
	}

	public bool IsSupportMultiDraw(uint chestID)
	{
		return false;
	}

	private bool IsSupportMultiDraw(GachaInfoDataBase info)
	{
		return false;
	}

	public void AddMultiDrawLevel(uint chestID)
	{
	}

	public int GetMultiDrawLevel(uint chestID)
	{
		return 0;
	}

	public bool IsCurrentMultiDrawDiscountBest(uint chestID)
	{
		return false;
	}

	private void _003CRequestHackerStoreInfo_003Eb__94_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGachaDescRes_003Eb__171_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CProcessGachaDes_003Eb__172_1(uint idA, uint idB)
	{
		return 0;
	}

	private void _003CRequestGachaSpecialExchangeDesc_003Eb__175_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
