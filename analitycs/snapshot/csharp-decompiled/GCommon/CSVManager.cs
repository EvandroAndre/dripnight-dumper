using System;
using System.Collections.Generic;

namespace GCommon;

public class CSVManager : SingletonModule<CSVManager>
{
	public const int TABLE_LOAD_INTERVAL = 10;

	private List<ICSVDataMap> m_Tables;

	private bool m_EnableCSVAsyncLoad;

	public void OnApplicationQuit()
	{
	}

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public CSVAsyncDataIntKeyMap<TVal> CreateIntKeyCSVData<TVal>(ResourceID resourceID, int capcity = 0) where TVal : CSVBaseData, new()
	{
		return null;
	}

	public CSVAsyncDataUIntKeyMap<TVal> CreateUIntKeyCSVData<TVal>(ResourceID resourceID, int capcity = 0) where TVal : CSVBaseData, new()
	{
		return null;
	}

	public CSVAsyncDataPairKeyMap<TKey1, TKey2, TVal> CreatePairKeyCSVData<TKey1, TKey2, TVal>(ResourceID resourceID, Func<TVal, Pair<TKey1, TKey2>> keySelector, int capcity = 0) where TVal : CSVBaseData, new()
	{
		return null;
	}

	public CSVAsyncDataMap<TKey, TVal> CreateCSVData<TKey, TVal>(ResourceID resourceID, Func<TVal, TKey> valueSelector, int capcity = 0) where TVal : CSVBaseData, new()
	{
		return null;
	}

	public AnonymousCSVAsyncDataMap CreateAnonymousCSVData(ResourceID resourceID, Type dateType)
	{
		return null;
	}
}
