using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelPeriodicLadderMatch : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BaseItemInfo> _003C_003E9__88_1;

		public static Predicate<LeaderBoardInfo> _003C_003E9__95_1;

		public static Comparison<FriendAccountInfo> _003C_003E9__96_2;

		public static Comparison<LeaderBoardInfo> _003C_003E9__96_0;

		internal int _003CGetPeriodicUnlockRewardLevelData_003Eb__88_1(BaseItemInfo a, BaseItemInfo b)
		{
			return 0;
		}

		internal bool _003CRequestLeaderBoardRegion_003Eb__95_1(LeaderBoardInfo x)
		{
			return false;
		}

		internal int _003CRequestLeaderBoardFriend_003Eb__96_2(FriendAccountInfo x, FriendAccountInfo y)
		{
			return 0;
		}

		internal int _003CRequestLeaderBoardFriend_003Eb__96_0(LeaderBoardInfo x, LeaderBoardInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass93_0
	{
		public ulong accoutid;

		public UIModelPeriodicLadderMatch _003C_003E4__this;

		internal void _003CRequestRankingInfoById_003Eb__0(HttpErrorCode errodCode, object res)
		{
		}
	}

	public const string FIRST_TIME_ENTER_LW_RANK_KEY = "FirstTimeEnterLWRank";

	private CSGetCurOrRecentPeriodicRankingConfigRes CurOrRecentRankingSeasonConfig;

	public CSPlayerPeriodicRankingInfoRes CurrentRankInfo;

	private CDTimeData m_CdTimeData;

	private int m_CdOfReqRankInfo;

	private uint m_LeaderBoardSize;

	private Dictionary<ulong, CDTimeData> m_LadderRankingProfileClickDic;

	private Dictionary<ulong, CSPlayerPeriodicRankingInfoRes> m_DictRankInfo;

	private float m_NextReqFriendBoardTime;

	private float m_NextReqRegionBoardTime;

	private List<LeaderBoardInfo> m_LadderBoardFriendList;

	private List<LeaderBoardInfo> m_LadderBoardRegionList;

	private LeaderBoardInfo m_PlayerLeaderBoardFriend;

	private LeaderBoardInfo m_PlayerLeaderBoardRegion;

	private bool m_ReRequestedSeasonConfig;

	private Dictionary<uint, PeriodicProtectionDesc> m_PeriodicProtectionConfig;

	private List<LadderLevelData> m_PeriodicLadderLevelDataList;

	private List<LadderLevelData> m_PeriodicExhibitLevelDataList;

	private Dictionary<uint, LadderLevelData> m_PeriodicLadderLevelDataDic;

	private Dictionary<int, int> m_PeriodicRankMappingDic;

	public uint MaxPeriodicLadderRank;

	public uint PeriodicFirstHasRewardRank;

	public bool IsNeedPeriodicRankMapping;

	public const string PERIODIC_RANK_MAP_SELECT = "periodic_rank_map_select";

	public bool HasUnlockRewardClaimed;

	private List<uint> m_CurrentAvailableSelectedMapIDList;

	public List<PeriodicRankData> PeriodicRankUpRewardList;

	public const uint PropID_RankInfoRefreshed = 4u;

	public const uint PropID_SeasonInfoRefreshed = 8u;

	public const uint PropID_RefreshLeaderBoardFriend = 128u;

	public const uint PropID_RefreshLeaderBoardRegion = 256u;

	public const uint PropID_PeriodicRankMapSelectConfirmed = 1024u;

	public const uint PropID_PeriodicResetMatchRewardClaimSuccess = 2048u;

	public List<LadderLevelData> PeriodicLadderLevelDataList => null;

	public List<LadderLevelData> PeriodicExhibitLevelDataList => null;

	public bool IsResetMatchRewardClaimable => false;

	public List<uint> CurrentAvailableSelectedMapIDList => null;

	public bool ShowPeriodicRankUpReward => false;

	public bool IsResetMatchRewardVisible()
	{
		return false;
	}

	public bool IsPeriodicRankMapSelected(uint mapID)
	{
		return false;
	}

	public void RefreshCurrentPeriodicLadderMapAfterDownload()
	{
	}

	public void UpdateGamePlay(uint cnt)
	{
	}

	public void SaveSelectedRankMaps(Dictionary<uint, bool> mapSelectDictory)
	{
	}

	public void AddTemporaryMapIDToSelectedMapIDList(uint id)
	{
	}

	public void UpdateCurrentAvailableSelectedMapIDList()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Logout(object[] data)
	{
	}

	public bool HasPlayerEnterPeriodicRankLobbyBefore()
	{
		return false;
	}

	public void SetHasPlayerEnterPeriodicRankLobbyKey(bool value)
	{
	}

	public void InitCSRankUpRewardData(uint rank_before, uint rank_after)
	{
	}

	public bool IsProtectedPeriodicRank()
	{
		return false;
	}

	public PeriodicRankingSeasonInfoDesc GetCurrentSeasonInfo()
	{
		return null;
	}

	private PeriodicRankData GetCurrentRankData()
	{
		return null;
	}

	public uint GetCurrentRank()
	{
		return 0u;
	}

	public string GetCurrentLevelRankName()
	{
		return null;
	}

	public uint GetCurrentRankingPoints()
	{
		return 0u;
	}

	public void ClaimRankingResetReward()
	{
	}

	public uint GetRealSeasonID()
	{
		return 0u;
	}

	public ResourceID GetRankIcon(int rank, LadderRankIconType iconType = LadderRankIconType.SmallIcon)
	{
		return default(ResourceID);
	}

	public bool IsDuringSeasonOpenTime()
	{
		return false;
	}

	public uint GetCurrentSeasonGameMode()
	{
		return 0u;
	}

	public uint GetCurrentSeasonMapID()
	{
		return 0u;
	}

	public int GetUnlockLevel(bool isMember = false, bool isMemberGuest = false)
	{
		return 0;
	}

	public bool IsLevelEnough()
	{
		return false;
	}

	public bool IsReachRankThreshold()
	{
		return false;
	}

	public CSPlayerPeriodicRankingInfoRes GetRankingInfoById(ulong accountId)
	{
		return null;
	}

	public float GetKDANum()
	{
		return 0f;
	}

	public bool GetOpeningState()
	{
		return false;
	}

	public List<AwardDesc> GetRankAwardList(uint rank)
	{
		return null;
	}

	public List<LeaderBoardInfo> GetFriendBoardScoreList()
	{
		return null;
	}

	public LeaderBoardInfo GetLocalPlayerBoardFriend()
	{
		return null;
	}

	public LeaderBoardInfo GetLocalPlayerBoardRegion()
	{
		return null;
	}

	public uint GetLeaderBoardSize()
	{
		return 0u;
	}

	public uint GetSeasonAwardId()
	{
		return 0u;
	}

	public string GetCdnUrlSeasonBg()
	{
		return null;
	}

	public void AfterPeriodicLadderMatch(MatchIncome incomeData)
	{
	}

	public override void Init()
	{
	}

	public void RequestInitPlayerRankingInfo(bool silence = false)
	{
	}

	public void RequestGetRankingsInfo(bool immediately = false)
	{
	}

	public void RequestGetCurOrRecentPeriodicRankingConfig(LoadingType loadingType = LoadingType.CircleLoading, uint httpOption = 4u, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void UpdateSeasonInfoConfig(CSGetCurOrRecentPeriodicRankingConfigRes season_info_res)
	{
	}

	public void SetCurSeasonPeriodicLevelData(uint gameMode, uint seasonID)
	{
	}

	public void ProcessSeasonInfoAwards(CSGetCurOrRecentPeriodicRankingConfigRes season_info_res)
	{
	}

	public List<BaseItemInfo> GetPeriodicUnlockRewardLevelData()
	{
		return null;
	}

	public void SetPeriodicProtectionConfig(List<PeriodicProtectionDesc> PeriodicProtectionsDescs, uint gameMode)
	{
	}

	public PeriodicProtectionDesc GetPeriodicProtectionConfigByGamemodeAndRank(uint gameMode, uint rank)
	{
		return null;
	}

	public uint GetPeriodicProtectionConfigKey(uint gameMode, uint rank)
	{
		return 0u;
	}

	public void RequestPlayerRankInfo()
	{
	}

	public void RequestRankingInfoById(ulong accoutid)
	{
	}

	public List<LeaderBoardInfo> GetRegionBoardScoreList()
	{
		return null;
	}

	public void RequestLeaderBoardRegion()
	{
	}

	public void RequestLeaderBoardFriend()
	{
	}

	public uint GetPeriodicRank(ulong acountId)
	{
		return 0u;
	}

	private void _003CClaimRankingResetReward_003Eb__61_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestInitPlayerRankingInfo_003Eb__82_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CRequestGetRankingsInfo_003Eb__83_0(HttpErrorCode errodCode, object res)
	{
	}

	private void _003CRequestGetCurOrRecentPeriodicRankingConfig_003Eb__84_0(HttpErrorCode errodCode, object res)
	{
	}

	private bool _003CGetPeriodicUnlockRewardLevelData_003Eb__88_0(LadderLevelData data)
	{
		return false;
	}

	private void _003CRequestLeaderBoardRegion_003Eb__95_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestLeaderBoardFriend_003Eb__96_1(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
