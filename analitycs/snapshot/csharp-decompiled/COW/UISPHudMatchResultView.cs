using GCommon;
using UnityEngine;

namespace COW;

public class UISPHudMatchResultView : UIBaseView
{
	public UIButton PrevBtn;

	public UILabel MatchMapTxt;

	public UILabel MatchModeTxt;

	public UITexture bg;

	public UITexture LocalBG;

	public GameObject infoPanel;

	public UITable LeftTable;

	public UIScrollView RightScrollView;

	public TweenPosition RightScrollViewTWPosition;

	public TweenAlpha RightScrollViewAlpha;

	public UIPanel RightScrollViewPanel;

	public UITable RightTable;

	public GameObject infoPanelQuad;

	public UITable LeftTableQuad;

	public UIScrollView RightScrollViewQuad;

	public TweenAlpha RightScrollViewQuadTWAlpha;

	public TweenPosition RightScrollViewQuadTWPosition;

	public UIPanel RightScrollViewQuadPanel;

	public UITable RightTableQuad;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
