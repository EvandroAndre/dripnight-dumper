using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelFlashStore : UIBaseModel
{
	public enum FlashStoreState
	{
		Unknown,
		Pre,
		Open,
		Closed
	}

	public enum EFlashStoreItemPriceState
	{
		FLASH_GEMS_ONLY,
		FLASH_GEMS_AND_GEMS,
		GEMS_ONLY
	}

	public enum ECurrentSelectItemAvailableState
	{
		NO_FLASHGEMS_NO_GEMS,
		NO_FLASHGEMS_HAS_GEMS,
		HAS_FLASHGEMS_NO_GEMS,
		HAS_FLASHGEMS_HAS_GEMS
	}

	public enum UILimitedStoreTabType
	{
		MallTabTypeRecommend,
		MallTabTypeFashion,
		MallTabTypeWeapon,
		MallTabTypeCharacter,
		MallTabTypePet,
		MallTabTypeCollection,
		MallTabTypeOther,
		Capacity
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, FlashStoreTabData> _003C_003E9__64_0;

		internal FlashStoreTabData _003CLoadFlashStoreTabCSV_003Eb__64_0(CSVBaseData input)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIModelFlashStore _003C_003E4__this;

		public bool requestInfoAfter;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestFlashStoreDesc_003Eb__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public FlashStoreGoodsDesc flashStoreItem;

		public UIModelFlashStore _003C_003E4__this;

		public uint count;

		internal void _003CRequestFlashStorePurchase_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_FlashStoreReady = 1u;

	public const uint PropID_FlashStoreDescUpdate = 2u;

	public const uint PropID_FlashStorePurchaseInfoUpdate = 4u;

	public const uint PropID_FlashStoreItemPurchaseSuccess = 8u;

	private const byte STEP1_READY = 1;

	private const byte STEP2_READY = 2;

	private const byte ALL_STEP_READY = 3;

	private byte m_ReadyFlag;

	private float m_FlashStoreDescRequestGameTime;

	private FlashStoreDesc m_FlashStoreDesc;

	private readonly List<FlashStoreGoodsDesc> m_FlashStoreGoodsDescList;

	private readonly Dictionary<uint, List<FlashStoreGoodsDesc>> m_FlashStoreItemsDict;

	private readonly Dictionary<uint, AccountFlashStorePurchase> m_FlashStorePurchaseInfoDict;

	private readonly List<FlashStoreTabData> m_FlashStoreTabDataList;

	private bool IsReady => false;

	private byte ReadyFlag
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void RequestFlashStoreDesc(bool silence = true, bool requestInfoAfter = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestFlashStoreDescAfterCertainTime(bool silence = true, bool forceReq = false, float cooldown = 0f)
	{
	}

	private void OnRequestFlashStoreDescFinished(HttpErrorCode errorCode, object result, bool requestInfoAfter, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void RequestFlashStoreInfo(bool silence = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private void OnRequestFlashStoreInfoFinished(HttpErrorCode errorCode, object result)
	{
	}

	public void RequestFlashStorePurchase(uint flashStoreActivityID, FlashStoreGoodsDesc flashStoreItem, uint count = 1u, bool silence = true)
	{
	}

	public bool ResendRequestIfPreviousFailed(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
		return false;
	}

	private bool IsFlashStoreActivityMatched(uint flashActivityID)
	{
		return false;
	}

	private bool IsGroupInFlashStoreActivityInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return false;
	}

	private bool IsActivityGroupOpenInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return false;
	}

	private FlashStoreState GetFlashStoreStateInternal(uint flashStoreActivityID)
	{
		return FlashStoreState.Unknown;
	}

	private uint GetCurrentFlashStoreActivityIDInternal()
	{
		return 0u;
	}

	private uint GetFlashStoreIDInternal(uint flashStoreActivityID)
	{
		return 0u;
	}

	private uint GetFlashGemIDInternal(uint flashStoreActivityID)
	{
		return 0u;
	}

	private uint[] GetActivityGroupIDArrayInternal(uint flashStoreActivityID)
	{
		return null;
	}

	private uint GetGroupTotalFlashGemAmountInternal(uint flashStoreActivityID, uint activityGroupID)
	{
		return 0u;
	}

	public bool IsSystemAvailable()
	{
		return false;
	}

	public bool IsAnyActivityGroupOpen(uint flashStoreActivityID)
	{
		return false;
	}

	public bool IsActivityGroupOpen(uint flashStoreActivityID, uint activityGroupID)
	{
		return false;
	}

	public ulong GetFlashStoreStartTime(uint flashStoreActivityID)
	{
		return 0uL;
	}

	public ulong GetFlashStoreEndTime(uint flashStoreActivityID)
	{
		return 0uL;
	}

	public static List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
	{
		return null;
	}

	public uint GetCurrentFlashGemsCnt(uint flashStoreActivityID)
	{
		return 0u;
	}

	public uint GetCurrentFlashStoreActivityID()
	{
		return 0u;
	}

	public FlashStoreState GetFlashStoreState(uint flashStoreActivityID)
	{
		return FlashStoreState.Unknown;
	}

	public uint GetFlashGemID(uint flashStoreActivityID)
	{
		return 0u;
	}

	public string GetActivityTitleTextureURL(uint flashStoreActivityID)
	{
		return null;
	}

	public string GetStoreTitleTextureURL(uint flashStoreActivityID)
	{
		return null;
	}

	public uint GetTotalFlashGemAmount(uint flashStoreActivityID)
	{
		return 0u;
	}

	public uint GetFlashStoreCurrentActivityGroup(uint flashStoreActivityID)
	{
		return 0u;
	}

	public uint GetGemsReplenishNeedCnt(uint flashStoreActivityID, FlashStoreGoodsDesc flashStoreItem, uint count = 1u)
	{
		return 0u;
	}

	public uint GetGemsShortageCnt(uint flashStoreActivityid, FlashStoreGoodsDesc flashStoreItem, bool includeReplenishCnt = false, uint count = 1u)
	{
		return 0u;
	}

	public uint[] GetActivityGroupIDArray(uint flashStoreActivityID)
	{
		return null;
	}

	public uint[] GetAllFinishedActivities(uint flashStoreActivityID)
	{
		return null;
	}

	public uint GetGroupFlashGemAmount(uint flashStoreActivityID, uint activityGroupID)
	{
		return 0u;
	}

	public ulong GetGroupStartTimestamp(uint flashStoreActivityID, uint activityGroupID)
	{
		return 0uL;
	}

	public ulong GetGroupEndTimestamp(uint flashStoreActivityID, uint activityGroupID)
	{
		return 0uL;
	}

	public List<FlashStoreTabData> LoadFlashStoreTabCSV()
	{
		return null;
	}

	public List<FlashStoreGoodsDesc> GetFlashStoreItemListByTabType(UILimitedStoreTabType tabType)
	{
		return null;
	}

	public List<FlashStoreGoodsDesc> GetFlashStoreItemListByTabType(uint mallTabType)
	{
		return null;
	}

	public FlashStoreGoodsDesc GetFlashStoreItemByItemID(uint flashStoreActivityID, uint itemID)
	{
		return null;
	}

	public bool IsFlashStoreItemsDictKeyValid(uint key)
	{
		return false;
	}

	public static UILimitedStoreTabType GetItemtype2MallType(uint itemType, uint subType = 0u)
	{
		return UILimitedStoreTabType.MallTabTypeRecommend;
	}

	public static UILimitedStoreTabType GetItemtype2MallType(CSSharedItemDataManager.ItemType itemType, CSSharedItemDataManager.CollectionSubType subType = CSSharedItemDataManager.CollectionSubType.NOTCOLLECTION)
	{
		return UILimitedStoreTabType.MallTabTypeRecommend;
	}

	public void ProcessTypeOverrideItemAndAddToDict(FlashStoreGoodsDesc item)
	{
	}

	public uint GetItemCurrentPurchaseTime(FlashStoreGoodsDesc itemData)
	{
		return 0u;
	}

	public bool IsHavePurchaseTime(FlashStoreGoodsDesc itemData)
	{
		return false;
	}

	public ECurrentSelectItemAvailableState GetItemAvailableState(FlashStoreGoodsDesc desc, EFlashStoreItemPriceState priceState, int purchaseCnt = 1)
	{
		return ECurrentSelectItemAvailableState.NO_FLASHGEMS_NO_GEMS;
	}

	public static EFlashStoreItemPriceState GetItemPriceState(FlashStoreGoodsDesc item)
	{
		return EFlashStoreItemPriceState.FLASH_GEMS_ONLY;
	}

	public int SortLimitedStoreItem(FlashStoreGoodsDesc x, FlashStoreGoodsDesc y)
	{
		return 0;
	}

	public void AddItemToDict(FlashStoreGoodsDesc item, UILimitedStoreTabType tabType)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
