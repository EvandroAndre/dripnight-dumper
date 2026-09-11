using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIDrawShopCouponTipsNewController : UIGachaCouponTipsNewController
{
	private UIModelDrawShop m_ModelDrawShop;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override List<CSSharedItemData> GetCouponItemsList()
	{
		return null;
	}

	protected override uint GetTotalCouponCount()
	{
		return 0u;
	}

	protected override UINavigationUtil.UINavigationFrom GetNavigationFrom()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public List<CSSharedItemData> _003C_003EiFixBaseProxy_GetCouponItemsList()
	{
		return null;
	}

	public uint _003C_003EiFixBaseProxy_GetTotalCouponCount()
	{
		return 0u;
	}

	public UINavigationUtil.UINavigationFrom _003C_003EiFixBaseProxy_GetNavigationFrom()
	{
		return UINavigationUtil.UINavigationFrom.None;
	}
}
