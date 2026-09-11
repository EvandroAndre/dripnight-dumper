namespace COW;

public class AutoTaskClanWarV2LimitedEventStart : AutoPopupTask
{
	private UIClanWarV2LimitedEventStartController m_Ctrl;

	private const int ALREADY_POPPED = 1;

	private const int NOT_POPPED = 0;

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
