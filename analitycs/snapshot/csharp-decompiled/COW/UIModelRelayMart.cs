using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelRelayMart : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__186_0;

		public static Action _003C_003E9__186_1;

		internal CommonRewardItemInfo _003CShowReward_003Eb__186_0(BaseItemInfo item)
		{
			return null;
		}

		internal void _003CShowReward_003Eb__186_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass165_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public ulong currentTimeStamp;

		internal void _003CRequestGetAccountRelayMartInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass166_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public string discountCode;

		public ERelayMartDiscountCodeAddFrom addFrom;

		public bool showTips;

		internal void _003CRequestLockRelayMartDiscountCode_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass168_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public List<DiscountCodeShareSetting> discountCodeShareSettingList;

		internal void _003CRequestShareRelayMartDiscountCode_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public List<RelayMartDiscountCodeInfo> discountCodeInfoList;

		internal void _003CRequestClaimRelayMartRebate_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass170_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public ulong currentTimeStamp;

		internal void _003CRequestGetRelayMartSharedDiscountCodes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public string discountCode;

		public bool isSendFriendAdd;

		public List<uint> martGoodsIdList;

		public bool preBigAward;

		internal void _003CRequestBuyRelayMartGoods_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass174_0
	{
		public UIModelRelayMart _003C_003E4__this;

		public ulong currentTimeStamp;

		internal void _003CRequestCheckAvailableDiscountCodes_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass177_0
	{
		public RelayMartSharedDiscountCode receivedCode;

		internal bool _003CUpdateAllReceivedDiscountCodes_003Eb__0(RelayMartSharedDiscountCode code)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass178_0
	{
		public FriendRelayMartDiscountCodeShareNtf friendDiscountCodeShareNtf;

		internal bool _003CAddToAllReceivedDiscountCodes_003Eb__0(RelayMartSharedDiscountCode code)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass184_0
	{
		public string discountCode;

		internal bool _003CTryRemoveDiscountShare_003Eb__0(RelayMartSharedDiscountCode code)
		{
			return false;
		}

		internal bool _003CTryRemoveDiscountShare_003Eb__1(RelayMartSharedDiscountCode code)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass189_0
	{
		public FriendRelayMartDiscountCodeShareNtf friendDiscountCodeShareNtf;

		internal bool _003CUpdateMyReceiveDiscountCode_003Eb__0(RelayMartSharedDiscountCode code)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass190_0
	{
		public RelayMartDiscountCodeUsedNtf discountCodeUsedNtf;

		internal bool _003CUpdateMyAccountRelayMartInfoRebate_003Eb__0(RelayMartDiscountCodeInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass192_0
	{
		public DiscountCodeShareSetting shareSetting;

		internal bool _003CUpdateMyAccountRelayMartDiscountCodeShareStatus_003Eb__0(RelayMartDiscountCodeInfo info)
		{
			return false;
		}
	}

	public const int MAX_SHOPPING_CART_COUNT = 3;

	private const uint FIRST_LEVEL = 1u;

	private const uint SECOND_LEVEL = 2u;

	private const uint FINAL_LEVEL = 3u;

	public const uint MAX_REWARD_POOL_COUNT = 40u;

	private const ulong REQUEST_GET_ACCOUNT_RELAY_MART_INFO_INTERVAL = 300uL;

	private const ulong REQUEST_CHECK_AVAILABLE_DISCOUNT_CODES_INTERVAL = 20uL;

	private const uint BACK_UP_CODE_LENGTH = 9u;

	private const string RELAY_MART_FIRST_SHOW_KEY = "RELAY_MART_FIRST_SHOW_KEY_{0}";

	public const uint PURCHASE_PRICE_FONT_SIZE = 34u;

	public const uint PURCHASE_PRICE_PERCENT_SIZE = 20u;

	public const uint MAIN_PAGE_DISCOUNT_FONT_SIZE = 34u;

	public const uint MAIN_PAGE_DISCOUNT_PERCENT_SIZE = 20u;

	public const uint PROGRESS_BAR_DISCOUNT_FONT_SIZE_UNACTIVE = 22u;

	public const uint PROGRESS_BAR_DISCOUNT_PERCENT_SIZE_UNACTIVE = 16u;

	public const uint PROGRESS_BAR_DISCOUNT_FONT_SIZE_ACTIVE = 28u;

	public const uint PROGRESS_BAR_DISCOUNT_PERCENT_SIZE_ACTIVE = 20u;

	public const float FLOAT_PRECISION_OFFSET = 0.0001f;

	public const float PERCENT_DIVISOR = 100f;

	public const uint MAX_DISCOUNT_VALUE = 99u;

	public const int MIN_DISCOUNTED_PRICE = 1;

	public const int LOCK_FAILED_TIMES_POP_OFFICIAL_CODE = 2;

	public const string DEFAULT_FALLBACK_LANGUAGE = "EN";

	public const uint PropID_ShoppingCartItemChanged = 1u;

	public const uint PropID_GetAccountRelayMartInfo = 2u;

	public const uint PropID_LockRelayMartDiscountCode = 4u;

	public const uint PropID_UnlockRelayMartDiscountCode = 8u;

	public const uint PropID_ShareRelayMartDiscountCode = 16u;

	public const uint PropID_ClaimRelayMartRebate = 32u;

	public const uint PropID_GetRelayMartSharedDiscountCodes = 64u;

	public const uint PropID_BuyRelayMartGoods = 128u;

	public const uint PropID_UpdateRelayMartRebateInfo = 256u;

	public const uint PropID_CheckAvailableDiscountCodes = 512u;

	private RelayMartSettingDesc m_RelayMartSettingDesc;

	private List<RelayMartShopDesc> m_RelayMartShopDescList;

	private Dictionary<uint, RelayMartShopDesc> m_DictMartGoodsIdToRelayMartShopDesc;

	private List<uint> m_ShoppingCartMartGoodsIdList;

	private Dictionary<string, Dictionary<ulong, float>> m_DictAccountIdToRelayMartDiscountCodeShareTime;

	private List<RelayMartSharedDiscountCode> m_SharedDiscountCodeList;

	private CSGetAccountRelayMartInfoRes m_MyAccountRelayMartInfo;

	private List<string> m_OffcialAvailableCodes;

	private List<RelayMartSharedDiscountCode> m_AllReceivedDiscountCodes;

	private RelayMartSharedDiscountCode m_CurrentLockedDiscountCode;

	private ulong m_CurrentLockedDiscountCodeExpireTime;

	private ERelayMartDiscountCodeAddFrom m_CurrentLockedDiscountCodeAddFrom;

	private uint m_MyRebateDiamonds;

	private bool m_HasRebateWndAutoOpened;

	private bool m_IsLobbyEntranceShowed;

	private bool m_HasRebateBubbleShowed;

	private bool m_HasReuqestGetAccountRelayMartInfo;

	private uint m_SelectedMartGoodsId;

	private int m_LockDiscountCodeFailedTimes;

	private bool m_IsRequestingGetAccountRelayMartInfo;

	private bool m_IsRequestingLockRelayMartDiscountCode;

	private bool m_IsRequestingUnlockRelayMartDiscountCode;

	private bool m_IsRequestingShareRelayMartDiscountCode;

	private bool m_IsRequestingClaimRelayMartRebate;

	private bool m_IsRequestingGetRelayMartSharedDiscountCodes;

	private bool m_IsRequestingBuyRelayMartGoods;

	private bool m_IsRequestingShareFriendRelayMartDiscountCode;

	private bool m_IsRequestingCheckAvailableDiscountCodes;

	private ulong m_LastRequestGetAccountRelayMartInfoTimeStamp;

	private ulong m_LastRequestGetRelayMartSharedDiscountCodesTimeStamp;

	private ulong m_LastRequestCheckAvailableDiscountCodesTimeStamp;

	private RelayMartDiscountCodeInfo m_CurrentGenerateDiscountCodeItemData;

	private string m_DeepLinkDiscountCode;

	private bool m_ShouldAutoTriggerPurchaseAfterCodeVerify;

	private const string RELAY_MART_DIAMOND_POPUP_SHOWN_KEY = "RELAY_MART_DIAMOND_POPUP_SHOWN_{0}_{1}";

	public RelayMartDiscountCodeInfo CurrentGenerateDiscountCodeItemData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public RelayMartSettingDesc RelayMartSettingDesc
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<RelayMartShopDesc> RelayMartShopDescList => null;

	public bool HasRebateWndAutoOpened
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasRebateBubbleShowed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint SelectedMartGoodsId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string DeepLinkDiscountCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

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

	public List<RelayMartSharedDiscountCode> SharedDiscountCodeList => null;

	public bool HasReuqestGetAccountRelayMartInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ERelayMartDiscountCodeAddFrom CurrentLockedDiscountCodeAddFrom => ERelayMartDiscountCodeAddFrom.None;

	public bool ShouldAutoTriggerPurchaseAfterCodeVerify
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public CSGetAccountRelayMartInfoRes MyAccountRelayMartInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ConsumeDeepLinkDiscountCode()
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Login(object[] data)
	{
	}

	public uint GetDiscountByLevel(uint level)
	{
		return 0u;
	}

	public ulong GetRelayMartStartTime()
	{
		return 0uL;
	}

	public ulong GetRelayMartEndTime()
	{
		return 0uL;
	}

	public bool IsRelayMartValidTime()
	{
		return false;
	}

	public bool IsRelayMartEnabledForCurrentVersion()
	{
		return false;
	}

	public string GetSpecialBgCDN()
	{
		return null;
	}

	public uint GetDiscountCodeDiscountValue()
	{
		return 0u;
	}

	public uint GetDiamondReturnRatio()
	{
		return 0u;
	}

	public string GetTitleCDN()
	{
		return null;
	}

	public string GetDefaultLanguageTitleCDN()
	{
		return null;
	}

	private string GetDefaultLanguage()
	{
		return null;
	}

	private string GetLocalizedCDNUrl(string cdnUrl, string overrideLanguage)
	{
		return null;
	}

	public RelayMartSharedDiscountCode GetCurrentDiscountCodeInfo()
	{
		return null;
	}

	public bool ShouldShowExtraOfficialCode()
	{
		return false;
	}

	public void ResetLockDiscountCodeFailedTimes()
	{
	}

	public void LockOfficialDiscountCode(string discountCode)
	{
	}

	public void UnlockOfficialDiscountCode()
	{
	}

	public int GetCurrentShoppingCartCount()
	{
		return 0;
	}

	public List<uint> GetShoppingCartMartGoodsIdList()
	{
		return null;
	}

	public List<RelayMartShopDesc> GetRelayMartShopDescList()
	{
		return null;
	}

	public List<RelayMartShopDesc> GetShoppingCartItemList()
	{
		return null;
	}

	public List<RelayMartDiscountCodeInfo> GetDiscountCodeList()
	{
		return null;
	}

	public List<RelayMartSharedDiscountCode> GetReceivedDiscountCodes()
	{
		return null;
	}

	public bool IsUsedOfficialDiscountCode()
	{
		return false;
	}

	public uint GetClaimedDiamondSum()
	{
		return 0u;
	}

	public ERelayMartRewardPoolItemState GetRelayMartRewardPoolItemState(uint martGoodsId)
	{
		return ERelayMartRewardPoolItemState.Normal;
	}

	public bool IsItemInShoppingCart(uint martGoodsId)
	{
		return false;
	}

	public bool AddToShoppingCart(uint martGoodsId)
	{
		return false;
	}

	public bool RemoveFromShoppingCart(uint martGoodsId)
	{
		return false;
	}

	public int GetMaxShoppingCartCount()
	{
		return 0;
	}

	public float GetAccountRelayMartDiscountCodeShareTime(string discountCode, ulong accountID)
	{
		return 0f;
	}

	public void SetAccountRelayMartDiscountCodeShareTime(string dicountCode, ulong accountID, float time)
	{
	}

	public int GetShoppingCartPrice(bool withDiscount = false)
	{
		return 0;
	}

	public int GetShoppingCartPriceWithCurrentCount(int count, bool withDiscount = false)
	{
		return 0;
	}

	public float GetCurrentDiscountPercent()
	{
		return 0f;
	}

	public uint GetCurrentDiscountValue()
	{
		return 0u;
	}

	public uint GetCurrentDiscountValueWithCount(int count)
	{
		return 0u;
	}

	public int GetNextLevelSavingAmount()
	{
		return 0;
	}

	public int GetCurrentTotalSavingAmount()
	{
		return 0;
	}

	public bool IsCurrentLockedDiscountCode(string discountCode)
	{
		return false;
	}

	public bool IsLockedDiscountCodeValid()
	{
		return false;
	}

	public bool CheckItemCanPurchase(uint martGoodsId)
	{
		return false;
	}

	public bool CheckIsBackUpDiscountCode(string discountCode)
	{
		return false;
	}

	public string GetBackUpDiscountCodePrefix(string discountCode)
	{
		return null;
	}

	public uint GetCurrentUnuseRebateCount()
	{
		return 0u;
	}

	public uint GetTotalRebateCount()
	{
		return 0u;
	}

	public bool CheckHasUnclaimedRebate()
	{
		return false;
	}

	public bool HasRelayMartActivity()
	{
		return false;
	}

	public uint GetRelayMartSettingDescID()
	{
		return 0u;
	}

	public void CheckFirstShowRelayMartTips()
	{
	}

	public void SetFirstShowRelayMartTips()
	{
	}

	public bool ShouldShowFreeDiamondPopup()
	{
		return false;
	}

	private bool HasShownFreeDiamondPopup()
	{
		return false;
	}

	public void SetFreeDiamondPopupShown()
	{
	}

	public void UpdateCanClaimRebateTips()
	{
	}

	public bool CheckActivityEnded()
	{
		return false;
	}

	public void ProcessRelayMartDesc(CSGetRelayMartDescRes relayMartDesc)
	{
	}

	public void RequestGetAccountRelayMartInfo(bool isForce = false)
	{
	}

	public void RequestLockRelayMartDiscountCode(string discountCode, bool showTips = false, ERelayMartDiscountCodeAddFrom addFrom = ERelayMartDiscountCodeAddFrom.None)
	{
	}

	public void RequestUnlockRelayMartDiscountCode()
	{
	}

	public void RequestShareRelayMartDiscountCode(List<DiscountCodeShareSetting> discountCodeShareSettingList)
	{
	}

	public void RequestClaimRelayMartRebate(List<RelayMartDiscountCodeInfo> discountCodeInfoList)
	{
	}

	public void RequestGetRelayMartSharedDiscountCodes(bool isForce = false)
	{
	}

	public void RequestBuyRelayMartGoods(List<uint> martGoodsIdList, string discountCode, bool useBackUpCode, bool isSendFriendAdd)
	{
	}

	public RelayMartSharedDiscountCode GetOfficialDiscountCode()
	{
		return null;
	}

	public void RequestShareFriendRelayMartDiscountCode(ulong friendAccountId, string discountCode)
	{
	}

	public void RequestCheckAvailableDiscountCodes(bool isForce = false)
	{
	}

	public void UpdateFriendDiscountCodeShare(FriendRelayMartDiscountCodeShareNtf friendDiscountCodeShareNtf)
	{
	}

	public void UpdateDiscountCodeUsed(RelayMartDiscountCodeUsedNtf discountCodeUsedNtf)
	{
	}

	private void UpdateAllReceivedDiscountCodes()
	{
	}

	private void AddToAllReceivedDiscountCodes(FriendRelayMartDiscountCodeShareNtf friendDiscountCodeShareNtf)
	{
	}

	private void UpdateReceivedDiscountCodesByAvailableCodes(List<string> availableCodes)
	{
	}

	private bool CheckItemIsOwnedOrSoldOut(uint martGoodsId)
	{
		return false;
	}

	private void ProcessAccountRelayMartInfo()
	{
	}

	private void UpdateOffcialAvailableCodes()
	{
	}

	private void UpdateMyAccountRelayMartInfo(CSBuyRelayMartGoodsRes buyRelayMartGoodsRes)
	{
	}

	private void TryRemoveDiscountShare(string discountCode)
	{
	}

	private bool CheckBigAwardBeforePurchase(List<uint> martGoodsIdList)
	{
		return false;
	}

	private void ShowReward(ExchangeChangeData awards, List<uint> martGoodsIdList, bool isBigAward)
	{
	}

	private void UpdateGameAssistantCodeData()
	{
	}

	private void UpdateGameAssistantRebateData()
	{
	}

	private void UpdateMyReceiveDiscountCode(FriendRelayMartDiscountCodeShareNtf friendDiscountCodeShareNtf)
	{
	}

	private void UpdateMyAccountRelayMartInfoRebate(RelayMartDiscountCodeUsedNtf discountCodeUsedNtf)
	{
	}

	private void CheckSendAddFriendRequest(bool isSendFriendAdd)
	{
	}

	private void UpdateMyAccountRelayMartDiscountCodeShareStatus(List<DiscountCodeShareSetting> discountCodeShareSettingList)
	{
	}

	private void _003CRequestUnlockRelayMartDiscountCode_003Eb__167_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestShareFriendRelayMartDiscountCode_003Eb__173_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}
}
