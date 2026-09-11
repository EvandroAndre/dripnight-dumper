namespace InterApp;

public class InterAppActionType
{
	public delegate void ActDelegate(InterAppAction action);

	public string Action;

	public string[] Parameters;

	public string[] OptionalParameters;

	public ActDelegate Act;

	public bool NeedCheckVersion;
}
