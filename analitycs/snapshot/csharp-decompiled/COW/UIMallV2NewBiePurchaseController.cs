using GCommon;
using proto;

namespace COW;

public class UIMallV2NewBiePurchaseController : UIMallPurchaseBaseController
{
	private StarterStoreItemDesc m_StarterStoreItemDesc;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshData(StarterStoreItemDesc starterStoreItemDesc, bool showVoucherContainer = false, bool canOverflow = false)
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

	private void SetPriceData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
