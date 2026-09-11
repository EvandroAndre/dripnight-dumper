using System;
using System.Collections.Generic;
using UnityEngine;

namespace UMA;

[Serializable]
public class UMAMeshData
{
	public Matrix4x4[] bindPoses;

	public UMABoneWeight[] boneWeights;

	public BoneWeight[] unityBoneWeights;

	[NonSerialized]
	public BoneWeight2[] unity3PBoneWeights;

	public Vector3[] vertices;

	public Vector4[] tangents;

	public Vector3[] normals;

	public Color32[] colors32;

	public Vector2[] uv;

	public Vector2[] uv2;

	public Vector2[] uv3;

	public Vector2[] uv4;

	public UMABlendShape[] blendShapes;

	public SubMeshTriangles[] submeshes;

	[NonSerialized]
	public Transform[] bones;

	[NonSerialized]
	public Transform rootBone;

	public UMATransform[] umaBones;

	public int umaBoneCount;

	public int rootBoneHash;

	public int[] boneNameHashes;

	public int subMeshCount;

	public int vertexCount;

	public string RootBoneName;

	public bool optimized;

	public uint[] optimizeduv;

	public OptimizedBoneWeight[] optimizedBoneWeights;

	public OptimizedBoneWeightV2[] optimizedBoneWeightsV2;

	public uint[] optimizedTangents;

	public uint[] optimizedNormals;

	public uint[] optimizeduv2;

	public byte[] optimizedVertArray;

	public byte[] optimizedNormalArray;

	public byte[] optimizedUVArray;

	public byte[] optimizedBoneWeightArray;

	public SubMeshTrianglesNew[] optimizedSubMeshArray;

	public byte[] optimizedCompressNormalArray;

	public byte[] optimizedCompressTangentArray;

	public byte[] optimizedCompressTangentArrayW;

	public byte[] optimized3PBoneWeightArray;

	[NonSerialized]
	public const int EXTRA_BONE_INDEX = 46;

	[NonSerialized]
	private Dictionary<int, int> BoneNameHashDict;

	[NonSerialized]
	private Dictionary<int, Matrix4x4> BindPoseDict;

	[NonSerialized]
	private Dictionary<int, UMATransform> BonesDict;

	public Matrix4x4[] extraBindPoses;

	public int[] extraBoneNameHashes;

	public UMATransform[] extraBones;

	public bool isMale;

	public bool UseShareBones()
	{
		return false;
	}

	public int[] GetBoneHashs()
	{
		return null;
	}

	public Matrix4x4[] GetBonePoses()
	{
		return null;
	}

	public UMATransform[] GetUMABones()
	{
		return null;
	}

	public void PrepareVertexBuffers(int size)
	{
	}

	private BoneWeight2[] GetBoneWeights2()
	{
		return null;
	}

	private BoneWeight[] GetBoneWeights()
	{
		return null;
	}

	public Vector3[] GetNormals()
	{
		return null;
	}

	public Vector3[] GetVertices()
	{
		return null;
	}

	public void GetVerticesNew(ref Vector3[] dest, int destIndex)
	{
	}

	public void GetVerticesNew(List<Vector3> dest, int destIndex)
	{
	}

	public Vector3[] GetNormalNew()
	{
		return null;
	}

	public void GetNormalNew(List<Vector3> dest)
	{
	}

	public Vector2[] GetUVNew()
	{
		return null;
	}

	public void GetUVNew(List<Vector2> dest)
	{
	}

	public Vector2[] GetUV2New()
	{
		return null;
	}

	public void GetUV2New(List<Vector2> dest)
	{
	}

	public BoneWeight2[] GetBoneWeight2New()
	{
		return null;
	}

	public BoneWeight[] Get3PBoneWeightNewOpt()
	{
		return null;
	}

	public BoneWeight[] GetBoneWeightNew()
	{
		return null;
	}

	public SubMeshTriangles[] GetSubMesh()
	{
		return null;
	}

	public SubMeshTriangles[] GetSubMeshNew()
	{
		return null;
	}

	public bool HasUV()
	{
		return false;
	}

	public bool HasUV2()
	{
		return false;
	}

	public bool HasColor32()
	{
		return false;
	}

	public Vector2[] GetUvs()
	{
		return null;
	}

	public Vector2[] GetUv2s()
	{
		return null;
	}

	public bool HasNormals()
	{
		return false;
	}

	public bool HasTangents()
	{
		return false;
	}

	public Vector4[] GetTangents()
	{
		return null;
	}

	public static implicit operator bool(UMAMeshData obj)
	{
		return false;
	}

	public bool Equals(UMAMeshData other)
	{
		return false;
	}

	public override bool Equals(object other)
	{
		return false;
	}

	public static bool operator ==(UMAMeshData overlay, UMAMeshData obj)
	{
		return false;
	}

	public static bool operator !=(UMAMeshData overlay, UMAMeshData obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
