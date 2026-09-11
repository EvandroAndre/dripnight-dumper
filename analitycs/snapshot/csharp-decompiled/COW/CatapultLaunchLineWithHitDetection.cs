using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class CatapultLaunchLineWithHitDetection : MonoBehaviour
{
	public bool IsMainLine;

	public int StartPosIndex;

	public int EndDistance;

	public float StartWidth;

	public float StartTime;

	public float EndWidth;

	public float EndTime;

	private LineRenderer m_LineRender;

	private float m_CurInterval;

	private int m_CurMaxPosCount;

	private GMPGMPFNMFP m_HitObjectInfo;

	private VisualInstanceHolder m_HitHolder;

	private List<Vector3> m_PointsList;

	private Vector3 m_CacheMainThrowerPos;

	private Vector3 m_CacheMainEndPos;

	private bool m_CacheMainActive;

	private Vector3 m_CacheThrowerPos;

	private Vector3 m_CacheVel;

	private bool m_CacheActive;

	private int m_CachedLayerMask;

	private AnimationCurve m_CachedConstantCurve;

	private AnimationCurve m_CachedDynamicCurve;

	private float m_LastDistance;

	private Vector3[] m_CachedPositions;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void LateUpdate()
	{
	}

	private void DelayCreate()
	{
	}

	private void DrawLineWithHitDetection(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}

	private void SelectParametersByAngle(Vector3 velocity)
	{
	}

	private void SetLineRendererPositions(bool hasHit, Vector3 hitPosition, int hitIndex)
	{
	}

	private float CalculateHitHintScale(float distance)
	{
		return 0f;
	}

	private int FindHitIndex(Vector3 hitPosition, int startIndex, int endIndex)
	{
		return 0;
	}
}
