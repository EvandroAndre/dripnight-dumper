namespace COW;

public class AutoTaskPrimeLevelRecover : AutoPopupTask
{
	private UIPrimeLevelRecoverController m_LeveRecoverUI;

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
