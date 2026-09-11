using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class Batch
{
	private bool _003CIsDirty_003Ek__BackingField;

	private int _003CTrangleCount_003Ek__BackingField;

	private int _003CVertexCount_003Ek__BackingField;

	private bool _003CIsStatic_003Ek__BackingField;

	private int _003CBatchID_003Ek__BackingField;

	private Material m_CombinedMaterial;

	private MeshData m_CombinedMeshData;

	private IShaderConverter m_ShaderConverter;

	internal Dictionary<int, MeshData> m_InstanceID2MeshData;

	private Mesh m_Mesh;

	private int m_EmptySize;

	internal bool IsDirty
	{
		get
		{
			return _003CIsDirty_003Ek__BackingField;
		}
		private set
		{
			_003CIsDirty_003Ek__BackingField = value;
		}
	}

	internal int TrangleCount
	{
		get
		{
			return _003CTrangleCount_003Ek__BackingField;
		}
		private set
		{
			_003CTrangleCount_003Ek__BackingField = value;
		}
	}

	internal int VertexCount
	{
		get
		{
			return _003CVertexCount_003Ek__BackingField;
		}
		private set
		{
			_003CVertexCount_003Ek__BackingField = value;
		}
	}

	internal bool IsStatic
	{
		get
		{
			return _003CIsStatic_003Ek__BackingField;
		}
		private set
		{
			_003CIsStatic_003Ek__BackingField = value;
		}
	}

	internal int BatchID
	{
		get
		{
			return _003CBatchID_003Ek__BackingField;
		}
		private set
		{
			_003CBatchID_003Ek__BackingField = value;
		}
	}

	internal bool Initialize(IShaderConverter shaderConverter, Dictionary<int, Texture> textures, Material material, bool isStatic, int batchID)
	{
		return false;
	}

	internal void Clear()
	{
	}

	private void CreateMesh(uint flag)
	{
	}

	internal int GetCount()
	{
		return 0;
	}

	internal bool IsInBatch(int instanceID)
	{
		return false;
	}

	internal IEnumerable<int> GetInstanceIDs()
	{
		return null;
	}

	internal Mesh GetMesh()
	{
		return null;
	}

	internal Material GetPreZMaterial()
	{
		return null;
	}

	internal Material GetMaterial()
	{
		return null;
	}

	internal bool TryAdd(int instanceID, Mesh mesh, MaterialPropertyBlock materialPropertyBlock, Material material, Transform transform)
	{
		return false;
	}

	internal bool Remove(int instanceID)
	{
		return false;
	}

	private void ClearMeshData(MeshData meshData)
	{
	}

	internal void ChangeTransform(int instanceID, Matrix4x4 localToWorldMatrix)
	{
	}

	internal void ChangeMaterial(int instanceID, MaterialPropertyBlock materialPropertyBlock, Material material, Transform transform)
	{
	}

	internal void ChangeMesh(int instanceID, Mesh mesh)
	{
	}

	private void RearrangeEmpty()
	{
	}

	private void CopyListToList<T>(List<T> src, List<T> dst, int start, int end)
	{
	}

	private void CopyValueToList<T>(List<T> src, T value, int start, int end)
	{
	}

	private void CopyInitializeVertexData(MeshData meshData)
	{
	}

	internal void RefreshCombinedMeshData()
	{
	}

	internal void MarkNoLongerReadable()
	{
	}

	internal void CheckRearrangeEmpty()
	{
	}

	internal void Update()
	{
	}
}
