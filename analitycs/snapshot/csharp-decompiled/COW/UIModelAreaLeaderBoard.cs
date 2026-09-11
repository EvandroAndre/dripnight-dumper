using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelAreaLeaderBoard : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass118_0
	{
		public RankingPlayerTitleInfo titleInfo;

		internal bool _003CProcessTitlesDic_003Eb__0(AreaLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass120_0
	{
		public CSPeakPlayerTitleInfo titleInfo;

		internal bool _003CProcessCSPeakTitlesDic_003Eb__0(AreaLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass121_0
	{
		public uint title_cfg_id;

		internal bool _003CGetRegionTypeByTitleCfgId_003Eb__0(AreaLeaderboardTitleDesc x)
		{
			return false;
		}

		internal bool _003CGetRegionTypeByTitleCfgId_003Eb__1(AreaLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass148_0
	{
		public ELeaderboard.LeaderboardMainType leaderBoardType;

		internal bool _003CGetAreaLeaderBoardId_003Eb__0(AreaLeaderboardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass149_0
	{
		public ELeaderboard.LeaderboardMainType leaderBoardType;

		internal bool _003CGetPeakAreaLeaderBoardId_003Eb__0(AreaLeaderboardInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass160_0
	{
		public uint titleCfgID;

		internal bool _003CGetLeaderboardMainTypeByTitleCfgID_003Eb__0(AreaLeaderboardTitleDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass176_0
	{
		public string areaCode;

		public Predicate<string> _003C_003E9__0;

		internal bool _003CGetAutoLocationInfo_003Eb__0(string x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass220_0
	{
		public RankingPlayerTitleInfo playerTitleInfo;

		internal bool _003CTryRefreshTitleSelectedState_003Eb__0(proto.RankingTitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass221_0
	{
		public CSPeakPlayerTitleInfo playerTitleInfo;

		internal bool _003CTryRefreshPeakTitleSelectedState_003Eb__0(proto.CSPeakTitleInfo x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass226_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		internal void _003CRequestAreaLeaderBoardDesc_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass227_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		internal void _003CRequestAreaLeaderBoardInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass229_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		internal void _003CRequestCSPeakAreaLeaderBoardInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass231_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		internal void _003CRequestReceiveAreaTitle_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass232_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		internal void _003CRequestChooseArea_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass233_0
	{
		public UIModelAreaLeaderBoard _003C_003E4__this;

		public string cmd;

		public int mainType;

		public ulong leaderBoardID;

		public uint notifyPropID;

		internal void _003CRequestAreaLeaderBoard_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_AreaLeaderBoardReady = 1u;

	public const uint PropID_GetAreaLeaderBoardDesc = 2u;

	public const uint PropID_GetAreaInfo = 4u;

	public const uint PropID_ReceiveAreaTitle = 8u;

	public const uint PropID_GetArea = 16u;

	public const uint PropID_GetAreaLeaderBoardInfo = 32u;

	public const uint PropID_GetPeakAreaLeaderBoardInfo = 64u;

	public const uint PropID_GetCSPeakAreaInfo = 128u;

	public const uint PropID_PeakAreaLeaderBoardReady = 256u;

	private uint m_ReadyFlag;

	private uint m_PeakReadyFlag;

	private const uint ALL_STEP_READY = 6u;

	private const uint PEAK_ALL_STEP_READY = 130u;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	private AreaLeaderboardDescRes m_AreaLeaderboardDesc;

	private AreaLeaderboardDescRes m_CSPeakAreaLeaderboardDesc;

	private AreaLeaderboardInfoWithTitle m_AreaLeaderboardInfo;

	private CSPeakAreaLeaderboardInfoWithTitle m_CSPeakAreaLeaderboardInfo;

	private readonly List<LeaderboardAreaListDesc> m_ListLocalPlayerAreaDesc;

	private readonly Dictionary<uint, LeaderboardAreaListDesc> m_DicLocalPlayerAreaDescDelete;

	private AreaLeaderboardSettingDesc m_LocalPlayerSettingDesc;

	private Dictionary<string, Dictionary<uint, AreaLeaderboardDesc>> m_DicRegionToDicAreaLeaderboardDesc;

	private Dictionary<string, Dictionary<uint, AreaLeaderboardDesc>> m_DicRegionToDicCSPeakAreaLeaderboardDesc;

	private readonly Dictionary<ulong, AreaLeaderboardCacheInfo> m_DicLeaderBoardTypeToInfo;

	private readonly Dictionary<ulong, AreaLeaderboardCacheInfo> m_DicCSPeakLeaderBoardTypeToInfo;

	private readonly Dictionary<Vector2Int, RankingPlayerTitleInfo> m_DicIdToRankTitles;

	private readonly Dictionary<Vector2Int, CSPeakPlayerTitleInfo> m_DicIdToCSPeakTitles;

	private readonly List<Vector2Int> m_RankNewTitleIDList;

	private readonly List<Vector2Int> m_CSPeakNewTitleIDList;

	private readonly Dictionary<uint, LeaderboardAreaListDesc> m_DicAreaCountryIDToCountryDesc;

	private readonly Dictionary<uint, List<LeaderboardAreaListDesc>> m_DicAreaCountryIDToProvinceDesc;

	private readonly Dictionary<uint, List<LeaderboardAreaListDesc>> m_DicAreaProvinceIDToCityDesc;

	private readonly BaseLeaderBoardAreaData m_NextAreaData;

	private BaseLeaderBoardAreaData m_CurAreaData;

	private bool m_SetArea;

	private bool m_ChangeAreaAfterSeasonEnd;

	private Dictionary<Vector3, uint> m_DicTitleDataToIconTypeList;

	private List<Vector3> m_ListTitleData;

	private List<Vector3> m_ListCSPeakTitleData;

	private List<Vector3> m_ListCSPeakRegionTitleData;

	private uint m_NextAreaId;

	private long m_ChooseAreaTime;

	private bool m_IsAutoGetCountry;

	private bool m_IsAutoGetProvince;

	private bool m_IsAutoGetCity;

	private bool m_NeedAutoSelect;

	private bool m_NeedAutoSelectPeak;

	private bool m_IsfirstTitleReceive;

	private bool m_IsCSPeakfirstTitleReceive;

	private bool m_IsSeasonFinalTitleReceive;

	private ELeaderboardDeleteAreaType m_AreaDeleteType;

	private bool m_HasRefreshedAreaLeaderBoardInfo;

	private bool m_HasRefreshedCSPeakLeaderBoardInfo;

	private static string COUNTRY_TITLE_REWARDTIME;

	private static string PROVINCE_TITLE_REWARDTIME;

	private static string CITY_TITLE_REWARDTIME;

	private static string PEAK_REGION_TITLE_REWARDTIME;

	private static string PEAK_COUNTRY_TITLE_REWARDTIME;

	private static string PEAK_PROVINCE_TITLE_REWARDTIME;

	private static string PEAK_CITY_TITLE_REWARDTIME;

	public static string PLAYERPREFS_LEADERBOARD1;

	public static string PLAYERPREFS_LEADERBOARD2;

	public static string PLAYERPREFS_LOCATION;

	public static string PLAYERPREFS_TITLE1;

	public static string PLAYERPREFS_TITLE2;

	public static string PLAYERPREFS_TITLE3;

	public bool SetArea
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool ChangeAreaAfterSeasonEnd => false;

	public bool IsSeasonFinalTitleReceive => false;

	private uint ReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	private uint PeakReadyFlag
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public BaseLeaderBoardAreaData CurAreaData => null;

	public BaseLeaderBoardAreaData NextAreaData => null;

	public bool NeedSetLocationByPlayer => false;

	public bool NeedAutoSelect
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool NeedAutoSelectPeak
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsAutoGetCountry => false;

	public bool IsAutoGetProvince => false;

	public bool IsAutoGetCity => false;

	public long ChooseAreaTime => 0L;

	public bool IsfirstTitleReceive => false;

	public bool IsCSPeakfirstTitleReceive => false;

	public bool IsRankingAreaLeaderBoardOpen => false;

	public bool IsPeakAreaLeaderBoardOpen => false;

	public bool IsDeleteAreaTitleUseBeforeArea => false;

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	private void ProcessLocalPlayerDataByRegion(RegionLeaderboardAreaDesc regionAreaDesc)
	{
	}

	private void ProcessNewTitleIDsList(List<RankingPlayerTitleInfo> rankPlayerTitleInfoList)
	{
	}

	private void ProcessNewCSPeakTitleIDsList(CSGetCSPeakLeaderboardInfoRes info)
	{
	}

	private void ProcessNewCSPeakTitleIDsList(List<CSPeakPlayerTitleInfo> titleInfoList)
	{
	}

	private void ProcessLeaderboardDesc(List<RegionAreaLeaderboardDesc> regionDescs)
	{
	}

	private void ProcessCSPeakAreaLeaderboardDesc(List<RegionAreaLeaderboardDesc> regionDescs)
	{
	}

	private void ProcessAreaDic()
	{
	}

	private void ProcessIconTypeToTitleDataDic()
	{
	}

	private void ProcessTitlesDic(List<RankingPlayerTitleInfo> rankPlayerTitleInfoList)
	{
	}

	private void ProcessCSPeakTitlesDic(CSGetCSPeakLeaderboardInfoRes info)
	{
	}

	private void ProcessCSPeakTitlesDic(List<CSPeakPlayerTitleInfo> titleInfoList)
	{
	}

	public ELeaderBoardTitleRegionType GetRegionTypeByTitleCfgId(uint title_cfg_id)
	{
		return ELeaderBoardTitleRegionType.None;
	}

	private void ProcessTitlesRewardList()
	{
	}

	private void ProcessPeakTitlesRewardList()
	{
	}

	private bool IsInRequestCD(ulong leaderBoardID)
	{
		return false;
	}

	private bool IsInCSPeakRequestCD(ulong leaderBoardID)
	{
		return false;
	}

	private void SetAreaLeaderBoardInfoData(ulong leaderBoardID, AccountLeaderboardRes leaderboardRes, int mainType)
	{
	}

	private void SetCSPeakAreaLeaderBoardInfoData(ulong leaderBoardID, AccountLeaderboardRes leaderboardRes, int mainType)
	{
	}

	private bool HasDeleteAreaInLeaderboardInfo(AreaLeaderboardInfoWithTitle areaLeaderboardInfo)
	{
		return false;
	}

	private void SetChooseAreaTimeByArea(CSChooseAccountLeaderboardAreaRes areaInfo)
	{
	}

	public void SetCountryProvinceName()
	{
	}

	private void SetNextAreaData()
	{
	}

	private void SetNextAreaDataByDesc(LeaderboardAreaListDesc areaDesc)
	{
	}

	private void ProcessNextAreaDataByAuto()
	{
	}

	private void ProcessCurAreaDataByInfo()
	{
	}

	private void RefreshTitlesDicByNew(List<RankingPlayerTitleInfo> newTitleList)
	{
	}

	private void RefreshCSPeakTitlesDicByNew(List<CSPeakPlayerTitleInfo> newTitleList)
	{
	}

	public bool IsReady()
	{
		return false;
	}

	public bool IsPeakReady()
	{
		return false;
	}

	public bool IsAreaLeaderBoardDescReady()
	{
		return false;
	}

	public bool IsPeakAreaLeaderBoardDescReady()
	{
		return false;
	}

	public bool IsLeaderBoardInfoGet()
	{
		return false;
	}

	public bool IsPeakAreaLeaderBoardInfoGet()
	{
		return false;
	}

	public bool IsPeakAreaLeaderBoardInfoGetWithoutArea()
	{
		return false;
	}

	public string GetLeaderBoardNameByLeaderBoardID(ulong leaderBoardID, string gameRegion)
	{
		return null;
	}

	public string GetPeakAreaLeaderBoardNameByLeaderBoardID(ulong leaderBoardID, string gameRegion)
	{
		return null;
	}

	public uint GetAreaLeaderBoardStartingScore(ulong subkey)
	{
		return 0u;
	}

	public uint GetCSPeakAreaLeaderBoardStartingScore(ulong subkey)
	{
		return 0u;
	}

	public ulong GetAreaLeaderBoardId(ELeaderboard.LeaderboardMainType leaderBoardType, ELeaderBoardTitleRegionType regionType)
	{
		return 0uL;
	}

	public ulong GetPeakAreaLeaderBoardId(ELeaderboard.LeaderboardMainType leaderBoardType, ELeaderBoardTitleRegionType regionType)
	{
		return 0uL;
	}

	public uint GetAreaLeaderBoardSizeByBoardID(ulong subkey)
	{
		return 0u;
	}

	public uint GetCSPeakAreaLeaderBoardSizeByBoardID(ulong subkey)
	{
		return 0u;
	}

	public ELeaderBoardTitleRegionType GetAreaLeaderBoardRegionTypeByID(ulong id, string region)
	{
		return ELeaderBoardTitleRegionType.None;
	}

	public ELeaderBoardTitleRegionType GetPeakAreaLeaderBoardRegionTypeByID(ulong id, string region)
	{
		return ELeaderBoardTitleRegionType.None;
	}

	public List<LeaderBoardInfo> GetAreaLeaderBoardInfoList(ulong leaderBoardID)
	{
		return null;
	}

	public List<LeaderBoardInfo> GetCSPeakAreaLeaderBoardInfoList(ulong leaderBoardID)
	{
		return null;
	}

	public LeaderBoardInfo GetAreaLeaderBoardSelfInfo(ulong leaderBoardID)
	{
		return null;
	}

	public LeaderBoardInfo GetCSPeakAreaLeaderBoardSelfInfo(ulong leaderBoardID)
	{
		return null;
	}

	public uint GetAreaLeaderBoardSize(ulong leaderBoardID)
	{
		return 0u;
	}

	public uint GetCSPeakAreaLeaderBoardSize(ulong leaderBoardID)
	{
		return 0u;
	}

	public ELeaderboard.LeaderboardMainType GetLeaderboardMainTypeByTitleCfgID(uint titleCfgID)
	{
		return ELeaderboard.LeaderboardMainType.Leaderboard_REGULAR;
	}

	public bool GetIsBrByTitleCfgID(uint titleCfgID)
	{
		return false;
	}

	private bool GetIsBrByTitleIDInConfig(uint titleCfgId)
	{
		return false;
	}

	public bool CheckCanRefreshLeaderBoard()
	{
		return false;
	}

	public bool CheckCanRefreshCSPeakLeaderBoard()
	{
		return false;
	}

	public LeaderboardAreaListDesc GetDeleteLeaderboardAreaListDesc(uint areaID)
	{
		return null;
	}

	public string GetRealTitleRegionName(uint areaID, string areaName)
	{
		return null;
	}

	public void ResetALLLeaderBoardRequestCD()
	{
	}

	public void ResetCSPeakLeaderBoardRequestCD()
	{
	}

	public void ResetLeaderBoardRequestCD(bool isBR)
	{
	}

	public void SetDeleteAreaType(CSGetAreaLeaderboardInfoRes infos)
	{
	}

	public bool IsCurAreaDelete()
	{
		return false;
	}

	private void SetLeaderBoarListByArea(CSChooseAccountLeaderboardAreaRes info)
	{
	}

	public bool IsAutoLocateOpen()
	{
		return false;
	}

	public void GetAutoLocationInfo(string city, string subdivision)
	{
	}

	public bool SetCurAreaDataByLeaderBoardAreaId(ulong subkey, BaseLeaderBoardAreaData areaData)
	{
		return false;
	}

	public void SetChooseAreaInfo(CSGetAreaLeaderboardInfoRes info)
	{
	}

	public void ResetSetChooseAreaInfo()
	{
	}

	public AreaLeaderboardDesc GetAreaLeaderboardDesc(ulong subkey)
	{
		return null;
	}

	public bool IsCurRegionTypeHide(ELeaderBoardTitleRegionType regionType)
	{
		return false;
	}

	public List<LeaderboardAreaListDesc> GetCountryAreaDescList()
	{
		return null;
	}

	public List<LeaderboardAreaListDesc> GetProvinceAreaDescListByCountryID(uint countryID)
	{
		return null;
	}

	public List<LeaderboardAreaListDesc> GetCityAreaListByProvinceID(uint provinceID)
	{
		return null;
	}

	public bool HasProvinceAreaDescByCountryID(uint countryID)
	{
		return false;
	}

	public bool HasCityAreaDescByProvinceID(uint provinceID)
	{
		return false;
	}

	public RankingPlayerTitleInfo GetTopNewBRTitle()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetSelectedTopBRTitle()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetTopNewCSTitle()
	{
		return null;
	}

	public CSPeakPlayerTitleInfo GetTopNewCSPeakTitle()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetSelectedTopCSTitle()
	{
		return null;
	}

	public CSPeakPlayerTitleInfo GetSelectedTopCSPeakTitle()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetBRSelectedRankTitleInfo()
	{
		return null;
	}

	public RankingPlayerTitleInfo GetCSSelectedRankTitleInfo()
	{
		return null;
	}

	public int SortRankPlayerTitleList(RankingPlayerTitleInfo x, RankingPlayerTitleInfo y)
	{
		return 0;
	}

	public int SortCSPeakPlayerTitleList(CSPeakPlayerTitleInfo x, CSPeakPlayerTitleInfo y)
	{
		return 0;
	}

	public CSPeakPlayerTitleInfo GetCSSelectedPeakTitleInfo()
	{
		return null;
	}

	public void SetRedDotInProfile()
	{
	}

	public void SetPeakRedDotInProfile()
	{
	}

	public List<tcp.RankingTitleInfo> GetTcpSelectedRankTitleinfoList()
	{
		return null;
	}

	public List<tcp.CSPeakTitleInfo> GetTcpSelectedCSPeakTitleInfoList()
	{
		return null;
	}

	public List<proto.RankingTitleInfo> GetSelectedRankTitleInfoList()
	{
		return null;
	}

	public List<proto.CSPeakTitleInfo> GetSelectedCSPeakTitleInfoList()
	{
		return null;
	}

	public List<RankingPlayerTitleInfo> GetSelectedRankPlayerTitleInfoList()
	{
		return null;
	}

	public List<CSPeakPlayerTitleInfo> GetSelectedCSPeakPlayerTitleInfoList()
	{
		return null;
	}

	public List<RankingPlayerTitleInfo> GetBRSortedRankingTitleInfoList()
	{
		return null;
	}

	public List<RankingPlayerTitleInfo> GetCSSortedRankingTitleInfoList()
	{
		return null;
	}

	public List<CSPeakPlayerTitleInfo> GetCSSortedPeakRankingTitleInfoList()
	{
		return null;
	}

	public int SortRankingPlayerTitleList(RankingPlayerTitleInfo x, RankingPlayerTitleInfo y)
	{
		return 0;
	}

	public int SortPeakPlayerTitleList(CSPeakPlayerTitleInfo x, CSPeakPlayerTitleInfo y)
	{
		return 0;
	}

	public List<RankingPlayerTitleInfo> GetNewTitlesInfoList()
	{
		return null;
	}

	public List<CSPeakPlayerTitleInfo> GetCSPeakNewTitlesInfoList()
	{
		return null;
	}

	public ELeaderBoardTitleIconType GetTitleIconType(int isBR, int areaType, uint rank)
	{
		return ELeaderBoardTitleIconType.NONE;
	}

	public bool CheckHasNewTitles()
	{
		return false;
	}

	public bool CheckHasNewPeakTitles()
	{
		return false;
	}

	public List<CSReceiveLeaderboardTitleReq.ReceiveLeaderboardTypeTitle> GetRankingNewTitleList()
	{
		return null;
	}

	public List<CSReceiveLeaderboardTitleReq.ReceiveLeaderboardTypeTitle> GetCSPeakNewTitleList()
	{
		return null;
	}

	public List<RankingPlayerTitleInfo> GetRankingNewTitleShowList()
	{
		return null;
	}

	public List<CSPeakPlayerTitleInfo> GetCSPeakNewTitleShowList()
	{
		return null;
	}

	public bool TryRefreshTitleSelectedState()
	{
		return false;
	}

	public bool TryRefreshPeakTitleSelectedState()
	{
		return false;
	}

	public void SetAutoSelectTitle(bool isAlone)
	{
	}

	public void SetAutoSelectPeakTitle(bool isAlone)
	{
	}

	public bool CheckCanShowTitleCtrl(uint iconType, ulong expireTime)
	{
		return false;
	}

	public void RequestAreaAllMesage(bool requestDesc = true, bool requestInfo = true, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool requestCSPeakInfo = true)
	{
	}

	public void RequestAreaLeaderBoardDesc(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestAreaLeaderBoardInfo(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void OnRespondAreaLeaderBoardInfo(AreaLeaderboardInfoWithTitle info, bool isAlone = true)
	{
	}

	public void RequestCSPeakAreaLeaderBoardInfo(bool force = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool sendImmediately = false)
	{
	}

	public void OnRespondCSPeakLeaderBoardInfo(CSGetCSPeakLeaderboardInfoRes info, bool isAlone = true)
	{
	}

	public void RequestReceiveAreaTitle(List<CSReceiveLeaderboardTitleReq.ReceiveLeaderboardTypeTitle> receiveTitles)
	{
	}

	public void RequestChooseArea(uint areaID)
	{
	}

	public void RequestAreaLeaderBoard(int mainType = 0, ulong mainKey = 0uL, ulong leaderBoardID = 0uL, string region = "", bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true, LoadingType loadingType = LoadingType.CircleLoading, uint notifyPropID = 32u)
	{
	}

	private bool _003CSetNextAreaData_003Eb__131_0(LeaderboardAreaListDesc x)
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
