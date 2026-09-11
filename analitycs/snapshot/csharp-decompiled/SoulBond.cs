using System.Collections.Generic;
using UnityEngine;

public class SoulBond : MonoBehaviour
{
	public const int MAXREFREHFRAMECOUNT = 200;

	public GameObject AnchorGameObject;

	public int Interpolation;

	private bool UseLocalPosition;

	public List<Transform> LinePoints;

	public List<AnchorPoint> AnchorPoints;

	public List<ControlPair> ControlPoints;

	public List<RandomVertexRecorder> RandomPoints;

	private LineRenderer m_lineRenderer;

	private readonly List<Transform> m_linePoints;

	private readonly List<ControlPair> m_controlPoints;

	private Vector3[] m_pointArray;

	private Vector3[] m_ditherArray;

	private Vector3[] m_traingles;

	private Dictionary<int, Vector3[]> m_RandomVertexs;

	private Dictionary<int, int[]> m_RandomTriangles;

	public bool Edit;

	public bool Curve;

	public bool Dither;

	public float PointMaxSpeed;

	public float PointMaxDrift;

	public int CurrentMidPointIndex;

	public int ReFreshFrameCount;

	private Vector3 m_ditherUnitSpeed;

	private Vector3 m_currentPointOffset;

	private int m_frameCountForRandom;

	private Transform CachedTransform;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void DrawStraight()
	{
	}

	private void DrawDither()
	{
	}

	private void DrawCurve()
	{
	}

	private Vector3 GetLinePoints(int index, bool isLessThanSet)
	{
		return default(Vector3);
	}

	private Vector3 RandomMeshPoint(int index)
	{
		return default(Vector3);
	}
}
