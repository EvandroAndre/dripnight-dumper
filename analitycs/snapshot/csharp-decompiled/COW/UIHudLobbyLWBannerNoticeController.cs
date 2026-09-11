using GCommon;

namespace COW;

public class UIHudLobbyLWBannerNoticeController : UIBaseController
{
	private UIHudLobbyLWBannerNoticeView m_View;

	private string m_Title;

	private string m_Desc;

	private ulong m_EndTime;

	private OnFinished m_OnFinished;

	private bool m_IsCountingDown;

	private int m_FrameCounter;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetCountDown(string title, string desc, ulong endTime, OnFinished onFinished = null)
	{
	}

	public void CancelCountDown()
	{
	}

	private void Update()
	{
	}

	private void UpdateLabel()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
