namespace COW;

internal class AutoTaskBigEventIconAutoEntry : AutoPopupTask
{
	public static string PrefAutoTaskBigEventIcon;

	private UIBigEventLobbyIconWndController m_PopupWnd;

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
