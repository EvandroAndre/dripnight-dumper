using GCommon;
using UnityEngine;

namespace COW;

public class UIGameModeCSRankSpecialPlayView : UIBaseView
{
	public UIButton SpecialPlayBtn;

	public GameObject Selected;

	public GameObject UnSelected;

	public UILabel ProtectLabel;

	public UILabel Ttile;

	public UISprite PlayIcon;

	public UIWidget GuideWidget;

	public UIButton GuildMaskBtn;

	public UIPanel GuildMaskPanel;

	public TweenPosition Protect;

	public TweenPosition OpeningHours;

	public UILabel OpeningHoursLabel;

	public Transform TweenPos1;

	public Transform TweenPos2;

	public Transform TweenPos3;

	public UIPanel CarouselContainer;

	public GameObject GameModeBorder;

	public GameObject ExpandArrowIcon;

	public UIButton DropdownBtn;

	public GameObject ExpandDetailsGroup;

	public TweenScale ExpandDetailsGroupTweenScale;

	public TweenAlpha ExpandDetailsGroupTweenAlpha;

	public UIScrollView DropdownDetailsScrollView;

	public UIPanel DropdownDetailsScrollViewPanel;

	public UIGrid Grid;

	public UIButton ScrollViewDragRegionBtn;

	public UIDragScrollView ScrollViewDragRegion;

	public GameObject CollapseArrowIcon;

	public UILabel AffixesDescriptionLabel;

	public UIButton CenteredDropdownBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
