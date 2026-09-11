using GCommon;
using proto;

namespace COW;

public class UIDrawShopTokenExchangeItemController : UIGachaTokenExchangeItemController
{
	protected DrawShopWheelExchangeDesc m_DrawShopExchangeItem;

	protected UIDrawShopTokenExchangeController m_DrawShopTokenExchangeController;

	protected UIModelDrawShop m_ModelDrawShop;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected new void RefreshItemView()
	{
	}

	private uint GetExchangePurchasedTimes(uint exchangeId)
	{
		return 0u;
	}

	private void SetExchangeInfo()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
