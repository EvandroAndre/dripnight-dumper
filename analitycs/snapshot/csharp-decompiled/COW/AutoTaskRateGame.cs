namespace COW;

public class AutoTaskRateGame : AutoPopupTask
{
	private static readonly string SHOW_RATEGAME_KEY;

	private UIRateGamePopupWindowController m_RateWindow;

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
