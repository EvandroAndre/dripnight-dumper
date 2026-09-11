namespace GarenaMSDK;

public class SDKIAPTaskInfo
{
	public string Delegate;

	public string Identifier;

	public int ServerID;

	public int RoleID;

	public static readonly SDKIAPTaskInfo Empty;

	public static bool Equals(SDKIAPTaskInfo a, SDKIAPTaskInfo b)
	{
		return false;
	}

	public string IdentifySelf()
	{
		return null;
	}
}
