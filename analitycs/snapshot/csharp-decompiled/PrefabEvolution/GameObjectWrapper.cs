using UnityEngine;

namespace PrefabEvolution;

public class GameObjectWrapper
{
	public GameObject target;

	public bool m_IsActive
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public GameObjectWrapper(GameObject target)
	{
	}
}
