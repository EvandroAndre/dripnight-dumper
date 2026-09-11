using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace GCommon;

public class CSVAsyncDataMap<TKey, TVal> : ICSVDataMap<TKey, TVal>, ICSVDataMap, IEnumerable where TVal : CSVBaseData
{
	public struct Enumerator : IEnumerator<KeyValuePair<TKey, TVal>>, IEnumerator, IDisposable
	{
		private Dictionary<TKey, CSVBaseData>.Enumerator m_Inner = default(Dictionary<TKey, CSVBaseData>.Enumerator);

		public KeyValuePair<TKey, TVal> Current => default(KeyValuePair<TKey, TVal>);

		object IEnumerator.Current => null;

		internal Enumerator(Dictionary<TKey, CSVBaseData> dict)
		{
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}
	}

	private object m_lockParse;

	private bool m_BytesLoaded;

	private bool m_Parsed;

	private bool m_AfterParse;

	private ResourceID m_ResourceID;

	private TextReader m_SyncLoadCsvText;

	private TextReader m_AsyncLoadCsvText;

	private byte[] m_CSVBytes;

	protected Dictionary<TKey, CSVBaseData> m_Map;

	public int Capacity;

	public Func<TVal, TKey> KeySelector;

	public bool BytesLoaded
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected bool Parsed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ResourceID ResourceID
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public int Count => 0;

	// C# has no syntax for parameterized property 'Item'.
	public TVal get_Item(TKey key)
	{
		return null;
	}

	public void set_Item(TKey key, TVal value)
	{
	}

	public bool Add(TKey key, TVal val)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool ContainsKey(TKey key)
	{
		return false;
	}

	public bool TryGetValue(TKey key, out TVal val)
	{
		val = null;
		return false;
	}

	public bool TryGetValue(TKey key, out object val)
	{
		val = null;
		return false;
	}

	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	IEnumerator<KeyValuePair<TKey, TVal>> ICSVDataMap<TKey, TVal>.GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public bool Remove(TKey key)
	{
		return false;
	}

	public virtual TKey Select(TVal record)
	{
		return default(TKey);
	}

	protected virtual TVal GetInstacne()
	{
		return null;
	}

	protected virtual Type GetDataType()
	{
		return null;
	}

	protected virtual void OnClear()
	{
	}

	private void SyncLoadImp()
	{
	}

	private void AsyncLoadImp()
	{
	}

	private void Load()
	{
	}

	private void Parse(object _param)
	{
	}

	private void SerializeBinary(StreamReader reader)
	{
	}

	private void ParseCSV(TextReader reader)
	{
	}

	protected void LoopCallAfterParseData(ICSVDataMap<TKey, TVal> dataMap)
	{
	}

	private void LoadAsync()
	{
	}

	private void OnCSVLoaded(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	public void SyncLoad()
	{
	}

	public void AsyncLoad()
	{
	}

	public void UnLoad()
	{
	}
}
