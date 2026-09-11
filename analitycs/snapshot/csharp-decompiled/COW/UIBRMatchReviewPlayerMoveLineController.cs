using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIBRMatchReviewPlayerMoveLineController : UIBaseController
{
	private struct Waypoint
	{
		public long ms;

		public Vector2 pos;
	}

	private UIBRMatchReviewPlayerMoveLineView m_View;

	private List<Waypoint> m_Waypoints;

	private List<Waypoint> m_RenderWaypoints;

	private Color m_Color;

	private bool m_IsTeleport;

	private bool m_IsLocalPlayer;

	private float m_AlphaScale;

	private const float TELEPORT_ALPHA = 0.35f;

	private const float COLLINEAR_TOLERANCE = 0.1f;

	private const bool ENABLE_SMOOTH_SHORT_CORNER = true;

	private const float SMOOTH_LONG_SEGMENT_MIN_LENGTH = 8f;

	private const float SMOOTH_SHORT_SEGMENT_MAX_LENGTH = 2.5f;

	private const float SMOOTH_SHARP_ANGLE_DEGREES = 120f;

	private const float SMOOTH_REVERSE_SEGMENT_MAX_LENGTH = 9f;

	private const float SMOOTH_REVERSE_ANGLE_DEGREES = 170f;

	private const float SMOOTH_CURVE_BACK_DISTANCE = 1.5f;

	private const int SMOOTH_CURVE_SAMPLE_COUNT = 5;

	private const float FRAME_TINY_SEGMENT_MAX_LENGTH = 0.5f;

	private const bool ENABLE_RENDER_WAYPOINT_INTERPOLATION = true;

	private const float RENDER_WAYPOINT_MAX_SEGMENT_LENGTH = 2f;

	private const long RENDER_WAYPOINT_MIN_SAMPLE_INTERVAL_MS = 100L;

	private const int RENDER_WAYPOINT_MAX_INSERT_COUNT_PER_SEGMENT = 16;

	private const int TEAMMATE_PATH_WIDGET_DEPTH = 1;

	private const int LOCAL_PLAYER_PATH_WIDGET_DEPTH = 2;

	private LineRenderer ActiveLine => null;

	private UIEffectWidget ActiveEffectWidget => null;

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

	public void BeginBuild(long startMs, Vector2 startPos, Color color, bool isTeleport, bool isLocalPlayer = false)
	{
	}

	private void ApplyPathWidgetDepth()
	{
	}

	public void AddWaypoint(long ms, Vector2 pos)
	{
	}

	private static bool IsCollinear(Vector2 ab, Vector2 bc)
	{
		return false;
	}

	public void FinishBuild()
	{
	}

	public void SetAlpha(float alphaScale)
	{
	}

	public void SetCurrentMs(long currentMs)
	{
	}

	public bool TryGetCurrentTip(long currentMs, out Vector2 pos, out Vector2 dir)
	{
		pos = default(Vector2);
		dir = default(Vector2);
		return false;
	}

	private void ApplyLine(int upToIdx, bool hasExtraTip, Vector2 extraTip)
	{
	}

	private List<Waypoint> GetActiveWaypoints()
	{
		return null;
	}

	private List<Waypoint> BuildRenderWaypoints(List<Waypoint> source)
	{
		return null;
	}

	private static List<Waypoint> BuildSmoothShortCornerWaypoints(List<Waypoint> source)
	{
		return null;
	}

	private static List<Waypoint> BuildInterpolatedRenderWaypoints(List<Waypoint> source)
	{
		return null;
	}

	private static bool TryAppendSmoothShortCorner(List<Waypoint> source, int cornerIdx, List<Waypoint> result, out int consumedEndIdx)
	{
		consumedEndIdx = default(int);
		return false;
	}

	private static float GetAngleDegrees(Vector2 a, Vector2 b)
	{
		return 0f;
	}

	private static bool ShouldAppendExtraTip(List<Waypoint> waypoints, int upToIdx, bool hasExtraTip, Vector2 extraTip)
	{
		return false;
	}

	private static long LerpMs(long startMs, long endMs, float t)
	{
		return 0L;
	}

	private static Vector2 CubicBezier(Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3, float t)
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
