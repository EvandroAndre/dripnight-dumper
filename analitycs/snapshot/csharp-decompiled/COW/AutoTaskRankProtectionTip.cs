namespace COW;

public class AutoTaskRankProtectionTip : AutoPopupTask
{
	private bool m_Hasdone;

	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override bool Do()
	{
		return false;
	}
}
