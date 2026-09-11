namespace COW;

public class AutoTaskAnniversaryRemind : AutoPopupTask
{
	private UIAnniversaryRemindWndController m_Ctrl;

	private const string AUTO_TASK_ANNIVERSARY_REMIND_KEY = "AUTO_TASK_ANNIVERSARY_REMIND_KEY_{0}";

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
