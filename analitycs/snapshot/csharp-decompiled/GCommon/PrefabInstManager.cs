using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public static class PrefabInstManager
{
	private class SingletonResource
	{
		public Object ResObj;

		public GameObject Obj;

		public bool IsFree;

		public SingletonResource(Object res, GameObject o)
		{
		}
	}

	private static Dictionary<ResourceID, SingletonResource> m_SingletonResPool;

	private static HashSet<ResourceID> m_PrefabDirectlyRes;

	private static GameObject m_Parent;

	public static HashSet<ResourceID> PrefabDirectlyRes => null;

	public static bool IsUsingPrefabDirectly(ResourceID resId)
	{
		return false;
	}

	public static GameObject BorrowPrefab(ResourceID resId, Object resObj, Transform parentTrans = null)
	{
		return null;
	}

	public static void ReturnPrefab(ResourceID resId, Object resObj)
	{
	}

	public static void ClearAllResource()
	{
	}
}
