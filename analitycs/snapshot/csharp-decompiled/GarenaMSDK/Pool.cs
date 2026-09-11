using System;
using System.Collections.Generic;

namespace GarenaMSDK;

public class Pool<K, V>
{
	protected K _Key;

	protected Dictionary<K, V> _Pool;

	protected Func<Dictionary<K, V>, K, V, K> _KeyGen;

	public Pool(Func<Dictionary<K, V>, K, V, K> keyGen)
	{
	}

	public K Save(V value)
	{
		return default(K);
	}

	public bool Has(K id)
	{
		return false;
	}

	public V Get(K id)
	{
		return default(V);
	}

	public bool TryGet(K id, out V result)
	{
		result = default(V);
		return false;
	}

	public V Take(K id)
	{
		return default(V);
	}

	public bool TryTake(K id, out V result)
	{
		result = default(V);
		return false;
	}
}
