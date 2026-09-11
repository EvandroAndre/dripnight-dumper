namespace COW;

internal class MutableIntValue : MutableValueBase
{
	private int mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(int value)
	{
	}

	public static implicit operator int(MutableIntValue value)
	{
		return 0;
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(int P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
