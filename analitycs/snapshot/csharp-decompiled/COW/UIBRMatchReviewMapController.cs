using System;
using System.Collections.Generic;
using GCommon;
using Lean.Touch;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewMapController : UIMapBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__74_0;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__75_0;

		public static Comparison<long> _003C_003E9__84_0;

		internal int _003CCollectPlayerEvents_003Eb__74_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}

		internal int _003CIsMapKillDisplayEventDuringPlayerDeath_003Eb__75_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}

		internal int _003CCollectPlayerReviveReceivedMs_003Eb__84_0(long a, long b)
		{
			return 0;
		}
	}

	private UIBRMatchReviewMapView m_View;

	private readonly Dictionary<long, UIBRMatchReviewPlayerPathController> m_PathControllers;

	private readonly Dictionary<long, List<HJNFDCJPPDE>> m_PlayerMapEvents;

	private readonly HashSet<uint> m_VisiblePlayerIds;

	private Dictionary<byte, uint> m_ShortToFullPlayerId;

	private BRMatchReviewClientData m_MatchData;

	private List<NGKNJIMOHBM> m_LocalTeamPlayers;

	private bool m_IsTeammatesKillShow;

	private int m_CurrentSafeZonePhase;

	private bool m_AirLineVisible;

	private long m_LastTickMs;

	private const float MAX_MAP_SCALE = 4f;

	private const float MAX_MAP_INIT_SIZE = 750f;

	private readonly Dictionary<int, LeanFinger> m_CacheFinger;

	private readonly List<Vector2> m_ActiveNodeLocalPositions;

	private const float MIN_AUTO_SCALE_SIDE_METER = 1f;

	private const int BOOYAH_TRIGGER_EVENT_MAX_DELTA_MS = 1000;

	private const int ENERGY_DEVICE_REVIVE_SUPPRESS_DISTANCE_X100 = 2000;

	private readonly List<UIBRMatchReviewPlayerPathController.EventLayerInfo> m_EventLayerInfos;

	private bool m_IsAutoScaleMode;

	private bool m_IsAutoScaleAdjusting;

	private float m_LastMapOperationRealtime;

	private EPlaybackState m_PlaybackState;

	private float m_AutoScaleActiveWindowSec;

	private float m_AutoScaleSafeMarginMeter;

	private float m_AutoScaleDiffThresholdMeter;

	private float m_AutoScaleStopThresholdMeter;

	private float m_AutoScaleManualIdleSec;

	private float m_AutoScaleMaxScale;

	private float m_AutoScaleCenterLerpAlpha;

	private float m_AutoScaleScaleLerpAlpha;

	private static readonly Color[] s_MemberColors;

	private Action<Vector3> m_OnIconScaleChanged;

	public event Action<Vector3> OnIconScaleChanged
	{
		add
		{
		}
		remove
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override UIMapContentController OpenMapContentController(Transform tr)
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public Transform GetMapPanelTransform()
	{
		return null;
	}

	public UIMapUtil.MapOffsetContext GetMapOffsetContext()
	{
		return null;
	}

	public Vector3 GetCurrentIconScale()
	{
		return default(Vector3);
	}

	public float GetMapZoomProgress()
	{
		return 0f;
	}

	public int GetMaxPanelDepth()
	{
		return 0;
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void LoadData(BRMatchReviewClientData data)
	{
	}

	public void Tick(long currentMs, bool isTimelineJump = false)
	{
	}

	public void SetPlaybackState(EPlaybackState state)
	{
	}

	public void SetAutoScaleMode(bool isAuto)
	{
	}

	public void ToggleAutoScaleMode()
	{
	}

	public bool IsAutoScaleMode()
	{
		return false;
	}

	private void LoadAutoScaleConfig(BRMatchReviewAutoScaleConfig config)
	{
	}

	public void SetTeammatesKillVisible(bool visible)
	{
	}

	public void SetPlayerPathVisible(long playerID, bool visible)
	{
	}

	private void UpdateSafeZone(long ms)
	{
	}

	private void UpdateAirLine(long ms)
	{
	}

	private void UpdatePlayerPaths(long ms)
	{
	}

	private void RefreshEventItemLayers(long ms)
	{
	}

	private void UpdateAutoScale(long currentMs, bool forceRefresh = false)
	{
	}

	private void ResetReplayMapToInitialView()
	{
	}

	private bool IsAirLineFinished(long currentMs)
	{
		return false;
	}

	private bool IsLocalRectVisible(float minX, float maxX, float minY, float maxY, float clipWidth, float currentScale, float toleranceLocal)
	{
		return false;
	}

	private void FitReplayMapToLocalSquare(Vector2 centerLocalPos, float squareSideLocal, float clipWidth, bool snapToTarget = false)
	{
	}

	private void ClampReplayMapPanelPosition(Transform mapPanel, float clipWidth)
	{
	}

	private float GetAutoScaleMaxScale()
	{
		return 0f;
	}

	private void CollectActiveInfoNodes(long currentMs, UIMapUtil.MapOffsetContext ctx, List<Vector2> result)
	{
	}

	private bool TryAddWorldIntNode(int worldIntX, int worldIntZ, UIMapUtil.MapOffsetContext ctx, List<Vector2> result)
	{
		return false;
	}

	private bool IsVisibleLocalTeamPlayer(uint playerID)
	{
		return false;
	}

	private void CreateLocalTeamPaths()
	{
	}

	private void CreatePlayerPath(NGKNJIMOHBM playerInfo, Color color, bool isLocalPlayer)
	{
	}

	private bool GetPathIsHiddenAfterDeath()
	{
		return false;
	}

	private void RefreshPathIconScale()
	{
	}

	private Vector3 CalcFixedScreenIconScale()
	{
		return default(Vector3);
	}

	private List<HJNFDCJPPDE> CollectPlayerEvents(long playerID)
	{
		return null;
	}

	private bool IsMapKillDisplayEventDuringPlayerDeath(HJNFDCJPPDE evt, uint playerID)
	{
		return false;
	}

	private static bool IsMapKillDisplayEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsReviveReceivedByPlayer(HJNFDCJPPDE evt, uint playerID)
	{
		return false;
	}

	private bool IsEnergyDeviceReviveSuppressedOnMap(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsWithinEnergyDeviceReviveSuppressDistance(HJNFDCJPPDE reviveEvent, HJNFDCJPPDE highRiskPointEvent)
	{
		return false;
	}

	private bool IsBooyahTriggerMapEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private HJNFDCJPPDE FindBooyahTriggerEvent(int booyahMs)
	{
		return null;
	}

	private bool IsSameEvent(HJNFDCJPPDE a, HJNFDCJPPDE b)
	{
		return false;
	}

	private List<NIGJJPPPJFN> CollectPlayerTeleportEvents(long playerID)
	{
		return null;
	}

	private List<long> CollectPlayerReviveReceivedMs(long playerID)
	{
		return null;
	}

	private void InitMapPanelScale()
	{
	}

	private void OnGesture(List<LeanFinger> fingers)
	{
	}

	private void EnterManualScaleMode()
	{
	}

	private void OnFingerSet(LeanFinger finger)
	{
	}

	private void OnFingerDown(LeanFinger finger)
	{
	}

	private bool IsMapTouched(LeanFinger finger)
	{
		return false;
	}

	private bool IsMapObject(GameObject go)
	{
		return false;
	}

	private void ClearPaths()
	{
	}

	private bool TryGetAutoScaleWindowBounds(long currentMs, out Vector2 min, out Vector2 max)
	{
		min = default(Vector2);
		max = default(Vector2);
		return false;
	}

	private static Color GetMemberColor(int idx)
	{
		return default(Color);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public UIMapContentController _003C_003EiFixBaseProxy_OpenMapContentController(Transform P0)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
