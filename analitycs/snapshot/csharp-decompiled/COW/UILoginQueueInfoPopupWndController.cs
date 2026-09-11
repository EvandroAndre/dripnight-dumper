using GCommon;
using proto;

namespace COW;

public class UILoginQueueInfoPopupWndController : UIPopupWindowController
{
	private UILoginQueueInfoPopupWndView m_View;

	private UIModelLogin m_ModelLogin;

	private uint m_Hours;

	private uint m_Mins;

	private uint m_Secs;

	private uint m_RequestInterval;

	private CountDownConfig m_Config;

	private ulong m_StartCountDownTime;

	private ulong m_TotalWaitSec;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateQueueInfo(LoginQueueInfo info, bool IsNew = false)
	{
	}

	private void SetCountDown(uint sec)
	{
	}

	private void UpdateProgressBar()
	{
	}

	private void ReRequestQueueInfo()
	{
	}

	private void OnCancleClick()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public override bool IgnoreEsc()
	{
		return false;
	}

	private void ClearData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return false;
	}
}
