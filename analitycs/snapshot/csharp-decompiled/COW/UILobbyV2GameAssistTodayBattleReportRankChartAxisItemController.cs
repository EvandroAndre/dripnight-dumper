using GCommon;

namespace COW;

public class UILobbyV2GameAssistTodayBattleReportRankChartAxisItemController : UIBaseController
{
	private UILobbyV2GameAssistTodayBattleReportRankChartAxisItemView m_View;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIBRRankIconController m_BRRankIconCtrl;

	private UICSRankIconController m_CSRankIconCtrl;

	private float m_ContentLeftBoundaryX;

	private const float LabelRightX = 56.5f;

	private const float ItemGap = 2f;

	private const float RankIconWidth = 18f;

	private const float RankIconScale = 0.18f;

	private const string CSStarIconName = "FF_UI_Rank_CS_star1";

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

	public void SetViewData(bool isBR, string valueText, int brScore, int csRankPoint, int csRank)
	{
	}

	public float GetValueLabelPrintedWidth()
	{
		return 0f;
	}

	public void RefreshLayoutByMaxLabelPrintedWidth(bool isBR, float maxLabelPrintedWidth)
	{
	}

	public float GetLeftOverflow(float chartLeftAnchorLocalX)
	{
		return 0f;
	}

	private void RefreshRankIcon(bool isBR, int brScore, int csRankPoint, int csRank)
	{
	}

	private int GetCSRankByRankPoint(int csRankPoint)
	{
		return 0;
	}

	private int GetBRRankByRankPoint(int score)
	{
		return 0;
	}

	private void RefreshLayout(bool isBR, float maxLabelPrintedWidth)
	{
	}

	private void CloseBRRankIcon()
	{
	}

	private void CloseCSRankIcon()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
