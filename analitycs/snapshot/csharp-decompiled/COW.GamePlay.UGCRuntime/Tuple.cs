namespace COW.GamePlay.UGCRuntime;

public struct Tuple<T1, T2, T3>
{
	private T1 _003CItem1_003Ek__BackingField = default(T1);

	private T2 _003CItem2_003Ek__BackingField = default(T2);

	private T3 _003CItem3_003Ek__BackingField = default(T3);

	public T1 Item1
	{
		get
		{
			return _003CItem1_003Ek__BackingField;
		}
		set
		{
			_003CItem1_003Ek__BackingField = value;
		}
	}

	public T2 Item2
	{
		get
		{
			return _003CItem2_003Ek__BackingField;
		}
		set
		{
			_003CItem2_003Ek__BackingField = value;
		}
	}

	public T3 Item3
	{
		get
		{
			return _003CItem3_003Ek__BackingField;
		}
		set
		{
			_003CItem3_003Ek__BackingField = value;
		}
	}

	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	public static Tuple<T1, T2, T3> Create(T1 t1, T2 t2, T3 t3)
	{
		return default(Tuple<T1, T2, T3>);
	}
}
public struct Tuple<T1, T2, T3, T4>
{
	private T1 _003CItem1_003Ek__BackingField = default(T1);

	private T2 _003CItem2_003Ek__BackingField = default(T2);

	private T3 _003CItem3_003Ek__BackingField = default(T3);

	private T4 _003CItem4_003Ek__BackingField = default(T4);

	public T1 Item1
	{
		get
		{
			return _003CItem1_003Ek__BackingField;
		}
		set
		{
			_003CItem1_003Ek__BackingField = value;
		}
	}

	public T2 Item2
	{
		get
		{
			return _003CItem2_003Ek__BackingField;
		}
		set
		{
			_003CItem2_003Ek__BackingField = value;
		}
	}

	public T3 Item3
	{
		get
		{
			return _003CItem3_003Ek__BackingField;
		}
		set
		{
			_003CItem3_003Ek__BackingField = value;
		}
	}

	public T4 Item4
	{
		get
		{
			return _003CItem4_003Ek__BackingField;
		}
		set
		{
			_003CItem4_003Ek__BackingField = value;
		}
	}

	public Tuple(T1 item1, T2 item2, T3 item3, T4 item4)
	{
	}
}
