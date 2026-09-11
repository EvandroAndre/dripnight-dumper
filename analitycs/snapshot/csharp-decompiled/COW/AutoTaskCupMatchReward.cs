namespace COW;

public class AutoTaskCupMatchReward : AutoPopupTask
{
	private UICupMatchRewardWndController m_Ctrl;

	private UIModelCupMatch m_ModelCupMatch;

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
