using System;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;

namespace COW.Gameplay.UGC;

public class UGCSkeletonBoneOwner
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UGCSkeletonPartController> _003C_003E9__19_0;

		internal int _003CsortControllerList_003Eb__19_0(UGCSkeletonPartController a, UGCSkeletonPartController b)
		{
			return 0;
		}
	}

	public UGCSkeletonControlImpl MonoImpl;

	public List<UGCSkeletonPartController> ControllerList;

	public List<UGCSkeletonBone> BoneList;

	public List<UGCSkeletonBone> BoneUpdateList;

	private bool m_isRebindBoneTransform;

	public EntityIndex OwnerEntityIndex;

	public string OwnerEntityID;

	public UGCEntityDataStore DataStore;

	public void RemoveFromUpdateList(UGCSkeletonBone bone)
	{
	}

	public void AddToUpdateList(UGCSkeletonBone bone)
	{
	}

	public void LateUpdate()
	{
	}

	public void InitWithGameObject(GameObject go)
	{
	}

	public static UGCSkeletonBoneOwner GetFromGameObject(GameObject go)
	{
		return null;
	}

	public static void UpdateSkeletonControlExtTransform(GameObject obj, Transform trans)
	{
	}

	public static UGCSkeletonBoneOwner GetOrCreateFromGameObject(GameObject go)
	{
		return null;
	}

	public UGCSkeletonBone GetOrAddBone(string boneName)
	{
		return null;
	}

	public void AddBoneController(UGCSkeletonPartController controller)
	{
	}

	public UGCSkeletonBone GetSkeletonBone(string boneName)
	{
		return null;
	}

	public void ClearAllPriorityBoneLocalScale(UGCSkeletonBone.EBoneControlPriority priority)
	{
	}

	public void EasySetBoneLocalScale(string boneName, Vector3 scale, UGCSkeletonBone.EBoneControlPriority priority = UGCSkeletonBone.EBoneControlPriority.property)
	{
	}

	public void RebindBoneTransform(Transform extTransform = null)
	{
	}

	protected void rebindAllBoneTransform()
	{
	}

	private void sortControllerList()
	{
	}

	public static UGCSkeletonBoneOwner TryFindFromUGCEntity(UGCRuntime ugcRuntime, string entityID)
	{
		return null;
	}

	public void AttachUGCEntity(UGCRuntime ugcRuntime, string entityID)
	{
	}

	public void OnDestroy()
	{
	}
}
