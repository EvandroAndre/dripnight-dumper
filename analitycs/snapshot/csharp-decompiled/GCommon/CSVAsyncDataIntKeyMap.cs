namespace GCommon;

public class CSVAsyncDataIntKeyMap<TVal> : CSVAsyncDataMap<int, TVal> where TVal : CSVBaseData, new()
{
	public override int Select(TVal record)
	{
		return 0;
	}

	public new bool Add(int key, TVal val)
	{
		return false;
	}

	public new bool TryGetValue(int key, out TVal val)
	{
		val = null;
		return false;
	}
}
