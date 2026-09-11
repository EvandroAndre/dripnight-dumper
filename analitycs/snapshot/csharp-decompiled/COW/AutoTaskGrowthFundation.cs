namespace COW;

public class AutoTaskGrowthFundation : AutoPopupTask
{
	private UIGrowthFundAdController m_GrowthFundationUI;

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
