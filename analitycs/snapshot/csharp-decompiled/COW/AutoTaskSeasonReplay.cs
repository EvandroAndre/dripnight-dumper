namespace COW;

public class AutoTaskSeasonReplay : AutoPopupTask
{
	private UISeasonReplayController m_SeasonReplay;

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
