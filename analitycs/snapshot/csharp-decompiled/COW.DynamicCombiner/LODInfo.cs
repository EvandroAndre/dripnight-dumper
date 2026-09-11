using UnityEngine;

namespace COW.DynamicCombiner;

public class LODInfo
{
	public GameObject gameObject;

	public LODGroup lodGroup;

	public LOD[] lods;

	public int visibleLOD;

	public MeshFilter[] meshes;

	public Renderer[] renderers;

	public LODInfo(GameObject obj, LODGroup group)
	{
	}
}
