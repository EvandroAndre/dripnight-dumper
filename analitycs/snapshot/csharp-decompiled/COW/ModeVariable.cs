using System;
using LitJson;
using UnityEngine;

namespace COW;

public class ModeVariable
{
	public enum VariableType
	{
		Boolean,
		Int,
		Float,
		Vector3
	}

	public Action OnDataChanged;

	public VariableType VarType;

	public int Id;

	public string Name;

	public string Rule;

	private IDefalutVariableInternalRule DefaultValueInternalRule;

	private bool m_BoolValue;

	private int m_IntValue;

	private float m_FloatValue;

	private Vector3 m_Vector3Value;

	private bool BoolDefaultValue;

	private bool BoolSavedValue;

	private int IntDefaultValue;

	private int IntSavedValue;

	private float FloatDefaultValue;

	private float FloatSavedValue;

	private Vector3 Vector3DefaultValue;

	private Vector3 Vector3SavedValue;

	private bool m_IgnoreReset;

	public bool BoolValue
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public int IntValue
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public float FloatValue
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Vector3 Vector3Value
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public static bool ParseVector3Str(string str, out Vector3 result)
	{
		result = default(Vector3);
		return false;
	}

	public bool ReadDefaultFromJson(JsonData jsonData)
	{
		return false;
	}

	public bool GetBoolDefaultValue(bool useRule)
	{
		return false;
	}

	public int GetIntDefaultValue(bool useRule)
	{
		return 0;
	}

	public float GetFloatDefaultValue(bool useRule)
	{
		return 0f;
	}

	public Vector3 GetVector3DefaultValue(bool useRule)
	{
		return default(Vector3);
	}

	public void ResetToDefault()
	{
	}

	public void ResetToSaved()
	{
	}

	public void Save()
	{
	}

	public bool CheckIsChanged()
	{
		return false;
	}

	public string ValueToString()
	{
		return null;
	}

	public string AllValuesToString()
	{
		return null;
	}

	public void CopyFrom(ModeVariable variable)
	{
	}
}
