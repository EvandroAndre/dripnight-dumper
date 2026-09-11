namespace COW;

internal class MutableBoolValue : MutableValueBase
{
	private bool mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(bool value)
	{
	}

	public static implicit operator bool(MutableBoolValue value)
	{
		return false;
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(bool P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
