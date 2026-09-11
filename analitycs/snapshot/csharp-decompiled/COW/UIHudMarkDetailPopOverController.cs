using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIHudMarkDetailPopOverController : UIBaseController
{
	private UIHudMarkDetailPopOverView m_View;

	private UIClickMask m_ClickMask;

	private UIWidget m_MaskWidget;

	private List<UIHippoCrisisPopItemController> m_CacheItemCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowData(EILKGGIDJEH type, List<uint> items, uint levelId)
	{
	}

	private void UpdateItemsView(List<uint> ids)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateMaskContainer()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
