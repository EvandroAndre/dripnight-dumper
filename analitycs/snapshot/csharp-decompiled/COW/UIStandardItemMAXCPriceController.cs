using GCommon;

namespace COW;

public class UIStandardItemMAXCPriceController : UIBaseController
{
	public UIStandardItemMAXCPriceView m_View;

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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
