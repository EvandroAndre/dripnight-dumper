namespace COW;

public class AutoTaskClanActiveness : AutoPopupTask
{
	private UISecondConfirmSmallContoller m_SecondConfirmUI;

	private ulong viewTime;

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

	private void _003CDo_003Eb__2_0()
	{
	}
}
