using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIBRMatchReviewPlayerPathController : UIBaseController
{
	private struct OutOfMapInterval
	{
		public long startMs;

		public long endMs;

		public Vector2 markerPos;
	}

	private struct EventItemEntry
	{
		public long ms;

		public NOOPBILFLIJ eventType;

		public UIBRMatchReviewEventItemController ctrl;

		public bool isKillType;

		public bool isReviveReceived;

		public bool isKillMergeUpdate;

		public int killMergeCount;

		public string mapEventNameLocKey;
	}

	public struct EventLayerInfo
	{
		public long ms;

		public int sequence;

		public UIBRMatchReviewEventItemController ctrl;
	}

	private struct PathWindow
	{
		public long startMs;

		public long endMs;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<BRMatchReviewPathNode> _003C_003E9__47_0;

		public static Comparison<BRMatchReviewPathNode> _003C_003E9__52_0;

		public static Comparison<HJNFDCJPPDE> _003C_003E9__54_0;

		public static Comparison<EventItemEntry> _003C_003E9__63_0;

		internal int _003CBuildSortedNodes_003Eb__47_0(BRMatchReviewPathNode a, BRMatchReviewPathNode b)
		{
			return 0;
		}

		internal int _003CAppendTeleportNodes_003Eb__52_0(BRMatchReviewPathNode a, BRMatchReviewPathNode b)
		{
			return 0;
		}

		internal int _003CBuildPathWindows_003Eb__54_0(HJNFDCJPPDE a, HJNFDCJPPDE b)
		{
			return 0;
		}

		internal int _003CInsertReviveReceivedEntries_003Eb__63_0(EventItemEntry a, EventItemEntry b)
		{
			return 0;
		}
	}

	private UIBRMatchReviewPlayerPathView m_View;

	private NGKNJIMOHBM m_PlayerInfo;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private Color m_Color;

	private List<BRMatchReviewPathNode> m_AllNodes;

	private Transform m_CurrentPosMarker;

	private UISprite m_CurrentPosMarkerSprite;

	private Vector3 m_EventIconScale;

	private Vector3 m_PlayerArrowScale;

	private readonly List<UIBRMatchReviewPlayerMoveLineController> m_MoveLines;

	private readonly List<int> m_MoveLineWindowIndices;

	private readonly List<EventItemEntry> m_EventItems;

	private UIBRMatchReviewEventItemController m_LatestDeathIcon;

	private int m_LastAppliedEventIdx;

	private bool m_IsTeammatesKillShow;

	private bool m_IsLocalPlayer;

	private bool m_IsHiddenAfterDeath;

	private long m_LastCurrentMs;

	private const float REVIVED_DEATH_ICON_ALPHA = 0.4f;

	private const float AFTER_DEATH_LINE_ALPHA = 0.4f;

	private const int EVENT_LAYER_STEP = 20;

	private const int TEAMMATE_PLAYER_ARROW_WIDGET_DEPTH = 3;

	public const int LOCAL_PLAYER_ARROW_WIDGET_DEPTH = 5;

	public const int EVENT_ITEM_MIN_WIDGET_DEPTH = 6;

	private const long EVENT_APPEAR_ANIM_MAX_FORWARD_DELTA_MS = 1000L;

	private const long TELEPORT_SYNTHETIC_DURATION_MS = 1L;

	private const float INITIAL_AIRLINE_POSITION_MAX_DISTANCE_METER = 200f;

	private const float WORLD_INT_PER_METER = 100f;

	private List<PathWindow> m_PathWindows;

	private readonly List<OutOfMapInterval> m_OutOfMapIntervals;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(NGKNJIMOHBM playerInfo, List<HJNFDCJPPDE> events, List<NIGJJPPPJFN> teleportEvents, List<long> reviveReceivedMs, List<JLNBGDGBHKL> positionSnapshots, BIJHHLHJDFN airLine, UIMapUtil.MapOffsetContext mapOffsetContext, Color color, bool isLocalPlayer = false, bool isTeammatesKillShow = true, bool isHiddenAfterDeath = true)
	{
	}

	public void SetCurrentMs(long currentMs)
	{
	}

	public void RefreshKillEventVisibility(bool show, bool isLocalPlayer, long currentMs)
	{
	}

	public void SetMapIconScale(Vector3 eventIconScale, Vector3 playerArrowScale)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public bool TryGetAutoScaleWindowBounds(long currentMs, long activeWindowMs, out Vector2 min, out Vector2 max)
	{
		min = default(Vector2);
		max = default(Vector2);
		return false;
	}

	private bool IsAutoScaleSegmentVisible(BRMatchReviewPathNode fromNode, BRMatchReviewPathNode toNode)
	{
		return false;
	}

	private Vector2 InterpolateNodeLocalPos(BRMatchReviewPathNode fromNode, BRMatchReviewPathNode toNode, long ms)
	{
		return default(Vector2);
	}

	private static void AppendAutoScaleBoundPoint(Vector2 p, ref bool hasBounds, ref Vector2 min, ref Vector2 max)
	{
	}

	private void ResetTransientVisualState()
	{
	}

	private List<BRMatchReviewPathNode> BuildSortedNodes(List<HJNFDCJPPDE> events, List<NIGJJPPPJFN> teleportEvents, List<JLNBGDGBHKL> positionSnapshots, BIJHHLHJDFN airLine)
	{
		return null;
	}

	private static long? GetFirstParachuteLandMs(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static bool ShouldSkipInitialAirlinePosition(long ms, int posX, int posZ, BIJHHLHJDFN airLine, long? firstParachuteLandMs)
	{
		return false;
	}

	private static int GetEventDisplayOrder(HJNFDCJPPDE eventData)
	{
		return 0;
	}

	private static int GetPathNodeDisplayOrder(BRMatchReviewPathNode node)
	{
		return 0;
	}

	private static void AppendTeleportNodes(List<BRMatchReviewPathNode> nodes, List<NIGJJPPPJFN> teleportEvents, uint pid)
	{
	}

	private static long EstimateTeleportStartMs(List<BRMatchReviewPathNode> positionNodes, int posX, int posZ)
	{
		return 0L;
	}

	private static List<PathWindow> BuildPathWindows(List<HJNFDCJPPDE> events)
	{
		return null;
	}

	private static int GetPathWindowIndex(long ms, List<PathWindow> windows)
	{
		return 0;
	}

	private void BuildAndCreateMoveLines(List<BRMatchReviewPathNode> nodes, List<PathWindow> windows)
	{
	}

	private UIBRMatchReviewPlayerMoveLineController CreateMoveLineCtrl(long startMs, Vector2 startPos, bool isTeleport, int windowIdx)
	{
		return null;
	}

	private void ApplyLocalPlayerLayerOrder()
	{
	}

	private void UpdateMoveLineVisibility(long currentMs)
	{
	}

	private bool ShouldHideMoveLineAfterRevive(int moveLineIndex, long latestReviveMs)
	{
		return false;
	}

	private long GetLatestReviveReceivedMs(long currentMs)
	{
		return 0L;
	}

	private void PreCreateEventItems(List<BRMatchReviewPathNode> nodes)
	{
	}

	private void InsertReviveReceivedEntries(List<long> reviveReceivedMs)
	{
	}

	private bool ShouldShowEventItem(EventItemEntry entry)
	{
		return false;
	}

	private bool ShouldPlayEventAppearAnim(EventItemEntry entry, long currentMs, long previousMs)
	{
		return false;
	}

	private void UpdateEventItemsVisibility(long currentMs, long previousMs)
	{
	}

	private void ResetEventItemsTo(long currentMs)
	{
	}

	private void HideAllMapEventNames()
	{
	}

	public void CollectVisibleEventLayers(long currentMs, List<EventLayerInfo> layers, ref int sequence)
	{
	}

	public static void SortEventLayers(List<EventLayerInfo> layers)
	{
	}

	public static void ApplyEventLayerOrder(EventLayerInfo layer, int orderIndex)
	{
	}

	private static void AddOrUpdateEventLayer(List<EventLayerInfo> layers, UIBRMatchReviewEventItemController ctrl, long ms, int sequence)
	{
	}

	private bool ShouldApplyEventLayer(EventItemEntry entry)
	{
		return false;
	}

	private static int FindEventLayerIndex(List<EventLayerInfo> layers, UIBRMatchReviewEventItemController ctrl)
	{
		return 0;
	}

	private static int CompareEventLayerEntry(EventLayerInfo a, EventLayerInfo b)
	{
		return 0;
	}

	private bool IsArrowVisible(long currentMs)
	{
		return false;
	}

	private bool TryGetCurrentMoveLineTip(long currentMs, out Vector2 pos, out Vector2 dir)
	{
		pos = default(Vector2);
		dir = default(Vector2);
		return false;
	}

	private bool TryGetActiveOutOfMapInterval(long currentMs, out OutOfMapInterval interval)
	{
		interval = default(OutOfMapInterval);
		return false;
	}

	private void UpdateCurrentPosMarker(long currentMs)
	{
	}

	private bool TryGetFallbackNodePosition(long currentMs, out Vector2 pos, out Vector2 dir)
	{
		pos = default(Vector2);
		dir = default(Vector2);
		return false;
	}

	private bool IsValidArrowPositionNode(BRMatchReviewPathNode node)
	{
		return false;
	}

	private int FindNextValidArrowPositionNodeIndex(int startIdx)
	{
		return 0;
	}

	private void UpdateNotInMapVFX(long currentMs)
	{
	}

	private bool IsWithinMapBounds(int worldIntX, int worldIntZ)
	{
		return false;
	}

	private Vector2 WorldIntToLocalPos(int worldIntX, int worldIntZ)
	{
		return default(Vector2);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
