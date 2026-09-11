using System.Collections.Generic;
using UnityEngine;

namespace UMA;

public static class SkinnedMeshCombiner
{
	public class CombineInstance
	{
		public UMAMeshData meshData;

		public List<int> targetSubmeshIndices;

		public void Clear()
		{
		}
	}

	private enum MeshComponents
	{
		none = 0,
		has_normals = 1,
		has_tangents = 2,
		has_colors32 = 4,
		has_uv = 8,
		has_uv2 = 0x10,
		has_uv3 = 0x20,
		has_uv4 = 0x40,
		has_blendShapes = 0x80
	}

	private class BoneIndexEntry
	{
		public int index;

		public List<int> indices;

		public int Count => 0;

		// C# has no syntax for parameterized property 'Item'.
		public int get_Item(int idx)
		{
			return 0;
		}

		internal void AddIndex(int idx)
		{
		}

		public void Clear()
		{
		}
	}

	public static bool m_enableNewUMABuild;

	public static Color32 m_defaultColor;

	private static Dictionary<int, BoneIndexEntry> bonesCollection;

	private static List<Matrix4x4> bindPoses;

	private static List<int> bonesList;

	private static List<int> s_SubMeshTrisCnt;

	public static bool OptGc;

	private static List<BoneIndexEntry> s_BoneIndexEntryPool;

	private static int s_BoneIndexEntryPoolUsedCnt;

	private static int[] s_nonSharedBoneMapping;

	private static int[] s_sharedBoneMapping;

	public static void BuildBones(UMAMeshDataForBuild target, List<CombineInstance> sources, bool ignoreBlendShapes = false)
	{
	}

	private static void ResetBoneIndexEntryPool()
	{
	}

	private static BoneIndexEntry AllocBoneIndexEntry()
	{
		return null;
	}

	private static bool UseBoneWeight2(bool isBone2)
	{
		return false;
	}

	public static void CombineMeshes(UMAMeshDataForBuild target, List<CombineInstance> sources, ref List<Vector3> verticesList, ref List<Vector4> tangentsList, ref List<Vector3> normalsList, ref List<Vector2> uvList, ref List<Vector2> uv2List, ref List<List<int>> trianglesList, ref List<Color32> vertColorList, ref BoneWeight[] boneWeightsCache, ref BoneWeight2[] boneWeights2Cache, int maxTriNum, bool ignoreBlendShapes = false, bool needTangent = true, bool isBone2 = false)
	{
	}

	private static void MergeSortedTransforms(UMATransform[] mergedTransforms, ref int len1, UMATransform[] umaTransforms)
	{
	}

	private static void AnalyzeSources(List<CombineInstance> sources, List<int> subMeshTriangleLength, int subMeshCnt, ref int vertexCount, ref int bindPoseCount, ref int transformHierarchyCount, ref MeshComponents meshComponents, ref int blendShapeCount)
	{
	}

	private static int FindTargetSubMeshCount(List<CombineInstance> sources)
	{
		return 0;
	}

	private static void BuildBoneWeights(UMAMeshData meshData, int sourceIndex, BoneWeight[] dest, BoneWeight2[] dest2, int destIndex, int count, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList, int[] sharedBoneMapping, int[] nonSharedBoneMapping)
	{
	}

	public static bool CompareSkinningMatrices(ref Matrix4x4 m1, ref Matrix4x4 m2)
	{
		return false;
	}

	private static int TranslateBoneIndex(int index, int[] bonesHashes, Matrix4x4[] bindPoses, Dictionary<int, BoneIndexEntry> bonesCollection, List<Matrix4x4> bindPosesList, List<int> bonesList)
	{
		return 0;
	}

	private static void CopyColorsToColors32(Color[] source, int sourceIndex, Color32[] dest, int destIndex, int count)
	{
	}

	private static void FillArray(Vector4[] array, int index, int count, Vector4 value)
	{
	}

	private static void FillArray(Vector3[] array, int index, int count, Vector3 value)
	{
	}

	private static void FillArray(Vector2[] array, int index, int count, Vector2 value)
	{
	}

	private static void FillArray(Color[] array, int index, int count, Color value)
	{
	}

	private static void FillArray(Color32[] array, int index, int count, Color32 value)
	{
	}

	private static void CopyIntArrayAdd(int[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	private static void CopyIntArrayAdd(int[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, int[] dest, int destIndex, int count, int add)
	{
	}

	private static void CopyByteArrayAdd(byte[] source, int sourceIndex, List<int> dest, int destIndex, int count, int add)
	{
	}

	private static T[] EnsureArrayLength<T>(T[] oldArray, int newLength)
	{
		return null;
	}

	private static void AddSourceUVToDes(int uvIndex, UMAMeshData sourceMeshData, int vertexCount, int vertexIndex, ref List<Vector2> uvList, Vector2[] uv)
	{
	}

	private static void AddSourceUVToDes(int uvIndex, UMAMeshData sourceMeshData, ref List<Vector2> uvList)
	{
	}
}
