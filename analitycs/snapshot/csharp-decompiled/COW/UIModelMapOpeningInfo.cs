using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using message;
using proto;

namespace COW;

public class UIModelMapOpeningInfo : UIBaseModel, IUIModelDataChangeObserver
{
	public class GameModeSortData
	{
		public uint sort_id;

		public List<MapModeData> mapmode_list;
	}

	public class ModesPickMoreMaps
	{
		public uint GameMode;

		public uint MatchMode;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}
	}

	public enum EPGCMapInfoState
	{
		NotReady,
		Ready,
		Updating
	}

	public class PGCMapInfos
	{
		public MapModeData MapMode;

		public EPGCMapInfoState State;

		public List<PGCMapInfo> MapInfos;

		public void ClearMapInfos()
		{
		}

		public bool IsReady()
		{
			return false;
		}
	}

	public class PGCMapInfo
	{
		public SceneEditSlotInfo SlotInfo;

		public string LastUrl;

		public EPGCMapInfoState State;

		public UGCResInfo ResInfo;

		public UGCSimpleDownloadTask DownloadTask;

		public void ClearResInfo()
		{
		}

		public void ReloadResInfo()
		{
		}
	}

	public class UIUGCMapItemData
	{
		public WorkshopCraftlandRecommendationInfo mapItemData;

		public int panelDepth;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MapOpeningInfo> _003C_003E9__168_0;

		public static Comparison<GameModeSortData> _003C_003E9__168_1;

		public static Func<uint, string> _003C_003E9__309_0;

		public static Func<string, string, string> _003C_003E9__309_1;

		public static Func<uint, string> _003C_003E9__311_0;

		public static Func<string, string, string> _003C_003E9__311_1;

		public static Predicate<WorkshopTagMatchDesc> _003C_003E9__321_0;

		public static Predicate<WorkshopTagMatchDesc> _003C_003E9__363_0;

		internal int _003CUpdateMapOpeningInfo_003Eb__168_0(MapOpeningInfo a, MapOpeningInfo b)
		{
			return 0;
		}

		internal int _003CUpdateMapOpeningInfo_003Eb__168_1(GameModeSortData a, GameModeSortData b)
		{
			return 0;
		}

		internal string _003CRefreshAvailableMapIdArray_003Eb__309_0(uint i)
		{
			return null;
		}

		internal string _003CRefreshAvailableMapIdArray_003Eb__309_1(string s1, string s2)
		{
			return null;
		}

		internal string _003CRefreshUnAvailableMode_003Eb__311_0(uint i)
		{
			return null;
		}

		internal string _003CRefreshUnAvailableMode_003Eb__311_1(string s1, string s2)
		{
			return null;
		}

		internal bool _003CIsUGCMapAvailable_003Eb__321_0(WorkshopTagMatchDesc e)
		{
			return false;
		}

		internal bool _003CNeedDownloadUGCMapRes_003Eb__363_0(WorkshopTagMatchDesc e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass169_0
	{
		public uint gameMode;

		public uint matchMode;

		internal bool _003CCheckGameModeAndMatchModeCanShowVisitor_003Eb__0(SpectateModeDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass234_0
	{
		public UIModelMapOpeningInfo _003C_003E4__this;

		public uint curGroupModePlayerLimit;

		internal bool _003CGetBrDefaultMapWithGroup_003Eb__0(MapOpeningInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass239_0
	{
		public UIModelMapOpeningInfo _003C_003E4__this;

		public uint curGroupPlayerMaxLimit;

		internal bool _003CGetCsDefaultMapWithGroup_003Eb__0(MapOpeningInfo info)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass243_0
	{
		public uint matchMode;

		public uint gameMode;

		public uint mapMode;

		public uint difficty;

		internal bool _003CUpdateSelectedMapData_003Eb__0(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__1(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__2(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__3(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__4(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__5(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__6(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__7(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateSelectedMapData_003Eb__8(MapModeData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass245_0
	{
		public uint matchMode;

		public uint gameMode;

		public uint mapMode;

		public uint difficulty;

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__0(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__1(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__2(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__3(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__4(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__5(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__6(MapModeData a)
		{
			return false;
		}

		internal bool _003CUpdateInGameLevelVisualStyle_003Eb__7(MapModeData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass246_0
	{
		public MapModeData data;

		internal bool _003CIsMapLimitedOpen_003Eb__0(MapOpeningInfo a)
		{
			return false;
		}

		internal bool _003CIsMapLimitedOpen_003Eb__1(MapOpeningInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass247_0
	{
		public MapModeData data;

		public UIModelMapOpeningInfo _003C_003E4__this;

		internal bool _003CGetOpeningInfo_003Eb__0(MapOpeningInfo a)
		{
			return false;
		}

		internal bool _003CGetOpeningInfo_003Eb__1(MapOpeningInfo a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass315_0
	{
		public List<int> difficultys;

		internal bool _003CGetWorkshopUGCOpeningInfoDesc_003Eb__0(WorkshopUGCOpeningInfoDesc desc)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass326_0
	{
		public List<PGCMapInfos> mapInfosList;

		public bool requestSlotInfo;

		public UIModelMapOpeningInfo _003C_003E4__this;

		internal void _003CRequestPGCMapInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass327_0
	{
		public HashSet<string> urls;

		public PGCMapInfos pgcMapInfos;

		public UIModelMapOpeningInfo _003C_003E4__this;

		internal void _003CRequestPGCGameData_003Eb__0(Dictionary<string, byte[]> gameDataDict)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass356_0
	{
		public uint gameMode;

		public uint matchMode;

		internal bool _003CCheckIsLimitByCertainMapData_003Eb__0(MMCertainMapDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass357_0
	{
		public uint gameMode;

		public uint matchMode;

		internal bool _003CGetMapUnlimitRank_003Eb__0(MMCertainMapDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass379_0
	{
		public UIModelMapOpeningInfo _003C_003E4__this;

		public UGCSimpleDownloadTask resDownloadTask;

		internal void _003CDownloadMapModeIfNeed_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass379_1
	{
		public uint mainTagID;

		internal void _003CDownloadMapModeIfNeed_003Eb__1()
		{
		}
	}

	private long RegionServerTimeOffset;

	public const string RANK_GUIDE_KEY = "rank_guide";

	public const string MEET_RANK_LIMIT_KEY = "rank_limit";

	public const string LASTPLAY_RANKINGMODE = "player_last_play_rankingmode";

	public const string LASTPLAY_CSPEAK_SEASON = "player_last_play_cspeak_season";

	private bool m_HasCheckRandomUGCMap;

	private RankingLevelLimitDescList m_MatchLevelLimitDescList;

	private ModeLevelLimitDescList m_mode_level_limit_list;

	private Dictionary<ulong, uint> m_PreCloseTimeDict;

	private bool _003CNeedCheckUGCResDownloadOptionalPop_003Ek__BackingField;

	private List<MapOpeningInfo> m_TotalOpeningInfoList;

	private float _003CMapRP_003Ek__BackingField;

	private List<MapModeData> m_MapModeList;

	private SortedDictionary<uint, List<MapModeData>> m_SortedMapModeDict;

	private List<MapOpeningInfo> m_NewOpeningInfoList;

	private Dictionary<int, UGCSimpleDownloadTask> m_UGCResourceDownloadTaskDict;

	private bool m_IsUGCNecessaryResourceDownloaded;

	private string m_LastReportedUGCSocialUrl;

	private Dictionary<uint, List<MapModeData>> m_ModeDictOfRandomMap;

	private Dictionary<ModesPickMoreMaps, List<MapModeData>> m_DictModesPickMoreMaps;

	private Dictionary<uint, SpecialModeOpeningInfoDesc> m_CSRankSpecialMatchOpeningDic;

	private Dictionary<uint, uint> m_CSSpecialMatchProtectCostTimesDic;

	private Dictionary<uint, bool> m_CSSpecialMatchCurrentSelectDic;

	public Dictionary<uint, uint> UGCGameModePickWndHotTagInfo;

	private Dictionary<int, MapModeData> m_AllDifficultyHippoCrisisMapDataDict;

	public List<MapModeData> HippoCrisisMapDataList;

	private List<GameModeSortData> m_SortedGameModeData;

	private uint m_CurrentPeriodicMapSelectConfigID;

	private bool m_NeedRefreshGameOpeningInfo;

	private List<MMCertainMapDesc> m_RankLimitMapDataList;

	private List<MapOpeningInfo> m_PermanentMapInfoList;

	private List<MapOpeningInfo> m_HintMapInfoList;

	private List<MapOpeningInfo> m_ChampionshipMapList;

	private List<MapOpeningInfo> m_CupMatchMapList;

	private List<MapModeData> m_TrainingMapList;

	private List<MapModeData> m_SocialMapList;

	private List<MapModeData> m_LobbySocialAreaMapList;

	private List<MapOpeningInfo> m_NewModeBubbleMapInfoMapList;

	private List<MapOpeningInfo> m_PeriodicRankMapOpeningInfoMapList;

	private List<SpectateModeDesc> m_FriendSpectateModeList;

	public List<MapModeData> PeriodicRankMapList;

	private MapOpeningInfo _003CShangrila_003Ek__BackingField;

	public const uint PropID_OpeningInfoListUpdate = 2u;

	public const uint PropID_WinnerTakeAllInfoUpdate = 4u;

	public const uint PropID_UGCMapChanged = 8u;

	public const uint PropID_MapPickedMoreChanged = 16u;

	public const uint PropID_UGCHotTagInfoUpdate = 32u;

	public const uint PropID_MapModeChange = 64u;

	public const uint PropID_UGCOpeningUpdate = 128u;

	public const uint PropID_SpecialMatchInfoReady = 256u;

	public const uint PropID_CSSpecialMatchSelectedChange = 512u;

	public const uint PropID_MapGameModeChange = 1024u;

	public const uint PropID_GameModeStatsConfigUpdate = 2048u;

	public const uint PropID_UGCAlgorithmUpdate = 4096u;

	public const uint PropID_PGCMapUpdated = 8192u;

	public const uint PropID_AvailableMapChange = 16384u;

	public const uint PropID_AvailableModeChange = 32768u;

	public const uint PropID_RefreshWorkshopSelectionPageInfo = 65536u;

	private MapModeData m_SelectedMapData;

	private MapModeData _003CSelectToDownloadMapMode_003Ek__BackingField;

	public SceneEditSlotInfo UGCCertainRoomMapInfo;

	private SceneEditSlotInfo UGCCertainSocialAreaMapInfo;

	public bool IsSocialAreaWithUGCMapResEnabled;

	public EUGCScene RoomMatchMakingScene;

	private bool m_HasSetBrDefaultGroupMode;

	private UGCMatchMakingInfo m_UGCMatchMakingInfo;

	private int newTagId;

	private long newTagTime;

	public bool ShowSelectAllTips;

	private uint m_PendingPGCMapMatchMakingInfoGameMode;

	public int DefaultPermanentMapIndex;

	public bool m_HasAvailableMapsInited;

	public bool m_HasNotAvailableModeInited;

	public bool LoginRequestedMapOpeningInfo;

	private const string MAP_HINT_KEY = "map_hint";

	private const string MAP_PVE_KEY = "pve_map_id";

	private const string CSSpecialMatchIsSelectPrefix = "CSSpecial";

	public bool InitDefaultMap;

	public bool PlayingBrRankGuide;

	private bool _003CNeedRefreshSelectMapData_003Ek__BackingField;

	private bool _003CIsRequestPending_003Ek__BackingField;

	private Dictionary<uint, string> m_GameModeNameDict;

	public List<ModesPickMoreMaps> ModesPickMoreList;

	private bool m_HasInitUGCOpeningDescs;

	private List<WorkshopUGCOpeningInfoDesc> m_WorkshopUGCOpeningInfoDesc;

	private bool m_HasInitWorkshopSelectionPageInfo;

	private List<WorkshopCraftlandRecommendationInfo> m_WorkshopSelectionPageInfo;

	private bool m_HasInitUGCAlgorithmDesc;

	private Dictionary<string, WorkshopBasicInfoWithExtra> m_UGCAlgorithmDict;

	public Dictionary<string, SceneEditSlotInfo> WorkshopUGCOpeningInfos;

	public Dictionary<string, SceneEditSlotInfo> WorkshopUGCOpeningBasicInfos;

	private List<uint> m_AvailableMapIdList;

	private List<uint> m_PreAvailableMapIdList;

	private List<uint> m_PreNotAvailableModeIdList;

	private List<uint> m_NotAvailableModeIdList;

	private List<uint> m_SkipOptionalMapConfigIdList;

	private List<uint> m_SkipOptionalMapIdList;

	private Dictionary<uint, PGCMapInfos> m_PGCMapInfos;

	private bool m_PGCMapInfosInited;

	private uint m_PGCModeNeedsToUpdate;

	private List<QuitControlDesc> m_quitControlDescList;

	public DateTime RegionServerTime => default(DateTime);

	public bool NeedCheckUGCResDownloadOptionalPop
	{
		get
		{
			return _003CNeedCheckUGCResDownloadOptionalPop_003Ek__BackingField;
		}
		set
		{
			_003CNeedCheckUGCResDownloadOptionalPop_003Ek__BackingField = value;
		}
	}

	public List<MapOpeningInfo> TotalOpeningInfoList => null;

	public float MapRP
	{
		get
		{
			return _003CMapRP_003Ek__BackingField;
		}
		private set
		{
			_003CMapRP_003Ek__BackingField = value;
		}
	}

	public List<MapModeData> MapModeList => null;

	public List<MapOpeningInfo> NewOpeningInfoList => null;

	public Dictionary<uint, SpecialModeOpeningInfoDesc> CSRankSpecialMatchOpeningDic => null;

	public Dictionary<int, MapModeData> AllDifficultyHippoCrisisMapDataDict => null;

	public uint CurrentPeriodicMapSelectConfigID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool NeedRefreshGameOpeningInfo
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public List<MapOpeningInfo> PermanentMapInfoList => null;

	public List<MapOpeningInfo> HintMapInfoList => null;

	public List<MapModeData> TrainingMapInfoList => null;

	public List<MapModeData> SocialMapInfoList => null;

	public List<MapModeData> LobbySocialAreaMapInfoList => null;

	public List<MapOpeningInfo> newModeBubbleMapInfoMapList => null;

	public MapOpeningInfo Shangrila
	{
		get
		{
			return _003CShangrila_003Ek__BackingField;
		}
		private set
		{
			_003CShangrila_003Ek__BackingField = value;
		}
	}

	public MapModeData SelectedMapData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public MapModeData SelectToDownloadMapMode
	{
		get
		{
			return _003CSelectToDownloadMapMode_003Ek__BackingField;
		}
		set
		{
			_003CSelectToDownloadMapMode_003Ek__BackingField = value;
		}
	}

	public MapModeData CachedUISelectedMapData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool UGCMapSelected => false;

	public UGCMatchMakingInfo UGCMatchMakingInfo => null;

	public int NewTagId => 0;

	public long NewTagTime => 0L;

	public bool NeedRefreshSelectMapData
	{
		get
		{
			return _003CNeedRefreshSelectMapData_003Ek__BackingField;
		}
		set
		{
			_003CNeedRefreshSelectMapData_003Ek__BackingField = value;
		}
	}

	public bool IsRequestPending
	{
		get
		{
			return _003CIsRequestPending_003Ek__BackingField;
		}
		set
		{
			_003CIsRequestPending_003Ek__BackingField = value;
		}
	}

	public List<WorkshopUGCOpeningInfoDesc> WorkshopUGCOpeningInfoDesc => null;

	public List<WorkshopCraftlandRecommendationInfo> WorkshopSelectionPageInfo => null;

	public Dictionary<string, WorkshopBasicInfoWithExtra> UGCAlgorithmDict => null;

	public List<QuitControlDesc> QuitControlDescList
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<uint> GetNewbieTopModes()
	{
		return null;
	}

	public static uint MakeOpeningInfoID(uint matchMode, uint mapID, uint gameMode)
	{
		return 0u;
	}

	public SortedDictionary<uint, List<MapModeData>> SortedMapModeDict()
	{
		return null;
	}

	public UGCSimpleDownloadTask GetUGCResourceDownloadTask(EUGCMatchMode matchMode, MapModeData mapModeData = null)
	{
		return null;
	}

	public void DeleteUGCResourceDownloadTask(EUGCMatchMode matchMode)
	{
	}

	private UGCSimpleDownloadTask AddUGCResourceDownloadTask(EUGCMatchMode matchMode, MapModeData mapModeData = null)
	{
		return null;
	}

	public List<GameModeSortData> SortedGameModeDataList()
	{
		return null;
	}

	public void InitUGCCertainSocialAreaMapInfo()
	{
	}

	public void RequestUGCSocialAreaMapInfo(string workshopCode)
	{
	}

	private void CreateUGCSocialAreaSlotInfo(string workshopCode, string exportDataUrl)
	{
	}

	public string GetUGCSocialAreaExportDataUrlIfReady()
	{
		return null;
	}

	public void UpdateUGCRandomMatchMakingInfo(List<string> CodePool, uint GroupMode, bool isTeamContest, uint[] teamCounts)
	{
	}

	public void UpdateUGCCertainMapMatchMakingInfo(SceneEditSlotInfo slotInfo, bool force = false, bool showTips = true)
	{
	}

	public void SetPendingPGCMapMatchMakingInfo(uint gameMode)
	{
	}

	public void UpdatePendingPGCMapMatchMakingInfo(PGCMapInfo pgcMapInfo)
	{
	}

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

	private void ClearInvaildPlayerPrefersKey()
	{
	}

	public override void Login(object[] data)
	{
	}

	protected override void OnCleanup()
	{
	}

	public List<MapOpeningInfo> GetPeriodicRankMapAvailableMapList()
	{
		return null;
	}

	public void RequestMapOpeningInfo()
	{
	}

	public void UpdateMapOpeningInfo(GameOpeningInfoRes data)
	{
	}

	public bool CheckGameModeAndMatchModeCanShowVisitor(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool CheckGameModeAndMatchModeCanReward(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool CheckGameModeAndMatchModeCanBeSpectate(uint gameMode, uint matchMode)
	{
		return false;
	}

	public bool IsNewModeBubbleMap(MapOpeningInfo info)
	{
		return false;
	}

	public int SortPerioidicMap(MapOpeningInfo a, MapOpeningInfo b)
	{
		return 0;
	}

	public int SortPerioidicMap(MapModeData a, MapModeData b)
	{
		return 0;
	}

	private RankingLevelLimitDesc GetLevelLimitDesc(NIKKALKPIBO tarGameMode, DLBMPCCFKKM tarMatchMode)
	{
		return null;
	}

	public GameModeSortData GetCurNewModeSortDataBySortId(uint sortId)
	{
		return null;
	}

	public uint GetCurNewModeBubbleId(ref uint curNewModeSortId)
	{
		return 0u;
	}

	public uint GetModeLimitLevel(NIKKALKPIBO tarGameMode, uint mapId)
	{
		return 0u;
	}

	private bool IsIgnoreUID(MapOpeningInfo openInfo)
	{
		return false;
	}

	private void ResetLevelEntranceUnlockData()
	{
	}

	public int GetMatchGuestUnlockLevel(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return 0;
	}

	public int GetMatchNormalUnlockLevel(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return 0;
	}

	public bool IsGuest()
	{
		return false;
	}

	public bool CheckLevelSatisfy(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode, bool showTips = false, bool rankingModeCheckLevel = false)
	{
		return false;
	}

	public bool CheckCurGroupModePlayerLimits()
	{
		return false;
	}

	public bool CheckMapModes(List<MapModeData> maps, bool showTips = true, bool showExtraTips = true)
	{
		return false;
	}

	public bool CheckMapMode(MapModeData mapData, bool showTips = true, bool showExtraTips = true)
	{
		return false;
	}

	public int GetGuestRegisterNeedTime(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return 0;
	}

	public int GetNormalRegisterNeedTime(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode)
	{
		return 0;
	}

	public bool CheckRegisterTimeSatisfy(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode, bool showTips)
	{
		return false;
	}

	private void SaveModeOfRandomMap(MapOpeningInfo mapOpening)
	{
	}

	public bool NeedPickMoreMaps(uint gameMode, uint matchMode)
	{
		return false;
	}

	public void SetMapsPickedMore(uint gameMode, uint matchMode, List<MapModeData> modes, bool notify = true, bool needUpdateRankLimitMapData = true)
	{
	}

	public List<MapModeData> GetMapsPickedMore(uint gameMode, uint matchMode)
	{
		return null;
	}

	public List<MapModeData> GetDefaultMapsPickedMore(uint gameMode, uint matchMode)
	{
		return null;
	}

	private bool IsPresetRoomMode(MapModeData map)
	{
		return false;
	}

	public void RefreshDownloadMapsPickedMore(uint gameMode, uint matchMode, bool notify = false)
	{
	}

	public uint[] GetRandomMapIds(uint gameMode, uint matchMode, bool ingoreNotInOpenTimeMap = false)
	{
		return null;
	}

	public bool IsInMapOpeingPeriod(MapOpeningInfo mapInfo)
	{
		return false;
	}

	public bool IsModeOpening(uint sortId)
	{
		return false;
	}

	public bool IsDescOpening(uint game_mode, uint match_mode)
	{
		return false;
	}

	public bool IsMapOpening(uint map_id, uint game_mode, uint match_mode, List<int> diff = null)
	{
		return false;
	}

	public bool IsMapOpening(uint map_id, uint game_mode, uint match_mode, out bool isPreClose)
	{
		isPreClose = default(bool);
		return false;
	}

	public bool IsMapOpening(uint map_id, uint game_mode, uint match_mode, out bool isPreClose, int difficulty)
	{
		isPreClose = default(bool);
		return false;
	}

	public bool IsGameModeOpening(uint game_mode)
	{
		return false;
	}

	public MapOpeningInfo GetOpeningMapByGameMode(uint gameMode)
	{
		return null;
	}

	public List<MapModeData> GetMapModeListByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public List<MapModeData> GetOpenMapModeListByGameModeAndMatchMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	public List<MapModeData> GetMapModeListByMatchMode(uint matchMode)
	{
		return null;
	}

	public List<MapModeData> GetPveMapModeList()
	{
		return null;
	}

	public bool CheckIntraTeamDuel(uint map_id, uint game_mode, uint match_mode)
	{
		return false;
	}

	public uint[] GetPlayersLimits(uint map_id, uint game_mode, uint match_mode, int difficulty = -1)
	{
		return null;
	}

	public bool MapCanSolo(MapModeData map)
	{
		return false;
	}

	public uint GetMaxPlayerLimit(uint game_mode, uint match_mode)
	{
		return 0u;
	}

	public uint GetMaxPlayerLimit(uint map_id, uint game_mode, uint match_mode)
	{
		return 0u;
	}

	public CMDBIPLGLGA GetSelectedGameModeMaxGroupMode()
	{
		return CMDBIPLGLGA.EGROUPMODE_SOLO;
	}

	public bool CheckMapIsOpening(MapOpeningInfo info)
	{
		return false;
	}

	public bool CheckMapIsOpeningInToday(MapOpeningInfo info)
	{
		return false;
	}

	public int GetMapOpeningLeftTime(MapOpeningInfo info)
	{
		return 0;
	}

	public int GetNextMapOpenTime(MapOpeningInfo info)
	{
		return 0;
	}

	public string GetMatchModeString(uint matchMode)
	{
		return null;
	}

	public string GetGameModeString(uint gMode)
	{
		return null;
	}

	public string GetGameModeStringLobbyOnly(uint gMode)
	{
		return null;
	}

	public string GetMapModeString(uint mapMode, uint matchMode = 0u)
	{
		return null;
	}

	public string GetMapBgSpriteName(MapModeData data)
	{
		return null;
	}

	public void SetDefaultMap()
	{
	}

	public void SetDefaultMapWithPlayLastPlay()
	{
	}

	private MapModeData GetDefaultMapFilterBySwitchContent(SwitchDesc desc, uint num, uint matchmode)
	{
		return null;
	}

	public void UpdateMapAfterGameopenInfoUpdate()
	{
	}

	private MapModeData GetDefaultMapFilterByMatchMode(uint matchmode)
	{
		return null;
	}

	public MapModeData GetBrDefaultMap()
	{
		return null;
	}

	public MapModeData GetBrDefaultMapWithGroup(ref bool needChangeGroupMode)
	{
		return null;
	}

	public MapModeData GetCsPeakDefaultMap()
	{
		return null;
	}

	public bool IsCoveredRankGuideAvailable()
	{
		return false;
	}

	public MapModeData GetCsDefaultMap()
	{
		return null;
	}

	public MapModeData GetCsCasualDefaultMap()
	{
		return null;
	}

	public MapModeData GetCsDefaultMapWithGroup(ref bool needChangeGroupMode)
	{
		return null;
	}

	public MapModeData GetOtherDefaultMap()
	{
		return null;
	}

	public MapModeData GetOtherDefaultMapWithGroup(ref bool needChangeGroupMode)
	{
		return null;
	}

	public MapModeData GetDefaultMap()
	{
		return null;
	}

	public void UpdateSelectedMapData(uint matchMode, uint gameMode, uint mapMode, uint difficty, List<uint> mapids, bool changeMapForRankLimit = true)
	{
	}

	private void UpdateLevelVisualStyle()
	{
	}

	public void UpdateInGameLevelVisualStyle()
	{
	}

	public bool IsMapLimitedOpen(MapModeData data)
	{
		return false;
	}

	public MapOpeningInfo GetOpeningInfo(MapModeData data)
	{
		return null;
	}

	public MapOpeningInfo GetChampionshipMapByType(uint championshipType)
	{
		return null;
	}

	public MapOpeningInfo GetCupMatchMapByType(int key)
	{
		return null;
	}

	public bool IsClanWarMode(uint match_mode, uint game_mode)
	{
		return false;
	}

	public bool IsClanWarOrTournament(uint match_mode, uint game_mode)
	{
		return false;
	}

	public bool IsClanWarChampionshipMode(uint matchMode)
	{
		return false;
	}

	public bool IsChampionshipMode(uint match_mode)
	{
		return false;
	}

	public bool IsPeriodicMode(uint match_mode)
	{
		return false;
	}

	public bool IsCupMatchMode(uint match_mode)
	{
		return false;
	}

	public bool IsTrainingMode(MapOpeningInfo map_info)
	{
		return false;
	}

	public bool IsSocialMode(MapOpeningInfo map_info)
	{
		return false;
	}

	public bool IsLobbySocialAreaMode(MapOpeningInfo map_info)
	{
		return false;
	}

	public bool IsHippoCrisisMode(uint matchMode, uint gameMode)
	{
		return false;
	}

	public bool IsUGCRoomMatchMode(uint match_mode)
	{
		return false;
	}

	public static bool IsRankingMatchMode(uint match_mode)
	{
		return false;
	}

	public static int MapComparison(MapModeData a, MapModeData b)
	{
		return 0;
	}

	public MapModeData GetMapModeData(uint matchMode, uint gameMode, uint mapMode)
	{
		return null;
	}

	public MapModeData GetMapModeData(uint matchMode, uint gameMode, uint mapMode, int difficulty)
	{
		return null;
	}

	public WorkshopUGCOpeningInfoDesc GetWorkshopUGCOpeningInfoDesc(MapModeData data = null)
	{
		return null;
	}

	public void RequestUGCMapOpeningInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestWorkshopSelectionPageInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestUGCAlgorithmInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public bool IsMapDataAvailable()
	{
		return false;
	}

	public string GetGameModeName(MapModeData data, bool inGameModeMain = false)
	{
		return null;
	}

	public bool IsUGCOptionalMapConfigId(uint configId)
	{
		return false;
	}

	public bool IsSocialAreaMapConfigId(uint configId)
	{
		return false;
	}

	public bool IsUGCEnabled(uint mapId, uint gameMode)
	{
		return false;
	}

	public string GetUGCShareCode(uint gameMode)
	{
		return null;
	}

	public string GetUGCMapUrl(uint gameMode)
	{
		return null;
	}

	public void SetUGCMapUrl(uint gameMode, string newUrl)
	{
	}

	public void TryReportUGCSocialUrlToBackendWhenInTeam()
	{
	}

	public void ClearLastReportedUGCSocialUrl()
	{
	}

	public bool CheckAndRequestDownloadMapRes(uint configId)
	{
		return false;
	}

	public bool CheckAndRequestDownloadMapRes(uint map, uint mode, string message = "")
	{
		return false;
	}

	public List<ResourceID> NeedDownloadMapRes(uint mapConfigID, bool includeMode = false, bool includeModeRes = true)
	{
		return null;
	}

	public bool CheckMapNeedDownloadFinished(uint map_mode, uint game_mode)
	{
		return false;
	}

	public bool CheckMapNeedDownloadFinished(uint mapConfigID)
	{
		return false;
	}

	public bool CheckModeIsEqualSubGoPos(string subGopos)
	{
		return false;
	}

	public bool MapIsForceMatch(MapModeData data)
	{
		return false;
	}

	public List<ResourceID> NeedDownloadMapRes(uint map_mode, uint game_mode, bool includeMode = false, bool includeModeRes = true)
	{
		return null;
	}

	public List<ResourceID> MapModeTotalInAbPackRes(uint map_mode, uint game_mode, bool includeMode = false, bool includeModeRes = true)
	{
		return null;
	}

	public uint[] GetAvailableMapIdArray()
	{
		return null;
	}

	public void RefreshAvailableMapIdArray()
	{
	}

	private void RefreshUnAvailableModeIds(uint modelId, bool add)
	{
	}

	public void RefreshUnAvailableMode()
	{
	}

	public uint[] GetUnAvailableModeIDArray()
	{
		return null;
	}

	public bool IsMapAvailable(uint mapID)
	{
		return false;
	}

	public bool IsModeAvailable(uint modeID)
	{
		return false;
	}

	public WorkshopUGCOpeningInfoDesc GetWorkshopUGCOpeningInfoDesc(List<int> difficultys)
	{
		return null;
	}

	public List<string> GetMultiMapsWorkshopCodes(WorkshopUGCOpeningInfoDesc infoDesc = null)
	{
		return null;
	}

	public void SetMultipleMapCodes(WorkshopUGCOpeningInfoDesc desc, List<string> codes)
	{
	}

	public EUGCMatchMode GetUGCMapMatchMode(MapModeData mapModeData = null)
	{
		return EUGCMatchMode.None;
	}

	public int GetUGCMapUniqueID(MapModeData data)
	{
		return 0;
	}

	public bool IsUGCMapAvailable(bool request = false, Action notReadyCallback = null, MapModeData mapModeData = null)
	{
		return false;
	}

	public bool IsUGCMapAvailable(bool request, Action notReadyCallback, EUGCMatchMode matchMode, bool isCustomTag = false, MapModeData mapModeData = null)
	{
		return false;
	}

	public bool IsNewPGCMapAvailable(MapModeData mapModeData, out PGCMapInfo pgcMapInfo)
	{
		pgcMapInfo = null;
		return false;
	}

	private void RequestPGCMapInfo(List<PGCMapInfos> mapInfosList, bool requestSlotInfo = false)
	{
	}

	private void RequestPGCGameData(PGCMapInfos pgcMapInfos, HashSet<string> urls)
	{
	}

	public PGCMapInfo GetMainPGCMapInfo(uint gameMode)
	{
		return null;
	}

	public PGCMapInfos GetPGCMapInfos(uint gameMode)
	{
		return null;
	}

	public void ClearPGCMapResInfo()
	{
	}

	public void ReloadPGCMapResInfo()
	{
	}

	public void ReRequestFailedPGCMapInfo()
	{
	}

	private void InitPGCMapInfos()
	{
	}

	public void RequestUpdatePGCMapInfo(uint gameMode, bool requestSlotInfo = false)
	{
	}

	public void MarkPGCMapNeedsToUpdate(uint gameMode)
	{
	}

	public void ClearCSSpecialMatchProtectCostTimesDic()
	{
	}

	public bool IsCSSpecialModeDisplayNoInteract(uint specialModeEventID)
	{
		return false;
	}

	public void SetCSSpecialMatchChoose(uint special_mode_event_id, bool target)
	{
	}

	public bool GetCSSpecialMatchChoose(uint special_mode_event_id)
	{
		return false;
	}

	public void RequestPlayerSpecialModeInfo()
	{
	}

	public SpecialModeOpeningInfoDesc GetVaildCSSpecialMatchInfo()
	{
		return null;
	}

	public bool TryGetCSSpecialModeOpeningInfoWithEventID(uint eventID, out SpecialModeOpeningInfoDesc specialModeOpeningInfo)
	{
		specialModeOpeningInfo = null;
		return false;
	}

	public bool TryGetCSSpecialMatchCoverCDN(uint eventID, out string link)
	{
		link = null;
		return false;
	}

	public SpecialModeOpeningInfoDesc GetValidSpecialMatchInfo(uint gameMode, uint matchMode)
	{
		return null;
	}

	public ResourceID GetSpecialPlayDropdownRes_CS_Rank()
	{
		return default(ResourceID);
	}

	public bool IsShowProtectPointsCarousel_CSrank()
	{
		return false;
	}

	private void PrepareAllCSSpecialModeContainers()
	{
	}

	private void CleanAllCSSpecialModeContainers()
	{
	}

	private void InitCSSpecialModeSelectState(SpecialModeOpeningInfoDesc desc)
	{
	}

	private bool IsCSSpecialModeDisplayNoInteractInternal(uint specialModeEventID)
	{
		return false;
	}

	private bool GetCurrentCSSpecialStyleConfigData(out GameplayAffixEventStyleConfigData configData)
	{
		configData = null;
		return false;
	}

	public void ProcesccRankLimitMapData(List<MMCertainMapDesc> dataList)
	{
	}

	public bool CheckIsLimitByCertainMapData(uint gameMode, uint matchMode, out MMCertainMapDesc certainLimitMapData)
	{
		certainLimitMapData = null;
		return false;
	}

	public uint GetMapUnlimitRank(uint gameMode, uint matchMode, uint mapID)
	{
		return 0u;
	}

	public bool UpdateRankLimitMapData(uint gameMode, uint matchMode, List<MapModeData> modes)
	{
		return false;
	}

	public void ProcessCSRankSpecialMatchOpeningRankMapping(bool needNotifyDataChanged = true)
	{
	}

	public uint GetCurrentCSRankSpecialMatchIdSelect()
	{
		return 0u;
	}

	public uint GetCSSpecialMatchProtectTimes(uint event_id)
	{
		return 0u;
	}

	public UGCSimpleDownloadTask NeedDownloadUGCMapRes(bool request = false, MapModeData mapModeData = null)
	{
		return null;
	}

	public UGCSimpleDownloadTask NeedDownloadUGCMapRes(bool request, EUGCMatchMode matchMode = EUGCMatchMode.None, bool isCustomTag = false, MapModeData mapModeData = null)
	{
		return null;
	}

	public void TryDownloadMapRes(MapModeData modeMapData)
	{
	}

	public bool IsTagMatchNeedForceDownload()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool IsSocialAreaOptionalResTag(uint tag)
	{
		return false;
	}

	private void CheckUGCNecessaryResourceDownloaded()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public bool IsClassicMode(MapModeData data)
	{
		return false;
	}

	public void SetMapDelayExitDesc(CSQuitControlDescRes desc)
	{
	}

	public void SetMapRP(RankingMatchParam data)
	{
	}

	public long GetRegionServerTimeOffset()
	{
		return 0L;
	}

	public bool DownloadMapModesIfNeed(List<MapModeData> maps)
	{
		return false;
	}

	public bool DownloadMapModeIfNeed(MapModeData mapModeData = null)
	{
		return false;
	}

	public void TryDownloadUGCMapRes(UGCSimpleDownloadTask resDownloadTask, bool auto = false)
	{
	}

	public void TryDownloadPGCMapRes(PGCMapInfo pgcMapInfo)
	{
	}

	public void TryDownloadMapRes(uint mapId, uint modeId)
	{
	}

	public void TryDownloadMapRes(uint mapConfigId)
	{
	}

	public void TryDownloadMapRes(List<ResourceID> needDownloadRes, uint mapID, uint modeID)
	{
	}

	public void RequestUGCHotTagInfo()
	{
	}

	public bool IsSameMapData(MapModeData mapConfig1, MapModeData mapConfig2)
	{
		return false;
	}

	public bool IsMapDifficultySame(MapModeData mapConfig1, MapModeData mapConfig2)
	{
		return false;
	}

	public void CheckRandomUGCMap(WorkshopUGCOpeningInfoDesc desc)
	{
	}

	private ulong EncodeMatchGameToUlong(uint matchMode, uint gameMode)
	{
		return 0uL;
	}

	public void ProcessGameCloseInfo(CSGameCloseInfoDescRes infos)
	{
	}

	private uint GetMatchGamePreCloseTime(uint matchMode, uint gameMode, out bool needPreClose)
	{
		needPreClose = default(bool);
		return 0u;
	}

	public bool IsMatchGamePreClose(uint matchMode, uint gameMode)
	{
		return false;
	}

	public void PreCloseMapAutoReSelected()
	{
	}

	public void RequestGameModeStatsOpeningInfo(HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	private bool CanPick(MapModeData mapData)
	{
		return false;
	}

	private bool MapIsInRankLImit(MapModeData mapData)
	{
		return false;
	}

	public List<MapModeData> GetCanPickMaps(List<MapModeData> maps)
	{
		return null;
	}

	public string GetCraftLandGameModeCDN(string CDNType)
	{
		return null;
	}

	private void _003CRequestUGCSocialAreaMapInfo_003Eb__120_0(bool success, SceneEditSlotInfo slotInfo)
	{
	}

	private bool _003CGetPeriodicRankMapAvailableMapList_003Eb__166_0(MapOpeningInfo x)
	{
		return false;
	}

	private bool _003CGetBrDefaultMap_003Eb__233_0(MapOpeningInfo info)
	{
		return false;
	}

	private bool _003CGetCsPeakDefaultMap_003Eb__235_0(MapOpeningInfo info)
	{
		return false;
	}

	private bool _003CGetCsDefaultMap_003Eb__237_0(MapOpeningInfo info)
	{
		return false;
	}

	private bool _003CGetCsCasualDefaultMap_003Eb__238_0(MapOpeningInfo info)
	{
		return false;
	}

	private bool _003CUpdateLevelVisualStyle_003Eb__244_0(MapModeData a)
	{
		return false;
	}

	private void _003CRequestUGCMapOpeningInfo_003Eb__280_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestWorkshopSelectionPageInfo_003Eb__281_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUGCAlgorithmInfo_003Eb__282_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPlayerSpecialModeInfo_003Eb__343_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUGCHotTagInfo_003Eb__385_0(HttpErrorCode errorCode, object res)
	{
	}

	private bool _003CPreCloseMapAutoReSelected_003Eb__393_0(MapOpeningInfo x)
	{
		return false;
	}

	private void _003CRequestGameModeStatsOpeningInfo_003Eb__394_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
