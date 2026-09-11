using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyV2GameAssistTodayBattleReportRankChartView : UIBaseView
{
	public GameObject Container;

	public UISprite ChartBg;

	public UIWidget Alignment;

	public UIPanel PanelClip;

	public UIScrollView PanelClipScrollView;

	public LineRenderer LineRenderer;

	public Transform AxisGrid;

	public UILabel AxisLabelTemplate;

	public Transform GridLineRoot;

	public UISprite PointTemplate;

	public UILabel ScoreChangeLabelTemplate;

	public UILabel TimeLabelTemplate;

	public Transform ChartContent;

	public MeshFilter MeshFilter;

	public MeshRenderer MeshRenderer;

	public Transform AxisItemTemplate;

	public UISprite AxisRankIconTemplate;

	public UISprite AxisStarIconTemplate;

	public UILabel AxisValueLabelTemplate;

	public Transform ChartPointItemTemplate;

	public UISprite ChartNormalPointTemplate;

	public UISprite ChartHighlightIconTemplate;

	public UILabel ChartChangeLabelTemplate;

	public UISprite ChartStarIconTemplate;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
