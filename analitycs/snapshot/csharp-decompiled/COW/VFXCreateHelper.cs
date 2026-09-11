using GCommon;
using UnityEngine;

namespace COW;

public class VFXCreateHelper : MonoBehaviour
{
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public VFXCreateHelper _003C_003E4__this;

		public uint generation;

		internal void _003CStartInstantAsync_003Eb__0(GameObject instance)
		{
		}
	}

	public bool InvokeOnEnableDisable;

	public string ResID;

	public Transform VFXContainer;

	public bool AsynLoad;

	public bool UsingPool;

	public bool AsyncInstantiate;

	private GameObject m_CreatedVFX;

	private uint m_CurWaitingAsyncResultTicket;

	private uint m_InstantAsyncGeneration;

	private bool m_InstantAsyncPending;

	private ResourceID m_CachedResourceID;

	private ResourceID m_ResourceID;

	private bool m_ForceShow;

	private bool ShouldAsyncInstantiate => false;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void SetResourceId(ResourceID resId)
	{
	}

	public void ForceDestroyVFX()
	{
	}

	public void SetForceShow(bool forceShow)
	{
	}

	public void SetActive(bool show)
	{
	}

	private void OnVFXLoaded(uint ticket, bool succeeded, Object obj)
	{
	}

	private void StartInstantAsync(GameObject prefab)
	{
	}

	private void OnInstantAsyncCompleted(uint generation, GameObject instance)
	{
	}

	private void ApplyVFXTransformAndActive()
	{
	}

	private void OnDestroy()
	{
	}

	public bool CheckVFXCreated()
	{
		return false;
	}
}
