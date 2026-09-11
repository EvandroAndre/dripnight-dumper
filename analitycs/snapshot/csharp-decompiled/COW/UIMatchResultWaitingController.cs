using GCommon;

namespace COW;

public class UIMatchResultWaitingController : UIPopupWindowController
{
	private UIMatchResultWaitingView m_View;

	private bool m_WaitingTimeState;

	private float m_WaitingTime;

	public bool ActiveState;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override int GlassDelay()
	{
		return 0;
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

	private void SetGlassColor()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
