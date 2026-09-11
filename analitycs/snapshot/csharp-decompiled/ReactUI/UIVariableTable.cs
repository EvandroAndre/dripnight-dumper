using System;
using System.Collections.Generic;
using UnityEngine;

namespace ReactUI;

public sealed class UIVariableTable : MonoBehaviour
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UIVariable> _003C_003E9__13_0;

		internal int _003CSort_003Eb__13_0(UIVariable P_0, UIVariable P_1)
		{
			return 0;
		}
	}

	private UIVariable[] variables;

	private Dictionary<string, UIVariable> m_varMap;

	private UIMapVariableTable mapVarTable;

	public UIVariable[] AllVariables => null;

	public UIMapVariableTable MapVarTable => null;

	public UIVariable[] Variables => null;

	private Dictionary<string, UIVariable> GetVariableMap()
	{
		return null;
	}

	public UIVariable FindVariable(string name)
	{
		return null;
	}

	public void AddDefaultVariable()
	{
	}

	public string[] GetVariableNames()
	{
		return null;
	}

	public void Sort()
	{
	}

	public UIVariable GetVariable(int index)
	{
		return null;
	}

	private static void InitVariableMap(Transform trans)
	{
	}

	private static void DeepInitVariableBind(Transform trans)
	{
	}

	private void Awake()
	{
	}
}
