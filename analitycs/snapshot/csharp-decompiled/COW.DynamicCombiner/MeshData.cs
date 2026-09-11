using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class MeshData
{
	internal KeyValuePair<int, int> TrangleStartEnd;

	internal KeyValuePair<int, int> VertexStartEnd;

	internal List<int> Trangles;

	internal List<Vector3> Verticles;

	internal List<Vector3> Normals;

	internal List<Vector4> Tangents;

	internal List<Color> Colors;

	internal Dictionary<int, List<Vector4>> UVs;

	internal Dictionary<int, Vector4> MaterialPropertys;

	internal Matrix4x4 LocalToWorldMatrix;

	private uint m_VertexAttributeFlag;

	private uint m_MeshDataDirtyFlag;

	private uint m_VertexAttributeDirtyFlag;

	internal void Initialize(uint flag, int trianglesCount, int vertexCount, Matrix4x4 localToWorldMatrix)
	{
	}

	internal void ExtractRawMeshData(Mesh mesh)
	{
	}

	internal void Clear()
	{
	}

	internal bool CalcuIsNonUniformScale()
	{
		return false;
	}

	internal List<Vector4> GetUV(VertexAttribute type)
	{
		return null;
	}

	internal int GetUVIndex(VertexAttribute type)
	{
		return 0;
	}

	internal bool HasVertexAttribute(VertexAttribute type)
	{
		return false;
	}

	internal bool IsMeshDataDirty(MeshDataDitry type)
	{
		return false;
	}

	internal void MarkMeshDataDirty(MeshDataDitry type)
	{
	}

	internal bool IsVertexAttributeDirty(VertexAttribute type)
	{
		return false;
	}

	internal void MarkVertexAttributeDirty(VertexAttribute type)
	{
	}
}
