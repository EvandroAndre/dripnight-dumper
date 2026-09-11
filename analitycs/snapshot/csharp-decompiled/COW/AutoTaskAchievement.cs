namespace COW;

public class AutoTaskAchievement : AutoPopupTask
{
	private UIFrontEndScene m_UIFrontEndScene;

	public override bool Do()
	{
		return false;
	}

	public bool IsShowTipsBox()
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
