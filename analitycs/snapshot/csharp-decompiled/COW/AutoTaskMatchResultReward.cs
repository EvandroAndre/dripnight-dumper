namespace COW;

public class AutoTaskMatchResultReward : AutoPopupTask
{
	private UIMatchResultRewardWndController m_UIMatchResultRewardWndController;

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
