using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTodayBattleReportItemController : UIBaseController, UITable2.IUITable2Item
{
	private enum RankTypeTab
	{
		BR,
		CS
	}

	private UILobbyV2GameAssistTodayBattleReportItemView m_View;

	private AssistTodayBattleReportInfo m_Info;

	private RankTypeTab m_RankTypeTab;

	private UILobbyV2GameAssistTodayBattleReportRankChartController m_RankChartCtrl;

	private UIModelGameAssistantIntroduction m_ModelGameAssistantIntroduction;

	private bool m_NeedRefreshDailyReviewOnNextUpdate;

	private Vector3 m_RankChartOriginLocalPosition;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitRankChart()
	{
	}

	private void InitRankTypeTab()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBRTabClick()
	{
	}

	private void OnCSTabClick()
	{
	}

	private void SelectRankTypeTab(RankTypeTab rankTypeTab)
	{
	}

	private void SetViewData(object data, int index)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public virtual void SetTable2Visible(bool visible)
	{
	}

	private void RefreshDailyReviewViewState()
	{
	}

	private bool HasDailyReviewData(RankTypeTab rankTypeTab)
	{
		return false;
	}

	private int GetMatchCount(RankTypeTab rankTypeTab)
	{
		return 0;
	}

	private RankTypeTab GetDefaultRankTypeTab()
	{
		return RankTypeTab.BR;
	}

	private UIModelGameAssistantIntroduction.DailyReportRankChartAdapterResult GetChartAdapterResult()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
