using System;
using UnityEngine;

namespace GCommon;

public class ReusableObject : MonoBehaviour
{
	private ResourceID _ResID;

	private uint m_DelayCallTicket;

	private Action m_DoRecycle;

	private IReusableObjectOwner _003COwnerEntity_003Ek__BackingField;

	private bool m_IsInPool;

	private Action m_ReleaseSuccess;

	public ResourceID ResID
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public IReusableObjectOwner OwnerEntity
	{
		get
		{
			return _003COwnerEntity_003Ek__BackingField;
		}
		set
		{
			_003COwnerEntity_003Ek__BackingField = value;
		}
	}

	public bool IsInPool => false;

	public override string ToString()
	{
		return null;
	}

	public virtual void Prepare()
	{
	}

	public void Recycle(float delayTime = 0f)
	{
	}

	public void TemporyStopUsing()
	{
	}

	public void OnDestroy()
	{
	}

	protected virtual void DoRecycle()
	{
	}

	public void BindReleaseSuccessCallback(Action recycleSuccess)
	{
	}

	public void AddReleaseSuccessCallback(Action recycleSuccess)
	{
	}

	public void UnbindReleaseSuccessCallback()
	{
	}

	private void NotifyReleaseSuccess()
	{
	}
}
