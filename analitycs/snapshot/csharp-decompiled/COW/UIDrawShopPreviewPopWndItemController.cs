using GCommon;

namespace COW;

public class UIDrawShopPreviewPopWndItemController : UIBaseController
{
	private UIDrawShopPreviewPopWndItemView m_View;

	private UIStandardItemMiniController m_ItemCtrl;

	private uint m_ChestId;

	private uint m_GoodsId;

	private BaseItemInfo m_ItemInfo;

	private bool m_IsGrandPrize;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(uint chestId, uint goodsId, BaseItemInfo itemInfo, bool isGrandPrize = false)
	{
	}

	private void RefreshStateDisplay()
	{
	}

	private void RefreshVFX()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
