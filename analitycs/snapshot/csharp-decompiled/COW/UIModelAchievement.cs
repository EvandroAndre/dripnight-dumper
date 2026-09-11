using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelAchievement : UIBaseModel
{
	public enum EAchievementState
	{
		All,
		Completed,
		InCompleted,
		CompleteSoon
	}

	public enum EAchievementSeasonYearState
	{
		CurSeasonYear,
		PastSeasonYear
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<AchStatistics> _003C_003E9__60_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__115_1;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__116_1;

		public static Action<HttpErrorCode, object> _003C_003E9__121_0;

		internal int _003CRefreshFriendsAchStatisticsInfo_003Eb__60_0(AchStatistics a, AchStatistics b)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimAchievementEntryAward_003Eb__115_1(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimStatsAchievementAward_003Eb__116_1(BaseItemInfo item)
		{
			return null;
		}

		internal void _003CRequestUpdateAccountAnniversaryTips_003Eb__121_0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass102_0
	{
		public AchievementEntryDesc entryDesc;

		internal bool _003CGetAchievementEntryAwardState_003Eb__0(AchievementLevelInfo levelInfo)
		{
			return false;
		}

		internal bool _003CGetAchievementEntryAwardState_003Eb__1(uint level)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass104_0
	{
		public AchievementConfigDesc configDesc;

		internal bool _003CGetAchievementStatsAwardState_003Eb__0(uint level)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass114_0
	{
		public UIModelAchievement _003C_003E4__this;

		public ulong curTimeStamp;

		public uint gotoAchievementId;

		public bool isAnniversary;

		internal void _003CRequestAchievementInfo_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass115_0
	{
		public UIModelAchievement _003C_003E4__this;

		public uint id;

		public uint level;

		internal void _003CRequestClaimAchievementEntryAward_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass116_0
	{
		public UIModelAchievement _003C_003E4__this;

		public proto.EAchievement.Type type;

		public uint level;

		internal void _003CRequestClaimStatsAchievementAward_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIModelAchievement _003C_003E4__this;

		public uint achId;

		internal void _003CRequestFriendsAchStatisticsInfo_003Eb__0(HttpErrorCode err, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public AchStatistics statistic;

		internal bool _003CRefreshFriendsAchStatisticsInfo_003Eb__1(AchStatistics temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_1
	{
		public AchievementEntryDesc desc;

		internal bool _003CRefreshFriendsAchStatisticsInfo_003Eb__2(AchStatistics temp)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public uint level;

		internal bool _003CGetEntryDescByIdAndLevel_003Eb__0(AchievementEntryDesc entryDesc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass98_0
	{
		public uint awardId;

		public Predicate<AwardDesc> _003C_003E9__0;

		internal bool _003CGetAchievementIdByAwardId_003Eb__0(AwardDesc a)
		{
			return false;
		}
	}

	public const uint EGG_ACHIEVEMENT_SUB_TYPE = 29u;

	public const uint BIG_EVENT_ACHIEVEMENT_SUB_TYPE_ALL = 60u;

	public const uint BIG_EVENT_ACHIEVEMENT_SUB_TYPE_IP = 69u;

	private bool m_HasDesc;

	private bool m_HasInfo;

	private Dictionary<uint, AchievementEntryInfo> m_EntryInfoDict;

	private Dictionary<uint, AchievementStats> m_StatsInfoDict;

	private Dictionary<uint, List<AchievementEntryDesc>> m_EntryDescListDict;

	private Dictionary<uint, List<AchievementConfigDesc>> m_ConfigDescDict;

	private Dictionary<uint, AchievementSeasonYearDesc> m_PastSeasonYearDescDict;

	private AchievementSeasonYearDesc m_CurSeasonYearDesc;

	private Dictionary<uint, List<AchStatistics>> m_AchStatisticsInfoDict;

	private Dictionary<uint, uint> m_AllRarityCompletedCount;

	private Dictionary<uint, AchievementTypeData> m_AchievementStateConfigDict;

	private List<uint> m_CompletedAndUnpopedEntryIDList;

	private List<uint> m_CacheSortAchievementIdList;

	private Dictionary<uint, uint> m_NewCompletedEntryLevelFlagDict;

	private HashSet<uint> m_NewCompletedEntrySet;

	private ulong m_LastRequestInfoTimeStamp;

	private const ulong REQUEST_INFO_CD = 3600uL;

	private bool m_IsRequestingDesc;

	private bool m_IsRequestingInfo;

	private bool m_IsRequestingClaimAchievementTypeAward;

	private bool m_IsRequestingClaimAchievementEntryAward;

	private int m_TipsNum;

	private List<AchievementUpdateNtf> m_AchievementUpdateNtfList;

	private List<int> m_CanClaimCategoryAwardList;

	private Dictionary<uint, AchievementEntryDesc> m_CanClaimAchievementAwardDict;

	private List<AchievementUpdateNtf> m_CacheSyncHistoryTcpInfoList;

	private Dictionary<uint, ResourceID> m_AchievementUIFXTypeDict;

	private Dictionary<uint, AchievementsRankConfig> m_AchievementsRankConfigDict;

	private List<uint> m_AchievementsRankConfigPercentageList;

	public const uint PropID_Desc_Update = 2u;

	public const uint PropID_Info_Update = 4u;

	public const uint PropID_Claime_Entry_Award = 8u;

	public const uint PropID_Claime_Stats_Award = 16u;

	public const uint PropID_Update_AchStatisticsInfo = 32u;

	public AchievementSeasonYearDesc CurSeasonYearDesc => null;

	public List<uint> CompletedAndUnpopedEntryIDList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<int> CanClaimCategoryAwardList => null;

	public Dictionary<uint, AchievementEntryDesc> CanClaimAchievementAwardDict => null;

	public Dictionary<uint, ResourceID> AchievementUIFXTypeDict => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	private void ClearDescData()
	{
	}

	private void ClearInfoData()
	{
	}

	private void ClearAchStatisticsInfoData()
	{
	}

	public void ClearTipBoxData()
	{
	}

	private void InitDesc(CSGetAllAchievementDescRes desc)
	{
	}

	private void InitSeasonYearDesc(List<AchievementSeasonYearDesc> desc)
	{
	}

	private void InitInfo(CSGetAccountAchievementInfoRes info)
	{
	}

	private void RefreshFriendsAchStatisticsInfo(CSGetFriendsAchStatisticsRes info, uint achId)
	{
	}

	private proto.EAchievement.Type GetAchievementType(uint achievementId)
	{
		return proto.EAchievement.Type.Type_NONE;
	}

	private int CompareEntryIdByDesc(AchievementEntryDesc curDesc, AchievementEntryDesc nextDesc)
	{
		return 0;
	}

	private int CompareEntryLevel(AchievementEntryDesc curEntryDesc, AchievementEntryDesc nextEntryDesc)
	{
		return 0;
	}

	private int CompareAllEntryId(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareCompletedEntryId(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareCompleteSoonEntryId(uint curId, uint nextId)
	{
		return 0;
	}

	private int CompareIncompletedEntryId(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareCompletedAndUnpopedEntryID(uint curID, uint nextID)
	{
		return 0;
	}

	private int CompareStatsConfig(AchievementConfigDesc curConfigDesc, AchievementConfigDesc nextConfigDesc)
	{
		return 0;
	}

	private bool IsAchievementValid(uint achievementId)
	{
		return false;
	}

	private void AddNewCompletedEntryFlag(uint entryId, uint level)
	{
	}

	private void UpdateEntryInfo(List<AchievementEntryUpdateInfo> entryInfoList)
	{
	}

	private void UpdateStatsInfo(List<AchievementStatsUpdateInfo> statsInfoList)
	{
	}

	private bool IsAchievementCompleteSoon(uint achievementId)
	{
		return false;
	}

	public AchievementTypeData GetAchievementTypeData(proto.EAchievement.Type type)
	{
		return null;
	}

	public bool IsEggAchievement(uint achievementId)
	{
		return false;
	}

	public bool IsAchievementCompleted(uint achievementId)
	{
		return false;
	}

	public uint GetAchievementLevel(uint achievementId)
	{
		return 0u;
	}

	public uint GetBigEventAchievementSubTypeId(uint bigEventAchievementId)
	{
		return 0u;
	}

	public AchievementEntryDesc GetEntryDescByIdAndLevel(uint id, uint level)
	{
		return null;
	}

	public List<AchievementEntryDesc> GetEntryDescListById(uint id)
	{
		return null;
	}

	public AchievementEntryInfo GetEntryInfoById(uint id)
	{
		return null;
	}

	public AchievementStats GetStatsInfoByType(proto.EAchievement.Type type)
	{
		return null;
	}

	public List<uint> GetAchievementPastSeasonYear()
	{
		return null;
	}

	public AchievementSeasonYearDesc GetAchievementPastSeasonYearDesc(uint seasonYear)
	{
		return null;
	}

	public uint GetCanClaimCategoryId()
	{
		return 0u;
	}

	public uint GetCanClaimAchievementId()
	{
		return 0u;
	}

	public bool IsActiveEvent(uint achievementId)
	{
		return false;
	}

	public List<uint> GetSortedEntryIds(proto.EAchievement.Type type, EAchievementState state, EAchievementSeasonYearState seasonYearState = EAchievementSeasonYearState.CurSeasonYear, uint seasonYear = 0u, uint bigEventSubTypeId = 60u)
	{
		return null;
	}

	public List<AchievementConfigDesc> GetConfigDescList(proto.EAchievement.Type type)
	{
		return null;
	}

	public uint GetTotalAchievementPointsByType(proto.EAchievement.Type type)
	{
		return 0u;
	}

	public void GetTotalAchievementRankingByRankInfoAndPoints(string rankInfo, uint points, out uint rank, out string color)
	{
		rank = default(uint);
		color = null;
	}

	public void GetTotalAchievementRankingByType(proto.EAchievement.Type type, out uint rank, out string color)
	{
		rank = default(uint);
		color = null;
	}

	public string GetFriendAchievenmentLabelByAchievementId(uint achievementId)
	{
		return null;
	}

	public bool CheckFriendAchievenmentInfo(uint achievementId)
	{
		return false;
	}

	public void UpdateCompletedAchievementRarityCount(AchievementEntryInfo entryInfo, bool isAdd)
	{
	}

	public uint GetCompletedAchievementRarityCount(uint rarity)
	{
		return 0u;
	}

	public uint GetAchievementIdByAwardId(uint awardId)
	{
		return 0u;
	}

	public bool CheckHasLockedEntryAward(uint achievementId)
	{
		return false;
	}

	public bool CheckCanClaimeEntryAward(uint achievementId)
	{
		return false;
	}

	public AchievementEntryDesc GetHighestClaimableEntryAwardDesc(uint achievementId)
	{
		return null;
	}

	public void GetAchievementEntryAwardState(AchievementEntryDesc entryDesc, AchievementEntryInfo entryInfo, out bool isCompleted, out bool isClaimable)
	{
		isCompleted = default(bool);
		isClaimable = default(bool);
	}

	public bool CheckCanClaimeStatsAward(proto.EAchievement.Type achType)
	{
		return false;
	}

	public void GetAchievementStatsAwardState(AchievementConfigDesc configDesc, out bool isCompleted, out bool isClaimable)
	{
		isCompleted = default(bool);
		isClaimable = default(bool);
	}

	public bool HasAchievementEntryDescInited()
	{
		return false;
	}

	public bool CheckIsEntryLevelNewCompleted(uint entryId, uint level)
	{
		return false;
	}

	public void RemoveNewCompletedEntryLevelFlag(uint entryId)
	{
	}

	public bool CheckIsEntryNewCompleted(uint entryId)
	{
		return false;
	}

	public void RemoveNewCompletedEntry(uint entryId)
	{
	}

	public void ClearNewCompletedDict()
	{
	}

	public bool CheckIsIPBigEvent(uint id)
	{
		return false;
	}

	public void UpdateAchievementRedPoint(int changedNum)
	{
	}

	public void RequestAchievementDesc(bool sendImmediately = false)
	{
	}

	public void RequestAchievementInfo(uint gotoAchievementId = 0u, bool sendImmediately = false, bool isAnniversary = false)
	{
	}

	public void RequestClaimAchievementEntryAward(uint id, uint level)
	{
	}

	public void RequestClaimStatsAchievementAward(proto.EAchievement.Type type, uint level)
	{
	}

	public void OnAchievementUpdateNotification(AchievementUpdateNtf updatedInfo)
	{
	}

	public void EquipAchievement(List<proto.EquipAchInfo> achInfo)
	{
	}

	public void RequestFriendsAchStatisticsInfo(uint achId)
	{
	}

	public bool NeedShowAnniversaryRemind()
	{
		return false;
	}

	public void RequestUpdateAccountAnniversaryTips()
	{
	}

	private void _003CRequestAchievementDesc_003Eb__113_0(HttpErrorCode err, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
