namespace COW;

internal class MutableInt64Value : MutableValueBase
{
	private long mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(long value)
	{
	}

	public static implicit operator long(MutableInt64Value value)
	{
		return 0L;
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(long P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
