namespace COW;

public class AutoTaskCupMatchWarmUp : AutoPopupTask
{
	private UICupMatchWarmUpController m_Ctrl;

	private UIModelCupMatch m_Model;

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
