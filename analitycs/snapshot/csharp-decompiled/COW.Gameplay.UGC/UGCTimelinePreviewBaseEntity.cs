using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using message;

namespace COW.Gameplay.UGC;

public class UGCTimelinePreviewBaseEntity : IUGCTimelinePreviewEntity
{
	protected UGCRuntime m_UGCRuntime;

	protected string m_EntityID;

	protected UGCLogicEntity m_UGCLogicEntity;

	protected INAMDLOFOHF m_EditorEntityData;

	protected SceneEditObjectAttrBase m_ObjAttr;

	protected SceneEditObjectBase m_EditObj;

	protected Dictionary<long, IUGCValue> m_PreviewInitRepItemMap;

	protected bool m_Registered;

	public virtual bool Init(UGCRuntime ugcRuntime, string entityID)
	{
		return false;
	}

	public virtual void Destroy()
	{
	}

	public virtual IUGCValue GetPreviewRepItemData(long propId)
	{
		return null;
	}

	public void RestoreRepItemModify()
	{
	}

	public void RestoreRepItemModifyByPropID(long propID)
	{
	}

	protected virtual void OnUGCEntityRepChange(long propId, UGCSimpleValue value)
	{
	}
}
