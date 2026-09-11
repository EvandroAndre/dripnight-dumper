using System;

namespace AppsFlyerSDK;

public class AppsFlyerRequestEventArgs : EventArgs
{
	private readonly int _003CstatusCode_003Ek__BackingField;

	private readonly string _003CerrorDescription_003Ek__BackingField;

	public int statusCode => _003CstatusCode_003Ek__BackingField;

	public string errorDescription => _003CerrorDescription_003Ek__BackingField;

	public AppsFlyerRequestEventArgs(int code, string description)
	{
	}
}
