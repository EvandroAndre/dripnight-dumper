using System;

namespace COW;

public class FacebookUtility
{
	private static FacebookUtility _instance;

	public Action<string> OnLoginFailed;

	public Action OnLoginSucess;

	public Action OnLoginCancel;

	private static string FacebookURL_Web;

	private static string FacebookURL_APP;

	public static FacebookUtility Instance()
	{
		return null;
	}

	public void OpenFBMainPage(string fbEventID)
	{
	}
}
