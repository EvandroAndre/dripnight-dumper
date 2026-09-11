using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW.GamePlay.UGCRuntime;

public class UGCMapResourceModule : IUGCModule
{
	private class MapResourceExportUrlCache
	{
		public bool Requesting;

		public float ExpireTime;

		public MapResourceExportUrlResult Result;

		public readonly List<Action<MapResourceExportUrlResult>> Callbacks;
	}

	private class GameDataResolveWaiter
	{
		public string MapCode;

		public SceneEditSlotInfo SlotInfo;

		public Action<MapResourceResolveResult> Callback;
	}

	private class MapResourceExportUrlResult
	{
		public string ExportUrl;

		public int ErrorCode;
	}

	private class MapResourceResolveResult
	{
		public SceneEditSlotInfo SlotInfo;

		public string ExportUrl;

		public int ErrorCode;
	}

	private class MapResourceDownloadSession
	{
		public readonly HashSet<string> MapCodes;

		public string ExportUrl;

		public SceneEditSlotInfo SlotInfo;

		public UGCSimpleDownloadTask DownloadTask;

		public int State;

		public int ErrorCode;

		public int Progress;

		public float ProgressCacheTime;

		public bool PopupPending;
	}

	private class MapResourceCheckProbe
	{
		public UGCSimpleDownloadTask ProbeTask;

		public int State;

		public int Progress;

		public float EvaluateCacheTime;
	}

	private sealed class _003C_003Ec__DisplayClass34_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string normalizedMapCode;

		public MapResourceDownloadSession session;

