using UnityEngine;

namespace GCommon;

public class GameObjectRecycleInfo : ObjectPoolCallbackBase
{
	private GameObject m_GameObject;

	private Transform m_Parent;

	private bool m_Actived;

	public void Recycle(GameObject go, Transform binRoot)
	{
	}

	public void Restore()
	{
	}

	public override void OnCollected()
	{
	}
}
