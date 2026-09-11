using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelIchis : UIBaseModel
{
	public enum PoolDataUpdateSource
	{
		Unknown,
		TcpDrawnItem,
		DrawResult,
		FullSync
	}

	public enum TcpProcessMode
	{
		Ignore,
		ProcessImmediately,
		CacheForLater
	}

	private struct IchisBarrageHistoryKey(uint poolVersion, long drawnTime, ulong accountId, uint uniqueId) : IEquatable<IchisBarrageHistoryKey>
	{
		private readonly uint m_PoolVersion = 0u;

		private readonly long m_DrawnTime = 0L;

		private readonly ulong m_AccountId = 0uL;

		private readonly uint m_UniqueId = 0u;

		public bool Equals(IchisBarrageHistoryKey other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}
	}

	private class IchisRewardSortData
	{
		public ExchangedAward award;

		public uint sourceItemId;

		public int tierWeight;

		public int rareWeight;

		public int originalIndex;
	}

	public enum ForceSwitchReason
	{
		None,
		PoolEmpty,
		GuaranteedEmpty
	}

	public enum EIchisDiscountType
	{
		None,
		Normal,
		Limit,
		Daily
	}

	public struct IchisDiscountResult
	{
		public bool IsValid;

		public EIchisDiscountType Type;

		public SharedGachaDiscountDesc Desc;

		public uint OriginalPrice;

		public uint DiscountPrice;

		public uint DiscountPercent;

		public uint UsedCount;

		public uint TotalCount;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<IchisSortableGoodsData> _003C_003E9__216_0;

		internal int _003CBuildSortedGoodsList_003Eb__216_0(IchisSortableGoodsData a, IchisSortableGoodsData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint chestId;

		public uint chestSubId;

		public PoolDataUpdateSource source;

		internal void _003CRequestGetSharedGachaInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint chestId;

		public uint chestSubId;

		public bool fromManualSwitchPopup;

		internal void _003CRequestSwitchSharedGachaPool_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIModelIchis _003C_003E4__this;

		public Action<CSGetSharedCachaHistoryRes> callback;

		internal void _003CRequestGetSharedGachaHistory_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint reqChestId;

		public uint reqChestSubId;

		public ELottery.LotteryType reqDrawType;

		public Action<bool> callback;

		internal void _003CRequestDrawSharedGacha_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass160_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint chestId;

		public uint chestSubId;

		internal int _003CProcessHistoryBarrages_003Eb__0(proto.SharedGachaHistoryInfo a, proto.SharedGachaHistoryInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint cChestId;

		public uint cChestSubId;

		public SharedGachaAccountChangeNtf cached;

		internal void _003COnAccountJoinNtf_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass94_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint cChestId;

		public uint cChestSubId;

		public SharedGachaAccountChangeNtf cached;

		internal void _003COnAccountLeaveNtf_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass95_0
	{
		public UIModelIchis _003C_003E4__this;

		public uint cChestId;

		public uint cChestSubId;

		public SharedGachaDrawnItemNtf cached;

		internal void _003COnDrawnItemNtf_003Eb__0()
		{
		}
	}

	public const uint PropID_PoolDataUpdate = 2u;

	public const uint PropID_PoolAccountUpdate = 4u;

	public const uint PropID_DrawResult = 8u;

	public const uint PropID_CollectProgress = 16u;

	public const uint PropID_SwitchPool = 32u;

	public const uint PropID_BarrageNew = 64u;

	public const uint PropID_StickerNew = 128u;

	public const uint PropID_DiscountRefresh = 256u;

	public const uint PropID_FreeDrawAvailable = 512u;

	public const uint PropID_SwitchQualification = 1024u;

	public const uint PropID_PoolEmpty = 2048u;

	public const uint PropID_GachaListLoaded = 4096u;

	public const uint PropID_OnlineCountUpdate = 8192u;

	public const uint PropID_HistoryRecordUpdate = 16384u;

	public const uint PropID_DrawFailed = 32768u;

	public const uint PropID_SwitchPoolFailed = 65536u;

	private Dictionary<uint, ClientChestType> m_TypeConfigMap;

	private Dictionary<uint, SharedGachaSettingDesc> m_SettingConfigMap;

	private Dictionary<uint, SharedGachaPriceDesc> m_PriceConfigMap;

	private Dictionary<uint, SharedGachaGoodsDesc> m_GoodsConfigMap;

	private Dictionary<uint, List<SharedGachaGoodsDesc>> m_GoodsListByJackPot;

	private Dictionary<uint, List<SharedGachaGoodsDesc>> m_GoodsListByChest;

	private Dictionary<uint, List<SharedGachaCollectRewardDesc>> m_CollectRewardMap;

	private Dictionary<uint, List<SharedGachaDiscountDesc>> m_DiscountMap;

	private Dictionary<uint, uint> m_ChestJackPotMap;

	private Dictionary<uint, SharedGachaAccountPoolInfo> m_AccountPoolInfoMap;

	private Dictionary<uint, HashSet<ulong>> m_PoolAccountSetMap;

	private static readonly HashSet<ulong> s_EmptyAccountSet;

	private Dictionary<uint, Dictionary<uint, uint>> m_PoolItemDrawnMapByChest;

	private Dictionary<uint, uint> m_PoolVersionMap;

	private Dictionary<uint, int> m_MultiDrawLevelMap;

	private Dictionary<uint, List<GachaRulesPopUpIchisRecordData>> m_HistoryRecordCacheMap;

	private Dictionary<uint, uint> m_HistoryCachePoolVersionMap;

	private List<ExchangedAward> m_LastDrawAwards;

	private ELottery.LotteryType m_LastDrawType;

	private proto.ESharedGacha.DrawStatus m_LastDrawStatus;

	private bool m_LastDrawNeedForceSwitch;

	private uint m_LastDrawRequestedCount;

	private uint m_LastDrawRequestedDiamondCost;

	private uint m_LastDrawRequestedCouponCost;

	private uint m_LastDrawRequestedCouponItemId;

	private uint[] m_LastDrawRequestedCouponItemIds;

	private uint m_LastDrawActualMoney;

	private uint m_LastDrawActualUniqueCount;

	private List<ExchangeItemNum> m_LastDrawActualExchangeItems;

	private uint[] m_LastDrawUniqueIds;

	private HashSet<uint> m_LastDrawPreOwnedItemIds;

	private HashSet<uint> m_LastDrawAllPreOwnedItemIds;

	private HashSet<uint> m_LastDrawCongratsItemIds;

	private const int BARRAGE_QUEUE_CAPACITY = 50;

	private Dictionary<uint, Queue<IchisBarrageData>> m_BarrageQueueMap;

	private Dictionary<uint, HashSet<IchisBarrageHistoryKey>> m_BarrageHistoryKeyMap;

	private Dictionary<uint, IchisStickerData> m_StickerMap;

	private Queue<Action> m_PendingUpdates;

	private bool m_IsIchisUIOnTop;

	private bool m_IsIchisInStack;

	private bool m_GachaListLoaded;

	private uint m_SelectedUniqueId;

	private bool m_IsRequestingList;

	private bool m_IsRequestingInfo;

	private bool m_IsRequestingSwitchPool;

	private bool m_IsRequestingOnlineCount;

	private bool m_IsRequestingDraw;

	private bool m_IsRequestingCollectReward;

	private uint m_FreeDrawDelayCallID;

	private HashSet<uint> m_CachedPoolInfoKeys;

	private HashSet<uint> m_FakePrimeBlockedPoolKeys;

	private Dictionary<uint, SharedGachaAccountPoolInfo> m_PrimeBlockedRealAssignmentBackup;

	private const int ONLINE_COUNT_INTERVAL_SEC = 300;

	private uint m_OnlineCount;

	private ulong[] m_OnlineAccountIds;

	private long m_LastOnlineCountTime;

	private bool m_IsRequestingHistory;

	public const string LOW_NUM_COLOR = "ff2222";

	private const float LOW_NUM_SCALE = 1.5f;

	private const int MAX_ITEMS_PER_ROW = 4;

	private const int MAX_MIXED_TIER_TOTAL = 3;

	private const int ICHIS55_MAX_A_IN_COMBINE_ROW = 4;

	private const string ICHIS_MULTI_BUY_LEVEL_KEY = "ICHIS_{0}_{1}_MULTI_BUY_LEVEL_{2}";

	public static readonly proto.ESharedGacha.RareType[] TierOrder;

	public static readonly proto.ESharedGacha.RareType[] HistoryTierOrder;

	private static readonly Dictionary<proto.ESharedGacha.RareType, string> s_TierLocKeyMap;

	private static readonly Dictionary<proto.ESharedGacha.RareType, string> s_TierStringMap;

	private uint m_PendingHistoryChestKey;

	public bool IsRequestingInfo => false;

	public bool IsRequestingSwitchPool => false;

	public bool IsRequestingDraw => false;

	public bool IsRequestingCollectReward => false;

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

	public void ClearAllData()
	{
	}

	public void SetIchisUIOnTop(bool onTop)
	{
	}

	public void SetIchisInStack(bool inStack)
	{
	}

	public void SetSelectedUniqueId(uint uniqueId)
	{
	}

	public uint GetSelectedUniqueId()
	{
		return 0u;
	}

	public TcpProcessMode ShouldProcessTcp()
	{
		return TcpProcessMode.Ignore;
	}

	public bool TryFindChestBySharedGachaId(ulong sharedGachaId, out uint chestId, out uint chestSubId)
	{
		chestId = default(uint);
		chestSubId = default(uint);
		return false;
	}

	public void OnAccountJoinNtf(SharedGachaAccountChangeNtf ntf)
	{
	}

	public void OnAccountLeaveNtf(SharedGachaAccountChangeNtf ntf)
	{
	}

	public void OnDrawnItemNtf(SharedGachaDrawnItemNtf ntf)
	{
	}

	private void ApplyAccountJoin(uint chestId, uint chestSubId, SharedGachaAccountChangeNtf ntf)
	{
	}

	private void ApplyAccountLeave(uint chestId, uint chestSubId, SharedGachaAccountChangeNtf ntf)
	{
	}

	private HashSet<ulong> GetOrCreateChestAccountSet(uint chestId, uint chestSubId)
	{
		return null;
	}

	private void UpdateCachedPoolAccountCount(uint chestId, uint chestSubId, uint count)
	{
	}

	private static void AddChangedUniqueId(ref HashSet<uint> changedUniqueIds, uint uniqueId)
	{
	}

	private static HashSet<uint> BuildChangedUniqueIdSet(uint[] uniqueIds)
	{
		return null;
	}

	private void NotifyPoolDataUpdate(HashSet<uint> changedUniqueIds, uint chestKey, PoolDataUpdateSource source)
	{
	}

	private void ApplyDrawnItem(uint chestId, uint chestSubId, SharedGachaDrawnItemNtf ntf)
	{
	}

	private uint GetPoolVersion(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	private void SetPoolVersion(uint chestId, uint chestSubId, uint poolVersion)
	{
	}

	private Dictionary<uint, uint> GetOrCreateDrawnMap(uint chestId, uint chestSubId)
	{
		return null;
	}

	private Dictionary<uint, uint> GetDrawnMapReadonly(uint chestId, uint chestSubId)
	{
		return null;
	}

	private void FlushPendingUpdates()
	{
	}

	public void RequestGetSharedGachaList(uint httpOption = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, bool sendImmediately = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public bool RequestGetSharedGachaInfo(uint chestId, uint chestSubId, uint poolVersion)
	{
		return false;
	}

	private bool RequestGetSharedGachaInfo(uint chestId, uint chestSubId, uint poolVersion, PoolDataUpdateSource source)
	{
		return false;
	}

	public void RequestSwitchSharedGachaPool(uint chestId, uint chestSubId, CSSwitchSharedGachaPoolReq.SwitchType switchType, bool fromManualSwitchPopup)
	{
	}

	public bool RequestGetSharedGachaHistory(ulong sharedGachaId, uint chestId, uint chestSubId, bool onlyOwner, Action<CSGetSharedCachaHistoryRes> callback)
	{
		return false;
	}

	public void RequestGetSharedGachaOnlineCount(uint chestId, uint chestSubId)
	{
	}

	public bool RequestSharedGachaCollectReward(uint chestId, uint chestSubId, uint rewardUniqueId)
	{
		return false;
	}

	public void RequestDrawSingle(uint chestId, uint chestSubId, ELottery.ExchangeItemGroupType exchangeGroup, proto.ESharedGacha.PurchaseType purchaseType, Action<bool> callback)
	{
	}

	public void RequestDrawMulti(uint chestId, uint chestSubId, ELottery.ExchangeItemGroupType exchangeGroup, proto.ESharedGacha.PurchaseType purchaseType, Action<bool> callback)
	{
	}

	private void ResolveDrawCoinAndMoney(uint chestId, uint chestSubId, ELottery.ExchangeItemGroupType exchangeGroup, UIModelGacha.GachaDrawType drawType, int multiLevel, proto.ESharedGacha.PurchaseType purchaseType, out ELottery.CoinType coinType, out uint money)
	{
		coinType = default(ELottery.CoinType);
		money = default(uint);
	}

	private static uint ExchangeGroupToExchangeType(ELottery.ExchangeItemGroupType exchangeGroup)
	{
		return 0u;
	}

	public void RequestDrawSharedGacha(uint chestId, uint chestSubId, int multiIndex, uint money, ELottery.CoinType coinType, ELottery.ExchangeItemGroupType exchangeGroup, ELottery.LotteryType drawType, proto.ESharedGacha.PurchaseType purchaseType, Action<bool> callback)
	{
	}

	private void CacheDrawRequestSnapshot(uint chestId, uint chestSubId, int multiIndex, ELottery.LotteryType drawType, ELottery.ExchangeItemGroupType exchangeGroup, proto.ESharedGacha.PurchaseType purchaseType, uint gemSentToServer)
	{
	}

	public uint GetLastDrawRequestedCount()
	{
		return 0u;
	}

	public uint GetLastDrawRequestedDiamondCost()
	{
		return 0u;
	}

	public uint GetLastDrawRequestedCouponCost()
	{
		return 0u;
	}

	public uint GetLastDrawRequestedCouponItemId()
	{
		return 0u;
	}

	public uint[] GetLastDrawRequestedCouponItemIds()
	{
		return null;
	}

	public uint GetLastDrawActualUniqueCount()
	{
		return 0u;
	}

	public uint GetLastDrawActualMoney()
	{
		return 0u;
	}

	public List<ExchangeItemNum> GetLastDrawActualExchangeItems()
	{
		return null;
	}

	private void CacheDrawPreOwnedSnapshot(uint chestId, uint chestSubId)
	{
	}

	private void CacheLastDrawCongratsItems(uint chestId, uint chestSubId, uint[] uniqueIds)
	{
	}

	public bool IsLastDrawPreOwnedItem(uint itemId)
	{
		return false;
	}

	public bool IsLastDrawCongratsItem(uint itemId)
	{
		return false;
	}

	public uint GetAwardSourceItemId(ExchangedAward award)
	{
		return 0u;
	}

	public List<ExchangedAward> SortLastDrawAwardsForRewardWnd(uint chestId, uint chestSubId, List<ExchangedAward> awards)
	{
		return null;
	}

	private int GetRewardTierWeight(uint chestId, uint chestSubId, uint sourceItemId)
	{
		return 0;
	}

	private int GetRewardRareWeight(uint sourceItemId)
	{
		return 0;
	}

	private int CompareIchisRewardSortData(IchisRewardSortData a, IchisRewardSortData b)
	{
		return 0;
	}

	private void ApplyDrawResultPoolInfo(uint chestId, uint chestSubId, CSDrawSharedGachaRes drawRes)
	{
	}

	public List<ExchangedAward> GetLastDrawAwards()
	{
		return null;
	}

	public ELottery.LotteryType GetLastDrawType()
	{
		return ELottery.LotteryType.LotteryType_NONE;
	}

	public proto.ESharedGacha.DrawStatus GetLastDrawStatus()
	{
		return proto.ESharedGacha.DrawStatus.DrawStatus_SUCCESS;
	}

	public bool IsLastDrawJackpot(uint chestId, uint chestSubId)
	{
		return false;
	}

	private static bool IsTierInJackpotSet(List<proto.ESharedGacha.RareType> jackpotTiers, proto.ESharedGacha.RareType tier)
	{
		return false;
	}

	public bool ShouldHighlightLowNum(uint chestId, uint chestSubId, proto.ESharedGacha.RareType tier, uint remaining, uint total)
	{
		return false;
	}

	public static string BuildRemainingCountText(int labelFontSize, string remainingText, uint total, bool highlightLowNum)
	{
		return null;
	}

	public bool IsAwardInJackpotSet(uint chestId, uint chestSubId, uint awardItemId)
	{
		return false;
	}

	public SharedGachaGoodsDesc GetGoodsByItemId(uint chestId, uint chestSubId, uint itemId)
	{
		return null;
	}

	public bool ShouldRefreshOnlineCount()
	{
		return false;
	}

	public ulong GetSharedGachaIdFor(uint chestId, uint chestSubId)
	{
		return 0uL;
	}

	public uint GetOnlineCount()
	{
		return 0u;
	}

	public ulong[] GetOnlineAccountIds()
	{
		return null;
	}

	private void ApplySharedGachaInfoResponse(uint chestId, uint chestSubId, SharedGachaAccountInfo accountInfo, SharedGachaPoolInfo poolInfo, List<proto.SharedGachaHistoryInfo> newHistorys, ulong[] accountIds, PoolDataUpdateSource source)
	{
	}

	private bool EnqueueOtherPlayerBarrages(uint chestId, uint chestSubId, SharedGachaDrawnItemNtf ntf)
	{
		return false;
	}

	private bool EnqueueBarrageData(uint chestId, uint chestSubId, ulong sharedGachaId, tcp.SharedGachaHistoryInfo history)
	{
		return false;
	}

	private bool ProcessHistoryBarrages(uint chestId, uint chestSubId, List<proto.SharedGachaHistoryInfo> historys, uint minPoolVersion)
	{
		return false;
	}

	private bool TryMarkBarrageHistoryQueued(uint chestId, uint chestSubId, uint poolVersion, long drawnTime, ulong accountId, uint uniqueId)
	{
		return false;
	}

	private Queue<IchisBarrageData> GetOrCreateBarrageQueue(uint chestId, uint chestSubId)
	{
		return null;
	}

	private void UpdateStickerData(uint uniqueId)
	{
	}

	public IchisBarrageData DequeueBarrage(uint chestId, uint chestSubId)
	{
		return null;
	}

	public bool HasPendingBarrage(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool HasPendingBarrage()
	{
		return false;
	}

	public List<IchisBarrageData> BuildLastSelfDrawBarrageData(uint chestId, uint chestSubId)
	{
		return null;
	}

	public bool EnqueueSelfDrawBarrageData(List<IchisBarrageData> barrageList)
	{
		return false;
	}

	public IchisStickerData GetAndClearSticker(uint uniqueId)
	{
		return null;
	}

	public ClientChestType GetTypeConfig(uint chestId, uint chestSubId)
	{
		return null;
	}

	public SharedGachaSettingDesc GetSettingConfig(uint chestId, uint chestSubId)
	{
		return null;
	}

	public SharedGachaPriceDesc GetPriceConfig(uint chestId, uint chestSubId)
	{
		return null;
	}

	public List<SharedGachaGoodsDesc> GetGoodsListByJackPot(uint jackPot)
	{
		return null;
	}

	public SharedGachaGoodsDesc GetGoodsByUniqueId(uint uniqueId)
	{
		return null;
	}

	public SharedGachaGoodsDesc GetGoodsByUniqueId(uint chestId, uint chestSubId, uint uniqueId)
	{
		return null;
	}

	public List<SharedGachaCollectRewardDesc> GetCollectRewards(uint chestId, uint chestSubId)
	{
		return null;
	}

	public List<SharedGachaDiscountDesc> GetDiscounts(uint chestId, uint chestSubId)
	{
		return null;
	}

	public uint GetChestJackPot(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public SharedGachaPoolInfo GetPoolInfo(uint chestId, uint chestSubId)
	{
		return null;
	}

	public SharedGachaAccountInfo GetAccountInfo(uint chestId, uint chestSubId)
	{
		return null;
	}

	public HashSet<ulong> GetPoolAccountSet(uint chestId, uint chestSubId)
	{
		return null;
	}

	public uint GetPoolAccountCount(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public bool IsGachaListLoaded()
	{
		return false;
	}

	public SharedGachaAccountPoolInfo GetAccountPoolInfo(uint chestId, uint chestSubId)
	{
		return null;
	}

	public bool HasPoolAssigned(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool HasPoolInfoCached(uint chestId, uint chestSubId)
	{
		return false;
	}

	public void InvalidateAllPoolInfoCache()
	{
	}

	public uint GetDrawnCount(uint chestId, uint chestSubId, uint uniqueId)
	{
		return 0u;
	}

	public bool IsItemOwned(uint chestId, uint chestSubId, uint uniqueId)
	{
		return false;
	}

	public bool IsItemFullyDrawn(uint chestId, uint chestSubId, uint uniqueId)
	{
		return false;
	}

	public int GetTierRemaining(uint chestId, uint chestSubId, proto.ESharedGacha.RareType tier)
	{
		return 0;
	}

	public int GetTierTotal(uint chestId, uint chestSubId, proto.ESharedGacha.RareType tier)
	{
		return 0;
	}

	public int GetJackpotRemaining(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public int GetJackpotTotal(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public int GetPoolRemaining(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public int GetPoolTotal(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public bool IsJackpotProbabilityRunningLow(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool IsJackpotProbabilityGood(uint chestId, uint chestSubId)
	{
		return false;
	}

	private static string MakeManualSwitchedPrefsKey(uint chestId, uint chestSubId)
	{
		return null;
	}

	public bool HasManualSwitchedPool(uint chestId, uint chestSubId)
	{
		return false;
	}

	public void MarkManualSwitchedPool(uint chestId, uint chestSubId)
	{
	}

	public bool HasSwitchQualification(uint chestId, uint chestSubId)
	{
		return false;
	}

	public CSSwitchSharedGachaPoolReq.SwitchType DetermineManualSwitchType(uint chestId, uint chestSubId)
	{
		return CSSwitchSharedGachaPoolReq.SwitchType.SwitchType_None;
	}

	public bool HasTcpEmptyPoolSwitchEntry(uint chestId, uint chestSubId)
	{
		return false;
	}

	public CSSwitchSharedGachaPoolReq.SwitchType DetermineTcpEmptyPoolSwitchType(uint chestId, uint chestSubId)
	{
		return CSSwitchSharedGachaPoolReq.SwitchType.SwitchType_None;
	}

	public static PoolDataUpdateSource GetPoolDataUpdateSource(object[] param)
	{
		return PoolDataUpdateSource.Unknown;
	}

	public bool IsFreeDrawAvailable(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool ShouldShowFreeDrawTag(uint chestId, uint chestSubId)
	{
		return false;
	}

	public proto.ESharedGacha.PurchaseType ResolvePurchaseType(uint chestId, uint chestSubId, UIGachaBuyBtnController.BuyBtnState state, UIModelGacha.GachaDrawType drawType)
	{
		return proto.ESharedGacha.PurchaseType.PurchaseType_NONE;
	}

	public ulong GetSwitchCooldownEndTime(uint chestId, uint chestSubId)
	{
		return 0uL;
	}

	private int GetUnownedTierRemaining(uint chestId, uint chestSubId, proto.ESharedGacha.RareType tier)
	{
		return 0;
	}

	public List<SharedGachaGoodsDesc> GetGoodsListByChest(uint chestId, uint chestSubId)
	{
		return null;
	}

	public static int TierToWeight(proto.ESharedGacha.RareType tier)
	{
		return 0;
	}

	public static BarrageTier GetBarrageLevelByTier(proto.ESharedGacha.RareType tier)
	{
		return BarrageTier.None;
	}

	public List<IchisSortableGoodsData> BuildSortedGoodsList(uint chestId, uint chestSubId, uint jackPot)
	{
		return null;
	}

	private List<IchisSortableGoodsData> BuildSortedGoodsList(uint chestId, uint chestSubId, uint jackPot, bool forceFullPool, int transitionFakePoolIndex)
	{
		return null;
	}

	private void ApplyTransitionFakePoolVariant(List<IchisSortableGoodsData> sortedGoods, int transitionFakePoolIndex)
	{
	}

	private void ApplyTransitionFakeRemainingVariant(List<IchisSortableGoodsData> sortedGoods, int transitionFakePoolIndex)
	{
	}

	private void RotateTransitionFakeTier(List<IchisSortableGoodsData> sortedGoods, proto.ESharedGacha.RareType tier, int transitionFakePoolIndex)
	{
	}

	public List<IchisTableRowData> BuildTableRowLayout(uint chestId, uint chestSubId, uint jackPot)
	{
		return null;
	}

	private List<IchisTableRowData> BuildTableRowLayoutFromSortedGoods(uint chestId, uint chestSubId, List<IchisSortableGoodsData> sortedGoods, bool isTransitionFakePool)
	{
		return null;
	}

	private Dictionary<int, List<IchisSortableGoodsData>> GroupByTierWeight(List<IchisSortableGoodsData> sortedGoods)
	{
		return null;
	}

	private void BuildSTierRows(Dictionary<int, List<IchisSortableGoodsData>> tierGroups, List<IchisTableRowData> rowList, uint chestId, uint chestSubId)
	{
	}

	private void BuildNonSTierRows(Dictionary<int, List<IchisSortableGoodsData>> tierGroups, List<IchisTableRowData> rowList)
	{
	}

	private void FlushPendingRow(List<IchisSortableGoodsData> items, proto.ESharedGacha.RareType primaryTier, List<IchisTableRowData> rowList)
	{
	}

	public List<IchisTableRowData> BuildIchis55CustomTableRowLayout(uint chestId, uint chestSubId, uint jackPot)
	{
		return null;
	}

	private List<IchisTableRowData> BuildIchis55CustomTableRowLayoutFromSortedGoods(uint chestId, uint chestSubId, List<IchisSortableGoodsData> sortedGoods, bool isTransitionFakePool)
	{
		return null;
	}

	public IchisTransitionPoolDisplayData BuildPrimeFullTransitionPoolDisplayData(uint chestId, uint chestSubId, uint jackPot, bool useIchis55Layout)
	{
		return null;
	}

	public IchisTransitionPoolDisplayData BuildPrimeFullTransitionPoolDisplayData(uint chestId, uint chestSubId, uint jackPot, bool useIchis55Layout, int transitionFakePoolIndex)
	{
		return null;
	}

	public IchisTransitionPoolDisplayData BuildPrimeFullTransitionPoolDisplayData(uint chestId, uint chestSubId, uint jackPot, bool useIchis55Layout, bool allowPrizePoolScroll, bool allowPreviewClick)
	{
		return null;
	}

	public IchisTransitionPoolDisplayData BuildPrimeFullTransitionPoolDisplayData(uint chestId, uint chestSubId, uint jackPot, bool useIchis55Layout, int transitionFakePoolIndex, bool allowPrizePoolScroll, bool allowPreviewClick)
	{
		return null;
	}

	private void ApplyFakePoolInteractionFlags(List<IchisTableRowData> rows, bool allowPreviewClick)
	{
	}

	private void ApplyPreviewClickDisabled(List<IchisSortableGoodsData> items, bool disablePreviewClick)
	{
	}

	private void ApplyTransitionFakeRowVariant(List<IchisTableRowData> rows, int transitionFakePoolIndex)
	{
	}

	private void ApplyRowContext(List<IchisTableRowData> rowList, uint chestId, uint chestSubId, bool isTransitionFakePool)
	{
	}

	private void ApplyTransitionFakeFlag(List<IchisSortableGoodsData> items, bool isTransitionFakePool)
	{
	}

	private void CalculateTransitionPoolTotals(List<IchisSortableGoodsData> sortedGoods, out int totalRemaining, out int totalCapacity)
	{
		totalRemaining = default(int);
		totalCapacity = default(int);
	}

	private void BuildIchis55CombineRow(Dictionary<int, List<IchisSortableGoodsData>> tierGroups, List<IchisTableRowData> rowList, uint chestId, uint chestSubId)
	{
	}

	private void BuildIchis55BCDRows(Dictionary<int, List<IchisSortableGoodsData>> tierGroups, List<IchisTableRowData> rowList)
	{
	}

	public void RegisterTypeConfig(uint chestId, uint chestSubId, ClientChestType config)
	{
	}

	public void RegisterSettingConfig(uint chestId, uint chestSubId, SharedGachaSettingDesc config)
	{
	}

	public void RegisterPriceConfig(uint chestId, uint chestSubId, SharedGachaPriceDesc config)
	{
	}

	public void RegisterGoodsConfig(uint chestId, uint chestSubId, SharedGachaGoodsDesc config)
	{
	}

	public void RegisterCollectReward(uint chestId, uint chestSubId, SharedGachaCollectRewardDesc config)
	{
	}

	public void RegisterDiscountConfig(uint chestId, uint chestSubId, SharedGachaDiscountDesc config)
	{
	}

	public void RegisterChestJackPot(uint chestId, uint chestSubId, uint jackPot)
	{
	}

	public void ClearConfigData()
	{
	}

	public void ProcessGachaDesc(GachaDesc gachaDesc)
	{
	}

	public bool HasRedDot(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool HasFreeDrawRedDot(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool HasFreeDrawRedDot(uint chestId, uint chestSubId, bool optimisticWhenUnloaded)
	{
		return false;
	}

	private void RefreshFreeDrawDelayCall()
	{
	}

	private void NotifyGachaFreeLotteryChanged()
	{
	}

	public bool HasAnyIchisCollectionRewardClaimable()
	{
		return false;
	}

	public bool IsIchisCollectionRewardClaimable(uint chestId, uint chestSubId)
	{
		return false;
	}

	private bool AreAllCollectRewardRequirementsOwned(uint[] reqItemIds)
	{
		return false;
	}

	public bool IsIchisChestCustom(uint chestId, uint chestSubId)
	{
		return false;
	}

	private bool IsCollectRewardOwned(SharedGachaCollectRewardDesc reward)
	{
		return false;
	}

	public bool ShouldTabSinkToBottom(uint chestId, uint chestSubId)
	{
		return false;
	}

	private bool AreAllGuaranteedRewardsOwned(uint chestId, uint chestSubId)
	{
		return false;
	}

	private bool AreAllCollectRewardsOwned(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool IsInPrimeEarlyPeriod(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool ShouldAssignPool(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool IsPrimeAccessActive(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool IsPrimeBlockedForPlayer(uint chestId, uint chestSubId)
	{
		return false;
	}

	public void EnsurePrimeBlockedFakePool(uint chestId, uint chestSubId)
	{
	}

	public bool IsPrimeBlockedFakePool(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool ClearPrimeBlockedFakePoolIfNeeded(uint chestId, uint chestSubId)
	{
		return false;
	}

	private static bool HasRealAccountInfo(SharedGachaAccountPoolInfo info)
	{
		return false;
	}

	private static bool HasRealPoolInfo(SharedGachaAccountPoolInfo info)
	{
		return false;
	}

	private static bool HasCompleteRealPoolInfo(SharedGachaAccountPoolInfo info)
	{
		return false;
	}

	private void ClearFakePrimeBlockedMarkIfReal(uint key, SharedGachaAccountInfo accountInfo, SharedGachaPoolInfo poolInfo)
	{
	}

	private void ClearFakePrimeBlockedRuntimeCache(uint key)
	{
	}

	private void ClearFakeHalfPoolInfo(uint key, SharedGachaAccountPoolInfo info)
	{
	}

	public bool AreAllGuaranteedItemsGone(uint chestId, uint chestSubId)
	{
		return false;
	}

	private static bool IsTierInGuaranteeSet(List<proto.ESharedGacha.RareType> tiers, proto.ESharedGacha.RareType tier)
	{
		return false;
	}

	public bool IsGuaranteedConfigured(uint chestId, uint chestSubId)
	{
		return false;
	}

	public uint GetGuaranteedPityCount(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public uint GetPityProgress(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public bool IsGuaranteedActive(uint chestId, uint chestSubId)
	{
		return false;
	}

	public bool IsPoolAllDrawn(uint chestId, uint chestSubId)
	{
		return false;
	}

	public ForceSwitchReason GetForceSwitchReason(uint chestId, uint chestSubId)
	{
		return ForceSwitchReason.None;
	}

	public bool ShouldHideContinueDraw(uint chestId, uint chestSubId)
	{
		return false;
	}

	public int GetMultiDrawLevel(uint chestId, uint chestSubId)
	{
		return 0;
	}

	private void SetMultiDrawLevel(uint chestId, uint chestSubId, int level)
	{
	}

	public bool IsSupportMultiDraw(uint chestId, uint chestSubId)
	{
		return false;
	}

	public int GetMultiDrawMaxLevel(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public void InitMultiDrawLevel(uint chestId, uint chestSubId)
	{
	}

	public void CycleMultiDrawLevel(uint chestId, uint chestSubId)
	{
	}

	public void SelectMultiDrawLevel(uint chestId, uint chestSubId, int level)
	{
	}

	public ChestMultiPrice GetMultiPriceAt(uint chestId, uint chestSubId, int level)
	{
		return null;
	}

	public bool IsInIchisDiscountPeriod(uint chestId, uint chestSubId)
	{
		return false;
	}

	public uint GetMultiDiscountPriceAt(uint chestId, uint chestSubId, int level)
	{
		return 0u;
	}

	public uint GetSingleDiscountPrice(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public IchisDiscountResult ResolveActiveDiscount(uint chestId, uint chestSubId, UIModelGacha.GachaDrawType drawType, int level)
	{
		return default(IchisDiscountResult);
	}

	private static bool IsInDiscountWindow(SharedGachaDiscountDesc desc, ulong now)
	{
		return false;
	}

	private static uint GetDiscountUsedCount(SharedGachaAccountInfo info, UIModelGacha.GachaDrawType drawType, int level)
	{
		return 0u;
	}

	private uint GetOriginalPriceFor(uint chestId, uint chestSubId, UIModelGacha.GachaDrawType drawType, int level)
	{
		return 0u;
	}

	private static uint[] GetDiscountPriceArray(SharedGachaDiscountDesc desc, UIModelGacha.GachaDrawType drawType, int level)
	{
		return null;
	}

	private static bool TryFillDiscountResult(SharedGachaDiscountDesc desc, UIModelGacha.GachaDrawType drawType, int level, uint used, uint origin, ref IchisDiscountResult result)
	{
		return false;
	}

	public bool HasUnconsumedTieredDiscount(uint chestId, uint chestSubId, UIModelGacha.GachaDrawType drawType, int level)
	{
		return false;
	}

	public bool GetMixedCouponPriceAt(uint chestId, uint chestSubId, int level, uint gachaId, uint exchangeType, out uint couponConsumeCnt, out uint price)
	{
		couponConsumeCnt = default(uint);
		price = default(uint);
		return false;
	}

	public bool GetMixedCouponPriceAt(uint chestId, uint chestSubId, int level, uint gachaId, uint exchangeType, out uint couponConsumeCnt, out uint originalPrice, out uint discountPrice)
	{
		couponConsumeCnt = default(uint);
		originalPrice = default(uint);
		discountPrice = default(uint);
		return false;
	}

	public int GetNextMultiDrawLevel(uint chestId, uint chestSubId)
	{
		return 0;
	}

	public uint GetMultiDrawCount(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public uint GetMultiDrawPrice(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public bool IsNextDrawCountGreater(uint chestId, uint chestSubId)
	{
		return false;
	}

	public uint GetOncePrice(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public static string GetTierString(proto.ESharedGacha.RareType rareType)
	{
		return null;
	}

	public static string GetTierLocKey(proto.ESharedGacha.RareType rareType)
	{
		return null;
	}

	public string GetGuaranteedTierDisplay(uint chestId, uint chestSubId)
	{
		return null;
	}

	public static string GetTierDisplayName(proto.ESharedGacha.RareType rareType)
	{
		return null;
	}

	public List<GachaRulesPopUpIchisRecordData> GetHistoryRecords(uint chestId, uint chestSubId)
	{
		return null;
	}

	public bool RequestHistoryRecords(uint chestId, uint chestSubId)
	{
		return false;
	}

	private void OnHistoryResponseForCache(CSGetSharedCachaHistoryRes response)
	{
	}

	private void OnHistoryPlayerNamesLoaded(List<AccountInfoBasic> accountInfos)
	{
	}

	private void ClearAllPoolData()
	{
	}

	private void ClearCurrentPoolData()
	{
	}

	public static uint MakeChestKey(uint chestId, uint chestSubId)
	{
		return 0u;
	}

	public static string GetQualityFrameSpriteName(uint quality)
	{
		return null;
	}

	public static string GetIchis55QualityFrameSpriteName(uint quality)
	{
		return null;
	}

	public static bool IsQualityPlus(uint quality)
	{
		return false;
	}

	public static string GetQualityPlusSpriteName(uint quality)
	{
		return null;
	}

	public static string GetIchis55QualityPlusSpriteName(uint quality)
	{
		return null;
	}

	private void _003CRequestGetSharedGachaList_003Eb__109_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetSharedGachaOnlineCount_003Eb__115_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSharedGachaCollectReward_003Eb__116_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRefreshFreeDrawDelayCall_003Eb__255_0()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
