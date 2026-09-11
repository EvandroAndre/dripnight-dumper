using System;

namespace ReactUI;

public abstract class UIVariableBindBool : UIVariableBind
{
	public enum BooleanLogic
	{
		And,
		Or
	}

	public enum CompareModeEnum
	{
		Less,
		LessEqual,
		Equal,
		Great,
		GreatEqual,
		Contain
	}

	[Serializable]
	private class OneVar
	{
		private string variableName;

		private CompareModeEnum compareMode;

		private int referenceInt;

		private float referenceFloat;

		private string referenceVariableName;

		private bool reverse;

		private UIVariable ownerVar;

		private UIVariable referenceVar;

		public UIVariable ReferenceVar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string GetRefVariableName()
		{
			return null;
		}

		public string GetVariableName()
		{
			return null;
		}

		public UIVariable GetVariable()
		{
			return null;
		}

		public void SetVariable(UIVariable v)
		{
		}

		public bool GetValue()
		{
			return false;
		}
	}

	private BooleanLogic booleanLogic;

	private OneVar[] variables;

	private bool reverse;

	public new UIVariable FindVariable(string name)
	{
		return null;
	}

	protected bool GetResult()
	{
		return false;
	}

	private bool GetResultInternal()
	{
		return false;
	}

	protected abstract void OnValueChanged();

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}
}
