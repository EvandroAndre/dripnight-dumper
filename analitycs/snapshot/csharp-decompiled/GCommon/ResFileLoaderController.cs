using System;
using System.Collections.Generic;
using System.Threading;

namespace GCommon;

public class ResFileLoaderController
{
	public class HashWorkerData
	{
		public List<ResHashFileLoader> loaders;

		public ManualResetEvent doneEvent;
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public ResHashFileLoader loader;

		public ResFileLoaderController _003C_003E4__this;

		internal void _003CpoolHashWorker_003Eb__0()
		{
		}
	}

	private int m_MaxLoaderCountSimultaneously;

	private bool m_IsPause;

	private long m_SizeLoaded;

	private LinkedList<ResFileLoader> m_Loaders;

	private LinkedList<ResFileLoader> m_RunningLoaders;

	private LinkedList<ResFileLoader> m_BackGroundLoaders;

	private LinkedList<ResFileLoader> m_BackGroundRunningLoaders;

	private HashSet<string> m_FinishedFilePath;

	private string m_CachedNetworkType;

	private Action<ResVersionInfo.FileInfo> m_LoaderFinishedCallBack;

	private bool m_SupportBackgroundDownload;

	private List<ResHashFileLoader> m_PoolLoader;

	private int m_TotalHashWorkerCount;

	private long m_MTHashLoadingSize;

	private ManualResetEvent mtHashDoneEvents;

	private List<ResFileLoader> m_FinishedLoader;

	public ResFileLoaderController(int maxLoaderCountSimultaneously)
	{
	}

	public void SetControllerSupportBackground(bool support = false)
	{
	}

	public void AddLoader(ResFileLoader loader, bool addToFirst = false)
	{
	}

	public void AddLoaderToMTQueue(ResFileLoader loader)
	{
	}

	public void BeginMultiThreadHash()
	{
	}

	private void PushHashDataToWork(HashWorkerData data)
	{
	}

	private void poolHashWorker(object d)
	{
	}

	public void PauseAndRemoveAllLoader()
	{
	}

	public void RemoveLoader(ResFileLoader loader)
	{
	}

	public void RemoveLoaderForDelete(ResFileLoader loader)
	{
	}

	public bool CheckLoadersContainsTarget(ResFileLoader loader)
	{
		return false;
	}

	public void Clear()
	{
	}

	public float GetSizeLoaded()
	{
		return 0f;
	}

	public static void ClearReusedMemMap()
	{
	}

	public void PauseDownload(bool isPause, bool is_auto_pause)
	{
	}

	public long Update(float time)
	{
		return 0L;
	}

	private long UpdateDownload(float time)
	{
		return 0L;
	}

	public long UpdateInBackgroundDownload(float time)
	{
		return 0L;
	}

	public bool IsFinished()
	{
		return false;
	}

	public void WaitForMTHashFinish()
	{
	}

	public ResVersionInfo.FileInfo CurrentDownloadFileInfo()
	{
		return null;
	}

	public void CacheNetwordInfo(float seconds)
	{
	}

	public void SetLoaderFinishedCallBack(Action<ResVersionInfo.FileInfo> call_back = null)
	{
	}

	private void LoaderRemoveAction(ResVersionInfo.FileInfo fileinfo)
	{
	}
}
