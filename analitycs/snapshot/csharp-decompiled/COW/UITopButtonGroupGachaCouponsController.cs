using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITopButtonGroupGachaCouponsController : UIBaseController
{
	protected UITopButtonGroupGachaCouponsView m_View;

	private UIModelGacha m_ModelGacha;

	private UIModelInventory m_ModelInventory;

	private List<UISprite> CouponList;

	private const int MaxShowCount = 3;

	protected uint m_ChestId;

	protected UIGachaCouponTipsNewController m_CouponTipsNewCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void OnCouponButtonClick()
	{
	}

	public void SetViewData(uint chestId)
	{
	}

	protected virtual void GetData(out List<ResourceID> resList, out uint couponCount)
	{
		resList = null;
		couponCount = default(uint);
	}

	protected virtual void Reset()
	{
	}

	public UIWidget GetCouponGuideWidget()
	{
		return null;
	}

	public UIWidget GetCouponIconsWidget()
	{
		return null;
	}

	public UIButton GetCouponButton()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
