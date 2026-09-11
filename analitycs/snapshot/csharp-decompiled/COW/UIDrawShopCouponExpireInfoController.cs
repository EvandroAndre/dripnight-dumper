using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIDrawShopCouponExpireInfoController : UIGachaCouponExpireInfoController
{
	private const string PREFS_KEY_PREFIX = "DRAWSHOP_COUPON_EXPIRATION_NOTI";

	private UIModelDrawShop m_ModelDrawShop;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override List<Item> GetExpiringCouponItems()
	{
		return null;
	}

	protected override int FindSelectItemChestID()
	{
		return 0;
	}

	protected override void OnBtnClick()
	{
	}

	protected override string GetPrefsKeyPrefix()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public List<Item> _003C_003EiFixBaseProxy_GetExpiringCouponItems()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_FindSelectItemChestID()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrefsKeyPrefix()
	{
		return null;
	}
}
