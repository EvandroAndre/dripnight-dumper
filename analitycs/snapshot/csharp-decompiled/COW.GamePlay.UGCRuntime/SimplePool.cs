using System;
using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class SimplePool
{
	private List<object> buf;

	private Func<object> _003CNew_003Ek__BackingField;

	private bool enableStatistics;

	private int poolHitCount;

	private int newCreateCount;

	public Func<object> New
	{
		get
		{
			return _003CNew_003Ek__BackingField;
		}
		set
		{
			_003CNew_003Ek__BackingField = value;
		}
	}

	public SimplePool Create(Func<object> New)
	{
		return null;
	}

	public void AddInitItem()
	{
	}

	public object Get()
	{
		return null;
	}

	public void Put(object x)
	{
	}

	public int GetCount()
	{
		return 0;
	}

	public void EnableStatistics()
	{
	}

	public void GetStatistics(out int poolHits, out int newCreates)
	{
		poolHits = default(int);
		newCreates = default(int);
	}

	public void ResetStatistics()
	{
	}
}
