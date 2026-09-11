using UnityEngine;

namespace ReactUI;

public sealed class VariableNameAttribute : PropertyAttribute
{
	private int m_typeMask;

	public VariableNameAttribute()
	{
	}

	public VariableNameAttribute(UIVariableType t1)
	{
	}

	public VariableNameAttribute(UIVariableType t1, UIVariableType t2)
	{
	}

	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3)
	{
	}

	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3, UIVariableType t4)
	{
	}

	public VariableNameAttribute(UIVariableType t1, UIVariableType t2, UIVariableType t3, UIVariableType t4, UIVariableType t5)
	{
	}

	public bool IsValid(UIVariableType type)
	{
		return false;
	}
}
