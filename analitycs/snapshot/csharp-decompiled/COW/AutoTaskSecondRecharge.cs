namespace COW;

public class AutoTaskSecondRecharge : AutoPopupTask
{
	private UISecondRechargeController m_SecondRechargeUI;

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
