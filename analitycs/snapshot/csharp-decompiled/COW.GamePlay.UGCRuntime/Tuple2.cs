namespace COW.GamePlay.UGCRuntime;

public struct Tuple2<T1, T2>
{
	private T1 _003CItem1_003Ek__BackingField = default(T1);

	private T2 _003CItem2_003Ek__BackingField = default(T2);

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

	public static Tuple2<T1, T2> Create(T1 t1, T2 t2)
	{
		return default(Tuple2<T1, T2>);
	}

	public Tuple2(T1 item1, T2 item2)
	{
	}
}
