using GCommon;
using UnityEngine;

public class SocialAreaSpawnObject : MonoBehaviour
{
	public bool ClientOnly;

	public int TypeId;

	private uint m_AsyncLoadTicket;

	private ResourceID m_resId;

	private GameObject m_Instance;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void OnSyncShowObj(object[] data)
	{
	}

	private void CreateInternal(string resid)
	{
	}

	private void OnVfxPoolInstantiated(uint ticket, bool success, Object instance)
	{
	}

	private void RecyleInstnce()
	{
	}
}
