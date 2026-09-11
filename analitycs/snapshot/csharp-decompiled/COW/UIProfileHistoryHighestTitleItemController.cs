using GCommon;

namespace COW;

public class UIProfileHistoryHighestTitleItemController : UIEasyListItemController
{
	private UIProfileHistoryHighestTitleItemView m_View;

	private UILeaderBoardTitleIconController m_LeaderBoardTitleIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
