using GCommon;

namespace COW;

internal class AutoTaskDrawShopGouponExpire : AutoPopupTask
{
	private const string PREFS_KEY_PREFIX = "DRAWSHOP_COUPON_EXPIRATION_NOTI";

	private UIPopupWindowController m_PopupWnd;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
