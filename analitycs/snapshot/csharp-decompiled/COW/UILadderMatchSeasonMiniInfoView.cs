using GCommon;
using UnityEngine;

namespace COW;

public class UILadderMatchSeasonMiniInfoView : UIBaseView
{
	public UIButton DetailBtn;

	public GameObject ContentContainer;

	public GameObject PointRankGroup;

	public GameObject CSRankGroup;

	public GameObject SeasonOpeningObj;

	public GameObject SeasonClosedObj;

	public UILabel CurRankName;

	public ParticleSystem VFX_Loop;

	public GameObject LabelScoreTip;

	public UIButton BtnProtectTip;

	public GameObject LabelProtectTip;

	public TweenAlpha TweenTip;

	public TweenAlpha BarTween;

	public UISprite BarPointFg;

	public UIProgressBar BarProgressPoint;

	public UILabel ScoreInfoLabel;

	public UILabel FinalRankName;

	public UIGrid CSStarGrid;

	public GameObject csstar1;

	public GameObject csstar2;

	public GameObject csstar3;

	public GameObject csstar4;

	public GameObject csstar5;

	public GameObject csblackstar1;

	public GameObject csblackstar2;

	public GameObject csblackstar3;

	public GameObject csblackstar4;

	public GameObject csblackstar5;

	public UILabel MaxRankTxt;

	public UILabel CSRankName;

	public UIWrapContent WrapContent;

	public Transform countDown;

	public UIButton QuickStartBtn;

	public UIWidget QuickStartBtnWidget;

	public GameObject BgRankOpening;

	public GameObject BgRankUnopen;

	public GameObject CSTipsRoot;

	public UILabel CSNextLevelLabel;

	public GameObject CSBottomTip;

	public UILabel CSBottomTipLabel;

	public GameObject DailyMissionContainer;

	public GameObject ToggleRankGroup;

	public UILabel LabelToggleRank;

	public UIButton ToggleRank;

	public GameObject ToggleRankSelected;

	public Animator LadderAni;

	public GameObject RankCardContainer;

	public UIButton RankingCardTipsButton;

	public GameObject RankingDboulePointCardIcon;

	public UISprite RankingNoDeductCardIcon;

	public GameObject BRTipsRoot;

	public UIButton TipsMiddleBtn;

	public UIWidget WidgetTipsMiddle;

	public Transform TipsMiddleTransform;

	public UILabel BRTipsTopLabel;

	public GameObject BRBottomTip;

	public UILabel BRTipsBottomLabel;

	public UITable Table;

	public GameObject Thumb;

	public GameObject GreyBg;

	public UISprite CSRankingNoDeductCardIcon;

	public UIButton ProtectionPointTipsButton;

	public Transform ProtectionPointPos;

	public GameObject BRBelowGrandmasterGroup;

	public GameObject BRReachGrandMasterGroup;

	public UILabel BRGrandMasterScoreLabel;

	public Transform WeaponPowerPos;

	public Transform CSRankIconContainer;

	public Transform BRRankIconContainer;

	public UIButton BRShareBtn;

	public UIButton CSShareBtn;

	public Transform NextBRRankIconRoot;

	public Transform NextCSRankIconRoot;

	public UIGrid MissionDotGrid;

	public Transform MissionDotGridTransform;

	public UIScrollView ScrollView;

	public UIWidget CrossMatchModeTipsRoot;

	public UIButton CrossMatchModeBtn;

	public UISprite CrossMatchModeIcon;

	public UIWidget BRLadderGuideWidget;

	public UIWidget CSLadderGuideWidget;

	public UIWidget QuickStartGuideWidget;

	public GameObject HippoCrisisGameInfoContainer;

	public UIGrid HippoCrisisGameInfoGrid;

	public Transform HippoCrisisGameInfoGridTransform;

	public Transform HCRankIconContainer;

	public UISprite ScoreIcon;

	public UISprite MaxRankScoreIcon;

	public GameObject HippocrisisBg;

	public GameObject ContentBg;

	public GameObject HCTipsRoot;

	public Transform NextHCRankIconRoot;

	public UILabel HCTipsBottomLabel;

	public GameObject HCBottomTip;

	public UILabel HCTipsTopLabel;

	public GameObject TipsContainer;

	public Transform UIFX_EffectAnchor;

	public UITable BRTopTipTable;

	public UITable CSTopTipTable;

	public UILabel CardDescLabel;

	public GameObject BRRankingDoubleBonusCardIcon;

	public GameObject CSRankingDoubleBonusCardIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
