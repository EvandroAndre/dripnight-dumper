using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeGameplayAffixDetailsDropdownView : UIBaseView
{
	public GameObject ExpandArrowIcon;

	public UIButton DropdownBtn;

	public TweenScale ExpandDetailsGroupTweenScale;

	public TweenAlpha ExpandDetailsGroupTweenAlpha;

	public GameObject ExpandDetailsGroup;

	public UIGrid Grid;

	public UIScrollView DropdownDetailsScrollView;

	public UIPanel DropdownDetailsScrollViewPanel;

	public UIPanel RootPanel;

	public UILabel TimeRangeLabel;

	public GameObject Collapse_CarouselClipPanelGO;

	public UIPanel Collapse_CarouselClipPanel;

	public UIFixTimeCarousel Collapse_FixTimeCarousel;

	public GameObject Expand_TitleGroup;

	public GameObject UIFX_UBAT_01_IDLE_LOOP;

	public Transform UIFX_EnterFromPreview_Root;

	public GameObject Collapse_CarouselProgressBarPanel;

	public UIDragScrollView ScrollViewDragRegion;

	public UIButton ScrollViewDragRegionBtn;

	public UIGrid BossProgressGrid;

	public GameObject DescriptionBG;

	public GameObject CollapseArrowIcon;

	public UILabel CollapseTitleLabel;

	public UILabel ExpandTitleLabel;

	public TweenPosition TimeRangeGroup;

	public TweenPosition Protect;

	public UILabel ProtectLabel;

	public Transform TweenPos1;

	public Transform TweenPos2;

	public Transform TweenPos3;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
