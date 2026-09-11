using UnityEngine;
using message;

namespace COW;

public class MutableValue : IMutableValue
{
	private MutableValueBase mImpl;

	public EUGCMutableValueType ValueType => EUGCMutableValueType.None;

	public MutableValue()
	{
	}

	public MutableValue(EUGCMutableValueType valueType)
	{
	}

	public MutableValue(bool value)
	{
	}

	public MutableValue(int value)
	{
	}

	public MutableValue(long value)
	{
	}

	public MutableValue(float value)
	{
	}

	public MutableValue(string value)
	{
	}

	public MutableValue(Vector2 value)
	{
	}

	public MutableValue(Vector3 value)
	{
	}

	public MutableValue(Quaternion value)
	{
	}

	private static MutableValueBase CreateImpl(EUGCMutableValueType valueType)
	{
		return null;
	}

	public EUGCMutableValueType GetValueType()
	{
		return EUGCMutableValueType.None;
	}

	public void SetValue(EUGCMutableValueType valueType, string value)
	{
	}

	public void SetValue(IPIFNFDIIKK entityRepValue)
	{
	}

	public void SetValue(MutableValue value)
	{
	}

	public void SetValue(bool value)
	{
	}

	public void SetValue(int value)
	{
	}

	public void SetValue(uint value)
	{
	}

	public void SetValue(long value)
	{
	}

	public void SetValue(float value)
	{
	}

	public void SetValue(string value)
	{
	}

	public void SetValue(Vector2 value)
	{
	}

	public void SetValue(Vector3 value)
	{
	}

	public void SetValue(Quaternion value)
	{
	}

	public bool GetBool()
	{
		return false;
	}

	public int GetInt()
	{
		return 0;
	}

	public long GetInt64()
	{
		return 0L;
	}

	public float GetFloat()
	{
		return 0f;
	}

	public string GetString()
	{
		return null;
	}

	public Vector2 GetVector2()
	{
		return default(Vector2);
	}

	public Vector3 GetVector3()
	{
		return default(Vector3);
	}

	public Quaternion GetQuaternion()
	{
		return default(Quaternion);
	}

	public MutableValue Clone()
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}
}
