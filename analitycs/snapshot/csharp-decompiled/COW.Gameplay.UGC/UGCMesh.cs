using System.Collections.Generic;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCMesh : UGCResource
{
	private enum ENLODMeshVersion
	{
		first,
		withColliderLodIndex
	}

	private bool m_isCustomMesh;

	private Mesh m_unityMesh;

	private List<Mesh> m_lodMeshes;

	private int m_lodMeshLogicSizeType;

	private int m_colliderLodMeshIndex;

	private string[] m_skinnedMeshBones;

	private static float[][] ms_lodConfigs;

	public int LodMeshCount => 0;

	public bool IsSkinnedMesh => false;

	public Mesh GetMesh()
	{
		return null;
	}

	public Mesh GetColliderMesh()
	{
		return null;
	}

	public string[] GetBones()
	{
		return null;
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	private void loadMeshFromData(byte[] data)
	{
	}

	private void loadLODMeshFromData(byte[] data, int index)
	{
	}

	private void loadNormalMeshFromData(byte[] data)
	{
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	public override void ReleaseUnityResRef()
	{
	}

	public void UpdateOrBuildLodGroupIfNeed(MeshRenderer originMeshRenderer)
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}

	public void _003C_003EiFixBaseProxy_ReleaseUnityResRef()
	{
	}
}
