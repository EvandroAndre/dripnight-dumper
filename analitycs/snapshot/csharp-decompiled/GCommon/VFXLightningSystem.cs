using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class VFXLightningSystem : MonoBehaviour
{
	private class LineData
	{
		public LineRenderer Line;

		public float LineTime;

		public float LineTimer;

		public int StartMeshIndex;

		public int startMeshSampleIndex;

		public int EndMeshIndex;

		public int EndMeshSampleIndex;

		public Vector3 StartNormal;

		public Vector3 EndNormal;

		public Vector2 Random2;

		public PointInfo[] Infos;

		public GameObject VFXStart;

		public GameObject VFXEnd;

		public float Width;

		public float Height;

		public GradientColorKey[] TempLineColorKeys;

		public GradientAlphaKey[] TempLineColorAlphaKeys;

		public Gradient TempColorGradient;

		public Vector3[] CachedLinePosition;

		public bool bUpdateGradient;

		public Color CachedColorOverLifeTime;

		public Vector3 CachedBendDir;

		public bool bIgnoreByAngleThresholdOrDistance;
	}

	private struct PointInfo
	{
		public Vector3 Position;

		public Vector3 Normal;
	}

	private struct SampleMeta
	{
		public SampleCachedPointsData CachedPointsData;

		public int BaseIndex;

		public int Num;
	}

	private sealed class _003CVFXGC_003Ed__78 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GameObject vfx;

		public VFXLightningSystem _003C_003E4__this;

		public bool isStartVFX;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CVFXGC_003Ed__78(int _003C_003E1__state)
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

	private const int FRAME_LOOP = 3;

	private const int MAX_LINE_COUNT = 15;

	private const int MAX_LINE_SEGMENT = 7;

	private const int QUALITY_LOW_MAX_LINE_COUNT = 6;

	private const int QUALITY_LOW_MAX_LINE_SEGMENT = 5;

	private const int MAX_SPAWN_VFX = 26;

	private const string SPAWN_LINE_NAME = "VFXSpawnLine";

	public bool LowQuality;

	public List<MeshFilter> EmitterMeshes;

	public bool FollowEmitter;

	public GameObject VFXEmitte;

	public List<MeshFilter> TargetsMeshes;

	public bool FollowTarget;

	public GameObject VFXTarget;

	public int LineMaxCount;

	public int LineQuality;

	public Material LineMat;

	public float RateOverTime;

	private float m_SpawnTimer;

	private float m_SpawnTime;

	public Vector2 LifeTimeRange;

	public Vector2 LineWidthRange;

	public Vector2 LineHeightRange;

	public AnimationCurve WidthCurve;

	public AnimationCurve WidthOverLife;

	public AnimationCurve HeightCurve;

	public float HeightCurvePannerOverlife;

	public AnimationCurve HeightOverLife;

	public Gradient ColorOverLife;

	public Gradient LineColorGradient;

	public float IgnoreAngle;

	public Vector2 LimitRange;

	private List<LineData> m_LineDatas;

	private Stack<LineData> m_LineHandlesPool;

	private Stack<GameObject> m_VFXStartPool;

	private Stack<GameObject> m_VFXEndPool;

	private List<GameObject> m_TempVFXList;

	private float m_UpdateTimer;

	private float m_UpdateTimerTemp;

	private float m_UpdateRate;

	private float m_UpdateTime;

	private int m_FrameIndex;

	private Transform m_LineRoot;

	private Transform m_VFXRoot;

	private GradientColorKey[] m_SharedLineColorKeys;

	private GradientAlphaKey[] m_SharedLineColorAlphaKeys;

	private float m_CachedIgnoreAngle;

	private float m_IgnoreThreshold;

	private SampleMeta[] m_EmitterSampleMetas;

	private SampleMeta[] m_TargetSampleMetas;

	private Transform[] m_CachedEmitterTransforms;

	private Transform[] m_CachedTargetTransforms;

	private VFXSampleCachedPoints[] m_CachedEmitterSamplePoints;

	private VFXSampleCachedPoints[] m_CachedTargetSamplePoints;

	private int m_PointsEmitterLength;

	private int m_PointsTargetLength;

	private int m_LineLength;

	private int m_MaxLineLimit;

	private int m_MaxLineSegmentLimit;

	private bool m_bUseSpawnVFX;

	private int m_MaxSpawnVFXNum;

	private Vector3 startPos;

	private Vector3 endPos;

	private Vector3 startNormal;

	private Vector3 endNormal;

	public bool bBlendHistory;

	private bool UseVFXStartEmitter => false;

	private bool UseVFXEndEmitter => false;

	private float IgnoreThreshold => 0f;

	private void PoolGC()
	{
	}

	private void BuildSamplePointsMeta()
	{
	}

	private void Init()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void CheckSpawnLine(float deltaTime)
	{
	}

	private void SpawnLine()
	{
	}

	private void SpawnVFX(ref LineData lineData)
	{
	}

	private IEnumerator VFXGC(GameObject vfx, bool isStartVFX)
	{
		return null;
	}

	private void UpdateLinePosition(ref LineData lineData, bool bInitialize = false)
	{
	}

	private void UpdateLineOverLifetime(ref LineData lineData)
	{
	}

	private void UpdateLines(float deltaTime)
	{
	}

	private void KillLine(int i, ref LineData lineData)
	{
	}

	private void Update()
	{
	}
}
