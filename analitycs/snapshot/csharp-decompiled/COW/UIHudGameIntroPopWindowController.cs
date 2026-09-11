using GCommon;

namespace COW;

public class UIHudGameIntroPopWindowController : UIPopupWindowController
{
	private uint m_DelayCallId;

	private UIHudFootballGameIntroView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	private void _003COnUIInit_003Eb__3_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
