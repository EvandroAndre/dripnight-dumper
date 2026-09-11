using GCommon;

namespace COW;

public class UIStandardItemWeaponPriceController : UIBaseController
{
	public UIStandardItemWeaponPriceView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshUnFreeItemView(uint item_id, uint coins_price, uint gems_price, float discount_value, bool havePurchaseTimes)
	{
	}

	public void RefreshDiscountItemView(bool havePurchaseTimes, bool isUniqueAndOwned, float discount_value)
	{
	}

	public void SetDiscountVFXActive(bool active)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
