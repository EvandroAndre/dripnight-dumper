using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.Graphics;

public class SceneEditEnvironmentPlaneAO
{
	private int m_LayerMask;

	private Dictionary<GameObject, KeyValuePair<ResourceID, GameObject>> m_GoAoDic;

	public void AddPlaneAO(GameObject go, ResourceID resID)
	{
	}

	public void RemovePlaneAO(GameObject go)
	{
	}

	private GameObject LoadPlaneAO(ResourceID resID, Transform parent)
	{
		return null;
	}

	public void RefreshAllPlaneAOs()
	{
	}

	private bool ValidPlaneAO(GameObject go)
	{
		return false;
	}
}
