using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonReplayOverviewView : UIBaseView
{
	public GameObject Title;

	public UIWidget Alignment;

	public LineRenderer LineRenderer;

	public MeshFilter MeshFilter;

	public MeshRenderer MeshRenderer;

	public UIGrid RankAxis;

	public UILabel Rank;

	public UILabel StartDate;

	public UILabel EndDate;

	public UIPanel PanelClip;

	public UIButton CollapseBtn;

	public UILabel TitleLabel;

	public Animation Main;

	public Transform TitleVFXPos;

	public GameObject ReachedGrandMaster;

	public UIButton ExpandBtn;

	public GameObject SeasonalHighlight;

	public Transform RankIconPos;

	public UIGrid SeasonalHighlightGrid;

	public Transform ExpandGuideContainer;

	public GameObject Expand;

	public UIButton ExpandBtnMini;

	public GameObject Collapse;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
