namespace COW;

public class AutoTaskLadderLeaderBoardEnterWnd : AutoPopupTask
{
	private UILadderLeaderBoardEnterWndController m_EnterWndController;

	private UIModelWeaponPower m_ModelWeaponPower;

	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

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
