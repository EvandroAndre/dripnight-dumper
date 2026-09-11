namespace COW;

public class AutoTaskBindAccount : AutoPopupTask
{
	private UIBindAccountController m_UIBindAccountController;

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public bool IsNeedBindAccountWndShow()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
