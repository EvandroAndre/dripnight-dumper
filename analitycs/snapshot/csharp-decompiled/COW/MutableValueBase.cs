using UnityEngine;

namespace COW;

internal abstract class MutableValueBase : IMutableValue
{
	public abstract EUGCMutableValueType GetValueType();

	public override string ToString()
	{
		return null;
	}

	public virtual void SetValue(bool value)
	{
	}

	public virtual void SetValue(int value)
	{
	}

	public virtual void SetValue(long value)
	{
	}

	public virtual void SetValue(float value)
	{
	}

	public virtual void SetValue(string value)
	{
	}

	public virtual void SetValue(Vector2 value)
	{
	}

	public virtual void SetValue(Vector3 value)
	{
	}

	public virtual void SetValue(Quaternion value)
	{
	}

	protected void ThrowTypeMismatchException(string requestedType)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
