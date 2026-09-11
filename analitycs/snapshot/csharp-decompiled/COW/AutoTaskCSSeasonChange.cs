namespace COW;

internal class AutoTaskCSSeasonChange : AutoPopupTask
{
	private UICSLadderMatchSeasonChangeController m_CsSeasonChangeCtrl;

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
