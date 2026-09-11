using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelCraftlandProfile : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkShopCreatorLevel> _003C_003E9__46_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__72_1;

		public static Action _003C_003E9__84_0;

		internal int _003CInit_003Eb__46_0(WorkShopCreatorLevel a, WorkShopCreatorLevel b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimCreatorReward_003Eb__72_1(BaseItemInfo item)
		{
			return null;
		}

		internal void _003CShowPinLimitDialog_003Eb__84_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass55_0
	{
		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		internal void _003CRequestFollow_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass56_0
	{
		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		internal void _003CRequestUnfollow_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass57_0
	{
		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		internal void _003CRequestPinCreator_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass58_0
	{
		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		internal void _003CRequestUnpinCreator_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public WorkshopAuthorInfo authorInfo;

		public CSEditCreatorBioReq req;

		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		internal void _003CRequestEditCreatorBio_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass71_0
	{
		public WorkshopAuthorInfo authorInfo;

		public List<string> currentCodes;

		public UIModelCraftlandProfile _003C_003E4__this;

		internal void _003CRequestUpdateCreatedMapPins_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass72_0
	{
		public UIModelCraftlandProfile _003C_003E4__this;

		public ulong creatorId;

		public uint level;

		internal void _003CRequestClaimCreatorReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass73_0
	{
		public bool disableNameColor;

		internal void _003CRequestUpdateCreatorPrivilegeSwitches_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_FollowListChanged = 1u;

	public const uint PropID_FollowedStatsChanged = 2u;

	public const uint PropID_RedPointChanged = 4u;

	public const uint PropID_ConfigChanged = 8u;

	public const uint PropID_OperationCDChanged = 16u;

	public const uint PropID_PinDataChanged = 32u;

	public const uint PropID_WorkshopCreatorStatsChanged = 64u;

	public const uint PropID_BioChanged = 128u;

	public const uint PropID_ClaimCreatorRewardChanged = 256u;

	public const uint PropID_FollowedCreatorListRedPointChanged = 1024u;

	public const ulong DefaultOpCDSeconds = 5uL;

	public const ulong SelfWorkshopCreatorStatsOpCDSeconds = 300uL;

	public const ulong ClaimCreatorRewardOpCDSeconds = 1uL;

	public const int DefaultBioMaxLength = 40;

	private const string CRAFTLAND_STAT_CACHE_KEY_PREFIX = "ProfileCraftlandStat_";

	private const string CREATOR_LEVEL_UP_POPUP_SHOWN_KEY_PREFIX = "CraftlandCreatorLevelUpPopupShown_";

	private const string FOLLOWED_CREATOR_LIST_VIEWED_AT_KEY_PREFIX = "CraftlandFollowedCreatorListViewedAt_";

	private int m_RemainingFollowCapacity;

	private ulong m_RemainingFollowCapacityUpdateAt;

	private const ulong RemainingFollowCapacityValidSeconds = 300uL;

	private readonly Dictionary<ulong, WorkshopAuthorInfo> m_AuthorInfoCache;

	private readonly Dictionary<ulong, long> m_LastSeenCreatorUpdateAt;

	private readonly Dictionary<uint, ulong> m_LastOpTime;

	private readonly List<AccountInfoBasic> m_Follows;

	private readonly List<ulong> m_FollowsPinnedCreators;

	private readonly Dictionary<ulong, WorkshopCreatorStats> m_FollowedCreatorStats;

	private readonly Dictionary<string, int> m_ProfileStatDeltaResult;

	private readonly Dictionary<string, ulong> m_ProfileStatBaselineRuntime;

	private List<WorkshopCreatorPrivilegeWarp> m_CreatorPrivilegeInfos;

	private CSVAsyncDataMap<uint, WorkShopCreatorLevel> m_WorkShopCreatorLevelMap;

	private uint m_WorkshopCreatorMaxLevel;

	private List<WorkShopCreatorLevel> m_WorkShopCreatorLevelList;

	private bool m_HasFetchedFollows;

	private CraftlandCreatorStats m_WorkShopCreatorStats;

	public List<WorkShopCreatorLevel> WorkShopCreatorLevelList => null;

	public CraftlandCreatorStats WorkShopCreatorStats => null;

	public void RemoveMapFromPinnedMaps(string longShareCode)
	{
	}

	public int GetWorkshopDraftCountLimit()
	{
		return 0;
	}

	public string GetWorkshopDraftCountLimitTips()
	{
		return null;
	}

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

	public override void ClearCache()
	{
	}

	public void ClearProfileStatDeltaResult()
	{
	}

	public override void Init()
	{
	}

	public WorkShopCreatorLevel GetWorkshopCreatorInfoByLv(uint level)
	{
		return null;
	}

	public WorkShopCreatorLevel GetCurrentWorkshopCreatorInfo()
	{
		return null;
	}

	public WorkShopCreatorLevel GetNextWorkshopCreatorInfo()
	{
		return null;
	}

	public uint GetCurrentWorkshopCreatorLv()
	{
		return 0u;
	}

	public bool CheckShowCreatorLevelUpPopup(ref uint lastPopupLevel)
	{
		return false;
	}

	public void MarkCreatorLevelUpPopupShown(uint level)
	{
	}

	public bool HasUnclaimedLevelAward()
	{
		return false;
	}

	public bool CanClaimAwardedLevel(uint level)
	{
		return false;
	}

	public bool RequestFollow(ulong creatorId, AccountInfoBasic basicInfo = null)
	{
		return false;
	}

	public bool RequestUnfollow(ulong creatorId)
	{
		return false;
	}

	public bool RequestPinCreator(ulong creatorId)
	{
		return false;
	}

	public bool RequestUnpinCreator(ulong creatorId)
	{
		return false;
	}

	public void RequestGetFollows(bool force = false)
	{
	}

	public List<AccountInfoBasic> GetFollowList()
	{
		return null;
	}

	public bool TryGetPinnedCreatorIndex(ulong AuthorId, out int index)
	{
		index = default(int);
		return false;
	}

	public void RequestGetFollowedCreatorStats()
	{
	}

	public bool TryGetFollowedCreatorStats(ulong creatorId, out WorkshopCreatorStats stats)
	{
		stats = null;
		return false;
	}

	public Dictionary<ulong, WorkshopCreatorStats> GetFollowedCreatorStats()
	{
		return null;
	}

	public void UpdateFollowedCreatorListViewedAt()
	{
	}

	public bool IsNeedShowFollowedCreatorListRedPoint()
	{
		return false;
	}

	public bool RequestEditCreatorBio(ulong creatorId, string currentBio, string targetBio, WorkshopAuthorInfo authorInfo, out string message)
	{
		message = null;
		return false;
	}

	public List<WorkshopCreatorPrivilegeWarp> GetCreatorPrivilegesForPlatform(uint currentLevel, uint nextLevel)
	{
		return null;
	}

	private string GenWorkshopPrivilegeValueTips(int currentValue, int nextValue)
	{
		return null;
	}

	public List<WorkshopCreatorPrivilegeWarp> GetCreatorPrivilegesForUI()
	{
		return null;
	}

	public void RequestUpdateCreatedMapPins(List<string> currentCodes, WorkshopAuthorInfo authorInfo)
	{
	}

	public bool RequestClaimCreatorReward(ulong creatorId, uint level)
	{
		return false;
	}

	public void RequestUpdateCreatorPrivilegeSwitches(bool disableNameColor)
	{
	}

	public int GetProfileStatDelta(ulong authorId, string statName)
	{
		return 0;
	}

	public void EnsureProfileStatDeltaIfMissing(ulong authorId, string statName, ulong currentValue)
	{
	}

	private bool ValidateBioForSubmit(string currentBio, string targetBio, out string errorCodeOrKey)
	{
		errorCodeOrKey = null;
		return false;
	}

	private bool TryBeginOperation(ECraftlandProfileOperation op, ulong duration, out ulong remainSeconds)
	{
		remainSeconds = default(ulong);
		return false;
	}

	private void SetFollows(List<AccountInfoBasic> follows, List<ulong> pinnedCreatorIds)
	{
	}

	public bool IsFollowing(ulong creatorId)
	{
		return false;
	}

	private bool CanFollow(ulong creatorId, out string reason)
	{
		reason = null;
		return false;
	}

	private void UpdateRemainingFollowCapacity(int value)
	{
	}

	private bool IsRemainingFollowCapacityValid()
	{
		return false;
	}

	private void InvalidateRemainingFollowCapacity()
	{
	}

	private void ShowPinLimitDialog()
	{
	}

	private void ApplyFollowSuccess(CSFollowRes res)
	{
	}

	private void ApplyUnfollowSuccess(ulong creatorId)
	{
	}

	private void ApplyPinCreatorSuccess(ulong creatorId)
	{
	}

	private void ApplyUnpinCreatorSuccess(ulong creatorId)
	{
	}

	private bool CanClaimCreatorReward(CraftlandCreatorStats stats, uint level)
	{
		return false;
	}

	private void ApplyClaimCreatorRewardSuccess(ulong creatorId, uint level)
	{
	}

	public void RequestSelfWorkshopCreatorStats()
	{
	}

	public void UpdateWorkshopCreatorStats(WorkshopCreatorStats stats)
	{
	}

	private void RecalculateProfileStatDeltaByRequest(CSGetWorkshopCreatorStatsRes data)
	{
	}

	private void RecalculateSingleProfileStatDelta(ulong viewerAccountId, ulong authorId, string statName, ulong currentValue, bool overwriteExisting)
	{
	}

	private static ulong GetCacheViewerAccountId()
	{
		return 0uL;
	}

	private string NormalizeText(string value)
	{
		return null;
	}

	private void ClearAllCache()
	{
	}

	private string BuildProfileStatKey(ulong viewerAccountId, ulong authorId, string statName)
	{
		return null;
	}

	private uint GetLastCreatorLevelUpPopupLevel(ulong viewerAccountId)
	{
		return 0u;
	}

	private string BuildCreatorLevelUpPopupShownKey(ulong viewerAccountId)
	{
		return null;
	}

	private string BuildFollowedCreatorListViewedAtKey(ulong viewerAccountId)
	{
		return null;
	}

	private int CalcProfileStatDeltaOnly(ulong viewerAccountId, ulong authorId, string statName, ulong currentValue)
	{
		return 0;
	}

	private bool TryGetProfileStatBaseline(string key, out ulong baselineValue)
	{
		baselineValue = default(ulong);
		return false;
	}

	private void UpdateFollowedCreatorStats(List<WorkshopCreatorStats> statsList)
	{
	}

	private void UpdateProfileStatBaseline(ulong viewerAccountId, ulong authorId, string statName, ulong baselineValue)
	{
	}

	private int SafeConvertDiffToInt(ulong currentValue, ulong baselineValue)
	{
		return 0;
	}

	private void _003CRequestGetFollows_003Eb__59_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetFollowedCreatorStats_003Eb__62_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestSelfWorkshopCreatorStats_003Eb__91_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
