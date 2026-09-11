using System;
using System.Collections.Generic;
using UnityEngine;

public class SceneStreamerInfo : MonoBehaviour
{
	[Serializable]
	private class MaterialInfo
	{
		public List<int> TextureMatIDList;

		public List<uint> TextureIndexList;

		public List<Texture> Textures;

		public Material OwnedMat;
	}

	[Serializable]
	private class MeshInfo
	{
		public uint TargetMeshIndex;

		public Mesh TargetMesh;

		public MeshFilter OwnedMeshFilter;
	}

	private List<MaterialInfo> MaterialInfos;

	private List<MeshInfo> MeshInfos;

	[NonSerialized]
	public List<StreamerMeshInfo> OwnedMeshInfos;

	[NonSerialized]
	public List<StreamerTextureInfo> OwnedTextureInfos;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}
}
