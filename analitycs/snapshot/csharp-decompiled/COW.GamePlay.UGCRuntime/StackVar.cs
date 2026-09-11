using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public class StackVar : IUGCObjectPoolItem
{
	public int LayerIndex;

	public string Name;

	public UGCSimpleValue value;

	public string upValueName;

	public StackContext upStack;

	public uint upStackGeneration;

	public override string ToString()
	{
		return null;
	}

	public StackVar Create(int layer, string name, UGCSimpleValue value)
	{
		return null;
	}

	public StackVar CreateWithUpValue(int layer, string name, string upValueName, StackContext upValueStack)
	{
		return null;
	}

	public void Reset()
	{
	}

	private bool IsUpStackValid()
	{
		return false;
	}

	public UGCSimpleValue GetCoreValue()
	{
		return null;
	}

	public object Get()
	{
		return null;
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

	public void Set(object value)
	{
	}

	public void SetBool(bool value)
	{
	}

	public void SetInt(int value)
	{
	}

	public void SetInt64(long value)
	{
	}

	public void SetFloat(float value)
	{
	}

	public void SetVector2(Vector2 value)
	{
	}

	public void SetVector3(Vector3 value)
	{
	}

	public void SetQuaternion(Quaternion value)
	{
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
