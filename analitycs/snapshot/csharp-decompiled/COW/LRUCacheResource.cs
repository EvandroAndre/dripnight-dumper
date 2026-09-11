using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class LRUCacheResource : IDisposable
{
	private sealed class CacheItem
	{
		private readonly ResourceID m_key;

		private GameObject m_value;

		public ResourceID Key => default(ResourceID);

		public GameObject Value
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CacheItem(ResourceID key, GameObject value)
		{
		}
	}

	private readonly int m_capacity;

	private readonly Dictionary<ResourceID, LinkedListNode<CacheItem>> m_cache;

	private readonly LinkedList<CacheItem> m_lruList;

	private readonly Action<ResourceID, GameObject> m_onRemove;

	private readonly Action<Exception> m_errorHandler;

	private bool m_disposed;

	private bool m_disposing;

	private const int DefaultCapacity = 5;

	private const int MaxCapacity = 1073741823;

	public int Count => 0;

	public int Capacity => 0;

	public List<GameObject> Values => null;

	public List<ResourceID> Keys => null;

	public LRUCacheResource(int capacity, Action<ResourceID, GameObject> onRemoveAction, Action<Exception> errorHandler = null)
	{
	}

	private void HandleError(Exception ex)
	{
	}

	public bool Contains(ResourceID key)
	{
		return false;
	}

	public bool TryGet(ResourceID key, out GameObject value)
	{
		value = null;
		return false;
	}

	private void ExecuteRemoveCallback(CacheItem item)
	{
	}

	public void Add(ResourceID key, GameObject value)
	{
	}

	public void Clear()
	{
	}

	public bool Remove(ResourceID key)
	{
		return false;
	}

	public void Dispose()
	{
	}
}
