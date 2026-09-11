namespace COW;

public class AutoTaskCheckClipBoard : AutoPopupTask
{
	private UIWorkshopDetailController m_Ctrl;

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
