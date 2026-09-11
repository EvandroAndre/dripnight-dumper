using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class WebViewSettingDataManager : SingletonModule<WebViewSettingDataManager>
{
	private static class UrlLimitType
	{
		public const uint WHITELIST_GARENA_TOKEN = 1u;

		public const uint BLACKLIST_WEBVIEW = 2u;
	}

	private static readonly char[] DOMAIN_LIST_SEPARATORS;

	private List<WebViewSettingDesc> m_WebViewSettingDataList;

	private List<WebExternalBrowserLimit> m_WebViewExternalBrowserDataList;

	private WebViewRegionalSettingsDesc m_WebViewRegionalSettings;

	private List<string> _DomainBlacklist_WebView;

	private List<string> _DomainWhitelist_GarenaToken;

	public List<WebViewSettingDesc> WebViewSettingDataList => null;

	public List<WebExternalBrowserLimit> WebViewExternalBrowserDataList => null;

	public WebViewRegionalSettingsDesc WebViewRegionalSettings => null;

	public List<string> DomainBlacklist_WebView => null;

	public List<string> DomainWhitelist_GarenaToken => null;

	public static string GetDomain(string url)
	{
		return null;
	}

	public static bool IsSystemCalendarUseAllowed(string url, string permission)
	{
		return false;
	}

	public static bool IsSystemCalendarPermission(string permission)
	{
		return false;
	}

	private static bool DomainMatches(string domain, string allowedDomain)
	{
		return false;
	}

	public string MatchDomainWithList(string domain, IEnumerable<string> list)
	{
		return null;
	}

	public string MatchDomainWithList<T>(string domain, IEnumerable<T> list, Func<T, string> getter)
	{
		return null;
	}

	public void ProcessRegionalSettings(WebViewRegionalSettingsDesc regionalSettings)
	{
	}

	public void ProcessDomainListing(List<WebLimitDesc> domainListing)
	{
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ProcessSettingData(CSWebViewSettingDescRes res)
	{
	}

	public void ProcessExternalBrowserData(List<WebExternalBrowserLimit> data)
	{
	}
}
