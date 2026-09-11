using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelGift : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public HashSet<ulong> requestSet;

		public ulong accountID;

		public HashSet<uint> itemSet;

		public bool isPrime;

		public UIModelGift _003C_003E4__this;

		internal void _003CRequestOwnedGiftList_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public HashSet<ulong> failedReceiversSet;

		internal bool _003CSetGiftItemOwnedAfterSendSuccess_003Eb__0(ulong x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UIModelGift _003C_003E4__this;

		public bool force;

		internal void _003CGetGiftStoreDetails_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public UIModelGift _003C_003E4__this;

		public FriendInfo receiverInfo;

		public GiftItem item;

		internal void _003CSendGift_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public UIModelGift _003C_003E4__this;

		public PrimeStoreItemDesc item;

		public FriendInfo receiverInfo;

		internal void _003CSendPrimeGift_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public uint itemID;

		internal bool _003CFindGiftItemByBaseItemIdExculdeBundleAndBox_003Eb__0(GiftItem o)
		{
			return false;
		}
	}

	public const uint PropID_UpdateGiftStore = 2u;

	public const uint PropID_UpdateGiftStoreDetails = 4u;

	public const uint PropID_SendGift = 8u;

	public const uint PropID_GetGiftRankDesc = 16u;

	public const uint PropID_GetGiftRankRewardInfo = 32u;

	public const uint PropID_GetGiftRankRewardSuccess = 64u;

	public const uint PropID_SendPrimeGift = 128u;

	public const uint PropID_OwnedGiftListReady = 256u;

	private uint m_SendGiftTimeToday;

	private uint m_SendPrimeTimeToday;

	private List<FriendInfo> m_AllSelectedList;

	private UIModelUser m_ModelUser;

	private GiftStoreInfo _003CGiftStore_003Ek__BackingField;

	private CSGetGiftStoreDetailsRes _003CGiftStoreDetails_003Ek__BackingField;

	private static uint PrimeStoreMaxSendFriendNum;

	private List<GiftItem> m_GiftItemsList;

	private Dictionary<uint, List<GiftRewardDesc>> m_GiftRewardsList;

	private ClientGiftRankDesc m_GiftRankDesc;

	private CSGetGiftRankRewardInfoRes m_GiftRankRewardInfoRes;

	private float m_LastUpdateGiftStoreResTime;

	private float m_LastUpdateGiftStoreDetailResTime;

	private float m_LastUpdateGiftRankResTime;

	private float m_GetGiftStoreResCoolDown;

	private List<uint> m_sortFirstTabList;

	private IntimacyPointsData m_IntimacyPointData;

	private Dictionary<uint, List<uint>> m_dicFirstTabData;

	private Dictionary<uint, List<GiftItem>> m_dicSecondTabData;

	private UIModelMall m_ModelMall;

	private UIModelStoreBox m_ModelStoreBox;

	private Dictionary<uint, uint> m_dicIntimacyOverrideDataDic;

	private List<ReceiveGiftNTF> m_CacheReceiveGiftNtf;

	private List<GiftItem> m_WishListGiftItems;

	private HashSet<uint> m_WishListItemID;

	private HashSet<uint> m_OwnedItemID;

	private HashSet<uint> m_OwnedPrimeItemID;

	private Dictionary<ulong, uint> m_AccountIDToOwnedItemTimeStampDic;

	private HashSet<ulong> m_RequestingOwnedDataAccountIDSet;

	private Dictionary<ulong, uint> m_AccountIDToOwnedPrimeItemTimeStampDic;

	private HashSet<ulong> m_RequestingPrimeOwnedDataAccountIDSet;

	private Dictionary<ulong, List<GiftItem>> m_AccountIDToWishListGiftItemListDic;

	private Dictionary<ulong, HashSet<uint>> m_AccountIDToWishListItemIDDic;

	private Dictionary<ulong, HashSet<uint>> m_AccountIDToOwnedItemIDSetDic;

	private Dictionary<ulong, HashSet<uint>> m_AccountIDToOwnedPrimeItemIDSetDic;

	private Dictionary<uint, string> m_DicGiftStoreCDNNameToUrl;

	public uint SendGiftTimeToday => 0u;

	public uint SendPrimeGiftTimeToday => 0u;

	public List<FriendInfo> AllSelectedList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private UIModelUser ModelUser => null;

	public GiftStoreInfo GiftStore
	{
		get
		{
			return _003CGiftStore_003Ek__BackingField;
		}
		private set
		{
			_003CGiftStore_003Ek__BackingField = value;
		}
	}

	public CSGetGiftStoreDetailsRes GiftStoreDetails
	{
		get
		{
			return _003CGiftStoreDetails_003Ek__BackingField;
		}
		private set
		{
			_003CGiftStoreDetails_003Ek__BackingField = value;
		}
	}

	public List<GiftItem> GiftItemsList => null;

	public Dictionary<uint, List<GiftRewardDesc>> GiftRewardsList => null;

	public ClientGiftRankDesc GiftRankDesc => null;

	public CSGetGiftRankRewardInfoRes GiftRankRewardInfoRes => null;

	public List<uint> SortFirstTabList => null;

	public Dictionary<uint, List<uint>> FirstTabDataDic => null;

	public Dictionary<uint, List<GiftItem>> SecondTabDataDic => null;

	public UIModelMall ModelMall => null;

	private UIModelStoreBox ModelStoreBox => null;

	public IntimacyPointsData IntimacyPointsData => null;

	public List<GiftItem> WishListGiftItems => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public void GetGiftStore(bool force = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1)
	{
	}

	public void ProcessGiftStore(CSGetGiftStoreRes giftStoreRes, bool notify = true)
	{
	}

	public void GetGiftStoreDetails(bool force = false, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, int urgentAfterIndex = -1)
	{
	}

	public void ProcessGiftStoreDetail(CSGetGiftStoreDetailsRes res, bool force)
	{
	}

	public bool IsGiftStoreShow()
	{
		return false;
	}

	public void SendGift(FriendInfo receiverInfo, EGiftStore_BuddyType buddyType, string message, uint commodityID, proto.EInventory.CurrencyType currencyType = proto.EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u, EGiftSendSource source = EGiftSendSource.None, uint price = 0u)
	{
	}

	public void SendPrimeGift(FriendInfo receiverInfo, EGiftStore_BuddyType buddyType, string message, uint commodityID, uint count = 1u, EGiftSendSource source = EGiftSendSource.None, uint price = 0u, uint voucher_id = 0u)
	{
	}

	private void RefreshGiftRes()
	{
	}

	public bool CheckCurrencyStock(GiftItem item, uint itemCount, proto.EInventory.CurrencyType currencyType, uint voucherID)
	{
		return false;
	}

	public bool CheckCurrencyStock(PrimeStoreItemDesc item, uint itemCount, uint voucher_id)
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	public GiftItem FindGiftItemByBaseItemIdExculdeBundleAndBox(uint itemID)
	{
		return null;
	}

	public bool IsShowDiscountTag(GiftItem desc)
	{
		return false;
	}

	public GiftItem FindGiftItemByCommodityID(uint commodityID)
	{
		return null;
	}

	public int SortGiftItem(GiftItem a, GiftItem b)
	{
		return 0;
	}

	public void CheckSendGiftCondition(FriendInfo info)
	{
	}

	public uint GetIntimacyOverrideValue(uint id)
	{
		return 0u;
	}

	public uint GetIntimacyValue(GiftItem giftItem, uint count = 1u, bool isPrime = false)
	{
		return 0u;
	}

	public List<uint> GetSecondTabListByTabId(uint tabId)
	{
		return null;
	}

	public void OnGetStoreResV2(CSGetGiftStoreDetailsRes res, bool force)
	{
	}

	private void UpdateItemsDictV2(GiftItem item)
	{
	}

	private void AddItemToDictV2(uint mallSubType, GiftItem item)
	{
	}

	public uint GetSecondTabIdByItemId(ref uint itemId)
	{
		return 0u;
	}

	public GiftItem FindGiftItemByCommodityOrItemID(ref uint id)
	{
		return null;
	}

	public GiftItem FindGiftItemByCommodityOrItemID(uint secondTabId, ref uint id)
	{
		return null;
	}

	private UINavigationUtil.UINavigationMallV2SubTabType GetSecondTabByItem(CSSharedItemData itemData)
	{
		return UINavigationUtil.UINavigationMallV2SubTabType.None;
	}

	public void ReloadGiftFirstTabList()
	{
	}

	public void LoadIntimacyPointData()
	{
	}

	public void ProcessIntimacyOverride(CSGetAllFriendDescRes desc)
	{
	}

	public void RequestOwnedGiftList(ulong accountID, bool isPrime)
	{
	}

	public void RequestGiftSenderInfo(ulong senderAccountID)
	{
	}

	public void ClearSelectedAccountID()
	{
	}

	public void SetSelectedAccountID(ulong accountID)
	{
	}

	public void SetWishListGiftItems(ulong accountID)
	{
	}

	public void SetGiftItemOwnedAfterSendSuccess(ulong[] receivers, ulong[] failedReceivers, uint commodityID, bool isPrime)
	{
	}

	public bool IsGiftItemInWishList(GiftItem item)
	{
		return false;
	}

	public bool IsGiftItemInWishList(PrimeStoreItemDesc item)
	{
		return false;
	}

	public bool IsGiftItemInWishList(uint itemId)
	{
		return false;
	}

	public bool IsGiftItemOwned(GiftItem item)
	{
		return false;
	}

	public bool IsGiftItemOwned(PrimeStoreItemDesc item)
	{
		return false;
	}

	public bool IsGiftItemOwned(uint itemId, bool isPrime = false)
	{
		return false;
	}

	private bool CheckIsOwnedInvisbleSkill(uint itemId, bool isPrime)
	{
		return false;
	}

	public bool HasCacheReceiveGiftNtf()
	{
		return false;
	}

	public void AddCacheRecieveGiftNtf(ReceiveGiftNTF ntf)
	{
	}

	public List<ReceiveGiftNTF> GetCacheReceiveGiftNtf()
	{
		return null;
	}

	public void ConvertGiftCDNToDictionary(GiftStoreCDNDesc desc)
	{
	}

	public string GetGiftCDNUrl(GiftCDNKey key)
	{
		return null;
	}

	private void _003CGetGiftStore_003Eb__47_0(HttpErrorCode errorCode, object res)
	{
	}

	private int _003CReloadGiftFirstTabList_003Eb__108_0(uint x, uint y)
	{
		return 0;
	}

	private int _003CReloadGiftFirstTabList_003Eb__108_1(uint x, uint y)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
