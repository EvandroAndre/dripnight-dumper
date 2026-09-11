using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class UIModelMatch : UIBaseModel
{
	private class ObserverTrackingItemStateCache
	{
		public PPCMIEPMLNN State;

		public float SyncedServerTimeSec;
	}

	private class ObserverTrackingItemStateSlotCache
	{
		public readonly Dictionary<uint, ObserverTrackingItemStateCache> Entries;

		public readonly List<uint> OrderedDataIDs;

		public void Clear()
		{
		}
	}

	public enum MatchMakingTipsRuleType
	{
		RankingGap = 1,
		TroughPeriod
	}

	public enum GroupTypeToPlayClanWar
	{
		False,
		GroupOnlyOnePerson,
		GroupNotFull,
		GroupFull
	}

	public enum LastMatchTypeEnum
	{
		Solo,
		Group
	}

	public class PlayerDeadInfo
	{
		public string KillerName;

		public string WeaponName;

		public Vector3 KillerPos;

		public bool KillerIsZombie;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<EPPlayerInfo> _003C_003E9__494_0;

		public static Comparison<NewbiePresetDesc> _003C_003E9__513_1;

		public static Converter<MapModeData, uint> _003C_003E9__519_0;

		public static Comparison<MatchmakingBlacklistPlayerInfo> _003C_003E9__540_1;

		public static Comparison<ResultTeamData> _003C_003E9__604_0;

		public static Comparison<MatchmakingTipsNewDesc> _003C_003E9__858_0;

		public static Action<HttpErrorCode, object> _003C_003E9__863_0;

		internal int _003CUpdateEPRankingList_003Eb__494_0(EPPlayerInfo a, EPPlayerInfo b)
		{
			return 0;
		}

		internal int _003CRequestNewbieGuideDescRes_003Eb__513_1(NewbiePresetDesc a, NewbiePresetDesc b)
		{
			return 0;
		}

		internal uint _003CRequestStartMatchMakingInternal_003Eb__519_0(MapModeData item)
		{
			return 0u;
		}

		internal int _003CRequestMatchBlackList_003Eb__540_1(MatchmakingBlacklistPlayerInfo x, MatchmakingBlacklistPlayerInfo y)
		{
			return 0;
		}

		internal int _003CGenerateMatchResult_003Eb__604_0(ResultTeamData a, ResultTeamData b)
		{
			return 0;
		}

		internal int _003CGetMatchMakingTipsWhenStartMatch_003Eb__858_0(MatchmakingTipsNewDesc x, MatchmakingTipsNewDesc y)
		{
			return 0;
		}

		internal void _003CRequestAvatarSkillOverwrite_003Eb__863_0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass378_0
	{
		public ulong myAccountId;

		internal int _003CSetLoadingPlayerInfo_003Eb__0(MatchPregameInfo x, MatchPregameInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass483_0
	{
		public BHGGAEEHJCO playerID;

		internal bool _003COnAddPlayer_003Eb__1(PlayerData a)
		{
			return false;
		}

		internal bool _003COnAddPlayer_003Eb__0(PlayerData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass489_0
	{
		public BHGGAEEHJCO pid;

		internal bool _003CGetTeammateData_003Eb__0(PlayerData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass518_0
	{
		public UIModelMatch _003C_003E4__this;

		public DLBMPCCFKKM match_mode;

		public NIKKALKPIBO game_mode;

		public List<uint> map_ids;

		public uint map_difficulty;

		public bool isRandomMap;

		public bool isFirstGuideMatch;

		public ulong groupId;

		public Action _003C_003E9__2;

		internal void _003CRequestStartMatchMaking_003Eb__0(ResErrorCode error, ResDownloadType download_type)
		{
		}

		internal void _003CRequestStartMatchMaking_003Eb__2()
		{
		}

		internal void _003CRequestStartMatchMaking_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass520_0
	{
		public UIModelMatch _003C_003E4__this;

		public uint matchMode;

		public uint gameMode;

		public ulong accountID;

		public Action _003C_003E9__2;

		internal void _003CRequestStartMatchmakingSpectate_003Eb__0(ResErrorCode error, ResDownloadType download_type)
		{
		}

		internal void _003CRequestStartMatchmakingSpectate_003Eb__2()
		{
		}

		internal void _003CRequestStartMatchmakingSpectate_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass522_0
	{
		public UIModelMapOpeningInfo openningInfo;

		public Action callBack;

		internal void _003CCheckIfNeedRequestWorkshopInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass540_0
	{
		public UIModelMatch _003C_003E4__this;

		public bool fromClickBlock;

		public ulong accountId;

		internal void _003CRequestMatchBlackList_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass541_0
	{
		public ulong accountId;

		internal bool _003CIsPlayerInBlackList_003Eb__0(AccountInfoBasic player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass544_0
	{
		public ulong[] removeBlacklistIds;

		public int i;

		public Predicate<AccountInfoBasic> _003C_003E9__0;

		internal bool _003CProcessRemoveMatchBlackList_003Eb__0(AccountInfoBasic player)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass545_0
	{
		public UIModelMatch _003C_003E4__this;

		public ulong blacklistId;

		public uint gameMode;

		public uint matchMode;

		public ulong matchID;

		public int curCount;

		public CSAddMatchmakingBlacklistReq req;

		internal void _003CRequestAddMatchBlackListPlayer_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass546_0
	{
		public UIModelMatch _003C_003E4__this;

		public ulong[] blacklistIds;

		internal void _003CRequestRemoveMatchBlackListPlayer_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass605_0
	{
		public ulong playerId;

		internal bool _003CGetTutorialPlayerDataByPlayerID_003Eb__0(PlayerData a)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass606_0
	{
		public ulong accountID;

		internal bool _003CGetPlayerDataByAccountID_003Eb__0(PlayerData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass607_0
	{
		public BHGGAEEHJCO playerID;

		internal bool _003CGetPlayerDataByPlayerID_003Eb__0(PlayerData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass608_0
	{
		public string nickName;

		internal bool _003CGetPlayerDataByNickName_003Eb__0(PlayerData p)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass734_0
	{
		public byte teamID;

		internal bool _003CGetRankByTeamID_003Eb__0(byte t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass735_0
	{
		public byte teamID;

		internal bool _003CGetLastRankByTeamID_003Eb__0(byte t)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass813_0
	{
		public CandidateReporteeData killer;

		internal bool _003CGetCandiateReportees_003Eb__0(CandidateReporteeData x)
		{
			return false;
		}

		internal bool _003CGetCandiateReportees_003Eb__1(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass813_1
	{
		public PlayerData damagerData;

		internal bool _003CGetCandiateReportees_003Eb__2(CandidateReporteeData x)
		{
			return false;
		}

		internal bool _003CGetCandiateReportees_003Eb__3(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass813_2
	{
		public CandidateReporteeData teammate;

		internal bool _003CGetCandiateReportees_003Eb__4(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass814_0
	{
		public CandidateReporteeData killer;

		internal bool _003CHasAnyCandidateReporteeBeforeFilter_003Eb__0(CandidateReporteeData x)
		{
			return false;
		}

		internal bool _003CHasAnyCandidateReporteeBeforeFilter_003Eb__1(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass814_1
	{
		public PlayerData damagerData;

		internal bool _003CHasAnyCandidateReporteeBeforeFilter_003Eb__2(CandidateReporteeData x)
		{
			return false;
		}

		internal bool _003CHasAnyCandidateReporteeBeforeFilter_003Eb__3(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass814_2
	{
		public CandidateReporteeData teammate;

		internal bool _003CHasAnyCandidateReporteeBeforeFilter_003Eb__4(CandidateReporteeData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass845_0
	{
		public IngameFeedbackData feedData;

		internal bool _003CGetMatchResultBadgeInfo_003Eb__1(IngameFeedbackData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass852_0
	{
		public GameModeStatsConfigManager.ESortOrder sortOrder;

		internal int _003CHandleRecPersistentData_003Eb__0(UIHudRegionLeaderboardItemController.RegionRankPlayerInfo a, UIHudRegionLeaderboardItemController.RegionRankPlayerInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass853_0
	{
		public GameModeStatsConfigManager.ESortOrder sortOrder;

		internal int _003CGetSortedCurMatchPlayerList_003Eb__0(UIHudRegionLeaderboardItemController.CurMatchPlayerInfo a, UIHudRegionLeaderboardItemController.CurMatchPlayerInfo b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass898_0
	{
		public UIModelMatch _003C_003E4__this;

		public Action onFailed;

		public bool needBlock;

		internal void _003CRequestGotoLobbySocialArea_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass899_0
	{
		public bool needBlock;

		public UIModelMatch _003C_003E4__this;

		public Action onFailed;

		internal void _003CRequestGotoLobbySocialAreaInternal_003Eb__0()
		{
		}
	}

	private sealed class _003CWaitGroupInfoNotReady_Accept_003Ed__507 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelMatch _003C_003E4__this;

		public InviteSocialNtf inviteSocialNtf;

		public bool isCancelReady;

		private float _003Ctimeout_003E5__2;

		private float _003CstartTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitGroupInfoNotReady_Accept_003Ed__507(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitGroupInfoNotReady_Request_003Ed__512 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelMatch _003C_003E4__this;

		public ulong targetPlayerId;

		public uint gameMode;

		public bool isCancelReady;

		private float _003Ctimeout_003E5__2;

		private float _003CstartTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitGroupInfoNotReady_Request_003Ed__512(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CWaitMemberNotReady_003Ed__895 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIModelMatch _003C_003E4__this;

		public Action onReady;

		public Action onFailed;

		private float _003Ctimeout_003E5__2;

		private float _003CstartTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CWaitMemberNotReady_003Ed__895(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public Vector3? LobbySocialAreaLastPlayerPos;

	public Vector3? LobbySocialAreaLastPlayerForward;

	public Quaternion? LobbySocialAreaLastPlayerAimRotation;

	public HashSet<ulong> LobbySocialAreaSkipGroupAnimUserIds;

	public const uint PropID_NewbieGuideDesc = 1u;

	public const uint PropID_MatchTime = 2u;

	public const uint PropID_LocalPlayerKillCount = 4u;

	public const uint PropID_RemainingPlayer = 8u;

	public const uint PropID_KillOccurs = 16u;

	public const uint PropID_TeammateAceEnemyTeam = 32u;

	public const uint PropID_PickupListChanged = 64u;

	public const uint PropID_SniperOn = 128u;

	public const uint PropID_RefreshMatchResult = 256u;

	public const uint PropID_TeammateAdd = 512u;

	public const uint PropID_TeammateDel = 1024u;

	public const uint PropID_ObservePlayerKillCount = 2048u;

	public const uint PropID_ObserverPlayerChanged = 4096u;

	public const uint PropID_BattleInfo = 8192u;

	public const uint PropID_TargetPlayerKillOccurs = 16384u;

	public const uint PropID_TeamateKnockDown = 32768u;

	public const uint PropID_ObserverTeammateSwitch = 65536u;

	public const uint PropID_KnockOtherDown = 131072u;

	public const uint PropID_EPRankingChange = 262144u;

	public const uint PropID_EPRankingTopChange = 524288u;

	public const uint PropID_RedEnvelopeInfo = 1048576u;

	public const uint PropID_PVEEnemyRemaingCount = 2097152u;

	public const uint PropID_PVEEnemyKillCount = 4194304u;

	public const uint PropID_PVETurnCount = 8388608u;

	public const uint PropID_LocalPlayerDeathCount = 16777216u;

	public const uint PropID_ObservePlayerDeathCount = 33554432u;

	public const uint PropID_BombMatchBombInfoChange = 67108864u;

	public const uint PropID_BanknoteMatchUnlockInfoChange = 134217728u;

	public const uint PropID_AskPurchaseUpdate = 268435456u;

	public const uint PropID_REVIVEINFO = 536870912u;

	public const uint PropID_SYSTEMKILL = 1073741824u;

	public const uint PropID_GetMatchBlackList = 2147483648u;

	public const uint KILL_FLAG_FIRST_BLOOD = 1u;

	private Dictionary<BHGGAEEHJCO, int> m_MatchKillCount;

	private Dictionary<BHGGAEEHJCO, int> m_MatchDeathCount;

	public Dictionary<BHGGAEEHJCO, string> KilledBySystemPlayerDict;

	public Dictionary<BHGGAEEHJCO, string> KilledBySystemTeammateDict;

	private Dictionary<BHGGAEEHJCO, ulong> m_PlayerAceTimeDict;

	private bool m_IsMatchMaking;

	private MatchModelKillData m_Data;

	private Dictionary<ulong, int> m_AccountIDToTeamIndex;

	public const int COUNT_DOWN_SECOND = 5;

	public uint RunningMatchingTime;

	public uint EstimateTime;

	public uint ReShowGameMode;

	public uint ReShowMatchMode;

	private const int ContinueKnockDownNeedCountBeforeAceInBr = 4;

	private HashSet<uint> m_MapLegendSet;

	private int m_MatchTime;

	private const int ObserverTrackingItemStateSlotCount = 4;

	private readonly ObserverTrackingItemStateSlotCache[] m_ObserverTrackingItemStateSlots;

	private uint m_ObserverTrackingItemStatePlayerID;

	private const int EPBADGE_RANKING_FILTER = 10;

	private List<EPPlayerInfo> m_ElitePassRankingList;

	private EPPlayerInfo m_LocalPlayerElitePassInfo;

	public List<uint> ListOverloadSceneCount;

	public bool SaveLocalPlayerTeammates;

	public List<PlayerData> LocalPlayerTeammates;

	public int MatchEndRank;

	public List<byte> GroupMedals;

	private List<ulong> m_LastMatchPlayerTeammates;

	private Queue<List<ulong>> m_Last10MatchPlayerTeammates;

	private int m_PreRank;

	private int m_CurRank;

	private DLBMPCCFKKM m_RankPromoteMatchMode;

	public byte LocalTeamId;

	public int Team1Score;

	public int Team2Score;

	private List<CandidateReporteeData> m_KillerList;

	private CandidateReporteeData m_KillerData;

	private CandidateReporteeData m_KnockDownerData;

	private uint m_LastTPCount;

	private float m_LastTPTime;

	public bool BanAvatarActiveSkill;

	public bool BanAvatarPassiveSkill;

	public uint CDPercentForAllActiveSkill;

	public Dictionary<string, uint> CDPercentPerActiveSkill;

	private bool _003CIsChickenPlayerObserver_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingHideKillInfo_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingNoSkill_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingHideCloth_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingUnlimitedAmmo_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingUnlimitedGloowall_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingUnlimitedThrowables_003Ek__BackingField;

	private bool _003CMapUIShowDeadBoxEnable_003Ek__BackingField;

	private bool _003CIsNoPowerGun_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingNoHud_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingFriendDmg_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingInGameChatOpen_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingNoAuxAim_003Ek__BackingField;

	private bool _003CIsCustomRoomSettingAutoReviveEnabled_003Ek__BackingField;

	private bool _003CIsSoloReviveMatchMode_003Ek__BackingField;

	private bool _003CIsSoloRevivePointEnabled_003Ek__BackingField;

	private bool _003CIsCustomRoomPrivilageVoiceOpen_003Ek__BackingField;

	private bool _003CIsCustomRoomAndHeadShotOnly_003Ek__BackingField;

	private bool _003CIsAdvRoomOpen_003Ek__BackingField;

	private bool isMobileReplayEnabled;

	private string m_WorkshopShareCode;

	private string _003CWorkshopMapName_003Ek__BackingField;

	private bool _003CShowingHallOverMask_003Ek__BackingField;

	private bool _003CUserControlDirty_003Ek__BackingField;

	private bool _003CEnableEPRecoveryOverwrite_003Ek__BackingField;

	private ulong _003CMVPPlayerUID_003Ek__BackingField;

	private TeammateStats _003CRecommendCriticalData_003Ek__BackingField;

	private EMatchRecommendCriticalType _003CRecommendCriticalType_003Ek__BackingField;

	public List<GroupJoinRequestNtf> CacheGroupJoinRequestNtf;

	public List<GroupInviteNtf> CacheGroupInviteNtf;

	private MatchResultHighlightWindowInfo _003CHighlightWindowInfo_003Ek__BackingField;

	private bool _003CHideClientDamageShow_003Ek__BackingField;

	private int _003CPlayerShowDamageTypePref_003Ek__BackingField;

	private bool _003CIsKickOutByUGC_003Ek__BackingField;

	private float _003CInventoryTransferItemDis_003Ek__BackingField;

	private List<BHGGAEEHJCO> m_LocalTeamPlayerIDs;

	private List<BHGGAEEHJCO> m_OppoTeamPlayerIDs;

	private Dictionary<byte, List<BHGGAEEHJCO>> m_TeamPlayerIDs;

	private List<ulong> m_LocalSubTeamIDs;

	private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

	private List<ResultTeamData> m_MatchResult;

	private List<PlayerData> m_PlayerDataList;

	private MatchStatsRes m_PendingMatchResultData;

	private List<TeammateStats> m_ArmsRaceAllPlayerStats;

	private Dictionary<ulong, proto.ExternalIconInfo> m_DicExternalInfos;

	private List<Vector4> m_MotionPlatformCheckAreas;

	private List<Vector4> m_MotionPlatformForbiddenDummyZones;

	private List<Vector4> m_MotionPlatformForbiddenPersonalAirdropZones;

	private NIKKALKPIBO _003COnlineGameMode_003Ek__BackingField;

	private int _003CAveragePing_003Ek__BackingField;

	private int _003COverPingCount_003Ek__BackingField;

	private bool _003CIsWifiAndCellularConnected_003Ek__BackingField;

	private bool _003CNeedShowRematchReason_003Ek__BackingField;

	private bool _003CNeedShowMatchMakingRematchUIFX_003Ek__BackingField;

	private EMatchReasonTextKey _003CReShowMatchReasonTextKey_003Ek__BackingField;

	private bool m_HasGetGameplaySurvey;

	private bool m_IsRequestingGameplaySurvey;

	private List<GameplaySurveyDesc> m_GameplayWebSurveyDescs;

	private List<GameplayFeedbackQuestionDesc> m_GameplayFeedbackQuestionDesc;

	private Dictionary<uint, GameplayFeedbackOptionDesc> m_DicOptionIdToOptionDesc;

	private List<GameplayFeedbackDesc> m_GameplayFeedbackDescs;

	private List<QuickFeedbackQuestDesc> m_QuickFeedbackQuestDescs;

	private uint m_CurrentMatchFeedbackQuestionId;

	private HashSet<BHGGAEEHJCO> m_HasRequestedAddFriendInGame;

	private MatchStatsBrief m_MatchStatsBrief;

	private CSMatchStatsBrief m_CSMatchStatsBrief;

	private List<ProficiencyChangeNtf> m_CacheProficiencyChangeNtfList;

	private bool m_NeedShowExtraResultBG;

	private ulong m_LastMatchRecordUserID;

	private string m_LastMatchRecordUserName;

	private bool m_RecordedPlayer;

	private bool m_HasLeaveGame;

	public bool KeepLastMatchResultOnNextStartMatch;

	private bool m_IsInviteInGamePlayerEnabled;

	private ulong m_VFXLobbyStartMatchMakingNextPlayTime;

	public List<uint> QuickMatchShowList;

	public List<uint> QuickMatchMatchModeList;

	public List<uint> QuickMatchGameModeList;

	public List<uint> QuickMatchGroupModeList;

	public Dictionary<long, MatchmakingTipsNewDesc> m_DictParamToMatchmakingTipsNewDesc;

	private List<AccountInfoBasic> m_MatchBlackList;

	private bool m_GetMatchBlackList;

	private int m_MaxMatchBlacklistCount;

	public int MaxMatchBlacklistDay;

	public int MaxMatchBlackListPrimaAdditional;

	private bool _003CNeedGuideBlockAfterReport_003Ek__BackingField;

	public bool IsPostMatchMatchMaking;

	private Dictionary<ulong, long> m_MatchBlackPlayerTimeDict;

	private List<ThumbUpTutorialDesc> m_ThumbUpTutorialDesc;

	private List<NewbiePresetDesc> m_NewbiePresetDesc;

	public bool m_DisableRequestGuideAvatar;

	private bool m_HaveGetNewbieGuideDesc;

	public bool IsForceTutorialGameFinished;

	private List<MatchResultRewardInfo> m_MatchResultRewardList;

	private List<MatchPregameInfo> m_LoadingPlayerInfo;

	public ulong LastMatchTs;

	public LastMatchTypeEnum LastMatchType;

	private int m_LocalPlayerKillCount;

	private int m_LocalPlayerDeathCount;

	public int LocalPlayerPendingReviveEndTimeMs;

	public uint LocalPlayerCurLeftFreeAutoReviveNum;

	public uint LocalPlayerCurMaxFreeAutoReviveNum;

	public uint LocalPlayerCurReviveCoinNum;

	public uint LocalPlayerCurReviveCoinCost;

	public uint LocalPlayerCurGemNum;

	public uint LocalPlayerCurReviveGemCost;

	public bool IsLocalPlayerCanUseGemRevive;

	private int m_RemainingPlayerCount_max;

	private int m_RemainingPlayerCount;

	private PlayerDeadInfo m_PlayerDeadInfoData;

	private PlayerDeadInfo m_LocalPlayerDeadInfoData;

	private ulong m_LastMatchEndTimeStamp;

	private MatchIncome m_LastMatchIncome;

	private MatchStats m_LastMatchStats;

	private tcp.HuntingGroundRecords m_LastHuntingGroundRecords;

	private HippoMatchStatsBrief m_LastHippoMatchStatsBrief;

	private tcp.HuntingGroundLikePVERecords m_LastHGLikePVERecords;

	private bool m_IsLowest;

	private bool m_HasPendingMatchRequest;

	private float m_TimeLastKnockDown;

	private float m_TimeLastKill;

	private float m_TimeNoQuickChat;

	private float m_TimeNoOverlapQuickChat;

	private IEnumerator AcceptInviteToSocialCoroutine;

	private IEnumerator RequestJoinSocialAreaCoroutine;

	private const string CarryNoticeShownKeyFmt = "SocialLobbySRB_NoticeCarry_{0}";

	private const string RideNoticeShownKeyFmt = "SocialLobbySRB_NoticeRide_{0}";

	private const string CarryTriggerGuideShownKeyFmt = "SocialLobbySRB_TriggerGuide_{0}";

	private const string CarryBattleFireBtnUsedKeyPrefix = "CarryBattleAttackBtnFireUsed_";

	private bool m_CarryNoticeLoaded;

	private bool m_ShownCarryNotice;

	private bool m_ShownRideNotice;

	private bool m_ShownCarryTriggerGuide;

	private bool m_CarryBattleFireBtnUsedLoaded;

	private bool m_CarryBattleFireBtnUsed;

	private List<BHGGAEEHJCO> m_EmoteLeaderList;

	private BHGGAEEHJCO m_LocalFollowEmoteLeader;

	private uint m_LeadEmoteSimTick;

	private bool m_HasClickWaitingPhaseThumbUp;

	private HashSet<BHGGAEEHJCO> m_LikedPlayerSet;

	private HashSet<ulong> m_ReportedPlayerSet;

	private HashSet<BHGGAEEHJCO> m_FriendlyInteractionPlayerSet;

	private Dictionary<ulong, HashSet<ulong>> m_Match2ReportedPlayer;

	private Dictionary<ulong, byte> m_CacheUserPlatform;

	private Dictionary<ulong, string> m_CacheUserClientVersion;

	private Dictionary<ulong, uint> m_CacheUserClientType;

	private HashSet<BHGGAEEHJCO> m_RequestedPlayerSet;

	private int m_PVERemainingEnemyCount;

	private int m_PVETurnCount;

	private int m_PVEMaxTurnCount;

	public Dictionary<BHGGAEEHJCO, int> m_PlayerPVEEnemyKillMap;

	private int m_CSWinTeamIdCurRound;

	private int m_LocalFactionID;

	private FakeSubmitRes m_ClanMatchResult;

	private int m_ODLocalFactionID;

	private int m_LocalPlayerArmsLevel;

	private int m_OpponentPlayerArmsLevel;

	private int m_UnlockItemIndex;

	private int m_UnlockLevel;

	private List<uint> m_AllLevelEquipList;

	private int m_OneLevelSetCount;

	private List<byte> m_PlayerSelectedEquipIndexList;

	private uint m_CommonEquipSetGroupBit;

	private List<uint> m_CommonEquipSetList;

	private List<byte> m_CSSORankList;

	private List<byte> m_CSSOLastRoundRankList;

	private List<byte> m_CSSOTeamsHPList;

	private List<byte> m_CSSOLastRoundTeamsHPList;

	private Dictionary<byte, int> m_CSSOTeamIndexDict;

	private Dictionary<BHGGAEEHJCO, uint> m_CSSOPlayerZoneIndexDict;

	private Dictionary<byte, bool> m_CSSOBattleResults;

	private Dictionary<BHGGAEEHJCO, HKKMLEMBAGG> m_CSSOPlayerKillInfos;

	private Dictionary<uint, bool> m_CSSOZoneIndexSpecial;

	private Dictionary<byte, byte> m_CSSOTeamEliminateInfo;

	private Dictionary<int, uint> m_CSSOTeamColorDict;

	private Dictionary<int, uint> m_CSSOTeamNameColorDict;

	private Dictionary<int, string> m_CSSOTeamBBCodeColorDict;

	private Dictionary<int, string> m_CSSOTeamNameDict;

	private Dictionary<int, string> m_CSSORankStringDict;

	private Dictionary<int, float> m_TDShowOverEffectTime;

	private bool _003CHideArrowOnMinimap_003Ek__BackingField;

	private Dictionary<BHGGAEEHJCO, AskCSPurchaseInfo> m_PlayerAskPurchaseDic;

	private static int s_NextAskSequence;

	private Dictionary<byte, MFNHNEDOGKH> m_LWSOTeamInfoDict;

	private Dictionary<byte, BLMNAEJBDLA> m_LWSOTeamInfoLastRoundResult;

	private Dictionary<uint, EEGMNEFLNHP> m_LWSOPlayerKillInfoDict;

	private BHGGAEEHJCO m_DeathMatchKillerKingID;

	private Dictionary<BHGGAEEHJCO, uint> m_FootballPlayerSkillRelation;

	private Dictionary<uint, int> m_FootballSkillPlayerRelation;

	private Dictionary<uint, uint> m_InGameFeedBackIdToPriorityId;

	private bool m_PersistentDataCurPlayerDicDirty;

	private Dictionary<BHGGAEEHJCO, UIHudRegionLeaderboardItemController.CurMatchPlayerInfo> m_PersistentDataCurMatchPlayerDic;

	private List<UIHudRegionLeaderboardItemController.RegionRankPlayerInfo> m_PersistentDataRegionRankPlayerList;

	public byte OpenEvents;

	private HashSet<BHGGAEEHJCO> m_SuperEmoteLikedPlayerSet;

	public ulong LonewolfTargetAccountID;

	public bool LonewolfTargetIsLogout;

	private string m_LonewolfTargetLockRegion;

	private List<IBPMKFFAEEG> m_TrainingMatchBattleReviveShopList;

	private IEnumerator m_CancelMemberReadyCoroutine;

	private uint m_Match3DLobbyCoroutineID;

	private UIWaitingForRequestController m_WaitingForRequestController;

	private const string TrainingShopNewTagItemKeyPrefix = "TrainingShopNewTagItem_";

	private readonly HashSet<uint> m_TrainingShopUnreadNewItemIds;

	private readonly HashSet<uint> m_TrainingShopSeenNewItemIds;

	private readonly HashSet<uint> m_TrainingShopCheckedNewItemIds;

	private ulong m_TrainingShopNewTagAccountId;

	public bool IsMatchMaking
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int MatchTime => 0;

	public MapConfigData MapConfig => null;

	public List<EPPlayerInfo> ElitePassRankingList => null;

	public EPPlayerInfo LocalPlayerElitePassInfo => null;

	public List<ulong> LastMatchPlayerTeammates => null;

	public Queue<List<ulong>> Last10MatchPlayerTeammates => null;

	public bool IsChickenPlayerObserver
	{
		get
		{
			return _003CIsChickenPlayerObserver_003Ek__BackingField;
		}
		set
		{
			_003CIsChickenPlayerObserver_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingHideKillInfo
	{
		get
		{
			return _003CIsCustomRoomSettingHideKillInfo_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingHideKillInfo_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingNoSkill
	{
		get
		{
			return _003CIsCustomRoomSettingNoSkill_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingNoSkill_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingHideCloth
	{
		get
		{
			return _003CIsCustomRoomSettingHideCloth_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingHideCloth_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingUnlimitedAmmo
	{
		get
		{
			return _003CIsCustomRoomSettingUnlimitedAmmo_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingUnlimitedAmmo_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingUnlimitedGloowall
	{
		get
		{
			return _003CIsCustomRoomSettingUnlimitedGloowall_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingUnlimitedGloowall_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingUnlimitedThrowables
	{
		get
		{
			return _003CIsCustomRoomSettingUnlimitedThrowables_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingUnlimitedThrowables_003Ek__BackingField = value;
		}
	}

	public bool MapUIShowDeadBoxEnable
	{
		get
		{
			return _003CMapUIShowDeadBoxEnable_003Ek__BackingField;
		}
		set
		{
			_003CMapUIShowDeadBoxEnable_003Ek__BackingField = value;
		}
	}

	public bool IsNoPowerGun
	{
		get
		{
			return _003CIsNoPowerGun_003Ek__BackingField;
		}
		set
		{
			_003CIsNoPowerGun_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingNoHud
	{
		get
		{
			return _003CIsCustomRoomSettingNoHud_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingNoHud_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingFriendDmg
	{
		get
		{
			return _003CIsCustomRoomSettingFriendDmg_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingFriendDmg_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingInGameChatOpen
	{
		get
		{
			return _003CIsCustomRoomSettingInGameChatOpen_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingInGameChatOpen_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingNoAuxAim
	{
		get
		{
			return _003CIsCustomRoomSettingNoAuxAim_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingNoAuxAim_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomSettingAutoReviveEnabled
	{
		get
		{
			return _003CIsCustomRoomSettingAutoReviveEnabled_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomSettingAutoReviveEnabled_003Ek__BackingField = value;
		}
	}

	public bool IsSoloReviveMatchMode
	{
		get
		{
			return _003CIsSoloReviveMatchMode_003Ek__BackingField;
		}
		set
		{
			_003CIsSoloReviveMatchMode_003Ek__BackingField = value;
		}
	}

	public bool IsSoloRevivePointEnabled
	{
		get
		{
			return _003CIsSoloRevivePointEnabled_003Ek__BackingField;
		}
		set
		{
			_003CIsSoloRevivePointEnabled_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomPrivilageVoiceOpen
	{
		get
		{
			return _003CIsCustomRoomPrivilageVoiceOpen_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomPrivilageVoiceOpen_003Ek__BackingField = value;
		}
	}

	public bool IsCustomRoomAndHeadShotOnly
	{
		get
		{
			return _003CIsCustomRoomAndHeadShotOnly_003Ek__BackingField;
		}
		set
		{
			_003CIsCustomRoomAndHeadShotOnly_003Ek__BackingField = value;
		}
	}

	public bool IsAdvRoomOpen
	{
		get
		{
			return _003CIsAdvRoomOpen_003Ek__BackingField;
		}
		set
		{
			_003CIsAdvRoomOpen_003Ek__BackingField = value;
		}
	}

	public bool IsMobileReplayEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string WorkshopShareCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string WorkshopMapName
	{
		get
		{
			return _003CWorkshopMapName_003Ek__BackingField;
		}
		set
		{
			_003CWorkshopMapName_003Ek__BackingField = value;
		}
	}

	public bool ShowingHallOverMask
	{
		get
		{
			return _003CShowingHallOverMask_003Ek__BackingField;
		}
		set
		{
			_003CShowingHallOverMask_003Ek__BackingField = value;
		}
	}

	public bool UserControlDirty
	{
		get
		{
			return _003CUserControlDirty_003Ek__BackingField;
		}
		set
		{
			_003CUserControlDirty_003Ek__BackingField = value;
		}
	}

	public bool EnableEPRecoveryOverwrite
	{
		get
		{
			return _003CEnableEPRecoveryOverwrite_003Ek__BackingField;
		}
		set
		{
			_003CEnableEPRecoveryOverwrite_003Ek__BackingField = value;
		}
	}

	public ulong MVPPlayerUID
	{
		get
		{
			return _003CMVPPlayerUID_003Ek__BackingField;
		}
		set
		{
			_003CMVPPlayerUID_003Ek__BackingField = value;
		}
	}

	public TeammateStats RecommendCriticalData
	{
		get
		{
			return _003CRecommendCriticalData_003Ek__BackingField;
		}
		set
		{
			_003CRecommendCriticalData_003Ek__BackingField = value;
		}
	}

	public EMatchRecommendCriticalType RecommendCriticalType
	{
		get
		{
			return _003CRecommendCriticalType_003Ek__BackingField;
		}
		set
		{
			_003CRecommendCriticalType_003Ek__BackingField = value;
		}
	}

	public MatchResultHighlightWindowInfo HighlightWindowInfo
	{
		get
		{
			return _003CHighlightWindowInfo_003Ek__BackingField;
		}
		set
		{
			_003CHighlightWindowInfo_003Ek__BackingField = value;
		}
	}

	public bool HideClientDamageShow
	{
		get
		{
			return _003CHideClientDamageShow_003Ek__BackingField;
		}
		set
		{
			_003CHideClientDamageShow_003Ek__BackingField = value;
		}
	}

	public int PlayerShowDamageTypePref
	{
		get
		{
			return _003CPlayerShowDamageTypePref_003Ek__BackingField;
		}
		set
		{
			_003CPlayerShowDamageTypePref_003Ek__BackingField = value;
		}
	}

	public bool IsKickOutByUGC
	{
		get
		{
			return _003CIsKickOutByUGC_003Ek__BackingField;
		}
		set
		{
			_003CIsKickOutByUGC_003Ek__BackingField = value;
		}
	}

	public float InventoryTransferItemDis
	{
		get
		{
			return _003CInventoryTransferItemDis_003Ek__BackingField;
		}
		set
		{
			_003CInventoryTransferItemDis_003Ek__BackingField = value;
		}
	}

	public List<TeammateStats> ArmsRaceAllPlayerStats => null;

	public NIKKALKPIBO OnlineGameMode
	{
		get
		{
			return _003COnlineGameMode_003Ek__BackingField;
		}
		set
		{
			_003COnlineGameMode_003Ek__BackingField = value;
		}
	}

	public int AveragePing
	{
		get
		{
			return _003CAveragePing_003Ek__BackingField;
		}
		set
		{
			_003CAveragePing_003Ek__BackingField = value;
		}
	}

	public int OverPingCount
	{
		get
		{
			return _003COverPingCount_003Ek__BackingField;
		}
		set
		{
			_003COverPingCount_003Ek__BackingField = value;
		}
	}

	public bool IsWifiAndCellularConnected
	{
		get
		{
			return _003CIsWifiAndCellularConnected_003Ek__BackingField;
		}
		set
		{
			_003CIsWifiAndCellularConnected_003Ek__BackingField = value;
		}
	}

	public bool NeedShowRematchReason
	{
		get
		{
			return _003CNeedShowRematchReason_003Ek__BackingField;
		}
		set
		{
			_003CNeedShowRematchReason_003Ek__BackingField = value;
		}
	}

	public bool NeedShowMatchMakingRematchUIFX
	{
		get
		{
			return _003CNeedShowMatchMakingRematchUIFX_003Ek__BackingField;
		}
		set
		{
			_003CNeedShowMatchMakingRematchUIFX_003Ek__BackingField = value;
		}
	}

	public EMatchReasonTextKey ReShowMatchReasonTextKey
	{
		get
		{
			return _003CReShowMatchReasonTextKey_003Ek__BackingField;
		}
		set
		{
			_003CReShowMatchReasonTextKey_003Ek__BackingField = value;
		}
	}

	public MatchStatsBrief MatchStatsBrief
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public CSMatchStatsBrief CSMatchStatsBrief
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<ProficiencyChangeNtf> CacheProficiencyChangeNtfList => null;

	public List<BHGGAEEHJCO> MLocalTeamPlayerIDs => null;

	public List<BHGGAEEHJCO> MOppoTeamPlayerIDs => null;

	public bool NeedShowExtraResultBG
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ulong LastMatchRecordUserID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public string LastMatchRecordUserName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool HasLeaveGame => false;

	public bool IsInviteInGamePlayerEnabled => false;

	public ulong VFXLobbyStartMatchMakingNextPlayTime
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	public Dictionary<ulong, proto.ExternalIconInfo> DicExternalIconInfos => null;

	public List<GameplayFeedbackQuestionDesc> GameplayFeedbackQuestionDescs => null;

	public Dictionary<uint, GameplayFeedbackOptionDesc> DicOptionIdToOptionDesc => null;

	public List<GameplaySurveyDesc> GameplaySurveyDescs => null;

	public List<GameplayFeedbackDesc> GameplayFeedbackDescs => null;

	public List<QuickFeedbackQuestDesc> QuickFeedbackQuestDescs => null;

	public bool HasGetGameplaySurvey => false;

	public uint CurrentMatchFeedbackQuestionId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public List<AccountInfoBasic> MatchBlackList => null;

	public int MaxMatchBlacklistCount => 0;

	public bool NeedGuideBlockAfterReport
	{
		get
		{
			return _003CNeedGuideBlockAfterReport_003Ek__BackingField;
		}
		set
		{
			_003CNeedGuideBlockAfterReport_003Ek__BackingField = value;
		}
	}

	public List<MatchResultRewardInfo> MatchResultRewardList => null;

	public int LocalPlayerKillCount => 0;

	public int LocalPlayerDeathCount => 0;

	public int LocalPlayerAssistCount => 0;

	public float LocalPlayerKDA => 0f;

	public int RemainingPlayerCountMax => 0;

	public int RemainingPlayerCount => 0;

	public PlayerDeadInfo PlayerDeadInfoData => null;

	public PlayerDeadInfo LocalPlayerDeadInfoData => null;

	public ulong LastMatchEndTimeStamp => 0uL;

	public MatchIncome LastMatchIncome => null;

	public MatchStats LastMatchStats => null;

	public tcp.HuntingGroundRecords LastHuntingGroundRecords => null;

	public HippoMatchStatsBrief LastHippoMatchStatsBrief => null;

	public tcp.HuntingGroundLikePVERecords LastHGLikePVERecords => null;

	public bool HasPendingMatchRequest
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool HasShownCarryNotice => false;

	public bool HasShownRideNotice => false;

	public bool HasShownCarryTriggerGuide => false;

	public bool HasClickWaitingPhaseThumbUp => false;

	public HashSet<BHGGAEEHJCO> LikedPlayerSet => null;

	public HashSet<ulong> ReportedPlayerSet => null;

	public HashSet<BHGGAEEHJCO> FriendlyInteractionPlayerSet => null;

	public Dictionary<ulong, HashSet<ulong>> Match2ReportedPlayer => null;

	public HashSet<BHGGAEEHJCO> RequestedPlayerSet => null;

	public int PVERemainingEnemyCount => 0;

	public int PVETurnCount => 0;

	public int PVEMaxTurnCount => 0;

	public int LocalPlayerPveEnemyKillCount => 0;

	public int MCSLocalTeamId => 0;

	public int CSTeamIdEyesOn => 0;

	public int CSWinTeamIdCurRound => 0;

	public int LocalODFaction => 0;

	public int LocalFactionID => 0;

	public bool IsLocalFactionInLeft => false;

	public int LocalPlayerArmsLevel => 0;

	public int OpponentPlayerArmsLevel => 0;

	public int UnlockItemIndex => 0;

	public int UnlockLevel => 0;

	public List<uint> AllLevelEquipList => null;

	public int OneLevelSetCount => 0;

	public List<byte> PlayerSelectedEquipIndexList => null;

	public List<uint> CommonEquipSetGroup => null;

	public bool HideArrowOnMinimap
	{
		get
		{
			return _003CHideArrowOnMinimap_003Ek__BackingField;
		}
		set
		{
			_003CHideArrowOnMinimap_003Ek__BackingField = value;
		}
	}

	public BHGGAEEHJCO DeathMatchKillerKing
	{
		get
		{
			return default(BHGGAEEHJCO);
		}
		set
		{
		}
	}

	private Dictionary<uint, uint> InGameFeedBackIdToPriorityId => null;

	public HashSet<BHGGAEEHJCO> SuperEmoteLikedPlayerSet => null;

	public string LonewolfTargetLockRegion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsSubTeammate(ulong otherId)
	{
		return false;
	}

	public long GetBlockTime(ulong accountId)
	{
		return 0L;
	}

	public void ParseQuickMatch()
	{
	}

	private void ParseStringToList(string src, List<uint> target)
	{
	}

	public int GetTutorialFakeThumbUpNumByRank(uint rank)
	{
		return 0;
	}

	public NewbiePresetDesc GetNewbiePresetListForNewbie()
	{
		return null;
	}

	public List<NewbiePresetDesc> GetNewbiePresetListForVeteran()
	{
		return null;
	}

	public bool NewbiePresetDataForVeteranIsValid()
	{
		return false;
	}

	public void SetLoadingPlayerInfo(List<MatchPregameInfo> list, DLBMPCCFKKM matchMode)
	{
	}

	public GroupTypeToPlayClanWar CheckCanPlayForClanWarAndTournament(bool showTip, uint matchMode)
	{
		return GroupTypeToPlayClanWar.False;
	}

	public GroupTypeToPlayClanWar CheckCanPlayInClanWar(bool showTips = false)
	{
		return GroupTypeToPlayClanWar.False;
	}

	public GroupTypeToPlayClanWar CheckCanPlayClanWarTournament(bool showTip = false)
	{
		return GroupTypeToPlayClanWar.False;
	}

	public List<MatchPregameInfo> GetListLoadingPlayerInfo()
	{
		return null;
	}

	public ELoadingBattleType GetLoadingBattleType()
	{
		return ELoadingBattleType.None;
	}

	public void updateLeaveGame(bool flag)
	{
	}

	public void UpdateMatchTime(int time)
	{
	}

	public void StartMatch()
	{
	}

	public void SetObserverTrackingItemStateSync(uint playerID, List<PPCMIEPMLNN> items)
	{
	}

	public void ApplyObserverTrackingItemStateUpdate(uint playerID, List<FBKEAPGNCKI> updates)
	{
	}

	public bool TryGetObserverTrackingItemState(out uint playerID, out List<PPCMIEPMLNN> items)
	{
		playerID = default(uint);
		items = null;
		return false;
	}

	public void ClearObserverTrackingItemState()
	{
	}

	private void ClearObserverTrackingItemStateSlots()
	{
	}

	private void ApplyObserverTrackingItemState(PPCMIEPMLNN item, bool removeWhenZero)
	{
	}

	private ObserverTrackingItemStateSlotCache GetObserverTrackingItemStateSlot(int slotIdx)
	{
		return null;
	}

	private PPCMIEPMLNN CloneObserverTrackingItemState(PPCMIEPMLNN item)
	{
		return null;
	}

	private PPCMIEPMLNN CloneObserverTrackingItemState(PPCMIEPMLNN item, float elapsedSec)
	{
		return null;
	}

	public void OnApplicationPause(bool paused)
	{
	}

	public void ClearEPRankingList()
	{
	}

	public void AddKnockDownInfo(string playerName, int weaponDataID, uint skinID, BHGGAEEHJCO beKilledId, BHGGAEEHJCO killerId, bool isHeadShot = false, uint knockDownPlayerRole = 0u)
	{
	}

	public void OnKnockOtherDown(ESPKillOperateNoti operate = ESPKillOperateNoti.NONE, bool isCounterAttack = false, uint killerID = 0u, uint gainCoins = 0u, int KnockedDownCount = 0, uint SkinID = 0u, bool isHeadShot = false)
	{
	}

	public void AddInstantKilledInfo(string playerName, BHGGAEEHJCO playerID)
	{
	}

	public void SyncInstantKilledInfo(List<uint> playerIDs, List<string> playerNames)
	{
	}

	public void AddBattleInfo(string battleInfo)
	{
	}

	public void AddRedEnvelopeInfo(string battleInfo)
	{
	}

	public void UpdateKillInfo(BHGGAEEHJCO killerID, int killCount)
	{
	}

	public void UpdateLikeCountInfo(BHGGAEEHJCO playerID, byte likeCount)
	{
	}

	public void UpdateDeathInfo(BHGGAEEHJCO playerId, int deathCount)
	{
	}

	public void UpdateBombInfo(EBHODPNCAGN infoType, object[] param)
	{
	}

	public void OnLandmineExplode(Player landmineOwner)
	{
	}

	private void CheckShowTutorial()
	{
	}

	public void OnRevived(BHGGAEEHJCO killId, BHGGAEEHJCO beKillId)
	{
	}

	public void OnKill(BHGGAEEHJCO killerID, BHGGAEEHJCO beKilledID, int weaponDataID, uint hitbodyPart, uint skinId, bool isPendingRevive = false, int killStacks = 0, byte flags = 0, int killerScore = 0, int killerTeamScore = 0, int killerHypeLvl = 0, uint assis = 0u, uint hitRate = 0u, uint headShotRate = 0u, uint bekilledKillStack = 0u, uint scannerMarkExtraCoin = 0u, bool isAceTeam = false, int knockDownNum = 0, bool isLastKill = false, bool isCounterAttack = false, byte kingKillType = 0, uint loadoutReinforceToken = 0u)
	{
	}

	private void ShowLeaderboardTitleTeamAcer(BHGGAEEHJCO killerID, BHGGAEEHJCO beKilledID)
	{
	}

	public ESPKillOperateNoti GetOperateWhenKill(uint weaponid, BHGGAEEHJCO bekilled)
	{
		return ESPKillOperateNoti.NONE;
	}

	public bool NeedReplaceNameWithEllipsis(Player player)
	{
		return false;
	}

	public void OnKillByZombie(BHGGAEEHJCO killerID, BHGGAEEHJCO beKilledID, int weaponDataID, uint hitbodyPart, uint skinId)
	{
	}

	public ulong GetPlayerAceStartTime(BHGGAEEHJCO playerid)
	{
		return 0uL;
	}

	public string GetWeaponName(int weaponDataID)
	{
		return null;
	}

	public void OnPlayerQuit(BHGGAEEHJCO playerID)
	{
	}

	public void OnAlivePlayerCountChanged(int remainingPlayers)
	{
	}

	public void OnAddPlayer(BHGGAEEHJCO playerID, Player player)
	{
	}

	private void SaveTeammateInfo(PlayerData playerData)
	{
	}

	private void SaveTeammateInfoForRecommand(PlayerData playerData)
	{
	}

	public void SaveMatchTeammateInfoForRecommand()
	{
	}

	private PlayerData CreatePlayerData(Player player)
	{
		return null;
	}

	public void UpdateSocialLobbyPlayerData(Player player)
	{
	}

	private PlayerData GetTeammateData(BHGGAEEHJCO pid)
	{
		return null;
	}

	public void OnTeammateHeadScaleChange(BHGGAEEHJCO pid, float scale)
	{
	}

	public void OnTeammateEpicClothesUpdate(BHGGAEEHJCO pid, uint oldClohtes, uint newClothes)
	{
	}

	public void OnTeammateHeadAvatarChange(BHGGAEEHJCO pid, uint avatardataID)
	{
	}

	private void RefreshEPRankingSurroundEffect()
	{
	}

	public void UpdateEPRankingList(ulong userID, BHGGAEEHJCO pID, bool isAI, object syncInfo)
	{
	}

	public EPPlayerInfo FindElitePassRankingInfoByUserID(ulong userID)
	{
		return null;
	}

	public void OnSwitchObserver(BHGGAEEHJCO trackingTargetID)
	{
	}

	public void OnDelPlayer(BHGGAEEHJCO playerID)
	{
	}

	public void OnRemoveTeam(byte teamID)
	{
	}

	public void SniperOn(bool v)
	{
	}

	public void RecordPlayerForDriftBottle()
	{
	}

	public void RequestDebugQuickMatch(int botNum)
	{
	}

	public void RequestInviteToSocial(ulong inviteeId, uint gameMode)
	{
	}

	public void AcceptInviteToSocial(InviteSocialNtf inviteSocialNtf)
	{
	}

	private void AcceptInviteToSocial_CallBack(InviteSocialNtf inviteSocialNtf, bool isCancelReady)
	{
	}

	private IEnumerator WaitGroupInfoNotReady_Accept(InviteSocialNtf inviteSocialNtf, bool isCancelReady)
	{
		return null;
	}

	public void StopWaitGroupInfoNotReadyCoroutine()
	{
	}

	public void RefuseInviteToSocial(InviteSocialNtf inviteSocialNtf)
	{
	}

	public void RequestJoinSocialArea(ulong targetPlayerId, uint gameMode)
	{
	}

	private void RequestJoinSocialArea_CallBack(ulong targetPlayerId, uint gameMode, bool isCancelReady)
	{
	}

	private IEnumerator WaitGroupInfoNotReady_Request(ulong targetPlayerId, uint gameMode, bool isCancelReady)
	{
		return null;
	}

	public void RequestNewbieGuideDescRes(uint httpOp = 0u, LoadingType loadingType = LoadingType.CircleLoading, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main, bool force = false, HttpManager.Priority priority = HttpManager.Priority.Normal)
	{
	}

	public void RequestPresetGuideAvatar()
	{
	}

	private proto.EFresh.PresetType GetPresetType()
	{
		return proto.EFresh.PresetType.PresetType_None;
	}

	private bool TryRequestPresetGuideAvatar()
	{
		return false;
	}

	public void RequestStartMatchMaking(uint map_id, NIKKALKPIBO game_mode = NIKKALKPIBO.EGAMEMODE_BattleRoyale, DLBMPCCFKKM match_mode = DLBMPCCFKKM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false, bool isFirstGuideMatch = false, ulong groupId = 0uL)
	{
	}

	public void RequestStartMatchMaking(List<uint> map_ids, NIKKALKPIBO game_mode = NIKKALKPIBO.EGAMEMODE_BattleRoyale, DLBMPCCFKKM match_mode = DLBMPCCFKKM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false, bool isFirstGuideMatch = false, ulong groupId = 0uL)
	{
	}

	private bool RequestStartMatchMakingInternal(List<uint> map_ids, NIKKALKPIBO game_mode = NIKKALKPIBO.EGAMEMODE_BattleRoyale, DLBMPCCFKKM match_mode = DLBMPCCFKKM.EMATCHMODE_CASUAL, uint map_difficulty = 0u, bool isRandomMap = false, bool isFirstGuideMatch = false, ulong groupId = 0uL)
	{
		return false;
	}

	public void RequestStartMatchmakingSpectate(ulong accountID, uint matchMode, uint gameMode)
	{
	}

	public bool RequestStartMatchmakingSpectateInternal(ulong accountID, uint matchMode, uint gameMode)
	{
		return false;
	}

	public void CheckIfNeedRequestWorkshopInfo(uint match_mode, uint game_mode, Action callBack)
	{
	}

	public void RequestCancelMatchMaking()
	{
	}

	public void RequestDropMatch()
	{
	}

	public void RequestLobbySocialAreaDropMatch()
	{
	}

	public void RequestClearReconnectInfo()
	{
	}

	public void PendingMatchResult(MatchStatsRes data)
	{
	}

	public void ProcessMatchStatsBrief(MatchStatsBrief data)
	{
	}

	public void ProcessCSMatchStatsBrief(CSMatchStatsBrief data)
	{
	}

	public void UpdateLadderMatchPlayCnt(uint matchMode, uint cnt = 1u)
	{
	}

	private void InitRankUpData(DLBMPCCFKKM matchMode, int rankAfterMatch)
	{
	}

	public void RequestMatchResultViaHTTP()
	{
	}

	public void RequestExternalIconInfos(List<ulong> accountIds)
	{
	}

	public void RequestBRExternalIconInfosInGame()
	{
	}

	public void RequestCSExternalIconInfosInGame()
	{
	}

	public proto.ExternalIconInfo FindExternalIconInfos(ulong accountId)
	{
		return null;
	}

	private bool CanShowPlatformHeadpic()
	{
		return false;
	}

	public void RequestMatchSurvey()
	{
	}

	public void ProcessMatchBlackListParam(CSGetAllFriendDescRes desc)
	{
	}

	public void RequestMatchBlackList(ulong accountId = 0uL, bool onlyNeedBlackListCount = false, bool forceRequest = false, bool fromClickBlock = false)
	{
	}

	public bool IsPlayerInBlackList(ulong accountId)
	{
		return false;
	}

	public int GetCurMatchBlackListCount()
	{
		return 0;
	}

	private void ProcessExpireMatchBlackList()
	{
	}

	private void ProcessRemoveMatchBlackList(ulong[] removeBlacklistIds)
	{
	}

	public void RequestAddMatchBlackListPlayer(ulong blacklistId, uint gameMode, uint matchMode, ulong matchID)
	{
	}

	public void RequestRemoveMatchBlackListPlayer(ulong[] blacklistIds)
	{
	}

	public bool IsOpenMatchBlackList()
	{
		return false;
	}

	public void ProcessMatchFeedbackDesc(List<GameplayFeedbackDesc> desc)
	{
	}

	public bool IsRankUp()
	{
		return false;
	}

	public void ClearRankUpData()
	{
	}

	public void GetRankUpData(out int preRank, out int curRank, out DLBMPCCFKKM matchMode)
	{
		preRank = default(int);
		curRank = default(int);
		matchMode = default(DLBMPCCFKKM);
	}

	public void InitRankUpData(int preRank, int curRank, DLBMPCCFKKM matchMode)
	{
	}

	public bool HasPendingReviveTeammates()
	{
		return false;
	}

	public bool HasGulagBattleTeammates()
	{
		return false;
	}

	public List<Player> OnFloatingLandTeammatesCount()
	{
		return null;
	}

	public bool UnpackMatchResult(bool force = true)
	{
		return false;
	}

	private static void TrySaveBRLastMatchStats(MatchStats stats)
	{
	}

	private static void TrySaveBRLastMatchStatsFromBrief(MatchStatsBrief brief)
	{
	}

	public static void GetBRLastMatchStats(uint gameMode, uint matchMode, out int kills, out int rank, out int reviveTeammateCount)
	{
		kills = default(int);
		rank = default(int);
		reviveTeammateCount = default(int);
	}

	public List<uint> FindAvatarAwakenInMatchStateData()
	{
		return null;
	}

	public bool HasPendingMatchResult()
	{
		return false;
	}

	private void EnsureCarryNoticeLoaded()
	{
	}

	public void MarkCarryNoticeShown()
	{
	}

	public void MarkRideNoticeShown()
	{
	}

	public void MarkCarryTriggerGuideShown()
	{
	}

	public bool HasUsedCarryBattleFireBtn(ulong userId)
	{
		return false;
	}

	public void MarkCarryBattleFireBtnUsed(ulong userId)
	{
	}

	private void ClearCarryNoticeCache()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public bool CheckReportByMatchID(ulong matchID, ulong userID)
	{
		return false;
	}

	public void AddReportRecordByMatchID(ulong matchID, ulong userID)
	{
	}

	public bool CanUseQuickChat(bool soloCanChat = false)
	{
		return false;
	}

	public bool CanUseTextChat()
	{
		return false;
	}

	public bool CanUseVoiceToText()
	{
		return false;
	}

	public Player GetNearestEmoteLeader(uint emoteID, Vector3 pos)
	{
		return null;
	}

	public bool IsEmoteLeader(BHGGAEEHJCO pid)
	{
		return false;
	}

	public void SetEmoteLeader(BHGGAEEHJCO pid)
	{
	}

	public void RemoveEmoteLeader(BHGGAEEHJCO pid, bool isStopEmotion = true)
	{
	}

	public void FollowEmoteLeader(BHGGAEEHJCO leaderPid)
	{
	}

	public void UnFollowEmoteLeader()
	{
	}

	public BHGGAEEHJCO GetFollowEmotePlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public void UpdateLeadEmoteSimTick(uint simTick)
	{
	}

	public uint GetLeadEmoteSimTick()
	{
		return 0u;
	}

	public void UpdateFollowerEmote(BHGGAEEHJCO leaderPid, uint emoteID)
	{
	}

	public void GenerateMatchResult(AEOFDLOIGCP msg)
	{
	}

	public PlayerData GetTutorialPlayerDataByPlayerID(ulong playerId)
	{
		return null;
	}

	public PlayerData GetPlayerDataByAccountID(ulong accountID)
	{
		return null;
	}

	public PlayerData GetPlayerDataByPlayerID(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public PlayerData GetPlayerDataByNickName(string nickName)
	{
		return null;
	}

	public void SetTeamScore(int idx, int score)
	{
	}

	public void UpdateTeamScore(int score)
	{
	}

	public void CacheUserPlatform(ulong user_id, byte platform)
	{
	}

	public byte GetUserPlatform(ulong user_id)
	{
		return 0;
	}

	public void CacheUserClientVersion(ulong user_id, string client_version)
	{
	}

	public string GetUserClientVersion(ulong user_id)
	{
		return null;
	}

	public void CacheUserClientType(ulong user_id, uint client_type)
	{
	}

	public uint GetUserClientType(ulong user_id)
	{
		return 0u;
	}

	public List<ulong> GetAllUserPlayerIDs()
	{
		return null;
	}

	public List<ulong> GetSameTeamPlayerIds()
	{
		return null;
	}

	public void RequestLikePlayer(BHGGAEEHJCO id, ulong accountID)
	{
	}

	public void SendWaitingPhaseThumbUp(int index)
	{
	}

	public void SendEmojiToPlayer(BHGGAEEHJCO id, string resName, uint sendType)
	{
	}

	private BHGGAEEHJCO GetSourcePlayerID()
	{
		return default(BHGGAEEHJCO);
	}

	public void UpdatePVEEmemyKillCount(int count, BHGGAEEHJCO playerId)
	{
	}

	public bool IsCSPlayerOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	public bool IsCSTeamOnLeft(int teamId)
	{
		return false;
	}

	public void UpdateWinTeamIdCurRound(int teamId)
	{
	}

	public void UpdateLocalFactionID(int factionID)
	{
	}

	public void UpdateLocalODFaction(int factionID)
	{
	}

	public void SetClanMatchResult(FakeSubmitRes tcpClanMatchResult)
	{
	}

	public FakeSubmitRes GetClanMatchResult()
	{
		return null;
	}

	public bool IsFactionInLeft(int factionID)
	{
		return false;
	}

	public void UpdateLocalPlayerArmsLevel(int level)
	{
	}

	public void UpdateOpponentPlayerArmsLevel(int level)
	{
	}

	public void UpdateEquipUnlockInfo(int unlockItemIndex, int unlockLevel)
	{
	}

	public void UpdateAllLevelEquipListInfo(List<uint> list, int oneLevelSetCount)
	{
	}

	public void UpdatePlayerSelectedEquipIndexList(List<byte> list)
	{
	}

	public void UpdateEquipGroup(uint groupID)
	{
	}

	public void ClearCSSOData()
	{
	}

	public void RefreshCSSOLastRoundRankList(List<byte> list)
	{
	}

	public void RefreshCSSORankList(List<byte> list)
	{
	}

	public void RefreshCSSOLastRoundTeamsHPList()
	{
	}

	public void RefreshCSSOTeamsHPList(List<byte> list)
	{
	}

	public List<byte> GetCSSORankList()
	{
		return null;
	}

	public List<byte> GetCSSOLastRoundRankList()
	{
		return null;
	}

	public int GetRankByTeamID(byte teamID)
	{
		return 0;
	}

	public int GetLastRankByTeamID(byte teamID)
	{
		return 0;
	}

	public byte GetTeamHPByTeamID(byte teamID)
	{
		return 0;
	}

	public byte GetLastRoundTeamHPByTeamID(byte teamID)
	{
		return 0;
	}

	public byte GetOppoTeamID(BHGGAEEHJCO playerID)
	{
		return 0;
	}

	public void SetCSSOTeamIndex(byte teamID, int teamIndex)
	{
	}

	public void ClearCSSOPlayerZoneIndex()
	{
	}

	public bool IsCSSOSameZone(Player p)
	{
		return false;
	}

	public bool IsCSSOSameZone(BHGGAEEHJCO p)
	{
		return false;
	}

	public void SetCSSOPlayerZoneIndex(BHGGAEEHJCO playerID, uint zoneIndex)
	{
	}

	public void SetZoneIndexSpecial(uint zoneIndex, bool special)
	{
	}

	public bool IsZoneIndexSpecial(uint zoneIndex)
	{
		return false;
	}

	public int GetCSSOTeamIndex(byte teamID)
	{
		return 0;
	}

	public uint GetCSSOPlayerZoneIndex(BHGGAEEHJCO playerID)
	{
		return 0u;
	}

	public void ResetPlayerIds(BHGGAEEHJCO playerID)
	{
	}

	public string GetCSSOTeamName(byte teamID)
	{
		return null;
	}

	public uint GetCSSOTeamColor(byte teamID)
	{
		return 0u;
	}

	public uint GetCSSOTeamNameColor(byte teamID)
	{
		return 0u;
	}

	public string GetCSSOBBCodeTeamColor(byte teamID)
	{
		return null;
	}

	public void SetRoundBattleResults(List<HFOFHBHFBBB> battleResult)
	{
	}

	public bool GetBattleResultByTeamID(byte teamID)
	{
		return false;
	}

	public void ClearCSSOBattleResult()
	{
	}

	public void SetCSSOPlayerKillInfos(MDCCOHELBAN msg)
	{
	}

	public HKKMLEMBAGG GetCSSOPlayerKillInfo(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public void SetCSSOTeamEliminateInfo(DOIHJJICDNE msg)
	{
	}

	public byte GetCSSOTeamEliminateRound(byte teamID)
	{
		return 0;
	}

	public bool IsCSSOTeamEliminate(byte teamID)
	{
		return false;
	}

	public string GetCSSORankString(byte teamID)
	{
		return null;
	}

	public int GetCSSOAliveTeamCnt()
	{
		return 0;
	}

	public void RecordTDShowOverEffectTime(HCBGDFOPAIJ type, float time)
	{
	}

	public float GetTDShowOverEffectTime(HCBGDFOPAIJ type)
	{
		return 0f;
	}

	public void RemoveTDShowOverEffectTime(HCBGDFOPAIJ type)
	{
	}

	public void ClearAskPurchaseInfo()
	{
	}

	public void OnOtherAskPurchase(IAIODMAFJJA res)
	{
	}

	public void OnPlayerPurchaseForOther(PNCEHCIKIPK res)
	{
	}

	public void AskCSPurchase(List<uint> itemids)
	{
	}

	public void CancelAskCSPurchase()
	{
	}

	public bool HasLocalPendingAskPurchase()
	{
		return false;
	}

	public bool TryGetLocalPendingAskItems(out List<uint> items)
	{
		items = null;
		return false;
	}

	public bool PayForOther(BHGGAEEHJCO sender)
	{
		return false;
	}

	private void ClearLWSOData()
	{
	}

	public List<MFNHNEDOGKH> GetLWSOTeamInfoList()
	{
		return null;
	}

	public void SetLWSOPlayerKillInfo(LHKGMIMDKFL msg)
	{
	}

	public EEGMNEFLNHP GetLWSOPlayerKillInfo(BHGGAEEHJCO playerID)
	{
		return null;
	}

	public void RefreshLWSOTeamInfo(List<MFNHNEDOGKH> teamInfos)
	{
	}

	public MFNHNEDOGKH GetLWSOTeamInfoByTeamID(byte teamID)
	{
		return null;
	}

	public void RefreshLWSOTeamLastRoundResult(List<NEIGFOOHAII> results)
	{
	}

	public void ClearLWSOTeamLastRoundResult()
	{
	}

	public BLMNAEJBDLA GetLWSOTeamLastRoundResult(byte teamID)
	{
		return BLMNAEJBDLA.LWSOLastRoundResult_Bye;
	}

	public MFNHNEDOGKH GetLWSOEnemyTeamInfo(byte teamID)
	{
		return null;
	}

	public bool LWSOTeamIsEliminate(byte teamID)
	{
		return false;
	}

	public bool LWSOTeamIsEliminate(MFNHNEDOGKH teamInfo)
	{
		return false;
	}

	public bool LWSOTeamIsLastRoundEliminate(MFNHNEDOGKH teamInfo)
	{
		return false;
	}

	public string GetLWSOTeamRankString(byte rank)
	{
		return null;
	}

	public bool IsLWSOSameFightZone(Player p)
	{
		return false;
	}

	public bool IsLWSOSameFightZone(BHGGAEEHJCO pID)
	{
		return false;
	}

	public byte GetLWSOPlayerFightZoneIndex(BHGGAEEHJCO playerID)
	{
		return 0;
	}

	public bool IsDeathMatchKillerKing(BHGGAEEHJCO playerID)
	{
		return false;
	}

	public bool IsShowMatchResultRewardWnd()
	{
		return false;
	}

	public uint GetBuffValueAndRemainTime(out float value, out float nextValue)
	{
		value = default(float);
		nextValue = default(float);
		return 0u;
	}

	public bool IsShowResultBuffValue()
	{
		return false;
	}

	public void GetGameBufValue(out uint gainToday, out uint gainTodayLimit)
	{
		gainToday = default(uint);
		gainTodayLimit = default(uint);
	}

	public bool HasTeamUPGameBuf()
	{
		return false;
	}

	public void OnKillerUpdate(MKNILMIIKDB msg)
	{
	}

	public void OnKnockDownerUpdate(BMEACFODNOH msg)
	{
	}

	public List<CandidateReporteeData> GetCandiateReportees()
	{
		return null;
	}

	public bool HasAnyCandidateReporteeBeforeFilter()
	{
		return false;
	}

	private List<CandidateReporteeData> GetTeamCandidateReporteeList()
	{
		return null;
	}

	public void SetSKillCDMatchSetting(DLGJOMMMGPI generalData)
	{
	}

	public void SetFootballTeammateSkillChoose(BHGGAEEHJCO playerID, uint id)
	{
	}

	public int GetFootballTeammateSkillChooseCount(uint id)
	{
		return 0;
	}

	public InGameLeaderBoardTitleInfo GetBetterTitleInfoByAccountID(ulong uid)
	{
		return null;
	}

	public bool IsShowGroupMedals()
	{
		return false;
	}

	public bool IsKilledBySystem(BHGGAEEHJCO id)
	{
		return false;
	}

	public int GetTeamIndexByAccountID(ulong accountID)
	{
		return 0;
	}

	public void ClearAccountIDToTeamIndex()
	{
	}

	public void ClearRecommendCriticalInfo()
	{
	}

	public void ClearCacheRecommendNtf()
	{
	}

	public Dictionary<byte, List<BHGGAEEHJCO>> GetAllTeamPlayerIDs()
	{
		return null;
	}

	public List<BHGGAEEHJCO> GetPlayerIDsByTeamId(byte teamId)
	{
		return null;
	}

	public void OnAvatarProficiencyChange(BatchProficiencyChangeNtf res)
	{
	}

	public bool IsAvatarProficiencyChange()
	{
		return false;
	}

	public void ClearStoreMatchMakingTime()
	{
	}

	public void ClearReshowModeType()
	{
	}

	public void ClearRematchShowLabelState()
	{
	}

	public void OnStopMatchMaking()
	{
	}

	public void AddOverPingCount()
	{
	}

	public bool CanShowMapLegend()
	{
		return false;
	}

	public bool CheckPositionInMotionPlatformArea(Vector3 position)
	{
		return false;
	}

	public bool CheckPositionInMotionPlatformInternal(Vector3 position, List<Vector4> zones, string zoneConfig)
	{
		return false;
	}

	public bool CheckPositionInMotionPlatformForbiddenPersonalAirdropZones(Vector3 position)
	{
		return false;
	}

	public bool CheckPositionInMotionPlatformForbiddenDummyZones(Vector3 position)
	{
		return false;
	}

	public List<IngameFeedbackData> GetMatchResultBadgeInfo(TeammateStats stats)
	{
		return null;
	}

	public void RequestPersistentData()
	{
	}

	public void UpdatePersistentDataCurMatchPlayerKillCnt(BHGGAEEHJCO id, int cnt)
	{
	}

	public void UpdatePersistentDataCurMatchPlayerDeathCnt(BHGGAEEHJCO id, int cnt)
	{
	}

	public void HandleRecPersistentData(ECPAPCJBJNK msg)
	{
	}

	public List<UIHudRegionLeaderboardItemController.CurMatchPlayerInfo> GetSortedCurMatchPlayerList()
	{
		return null;
	}

	public List<UIHudRegionLeaderboardItemController.RegionRankPlayerInfo> GetSortedRegionRankPlayerList()
	{
		return null;
	}

	public bool IsNBEventOpen()
	{
		return false;
	}

	public bool IsRamadanEventOpen()
	{
		return false;
	}

	public List<MatchmakingTipsNewDesc> GetMatchMakingTipsWhenStartMatch(uint gameMode, uint matchMode, int teamMatesRankingGap)
	{
		return null;
	}

	public void ProcessMatchMakingTipsDataDict(List<MatchmakingTipsNewDesc> matchmakingTipsNewDescList)
	{
	}

	public uint GetRankingGapInGroup(uint matchMode)
	{
		return 0u;
	}

	public bool IsPlayerHasBadge(List<TeammateStats> teammates)
	{
		return false;
	}

	public string GetGameModeString(bool isShowInFrontEndScene, uint matchMode, uint gameMode, uint specialModeEventId = 0u)
	{
		return null;
	}

	public void RequestAvatarSkillOverwrite(HttpManager.EHttpChannel channel)
	{
	}

	public bool NeedSetMVPPlayer(uint gameMode)
	{
		return false;
	}

	public void RecordAddFriendInGame(BHGGAEEHJCO playerId)
	{
	}

	public bool HasAddFriendInGame(BHGGAEEHJCO playerId)
	{
		return false;
	}

	public void ClearAddedFriendInGameList()
	{
	}

	public void RequestLikeSuperEmote(BHGGAEEHJCO playerID)
	{
	}

	public bool NeedToShowRatingBoard(MatchIncome income)
	{
		return false;
	}

	public ERatingLevel GetRatingLevel(float rating)
	{
		return ERatingLevel.None;
	}

	public void SetRatingUIFX(GameObject uiFxGold, GameObject uiFxSilvery, float rating, GameObject GoldMedal = null, GameObject SilverMedal = null)
	{
	}

	public void SetRatingMVPUIFX(GameObject uiFxMvpWin, GameObject uiFxMvpLose, float rating)
	{
	}

	public void SetRatingBgSprite(UISprite bg, float rating)
	{
	}

	public void SetRatingLabelColor(UILabel label, float rating, bool greyUseWhiteCol = false)
	{
	}

	public void SetRatingLabelColorSpecial(UILabel GoldLabel, UILabel SilverLabel, UILabel NormalLabel, float rating)
	{
	}

	public float GetLocalPlayerOrObserverTargetBRRating()
	{
		return 0f;
	}

	public void OnGetTrainingBattleReviveShopConfig(List<IBPMKFFAEEG> list)
	{
	}

	public void ReqTrainingBattleReviveShopState(bool isStart)
	{
	}

	private void TryOpenTrainingMatchBattleReviveShop()
	{
	}

	private UIMatchMakingManager GetCurrentMatchMakingManager()
	{
		return null;
	}

	public bool TryRestoreMemberReady()
	{
		return false;
	}

	public bool TryCancelMemberReady()
	{
		return false;
	}

	public bool RunAfterCancelMemberReady(Action onReady, Action onFailed = null)
	{
		return false;
	}

	private IEnumerator WaitMemberNotReady(Action onReady, Action onFailed)
	{
		return null;
	}

	public void RequestGotoLobbySocialArea(Action onFailed, bool needBlock = true)
	{
	}

	private void RequestGotoLobbySocialAreaInternal(Action onFailed, bool needBlock)
	{
	}

	public void CreateBlockForMatch3DLobby()
	{
	}

	public void DestroyBlockForMatch3DLobby()
	{
	}

	public void ResetTrainingShopNewTagState()
	{
	}

	public void OnTrainingShopNewTagPreSync(uint shopId, List<IBPMKFFAEEG> itemList)
	{
	}

	public bool HasTrainingShopNewTag()
	{
		return false;
	}

	public bool IsTrainingShopNewTagItemUnread(uint itemId)
	{
		return false;
	}

	public void MarkTrainingShopNewTagItemsSeen(IEnumerable<uint> itemIds)
	{
	}

	private bool TryAddTrainingShopUnreadNewItem(uint itemId)
	{
		return false;
	}

	private void EnsureTrainingShopNewTagAccount()
	{
	}

	private string GetTrainingShopNewTagItemKey(uint itemId)
	{
		return null;
	}

	private void DispatchTrainingShopNewTagChange()
	{
	}

	public void ProcessReconnect(MatchmakingSussNtf resData, string serverAddr, int serverPort)
	{
	}

	private void _003CRequestNewbieGuideDescRes_003Eb__513_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestMatchResultViaHTTP_003Eb__532_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestExternalIconInfos_003Eb__533_0(HttpErrorCode errorCode, object obj)
	{
	}

	private void _003CRequestMatchSurvey_003Eb__538_0(HttpErrorCode errorCode, object obj)
	{
	}

	private int _003CGetMatchResultBadgeInfo_003Eb__845_0(IngameFeedbackData a, IngameFeedbackData b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
