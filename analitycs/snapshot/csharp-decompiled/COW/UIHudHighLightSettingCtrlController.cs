using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudHighLightSettingCtrlController : UIBaseController
{
	private UIHudHighLightSettingCtrlView m_View;

	private List<UIHudHighLightSettingItemController> children;

	private readonly int unit_height;

	private uint m_DelayCallID;

	private bool m_show;

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

	private void RefreshItemsChosenUI()
	{
	}

	private void OnClickHighlightSettingCallback(object[] args)
	{
	}

	private void OnClickReplayToggleCallback(object[] args)
	{
	}

	private void OnHudReplayStartHide(object[] args)
	{
	}

	private void _003COnHudReplayStartHide_003Eb__11_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
