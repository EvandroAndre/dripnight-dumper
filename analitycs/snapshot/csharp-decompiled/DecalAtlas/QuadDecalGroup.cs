using System.Collections.Generic;
using UnityEngine;

namespace DecalAtlas;

public class QuadDecalGroup : DecalGroup
{
	private static readonly Vector4[] VERTICES;

	private static readonly Vector4 Normal;

	private static readonly Vector2[] UVS;

	private static readonly int[] TRIANGLES;

	public List<int> RectIndexes;

	private List<Vector3> _RuntimeMeshVertices;

	private List<Vector3> _RuntimeMeshNormals;

	private List<int> _RuntimeMeshTriangles;

	private List<Vector2> _RuntimeMainTexUVs;

	private List<Vector2> _UVArray;

	private List<Vector3> _NormalArray;

	private List<Vector3> _VerticesArray;

	private int decalNumLimit;

	private readonly Vector3 farPos;

	protected override void Start()
	{
	}

	private void InitRuntimeContainer()
	{
	}

	protected override void UpdateDecalMesh(int swapDataIndex)
	{
	}

	public override void DrawDecalMesh()
	{
	}

	private void UpdateMesh(int swapDataIndex)
	{
	}
}
