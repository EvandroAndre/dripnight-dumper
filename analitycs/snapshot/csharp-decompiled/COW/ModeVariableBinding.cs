using System;
using UnityEngine;

namespace COW;

public class ModeVariableBinding
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public ModifierControlSkillCDByRegion modifier;

		internal bool _003Cget_BoolValue_003Eb__0(WorkShopSkillEditListData x)
		{
			return false;
		}
	}

	public ModeVariable Variable;

	public IModeVariableBindingModifier Modifier;

	public IModeVariableLogicOperate Operator;

	private bool m_BoolValue;

	private int m_IntValue;

	private float m_FloatValue;

	private Vector3 m_Vector3Value;

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

	public void AddDataChanged(Action callback)
	{
	}

	public void RemoveDataChanged(Action callback)
	{
	}

	public void CleanDataChanged()
	{
	}

	public void SaveValue()
	{
	}
}
