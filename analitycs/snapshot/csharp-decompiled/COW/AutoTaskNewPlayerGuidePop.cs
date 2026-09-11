namespace COW;

public class AutoTaskNewPlayerGuidePop : AutoPopupTask
{
	private string m_GuideKey;

	private NewbieGuideId m_GuideId;

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
