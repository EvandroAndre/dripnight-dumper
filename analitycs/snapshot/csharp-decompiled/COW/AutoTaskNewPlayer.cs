namespace COW;

public class AutoTaskNewPlayer : AutoPopupTask
{
	private UINewPlayerV3Controller m_NewPlayerUI;

	private const int SHOWED = 1;

	private const int UNSHOWED = 0;

	private const string NEWPLAYER = "NEWPLAYER";

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
