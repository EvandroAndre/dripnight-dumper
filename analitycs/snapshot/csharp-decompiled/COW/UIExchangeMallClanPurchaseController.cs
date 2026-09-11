using GCommon;
using proto;

namespace COW;

public class UIExchangeMallClanPurchaseController : UIExchangeMallPurchseController
{
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

	public override void RefreshData(ExchangeStoreItemDesc exchangeStoreItem, EFromType fromType = EFromType.NONE)
	{
	}

	public new int _003C_003EiFixBaseProxy_get_ItemCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_set_ItemCount(int P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshData(ExchangeStoreItemDesc P0, EFromType P1)
	{
	}
}
