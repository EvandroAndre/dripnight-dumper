using UnityEngine;

namespace ReactUI;

public sealed class UIMapVariableTable : MonoBehaviour
{
	private UIMapVariable[] mapVariables;

	private UIVariableTable varTable;

	public UIMapVariable[] Variables => null;

	public UIVariableTable VarTable => null;

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public UIMapVariable GetMapVariable(int index)
	{
		return null;
	}

	public void SetSrcValue(int srcIdx, int mapVarIdx)
	{
	}

	public void AddDefaultVariable()
	{
	}
}
