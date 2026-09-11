using System.Collections.Generic;

namespace GCommon;

public interface ICSVDataMap
{
	ResourceID ResourceID { get; set; }

	int Count { get; }

	void Clear();

	void SyncLoad();

	void AsyncLoad();

	void UnLoad();
}
public interface ICSVDataMap<TKey, TVal> : ICSVDataMap
{
	// C# has no syntax for parameterized property 'Item'.
	TVal get_Item(TKey key);

	void set_Item(TKey key, TVal value);

	bool Add(TKey value, TVal val);

	bool TryGetValue(TKey value, out TVal val);

	IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator();

	bool Remove(TKey value);
}
