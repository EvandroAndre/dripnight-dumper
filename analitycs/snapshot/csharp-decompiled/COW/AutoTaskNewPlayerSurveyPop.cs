namespace COW;

public class AutoTaskNewPlayerSurveyPop : AutoPopupTask
{
	private UILobbyNewPlayerSurveyPopWindowController m_PlayerSurveyPopWindowCtrl;

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
