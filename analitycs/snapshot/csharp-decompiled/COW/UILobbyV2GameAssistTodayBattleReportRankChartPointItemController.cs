using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTodayBattleReportRankChartPointItemController : UIBaseController
{
	private UILobbyV2GameAssistTodayBattleReportRankChartPointItemView m_View;

	private UIModelLadderMatch m_ModelLadderMatch;

	private UIModelCSLadderMatch m_ModelCSLadderMatch;

	private UIBRRankIconController m_BRRankIconCtrl;

	private UICSRankIconController m_CSRankIconCtrl;

	private bool m_HasHighlightIcon;

	private const int NormalPointSize = 6;

	private const float ItemGap = 2f;

	private const float RankIconWidth = 24f;

	private const float RankIconScale = 0.24f;

	private const string CSStarIconName = "FF_UI_Rank_CS_star1";

	private static readonly Color PointColor;

	private static readonly Color NormalChangeColor;

	private static readonly Color PositiveHighlightColor;

	private static readonly Color NegativeChangeColor;

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

	public void SetViewData(bool isBR, int change, int brScore, int csRankPoint, int csRank, bool showRankIcon, EHighLightPlayType highlightType)
	{
	}

	public void SetChartPointPosition(Vector2 point)
	{
	}

	private void RefreshRankIcon(bool isBR, int brScore, int csRankPoint, int csRank)
	{
	}

	private int GetCSRankByRankPoint(int csRankPoint)
	{
		return 0;
	}

	private Transform GetPointAnchorTransform()
	{
		return null;
	}

	private int GetBRRankByRankPoint(int score)
	{
		return 0;
	}

	private string FormatChangeValue(int value)
	{
		return null;
	}

	private Color GetChangeColor(int change, bool hasHighlightIcon)
	{
		return default(Color);
	}

	private void RefreshLabelLayout(bool isBR, bool hasRankIcon)
	{
	}

	private void CloseRankIcons()
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
