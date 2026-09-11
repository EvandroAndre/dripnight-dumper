using GCommon;
using Spine.Unity;
using UnityEngine;

namespace COW;

public class UISeasonReplayView : UIBaseView
{
	public UIButton ShareBtn;

	public UISprite GiftTip;

	public GameObject Content;

	public UIButton OverviewBtn;

	public UIButton DestinyBtn;

	public UIButton SocialBtn;

	public GameObject FirstPage;

	public Animation FirstPageAnim;

	public GameObject SeasonContainer;

	public UIButton FirstPageBtn;

	public UILabel SeasonLabel;

	public UIButton NextBtn;

	public AnimatedAlpha NextBtnAlpha;

	public UISeasonReplayUtil BtnsUtil;

	public UIGrid BtnsGrid;

	public UIWidget BtnsGridWidget;

	public UITexture FirstPageBG;

	public UIButton FirstPageCloseBtn;

	public UILabel SeasonLabe2;

	public GameObject SocialSelected;

	public GameObject DestinySelected;

	public GameObject OverviewSelected;

	public UIButton BattleStylelBtn;

	public GameObject BattleStyleSelected;

	public UILabel WelcomeLabel;

	public UILabel PageTitle;

	public GameObject CloudContainer;

	public Animation KellySpineContainer;

	public GameObject SeasonReplay_A;

	public SkeletonAnimation SeasonReplay_Ani;

	public GameObject UIFX_Seasonreplay_once;

	public UILabel NextBtnLabel;

	public Animation UIFXBG_Ani;

	public UISprite NextBtnIcon;

	public UISprite Logo;

	public Transform LogoTitlePos;

	public Transform LogoTitleSharePos;

	public GameObject UIFX_Seasonreplay;

	public UILabel StartLabel;

	public UISprite ShareIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
