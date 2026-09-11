using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIItemReference : MonoBehaviour
{
	public List<UIItemVariable> Items;

	private Dictionary<string, UIItemVariable> m_ItemDict;

	public T GetItem<T>(string itemName) where T : Object
	{
		return null;
	}

	private void CacheItem()
	{
	}

	private bool HasCached()
	{
		return false;
	}
}
