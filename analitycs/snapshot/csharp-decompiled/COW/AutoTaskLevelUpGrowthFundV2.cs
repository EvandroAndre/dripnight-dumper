namespace COW;

public class AutoTaskLevelUpGrowthFundV2 : AutoPopupTask
{
	private UIGrowthFundAnnounceController m_Ctrl;

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
