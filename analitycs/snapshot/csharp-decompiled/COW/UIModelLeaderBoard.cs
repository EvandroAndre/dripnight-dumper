using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelLeaderBoard : UIBaseModel
{
	private enum LeaderBoardProfileType
	{
		None,
		Account,
		Clan,
		Championship
	}

	private sealed class _003C_003Ec__DisplayClass105_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		internal void _003CRequestBigEventLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		public CSLeaderboardReq req;

		internal void _003CHandleAccountGlobalLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass108_1
	{
		public AccountLeaderboardItem localPlayerInfo;

		public _003C_003Ec__DisplayClass108_0 CS_0024_003C_003E8__locals1;

		internal void _003CHandleAccountGlobalLeaderBoard_003Eb__1(HttpErrorCode errorCode1, object res1)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass109_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		public Action<HttpErrorCode, object> _003C_003E9__1;

		internal void _003CHandleClanGlobalLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CHandleClanGlobalLeaderBoard_003Eb__1(HttpErrorCode errorCode1, object res1)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass111_0
	{
		public uint propID;

		public UIModelLeaderBoard _003C_003E4__this;

		public uint boardV2ID;

		internal void _003CHandleAccountRegionLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		internal void _003CHandleClanRegionLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass113_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		internal void _003CHandleChampionshipRegionLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public bool isLadder;

		public bool isPlatform;

		public UIModelLeaderBoard _003C_003E4__this;

		public uint propID;

		public uint boardV2ID;

		internal void _003CRequestFriendInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass124_0
	{
		public ulong myAccountID;

		internal bool _003CUpdateMyLadderInfo_003Eb__0(LeaderBoardInfo item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass128_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public LeaderBoardIDV2 boardID;

		public Action<HttpErrorCode, object> _003C_003E9__1;

		internal void _003CHandleLeaderBoard_GuildActiveGlobalV2_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CHandleLeaderBoard_GuildActiveGlobalV2_003Eb__1(HttpErrorCode errorCode1, object res1)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass129_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public LeaderBoardIDV2 boardID;

		public Action<HttpErrorCode, object> _003C_003E9__1;

		internal void _003CHandleLeaderBoard_GuildActive_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CHandleLeaderBoard_GuildActive_003Eb__1(HttpErrorCode errorCode1, object res1)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass130_0
	{
		public LeaderBoardIDV2 boardID;

		public UIModelLeaderBoard _003C_003E4__this;

		public UIModelUser modelUser;

		internal void _003CHandleLeaderBoard_GuildWarIndividual_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass131_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public LeaderBoardIDV2 boardID;

		public CSLeaderboardReq req;

		internal void _003CHandleLeaderBoard_GuildWarGuild_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass134_0
	{
		public UIModelUser modelUser;

		internal bool _003CUpdateGuildWarChampionshipScore_003Eb__0(LeaderBoardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass135_0
	{
		public UIModelUser modelUser;

		internal bool _003CUpdateGuildWarGuildList_003Eb__0(LeaderBoardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public LeaderBoardIDV2 boardID;

		public UIModelLeaderBoard _003C_003E4__this;

		internal void _003CRequestOthersGuildWarGuild_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass137_0
	{
		public LeaderBoardIDV2 boardID;

		public UIModelLeaderBoard _003C_003E4__this;

		internal void _003CRequestGuildWarChampionship_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass187_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public string cmd;

		public Action onSuccess;

		internal void _003CRequesetClanLeaderBoardAreaDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass202_0
	{
		public ELeaderboard.LeaderboardMainType leaderBoardType;

		internal bool _003CGetLocalClanLeaderBoardIdByType_003Eb__0(ClanAreaLeaderboardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass207_0
	{
		public UIModelLeaderBoard _003C_003E4__this;

		public string cmd;

		public bool needSetModelClanWarFlag;

		public Action onSuccess;

		internal void _003CRequestClanAreaInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass216_0
	{
		public string areaCode;

		public Predicate<string> _003C_003E9__0;

		internal bool _003CGetAutoLocationInfo_003Eb__0(string x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public bool isPlatform;

		public UIModelLeaderBoard _003C_003E4__this;

		public bool isLadder;

		internal void _003CDeprecated_RequestFriendInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass82_0
	{
		public ulong accountId;

		internal bool _003CCacheUpdateEPBadgeCount_003Eb__0(LeaderBoardInfo e)
		{
			return false;
		}
	}

	public const int PropID_GetSOLOLeaderBoard = 1;

	public const int PropID_GetDUOLeaderBoard = 2;

	public const int PropID_GetSQUADLeaderBoard = 4;

	public const int PropID_FriendLeaderBoard = 8;

	public const int PropID_GlobleLeaderBoard = 16;

	public const int PropID_GetRegionData = 32;

	public const int PropID_WinsLeaderBoard = 64;

	public const int PropID_KDLeaderBoard = 128;

	public const int PropID_KillsLeaderBoard = 256;

	public const int PropID_ClanAreaInfoUpdate = 512;

	public const int PropID_ScoreLeaderBoard = 1024;

	public const int PropID_GetEmptyData = 2048;

	public const int PropID_EPBadgeLeaderBoard = 4096;

	public const int PropID_GetWeekData = 8192;

	public const int PropID_GetTotalData = 16384;

	public const int PropID_GetHonor = 32768;

	public const int PropID_GuildWeekInfoUpdate = 65536;

	public const int PropID_TeamFFC = 131072;

	public const int PropID_TeamThirdParty = 262144;

	public const int PropID_CSWinsLeaderBoard = 524288;

	public const int PropID_CSKillsLeaderBoard = 1048576;

	public const int PropID_CSKDLeaderBoard = 2097152;

	public const int PropID_ClanWarLeaderBoard = 4194304;

	public const int PropID_WeaponPowerLeaderBoard = 8388608;

	public const int PropID_PVETimeLimit = 16777216;

	public const int PropID_PVEInfinite = 33554432;

	public const int PropID_CSLadderMatch = 67108864;

	public const int PropID_LeaderBoardV2 = 1073741824;

	public const int LEADERBOARD_SIZE = 100;

	public const int TEAM_LEADERBOARD_SIZE = 3000;

	private List<FriendAccountInfo> m_LadderFriendList;

	private List<FriendAccountInfo> m_FriendList;

	private HashSet<ulong> m_LadderFriendIDSet;

	private HashSet<ulong> m_FriendIDSet;

	private HashSet<int> m_ClosedLeaderBoardSet;

	private Dictionary<int, List<LeaderBoardInfo>> m_DicLeaderBoardList;

	private Dictionary<uint, List<LeaderBoardInfo>> m_DicLeaderBoardList_V2;

	private Dictionary<int, LeaderBoardInfo> m_LocalPlayerInfos;

	private Dictionary<uint, LeaderBoardInfo> m_LocalPlayerInfos_V2;

	private Dictionary<uint, float> m_DicLeaderBoardCD;

	private Dictionary<uint, float> m_DicLeaderBoardCD_V2;

	private Dictionary<uint, uint> m_DicLeaderBoardSize;

	private Dictionary<uint, uint> m_DicLeaderBoardSize_V2;

	private HashSet<uint> m_RunningRequestPropIDCache;

	private HashSet<uint> m_RunningRequestPropIDCache_V2;

	public CSGetClanWeekLeaderboardInfoRes m_GuildWeekInfo;

	private float m_LastUpdateFriendLadderTime;

	private float m_LastUpdateFriendRankingTime;

	private bool m_GameFriendLadderDataHasCome;

	private bool m_FBFriendLadderDataHasCome;

	private bool m_GameFriendStatsDataHasCome;

	private bool m_FBFriendStatsDataHasCome;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private Action m_PendingGuildWarGuildRequest;

	private UIModelHuntingGround m_ModelHuntingGround;

	private ELeaderboardDeleteAreaType m_ClanAreaDeleteType;

	private bool m_IsAutoGetCountry;

	private bool m_IsAutoGetProvince;

	private bool m_IsAutoGetCity;

	private Dictionary<uint, LocationAreaDes> m_DicClanCountryIDToCountryDesc;

	private Dictionary<uint, List<LocationAreaDes>> m_DicClanCountryIDToProvinceDesc;

	private Dictionary<uint, List<LocationAreaDes>> m_DicClanProvinceIDToCityDesc;

	private Dictionary<uint, LocationAreaDes> m_DicAreaIDToDesc;

	private uint m_NextAreaId;

	private BaseLeaderBoardAreaData m_NextChosenArea;

	private long m_NextChooseClanAreaTime;

	private BaseLeaderBoardAreaData m_CurrentChosenArea;

	private readonly List<ClanLeaderboardAreaListDesc> m_ListLocalPlayerClanLeaderBoardAreaDesc;

	private readonly Dictionary<uint, ClanLeaderboardAreaListDesc> m_DicLocalPlayerClanAreaDescDelete;

	private ClanLeaderboardSettingsDesc m_LocalPlayerSettingClanLeaderBoardDesc;

	private Dictionary<string, Dictionary<uint, ClanAreaLeaderboardDesc>> m_DicRegionToDicClanLeaderboardDesc;

	private ClanAreaLeaderboardDesc m_FirstClanLeaderBoardDesc;

	private CSClanAreaLeaderboardDescRes m_ClanLeaderBoardDesc;

	private CSGetClanAreaLeaderboardInfoRes m_NoClanAreaInfo;

	private CSGetClanAreaLeaderboardInfoRes m_ClanAreaInfo;

	public bool IsAutoGetCountry => false;

	public bool IsAutoGetProvince => false;

	public bool IsAutoGetCity => false;

	public Dictionary<uint, LocationAreaDes> DicAreaIDToDesc => null;

	public uint NextAreaId => 0u;

	public bool NeedSetClanLocationByPlayer => false;

	public BaseLeaderBoardAreaData NextChosenArea => null;

	public long NextChooseClanAreaTime => 0L;

	public BaseLeaderBoardAreaData CurrentChosenArea => null;

	public CSClanAreaLeaderboardDescRes ClanLeaderBoardDesc => null;

	public CSGetClanAreaLeaderboardInfoRes ClanAreaInfo => null;

	public override void Init()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private void InitClosedLeaderBoard()
	{
	}

	public LeaderBoardInfo GetLocalPlayerInfo(int propID, uint boardID = 0u)
	{
		return null;
	}

	private void SetLocalPlayerInfo(int propID, LeaderBoardInfo info, uint boardId = 0u)
	{
	}

	public List<LeaderBoardInfo> GetLeaderBoardList(int propID, uint boardID = 0u)
	{
		return null;
	}

	public bool IsLeaderBoardClosed(int propID)
	{
		return false;
	}

	public void Deprecated_AddLeaderBoardDataByPropIDDeduplicate(int propID, LeaderBoardInfo data)
	{
	}

	public void AddLeaderBoardDataByPropID(int propID, LeaderBoardInfo data)
	{
	}

	public void AddV2LeaderBoardDataByBoardID(uint boardID, LeaderBoardInfo data)
	{
	}

	public void AddLeaderBoardData(List<LeaderBoardInfo> list, LeaderBoardInfo data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public void ClearFriendRequestWhenFail()
	{
	}

	public void Deprecated_UpdateFriendBoard(List<FriendAccountInfo> friend_list, EAccountAdscription type, bool isLadder = false)
	{
	}

	private void Deprecated_InitFriendLeaderBoardList(int propId)
	{
	}

	public void Deprecated_SortFriendBoardWithPropID(int propID, List<LeaderBoardInfo> board_list)
	{
	}

	private void Deprecated_RefreshAllFriendRankingStats(bool isLadder, bool silence = false)
	{
	}

	private void Deprecated_RefreshGameFriendStats(bool isLadder, bool silence = false)
	{
	}

	public void Deprecated_RefreshPlatformFriendList(bool isLadder)
	{
	}

	private void Deprecated_RequestFriendInfo(object req, bool isPlatform, bool isLadder, bool silence = false)
	{
	}

	public void CacheUpdateSelfEPBadge()
	{
	}

	private void CacheUpdateEPBadgeCount(int propID, ulong accountId, uint count)
	{
	}

	public void SortFriendBoardWithPropID(uint propID, List<LeaderBoardInfo> board_list)
	{
	}

	public void SortFriendBoardWithBoardV2ID(uint boardV2ID, List<LeaderBoardInfo> board_list)
	{
	}

	private int SortFriendBoardItemWithHCScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithHCWorth(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithHCProfit(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPrimeMonthly(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPrimeYearly(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPrimeTotal(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithWins(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithKills(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithBRKD(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithCSKD(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private void SortPVETimeLimitLeaderBoardList(List<LeaderBoardInfo> leaderBoardList)
	{
	}

	private int SortFriendBoardItemWithPVEInfiniteData(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPVEPassTime(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPVEDamage(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPVETotalScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortFriendBoardItemWithPVEHighestScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortBoardItemWithEPBadges(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	private int SortBoardItemByScore(LeaderBoardInfo a, LeaderBoardInfo b)
	{
		return 0;
	}

	public void RequestFriendLeaderBoard(uint propID, bool silence = false, uint boardV2ID = 0u)
	{
	}

	public void RequestBigEventLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true)
	{
	}

	public void RequestLeaderBoard(uint propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true, bool forceRequestIfBoardEmpty = true, uint boardV2ID = 0u)
	{
	}

	private void RequestGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	private void HandleAccountGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	private void HandleClanGlobalLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	private void RequestRegionLeaderBoard(uint propID, CSLeaderboardReq req, LoadingType loadingType = LoadingType.CircleLoading, uint boardV2ID = 0u)
	{
	}

	private void HandleAccountRegionLeaderBoard(uint propID, CSLeaderboardReq req, LoadingType loadingType = LoadingType.CircleLoading, uint boardV2ID = 0u)
	{
	}

	private void HandleClanRegionLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	private void HandleChampionshipRegionLeaderBoard(uint propID, CSLeaderboardReq req)
	{
	}

	private LeaderBoardProfileType GetLeaderBoardProfileType(int mainType)
	{
		return LeaderBoardProfileType.None;
	}

	private bool IsInRequestCD(uint propID, uint boardV2ID = 0u)
	{
		return false;
	}

	public void RequestClanWeekLeaderBoardInfo()
	{
	}

	private void UpdateFriendLeaderboard(uint propID, uint boardV2ID = 0u)
	{
	}

	private void RefreshAllFriendRankingStats(uint propID, bool isLadder, bool silence = false, uint boardV2ID = 0u)
	{
	}

	private void ClearDirtyFriendData(bool isLadder)
	{
	}

	private void RefreshGameFriendStats(uint propID, bool isLadder, bool silence = false, uint boardV2ID = 0u)
	{
	}

	public void RefreshPlatformFriendList(uint propID, bool isLadder, bool silence = false, uint boardV2ID = 0u)
	{
	}

	private void RequestFriendInfo(uint propID, object req, bool isPlatform, bool isLadder, bool silence = false, uint boardV2ID = 0u)
	{
	}

	public void UpdateMyLadderInfo(LadderRankInfo rankInfo)
	{
	}

	public string GetClanRegionData()
	{
		return null;
	}

	public uint GetLeaderBoardSize(uint propID, uint boardID = 0u)
	{
		return 0u;
	}

	private void RequestV2LeaderBoard(uint boardV2ID, CSLeaderboardReq req, uint propID)
	{
	}

	private void HandleLeaderBoard_GuildActiveGlobalV2(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	private void HandleLeaderBoard_GuildActive(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	private void HandleLeaderBoard_GuildWarIndividual(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	private void HandleLeaderBoard_GuildWarGuild(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	private void HandleLeaderBoard_GuildWarChampionship(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	public void OnGuildWarScoreUpdate(uint season)
	{
	}

	public void UpdateGuildWarChampionshipScore(bool notifyWhenChange)
	{
	}

	private void UpdateGuildWarGuildList(uint notifyID, List<LeaderBoardInfo> list, bool notifyWhenChange)
	{
	}

	private void RequestOthersGuildWarGuild(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	private void RequestGuildWarChampionship(LeaderBoardIDV2 boardID, CSLeaderboardReq req)
	{
	}

	public Dictionary<string, Dictionary<uint, ClanAreaLeaderboardDesc>> GetDicRegionToDicClanLeaderboardDesc()
	{
		return null;
	}

	public ClanAreaLeaderboardDesc GetLocalPlayerFirstClanLeaderBoard()
	{
		return null;
	}

	public bool IsClanLeaderBoardAreaDescReady()
	{
		return false;
	}

	private void SetChooseAreaTimeByArea(CSGetClanAreaLeaderboardInfoRes areaInfo)
	{
	}

	public bool IsAutoLocateOpen()
	{
		return false;
	}

	private void ProcessClanAreaDic()
	{
	}

	public string GetClanAreaNameDescByAreaId(uint areaId)
	{
		return null;
	}

	public uint GetNoRegionAreaId()
	{
		return 0u;
	}

	public void RequesetClanLeaderBoardAreaDesc(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, Action onSuccess = null)
	{
	}

	private void ProcessLocalPlayerClanLeaderBoardDataByRegion()
	{
	}

	public ClanLeaderboardAreaListDesc GetDeleteClanLeaderboardAreaListDesc(uint areaID)
	{
		return null;
	}

	private void ProcessClanLeaderBoardDesc()
	{
	}

	public bool IsClanActiveLeaderBoardOpen()
	{
		return false;
	}

	private void TryBuildNoClanPlayerAreaInfoRes()
	{
	}

	public void ResetLeaderBoardClanInfo()
	{
	}

	private void RemoveClanActiveLeaderBoardInfoInV2Dic()
	{
	}

	private void RemoveClanWarLeaderBoardInfoInV2Dic()
	{
	}

	public List<LocationAreaDes> GetClanCountryAreaDescList()
	{
		return null;
	}

	public List<LocationAreaDes> GetClanProvinceAreaDescListByCountryID(uint countryID)
	{
		return null;
	}

	public List<LocationAreaDes> GetClanCityAreaListByProvinceID(uint provinceID)
	{
		return null;
	}

	public bool HasClanProvinceAreaDescByCountryID(uint countryID)
	{
		return false;
	}

	public bool HasClanCityAreaDescByProvinceID(uint provinceID)
	{
		return false;
	}

	public void RequestChangeClanLeaderBoardArea(uint areaID)
	{
	}

	public ulong GetLocalClanLeaderBoardIdByType(ELeaderboard.LeaderboardMainType leaderBoardType, uint leaderBoardRegionType)
	{
		return 0uL;
	}

	private ClanLeaderBoardRegionType GetLocalClanLeaderBoardRegionTypeByID(ulong id)
	{
		return ClanLeaderBoardRegionType.None;
	}

	private bool CheckGetLocalClanLeaderBoardIsDelete(ulong id)
	{
		return false;
	}

	public uint GetClanLeaderBoardSizeByBoardID(ulong subkey, string lockRegion)
	{
		return 0u;
	}

	private void SetLeaderBoarListByArea(CSClanLeaderboardAreaChooseRes info)
	{
	}

	public void RequestClanAreaInfo(bool force = false, bool needSetModelClanWarFlag = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, Action onSuccess = null)
	{
	}

	public void OnRespondClanAreaInfo(CSGetClanAreaLeaderboardInfoRes info)
	{
	}

	private void SetDeleteAreaType(CSGetClanAreaLeaderboardInfoRes infos)
	{
	}

	private bool HasDeleteAreaInLeaderboardInfo(List<ClanAreaLeaderboardInfo> clanAreaLeaderboards)
	{
		return false;
	}

	private ClanAreaLeaderboardDesc GetClanAreaLeaderboardDesc(ulong subKey)
	{
		return null;
	}

	public bool IsClanCurAreaDelete()
	{
		return false;
	}

	private void SetCountryProvinceName()
	{
	}

	private void SetNextAreaData()
	{
	}

	private void ProcessNextAreaDataByAuto()
	{
	}

	public bool GetAutoLocationInfo(string city, string subdivision)
	{
		return false;
	}

	private void SetNextAreaDataByDesc(ClanLeaderboardAreaListDesc areaDesc)
	{
	}

	public bool IsClanLeaderBoardAreaGet()
	{
		return false;
	}

	private void ProcessCurAreaDataByInfo()
	{
	}

	public bool SetCurClanAreaDataByLeaderBoardAreaId(ulong subkey, BaseLeaderBoardAreaData areaData)
	{
		return false;
	}

	public void RequestClanMembers(LeaderBoardIDV2 boardV2)
	{
	}

	public uint RequestClanWarLeaderBoard(bool force, ELeaderBoardTitleRegionType type, uint season, uint round)
	{
		return 0u;
	}

	public uint RequestClanWarChampionshipLeaderBoard(bool force, uint season)
	{
		return 0u;
	}

	public bool CheckCanGetRealRankScore(bool isBR)
	{
		return false;
	}

	private void _003CRequestClanWeekLeaderBoardInfo_003Eb__117_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestChangeClanLeaderBoardArea_003Eb__201_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CSetNextAreaData_003Eb__214_0(ClanLeaderboardAreaListDesc x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
