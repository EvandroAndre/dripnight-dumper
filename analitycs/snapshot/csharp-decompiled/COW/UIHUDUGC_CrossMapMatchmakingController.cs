using System;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIHUDUGC_CrossMapMatchmakingController : UIBaseController
{
	private UIHUDUGC_CrossMapMatchMakingWaitingView m_View;

	private UINewDownloadInfoController m_OptionalMapResDownloader;

	private UGCSimpleDownloadTask m_DownloadTask;

	private float m_Time;

	private int m_TimeoutS;

	private Action m_OnTimeout;

	public Action OnCancel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	protected void OnBtnCancel()
	{
	}

	public void StartDownloadTask(UGCSimpleDownloadTask downloadTask)
	{
	}

	public void UpdateResReadyProgress(int ready, int total)
	{
	}

	public void UpdateMatchmakingProgress(int pre, int after)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
