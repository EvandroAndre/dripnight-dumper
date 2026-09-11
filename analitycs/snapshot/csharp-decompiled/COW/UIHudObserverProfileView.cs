using GCommon;
using UnityEngine;

namespace COW;

public class UIHudObserverProfileView : UIBaseView
{
	public GameObject normalContainer;

	public UILabel name;

	public GameObject profileContainer;

	public UIButton BtnDrop;

	public UIButton BtnRevive;

	public UICountDownLabel ReviveCountDown;

	public UILabel ReviveLabel;

	public GameObject ReviveCoin;

	public UILabel ReviveCoinCount;

	public GameObject UIHudTimer_Ani;

	public Animator TimerAni;

	public AudioSource TimerAud;

	public GameObject SoloMatchContainer;

	public GameObject GroupMatchContainer;

	public UIButton SoloQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public UIButton MultQuickNextBtn;

	public GameObject MatchMaking;

	public Transform QuickBtnClosePosition;

	public UIButton DisableBtn;

	public Transform TopContent;

	public UILabel DisableBtnLabel;

	public GameObject NoticeVFX;

	public GameObject CommonReviveRoot;

	public GameObject CustomReviveRoot;

	public GameObject BriefMatchResult;

	public UIAnchor BriefMatchResultAnchor;

	public UILabel LabelRankNum;

	public UILabel LabelAmount;

	public UILabel OldScoreLabel;

	public UILabel DeltaScoreLabel;

	public UILabel LabelKillNum;

	public UIButton BtnLikeList_01;

	public Transform WishListNode;

	public UIButton BtnSmallDrop;

	public UIButton DisableBigBtn;

	public UILabel DisableBtnBigLabel;

	public GameObject SoloMatchBigContainer;

	public UIButton SoloQuickNextBigBtn;

	public UIButton MultQuickNextBigBtn;

	public GameObject GroupMatchBigContainer;

	public UIButton ReadyBigBtn;

	public GameObject ReadyBigLabel;

	public GameObject CancelReadyBigLabel;

	public GameObject NoticeBigVFX;

	public GameObject BigMatchMaking;

	public UIButton BtnBigRevive;

	public UICountDownLabel ReviveBigCountDown;

	public UILabel ReviveBigLabel;

	public GameObject BigReviveCoin;

	public UILabel BigReviveCoinCount;

	public UITable ReviveTable;

	public UITable BigReviveTable;

	public GameObject revivebg;

	public GameObject reviveBigbg;

	public GameObject QuickMatchContainer;

	public GameObject QuickMatchBigContainer;

	public Transform InteractionHorizantol;

	public Transform InteractionVertical;

	public Transform RankingTipsTransForm;

	public GameObject ReplacementProfileInfo;

	public UISprite ReplacementHeadPic;

	public UISprite ReplacementBanner;

	public UILabel ReplacementName;

	public UILabel RatingNum;

	public GameObject Rating;

	public UIGrid BriefMatchResultGrid;

	public UIAnchor TopContainer;

	public GameObject AskReviveSmallContainer;

	public GameObject AskReviveBigContainer;

	public UIButton BtnAskRevive;

	public UIButton AskReviveDisableBtn;

	public UITable AskReviveDisableTable;

	public UICountDownLabel AskReviveDisableCountDown;

	public UIButton BtnBigAskRevive;

	public UIButton AskReviveBigDisableBtn;

	public UITable AskReviveBigDisableTable;

	public UICountDownLabel AskReviveBigDisableCountDown;

	public UIButton PostMatchTeamUpBigBtn;

	public UIProgressBar BigProcessBar;

	public UILabel PostMatchTeamUpBigBtnLabel;

	public UIButton PostMatchBigBtnSmallDrop;

	public UIButton PostMatchQuickNextBigBtn;

	public GameObject PostMatchBigContainer;

	public UICheckboxButton TrainingGameAutoReviveBtn;

	public UIWidget TrainingGameAutoReviveBtnWidget;

	public UIButton PostMatchTeamUpBtn;

	public UILabel PostMatchTeamUpBtnLabel;

	public UIProgressBar ProcessBar;

	public UIButton PostMatchBtnSmallDrop;

	public UIButton PostMatchQuickNextBtn;

	public GameObject PostMatchContainer;

	public GameObject PostMatchTeamUpBtnPopup;

	public UILabel ReasonLabel;

	public GameObject PostMatchTeamUpBigBtnPopup;

	public UILabel BigReasonLabel;

	public GameObject RatingMedalContainer;

	public UILabel RatingNumMedal_Normal;

	public UISprite RatingMedalBG;

	public GameObject ColorBG_Normal;

	public GameObject ColorBG_Silvery;

	public GameObject ColorBG_Golden;

	public UILabel RatingNumMedal_Golden;

	public UILabel RatingNumMedall_Silvery;

	public UIColor ColorBG;

	public UIButton PostMatchCancelBtn;

	public UIButton PostMatchCancelBigBtn;

	public VFXCreateHelper ThumbPos;

	public VFXCreateHelper BigThumbPos;

	public GameObject BigCountdownContainer;

	public UILabel BigCountDownLabel;

	public UISprite BigCountdownIcon;

	public GameObject CountdownContainer;

	public UILabel CountDownLabel;

	public UISprite CountdownIcon;

	public GameObject PostMatchTeammateContainerPos;

	public GameObject BigPostMatchTeammateContainerPos;

	public UILabel NewScrollLabel;

	public UILabel NewBigScrollLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
