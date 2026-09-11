using System.Collections.Generic;

namespace GCommon;

public class ResFileLoader
{
	protected const long HTTP_OK = 200L;

	protected const long HTTP_PartialOK = 206L;

	public static readonly string ERR_OK;

	public static readonly string ERR_SAVE_TEMP_FAILED;

	public static readonly string ERR_TIME_OUT;

	public static readonly string ERR_READ_FAILED;

	public static readonly string ERR_UNZIP_FAILED;

	public static readonly string ERR_INSUFFICIENT_STORAGE;

	public static readonly string ERR_MULTIDOWNLOAD_NOTEMPFILECONFIG;

	public static readonly string ERR_DOWNLOAD_ERROR;

	private static readonly Dictionary<string, int> ErrorMapping;

	public ResFileLoaderState State;

	public string FullPath;

	public string RelativePath;

	public int RetryCount;

	public long TotalSize;

	public string RequestError;

	public ResVersionInfo.FileInfo FileInfo;

	public bool IsInBackGround;

	protected float m_LastProgress;

	public static ResErrorCode MapToErrorCode(string error)
	{
		return ResErrorCode.OK;
	}

	public static bool CheckHttpResposeCode(long response_code)
	{
		return false;
	}

	public static bool IsDiskFull(ResFileLoader loader)
	{
		return false;
	}

	public void Start(float time)
	{
	}

	public void Notify()
	{
	}

	public void Dispose()
	{
	}

	public float UpdateProgress(float time)
	{
		return 0f;
	}

	public float UpdateProgressInThread(float time)
	{
		return 0f;
	}

	public virtual long GetDownloadingSize()
	{
		return 0L;
	}

	protected void SetRequestError(string error)
	{
	}

	public bool HaveError()
	{
		return false;
	}

	public virtual bool IsTimeout(float time)
	{
		return false;
	}

	public virtual bool IsFinished()
	{
		return false;
	}

	protected virtual void OnStart(float time)
	{
	}

	protected virtual void OnDispose()
	{
	}

	protected virtual void OnNotify()
	{
	}

	public virtual bool HasStarted()
	{
		return false;
	}

	protected virtual void OnUpdate(float time)
	{
	}

	protected virtual void OnUpdateInThread(float time)
	{
	}

	public virtual void OnPause()
	{
	}

	public virtual long NeedDownloadSize()
	{
		return 0L;
	}

	public virtual bool IsSupportBackground()
	{
		return false;
	}
}
