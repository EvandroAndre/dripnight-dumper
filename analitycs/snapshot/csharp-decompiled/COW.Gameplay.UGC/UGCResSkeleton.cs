using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCResSkeleton : UGCResource
{
	private GameObject m_unitySkeleton;

	protected CJEKFIPLFEG m_resSkeletonData;

	public override bool LoadFromData(byte[] data)
	{
		return false;
	}

	public override void OnUnityObjectLoaded(bool isSucc, Object resObject)
	{
	}

	public GameObject BuildGameObject(GameObject skeletonObj, Dictionary<string, Transform> outBoneNameMap, Dictionary<string, Transform> forceUseBone = null)
	{
		return null;
	}

	public void MergeSkeleton(GameObject skeletonObj, Dictionary<string, Transform> outBoneNameMap, Dictionary<string, Transform> forceUseBone)
	{
	}

	private void MakeBoneGameObject(ICMEEFDFGPP boneData, Transform parent, Dictionary<string, Transform> outBoneNameMap, Dictionary<string, Transform> forceUseBone = null)
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
