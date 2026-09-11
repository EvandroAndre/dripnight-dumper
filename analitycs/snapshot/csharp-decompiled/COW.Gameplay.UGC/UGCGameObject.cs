using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCGameObject : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public int cacheIndex;

		public UGCGameObject _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__2(bool succ, UGCMaterial resObj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public int cacheIndex;

		public UGCGameObject _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__3(bool succ, UGCMesh resObj)
		{
		}
	}

	private UGCMesh mesh;

	private UGCMaterial[] materials;

	private UGCMesh[] m_cacheColMesh;

	private PPLJIECPGIJ m_resSceneMeshData;

	private UGCGameObject m_abResGameObject;

	private string[] m_skinnedMeshBones;

	private string[] m_dependencies;

	private static string ImGameObjectName;

	private Object m_unityObject;

	public bool IsUnityObject => false;

	public PPLJIECPGIJ SceneMesh
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void ClearOtherResDependence()
	{
	}

	private void OnMeshChanged(UGCResource res)
	{
	}

	protected override void AfterOneDependLoaded()
	{
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	private GameObject InstantiateFromCustom()
	{
		return null;
	}

	private void MakeSkinnedBones(SkinnedMeshRenderer skinnedMeshRenderer, Dictionary<string, Transform> boneMap)
	{
	}

	public void BuildGameObject(GameObject obj, Dictionary<string, Transform> boneMap = null)
	{
	}

	public GameObject Instantiate()
	{
		return null;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void UpdateInstantiateGameObject()
	{
	}

	private void _003CLoadFromData_003Eb__15_0(bool succ, UGCGameObject resObj)
	{
	}

	private void _003CLoadFromData_003Eb__15_1(bool succ, UGCMesh resObj)
	{
	}

	public void _003C_003EiFixBaseProxy_AfterOneDependLoaded()
	{
	}

	public bool _003C_003EiFixBaseProxy_LoadFromData(byte[] P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUnityObjectLoaded(bool P0, Object P1)
	{
	}
}
