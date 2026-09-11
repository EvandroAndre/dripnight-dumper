using System;
using System.Collections.Generic;

namespace COW;

public class UGCLRUDataCachePool<TKey, TValue> where TKey : IEquatable<TKey>
{
	private class CacheNode
	{
		public TKey Key;

		public TValue Value;

		public CacheNode Prev;

		public CacheNode Next;

		public long LastAccessTime;

		public bool IsPinned;

		public CacheNode(TKey key, TValue value)
		{
		}

		public void UpdateAccessTime()
		{
		}

		private static long GetCurrentTimestamp()
		{
			return 0L;
		}
	}

	private readonly Dictionary<TKey, CacheNode> m_CacheMap;

	private readonly CacheNode m_Head;

	private readonly CacheNode m_Tail;

	private readonly int m_MaxCapacity;

	private int m_CurrentSize;

	private int m_PinnedCount;

	private long m_HitCount;

	private long m_TotalAccess;

	public int Count => 0;

	public int MaxCapacity => 0;

	public bool IsFull => false;

	public float HitRate => 0f;

	public int PinnedCount => 0;

	public int RemovableCount => 0;

	public UGCLRUDataCachePool(int maxCapacity)
	{
	}

	public bool TryGet(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	public void Put(TKey key, TValue value)
	{
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool Pin(TKey key)
	{
		return false;
	}

	public bool Unpin(TKey key)
	{
		return false;
	}

	public bool IsPinned(TKey key)
	{
		return false;
	}

	public void Clear()
	{
	}

	private bool RemoveSingleLRU()
	{
		return false;
	}

	public int BatchRemoveLRU(int batchRemoveCount)
	{
		return 0;
	}

	public List<TKey> GetAllKeys()
	{
		return null;
	}

	public List<TKey> GetRecentKeys(int count)
	{
		return null;
	}

	public List<TKey> GetPinnedKeys()
	{
		return null;
	}

	public List<TKey> GetRemovableKeys()
	{
		return null;
	}

	public int BatchPin(IEnumerable<TKey> keys)
	{
		return 0;
	}

	public int BatchUnpin(IEnumerable<TKey> keys)
	{
		return 0;
	}

	private void AddToHead(CacheNode node)
	{
	}

	private void RemoveNode(CacheNode node)
	{
	}

	private void MoveToHead(CacheNode node)
	{
	}

	public void PrintCacheStatus()
	{
	}

	public string GetCacheStats()
	{
		return null;
	}
}
