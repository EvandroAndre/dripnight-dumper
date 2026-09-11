namespace COW;

internal class AutoTaskCSPeakTournamentInvitation : AutoPopupTask
{
	private UICSPeakTournamentInvitationController m_InvitationCtrl;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournament;

	private UISettingController m_CurrentSettingCtrl;

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
