using GCommon;
using proto;

namespace COW;

public class UIMallV2VeteranDiscountPurchaseController : UIMallPurchaseBaseController
{
	private VeteranStoreDesc m_VeteranStoreDesc;

	private UIModelVeteran m_ModelVeteran;

	private uint m_Discount;

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

	public void RefreshData(VeteranStoreDesc discountStoreDesc, bool showVoucherContainer = false)
	{
	}

	private void SetPriceData()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
