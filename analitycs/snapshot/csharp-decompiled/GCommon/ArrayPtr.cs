namespace GCommon;

public class ArrayPtr<T> : ObjPtrWithLength
{
	protected static readonly byte OFFSET_SIZE;

	// C# has no syntax for parameterized property 'Item'.
	public T get_Item(int idx)
	{
		return default(T);
	}

	public void set_Item(int idx, T value)
	{
	}

	public ArrayPtr(T[] array)
		: base(null)
	{
	}

	public unsafe void Set(int idx, void* ptr)
	{
	}
}
