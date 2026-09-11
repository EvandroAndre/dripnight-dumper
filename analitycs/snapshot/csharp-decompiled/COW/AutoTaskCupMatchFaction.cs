namespace COW;

public class AutoTaskCupMatchFaction : AutoPopupTask
{
	private UICupMatchFactionController m_Ctrl;

	private UIModelCupMatch m_ModelCupMatch;

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
