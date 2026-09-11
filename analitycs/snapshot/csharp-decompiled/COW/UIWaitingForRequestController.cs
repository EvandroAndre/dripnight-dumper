using GCommon;

namespace COW;

internal class UIWaitingForRequestController : UIBaseController
{
	protected UIWaitingForRequestView m_View;

	private bool m_WaitingTimeState;

	private float m_WaitingTime;

	public bool ActiveState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetBlockClick(bool flag)
	{
	}

	private void Update()
	{
	}

	private void ShowRoot(bool isShow)
	{
	}

	public void RequestFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
