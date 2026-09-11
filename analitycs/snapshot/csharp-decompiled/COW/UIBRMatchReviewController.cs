using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__46_0;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__82_0;

		internal int _003CFilterMyTeamEvents_003Eb__46_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}

		internal int _003CFindMyTeamAllDeadTimeMs_003Eb__82_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}
	}

	private UIBRMatchReviewView m_View;

	private UIRoot m_UIRoot;

	private const int FOREGROUND_PANEL_DEPTH_STEP = 10;

	private UIBRMatchReviewTimelineBarController m_TimelineBarController;

	private UIBRMatchReviewMapController m_MapController;

	private UIBRMatchReviewBattleLogController m_BattleLogController;

	private UIBRMatchReviewTeammatePanelController m_TeammatePanelController;

	private UIBRMatchReviewLegendsController m_LegendsController;

	private UIBRMatchReviewRecordController m_RecordController;

	private EIENIBNLACM m_MatchData;

	private BRMatchReviewHeatmapRenderer m_HeatmapRenderer;

	private BRMatchReviewSurvivalTracker m_SurvivalTracker;

	private BRMatchReviewMapObjectRenderer m_MapObjectRenderer;

	private const int INVALID_SURVIVAL_DISPLAY_COUNT = -1;

	private const float MAP_OBJECT_BASE_SCALE_MIN = 0.7f;

	private const float MAP_OBJECT_BASE_SCALE_MAX = 1f;

	private int m_LastAliveTeamCount;

	private int m_LastAlivePlayerCount;

	private BRMatchReviewPlaybackEngine m_PlaybackEngine;

	private bool m_RuntimeStateCleaned;

	private float m_OpenRealtime;

	private bool m_HasSentExitLog;

	private float m_MaxReviewTimeMs;

	private long m_MatchDurationMs;

	private bool m_GroupWaitingWasVisibleOnOpen;

	private const float LAYOUT_REFERENCE_WIDTH = 1500f;

	private const float LAYOUT_RIGHT_COMPACT_SCALE = 0.88f;

	private const float LAYOUT_LEFT_OFFSET_FACTOR = 0.5f;

	private const float LAYOUT_RIGHT_OFFSET_FACTOR = 0.25f;

	private const long MIN_TIMELINE_DURATION_MS = 1000L;

	private const long INVALID_TIMELINE_TIME_MS = -1L;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void LiftViewPanelsAboveMap()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ApplyResolutionLayout()
	{
	}

	private static void ApplyContainerLayout(GameObject container, float localX, float scale)
	{
	}

	private void TryLoadDataFromModel()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void HideUnderlyingWaitingViewsForReview()
	{
	}

	private void RestoreUnderlyingWaitingViewsAfterReview()
	{
	}

	private bool CanCurrentlyShowGroupWaiting(UIMatchMakingManager matchMaking)
	{
		return false;
	}

	private UIMatchMakingManager GetCurrentSceneMatchMakingManager()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	private void CleanupRuntimeState()
	{
	}

	private void OnMapIconScaleChanged(Vector3 iconScale)
	{
	}

	private JODHCHIKNEP FindMyTeam(ulong localUserID)
	{
		return null;
	}

	private HashSet<uint> CollectPlayerIds(List<NGKNJIMOHBM> players)
	{
		return null;
	}

	private List<HJNFDCJPPDE> FilterMyTeamEvents(HashSet<uint> myTeamPlayerIds, List<NGKNJIMOHBM> myTeamPlayers)
	{
		return null;
	}

	private static List<HJNFDCJPPDE> FilterPreFirstDeathParachuteLandEvents(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static bool IsPreFirstDeathParachuteLandEvent(HJNFDCJPPDE evt, Dictionary<uint, int> firstDeathMsByPlayer)
	{
		return false;
	}

	private HashSet<ulong> BuildMyTeamDeathKeys(HashSet<uint> myTeamPlayerIds)
	{
		return null;
	}

	private static bool IsMyTeamKilledByEnemy(HJNFDCJPPDE evt, HashSet<uint> myTeamPlayerIds)
	{
		return false;
	}

	private static bool IsEnemyTeamEliminatedByMyTeam(HJNFDCJPPDE evt, HashSet<uint> myTeamPlayerIds)
	{
		return false;
	}

	private static bool IsMyTeamEliminatedByEnemy(HJNFDCJPPDE evt, HashSet<uint> myTeamPlayerIds)
	{
		return false;
	}

	private static void AddDisplayDeathEventIfNeeded(List<HJNFDCJPPDE> result, HashSet<ulong> deathKeys, HJNFDCJPPDE sourceEvent)
	{
	}

	private static ulong BuildDeathKey(uint playerId, int ms)
	{
		return 0uL;
	}

	private static HJNFDCJPPDE CreateDisplayDeathEvent(HJNFDCJPPDE killEvent)
	{
		return null;
	}

	private Dictionary<uint, NGKNJIMOHBM> BuildPlayerIdToInfo()
	{
		return null;
	}

	private void InitHeatmapRenderer(Dictionary<uint, NGKNJIMOHBM> playerInfoDict, HashSet<uint> myTeamPlayerIds, uint localPlayerId, long enemyLayerRevealTimeMs)
	{
	}

	private uint FindLocalPlayerID()
	{
		return 0u;
	}

	private void InitMapObjectRenderer(HashSet<uint> myTeamPlayerIds)
	{
	}

	private void RefreshMapObjectBaseScale()
	{
	}

	private void InitSurvivalTracker()
	{
	}

	private void RefreshSurvivalDisplay(float currentTimeMs)
	{
	}

	private void ResetSurvivalDisplayCache()
	{
	}

	private void EnsureLegendsController()
	{
	}

	private void InitLegends()
	{
	}

	public void OnLegendToggled(EBRMatchReviewLegendType type, bool isOn)
	{
	}

	private void OnLegendsClick()
	{
	}

	public void OnTeamMemberVisibilityChanged(uint playerId, bool isVisible)
	{
	}

	public HashSet<uint> GetVisiblePlayerIds()
	{
		return null;
	}

	private static HashSet<uint> ClonePlayerIdSet(HashSet<uint> playerIds)
	{
		return null;
	}

	public void LoadMockData()
	{
	}

	public void LoadData(BRMatchReviewClientData data)
	{
	}

	private static List<HJNFDCJPPDE> FilterAutoSpeedEvents(List<HJNFDCJPPDE> events, uint localPlayerId, bool isTeammatesKillShow)
	{
		return null;
	}

	private static bool IsTeammateKillHiddenByConfig(HJNFDCJPPDE evt, uint localPlayerId)
	{
		return false;
	}

	private static List<HJNFDCJPPDE> FilterEventsUntil(List<HJNFDCJPPDE> events, long endTimeMs)
	{
		return null;
	}

	private static long CalcTotalDuration(BRMatchReviewClientData data, List<HJNFDCJPPDE> myTeamEvents, HashSet<uint> myTeamPlayerIds)
	{
		return 0L;
	}

	private static long FindEnemyLayerRevealTimeMs(List<HJNFDCJPPDE> events, uint localPlayerId, HashSet<uint> myTeamPlayerIds, BIJHHLHJDFN airLine)
	{
		return 0L;
	}

	private static long GetAirLineEndMs(BIJHHLHJDFN airLine)
	{
		return 0L;
	}

	private static long FindMyTeamBooyahTimeMs(BRMatchReviewClientData data, HashSet<uint> myTeamPlayerIds)
	{
		return 0L;
	}

	private static long FindMyTeamAllDeadTimeMs(List<HJNFDCJPPDE> myTeamEvents, HashSet<uint> myTeamPlayerIds)
	{
		return 0L;
	}

	private static bool TryGetRevivedMyTeamPlayerId(HJNFDCJPPDE evt, HashSet<uint> myTeamPlayerIds, out uint revivedPlayerId)
	{
		revivedPlayerId = default(uint);
		return false;
	}

	private static bool IsSingleActorReviveSubType(HIMPICPLPMB subType)
	{
		return false;
	}

	private static bool HasMyTeamEventAfter(List<HJNFDCJPPDE> myTeamEvents, long timeMs)
	{
		return false;
	}

	private static long CalcFallbackTotalDuration(BRMatchReviewClientData data)
	{
		return 0L;
	}

	private void SendBRTacticalReviewExitLog()
	{
	}

	private int GetMatchTimeSeconds()
	{
		return 0;
	}

	public void MarkReviewTimeReached(float reviewTimeMs)
	{
	}

	private static int MsToSecondsInt(long ms)
	{
		return 0;
	}

	public float GetCurrentTimeMs()
	{
		return 0f;
	}

	public float GetTotalTimeMs()
	{
		return 0f;
	}

	public EPlaybackState GetPlaybackState()
	{
		return EPlaybackState.Stopped;
	}

	public float GetPlaybackSpeed()
	{
		return 0f;
	}

	public bool GetIsAutoPlay()
	{
		return false;
	}

	public float EvaluateAutoSpeed(float currentTimeMs)
	{
		return 0f;
	}

	public EIENIBNLACM GetMatchData()
	{
		return null;
	}

	public void StartPlayback()
	{
	}

	public void StopPlayback()
	{
	}

	public void PausePlayback()
	{
	}

	public void ResumePlayback()
	{
	}

	public void SeekPlaybackTime(float timeMs)
	{
	}

	public void SeekPlaybackTime(long timeMs)
	{
	}

	public void SetPlaybackTime(float timeMs)
	{
	}

	private void Update()
	{
	}

	private float EvaluatePlaybackSpeed(float currentTimeMs)
	{
		return 0f;
	}

	private void RefreshAllModules(bool isTimelineJump = false)
	{
	}

	private void OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
