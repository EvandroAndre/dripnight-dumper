using GCommon;

namespace COW;

public class UIDrawShopCDNChangeSkinTokenWheelContentController : UIDrawShopUnlimitedTokenWheelContentController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIDrawShopUnlimitedBuyBtnController OpenBuyController()
	{
		return null;
	}

	protected override UIDrawShopUnlimitedCardPoolController OpenCardPoolController()
	{
		return null;
	}

	public UIDrawShopUnlimitedBuyBtnController _003C_003EiFixBaseProxy_OpenBuyController()
	{
		return null;
	}

	public UIDrawShopUnlimitedCardPoolController _003C_003EiFixBaseProxy_OpenCardPoolController()
	{
		return null;
	}
}
