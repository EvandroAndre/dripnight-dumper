using System;
using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class SimpleMap : DirtyNotify
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public string toStr;

		internal void _003CToString_003Eb__0(object key, object value)
		{
		}
	}

	private Dictionary<object, object> pairs;

	private Dictionary<object, bool> diffCache;

	private bool diff2Clean;

	public SimpleMap Create()
	{
		return null;
	}

	public SimpleMap Clone()
	{
		return null;
	}

	public void Reset()
	{
	}

	public Dictionary<object, object> Buffer()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public void Iterator(Action<object, object> callback)
	{
	}

	public Dictionary<object, object> Pairs()
	{
		return null;
	}

	public bool IsDirty()
	{
		return false;
	}

	public Dictionary<object, bool> DiffCache()
	{
		return null;
	}

	public bool IsDiff2Clean()
	{
		return false;
	}

	public void PushOperate(MapOperateType operateType, object key)
	{
	}

	public void ResetDirty()
	{
	}

	public void SetKV(object key, object value)
	{
	}

	public bool Exist(object key)
	{
		return false;
	}

	public bool TryGet(object key, out object value)
	{
		value = null;
		return false;
	}

	public object Get(object key)
	{
		return null;
	}

	public void Del(object key)
	{
	}

	public void Clean()
	{
	}

	public int Length()
	{
		return 0;
	}

	public object[] Keys()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
