using GCommon;
using UnityEngine;

namespace COW;

public class UIHudLadderMatchResultView : UIBaseView
{
	public Animation LadderRankInfoAnim;

	public UISprite RankAfterSprite;

	public UILabel RankNameAfter;

	public GameObject HeroicLevelAfterContainer;

	public UISprite RankBeforeSprite;

	public UILabel RankNameBefore;

	public GameObject Shine;

	public UIProgressBar ProgressBar;

	public UILabel CurScoreTxt;

	public UILabel AddScoreTxt;

	public UILabel ResultBonousInfoTxt;

	public GameObject TokeInfoOB;

	public UILabel SurvivalTimeTxt;

	public UILabel TokenTxt;

	public UIButton TokenDetailBtn;

	public UIButton BackMaskBtn;

	public Transform RankResultBigAniContainer;

	public GameObject AntiHackContainer;

	public UILabel MapBonusTxt;

	public UIGrid BonusGrid;

	public GameObject HeroicLevelBeforeContainer;

	public UIButton DetailScoreTitleTip;

	public UITable DetailScoreContentTable;

	public Transform DetailScoreContentTableTransform;

	public UIButton WeaponPowerTitleTip;

	public Transform WeaponPowerTitleTipPos;

	public UITable WeaponPowerContentTable;

	public Transform WeaponPowerContentTableTransform;

	public UITable SpecialBonusTable;

	public Transform SpecialBonusTableTransform;

	public Animation MainContainerAnim;

	public GameObject WeaponPowerContainer;

	public Transform UIFX_RankAfterIcon;

	public Transform UIFX_RankBeforeIcon;

	public Animation ShieldAnim;

	public Transform GrandMasterPosChangeTransForm;

	public Transform FirstReachRankContainer;

	public UILabel SpecialMissionLabel;

	public GameObject OccupationUpdateContainer;

	public UIButton OccupationUpdateTitleTipBtn;

	public UITable OccupationUpdateContentTable;

	public UITable RightTable;

	public Transform CrossModeTipContainer;

	public UILabel MatchModeTypeLabel;

	public UISprite ScoreIcon;

	public GameObject HippocrisisBg;

	public GameObject BgContent;

	public Transform UIFX;

	public UIPanel RankRelocationContainer;

	public Transform RankRelocationBonusPos;

	public GameObject PointNotCalculateLabel;

	public GameObject DetailScoreContainer;

	public GameObject ScoreCon;

	public GameObject RadioScoreContainer;

	public UILabel RadioLabel;

	public UILabel RadioDescLabel;

	public GameObject RatingQuickUpgradeBubble;

	public UILabel RatingBubbleLabel;

	public VFXCreateHelper RatingExplodeVFX;

	public GameObject TrailStartPos;

	public GameObject ScoreInfoContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
