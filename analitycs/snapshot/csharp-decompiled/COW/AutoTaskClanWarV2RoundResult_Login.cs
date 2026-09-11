namespace COW;

public class AutoTaskClanWarV2RoundResult_Login : AutoPopupTask
{
	private UIClanWarV2RoundResultController m_RoundReasultCtrl;

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
