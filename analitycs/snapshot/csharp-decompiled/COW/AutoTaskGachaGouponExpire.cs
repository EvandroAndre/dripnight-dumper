namespace COW;

internal class AutoTaskGachaGouponExpire : AutoPopupTask
{
	private UIGachaCouponExpireInfoController m_PopupWnd;

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
