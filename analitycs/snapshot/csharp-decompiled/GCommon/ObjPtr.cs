namespace GCommon;

public class ObjPtr
{
	protected const ulong INVALID_HANDLE = 0uL;

	public static readonly byte PTR_SIZE;

	public static readonly bool Is32Bit;

	protected static readonly byte PTR_SIZE_2;

	protected static readonly byte PTR_SIZE_3;

	protected object m_Obj;

	protected unsafe byte* m_Ptr;

	protected ulong m_handle;

	public bool HasObjRef => false;

	public long Address => 0L;

	public unsafe byte* Ptr => null;

	public ObjPtr(object obj)
	{
	}

	~ObjPtr()
	{
	}

	public virtual void Release()
	{
	}

	protected void ClearHandle()
	{
	}

	protected virtual void ClearObjRef()
	{
	}

	protected void ThrowIfNull()
	{
	}

	protected void SetVal(int offset, int val)
	{
	}

	protected void SetVal(int offset, long val)
	{
	}

	protected unsafe void SetVal(int offset, void* val)
	{
	}

	public int GetInt(int offset)
	{
		return 0;
	}

	public long GetLong(int offset)
	{
		return 0L;
	}

	public unsafe void* GetPtr(int offset)
	{
		return null;
	}
}
