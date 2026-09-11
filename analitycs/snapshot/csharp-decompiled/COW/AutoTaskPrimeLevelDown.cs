namespace COW;

public class AutoTaskPrimeLevelDown : AutoPopupTask
{
	private UIPrimeLevelDownController m_LevelDownUI;

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
