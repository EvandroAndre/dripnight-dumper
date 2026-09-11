namespace GCommon;

public class ObjPtrWithLength : ObjPtr
{
	protected int m_Capacity;

	protected bool m_LengthIsLong;

	protected byte m_LengthOffset;

	public int Length
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public int ElementOffset => 0;

	public unsafe byte* ElementPtr => null;

	public ObjPtrWithLength(object obj)
		: base(null)
	{
	}

	protected void Init(int cap, bool lenIsLong, byte lenOffset)
	{
	}

	protected void ThrowIfOutofBounds(int offset, bool forLength)
	{
	}
}
