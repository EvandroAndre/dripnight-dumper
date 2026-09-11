using System.Collections.Generic;
using proto;

namespace GCommon;

public class CDNForceRefreshManager : SingletonModule<CDNForceRefreshManager>
{
	private enum RefreshCNDType
	{
		None,
		PngCDN,
		AgentVoice
	}

	private Dictionary<string, CDNSourceUpdateDesc> m_ForceRefreshUrlDict;

	private const string AudioCachePref = "AudioCache {0} {1}";

	private const string PngCachePref = "PngCache {0} {1}";

	private NetworkDownloadEngine m_NetworkEngine;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ProcessCDNForceRefresh(CSGetCDNSourceUpdateRes cdnSourceUpdateRes)
	{
	}

	public bool CheckAndClearPNGCacheIfNeeded(string url, uint endTime, string originalUrl)
	{
		return false;
	}

	private bool CheckAndUpdateRefresheStatus(string targetType, CDNSourceUpdateDesc desc)
	{
		return false;
	}

	private void ClearTextureMemoryCache(string url)
	{
	}

	private bool ClearTextureDiskCache(string url, uint endTime)
	{
		return false;
	}

	public void CheckAndClearAgentVoiceCacheIfNeeded(string pathUrl, string originUrl)
	{
	}

	private void ClearAudioDiskCache(string url)
	{
	}
}
