namespace COW;

public class AutoTaskGrowthFundV2 : AutoPopupTask
{
	private UIGrowthFundAnnounceController m_GrowthFundAnnounceCtrl;

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
