namespace COW;

public class AutoTaskClanLevelUp : AutoPopupTask
{
	private UIClanLevelUpController m_LevelUpUI;

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
