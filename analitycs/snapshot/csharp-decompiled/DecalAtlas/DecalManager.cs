using System;
using System.Collections.Generic;
using UnityEngine;

namespace DecalAtlas;

public class DecalManager : MonoBehaviour
{
	public Rect TerrainRect;

	public GranularityDatum[] GranularityData;

	public ProjectionDecalGroup[] ProjectionDecalGroups;

	public QuadDecalGroup[] QuadDecalGroups;

	[NonSerialized]
	public Dictionary<int, DecalDatum> EditorData;

	private int _SwapDataIndex;

	[NonSerialized]
	public Vector2[] CameraTriangles;

	public Camera _Camera;

	private Vector3 cameraPosition;

	private Vector2 cameraForward;

	private float halfHorizontalCos;

	private Vector3 _LastCameraForward;

	private Vector3 _LastCameraPosition;

	private readonly Vector3 _midDown;

	private readonly List<Vector2> _3Points;

	private readonly List<Vector2> _4Points;

	private List<Vector2> _Points;

	private Vector3 cameraForward3D;

	public bool camLookingDown;

	private bool camLookingBack;

	private float leftRightScale;

	private int distanceIndex;

	public int SwapDataIndex => 0;

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	private void _UpdateCameraData()
	{
	}

	public void _UpdateCellVisiblity()
	{
	}

	private void SortByCamDistance(ref List<Vector2Int> cells, int mid, Vector2Int camCoord)
	{
	}

	private int DistanceSqr(Vector2Int p0, Vector2Int p1)
	{
		return 0;
	}

	public bool IsInTrapezoid(ref Vector2 position, ref Vector2 v0, ref Vector2 v1, ref Vector2 v2, ref Vector2 v3)
	{
		return false;
	}

	public bool IsGOVisible(Vector2 point)
	{
		return false;
	}
}
