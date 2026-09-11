using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCLogicEntityBridgingBase : IUGCLogicEntityBridging
{
	protected SceneEditObjectBase m_EditObj;

	protected UGCLogicEntity m_UGCLogicEntity;

	public virtual SceneEditObjectBase EditObj => null;

	public virtual bool Init(string entityID, SceneEditObjectBase editObj, long[] componentIDs)
	{
		return false;
	}

	public virtual void AddCustomProp(long propID, UGCVarValueDataV2 value)
	{
	}

	public virtual void RemoveCustomProp(long propID)
	{
	}

	public virtual void Destroy()
	{
	}

	protected virtual void OnEntityDataChange(long propID, UGCSimpleValue value)
	{
	}

	protected virtual void SetRepItem(long propID, UGCSimpleValue value, bool isManullyChanged = true)
	{
	}

	public virtual void ManuallyApplyPropToEditObj(long propID, bool isManullyChanged = true)
	{
	}

	public virtual void ManualApplyAllDataStorePropsToEditObj(bool isManullyChanged = true)
	{
	}

	private Transform GetTargetParentTransform(string parentEntityId)
	{
		return null;
	}

	private SceneEditObjectBase FindSceneEditObjectByEntityId(string entityId)
	{
		return null;
	}
}
