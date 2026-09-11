using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;
using proto;
using tcp;

namespace COW;

internal class MobileReplayManager : SingletonModule<MobileReplayManager>
{
	public delegate void MessageConversionDelegate(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg);

	public class MessageConversionConfig
	{
		public uint SourceMessageID;

		public uint TargetMessageID;

		public Type SourceMessageType;

		public Type TargetMessageType;

		public MessageConversionDelegate ConversionFunction;

		public MessageConversionConfig(uint sourceID, uint targetID, Type sourceType, Type targetType, MessageConversionDelegate conversionFunc)
		{
		}
	}

	private class PhotoRequest
	{
		public uint matchEventID;

		public uint curRound;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MobileReplayInfo> _003C_003E9__146_0;

		public static Predicate<MobileReplayInfo> _003C_003E9__147_0;

		public static Predicate<MobileReplayInfo> _003C_003E9__148_0;

		public static Predicate<MobileReplayInfo> _003C_003E9__149_0;

		internal int _003CReadReplayList_003Eb__146_0(MobileReplayInfo x, MobileReplayInfo y)
		{
			return 0;
		}

		internal bool _003CGetAllReplayList_003Eb__147_0(MobileReplayInfo v)
		{
			return false;
		}

		internal bool _003CGetSavedReplayList_003Eb__148_0(MobileReplayInfo v)
		{
			return false;
		}

