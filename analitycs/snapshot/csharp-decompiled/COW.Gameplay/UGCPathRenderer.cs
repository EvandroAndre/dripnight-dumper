using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay;

public class UGCPathRenderer : MonoBehaviour
{
	private UGCPathMeshBuilder.MeshType meshType;

	public float pathWidth;

	public float trackWidthScale;

	public Material pathMaterial;

	private Material m_Material;

	private UGCPathMeshBuilder builder;

	private List<Mesh> meshes;

	private List<MeshFilter> meshFilters;

	public UGCPathMeshBuilder.MeshType MeshType
	{
		get
		{
			return UGCPathMeshBuilder.MeshType.Line;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetPath(List<UGCPath> active)
	{
	}

	public void RebuildCombineMesh()
	{
	}

	private void UpdateMeshFilter()
	{
	}

	private void CreateMeshFilter(bool shrink)
	{
	}
}
