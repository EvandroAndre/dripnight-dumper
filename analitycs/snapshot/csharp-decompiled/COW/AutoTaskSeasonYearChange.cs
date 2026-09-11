using GCommon;

namespace COW;

internal class AutoTaskSeasonYearChange : AutoPopupTask
{
	private UIBaseNavigationController m_SeasonYearMainController;

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
