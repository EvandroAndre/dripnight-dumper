using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public abstract class UIManagedMapContentIconController : UIBaseController, IObjectPoolCallback
{
	private bool m_IsInPool;

	protected UIMapUtil.EMapType m_MapType;

	public void OnAllocated()
	{
	}

	public void OnCollected()
	{
	}

	public bool IsInPool()
	{
		return false;
	}

	public virtual bool KeepRotationUp()
	{
		return false;
	}

	public virtual bool KeepVisuallyConstantWhenScale()
	{
		return false;
	}

	public void SetLocalPosition(Vector3 localPosition)
	{
	}

	public virtual void SetLocalRotation(Quaternion localRotation)
	{
	}

	public virtual void SetLocalScale(Vector3 localScale)
	{
	}

	public virtual void SetViewData(object viewData)
	{
	}

	public virtual void OnTrackedPlayerChanged(BHGGAEEHJCO trackedPlayer)
	{
	}

	public virtual bool IconBoundsContainsPos(Vector3 position)
	{
		return false;
	}

	protected virtual Bounds? GetIconBounds()
	{
		return null;
	}

	public void SetMapType(UIMapUtil.EMapType mapType)
	{
	}

	protected abstract void RestoreBeforeRecycled();
}
