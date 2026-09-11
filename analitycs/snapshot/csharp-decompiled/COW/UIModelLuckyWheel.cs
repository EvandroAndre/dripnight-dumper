using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelLuckyWheel : UIBaseModel
{
	public enum WheelItemState
	{
		None,
		Drawed,
		DrawedAndUsed
	}

	public enum RefreshCoinType
	{
		Diamond = 1,
		Gold
	}

	public enum DiscountType
	{
		None,
		Discount,
		Price
	}

	public enum LuckyWheelCDNBgType
	{
		bg01 = 1,
		bg02
	}

	public class LuckyWheelShareInfo
	{
		public bool NeedShowShareUI;

		public uint Price;

		public uint OriginalPrice;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003E9__68_2;

		internal CommonRewardItemInfo _003CRequestLuckyWheelBuyItem_003Eb__68_2(ExchangedAward item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public CSLuckyWheelDiscountInfo item;

		internal bool _003CGetCurrentDiscountType_003Eb__0(CSLuckyWheelDiscountDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public CSLuckyWheelDiscountInfo item;

		internal bool _003CGetCurrentDiscountValue_003Eb__0(CSLuckyWheelDiscountDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass53_0
	{
		public uint id;

		internal bool _003CGetCurrentRewardPoolList_003Eb__0(CSLuckyWheelShopItemDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public uint id;

		internal bool _003CGetWheelItemStateByID_003Eb__0(CSLuckyWheelDiscountInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public uint id;

		internal bool _003CGetRewardPoolItemByID_003Eb__0(CSLuckyWheelShopItemDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public UIModelLuckyWheel _003C_003E4__this;

		public HttpManager.Priority priority;

		internal void _003CRequestLuckyWheelDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public UIModelLuckyWheel _003C_003E4__this;

		public uint id;

		public bool needShare;

		public CSLuckyWheelDiscountDesc discount;

		internal void _003CRequestLuckyWheelBuyItem_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_1
	{
		public CSLuckyWheelDiscountInfo item;

		internal bool _003CRequestLuckyWheelBuyItem_003Eb__1(CSLuckyWheelDiscountDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass70_0
	{
		public uint id;

		internal bool _003CCheckHasBuyedItemByID_003Eb__0(CSLuckyWheelShopItemInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public uint shopItemId;

		internal bool _003CTryApplyCurrFullyOwnedOnLoginOpen_003Eb__0(CSLuckyWheelShopItemDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public CSLuckyWheelDiscountInfo item;

		internal bool _003CGetCurrentDiscountID_003Eb__0(CSLuckyWheelDiscountDesc x)
		{
			return false;
		}
	}

	public const int LUCKYWHEEL_ALL_COUNT = 8;

	public const string LUCKYWHEELFIRSTENTERKET = "LuckyWheelFirstEnterKey_{0}_{1}";

	public static uint PropID_LuckyWheel_DrawDiscount;

	public static uint PropID_LuckyWheel_GetInfo;

	public static uint PropID_LuckyWheel_GetDesc;

	public static uint PropID_LuckyWheel_BuyItem;

	public static uint PropID_LuckyWheel_RefreshRewardPool;

	public bool NoNeedConfirmRefreshRewardPool;

	private uint _003CTotalWeight_003Ek__BackingField;

	public LuckyWheelShareInfo ShareInfo;

	private uint _003CCurrentLuckyWheelID_003Ek__BackingField;

	private CSLuckyWheelInfo m_CSLuckyWheelInfo;

	private CSLuckyWheelDesc m_CSLuckyWheelDesc;

	private bool m_CurrFullyOwned;

	private Dictionary<uint, CSLuckyWheelShopItemDesc> m_ItemIDToShopItemDescDict;

	private Dictionary<uint, bool> m_ShopItemIDToPurchasedStatusDict;

	private bool m_HasGotItemStatus;

	private bool m_IsItemStatusRequestPending;

	private bool m_IsLobbyEntranceShowed;

	private bool m_IsLobbySpecialEntranceShowed;

	public uint TotalWeight
	{
		get
		{
			return _003CTotalWeight_003Ek__BackingField;
		}
		private set
		{
			_003CTotalWeight_003Ek__BackingField = value;
		}
	}

	public uint CurrentLuckyWheelID
	{
		get
		{
			return _003CCurrentLuckyWheelID_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentLuckyWheelID_003Ek__BackingField = value;
		}
	}

	public bool IsCurrFullyOwned => false;

	public bool IsLobbyEntranceShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsLobbySpecialEntranceShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsEntranceShowed => false;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public long GetStartTime()
	{
		return 0L;
	}

	public long GetEndTime()
	{
		return 0L;
	}

	public bool HasLuckyWheelActivity()
	{
		return false;
	}

	public DiscountType GetCurrentDiscountType()
	{
		return DiscountType.None;
	}

	private int SortDiscountDesc(CSLuckyWheelDiscountDesc a, CSLuckyWheelDiscountDesc b)
	{
		return 0;
	}

	private int SortDiscountDescByRule(CSLuckyWheelDiscountDesc a, CSLuckyWheelDiscountDesc b)
	{
		return 0;
	}

	private int SortRewardPoolDesc(CSLuckyWheelShopItemDesc a, CSLuckyWheelShopItemDesc b)
	{
		return 0;
	}

	private int ComparRewardItem(CSLuckyWheelShopItemDesc a, CSLuckyWheelShopItemDesc b)
	{
		return 0;
	}

	public uint GetCurrentDiscountValue()
	{
		return 0u;
	}

	public List<CSLuckyWheelShopItemDesc> GetCurrentRewardPoolList()
	{
		return null;
	}

	public RefreshCoinType GetCurrentRefreshCoinType()
	{
		return (RefreshCoinType)0;
	}

	public uint GetCurrentRefreshRemainCount()
	{
		return 0u;
	}

	public uint GetCurrentRefreshPrice()
	{
		return 0u;
	}

	public bool HasFreeRefreshTime()
	{
		return false;
	}

	public uint GetTotalFreeRefreshCount()
	{
		return 0u;
	}

	public List<CSLuckyWheelShopItemDesc> GetLuckyWhellRewardItems()
	{
		return null;
	}

	public WheelItemState GetWheelItemStateByID(uint id)
	{
		return WheelItemState.None;
	}

	public List<CSLuckyWheelDiscountDesc> GetWheelItemDescList()
	{
		return null;
	}

	public List<CSLuckyWheelDiscountDesc> GetSortedWheelItemDescList()
	{
		return null;
	}

	public CSLuckyWheelShopItemDesc GetRewardPoolItemByID(uint id)
	{
		return null;
	}

	public void RequestLuckyWheelDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestLuckyWheelInfo(uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestLuckyWheelItemStatus(uint httpOption = 0u, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestLuckyWheelDrawDiscount(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestLuckyWheelBuyItem(uint id)
	{
	}

	public void RequestRefreshRewardPool(HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public bool CheckHasBuyedItemByID(uint id)
	{
		return false;
	}

	private void TryApplyCurrFullyOwnedOnLoginOpen()
	{
	}

	public int GetUsedDiscountCount()
	{
		return 0;
	}

	public bool IsLastDiscount()
	{
		return false;
	}

	public bool IsLastDraw()
	{
		return false;
	}

	public bool IsProperbilityOpen()
	{
		return false;
	}

	public bool HasFinishedLuckyWheel()
	{
		return false;
	}

	public bool HasOwnedAllLuckyWheelItems()
	{
		return false;
	}

	private void ApplyCurrFullyOwnedBonus(bool currFullyOwned)
	{
	}

	public uint GetCurrentDiscountID()
	{
		return 0u;
	}

	public bool CheckCanRefresh()
	{
		return false;
	}

	public bool CheckIsItemInLuckyWheel(uint itemId)
	{
		return false;
	}

	public bool CheckIsItemTimeEqual(uint itemId, uint deltaTime)
	{
		return false;
	}

	public bool CheckIsItemPurchasable(uint itemId)
	{
		return false;
	}

	private void _003CRequestLuckyWheelInfo_003Eb__65_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLuckyWheelItemStatus_003Eb__66_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLuckyWheelDrawDiscount_003Eb__67_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestRefreshRewardPool_003Eb__69_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
