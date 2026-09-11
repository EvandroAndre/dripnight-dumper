using System.Collections.Generic;
using UnityEngine;

namespace COW.DynamicCombiner;

internal class Allocator
{
	private List<List<int>> m_IntLists;

	private List<List<Vector3>> m_Vector3Lists;

	private List<List<Vector4>> m_Vector4Lists;

	private List<List<Color>> m_ColorLists;

	private List<Dictionary<int, List<Vector4>>> m_Vector4Dics;

	private List<MeshData> m_MeshDatas;

	private List<Dictionary<int, MeshData>> m_MeshDataDics;

	private List<Dictionary<int, Texture>> m_TextureDics;

	private Dictionary<string, List<Material>> m_Materials;

	private List<Dictionary<int, Vector4>> m_MaterialProperties;

	public void Clear()
	{
	}

	public List<int> CreateIntList(int capacity)
	{
		return null;
	}

	public void DestroyIntList(List<int> temp)
	{
	}

	public List<Vector3> CreateVector3List(int capacity)
	{
		return null;
	}

	public void DestroyVector3List(List<Vector3> temp)
	{
	}

	public List<Vector4> CreateVector4List(int capacity)
	{
		return null;
	}

	public void DestroyVector4List(List<Vector4> temp)
	{
	}

	public List<Color> CreateColorList(int capacity)
	{
		return null;
	}

	public void DestroyColorList(List<Color> temp)
	{
	}

	public Dictionary<int, List<Vector4>> CreateVector4Dic(int capacity)
	{
		return null;
	}

	public void DestroyVector4Dic(Dictionary<int, List<Vector4>> temp)
	{
	}

	public MeshData CreateMeshData()
	{
		return null;
	}

	public void DestroyMeshData(MeshData temp)
	{
	}

	public Dictionary<int, MeshData> CreateMeshDataDicList(int capacity)
	{
		return null;
	}

	public void DestroyMeshDataDicList(Dictionary<int, MeshData> temp)
	{
	}

	public Material CreateMaterial(Shader shader)
	{
		return null;
	}

	public void DestroyMaterial(Material temp)
	{
	}

	public Dictionary<int, Vector4> CreateMaterialProperyDic(int capacity)
	{
		return null;
	}

	public void DestroyMaterialProperyDic(Dictionary<int, Vector4> temp)
	{
	}
}
