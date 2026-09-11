using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UISeasonStatsDetailController : UINavigationController, IUIModelDataChangeObserver
{
	private UISeasonStatsDetailView m_View;

	private DLBMPCCFKKM m_MatchMode;

	private UIModelPeriodicLadderMatch m_ModelLadderMatchPeriodic;

	private List<SeasonStatsData> m_StatsDataList;

	private UIModelLadderMatch m_ModelBRLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	private UIModelCSPeakTournamentLadderMatch m_ModelCSPeakTournamentLadderMatch;

	private UIModelSeasonYear m_ModelSeasonYear;

	private EShareLadderIconType m_ShareLadderIconType;

	private UISeasonStatsDetailItemController m_ItemCtrl;

	private UISeasonStatsDetailInfoItemController m_InfoItemCtrl;

	private UIStandardTabRemakeController m_LeftTabCtrl;

	private List<StandardTabItemViewData> m_LeftTabDataList;

	private UIStandardTopTabController m_TopTabCtrl;

	private List<StandardTopTabItemViewData> m_TopTabDataList;

	private uint m_BRSeasonYearId;

	private uint m_CSSeasonYearId;

	private bool m_CSPeakInfoNotified;

	private bool m_CSPeakStatsNotified;

	private bool m_CSPeakHistoryNotified;

	private Vector3 m_HistorySeasonDataNoticeOriPos;

	private int m_Index;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitTopTab()
	{
	}

	private void InitLeftTab()
	{
	}

	private void OnTopTabClick(int index)
	{
	}

	private void OnLeftTabClick(int index)
	{
	}

	private void SetStatsData()
	{
	}

	private void InitSeasonStatsItemTemplate()
	{
	}

	private void SetStatsItems()
	{
	}

	private void RefreshUI()
	{
	}

	private void OnDetailInfoOpen(object[] data)
	{
	}

	private void PlayItemAnim()
	{
	}

	private void OnDetailInfoScreenShot(object[] data)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void OnClickBtnClose()
	{
	}

	private bool CanShowPeriodicRank()
	{
		return false;
	}

	private void RefreshScrollPos()
	{
	}

	private UITable2.IUITable2Item _003CInitSeasonStatsItemTemplate_003Eb__33_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitSeasonStatsItemTemplate_003Eb__33_1()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
