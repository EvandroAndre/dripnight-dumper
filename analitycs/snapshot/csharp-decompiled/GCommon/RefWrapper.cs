namespace GCommon;

public sealed class RefWrapper<T> where T : class
{
	private T _003CRefObj_003Ek__BackingField;

	public T RefObj
	{
		get
		{
			return _003CRefObj_003Ek__BackingField;
		}
		private set
		{
			_003CRefObj_003Ek__BackingField = value;
		}
	}

	public RefWrapper(T holder)
	{
	}

	public void BreakRef()
	{
	}
}
