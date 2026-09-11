namespace COW;

internal class AutoTaskCSPeakTournamentSeasonChange : AutoPopupTask
{
	private UICSPeakTournamentSeasonChangeController m_SeasonChangeCtrl;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournament;

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
