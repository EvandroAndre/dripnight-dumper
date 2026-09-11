using System.Collections.Generic;
using GCommon;

namespace COW;

internal class PlatformPromotionProductMessageBoxController : UIPopupWindowController
{
	private List<PlatformPromotionProductsData> m_PlatformPromotionProductResults;

	private UICommonRewardPreviewWndView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private UIModelPayment m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void InitItem()
	{
	}

	private void SetViewData()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
