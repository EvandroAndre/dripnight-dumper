using System.Collections.Generic;
using GCommon;

namespace InterApp;

public class OpenedWithParamsDelegate
{
	public class OpenedWithParams
	{
		public string DeepLinkUrl;

		public string WebViewUrl;

		public string WebViewStyle;

		public string BrowserUrl;

		public Dictionary<string, string> Extras;

		public bool HasValue()
		{
			return false;
		}
	}

	protected static bool Has(Dictionary<string, string> parameters, string key)
	{
		return false;
	}

	protected static string _(string v)
	{
		return null;
	}

	public virtual PlatformUtility.OpenedWith OverrideOpenedWith(PlatformUtility.OpenedWith ow)
	{
		return null;
	}

	public virtual void Processed(OpenedWithParams openedWithParams)
	{
	}

	public virtual bool CanProcess(Dictionary<string, string> parameters)
	{
		return false;
	}

	public virtual OpenedWithParams Process(Dictionary<string, string> parameters)
	{
		return null;
	}
}
