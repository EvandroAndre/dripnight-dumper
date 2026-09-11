using System;
using System.Collections;
using System.Collections.Generic;

namespace COW;

public class ProfileWeaponDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
{
	private struct Enumerator : IEnumerator<KeyValuePair<TKey, TValue>>, IEnumerator, IDisposable
	{
		private IEnumerator<TKey> weaponsEnum = null;

		private int version = 0;

		private KeyValuePair<TKey, TValue> current = default(KeyValuePair<TKey, TValue>);

		private ProfileWeaponDictionary<TKey, TValue> dictionary = null;

		public KeyValuePair<TKey, TValue> Current => default(KeyValuePair<TKey, TValue>);

		object IEnumerator.Current => null;

		internal Enumerator(ProfileWeaponDictionary<TKey, TValue> dict)
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		public void Dispose()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private static HashSet<TKey> m_WeaponIDs;

	private Dictionary<TKey, TValue> m_Dictionary;

	private int m_Version;

	// C# has no syntax for parameterized property 'Item'.
	public TValue get_Item(TKey key)
	{
		return default(TValue);
	}

	public void set_Item(TKey key, TValue value)
	{
	}

	public ICollection<TKey> Keys => null;

	public ICollection<TValue> Values => null;

	public int Count => 0;

	public bool IsReadOnly => false;

	static ProfileWeaponDictionary()
	{
	}

	public ProfileWeaponDictionary()
	{
	}

	public ProfileWeaponDictionary(int capacity)
	{
	}

	public static void SetWeaponsKey(List<TKey> weapons)
	{
	}

	public bool TryGetValue(TKey key, out TValue value)
	{
		value = default(TValue);
		return false;
	}

	public void Add(TKey key, TValue value)
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public void Add(KeyValuePair<TKey, TValue> item)
	{
	}

	public bool Contains(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public bool Remove(KeyValuePair<TKey, TValue> item)
	{
		return false;
	}

	public void Clear()
	{
	}

	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
	{
	}

	IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
