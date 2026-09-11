using System;

namespace GCommon;

public class DownloadContext
{
	public ResDownloadType DownloadType;

	public Action<ResErrorCode, ResDownloadType> FinishedCallBack;

	public ResUpdaterProgressMonitor UpdateProgressMonitor;

	public ResFileLoaderController LoaderController;

	public ResErrorCode LastError;

	private EDownloadContextState _003CState_003Ek__BackingField;

	public long TotalNeedDownloadSize;

	public long TotalRequireSize;

	public EDownloadContextState State
	{
		get
		{
			return _003CState_003Ek__BackingField;
		}
		protected set
		{
			_003CState_003Ek__BackingField = value;
		}
	}

	public bool IsPaused => false;

	public bool IsFinished => false;

	public bool IsStarted => false;

	public bool IsLoaderControllerFinished => false;

	public DownloadContext(ResDownloadType type, int maxLoaderCountSimultaneously)
	{
	}

	public virtual void Clear()
	{
	}

	public void InitContext()
	{
	}

	public void AddLoader(ResFileLoader load, bool is_Retry = false, long progress_size = -1L, bool needMultiThread = false)
	{
	}

	public virtual void PauseDownload(bool isPause, bool is_auto_pause = false)
	{
	}

	public virtual void StartDownload(Action<ResErrorCode, ResDownloadType> callback = null)
	{
	}

	public virtual void InvokeFinishCallBack()
	{
	}

	public void Update(float time)
	{
	}

	public bool HaveEnoughStorage()
	{
		return false;
	}
}
