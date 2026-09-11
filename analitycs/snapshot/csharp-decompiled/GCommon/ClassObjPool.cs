using System;
using System.Collections.Generic;

namespace GCommon;

public class ClassObjPool<T> : IObjectPool where T : PooledClassObject, new()
{
	public static int CLASS_ID;

	internal static bool IS_REGISTERED;

	protected List<object> pool;

	public uint reqSeq;

	private RefWrapper<PoolWrapper> Ref;

	private int _003Ctotal_003Ek__BackingField;

	private int _003CRTAllocCnt_003Ek__BackingField;

	public int Capacity => 0;

	public int total
	{
		get
		{
			return _003Ctotal_003Ek__BackingField;
		}
		private set
		{
			_003Ctotal_003Ek__BackingField = value;
		}
	}

	public int RTAllocCnt
	{
		get
		{
			return _003CRTAllocCnt_003Ek__BackingField;
		}
		private set
		{
			_003CRTAllocCnt_003Ek__BackingField = value;
		}
	}

	public int Count => 0;

	public void Init(PoolWrapper wrapper)
	{
	}

	public static ClassObjPool<T> GetPool()
	{
		return null;
	}

	object IObjectPool.Get(object constructData)
	{
		return null;
	}

	public static T Get()
	{
		return null;
	}

	public T GetObject()
	{
		return null;
	}

	private void ClearAllocRecords()
	{
	}

	public void Release(PooledClassObject obj)
	{
	}

	public void ClearAll(bool clearRef = true)
	{
	}

	public void ClearUnused()
	{
	}

	private void AdjustCapcity(int count)
	{
	}

	public static void ExtendCaptain(int extCount)
	{
	}

	public Type GetElemType()
	{
		return null;
	}
}
