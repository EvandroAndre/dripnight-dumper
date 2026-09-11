using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceCollider : UGCResource
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int cacheIndex;

		public UGCResourceCollider _003C_003E4__this;

		internal void _003CLoadFromData_003Eb__0(bool succ, UGCMesh resObj)
		{
		}
	}

	private KANPBOFPDGE m_resColliderData;

	private string[] m_dependencies;

	private UGCMesh[] m_cacheColMesh;

	private static string ImGameObjectName;

	public KANPBOFPDGE ColliderData
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

	protected override void AfterOneDependLoaded()
	{
	}

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public static void BuildGameObject(GameObject obj, List<KJHCKIEJOEF> colList, UGCMesh[] cacheColMesh)
	{
	}

	public void Instantiate(GameObject parentObj)
	{
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	private void UpdateInstantiateGameObject()
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
