using UnityEngine.Networking;

namespace COW.Gameplay.UGC;

public class UGCDownloadResourceInfo
{
	public UGCResourceForGameData.PackageOrABFileInfo FileInfo;

	public UnityWebRequest WWW;

	public string FileName;

	public float TotalTimeout;

	public float ConnectionTimeout;

	public float NoProgressTimeout;

	public EventLogger.EventTypeUGCLoadingGameDataDownload LogInfo;

	public bool IgnoreDownloading => false;

	public void SendLogInfo()
	{
	}

	public void ClearLogInfo()
	{
	}
}
