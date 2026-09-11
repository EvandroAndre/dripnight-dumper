namespace COW;

public class AutoTaskPrimeLevelUp : AutoPopupTask
{
	private UIPrimeLevelUpController m_LevelUpUI;

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
