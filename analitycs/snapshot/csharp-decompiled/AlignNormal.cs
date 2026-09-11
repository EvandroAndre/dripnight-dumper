using System.Collections.Generic;
using UnityEngine;

public class AlignNormal : MonoBehaviour
{
	public float rayLength;

	public LayerMask layerMask;

	public bool useGlobalDirection;

	public Vector3 rayDirection;

	public Vector3 positionOffset;

	public Vector3 raycastPositionOffset;

	public bool isMovable;

	private int SubmeshCount;

	private List<Vector3> localVertices;

	private List<Vector3> localNormal;

	private Mesh mesh;

	private Matrix4x4 cacheLocalToWorld;

	private static readonly List<Vector3> originalVertices;

	private static readonly List<Vector3> originalNormal;

	private static readonly List<Vector2> uv;

	private static readonly int[] triangles;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void OnDestroy()
	{
	}

	private void CreateMesh()
	{
	}

	public void UpdateImp()
	{
	}

	private void CalculateBasisVectors(Vector3 normal, out Vector3 basisx, out Vector3 basisz)
	{
		basisx = default(Vector3);
		basisz = default(Vector3);
	}
}
