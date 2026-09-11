using GCommon;
using proto;

namespace COW;

public class UIDrawShopPurchaseController : UIMallPurchaseBaseController
{
	private DrawShopWheelExchangeDesc m_ExchangeDesc;

	private UIModelDrawShop m_ModelDrawShop;

	private UIModelInventory m_ModelInventory;

	private uint m_DrawShopId;

	private uint m_PurchaseTimes;

	private bool m_HaveEnoughMaterial;

	private bool m_CanExchangeByDiamond;

	protected override int ItemCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(DrawShopWheelExchangeDesc desc, uint purchaseTimes, bool haveEnoughMaterial, bool canExchangeByDiamond, bool showModifyCountContainer = false)
	{
	}

	private void UpdateExchangeButtonState()
	{
	}

	private void SetExchangePrice()
	{
	}

	protected void SetExchangeIcon(UISprite sprite, uint itemID)
	{
	}

	private void OnExchangeBtnClick()
	{
	}

	private void SetMainCurrencyIcon(UISprite sprite)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}
}
