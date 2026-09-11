using GCommon;

namespace COW;

internal class UIHUDFFWSCabinWaitTopTipController : UIBaseController
{
	private UIHUDFFWSCabinWaitTopTipView m_View;

	private uint m_DelayId;

	private VisualInstanceHolder m_UIFXHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetIcon(string spriteName)
	{
	}

	private void OnFlagBannerFinish(object[] data)
	{
	}

	private void OnAnimEnd()
	{
	}

	private void OnCabinPhaseEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
