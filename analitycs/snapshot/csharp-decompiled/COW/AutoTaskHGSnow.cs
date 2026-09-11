namespace COW;

public class AutoTaskHGSnow : AutoPopupTask
{
	private UIHGSnowDifficultySelectionController m_HGSnowDifficultySeletionCtrl;

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
