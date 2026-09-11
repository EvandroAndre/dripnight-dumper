namespace GCommon;

public class DownloadTextureReqInfo
{
	public string url;

	public string name;

	public float targetWidth;

	public float targetHeight;

	public NetworkDownloadEngine.OnDowloadFinished finishedCallBack;

	public bool needCache;

	public NetworkDownloadEngine.OnDownloadFailed failedCallBack;

	public bool isReadable;

	public bool sameToLastUrl;

	public uint endTime;

	public bool useOriginUrl;

	public ETextureUsageType textureType;
}
