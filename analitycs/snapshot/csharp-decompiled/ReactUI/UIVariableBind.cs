using UnityEngine;

namespace ReactUI;

public abstract class UIVariableBind : MonoBehaviour
{
	private UIVariableTable variableTable;

	private bool isInited;

	private UIVariableTable bindTable;

	private UIVariableTable _003CVariableTable_003Ek__BackingField;

	private static string _markCustomParentVariableTable;

	public UIVariableTable VariableTable
	{
		get
		{
			return _003CVariableTable_003Ek__BackingField;
		}
		private set
		{
			_003CVariableTable_003Ek__BackingField = value;
		}
	}

	internal virtual void Init()
	{
	}

	public UIVariable FindVariable(string name)
	{
		return null;
	}

	private UIVariableTable FindCustomParentTable(string name)
	{
		return null;
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void BindVariables()
	{
	}

	protected virtual void UnbindVariables()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnValidate()
	{
	}

	private void FindVarTable()
	{
	}
}
