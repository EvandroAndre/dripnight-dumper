namespace COW;

internal class MutableFloatValue : MutableValueBase
{
	private float mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(float value)
	{
	}

	public static implicit operator float(MutableFloatValue value)
	{
		return 0f;
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(float P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
