using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewTimelineBarController : UIBaseController
{
	private struct MarkerCandidate
	{
		public long TimeMs;

		public HJNFDCJPPDE EventData;

		public UIBRMatchReviewTimelineEventController.ETimelineMarkerType LowerType;

		public bool IsSelfEvent;

		public Color BubbleTint;
	}

	private struct MarkerStackEntry
	{
		public long TimeMs;

		public int CreateOrder;

		public UIBRMatchReviewTimelineEventController Controller;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<MarkerCandidate> _003C_003E9__33_0;

		public static Comparison<MarkerStackEntry> _003C_003E9__36_0;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__49_0;

		internal int _003CRebuildMarkers_003Eb__33_0(MarkerCandidate a, MarkerCandidate b)
		{
			return 0;
		}

		internal int _003CApplyMarkerStackingOrder_003Eb__36_0(MarkerStackEntry a, MarkerStackEntry b)
		{
			return 0;
		}

		internal int _003CCollectPrioritizedEventMarkers_003Eb__49_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}
	}

	private const int MAX_EVENT_MARKERS = 10;

	private const int TIMELINE_MARKER_DEPTH_STEP = 16;

	private UIBRMatchReviewTimelineBarView m_View;

	private bool m_IsDragging;

	private EPlaybackState m_StateBeforeDrag;

	private List<UIBRMatchReviewTimelineEventController> m_MarkerControllers;

	private List<HJNFDCJPPDE> m_CachedEvents;

	private List<HJNFDCJPPDE> m_CachedMarkerEvents;

	private List<OFCOMIFFOLO> m_CachedSafeZones;

	private long m_CachedTotalDurationMs;

	private HashSet<uint> m_VisiblePlayerFilter;

	private uint m_LocalPlayerID;

	private bool m_IsTeammatesKillShow;

	private List<NGKNJIMOHBM> m_MyTeamPlayers;

	private Dictionary<uint, int> m_TeamSlotByPlayerId;

	private const long CLUSTER_WINDOW_MS = 5000L;

	private UIBRMatchReviewController ReviewCtrl => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnTimelineSliderChanged()
	{
	}

	private void OnTimelineSliderDragFinished()
	{
	}

	public void RefreshPlaybackUI(float currentTimeMs, float totalTimeMs, EPlaybackState state)
	{
	}

	private void OnPauseClick()
	{
	}

	public void SetEventMarkerData(List<HJNFDCJPPDE> events, List<OFCOMIFFOLO> safeZones, long totalDurationMs, uint localPlayerID, List<NGKNJIMOHBM> myTeamPlayers, uint groupMode = 0u, bool isTeammatesKillShow = true)
	{
	}

	private void BuildTeamSlotLookup(List<NGKNJIMOHBM> myTeamPlayers)
	{
	}

	private Color ResolveBubbleTint(HJNFDCJPPDE evt)
	{
		return default(Color);
	}

	private bool TryGetVisibleTeamSlot(uint playerId, out int slot)
	{
		slot = default(int);
		return false;
	}

	private bool TryGetTeamSlot(uint playerId, out int slot)
	{
		slot = default(int);
		return false;
	}

	private bool TryGetVisibleRevivedTeamSlot(HJNFDCJPPDE evt, out int slot)
	{
		slot = default(int);
		return false;
	}

	private bool TryGetRevivedTeamSlot(HJNFDCJPPDE evt, out int slot)
	{
		slot = default(int);
		return false;
	}

	public void SetVisiblePlayerFilter(HashSet<uint> visiblePlayerIds)
	{
	}

	private void RebuildMarkers()
	{
	}

	private void OnEventMarkerClicked(long timeMs)
	{
	}

	private void RemoveMarkersAfterDuration(List<MarkerCandidate> candidates)
	{
	}

	private void ApplyMarkerStackingOrder(List<MarkerStackEntry> markers)
	{
	}

	private List<HJNFDCJPPDE> FilterEventsByVisibility(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private bool ShouldShowKillEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static bool IsTimelineKillEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private void ClearMarkers()
	{
	}

	private int GetEventPriority(HJNFDCJPPDE evt)
	{
		return 0;
	}

	private int GetBooyahPriority(HJNFDCJPPDE evt)
	{
		return 0;
	}

	private bool IsRepresentativeBooyahEventVisible(HJNFDCJPPDE evt)
	{
		return false;
	}

	private bool IsPlayerVisible(uint playerId)
	{
		return false;
	}

	private void CollectAirlineMarker(List<HJNFDCJPPDE> events, List<MarkerCandidate> candidates)
	{
	}

	private void CollectSafeZoneShrinkMarkers(List<OFCOMIFFOLO> safeZones, List<MarkerCandidate> candidates)
	{
	}

	private static long GetMarkerAnchorMs(HJNFDCJPPDE evt)
	{
		return 0L;
	}

	private void CollectPrioritizedEventMarkers(List<HJNFDCJPPDE> events, List<MarkerCandidate> candidates)
	{
	}

	private bool IsSelfMarkerEvent(HJNFDCJPPDE evt)
	{
		return false;
	}

	private static int CountList<T>(List<T> list)
	{
		return 0;
	}

	private int GetVisibleFilterLogValue()
	{
		return 0;
	}

	private int _003CCollectPrioritizedEventMarkers_003Eb__49_1(HJNFDCJPPDE a, HJNFDCJPPDE b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
