using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class EntityVisualEffectManager
{
	private enum VisibilityMode : byte
	{
		Boolean,
		BitAndArray
	}

	public const uint InvalidUniqueID = 0u;

	private readonly VisibilityMode m_Mode;

	private uint m_UniqueIDGen;

	private uint m_VisibilityRawValue;

	private Dictionary<uint, ManagedVisualInstanceHolder> m_InstanceHolders;

	private uint NewUniqueID => 0u;

	private EntityVisualEffectManager(VisibilityMode mode, uint visibilityRawValue)
	{
	}

	public static EntityVisualEffectManager CreateManager(bool defaultVisibility)
	{
		return null;
	}

	public static EntityVisualEffectManager CreateManagerWithBitAndArray(uint bitArrayRawValue)
	{
		return null;
	}

	private bool TryGetValueHolder(uint uniqueID, out ManagedVisualInstanceHolder holder)
	{
		holder = null;
		return false;
	}

	private void AddHolder(uint uniqueID, ManagedVisualInstanceHolder holder)
	{
	}

	private bool RemoveHolder(uint uniqueID)
	{
		return false;
	}

	private bool ContainsKeyHolder(uint uniqueID)
	{
		return false;
	}

	private bool IsHostVisibleInternal()
	{
		return false;
	}

	private bool IsRelativelyVisibleInternal(ManagedVisualInstanceHolder holder)
	{
		return false;
	}

	private void OnHostVisibilityChangedInternal(uint visibilityRawValue)
	{
	}

	private bool TryGetInstanceHolder(uint uniqueID, out ManagedVisualInstanceHolder holder)
	{
		holder = null;
		return false;
	}

	private uint AttachInstanceInternal(ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, float lifetimeSecs, uint visibilityMask, ManagedVisualInstanceHolder.OnManagedInstanceAttached instanceAttachedCallback, ResourceManager.LoadPriority loadPriority, ManagedVisualInstanceHolder.OnInstanceFailed failedCallBack = null, bool asyncInstantiate = false)
	{
		return 0u;
	}

	public bool IsRelativelyVisible(ManagedVisualInstanceHolder holder)
	{
		return false;
	}

	public void RemoveHolderOnSelfRelease(uint uniqueID)
	{
	}

	public void ResetUniqueID()
	{
	}

	public bool IsHostVisible()
	{
		return false;
	}

	public bool IsVisualInstanceHolderExisted(uint uniqueID)
	{
		return false;
	}

	public void OnHostVisibilityChanged(bool hostVisible)
	{
	}

	public void OnHostVisibilityChanged(uint hostVisibilityRawValue)
	{
	}

	public uint AttachVisualEffectInstance(ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, ManagedVisualInstanceHolder.OnManagedInstanceAttached instanceAttachedCallback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, ManagedVisualInstanceHolder.OnInstanceFailed instanceFailed = null, bool asyncInstantiate = false)
	{
		return 0u;
	}

	public uint AttachVisualEffectInstanceWithLifetime(ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, float lifetimeSecs, ManagedVisualInstanceHolder.OnManagedInstanceAttached instanceAttachedCallback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, bool asyncInstantiate = false)
	{
		return 0u;
	}

	public uint AttachInstanceWithVisibilityMask(ResourceID resID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, uint visibilityMask, ManagedVisualInstanceHolder.OnManagedInstanceAttached instanceAttachedCallback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, bool asyncInstantiate = false)
	{
		return 0u;
	}

	public uint AttachLifetimeInstanceWithVisibilityMask(ResourceID resID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, float lifetimeSecs, uint visibilityMask, ManagedVisualInstanceHolder.OnManagedInstanceAttached instanceAttachedCallback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, bool asyncInstantiate = false)
	{
		return 0u;
	}

	public bool DetachVisualEffectInstance(uint uniqueID)
	{
		return false;
	}

	public void DetachAnyway(ref uint uniqueID)
	{
	}

	public void DetachAllInstances()
	{
	}

	public bool SetInstanceActive(uint uniqueID, bool active)
	{
		return false;
	}

	public bool SetInstanceLocalPosition(uint uniqueID, Vector3 localPosition)
	{
		return false;
	}

	public bool SetInstanceLocalRotation(uint uniqueID, Quaternion localRotation)
	{
		return false;
	}

	public bool SetInstanceLocalScale(uint uniqueID, Vector3 localScale)
	{
		return false;
	}

	public bool SetInstancePosition(uint uniqueID, Vector3 position)
	{
		return false;
	}

	public bool SetInstanceRotation(uint uniqueID, Quaternion rotation)
	{
		return false;
	}

	public bool PlayParticleSystem(uint uniqueID)
	{
		return false;
	}

	public bool StopParticleSystem(uint uniqueID)
	{
		return false;
	}
}
