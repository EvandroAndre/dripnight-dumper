using UnityEngine;

namespace COW;

internal class MutableQuaternionValue : MutableValueBase
{
	private Quaternion mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(Quaternion value)
	{
	}

	public static implicit operator Quaternion(MutableQuaternionValue value)
	{
		return default(Quaternion);
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(Quaternion P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
