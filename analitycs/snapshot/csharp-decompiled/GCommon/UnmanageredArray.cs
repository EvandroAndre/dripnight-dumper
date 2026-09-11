namespace GCommon;

public class UnmanageredArray<T>
{
	protected unsafe static void* s_klass;

	private unsafe byte* m_Ptr;

	private unsafe byte* m_AlignPtr;

	public unsafe static void* KlassPtr => null;

	public UnmanageredArray(int cap)
	{
	}

	public T[] GetArray()
	{
		return null;
	}

	public void Release()
	{
	}
}
