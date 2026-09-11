namespace COW;

public class AutoTaskBindAccountForCompliance : AutoPopupTask
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

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
