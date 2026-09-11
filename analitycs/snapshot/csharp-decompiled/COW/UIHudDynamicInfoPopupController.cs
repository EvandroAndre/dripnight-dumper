using GCommon;

namespace COW;

internal class UIHudDynamicInfoPopupController : UIBaseController
{
	private UIHudDynamicInfoPopupView m_View;

	private uint m_DelayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetMessage(string message, float duration)
	{
	}

	private void AutoHide()
	{
	}

	private void CancelDelayCall()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