		internal bool _003CGetTempReplayList_003Eb__149_0(MobileReplayInfo v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass150_0
	{
		public ulong matchID;

		internal bool _003CGetReplayInfoByMatchID_003Eb__0(MobileReplayInfo v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass197_0
	{
		public uint group;

		public float point;

		internal bool _003CLogNormalReplayEvent_003Eb__0(MobileReplayEvent e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass230_0
	{
		public ReplayHighlightEvent highlightEvent;

		internal bool _003CSettingHighLightEventState_003Eb__0(ReplayHighlightEvent e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass231_0
	{
		public ReplayHighlightEvent highlightEvent;

		internal bool _003CGetHighLightEventSelectedState_003Eb__0(ReplayHighlightEvent e)
		{
			return false;
		}
	}

	private sealed class _003COnRenderPhotoDoneActionCor_003Ed__274 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MobileReplayManager _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnRenderPhotoDoneActionCor_003Ed__274(int _003C_003E1__state)
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

	private sealed class _003CTakeHighlightPhotoCor_003Ed__239 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public uint matchEventID;

		public MobileReplayManager _003C_003E4__this;

		public uint curRound;

		private HighlightInfo _003ChighlightInfo_003E5__2;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CTakeHighlightPhotoCor_003Ed__239(int _003C_003E1__state)
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

	private List<MessageConversionConfig> m_MessageConversionConfigs;

	private MemoryStream m_MemoryStream;

	private FastBinaryWriter m_BinaryWriter;

	private bool m_SkipUsingOptimized1PForSpecialTime;

	public const string REPLAY_SAVE_RESULT = "ResultSaveBtn";

	public const string REPLAY_EVENT_ICON = "EventIconBtn";

	public const string REPLAY_PLAY = "PlayBtn";

	public const string REPLAY_PAUSE = "PauseBtn";

	public const string REPLAY_RESET = "ResetBtn";

	public const string REPLAY_JUMP = "JumpBtn";

	public const string REPLAY_HIGHLIGHT = "HighlightBtn";

	public const string REPLAY_NORMAL = "NormalReplayBtn";

	public const string REPLAY_OVERLOOK = "OverlookBtn";

	public const string REPLAY_FOLLOW = "FollowLockBtn";

	public const string REPLAY_FILTER = "AchievementFilter";

	private static readonly string DATA_PATH;

	private const string REPLAY_DIRECTORY_NAME = "MReplays";

	private const int MS_TO_TICK = 10000;

	private const float S_TO_MS = 1000f;

	private const int JMUP_GAP_TIME_MS = 1000;

	private BinaryWriter m_ReplayBinaryWriter;

	private ReplayData m_ReplayData;

	private List<ReplayData> m_ReplayDataList;

	public List<ReplayData> m_RecycleReplayDataList;

	private MobileReplayInfo m_CurReplayInfo;

	private long m_GameTotalTimeMS;

	private EReplayState m_CurState;

	private EnterReplayMode _003CCurEnterReplayMode_003Ek__BackingField;

	private long m_StartTimeMS;

	private string m_MatchInfo;

	private Action m_ReplayJumpCallBack;

	private long m_ReplayTimeMS;

	private bool m_Started;

	private bool m_MatchEnded;

	private bool m_TriggerCheckSkipRejoinPackets;

	private bool m_TriggerCalSkipRealWorldTime;

	private bool m_DisableRecordPackets;

	private MobileReplayEndMode m_ReplayEndMode;

	private Queue<ReplayData> m_ReplayDataQueue;

	private List<MobileReplayInfo> m_ReplayInfos;

	private List<EventLogger.HightlightEventPlayInfoData> m_highlightEventPlayInfos;

	private bool m_IsHighlight;

	private bool m_IsingleHighlight;

	private bool m_IsRestartSingleHighlight;

	private bool m_NeedStartSkip;

	private bool m_HasSendAnimEvent;

	private const float DELAY_HIGHLIGHT_START = 1.5f;

	private EHighLightPlayType m_HighLightPlayType;

	private Dictionary<uint, uint> m_HighLightPlayTypePlayCnt;

	private Dictionary<uint, uint> m_HighLightPlayTypecompleteCnt;

	public EventLogger.EventTypeReplayPlayInfo PlayInfoLog;

	public HashSet<uint> PlayHighlights;

	public string EXIT_AUTO_SAVE_RECORD;

	private string KEY_FIRSTSHOW_SINGLEHIGHLIGHT;

	public ReplaySaveMatchData replaySaveMatchData;

	private CSVAsyncDataMap<uint, HighlightEventPriorityData> m_HighlightEventPriorityDatas;

	private AlbumPhotoInfo m_MultiKillHighlightPhoto;

	private AlbumPhotoInfo m_HeadShotHighlightPhoto;

	private RenderTexture m_MultiKillHighlightRT;

	private RenderTexture m_HeadShotHighlightRT;

	private uint m_HeadShotHighlightCount;

	private Dictionary<uint, Dictionary<uint, AlbumPhotoInfo>> m_RoundHighlightPhotos;

	private Dictionary<uint, Dictionary<uint, RenderTexture>> m_RoundHighlightRTs;

	public bool IsDuringSavingHighlightPhotos;

	private int m_SavingHighlightPhotosCount;

	private GameObject m_HighlightPhotoCamera;

	private Queue<PhotoRequest> m_PendingPhotoRequests;

	private bool m_IsTakingPhoto;

	private Camera[] m_HighlightPhotoRenderCameras;

	private bool _003CIsMenoryRecord_003Ek__BackingField;

	private bool[] mCurCancelHighLightEvent;

	private bool m_HasMatchEnd;

	private GameObject m_GameStartup;

	private MobileReplayAgain m_Script;

	private int m_ReplayCount;

	private const int FRAME_RATE_MS = 33;

	private bool m_HaveKillCamTriggered;

	private List<string> m_PreLoadCDNUrlList;

	private bool m_ReplayPaused;

	private int m_CurSpeed;

	private bool m_IsJumping;

	private long m_DestTimeMS;

	private Dictionary<int, float> m_LevelSpeedDic;

	private int m_HighlightEventIndex;

	private long m_LastHighlightTimeMS;

	private bool m_HasSaved;

	private bool m_HasEventLogSend;

	private List<uint> m_SmokeGrenadeVFXUniqueIDList;

	private static readonly List<Type> m_HighlightShowUIControllerTypes;

	private Dictionary<string, GameObject> m_CachedHideableControllers;

	private Dictionary<string, bool> m_ControllerLayerChanged;

	private Dictionary<string, bool> m_DynamicallyAddedPanels;

	private static readonly List<Type> m_PanelDepthOrder;

	private const string KEY_HIGHLIGHT_UNREAD_TRIGGERED = "HIGHLIGHT_UNREAD_TRIGGERED_{0}";

	private const string KEY_HIGHLIGHT_UNREAD_DISMISSED = "HIGHLIGHT_UNREAD_DISMISSED_{0}";

	private const int HIGHLIGHT_DAILY_RESET_HOUR = 4;

	private bool m_HighlightUnreadTriggered;

	private bool m_HighlightUnreadDismissed;

	private ulong m_PendingSelectReplayMatchID;

	private const int MAX_HIGHLIGHT_ASSIST_COUNT = 10;

	private const int HIGHLIGHT_ASSIST_REPEAT_COUNT_FOR_TEST = 3;

	private int m_LastRecordedPingValue;

	private Queue<MobileReplayPingSample> m_ReplayPingQueue;

	private int m_CurrentReplayPingValue;

	private bool m_ReplayHasPingData;

	private Dictionary<int, FOKBHOEDEMJ> mdicMobileReplaySpeeds;

	private int replaySpeedKey;

	private float mfReplaySpeed;

	public EnterReplayMode CurEnterReplayMode
	{
		get
		{
			return _003CCurEnterReplayMode_003Ek__BackingField;
		}
		private set
		{
			_003CCurEnterReplayMode_003Ek__BackingField = value;
		}
	}

	public bool IsMenoryRecord
	{
		get
		{
			return _003CIsMenoryRecord_003Ek__BackingField;
		}
		private set
		{
			_003CIsMenoryRecord_003Ek__BackingField = value;
		}
	}

	public bool IsJumping => false;

	public ulong PendingSelectReplayMatchID
	{
		get
		{
			return 0uL;
		}
		set
		{
		}
	}

	private void InitializeMessageConversions()
	{
	}

	private void RegisterMessageConversion(uint sourceID, uint targetID, Type sourceType, Type targetType, MessageConversionDelegate conversionFunc)
	{
	}

	private MessageConversionConfig FindConversionConfig(uint messageID, UDPClientMessageBase msg)
	{
		return null;
	}

	private void ConvertPlayerStateRequestToResponse(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg)
	{
	}

	private void ConvertStartFireRequestToResponse(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg)
	{
	}

	private void ConvertStopFireRequestToResponse(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg)
	{
	}

	private void ConvertStartSniperRequestToResponse(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg)
	{
	}

	private void ConvertStopSniperRequestToResponse(UDPClientMessageBase sourceMsg, UDPClientMessageBase targetMsg)
	{
	}

	private void EnsureResources()
	{
	}

	public void ConvertClientMsgToGsMsg(uint messageID, UDPClientMessageBase msg, byte sendOption)
	{
	}

	private UDPMsgPacket ConvertResponseToUDPPacket(UDPClientMessageBase response, uint messageID, byte sendOption)
	{
		return null;
	}

	private bool NeedConvert(uint message)
	{
		return false;
	}

	public bool ReplayUsingOptimized1P()
	{
		return false;
	}

	public void SetSkipUsingOptimized1PForSpecialTime(bool value)
	{
	}

	public static string GetReplayDirectoryPath()
	{
		return null;
	}

	public void ResetEnterMode()
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public ulong ReplayAuthorID()
	{
		return 0uL;
	}

	public void OnStarted()
	{
	}

	public void OnEnded()
	{
	}

	private string GetFilePath(string suffix)
	{
		return null;
	}

	public static string GetFilePath(string strMatchDateTime, string suffix)
	{
		return null;
	}

	private bool EnableMemoryRecord()
	{
		return false;
	}

	private void SetReplayInfo()
	{
	}

	private void OnRecordStarted()
	{
	}

	public void OnMatchEnd()
	{
	}

	public void OnRecordEnded()
	{
	}

	private void AutoSaveReplayToFile()
	{
	}

	private void TryCleanReplayInfoAndReplayWriter(bool cleanReplayInfo)
	{
	}

	public void ForceSaveReplayToFileOnApplicationQuit()
	{
	}

	public void RecordPacket(UDPMsgPacket p)
	{
	}

	private void SerializeRecordDatas()
	{
	}

	public float CurTimeSec()
	{
		return 0f;
	}

	private long GetNowTimeMS()
	{
		return 0L;
	}

	public void OnLocalShowMatchEnd()
	{
	}

	private EMobileReplayErrorCode CheckCanSaveReplay()
	{
		return EMobileReplayErrorCode.NONE;
	}

	private void SaveReplay()
	{
	}

	public EMobileReplayErrorCode ManualSaveReplay()
	{
		return EMobileReplayErrorCode.NONE;
	}

	public void ChangeToSaved(MobileReplayInfo info, EChangeToSaveChannel channel)
	{
	}

	public void SaveReplayInfos(List<MobileReplayInfo> infos)
	{
	}

	private void GetTempReplaySpace()
	{
	}

	private void CheckAndSendEventLog(bool success)
	{
	}

	private void CheckAndSendHighlightEventLog()
	{
	}

	private void SendChangeToSaveEventLog(MobileReplayInfo info, EChangeToSaveChannel channel)
	{
	}

	private void SendReplayEndEventLog()
	{
	}

	public void SetHighlightType(EHighLightPlayType type)
	{
	}

	public EHighLightPlayType GetCurHighlightType()
	{
		return EHighLightPlayType.None;
	}

	public void UpdatePlayHighlights()
	{
	}

	private float GetEventsTotalTime(List<ReplayHighlightEvent> events)
	{
		return 0f;
	}

	private void OnReplayStarted()
	{
	}

	private void OnReplayEnded()
	{
	}

	public void OnReplayMatchEnd()
	{
	}

	public void GetReplayPackets(List<UDPMsgPacket> outPackets)
	{
	}

	private void OnGetReplayPackets(List<UDPMsgPacket> outPackets)
	{
	}

	private bool ShouldKeepReplayData(ReplayData replayData)
	{
		return false;
	}

	private void OnReplayEnd()
	{
	}

	public ulong GetReplayMatchID()
	{
		return 0uL;
	}

	public bool GetReplayIsEmulatorPool()
	{
		return false;
	}

	public long GetReplayMemory()
	{
		return 0L;
	}

	private void ReadReplayList()
	{
	}

	public List<MobileReplayInfo> GetAllReplayList()
	{
		return null;
	}

	public List<MobileReplayInfo> GetSavedReplayList()
	{
		return null;
	}

	public List<MobileReplayInfo> GetTempReplayList()
	{
		return null;
	}

	public MobileReplayInfo GetReplayInfoByMatchID(ulong matchID)
	{
		return null;
	}

	public void DelReplay(MobileReplayInfo info, bool needRefresh = true)
	{
	}

	private void CleanupTemporaryReplay()
	{
	}

	public void CheckAndDeleteOutOfDateReplays()
	{
	}

	public void StartReplay()
	{
	}

	public void ResetReplay()
	{
	}

	public bool StartReplay(MobileReplayInfo info, EnterReplayMode enterMode = EnterReplayMode.None, bool isHighlight = false, bool needReset = true, bool resetHighLightSelect = true, bool isSingleHighlight = false, bool isRestartSingleHighlight = false, EReplayPlayChannel playChannel = EReplayPlayChannel.None)
	{
		return false;
	}

	public void PreLoadHighlightCDNAd()
	{
	}

	public void PauseReplay(bool pause)
	{
	}

	public void SetPlaySpeed(bool fast)
	{
	}

	public void StartHighlight()
	{
	}

	public void PlaySingleHighlight(ulong matchid = 0uL, EReplayPlayChannel channel = EReplayPlayChannel.None, EnterReplayMode enterMode = EnterReplayMode.History)
	{
	}

	public void MatchEndPlaySingleHighlight()
	{
	}

	public void ReStartSingleHighlight()
	{
	}

	public void GoToTimePoint(float value, Action callback = null, bool isHighlight = false, bool isSingleHighlight = false, bool isRestartSingleHighlight = false, EReplayPlayChannel playChannel = EReplayPlayChannel.None)
	{
	}

	public int GetHighlightEventIndex()
	{
		return 0;
	}

	public void NextHighlight()
	{
	}

	private void GetHighLightIndex(ref int index)
	{
	}

	public bool isLastHighLight(int index)
	{
		return false;
	}

	public long CurrentGameTimeMS()
	{
		return 0L;
	}

	public float CurrentGameTimeS()
	{
		return 0f;
	}

	public long GetTotalGameTime()
	{
		return 0L;
	}

	public float CurrentProgress()
	{
		return 0f;
	}

	public long GetGameTimeMS(float value)
	{
		return 0L;
	}

	public float GetTimeRatio(float time)
	{
		return 0f;
	}

	public MobileReplayInfo GetCurReplayInfo()
	{
		return null;
	}

	public bool IsHighlight()
	{
		return false;
	}

	public bool IsSingleHighlight()
	{
		return false;
	}

	public bool IsRestartSingleHighlight()
	{
		return false;
	}

	public int GetCurReplayOrHighlightTotalTime()
	{
		return 0;
	}

	public void SetState(EReplayState state)
	{
	}

	public bool IsRecordState()
	{
		return false;
	}

	public bool IsReplayState()
	{
		return false;
	}

	public void LogReplayEvent(uint iEventID, uint serial, uint group, uint time, int weaponDataID, List<string> args, List<uint> del_serial, List<JLHEBAFCAHO> correctionInfos, uint curRound, Vector3 beKilledPlayerPos)
	{
	}

	private void LogHighLightPlayCnt(bool isComplete, uint highLightType)
	{
	}

	private void LogNormalReplayEvent(MobileReplayInfo replayInfo, uint iEventID, uint group, float point)
	{
	}

	private float CheckDeadHappenInEvent(float startTime, float endTime, uint curRound, float eventTriggerPoint)
	{
		return 0f;
	}

	public void LogMatchResultData(MatchStats stats, MatchIncome income)
	{
	}

	public void LogKillData(uint kills)
	{
	}

	public void LogRankData(int rank)
	{
	}

	public void LogTeamCountData(int teamCount)
	{
	}

	public void LogMatchResultByBriefData(MatchStatsBrief briefData)
	{
	}

	public List<MobileReplayEvent> GetReplayEventList()
	{
		return null;
	}

	public void LogReplaySafeZoneEvent(byte StageID, uint StartTime)
	{
	}

	public void LogReplayFeedback(BHGGAEEHJCO playerID, byte id)
	{
	}

	public void LogReplayRoundEvent()
	{
	}

	public void LogReplayCabinWaitingEnd()
	{
	}

	public string[] GetCurrentReplayAchievementArgs(uint serial)
	{
		return null;
	}

	public void GenerateReplayEvent(MobileReplayInfo replayInfo)
	{
	}

	public bool IsReplayShowBooyah()
	{
		return false;
	}

	private static int SortReplayEvent(MobileReplayEvent left, MobileReplayEvent right)
	{
		return 0;
	}

	private static int SortReplayKillEvent(ReplayKillEvent left, ReplayKillEvent right)
	{
		return 0;
	}

	public bool IsReplaySaveAfterPlay()
	{
		return false;
	}

	public bool IsMobileReplayDeviceEnabled()
	{
		return false;
	}

	private bool IsMobileReplayInGameEnabled()
	{
		return false;
	}

	public bool IsRealMobileReplayEnabled()
	{
		return false;
	}

	private bool HaveEnoughStorage()
	{
		return false;
	}

	private bool CheckAndCreateDirectory()
	{
		return false;
	}

	public bool HasReplayHighLight(MobileReplayInfo mobileReplayInfo)
	{
		return false;
	}

	public bool HasReplayHighLight()
	{
		return false;
	}

	public MobileReplayInfo GetHighlightTipsReplayInfo(ulong historyRecordMatchId = 0uL)
	{
		return null;
	}

	public bool CanShowHighLightTipsInResult(ulong historyRecordMatchId = 0uL)
	{
		return false;
	}

	public string GetHighlightShowAchievementIcon(EHighLightPlayType highlightType)
	{
		return null;
	}

	public void SaveAnotherMatchDataWhenStartReplay(uint ret, MatchmakingSussNtf resData, string outAddr, int outPort)
	{
	}

	public bool IsOverLookMode()
	{
		return false;
	}

	public EHighlightMemoryLevel GetHightLightMemoryLevel()
	{
		return EHighlightMemoryLevel.LOW;
	}

	public bool IsHightlightStartDelayLong()
	{
		return false;
	}

	public float GetHightlightStartDelayTime()
	{
		return 0f;
	}

	public bool SettingHighLightEventState(ReplayHighlightEvent highlightEvent)
	{
		return false;
	}

	public bool GetHighLightEventSelectedState(ReplayHighlightEvent highlightEvent)
	{
		return false;
	}

	public void AddSmokeGrenadeVFXUniqueID(uint uniqueID)
	{
	}

	public void ClearSmokeGrenadeVFX()
	{
	}

	private void OnReplayJumpFinished()
	{
	}

	public void TriggerCheckSkipRejoinPackets(bool enable)
	{
	}

	public void TriggerCalSkipRealWorldTime()
	{
	}

	public bool IsNormalSpeed()
	{
		return false;
	}

	private IEnumerator TakeHighlightPhotoCor(uint matchEventID, uint curRound)
	{
		return null;
	}

	public void TakeHighlightPhoto(uint matchEventID, uint curRound)
	{
	}

	private void TryProcessNextPhotoRequest()
	{
	}

	public void SaveHighlightPhoto(uint GameServerGameMode)
	{
	}

	private void SaveBRHighlightPhotos()
	{
	}

	private void SaveCSHighlightPhotos()
	{
	}

	public void OnHighlightPhotoSaved()
	{
	}

	public void ResetHighlightPhotoSavingFlag()
	{
	}

	public HighlightInfo CreatePhotoHighlightInfo(ReplayMatchEventData replayEventData, uint curRound)
	{
		return null;
	}

	public void AddRoundHighlightPhoto(uint round, uint highlightType, AlbumPhotoInfo photoInfo)
	{
	}

	public AlbumPhotoInfo GetRoundHighlightPhoto(uint round, uint highlightType)
	{
		return null;
	}

	public void ClearAllRoundHighlightPhotos()
	{
	}

	private void ClearAllRenderTextures()
	{
	}

	public AlbumPhotoInfo GetCurrentMultiKillPhoto()
	{
		return null;
	}

	public AlbumPhotoInfo GetCurrentHeadShotPhoto()
	{
		return null;
	}

	public void SetCurrentMultiKillPhoto(AlbumPhotoInfo photoInfo)
	{
	}

	public void SetCurrentHeadShotPhoto(AlbumPhotoInfo photoInfo)
	{
	}

	private int GetPanelDepthForType(Type controllerType)
	{
		return 0;
	}

	public void ShowHighlightPhotoUI()
	{
	}

	private void CleanInvalidControllerReferences()
	{
	}

	private void AddAndChangeShowUILayer(Type controllerType)
	{
	}

	private void SetLayerChanged(GameObject go)
	{
	}

	public void SetChildLayerToSpecial(Transform t)
	{
	}

	public void RestoreLayerToUI()
	{
	}

	private void RestoreLayerChanged(GameObject go)
	{
	}

	public void RestoreChildLayerToUI(Transform t)
	{
	}

	public void ActiveHighlightPhotoCamera()
	{
	}

	private void SetHighlightPhotoCameraEnabled(bool enabled)
	{
	}

	public void DestroyHighlightPhotoCamera()
	{
	}

	public void OnRenderPhotoDoneAction()
	{
	}

	private IEnumerator OnRenderPhotoDoneActionCor()
	{
		return null;
	}

	public bool SetSavedHighLight(ulong matchId, bool saved = true)
	{
		return false;
	}

	public bool IsSavedHighLight(ulong matchId)
	{
		return false;
	}

	public bool IsAssistHighlightRead(ulong matchId)
	{
		return false;
	}

	public bool SetAssistHighlightRead(ulong matchId, bool isRead, bool needRefreshAssistView = true)
	{
		return false;
	}

	private void SaveReplayInfoToLocal(MobileReplayInfo info)
	{
	}

	public void InitHighlightUnreadState(bool needRefreshAssist = true)
	{
	}

	public void OnHighlightUnreadTriggered()
	{
	}

	public void OnHighlightUnreadDismissed()
	{
	}

	public bool HasHighlightUnread()
	{
		return false;
	}

	public ulong FindLatestHighlightMatchId()
	{
		return 0uL;
	}

	private void AddHighlightMomentToAssist()
	{
	}

	private string GetHighlightPeriodKey()
	{
		return null;
	}

	private void ClearHighlightUnreadState()
	{
	}

	public void ResetPingRecordCursor()
	{
	}

	public void ResetReplayPingCursor()
	{
	}

	public void RecordPingSample(int value)
	{
	}

	public bool HasReplayPingData()
	{
		return false;
	}

	public int GetCurrentReplayPingValue()
	{
		return 0;
	}

	private void SetReplaySpeed(float speed)
	{
	}

	public void AddReplaySpeed(FOKBHOEDEMJ replaySpeed)
	{
	}

	public void RemoveReplaySpeed(FOKBHOEDEMJ replaySpeed)
	{
	}
}
