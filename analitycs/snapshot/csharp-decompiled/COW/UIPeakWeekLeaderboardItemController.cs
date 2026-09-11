using GCommon;

namespace COW;

public class UIPeakWeekLeaderboardItemController : UIBaseController
{
	private UIPeakWeekLeaderboardItemView m_View;

	private UIBaseProfileInfoController m_BaseProfileUI;

	private LeaderBoardInfo m_Data;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int index, LeaderBoardInfo info)
	{
	}

	private void onHeadBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
