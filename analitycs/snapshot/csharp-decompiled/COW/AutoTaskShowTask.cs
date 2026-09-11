namespace COW;

internal class AutoTaskShowTask : AutoPopupTask
{
	private UITaskController m_TaskUI;

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
