using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelPrime : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<KeyValuePair<uint, uint>> _003C_003E9__55_0;

		public static Converter<KeyValuePair<uint, uint>, uint> _003C_003E9__55_1;

		public static Converter<uint, proto.EPrime.PrivilegeID> _003C_003E9__68_0;

		public static Converter<proto.EPrime.PrivilegeID, uint> _003C_003E9__68_2;

		public static Comparison<PrimePrivilegeDesc> _003C_003E9__116_0;

		internal int _003CConvertPrimeLevelsToDictionary_003Eb__55_0(KeyValuePair<uint, uint> x, KeyValuePair<uint, uint> y)
		{
			return 0;
		}

		internal uint _003CConvertPrimeLevelsToDictionary_003Eb__55_1(KeyValuePair<uint, uint> p)
		{
			return 0u;
		}

		internal proto.EPrime.PrivilegeID _003CRequestUpdatePrimePrivilegeSetting_003Eb__68_0(uint id)
		{
			return proto.EPrime.PrivilegeID.PrivilegeID_NONE;
		}

		internal uint _003CRequestUpdatePrimePrivilegeSetting_003Eb__68_2(proto.EPrime.PrivilegeID id)
		{
			return 0u;
		}

		internal int _003CGetSortedIntroductionPrivilegeIds_003Eb__116_0(PrimePrivilegeDesc x, PrimePrivilegeDesc y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass171_0
	{
		public uint festivalId;

		internal bool _003CGetPrimeFestivalDescByFestivalId_003Eb__0(PrimeFestivalDesc festival)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass64_0
	{
		public UIModelPrime _003C_003E4__this;

		public uint month;

		public uint day;

		internal void _003CRequestSetBirthday_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass69_0
	{
		public ulong shareeAccountID;

		internal bool _003CRequestOfferSetShare_003Eb__0(GroupMemberInfo memberInfo)
		{
			return false;
		}
	}

	private CSGetPrimeDescsRes m_PrimeDescRes;

	private Dictionary<uint, List<uint>> m_DicLevelToSortedPrivileges;

	private Dictionary<uint, List<uint>> m_DicLevelToAllPrivilegeIDs;

	private Dictionary<uint, uint> m_DictPrimePriIdToLowestLevel;

	private Dictionary<uint, int> m_DicLevelToPoints;

	private Dictionary<uint, PrimePrivilegeDesc> m_DicPrivilegeToDescs;

	private Dictionary<uint, PrimeCDNDesc> m_DicPrivilegeToCDNDescs;

	private Dictionary<uint, PrimeLeaderboardDesc> m_DicLeaderBoardTypeToOpenSettingDescs;

	private List<PrimeFestivalDesc> m_FestivalDescs;

	private Dictionary<uint, PrimeFestivalAwardDesc> m_DicFestivalToAwardDescs;

	private PrimeEventDesc m_CurrentPrimeEventDesc;

	private CSGetPrimeAccountInfoRes m_PrimeAccountInfoRes;

	private uint m_CurrentSetShareRemainTimes;

	private CSGetPrimeFestivalAccountInfoRes m_PrimeFestivalAccountInfoRes;

	private bool m_IsPrimeOpen;

	private uint m_MaxPrimeLevel;

	private List<uint> m_PrimeHiddenListUI;

	private PrimeLevelTips m_CurrentShowingLevelTips;

	public bool PrimeLeaderBoardOpen;

	private PrimeFestivalPopupData m_PrimeTodayFestivalInfo;

	private int m_LastPrimePoints;

	private bool m_NeedShowPrimePointsChange;

	private uint m_LastPrimeLevel;

	private bool m_NeedShowPrimePrimeLevelChange;

	private Dictionary<uint, string> m_DicPrimeCDNNameToUrl;

	public static uint PrimeStoreItemMAXPurchaseTimes;

	private uint m_SetShareID;

	private bool m_DoublePointsActivityTipsExpired;

	private bool m_IsPrimeAccountInfoRequested;

	public const uint PropID_GetPrimeAccountInfo = 2u;

	public const uint PropID_PrimeTips = 4u;

	public const uint PropID_GetPrimeFestivalAccountInfo = 8u;

	public const uint PropID_SetBirthday = 16u;

	public const uint PropID_PrimeLevelChange = 32u;

	public const uint PropID_PrimeFestivalReceived = 64u;

	public const uint PropID_PrimePrivilegeIdListChange = 128u;

	public const string PRIME_SETSHARE_GROUPINFO_GUIDE = "PrimeSetShareGroupInfoGuide";

	public const int PRIME_SETSHARE_LIMIT_TIMES = 10;

	public const uint PRIME_SETSHARE_CHATITEM_NORMALBANNER_COLOR = 3399834623u;

	public const uint PRIME_SETSHARE_CHATITEM_COLORBG_COLOR = 622599423u;

	public const uint PRIME_SETSHARE_CHATITEM_CORNER_COLOR = 4123289087u;

	private SortedDictionary<uint, PrimeSetShareActionState> m_SetShareActionState;

	private string PRIME_REACHTOP;

	private string PREVIOUS_PRIME_MONTHLY_RANK;

	private string PREVIOUS_PRIME_YEARLY_RANK;

	private string PREVIOUS_PRIME_TOTALY_RANK;

	private string PRIME_LEVEL;

	private string PRIME_HISTORY_MAX_LEVELEL;

	private string PRIME_LAST_CHARGE_MONTHID;

	private string PRIME_LAST_SHOW_LEVEL_DOWN_MONTHID;

	private string PRIME_LAST_SHOW_WILL_LEVEL_DOWN_MONTHID;

	private string PRIME_LAST_SHOW_NEED_RECOVER_MONTHID;

	private string PRIME_POINTS;

	private string PRIME_LAST_POINTS;

	private string PRIME_DOUBLE_POINTS_ACTIVITY_LAST_SHOW_GEMS;

	private string PRIME_DOUBLE_POINTS_ACTIVITY_LAST_SHOW_EVENT_ID;

	private string PRIME_DOUBLE_POINTS_ACTIVITY_TIPS_CLICKED;

	private string PRIME_DOUBLE_POINTS_ACTIVITY_TIPS_CLICKED_EVENT_ID;

	private string PRIME_INTRODUCTION;

	private UILabel m_OriginalPrimeLabelInfo;

	private GameObject m_OriginalPrimeObj;

	private bool? m_InitPrimeOriginalLabelSuccess;

	private PrimeStoreDesc m_CurrentStoreInfo;

	private List<PrimeStoreItemDesc> m_CurrentStoreItemInfo;

	private List<PrimeStoreItemDesc> m_CurrentStoreGiftItemInfo;

	private string PRIMELASTLOGINLEVEL;

	public bool IsPrimeAccountInfoRequested => false;

	public PrimeLevelTips CurrentShowingLevelTips => PrimeLevelTips.None;

	public bool HasGetPrimeDesc => false;

	public bool HasGetPrimeInfo => false;

	public bool HasGetPrimeFestivalAccount => false;

	public PrimeStoreDesc CurrentStoreInfo => null;

	public List<PrimeStoreItemDesc> CurrentStoreItemInfo => null;

	public List<PrimeStoreItemDesc> CurrentStoreGiftItemInfo => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ProcessPrimeDescs(CSGetPrimeDescsRes desc)
	{
	}

	private Dictionary<uint, List<uint>> ConvertPrimeLevelsToDictionary(List<PrimeLevelDesc> listprime_level)
	{
		return null;
	}

	private void AddPrivilege(List<KeyValuePair<uint, uint>> privileges, PrimePrivilege privilege, uint value)
	{
	}

	private void ConvertPrimeCDNToDictionary(ClientPrimeSettingDesc desc)
	{
	}

	private void InitLevelToAllPriIDList(List<PrimeLevelDesc> listprime_level)
	{
	}

	private void InitPrimePriIdToLowestLevelDict(List<PrimeLevelDesc> listprime_level)
	{
	}

	private void RefreshLowestLevelPrimePriInfo(uint level, uint primePri, bool show)
	{
	}

	public uint GetSpecificPrimePriLowestLevel(PrimePrivilege privilege)
	{
		return 0u;
	}

	public void RequestPrimeAccountInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool checkFestivalReward = true)
	{
	}

	public void RequestPrimeFestivalAccountInfo()
	{
	}

	public void RequestSetBirthday(uint month, uint day)
	{
	}

	private void RefreshPrivilegeIdList()
	{
	}

	public void RefreshPrimeHiddenListAfterEquipAvatarFrame(uint equipAvatarFrameID, bool isPrime)
	{
	}

	private void ForceEquipPrimeAvatarFrame()
	{
	}

	public void RequestUpdatePrimePrivilegeSetting()
	{
	}

	public void RequestOfferSetShare(ulong shareeAccountID)
	{
	}

	public uint GetSetShareID()
	{
		return 0u;
	}

	public bool GetSetShareActionState(uint setShareID)
	{
		return false;
	}

	public void ChangeSetShareActionState(uint setShareID, bool state = false, ulong actionAccountID = 0uL)
	{
	}

	public void RequestAcceptOfferSetShare(ulong sharerAccountID, uint setShareID)
	{
	}

	public void RequestApplySetShare(ulong sharerAccountID)
	{
	}

	public void RequestApprovalApplySetShare(ulong shareeAccountID, uint setShareID)
	{
	}

	public void RequestTakeOffSetShare(int source)
	{
	}

	public ulong GetSetShareActionTimeStamp(uint setShareID)
	{
		return 0uL;
	}

	public void SendSetShareFakeChatMessage(ulong shareeAccountID, ulong sharerAccountID, EPrimeSetShareState state, uint setShareID)
	{
	}

	public void UpdateAccountInfo(PrimePointsChangeNtf ntf)
	{
	}

	public void UpdateTodayFestival(PrimeFestivalAward festivals, bool isImmediateReward = false)
	{
	}

	public string GetPrimeIconSpriteName(int level)
	{
		return null;
	}

	public uint GetPrimeLevelByScore(int score)
	{
		return 0u;
	}

	public bool GetMemberInfoHasPrivilege(GroupMemberInfo info, PrimePrivilege privilege)
	{
		return false;
	}

	public static void GetMemberDisplayClothesAndAvatar(GroupMemberInfo member, out uint[] clothes, out uint avatarID)
	{
		clothes = null;
		avatarID = default(uint);
	}

	public static bool IsSameClothAndAvatarAsMember(GroupMemberInfo myInfo, GroupMemberInfo target)
	{
		return false;
	}

	public EPrimeSetShareState CalcSetShareState(GroupMemberInfo myInfo, GroupMemberInfo target)
	{
		return EPrimeSetShareState.None;
	}

	public bool CheckPrimeOpen()
	{
		return false;
	}

	public PrimeState GetPrimeState()
	{
		return PrimeState.NotPrime;
	}

	public ResourceID GetPrimeAvatarFrame()
	{
		return default(ResourceID);
	}

	public ResourceID GetPrimeCollectioSprite(PrimePrivilege privilege, uint playerPrimeLevel = 0u)
	{
		return default(ResourceID);
	}

	public bool IsPrime()
	{
		return false;
	}

	public bool IsLevelDownPrime()
	{
		return false;
	}

	public uint GetCurrentPrimeLevel()
	{
		return 0u;
	}

	public uint GetLastPrimeLevel()
	{
		return 0u;
	}

	public bool NeedShowPrimePrimeLevelChange()
	{
		return false;
	}

	public void ResetNeedShowPrimeLevelChangeFlag()
	{
	}

	public int GetCurrentPrimePoints()
	{
		return 0;
	}

	public int GetLastPrimePoints()
	{
		return 0;
	}

	public bool NeedShowPrimePointsChange()
	{
		return false;
	}

	public void ResetNeedShowPrimePointsChangeFlag()
	{
	}

	public uint GetHistoryMaxPrimelevel()
	{
		return 0u;
	}

	public uint GetSetShareShareeRemainTimes()
	{
		return 0u;
	}

	public void UpdateSetShareRemainTimes(uint remainTimes)
	{
	}

	public uint GetPrimeMaxLevel()
	{
		return 0u;
	}

	public List<uint> GetPrivilegesHiddenList()
	{
		return null;
	}

	public void SyncHiddenList()
	{
	}

	public List<uint> GetPrivilegesHiddenListUI()
	{
		return null;
	}

	public bool IsPrivilegeHiddenDirty()
	{
		return false;
	}

	public int GetLevelNeedPoints(uint level)
	{
		return 0;
	}

	public List<uint> GetSortedPrivilegesByLevel(uint level)
	{
		return null;
	}

	public List<uint> GetAllSortedPrivilegesByLevel(uint level)
	{
		return null;
	}

	public PrimePrivilegeDesc GetPrivilegeDesc(uint privilegeId)
	{
		return null;
	}

	public PrimeCDNDesc GetPrivilegeCDNDesc(uint privilegeId)
	{
		return null;
	}

	public PrimeLeaderboardDesc GetLeaderBoardDesc(uint leaderBoardType)
	{
		return null;
	}

	public List<uint> GetSortedIntroductionPrivilegeIds()
	{
		return null;
	}

	public uint GetPrimeLeaderBoardPointsLimit(uint leaderBoardType)
	{
		return 0u;
	}

	public uint GetPrimeFriendLeaderBoardPointsLimit(uint leaderBoardType)
	{
		return 0u;
	}

	public bool HasPrimePrivilege(PrimePrivilege primePrivilege)
	{
		return false;
	}

	public bool CheckMyPrimePriShowState(PrimePrivilege pri, bool useCache = false)
	{
		return false;
	}

	public string GetPrimeCDNUrl(PrimeCDNKey key)
	{
		return null;
	}

	public uint GetPrimeTodayBestMonthlyRank()
	{
		return 0u;
	}

	public void SetPrimeTodayBestMonthlyRank(uint rank)
	{
	}

	public uint GetLastPrimeRank(UIPrimeLeaderBoardController.TimeFilter timeFilter)
	{
		return 0u;
	}

	public void SetLastPrimeRank(UIPrimeLeaderBoardController.TimeFilter timeFilter, uint rank)
	{
	}

	private string GetPrimeRankKey(UIPrimeLeaderBoardController.TimeFilter timeFilter)
	{
		return null;
	}

	public void CheckNeedShowPrimeTips()
	{
	}

	public bool CheckInNeedRecover()
	{
		return false;
	}

	public bool CheckInWillLeveDown()
	{
		return false;
	}

	public bool CurrentPrimeLevelChanged()
	{
		return false;
	}

	public bool CheckNeedNavToDoublePointsActivityTab()
	{
		return false;
	}

	public void SetCachedPrimeHistoryMaxLevel(uint level)
	{
	}

	public void SetCachedPrimeLevel(uint level)
	{
	}

	public void SetCachedPrimeLastPoints()
	{
	}

	public void UpdateCachedLastChargeMonthId()
	{
	}

	public void UpdateCachedLastShowLevelDownMonthId()
	{
	}

	public void UpdateCachedLastShowWillLevelDownMonthId()
	{
	}

	public void UpdateCachedPrimePoints()
	{
	}

	public void UpdateCachedPrimeEventGems()
	{
	}

	public int GetCachedPrimeEventGems()
	{
		return 0;
	}

	public int GetCachedPrimeEventPoints()
	{
		return 0;
	}

	public bool HasPrimeEventGemsChanged()
	{
		return false;
	}

	private bool GetHasShowedIntroductionInPlayerPrefs()
	{
		return false;
	}

	private bool GetHasShowedIntroductionInBackend()
	{
		return false;
	}

	public bool GetHasShowedIntroduction()
	{
		return false;
	}

	public void SyncPrimeIntroductionShownStateToBackendIfNeeded()
	{
	}

	public void SetHasShowedIntroduction()
	{
	}

	public int GetMonthIdByDateTime(DateTime dt)
	{
		return 0;
	}

	public double GetDaysToNextMonthFirst4AM(DateTime dt)
	{
		return 0.0;
	}

	public int GetNotChargeInterval()
	{
		return 0;
	}

	public PrimeFestivalPopupData GetPrimeUnPopupFestivalInfo()
	{
		return null;
	}

	public void SetTodayFestivalClaimed()
	{
	}

	public List<PrimeFestivalDesc> GetPrimeFestivalDesc()
	{
		return null;
	}

	public PrimeFestivalDesc GetPrimeFestivalDescByFestivalId(uint festivalId)
	{
		return null;
	}

	public List<BaseItemInfo> GetFestivalAwardByFestivalId(uint festivalId)
	{
		return null;
	}

	public bool GetReceivedByFestivalId(uint festivalId)
	{
		return false;
	}

	public bool HasSetBirthday()
	{
		return false;
	}

	public uint GetMyBirthdayMonth()
	{
		return 0u;
	}

	public uint GetMyBirthdayDay()
	{
		return 0u;
	}

	private void InitOriginalPrimeLabelState()
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label, proto.PrimePrivilegeDetail primeDetail, bool defaultShow = true)
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label, tcp.PrimePrivilegeDetail primeDetail, bool defaultShow = true)
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label, BadgeInfoInGame primeDetail, bool defaultShow = true)
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label, List<uint> primeIDList, bool defaultShow = true)
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label)
	{
	}

	public void InitOriginalPrimeLableShowState(UILabel label, bool isPrime)
	{
	}

	public bool CheckPlayerShowPrimeNamePri(proto.PrimePrivilegeDetail detail)
	{
		return false;
	}

	public bool CheckPlayerShowPrimeNamePri(tcp.PrimePrivilegeDetail detail)
	{
		return false;
	}

	public bool CheckPlayerShowPrimeNamePri(BadgeInfoInGame detail)
	{
		return false;
	}

	public bool CheckPlayerShowPrimeNamePri(List<uint> primeIDList)
	{
		return false;
	}

	public void ProcessPrimeStoreInfo(CSGetPrimeStoreRes primeStoreInfo)
	{
	}

	public bool CheckNeedReReqForPrimeShop()
	{
		return false;
	}

	public PrimeStoreItemDesc GetPrimeStoreDescByCommodityId(uint uniqueId)
	{
		return null;
	}

	public PrimeStoreItemDesc GetGiftStoreDescByCommodityId(uint uniqueId)
	{
		return null;
	}

	public bool CheckShowStorePrimeTab()
	{
		return false;
	}

	public bool CheckShowGiftStorePrimeTab()
	{
		return false;
	}

	public GiftItem GetGiftItemByPrimeStoreItemDecs(PrimeStoreItemDesc itemDesc)
	{
		return null;
	}

	public bool CheckCurrentGachaIsInPrimeState(ClientChestType clientChestDesc)
	{
		return false;
	}

	public bool CheckCurrentDrawShopIsInPrimeState(UIModelDrawShop.DrawShopContentDataBase contentData)
	{
		return false;
	}

	private int GetLastLoginPlayerPrefsPlayerPrimeLevelID()
	{
		return 0;
	}

	private void SetLoginPlayerPrefsUtilPriState()
	{
	}

	public bool GetSetShareGroupInfoGuideShowState()
	{
		return false;
	}

	public void SetGuideSetShareGroupInfo()
	{
	}

	public PrimeEventDesc RefreshCurrentPrimeEventDesc()
	{
		return null;
	}

	private bool CheckCurrentPrimeEventDescValid()
	{
		return false;
	}

	public bool CheckCurrentPrimeAccountInfoResValid()
	{
		return false;
	}

	public bool CheckDoublePointsActivityOpen()
	{
		return false;
	}

	public long GetDoublePointsActivityEndTime()
	{
		return 0L;
	}

	public bool CheckDoublePointsActivityTipsClicked()
	{
		return false;
	}

	public void SetDoublePointsActivityTipsClicked()
	{
	}

	public long GetDoublePointsActivityStartTime()
	{
		return 0L;
	}

	public bool CheckDoublePointsActivityContainerFull()
	{
		return false;
	}

	public bool CheckDoublePointsActivityContainerCachedFull()
	{
		return false;
	}

	public int GetEarnedPointsCount()
	{
		return 0;
	}

	public int GetMaxEarnedPointsCount()
	{
		return 0;
	}

	private bool IsActivityDataValid()
	{
		return false;
	}

	public bool CheckDoublePointsActivityTipsExpired()
	{
		return false;
	}

	public void SetDoublePointsActivityTipsExpired()
	{
	}

	public uint GetDoublePointsActivityEventRate()
	{
		return 0u;
	}

	public void TestPrimeDoublePointsActivity(int start = 0, int end = 500)
	{
	}

	private void _003CRequestPrimeAccountInfo_003Eb__62_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPrimeFestivalAccountInfo_003Eb__63_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUpdatePrimePrivilegeSetting_003Eb__68_1(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
