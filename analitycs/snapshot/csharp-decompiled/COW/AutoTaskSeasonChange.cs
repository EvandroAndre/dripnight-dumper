namespace COW;

internal class AutoTaskSeasonChange : AutoPopupTask
{
	private UILadderMatchSeasonChangeController m_SeasonChangeCtrl;

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
