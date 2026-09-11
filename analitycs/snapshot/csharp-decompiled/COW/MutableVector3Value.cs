using UnityEngine;

namespace COW;

internal class MutableVector3Value : MutableValueBase
{
	private Vector3 mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(Vector3 value)
	{
	}

	public static implicit operator Vector3(MutableVector3Value value)
	{
		return default(Vector3);
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(Vector3 P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
