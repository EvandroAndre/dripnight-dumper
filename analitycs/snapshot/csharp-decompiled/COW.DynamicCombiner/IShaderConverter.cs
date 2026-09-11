using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.DynamicCombiner;

internal abstract class IShaderConverter
{
	public ResourceID CombinedShaderResID;

	public ResourceID CombinedPreZShaderResID;

	public uint VertexAttributeFlag;

	public uint CombinedVertexAttributeFlag;

	public bool CopyFirstMaterialInBatch;

	public VertexAttribute[] LocalToWorldMatrixRows;

	public VertexAttribute PassNormalOSToVertexAttribute;

	private Material m_PreZMaterial;

	internal abstract void Initialize();

	internal abstract void ExcratProperties(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, Transform transform, ref Dictionary<int, Vector4> output);

	internal Material GetPreZMaterial()
	{
		return null;
	}

	protected float GetFloat(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
	{
		return 0f;
	}

	protected int GetInt(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
	{
		return 0;
	}

	protected Vector4 GetVector(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
	{
		return default(Vector4);
	}

	protected Color GetColor(MaterialPropertyBlock materialPropertyBlock, Material sharedMaterial, int propertyID)
	{
		return default(Color);
	}
}
