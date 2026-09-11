using GCommon;
using proto;

namespace COW;

public class UIMallDiscountPurchaseController : UIMallPurchaseBaseController
{
	private DiscountStoreDesc m_DiscountStoreDesc;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnGemsPurchaseBtnClick()
	{
	}

	private void OnGoldPurchaseBtnClick()
	{
	}

	private void PurchaseDiscountItem(EInventory.CurrencyType currencyType)
	{
	}

	public void RefreshData(DiscountStoreDesc discountStoreDesc, bool showVoucherContainer = false, bool canOverflow = false)
	{
	}

	private void SetPriceData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
