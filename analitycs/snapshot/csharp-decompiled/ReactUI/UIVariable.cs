using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ReactUI;

[Serializable]
public sealed class UIVariable
{
	private string name;

	private UIVariableType type;

	private bool booleanValue;

	private long integerValue;

	private float floatValue;

	private string stringValue;

	private IList arrayValue;

	private object objectValue;

	private List<UIVariableBind> binderList;

	private Action actionOnValueChanged;

	private Action actionOnValueInit;

	public string Name => null;

	public UIVariableType Type
	{
		get
		{
			return UIVariableType.Boolean;
		}
		set
		{
		}
	}

	public object ValueObject => null;

	public ICollection<UIVariableBind> Binds => null;

	public event Action OnValueChanged
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public event Action OnValueInitialized
	{
		[MethodImpl((MethodImplOptions)32)]
		add
		{
		}
		[MethodImpl((MethodImplOptions)32)]
		remove
		{
		}
	}

	public bool GetBoolean()
	{
		return false;
	}

	public int GetInteger()
	{
		return 0;
	}

	public long GetLongVal()
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

	public IList GetArray()
	{
		return null;
	}

	public void SetBoolean(bool value, bool forceSet = false)
	{
	}

	public void SetInteger(long value, bool forceSet = false)
	{
	}

	public void SetFloat(float value, bool forceSet = false)
	{
	}

	public void SetString(string value, bool forceSet = false)
	{
	}

	public void SetArray(IList value)
	{
	}

	public void SetObject(object value)
	{
	}

	public void AddBind(UIVariableBind bind)
	{
	}

	public void RemoveBind(UIVariableBind bind)
	{
	}

	internal void InvokeValueChange()
	{
	}

	internal void InvokeValueInit()
	{
	}

	public void ResetValue()
	{
	}
}
