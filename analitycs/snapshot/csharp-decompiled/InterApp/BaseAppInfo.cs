using System;

namespace InterApp;

public class BaseAppInfo
{
	protected static readonly string[] EMPTY_STRING_ARRAY;

	public string[] URLSchemes => null;

	public string[] BundleIdentifiers => null;

	public virtual string[] URLSchemes_iOS => null;

	public virtual string URLScheme_Android => null;

	public virtual string[] BundleIdentifiers_iOS => null;

	public virtual string[] BundleIdentifiers_Android => null;

	public virtual bool OAuthRequiresAndroidSystemWebView()
	{
		return false;
	}

	public virtual bool CanLaunch()
	{
		return false;
	}

	public virtual bool CanShareText()
	{
		return false;
	}

	public virtual void ShareText(string text)
	{
	}

	public virtual bool CanShareImage()
	{
		return false;
	}

	public virtual void ShareImage(string filePath)
	{
	}

	public virtual bool CanShareVideo()
	{
		return false;
	}

	public virtual void ShareVideo(string identifier, Action<int, string> callback = null)
	{
	}
}
