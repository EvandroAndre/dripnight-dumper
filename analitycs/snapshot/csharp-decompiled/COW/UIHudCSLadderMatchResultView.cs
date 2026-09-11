using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCSLadderMatchResultView : UIBaseView
{
	public Animation RankInfoAnim;

	public UISprite RankAfterSprite;

	public UITable RankAfterStarTable;

	public Animation AfterLabelAnim;

	public UILabel CurRankCountLabel_2;

	public UILabel CurLabelHeriocStarMax_2;

	public UILabel CurRankCountLabel;

	public UILabel CurLabelHeriocStarMax;

	public UILabel RankNameAfter;

	public UISprite RankBeforeSprite;

	public UITable RankBeforeStarTable;

	public Animation BeforeLabelAnim;

	public UILabel BeforeRankCountLabel;

	public UILabel BeforeLabelHeriocStarMax;

	public UILabel BeforeRankCountLabel_2;

	public UILabel BeforeLabelHeriocStarMax_2;

	public UILabel RankNameBefore;

	public GameObject ScoreInfoContainer;

	public UIButton BackMaskBtn;

	public GameObject RankStar;

	public Transform RankResultBigAniContainer;

	public Animation ShieldAnim;

	public GameObject AntiHackProtectTipContainer;

	public UIButton ProtectTitleTip;

	public UITable ProtectDetailContentTable;

	public Transform ProtectDetailContentTableTransform;

	public UIButton WeaponPowerTitleTip;

	public UITable WeaponPowerContentTable;

	public Transform WeaponPowerContentTableTransform;

	public Transform ProtectCircleIconPos;

	public Animation MainContainerAnim;

	public GameObject ProtectionCompensationTip;

	public Transform ProtectPointStarVFXPos;

	public UILabel MatchModeTypeLabel;

	public Transform RankAfterLabelStarPos;

	public Transform RankBeforeLabelStarPos;

	public GameObject WeaponPowerContainer;

	public Transform UIFX_RankAfterIcon;

	public Transform UIFX_RankBeforeIcon;

	public Transform FirstSpecialBouns;

	public Transform SecondSpecialBonus;

	public GameObject RankRelocationContainer;

	public UIPanel RankRelocationContainerPanel;

	public Transform RankRelocationBonusPos;

	public UILabel ProtectionNotCalculateLabel;

	public Transform GrandMasterPosChangeTransForm;

	public Transform FirstReachRankContainer;

	public GameObject InvalidMatch;

	public GameObject SpecialMissionContainer;

	public UITable NotifyInfoTable;

	public GameObject OccupationUpdateContainer;

	public UIButton OccupationUpdateTitleTipBtn;

	public UITable OccupationUpdateContentTable;

	public UITable RightTable;

	public Transform CrossModeTipContainer;

	public GameObject LargeRankGapNoStar;

	public UIButton LargeRankGapNoStarTipBtn;

	public UITable SpecialTipsContainer;

	public UILabel LargeRankGapNoStarLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
