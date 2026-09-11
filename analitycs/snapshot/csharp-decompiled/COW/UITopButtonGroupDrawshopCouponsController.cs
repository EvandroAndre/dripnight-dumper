using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITopButtonGroupDrawshopCouponsController : UITopButtonGroupGachaCouponsController
{
	private UIModelDrawShop m_ModelDrawShop;

	private UIModelInventory m_ModelInventory;

	private UIDrawShopCouponTipsNewController m_DrawShopCouponTipsCtrl;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void Reset()
	{
	}

	protected override void OnCouponButtonClick()
	{
	}

	protected override void GetData(out List<ResourceID> resList, out uint couponCount)
	{
		resList = null;
		couponCount = default(uint);
	}

	private void GetSingleExchangeData(List<KeyValuePair<uint, uint>> tokenItemList, out List<ResourceID> resList, out uint couponCount)
	{
		resList = null;
		couponCount = default(uint);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Reset()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCouponButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_GetData(out List<ResourceID> P0, out uint P1)
	{
		P0 = null;
		P1 = default(uint);
	}
}
