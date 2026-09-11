using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class GrenadeLine : MonoBehaviour
{
	public LineRenderer SplitLine;

	protected List<LineRenderer> m_SplitLines;

	protected bool m_ShowGrenadeLine;

	protected bool m_ShowThrowSkillLine;

	protected LineRenderer m_GrenadeLine;

	private float interval;

	private const int pos_count = 75;

	private const float grenadeLauncher1stPosRatio = 0.15f;

	private const float defaultEffectRadius = 4.75f;

	private SkillLineType m_IsSkill;

	private Vector3 m_KickBallStartPos;

	private Vector3 m_KickBallVelocity;

	protected float m_EffectRadius;

	protected bool ShowEffectPlayerOutline;

	protected bool m_IsDefaultSplitState;

	protected bool m_CanSplit;

	protected int m_SplitNum;

	protected float m_RemainTime;

	protected float m_SplitVelocityFactor;

	protected bool m_EffectPlayed;

	protected GameObject m_EffectOnce;

	protected GameObject m_EffectLoop;

	private const uint SAMPLE_INTERVAL = 8u;

	private GMPGMPFNMFP m_HitObjectInfo;

	public string HitHintResid;

	public GameObject hitHint;

	public GameObject exploredHint;

	public GameObject effectRangeHint;

	private Vector3[] SegVectors;

	private float[] distanceArr;

	private float m_GrenadeSplitTime;

	private List<GameObject> m_SplitHitHints;

	private List<GameObject> m_SplitExploredHints;

	private const int MAX_BISECTION_STEP = 4;

	private const int SPLIT_SEGMENT_POINT_COUNT = 8;

	private List<Vector3> m_PointsList;

	private bool m_Init;

	private bool m_EventRegistered;

	private ResourceID m_LineResID;

	private static readonly Dictionary<ResourceID, GrenadeLine> s_GrenadeLines;

	private static Material s_SharedOutlineMaterial;

	private Dictionary<BHGGAEEHJCO, int> m_PlayerOutlineTickets;

	private Material m_OutlineMaterial;

	protected bool ShowGrenadeLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected bool ShowThrowSkillLine
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void OnShowGrenadeLineChanged()
	{
	}

	private void Start()
	{
	}

	private void InitLineIfNeeded()
	{
	}

	protected virtual ResourceID GetDefaultLineResID()
	{
		return default(ResourceID);
	}

	private ResourceID GetCurrentLineResID()
	{
		return default(ResourceID);
	}

	private bool IsDefaultLine()
	{
		return false;
	}

	protected bool IsTargetLine(ResourceID targetLineResID)
	{
		return false;
	}

	public void SetLineResID(ResourceID resID)
	{
	}

	public static ResourceID PrepareGrenadeLine(ResourceID resID)
	{
		return default(ResourceID);
	}

	protected void SetEnabled(bool value)
	{
	}

	protected void DelayCreate()
	{
	}

	private ResourceID GetHitHintResID()
	{
		return default(ResourceID);
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void UpdateEffectRangePlayerOutline()
	{
	}

	private int AttachOutlineEffect(Player player)
	{
		return 0;
	}

	private void DetachOutlineEffect(Player player, int ticket)
	{
	}

	private void DetachAllOutlineEffect()
	{
	}

	private float ExplodeLeftTime(float exlodeTime, float triggerEndTime)
	{
		return 0f;
	}

	private int DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity, float explodeTime, uint layer)
	{
		return 0;
	}

	private bool BisectionFindHit(int startIndex, int endIndex, Vector3 throwVel, uint layer, int layerMask, ref bool onceHitted, ref int middleIndex, ref Vector3 middlePos)
	{
		return false;
	}

	private int SetLinePositionOp(bool needReCalPos, int timeStep, Vector3 starPos, Vector3 throwVel, Vector3 gravity, uint layer, LineRenderer grenadeLine, GameObject hitEffect, GameObject exploredEffect, GameObject effectRangeHint)
	{
		return 0;
	}

	private Vector3 FindMiddlePos(Vector3 hitPostion, int startIndex, int endIndex, Vector3 velocity, out int middleIndex)
	{
		middleIndex = default(int);
		return default(Vector3);
	}

	private int SetLinePositions(bool needReCalPos, int timeStep, Vector3 starPos, Vector3 throwVel, Vector3 gravity, uint layer, LineRenderer grenadeLine, GameObject hitEffect, GameObject exploredEffect)
	{
		return 0;
	}

	protected virtual void DrawSplitLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity, float splitVelFactor, float remainTime, int splitNum, float leftTime, uint layer, int hitIndex)
	{
	}

	private void DrawLine2(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}

	private void DrawStraightLine(Vector3 throwPos, Vector3 throwVel, float maxDistance)
	{
	}

	private void DrawKickBallLine(Vector3 startPos, Vector3 velocity, Vector3 gravity)
	{
	}

	private void DrawStraightLineWithHitHint(Vector3 throwPos, Vector3 throwVel, float maxDistance, bool checkHitObject = true)
	{
	}

	protected virtual void OnGrenadeCrosshairFireChange(object[] data)
	{
	}

	protected virtual void OnThrowSkillFireChange(object[] data)
	{
	}

	protected virtual void OnKickFootballLineChange(object[] data)
	{
	}

	protected virtual void GenerateSplitLineNum(int splitNum)
	{
	}

	protected virtual void EnableAllSplitLine(bool isEnabled)
	{
	}

	protected virtual void UpdateAllSplitLineEnabled(bool isEnabled)
	{
	}

	protected virtual void OnGrenadeCrosshairSplitChange(int data)
	{
	}

	private void AddGrenageSplitEffect(float remainTime, Player localPlayer)
	{
	}

	protected void RemoveGrenageSplitEffect()
	{
	}

	private uint GetLayerMask(KIDGFPLCBCP grenade)
	{
		return 0u;
	}

	private void SetGameObjectActive(GameObject go, bool flag)
	{
	}

	private uint GetGrenadeStartBlockLayer(uint layer)
	{
		return 0u;
	}

	private bool TryGetGrenadeStartBlockHitPos(Vector3 firePos, Vector3 throwPos, uint layer, out Vector3 hitPos)
	{
		hitPos = default(Vector3);
		return false;
	}

	private int DrawGrenadeStartBlockedLine(Vector3 firePos, Vector3 hitPos)
	{
		return 0;
	}

	private void RecycleGrenadeLineHitObjectInfo()
	{
	}
}
