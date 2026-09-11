namespace GCommon;

public class CSVAsyncDataPairKeyMap<TKey1, TKey2, TVal> : CSVAsyncDataMap<Pair<TKey1, TKey2>, TVal> where TVal : CSVBaseData, new()
{
	public bool Add(TKey1 key1, TKey2 key2, TVal val)
	{
		return false;
	}

	public bool TryGetValue(TKey1 key1, TKey2 key2, out TVal val)
	{
		val = null;
		return false;
	}
}
