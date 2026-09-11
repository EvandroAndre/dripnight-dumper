using UnityEngine;

namespace GarenaMSDK;

public class SdkUnity
{
	private AndroidJavaObject javaSdkUnity;

	private static SdkUnity sInstance;

	public static SdkUnity Instance => null;

	public bool FacebookAutoLogAppEventsEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool FacebookAdvertisingIDCollectionEnabled
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private SdkUnity()
	{
	}

	public void Call(string methodName, object[] args)
	{
	}

	public T Call<T>(string methodName, object[] args)
	{
		return default(T);
	}

	public void SetLog(bool debug, bool error)
	{
	}

	public void EnableSensitiveLogHiding(bool enable)
	{
	}

	public void SetOverrideRootUrl(string url)
	{
	}

	public void SetOverrideNewRootUrl(string url)
	{
	}

	public void ClearFacebookAppEventsUserID()
	{
	}

	public void ClearFacebookAppEventsUserData()
	{
	}

	public void OverrideFacebookGraphAPIVersion(string version)
	{
	}

	internal void SetRegFormCallback(IRegFormCallback callback)
	{
	}

	internal void ProtectWebViewForRegistrationForm(bool enabled)
	{
	}

	public void OpenRegistrationForm(string region, string locale, bool forceDisplay)
	{
	}

	public void CloseRegistrationForm()
	{
	}

	public void GetUserVerificationInfo(string region)
	{
	}
}
