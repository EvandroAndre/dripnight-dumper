using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public class UMADefaultMeshCombiner : UMAMeshCombiner
{
	protected List<SkinnedMeshCombiner.CombineInstance> combinedMeshList;

	protected List<SkinnedMeshCombiner.CombineInstance> combinedMeshListPool;

	protected Material[] combinedMaterialList;

	protected const int MaxCacheMatArrayLength = 10;

	protected Material[][] cachedMatArrays;

	private int atlasResolution;

	public static int MAX_VERT_NUM;

	public static int MAX_VERT_NUM_LOWMEM;

	private static List<Vector3> verticesList;

	private static List<Vector4> tangentsList;

	private static List<Vector3> normalsList;

	private static List<Vector2> uvList;

	private static List<Vector2> uv2List;

	private static List<Color32> vertColorList;

	private static List<List<int>> trianglesList;

	private static BoneWeight[] boneWeightsCache;

	private static BoneWeight[] emptyBoneWeights;

	private static BoneWeight2[] boneWeights2Cache;

	private static BoneWeight2[] emptyBoneWeights2;

	private string useSpecialUVShaderName;

	private string noTangentShaderName;

	public static bool OptGc;

	private static UMAMeshDataForBuild s_SharedUMAMeshData;

	public void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static int GetMaxTriangleNum()
	{
		return 0;
	}

	protected void EnsureUMADataSetup(UMAData umaData)
	{
	}

	public override void UpdateUMAMesh(bool updatedAtlas, UMAData umaData, int atlasResolution)
	{
	}

	protected void BuildCombineInstances(UMAData umaData)
	{
	}

	protected bool NeedTangent(UMAData umaData)
	{
		return false;
	}

	protected void RecalculateUV(UMAMeshData umaMesh, UMAData umaData, ref List<Vector2> uv2List)
	{
	}
}
