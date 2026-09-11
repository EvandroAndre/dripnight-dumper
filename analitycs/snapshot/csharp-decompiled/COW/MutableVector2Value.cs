using UnityEngine;

namespace COW;

internal class MutableVector2Value : MutableValueBase
{
	private Vector2 mValue;

	public override EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public override void SetValue(Vector2 value)
	{
	}

	public static implicit operator Vector2(MutableVector2Value value)
	{
		return default(Vector2);
	}

	public override string ToString()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_SetValue(Vector2 P0)
	{
	}

	public new string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
