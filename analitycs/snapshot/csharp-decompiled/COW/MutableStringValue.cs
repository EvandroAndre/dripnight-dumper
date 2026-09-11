namespace COW;

internal class MutableStringValue : MutableValueBase
{
	private string mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(string value)
	{
	}

	public static implicit operator string(MutableStringValue value)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(string P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
