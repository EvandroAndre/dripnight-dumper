using System;
using UnityEngine;

namespace GCommon;

public class VisualInstanceHolder
{
	public delegate void OnInstanceAttached(GameObject instance);

	private sealed class _003C_003Ec__DisplayClass54_0
	{
		public VisualInstanceHolder _003C_003E4__this;

		public uint generation;

		internal void _003CStartInstantAsync_003Eb__0(GameObject instance)
		{
		}
	}

	private readonly Action<uint, bool, UnityEngine.Object> m_OnVfxResourceLoaded;

	private readonly Action<uint, bool, UnityEngine.Object> m_OnVfxPoolInstantiated;

	protected ResourceID m_VfxResID;

	private VisualEffectLoadMethod m_LoadMethod;

	private Transform m_NodeTransform;

	private bool m_AsyncInstantiate;

	private bool m_ResetTransform;

	private ResourceManager.LoadPriority m_AsyncLoadPriority;

	private bool m_AutoRelease;

	private float m_LifetimeSecs;

	private OnInstanceAttached m_OnInstanceAttached;

	private bool m_LoadStarted;

	private bool m_LoadSucceed;

	private bool m_ReceivedNullTransform;

	private bool m_HasDisabledReusableComp;

	private bool m_HasBindReusableCallback;

	private bool m_PoolGetFallbackToNonPooled;

	private uint m_InstantAsyncGeneration;

	private uint m_AsyncLoadTicket;

	private uint m_AutoReleaseDelayCallID;

	protected uint m_SyncLoadCallbackDelayCallID;

	protected GameObject m_Instance;

	protected long m_PropertyStatus;

	protected bool m_ActiveSelf;

	private Vector3 m_LocalPosition;

	private Quaternion m_LocalRotation;

	private Vector3 m_LocalScale;

	private Vector3 m_Position;

	private Quaternion m_Rotation;

	public ResourceID VfxResID => default(ResourceID);

	public bool IsLoadStarted => false;

	public bool IsInstanceAlive => false;

	protected VisualInstanceHolder Init(ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, ResourceManager.LoadPriority loadPriority, bool asyncInstantiate = false)
	{
		return null;
	}

	public VisualInstanceHolder WithInstanceAttachedCallback(OnInstanceAttached callback)
	{
		return null;
	}

	public void StartLimitedLifetime(float lifetimeSecs)
	{
	}

	protected virtual void OnTakeFromPool()
	{
	}

	protected virtual void OnReturnToPool()
	{
	}

	private void TryCancelAutoReleaseDelayCall()
	{
	}

	protected virtual void AutoReleaseOnLimitedLifetimeEnded()
	{
	}

	private void StartLimitedLifetimeInternal()
	{
	}

	protected virtual void AfterInstanceExternalReleased()
	{
	}

	private void RecoverReusableOnRelease(ReusableObject reusableComp)
	{
	}

	protected virtual bool IsAttachedCallbackAssigned()
	{
		return false;
	}

	protected virtual void InvokeCallbackAfterInstantiateForAsyncLoad()
	{
	}

	protected virtual void InvokeFailedLoadCallBackForAsyncLoad()
	{
	}

	protected virtual void InvokeCallbackAfterInstantiateForSyncLoad()
	{
	}

	private void TryCancelSyncLoadCallbackDelayCall()
	{
	}

	private void HandleCallbackAfterInstantiate()
	{
	}

	private void CleanUpAfterInstanceReleased()
	{
	}

	private void AfterInstantiate()
	{
	}

	private bool SyncGetVfxInstance()
	{
		return false;
	}

	private bool SyncPoolGetVfxInstance()
	{
		return false;
	}

	private bool AsyncGetVfxInstance()
	{
		return false;
	}

	private bool AsyncPoolGetVfxInstance()
	{
		return false;
	}

	private void LogDetailsForAsyncGetTicketMismatched(uint savedTicket, uint receivedTicket, string resName, UnityEngine.Object resource)
	{
	}

	private void OnVfxResourceLoaded(uint ticket, bool success, UnityEngine.Object resource)
	{
	}

	private void StartInstantAsync(GameObject prefab)
	{
	}

	private void OnInstantAsyncCompleted(uint generation, GameObject instance)
	{
	}

	private void LogDetailsForAsyncPoolGetTicketMismatched(uint savedTicket, uint receivedTicket, string resName, UnityEngine.Object instance)
	{
	}

	private void OnVfxPoolInstantiated(uint ticket, bool success, UnityEngine.Object instance)
	{
	}

	private bool StartVFXLoading()
	{
		return false;
	}

	private void CancelAsyncLoading()
	{
	}

	private void ReleaseVfxInstance()
	{
	}

	protected bool LoadInternal()
	{
		return false;
	}

	public void Release()
	{
	}

	public bool Start(ResourceID vfxResID, VisualEffectLoadMethod loadMethod, Transform nodeTransform, bool resetTransform, float lifetimeSecs = 0f, OnInstanceAttached callback = null, ResourceManager.LoadPriority loadPriority = ResourceManager.LoadPriority.Normal, bool asyncInstantiate = false)
	{
		return false;
	}

	public bool Restart()
	{
		return false;
	}

	protected virtual bool IsActive()
	{
		return false;
	}

	protected void SetLocalTransformToDefaultInternal()
	{
	}

	private void ApplyActivePropertyStatus()
	{
	}

	private void ApplyLocalTransformPropertyStatus()
	{
	}

	private void ApplyGlobalTransformPropertyStatus()
	{
	}

	private void ApplyTransformPropertyStatus()
	{
	}

	private void ApplyAnimationPropertyStatus()
	{
	}

	private void ApplyPropertyStatusAfterInstantiate()
	{
	}

	private void ResetPropertyStatusInternal()
	{
	}

	public void ResetPropertyStatus()
	{
	}

	public virtual void SetActive(bool activeSelf)
	{
	}

	public void SetLocalPosition(Vector3 localPosition)
	{
	}

	public Vector3 GetLocalPosition()
	{
		return default(Vector3);
	}

	public void SetLocalRotation(Quaternion localRotation)
	{
	}

	public void SetLocalScale(Vector3 localScale)
	{
	}

	public void SetPosition(Vector3 position)
	{
	}

	public void SetRotation(Quaternion rotation)
	{
	}

	public void PlayParticleSystem()
	{
	}

	public void StopParticleSystem()
	{
	}
}
