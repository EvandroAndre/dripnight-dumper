using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class UGCSkeletonPartControllerModule : IUGCModule
{
	private UGCRuntime m_ugcRuntime;

	private UGCEntityDataStore m_entityModule;

	private int m_guid;

	private uint m_prevGameTime;

	private Dictionary<string, UGCSkeletonBoneOwner> m_skeletonOwners;

	private Dictionary<string, UGCSkeletonPartController> m_skeletonPartControllerMap;

	public UGCEntityDataStore DataStore => null;

	public UGCSkeletonPartControllerModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void Destroy()
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void OnTickEventHandle()
	{
	}

	public void Update(uint gt)
	{
	}

	public int allocateID()
	{
		return 0;
	}

	public UGCLogicEntity GetOrCreateSkeletonPoint(UGCLogicEntity ownerEntity, string boneName)
	{
		return null;
	}

	public UGCSkeletonBone FindSkeletonPoint(string skeletonPointEntityID)
	{
		return null;
	}

	public UGCSkeletonBoneOwner GetOrCreateSkeletonOwner(string ownerEntityID, GameObject ownerGameObject)
	{
		return null;
	}

	public UGCLogicEntity GetOrCreateSkeletonPoint(string ownerEntityID, string boneName)
	{
		return null;
	}

	public void RemoveSkeletonOwner(UGCSkeletonBoneOwner owner)
	{
	}

	public void RemoveAllSkeletonPoint(string owner)
	{
	}

	public UGCLogicEntity NewLookAt(UGCLogicEntity controlBone, UGCLogicEntity lookAt)
	{
		return null;
	}

	private void OnRemoveLookAtEntity(string entityID)
	{
	}
}