		internal void _003CDownloadMapResource_003Eb__0(MapResourceExportUrlResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string normalizedMapCode;

		public Action<int, int, int> callback;

		internal void _003CCheckMapResourceDownloaded_003Eb__0(MapResourceExportUrlResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string mapCode;

		internal void _003CRequestExportDataUrl_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string mapCode;

		public string exportUrl;

		public Action<MapResourceResolveResult> callback;

		internal void _003CRequestSlotInfoForResource_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public SceneEditSlotInfo slotInfo;

		public UGCMapResourceModule _003C_003E4__this;

		public string mapCode;

		internal void _003CResolveGameDataWithExportUrl_003Eb__0(byte[] gameDataBytes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass45_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string mapCode;

		public string exportUrl;

		public MapResourceDownloadSession session;

		internal void _003CContinueDownloadWithExportUrl_003Eb__0(MapResourceResolveResult result)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public UGCMapResourceModule _003C_003E4__this;

		public string mapCode;

		public string exportUrl;

		public Action<int, int, int> callback;

		internal void _003COnCheckExportUrlResolved_003Eb__0(MapResourceResolveResult resourceResult)
		{
		}
	}

	public const int DownloadStateNotDownloaded = 0;

	public const int DownloadStateDownloading = 1;

	public const int DownloadStateSuccess = 2;

	public const int DownloadStateFailed = 3;

	public const int StatusCodeNoError = 0;

	public const int StatusCodeParamError = 110;

	public const int StatusCodeMapResourceNotFound = 1012;

	public const int StatusCodeMapResourceTargetUnavailable = 1006;

	public const int StatusCodeMapResourceAccessDenied = 1007;

	public const int StatusCodeMapResourceBusy = 1008;

	public const int StatusCodeMapResourceDownloadFailed = 1009;

	public const int StatusCodeMapResourceVerifyFailed = 1010;

	public const int StatusCodeMapResourceNetworkRestricted = 1011;

	private const float CheckProgressCacheDuration = 0.25f;

	private const string DownloadPurpose = "UGCMapResourceAPI";

	private UGCRuntime m_UGCRuntime;

	private readonly Dictionary<string, MapResourceExportUrlCache> m_ExportUrlCachesByMapCode;

	private readonly Dictionary<string, List<GameDataResolveWaiter>> m_GameDataWaitersByExportUrl;

	private readonly Dictionary<string, MapResourceDownloadSession> m_DownloadSessionsByExportUrl;

	private readonly Dictionary<string, MapResourceDownloadSession> m_ActiveDownloadSessionsByMapCode;

	private readonly Dictionary<string, MapResourceCheckProbe> m_CheckProbesByExportUrl;

	private EventDispatcher m_RegisteredDispatcher;

	private bool m_Destroyed;

	public UGCMapResourceModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	private bool HasDownloadingInGameSession()
	{
		return false;
	}

	public int DownloadMapResource(string mapCode)
	{
		return 0;
	}

	public void CheckMapResourceDownloaded(string mapCode, Action<int, int, int> callback)
	{
	}

	private void ResolveExportUrl(string mapCode, Action<MapResourceExportUrlResult> callback)
	{
	}

	private void RequestExportDataUrl(string mapCode)
	{
	}

	private void FinishResolveExportUrl(string mapCode, MapResourceExportUrlResult result)
	{
	}

	private void ResolveResourceInfo(string mapCode, string exportUrl, Action<MapResourceResolveResult> callback)
	{
	}

	private void RequestSlotInfoForResource(string mapCode, string exportUrl, Action<MapResourceResolveResult> callback)
	{
	}

	private void ResolveGameDataWithExportUrl(string mapCode, SceneEditSlotInfo slotInfo, Action<MapResourceResolveResult> callback)
	{
	}

	private MapResourceResolveResult BuildSuccessResolveResult(SceneEditSlotInfo slotInfo)
	{
		return null;
	}

	private MapResourceResolveResult BuildErrorResolveResult(int errorCode, SceneEditSlotInfo slotInfo = null, string exportUrl = null)
	{
		return null;
	}

	private void OnDownloadExportUrlResolved(string mapCode, MapResourceDownloadSession pendingSession, MapResourceExportUrlResult result)
	{
	}

	private void ContinueDownloadWithExportUrl(string mapCode, MapResourceDownloadSession pendingSession, string exportUrl)
	{
	}

	private void OnDownloadResourceInfoResolved(string mapCode, MapResourceDownloadSession session, MapResourceResolveResult result)
	{
	}

	private bool BuildDownloadSessionTask(MapResourceDownloadSession session)
	{
		return false;
	}

	private UGCSimpleDownloadTask BuildProbeDownloadTask(SceneEditSlotInfo slotInfo)
	{
		return null;
	}

	private void StartDownloadTask(MapResourceDownloadSession session)
	{
	}

	private void ShowDownloadPopup(MapResourceDownloadSession session)
	{
	}

	private void OnCheckExportUrlResolved(string mapCode, MapResourceExportUrlResult result, Action<int, int, int> callback)
	{
	}

	private void OnCheckResourceInfoResolved(MapResourceResolveResult result, Action<int, int, int> callback)
	{
	}

	private void ReplyCheckWithDownloadSession(MapResourceDownloadSession session, Action<int, int, int> callback)
	{
	}

	private bool TryReplyActiveDownloadSessionCheck(string mapCode, string exportUrl, Action<int, int, int> callback)
	{
		return false;
	}

	private MapResourceCheckProbe GetOrCreateCheckProbe(string exportUrl, SceneEditSlotInfo slotInfo)
	{
		return null;
	}

	private int RefreshCheckSessionProgress(MapResourceDownloadSession session, int state)
	{
		return 0;
	}

	private void EvaluateCheckProbe(MapResourceCheckProbe probe, UGCSimpleDownloadTask downloadTask, out int state, out int progress)
	{
		state = default(int);
		progress = default(int);
	}

	private int RefreshCheckProgressWithKnownState(MapResourceCheckProbe probe, UGCSimpleDownloadTask downloadTask, int state)
	{
		return 0;
	}

	private int EvaluateProbeTaskState(UGCSimpleDownloadTask probeTask)
	{
		return 0;
	}

	private bool EnsureDownloadEventsRegistered()
	{
		return false;
	}

	private void UnregisterDownloadEvents()
	{
	}

	private void OnOptionalResourceDownloadRefresh(object[] param)
	{
	}

	private void OnOptionalResourceDownloadFailed(object[] param)
	{
	}

	private void OnDownloadPopupCancel(object[] param)
	{
	}

	private void OnDownloadPopupConfirm(object[] param)
	{
	}

	private void SetDownloadSessionState(MapResourceDownloadSession session, int state, int errorCode, bool forceEvent)
	{
	}

	private void DispatchDownloadSessionEvent(int state, int errorCode, IEnumerable<string> mapCodes)
	{
	}

	private int RefreshDownloadSessionProgress(MapResourceDownloadSession session, bool force = false)
	{
		return 0;
	}

	private int RefreshTaskProgress(UGCSimpleDownloadTask downloadTask, int state, ref int progress, ref float progressCacheTime, bool force)
	{
		return 0;
	}

	private int CalculateTaskProgress(UGCSimpleDownloadTask downloadTask, int state)
	{
		return 0;
	}

	private void DispatchMapResourceDownloadEvent(string mapCode, int state, int errorCode)
	{
	}

	private bool TryNormalizeMapCode(string mapCode, out string normalizedMapCode)
	{
		normalizedMapCode = null;
		return false;
	}

	private int CheckClientReady()
	{
		return 0;
	}

	private EventDispatcher GetCurrentDispatcher()
	{
		return null;
	}

	private bool IsCallbackStale(string source, string mapCode, string exportUrl = null)
	{
		return false;
	}

	private MapResourceDownloadSession CreateDownloadSession()
	{
		return null;
	}

	private void BindMapCodeToDownloadSession(MapResourceDownloadSession session, string mapCode)
	{
	}

	private void DetachMapCodeFromDownloadSession(MapResourceDownloadSession session, string mapCode)
	{
	}

	private void AbandonDownloadSessionIfUnused(MapResourceDownloadSession session)
	{
	}

	private void UpdateDownloadSessionResourceInfo(MapResourceDownloadSession session, string exportUrl, SceneEditSlotInfo slotInfo, bool indexByExportUrl)
	{
	}

	private void RemoveDownloadSessionExportIndex(MapResourceDownloadSession session, string exportUrl)
	{
	}

	private MapResourceDownloadSession FindPopupSession(UGCSimpleDownloadTask task)
	{
		return null;
	}

	private bool IsDownloadInGame()
	{
		return false;
	}

	private void AddFileInfosForPausingInGame(MapResourceDownloadSession session)
	{
	}

	private bool NeedConfirmForNetwork()
	{
		return false;
	}

	private bool IsTaskDownloading(UGCSimpleDownloadTask downloadTask)
	{
		return false;
	}

	private bool TaskContainsFileInfo(UGCSimpleDownloadTask downloadTask, object fileInfoObject)
	{
		return false;
	}

	private int MapHttpErrorToStatusCode(HttpErrorCode errorCode)
	{
		return 0;
	}

	private int MapResErrorToStatusCode(object error)
	{
		return 0;
	}

	private void SafeInvokeCheckCallback(Action<int, int, int> callback, int state, int progress, int statusCode)
	{
	}
}
