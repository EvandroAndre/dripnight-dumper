using GCommon;
using proto;

namespace COW;

public class UIPrimeMallPurchseController : UIMallPurchaseBaseController
{
	protected PrimeStoreItemDesc m_PrimeStoreItem;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void OnPurchaseBtnClick()
	{
	}

	public virtual void RefreshData(PrimeStoreItemDesc primeItem, uint count = 1u)
	{
	}

	public void SetUIData(BaseItemInfo baseItemInfo, uint coinsPrice, uint gemsprice, bool showVoucherContainer = false, int defaultCount = 1, bool showSpecialConfirmCon = false)
	{
	}

	private void SetPriceData(int defaultCount = 1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
