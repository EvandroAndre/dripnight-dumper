using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public class UMAMeshDataForBuild : UMAMeshData
{
	public List<int> boneNameHashesList;

	public List<Matrix4x4> bindPosesList;

	private static int[] s_EmptyTris;

	private static Vector3[] s_EmptyVerts;

	private static Vector2[] s_WarmupVect2;

	private static Vector3[] s_WarmupVect3;

	private static Vector4[] s_WarmupVect4;

	private static Color32[] s_WamupColor32;

	private static BoneWeight[] s_WarmupBoneWeight;

	private static BoneWeight2[] s_WarmupBoneWeight2;

	public void ApplyDataToUnityMesh(SkinnedMeshRenderer renderer, UMASkeleton skeleton, List<Vector3> verticesList, List<Vector4> tangentsList, List<Vector3> normalsList, List<Vector2> uvList, List<Vector2> uv2List, List<Color32> vertColorList, bool isBone2)
	{
	}

	public void ApplySharedMesh(UMAData umaData)
	{
	}

	private void CreateTransforms(UMASkeleton skeleton)
	{
	}

	private bool OwnSharedBuffers()
	{
		return false;
	}

	private void ApplySharedBuffers(Mesh mesh)
	{
	}

	public bool ClaimSharedBuffers()
	{
		return false;
	}

	public void ReleaseSharedBuffers()
	{
	}
}
