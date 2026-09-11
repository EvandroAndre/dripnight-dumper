namespace COW;

public class AutoTaskCSPeakTournamentRankUpReward : AutoPopupTask
{
	private CSPeakTournamentWndCfg m_CurrentCfg;

	private bool isCSPeakDone;

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

	private void OnCSPeakRewardWndClose(object[] param)
	{
	}
}
