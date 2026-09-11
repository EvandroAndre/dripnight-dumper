using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelMemberShip : UIBaseModel
{
	private class MemberShipDelegate : PayUtility.PaymentDelegate
	{
		private static MemberShipDelegate _I;

		private string LastSubscribedProductIdentifier;

		public static MemberShipDelegate I => null;

		public override string Name => null;

		public override ProductPurchasedReaction OnProductPurchased(string reason, ProductPurchasedResult result, string productIdentifier, long rebateId, int quantity)
		{
			return null;
		}

		public override void OnPurchasing(string reason, bool willPurchase, string productIdentifier, long rebateId, bool isEvent, long eventId)
		{
		}

		public override void OnProductsUpdated(string task, bool result, string[] productIdentifiers)
		{
		}

		public override void OnRebateOptionsUpdated(string reason, bool result, long[] rebateIds)
		{
		}

		public ProductPurchasedReaction _003C_003EiFixBaseProxy_OnProductPurchased(string P0, ProductPurchasedResult P1, string P2, long P3, int P4)
		{
			return null;
		}

		public void _003C_003EiFixBaseProxy_OnPurchasing(string P0, bool P1, string P2, long P3, bool P4, long P5)
		{
		}

		public void _003C_003EiFixBaseProxy_OnProductsUpdated(string P0, bool P1, string[] P2)
		{
		}

		public void _003C_003EiFixBaseProxy_OnRebateOptionsUpdated(string P0, bool P1, long[] P2)
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__152_0;

		public static Predicate<AwardDesc> _003C_003E9__160_0;

		internal CommonRewardItemInfo _003CShowInitAward_003Eb__152_0(BaseItemInfo item)
		{
			return null;
		}

		internal bool _003C_002Ector_003Eb__160_0(AwardDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass100_0
	{
		public uint currentDay;

		internal bool _003CInitMemberShipDataToAssist_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public UIModelMemberShip _003C_003E4__this;

		public bool isBackEndNotify;

		public bool isReissue;

		internal void _003CRequestMemberShipInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass103_0
	{
		public ClientMemberShipCardData cardData;

		internal bool _003CProcessMemberShipInfo_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass106_0
	{
		public uint i;

		internal bool _003CProcessLastPeriodReissueData_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass107_0
	{
		public uint i;

		internal bool _003CProcessCurrentPeriodReissueData_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public uint cliamTime;

		internal bool _003CProcessReissueData_003Eb__0(ClientReissueItemData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass110_0
	{
		public bool claimAll;

		public UIModelMemberShip _003C_003E4__this;

		public proto.EVipCard.VipCardType memberShipType;

		public bool needRefreshAssist;

		internal void _003CRequestMemberShipCardCheckIn_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public uint currentDay;

		internal bool _003CUpdateCheckInInfo_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public uint lastDay;

		internal bool _003CUpdateLastDayCheckInInfo_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIModelMemberShip _003C_003E4__this;

		public ClientReissueItemData itemData;

		internal void _003CRequestClaimLastDayReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass138_0
	{
		public uint currentDay;

		internal bool _003CHasCheckIn_003Eb__0(VipCardAwardStatus x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass153_0
	{
		public long rebateID;

		internal bool _003CGetRebateCardDescByRebateID_003Eb__0(VipCardRebateDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass91_0
	{
		public UIModelMemberShip _003C_003E4__this;

		public HttpManager.EHttpChannel channel;

		internal void _003CRequestMemberShipDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint MEMBERSHIPREISSUECARDID = 827000001u;

	public const uint MEMBERSHIPEPBADGEID = 827001001u;

	public const uint REISSUESHOWDAY = 7u;

	public const uint WEEKCARDDAY = 7u;

	public const uint MONTHCARDDAY = 30u;

	public const uint PropID_MemberShipCheckInSuccess = 4u;

	public const uint PropID_MemberShipPurchaseSuccess = 8u;

	public const uint PropID_MemberShipSubscriptionBonusUpdate = 32u;

	public const uint PropID_MemberShipSubscriptionDone = 64u;

	public const uint PropID_MemberShipModelStateChange = 128u;

	public const uint PropID_MemberShipGetDesc = 256u;

	public const uint PropID_MemberShipGetInfo = 512u;

	public const uint PropID_MemberShipOnProductUpdate = 2048u;

	public const uint PropID_MemberShipReissueGetInfo = 4096u;

	private Predicate<AwardDesc> m_PredicateGem;

	private bool m_HasRequestReissue;

	private bool m_HasRequestLastDayReward;

	private ClientMemberShipCardData _003CMiniWeekCardData_003Ek__BackingField;

	private ClientMemberShipCardData _003CMonthCardData_003Ek__BackingField;

	private ClientMemberShipCardData _003CWeekCardData_003Ek__BackingField;

	private ClientReissueData _003CClientReissueData_003Ek__BackingField;

	private Dictionary<uint, bool?> m_SubscriptionBonusAvailable;

	private uint m_NextResetTimeStamp;

	private bool m_HasMembershipInfoGet;

	private const uint m_FuturePreivewLength = 30u;

	private const uint m_GraceTime = 1u;

	private long m_TimezoneOffsetSecs;

	private const int m_UTC8 = 28800;

	private string ChangeMemberShipVersionNoticeKey;

	private string MemberShipPurchaseKey;

	private CSGetVipCardDescRes m_MemberShipDescRes;

	private CSGetAccountVipCardInfosRes m_MemberShipInfo;

	private Dictionary<uint, uint> m_InitAwardDicByVipCardType;

	private Dictionary<uint, List<VipCardDailyAwardDesc>> m_DailyAwardListByDayDicByVipCardType;

	private Dictionary<uint, VipCardInfo> m_MemberShipInfoDic;

	private Dictionary<int, VipCardRebateDesc> m_MeberShipDiscountDescDic;

	private Dictionary<uint, uint> m_MemberShipDiscountInfoDic;

	private Dictionary<uint, uint> m_DictPaidLevelToVipCardType;

	private uint m_ResignCoins;

	private EMemberShipModelState _003CCurrentModelState_003Ek__BackingField;

	private EMemberShipBackEndNotifyState _003CCurrentPurchaseState_003Ek__BackingField;

	private proto.EVipCard.VipCardType _003CPendingNavigationCardType_003Ek__BackingField;

	private bool m_NeedRefreshProductsOnResume;

	public ClientMemberShipCardData MiniWeekCardData
	{
		get
		{
			return _003CMiniWeekCardData_003Ek__BackingField;
		}
		private set
		{
			_003CMiniWeekCardData_003Ek__BackingField = value;
		}
	}

	public ClientMemberShipCardData MonthCardData
	{
		get
		{
			return _003CMonthCardData_003Ek__BackingField;
		}
		private set
		{
			_003CMonthCardData_003Ek__BackingField = value;
		}
	}

	public ClientMemberShipCardData WeekCardData
	{
		get
		{
			return _003CWeekCardData_003Ek__BackingField;
		}
		private set
		{
			_003CWeekCardData_003Ek__BackingField = value;
		}
	}

	public ClientReissueData ClientReissueData
	{
		get
		{
			return _003CClientReissueData_003Ek__BackingField;
		}
		private set
		{
			_003CClientReissueData_003Ek__BackingField = value;
		}
	}

	public bool HasMembershipInfoGet => false;

	public long TimezoneOffsetSecs => 0L;

	private int SubscriptionMembershipSwitch => 0;

	public uint ResignCoins => 0u;

	public bool MemberShipCardEnabled => false;

	public EMemberShipModelState CurrentModelState
	{
		get
		{
			return _003CCurrentModelState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentModelState_003Ek__BackingField = value;
		}
	}

	public EMemberShipBackEndNotifyState CurrentPurchaseState
	{
		get
		{
			return _003CCurrentPurchaseState_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentPurchaseState_003Ek__BackingField = value;
		}
	}

	public proto.EVipCard.VipCardType PendingNavigationCardType
	{
		get
		{
			return _003CPendingNavigationCardType_003Ek__BackingField;
		}
		set
		{
			_003CPendingNavigationCardType_003Ek__BackingField = value;
		}
	}

	public static proto.EVipCard.VipCardType GetMemberShipType(RebateCardType rebateCardType)
	{
		return proto.EVipCard.VipCardType.VipCardType_NONE;
	}

	public static RebateCardType GetRebateCardType(proto.EVipCard.VipCardType memberShipCardType)
	{
		return RebateCardType.WeekCard;
	}

	public static proto.EVipCard.VipCardType ConvertToVipCardType(ESubscription.PriceType price_type)
	{
		return proto.EVipCard.VipCardType.VipCardType_NONE;
	}

	public static string GetCardSpriteNameByVipCardType(proto.EVipCard.VipCardType vipCardType, bool isBig = false)
	{
		return null;
	}

	public bool CanDisplaySubscription(proto.EVipCard.VipCardType membershipType)
	{
		return false;
	}

	public ClientMemberShipCardData MemberShipCard(proto.EVipCard.VipCardType rebateCardType)
	{
		return null;
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public proto.EVipCard.VipCardType GetCurrentMemberShipType()
	{
		return proto.EVipCard.VipCardType.VipCardType_NONE;
	}

	public override void Init()
	{
	}

	public void InitAfterLogin()
	{
	}

	public override void Login(object[] data)
	{
	}

	public void LoadRebateCardData()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool HasReissueCard()
	{
		return false;
	}

	public bool SubscriptionBonusAvailable(proto.EVipCard.VipCardType memberShipCardType)
	{
		return false;
	}

	public void RequestSubscriptionBonusAvailable()
	{
	}

	private void OnGetSubscriptionBonusStatus(HttpErrorCode httpErrorCode, object obj)
	{
	}

	private void OnSubscribed(string productIdentifier)
	{
	}

	public void OnProductAndRebateOptionsUpdate()
	{
	}

	public void ShowSubscriptionTips(proto.EVipCard.VipCardType memberShipCardType, Vector3 position, bool isSubscriptionHub = false)
	{
	}

	public void ChangeModelState(EMemberShipModelState nextState, object[] data)
	{
	}

	public void ChangeBackEndNotifyState(EMemberShipBackEndNotifyState nextState)
	{
	}

	public void RequestMemberShipDesc(LoadingType loadingType = LoadingType.CircleLoading, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void TryProcessMemberShipDesc()
	{
	}

	private void ProcessMemberShipDesc(CSGetVipCardDescRes desc)
	{
	}

	public proto.EVipCard.VipCardType GetDefaultVipCardDisplayTypeByPaidLevel(uint paidLevel)
	{
		return proto.EVipCard.VipCardType.VipCardType_NONE;
	}

	public void UpdateMemberShipProducts()
	{
	}

	private void RegisterProductAndRebateIDs()
	{
	}

	private int SortByDay(VipCardDailyAwardDesc a, VipCardDailyAwardDesc b)
	{
		return 0;
	}

	private void InitFakeMemberShipDataToAssist(bool needRefreshAssistView)
	{
	}

	private void SetAssistCardRewardDataIsRead(AssistMemberShipCardInfo cardInfo)
	{
	}

	private void InitMemberShipDataToAssist(bool needRefreshAssistView)
	{
	}

	public void RequestMemberShipInfo(uint httpOption = 0u, bool isBackEndNotify = false, bool isReissue = false, HttpManager.Priority priority = HttpManager.Priority.Normal, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public uint GetCardRefreshTimeStamp(uint startTime)
	{
		return 0u;
	}

	private void ProcessMemberShipInfo(CSGetAccountVipCardInfosRes info)
	{
	}

	private int SortReissueRewardDataByTime(ClientReissueItemData a, ClientReissueItemData b)
	{
		return 0;
	}

	private void CalculateReissueRewardData()
	{
	}

	private void ProcessLastPeriodReissueData(VipCardInfo cardInfo)
	{
	}

	private void ProcessCurrentPeriodReissueData(VipCardInfo cardInfo)
	{
	}

	private void ProcessFutureReviewData(VipCardInfo cardInfo)
	{
	}

	private void ProcessReissueData(EClientReissueItemType type, EClientCardTypeReissueAwardStatus status, uint day, VipCardInfo cardInfo, List<ClientReissueItemData> list)
	{
	}

	public void RequestMemberShipCardCheckIn(proto.EVipCard.VipCardType memberShipType, bool claimAll = false, bool needRefreshAssist = false)
	{
	}

	private void UpdateCheckInInfo(proto.EVipCard.VipCardType memberShipType)
	{
	}

	private void UpdateLastDayCheckInInfo(proto.EVipCard.VipCardType memberShipType, uint claimTime)
	{
	}

	public void RequestMemberShipReissue(ClientReissueItemData data)
	{
	}

	public void RequestClaimLastDayReward(ClientReissueItemData itemData)
	{
	}

	public void PurchaseMemberShipCard(ClientMemberShipCardData memberShipCardData, bool subscribe)
	{
	}

	public void PurchaseMemberShipCard(long rebateID, string productIdentifier)
	{
	}

	public void GetSVIPPagePurchaseRebateIDAndProductIdentifier(out long rebateId, out string productIdentifier)
	{
		rebateId = default(long);
		productIdentifier = null;
	}

	private void GetRebateIDAndProductIdentifierByMemberShipCardRebateIDType(MemberShipCardRebateIDType memberShipCardRebateIDType, out long rebateId, out string productIdentifier)
	{
		rebateId = default(long);
		productIdentifier = null;
	}

	public void OnGOPNotifyPurchased(string productIdentifier, int rebateId)
	{
	}

	public void OnBackEndNotifyPurchased(bool result, List<tcp.EVipCard.VipCardType> vipCardTypes)
	{
	}

	public void UpdateMemberShipTips()
	{
	}

	public bool CanShowCheckInAll()
	{
		return false;
	}

	public string SubscriptionProductIdentifier(proto.EVipCard.VipCardType memberShipCardType)
	{
		return null;
	}

	public bool SupportSubscription(proto.EVipCard.VipCardType memberShipCardType)
	{
		return false;
	}

	public PayItemData SubscriptionProduct(proto.EVipCard.VipCardType memberShipCardType)
	{
		return null;
	}

	public void CheckAndCreateSubscriptionRenewalMails()
	{
	}

	public static void SaveSubscriptionMailPrefs(string prefsKey, long windowStart, int status)
	{
	}

	public static void ReadSubscriptionMailPrefs(string prefsKey, out int savedStatus, out long savedWindowStart)
	{
		savedStatus = default(int);
		savedWindowStart = default(long);
	}

	private static void ClearSubscriptionRenewalMailPrefs(string prefsKey)
	{
	}

	public static string MakeSubscriptionLocalMailId(proto.EVipCard.VipCardType cardType)
	{
		return null;
	}

	private static int GetSubscriptionRenewalMailAdvanceDays(proto.EVipCard.VipCardType cardType)
	{
		return 0;
	}

	private MailInfo CreateSubscriptionRenewalMailInfo(proto.EVipCard.VipCardType cardType, PayItemData subscriptionProduct, long nextPaymentTime, long windowStart, int savedStatus)
	{
		return null;
	}

	public bool HasCheckIn(proto.EVipCard.VipCardType card_type)
	{
		return false;
	}

	public bool HasOwnMemberShipCard(proto.EVipCard.VipCardType card_type)
	{
		return false;
	}

	public bool CanCheckInAll()
	{
		return false;
	}

	public bool IsToday(uint timeStamp)
	{
		return false;
	}

	public uint CalculateRemainingDiamond()
	{
		return 0u;
	}

	public bool HasLastDayLoggedIn()
	{
		return false;
	}

	private bool HasMemberShipByDay(VipCardInfo info, uint day)
	{
		return false;
	}

	public uint GetNextRestTimeStamp()
	{
		return 0u;
	}

	public int GetOwnedReissueCardNum()
	{
		return 0;
	}

	public bool HasDiscountChance(proto.EVipCard.VipCardType vipCardType)
	{
		return false;
	}

	public uint GetPurchaseTime(proto.EVipCard.VipCardType vipCardType)
	{
		return 0u;
	}

	private uint CalculatePurchaseTimeByRebateIDType(MemberShipCardRebateIDType type)
	{
		return 0u;
	}

	public bool ValidToPurchase(proto.EVipCard.VipCardType vipCardType, bool subscribed)
	{
		return false;
	}

	public bool ValidToPurchase(long rebateID)
	{
		return false;
	}

	private void ShowInitAward(List<tcp.EVipCard.VipCardType> vipCardTypes)
	{
	}

	public VipCardRebateDesc GetRebateCardDescByRebateID(long rebateID)
	{
		return null;
	}

	public DateTime GetRefreshDateTime()
	{
		return default(DateTime);
	}

	public bool IsMemberShipCompliance()
	{
		return false;
	}

	public void CancelMemberShipSubscription(proto.EVipCard.VipCardType memberShipType)
	{
	}

	public void OnApplicationResumed()
	{
	}

	public void FakeAssistData()
	{
	}

	private void _003COnSubscribed_003Eb__86_0(string product_identifier)
	{
	}

	private void _003CRequestMemberShipReissue_003Eb__113_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
