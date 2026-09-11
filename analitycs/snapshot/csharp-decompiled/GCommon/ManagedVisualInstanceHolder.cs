using UnityEngine;

namespace GCommon;

public sealed class ManagedVisualInstanceHolder : VisualInstanceHolder, IObjectPoolCallback
{
	public delegate void OnManagedInstanceAttached(uint uniqueID, ResourceID vfxResID, GameObject instance);

	public delegate void OnInstanceFailed(uint uniqueID, ResourceID vfxRedID);

	private bool m_InPool;

	private uint m_UniqueID;

	private uint m_VisibilityMask;

	private EntityVisualEffectManager m_Manager;

	private OnManagedInstanceAttached m_OnManagedInstanceAttached;

	private OnInstanceFailed m_OnFailedAttached;

	public uint UniqueID => 0u;

	public bool ActiveSelf => false;

	public uint VisibilityMask => 0u;

	public ManagedVisualInstanceHolder Init(EntityVisualEffectManager manager, ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, uint visibilityMask, ResourceManager.LoadPriority loadPriority, bool asyncInstantiate = false)
	{
		return null;
	}

	public ManagedVisualInstanceHolder WithInstanceAttachedCallback(OnManagedInstanceAttached callback, OnInstanceFailed failedCallBack = null)
	{
		return null;
	}

	public void BindUniqueID(uint uniqueID)
	{
	}

	protected override void OnTakeFromPool()
	{
	}

	protected override void OnReturnToPool()
	{
	}

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

	protected override bool IsActive()
	{
		return false;
	}

	protected override void AutoReleaseOnLimitedLifetimeEnded()
	{
	}

	protected override void AfterInstanceExternalReleased()
	{
	}

	protected override bool IsAttachedCallbackAssigned()
	{
		return false;
	}

	protected override void InvokeCallbackAfterInstantiateForAsyncLoad()
	{
	}

	protected override void InvokeFailedLoadCallBackForAsyncLoad()
	{
	}

	protected override void InvokeCallbackAfterInstantiateForSyncLoad()
	{
	}

	public override void SetActive(bool activeSelf)
	{
	}

	public void SetLocalTransformToDefault()
	{
	}

	public bool IsMaskAssigned()
	{
		return false;
	}

	public bool Load()
	{
		return false;
	}

	public void OnHostVisibilityChanged(bool relativelyVisible)
	{
	}
}
