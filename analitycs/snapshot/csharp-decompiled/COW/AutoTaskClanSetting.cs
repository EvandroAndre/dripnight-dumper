namespace COW;

public class AutoTaskClanSetting : AutoPopupTask
{
	private UIClanEditController m_Ctrl;

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
