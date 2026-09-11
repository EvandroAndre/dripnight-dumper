namespace COW;

public class AutoTaskNewBieOfferRemind : AutoPopupTask
{
	private UINewBieOfferRemindController m_NewBieOfferRemindCtrl;

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
