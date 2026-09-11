using GCommon;

namespace COW;

public class UIDrawShopLimitedDropRateItemController : UIBaseController
{
	private UIGachaRulesPopUpDropRateV2ItemView m_View;

	private UIStandardItemMiniController m_MiniItem;

	private uint m_DrawShopId;

	private uint m_PoolItemId;

	private string m_Probability;

	private BaseItemInfo m_ItemInfo;

	private UIModelDrawShop m_ModelDrawShop;

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

	public void SetViewInfo(uint drawShopId, uint poolItemId, string probability)
	{
	}

	protected virtual void RefreshDisplay()
	{
	}

	private BaseItemInfo GetItemDataByPoolItemId(uint drawShopId, uint poolItemId)
	{
		return null;
	}

	private void SetStandardItemMini()
	{
	}

	private void SetStatusSprites()
	{
	}

	private bool IsItemRemoved(UIModelDrawShop.DrawShopLimitedPoolContentData limitedData, uint poolItemId)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
