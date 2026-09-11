namespace COW;

public class AutoTaskClanLuckyBag : AutoPopupTask
{
	private UILuckyBagController m_LuckyBagUI;

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
