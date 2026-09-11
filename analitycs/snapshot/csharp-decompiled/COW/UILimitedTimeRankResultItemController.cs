using GCommon;
using tcp;

namespace COW;

public class UILimitedTimeRankResultItemController : UIBaseController
{
	private UILimitedTimeRankResultItemView m_View;

	private ModeStatsScoreUpdateNtf m_CurModeStatsScoreUpdateData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRankPointDetailBtnClick()
	{
	}

	public void SetViewData(ModeStatsScoreUpdateNtf data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
