using System;
using System.Collections.Generic;

namespace GCommon;

public class AnonymousCSVAsyncDataMap : CSVAsyncDataMap<string, CSVBaseData>
{
	public Type DataType;

	private List<CSVBaseData> m_DataList;

	public List<CSVBaseData> GetDataList()
	{
		return null;
	}

	protected override Type GetDataType()
	{
		return null;
	}

	public Dictionary<string, CSVBaseData> GetDataMap()
	{
		return null;
	}

	protected override void OnClear()
	{
	}

	protected override CSVBaseData GetInstacne()
	{
		return null;
	}

	private static string KeySelectorDelegate(CSVBaseData data)
	{
		return null;
	}

	public static implicit operator Dictionary<string, CSVBaseData>(AnonymousCSVAsyncDataMap dataMap)
	{
		return null;
	}
}
