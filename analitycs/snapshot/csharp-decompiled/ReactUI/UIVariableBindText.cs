namespace ReactUI;

public sealed class UIVariableBindText : UIVariableBind
{
	private string format;

	private string[] paramBinds;

	private bool setTextNotKey;

	private UILabel unityText;

	private UIVariable[] m_bindVariable;

	private string sepForArrayValue;

	public string Format
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void RefreshText()
	{
	}

	private new void Awake()
	{
	}
}
