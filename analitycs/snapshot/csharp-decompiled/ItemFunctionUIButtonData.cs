public class ItemFunctionUIButtonData
{
	public enum EItemFuncUIBtnType
	{
		Normal,
		Compound
	}

	public string Icon;

	public EItemFuncUIBtnType Type;

	public EventDelegate.Callback Callback;
}
