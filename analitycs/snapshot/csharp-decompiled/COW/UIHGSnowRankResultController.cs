using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

internal class UIHGSnowRankResultController : UIBaseController
{
	private int m_CurIndex;

	private List<PVELeaderboardPositionInfo> m_RankData;

	private UIHGSnowRankResultView m_View;

	private const int MAX_AWARD_ITEMS_COUNT = 3;

	private List<UIStandardItemMiniController> m_AwardItemCtrlList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<PVELeaderboardPositionInfo> rankInfoList)
	{
	}

	private void ShowCurRankResult()
	{
	}

	private void OnBtnConfirmClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
