using System;
using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;

namespace COW.DynamicPVS;

public class Deserializer
{
	private MemoryStream m_MemoryStream;

	private BinaryReader m_BinaryReader;

	private SerializeData m_SerializeData;

	private string m_SceneName;

	private const int k_CachePoolSize = 1;

	private Queue<KeyValuePair<int, ResourceID>> m_ResIDCache;

	private Queue<KeyValuePair<ResourceID, byte[]>> m_BinaryCache;

	private uint m_AsyncLoadingTicket;

	private ResourceID m_AsyncLoadResID;

	private Action<byte[]> m_AsyncLoadCallBack;

	public void Init(string sceneName)
	{
	}

	public void Clear()
	{
	}

	public byte[] LoadBytes(ResourceID resId)
	{
		return null;
	}

	public void LoadBytesAsync(ResourceID resId, Action<byte[]> callBack)
	{
	}

	public void OnAsyncLoadCallBack(byte[] bytes)
	{
	}

	private void DelegateAsyncLoadBinary(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	public void CancelAsyncLoad()
	{
	}

	public void ReleaseResID(ResourceID resId)
	{
	}

	public ResourceID GetResourceID(int key)
	{
		return default(ResourceID);
	}

	public ResourceID GetResourceID(string key)
	{
		return default(ResourceID);
	}

	public void ReadAreaBounds(byte[] bytes, ref Dictionary<int, Bounds> areaBounds)
	{
	}

	public SerializeData ReadSerializeData(byte[] bytes)
	{
		return null;
	}
}
