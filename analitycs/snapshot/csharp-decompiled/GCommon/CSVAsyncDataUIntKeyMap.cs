namespace GCommon;

public class CSVAsyncDataUIntKeyMap<TVal> : CSVAsyncDataMap<uint, TVal> where TVal : CSVBaseData, new()
{
	public override uint Select(TVal record)
	{
		return 0u;
	}

	public new bool Add(uint key, TVal val)
	{
		return false;
	}

	public new bool TryGetValue(uint key, out TVal val)
	{
		val = null;
		return false;
	}
}
