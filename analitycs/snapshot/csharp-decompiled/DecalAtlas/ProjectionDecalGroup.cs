using System;
using System.Collections.Generic;
using UnityEngine;

namespace DecalAtlas;

public class ProjectionDecalGroup : DecalGroup
{
	[Serializable]
	public class DecalData
	{
		public Vector4[] MainTexRects;

		public Matrix4x4[] TransformLocalToWorlds;

		public Vector4[] RendererWorldToLocalRows;
	}

	private static readonly Vector4[] VERTICES;

	private static readonly int[] TRIANGLES;

	private List<Vector3> _RuntimeMeshVertices;

	private List<int> _RuntimeMeshTriangles;

	private List<Vector4> _RuntimeMainTexRects;

	private List<Vector4> _RuntimeWorldToLocalRow0;

	private List<Vector4> _RuntimeWorldToLocalRow1;

	private List<Vector4> _RuntimeWorldToLocalRow2;

	public DecalData PersistDecals;

	protected override void Start()
	{
	}

	public override void DrawDecalMesh()
	{
	}

	protected override void UpdateDecalMesh(int swapDataIndex)
	{
	}
}
