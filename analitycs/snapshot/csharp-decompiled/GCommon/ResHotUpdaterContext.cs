using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class ResHotUpdaterContext
{
	public uint[] DownloadTypes;

	public string RemoteAddr;

	public string RemoteHotupdateAddr;

	public string VersionInfoPath;

	public string FileInfoPath;

	public bool NeedForceLoadRemoteFileInfo;

	public bool RestartDownloadABHotupdaterForHashCheckError;

	public bool ForceUpdateSucees;

	public string AssetBundlePrefix;

	public int MaxLoaderCountSimultaneously;

	public int MaxOptionalDownloadThreadCount;

	public bool EnableOverrideWithFullData;

	public int MaxRetryCount;

	public int MaxForceUpdateRetryCount;

	public MonoBehaviour CoroutineHolder;

	public Action<ResHotUpdateResult> OnGetRemoteFileInfoFinished;

	public Action<ResHotUpdateResult> OnGetLocalVerionFinished;

	public Action<ResHotUpdateResult> OnStarted;

	public Action<ResErrorCode> OnHotUpdateFinished;

	public List<uint> PendingDownloadTypes;

	public Dictionary<uint, string> OptionalVersionMap;

	public string LocalAddr;

	public string CacheAddr;

	public string StreamFileAddr;

	public string StreamOptionalAddr;

	public string OptionalCacheAddr;

	public string TempCacheAddr;

	public bool NoResourceDownload;

	public bool UseBigFileDownload;

	public string ReleaseVersion;

	public void ClearContextActionReference()
	{
	}
}
