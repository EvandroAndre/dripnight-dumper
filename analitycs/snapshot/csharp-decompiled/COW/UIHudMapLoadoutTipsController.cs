using GCommon;

namespace COW;

public class UIHudMapLoadoutTipsController : UIBaseController
{
	private UIHudMapLoadoutTipsView m_View;

	private uint m_DelayHideTicket;

	private int m_DefaultBGLeftAnchorAbsolute;

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

	public void RefreshView(string label, ResourceID resId, bool needDelayHide = false, string iconSpriteName = "")
	{
	}

	public void PlayAnim()
	{
	}

	private void ClearDelayCall()
	{
	}

	private void _003CRefreshView_003Eb__6_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
