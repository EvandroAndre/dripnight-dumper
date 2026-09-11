using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNormalMatchResultView : UIBaseView
{
	public Animator HudNormalMatchResAni;

	public UILabel RankNum;

	public UILabel TotalNum;

	public UILabel ResultDesc;

	public Transform BaseReward;

	public UILabel GameModeTxt;

	public UILabel GameMapTxt;

	public GameObject WorkShopGo;

	public UILabel TitleInfo1Txt;

	public UILabel TitleInfo2Txt;

	public UILabel TitleInfo3Txt;

	public UILabel TitleInfo4Txt;

	public Transform PlayerItemInfo1;

	public Transform PlayerItemInfo2;

	public Transform PlayerItemInfo3;

	public Transform PlayerItemInfo4;

	public UIButton ShareBtn;

	public UIButton NextBtn;

	public UILabel NextBtnTime;

	public UILabel NextBtnLable;

	public UIButton ReplayBtn;

	public UIGrid RewardBtnGrid;

	public UIButton VideoGiftBtn;

	public UIButton FastSendGiftBtn;

	public Transform CallSignContainer;

	public GameObject ShareInfoContainer;

	public UILabel ShareGameModeTxt;

	public UIButton DataBtn;

	public GameObject NormalTitleRoot;

	public UICustomParamUtil DataTitleCustomParamUtil;

	public UILabel TitleDataTxt;

	public UILabel TitleInfo5Txt;

	public GameObject TitlePlayerTxt;

	public UISprite DataBtnIcon;

	public UILabel DataBtnLabel;

	public UITable BottomLeftTable;

	public GameObject RankInfo;

	public Transform AvatarBoxRoot;

	public UILabel ResultDescEx;

	public GameObject TitleLvBg;

	public GameObject ResultDescExRoot;

	public GameObject icon;

	public GameObject WinStreakContainer;

	public UITexture BGInFrontEndScene;

	public GameObject MaskBG;

	public UIGrid BattleTagGird;

	public UIGrid HQPageSwtichBtnGrid;

	public UIButton AvatarPageBtn;

	public UIColor AvatarPageBG;

	public UISprite AvatarPageIcon;

	public UIButton NormalPageBtn;

	public UIColor NormalPageBG;

	public UISprite NormalPageIcon;

	public UIButton DataPageBtn;

	public UIColor DataPageBG;

	public UISprite DataPageIcon;

	public UIButton SoloQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public UIButton MultQuickNextBtn;

	public GameObject MatchMaking;

	public UILabel MentionLabel;

	public UIButton DisableBtn;

	public GameObject MatchFeedbackContainer;

	public UIButton MatchFeedbackBtn;

	public UIButton DetailBtn;

	public UISprite DetailBtnIcon;

	public UILabel RankDesc;

	public GameObject ScreenshotContainer;

	public UILabel DisableBtnLabel;

	public GameObject NoticeVFX;

	public UILabel MatchIDAndAcounntId;

	public UIGrid GroupMedals;

	public UIWidget MedalsWidget;

	public UICustomParamUtil uiCustomParamUtil;

	public UIButton ReportBtn;

	public UIButton BlockBtn;

	public TweenAlpha BlockIcon;

	public GameObject BlockTips;

	public Transform ReplayDisplay;

	public Transform RankingTipsTransForm;

	public UIButton ModeNextBtn;

	public GameObject ModeSuccessContainer;

	public GameObject ModeFailedContainer;

	public UILabel TitleInfo6Txt;

	public UILabel TitleInfo7Txt;

	public UIButton TitleInfo2Tip;

	public UIColor ColorBG;

	public Transform DataPageRedTipsContainer;

	public GameObject RankRootContainer;

	public GameObject PosterShareIcon;

	public GameObject NormalShareIcon;

	public UITable ShareInfoBottom;

	public UILabel ClanName;

	public UISprite ClanInfoFrameIcon;

	public UISprite ClanInfoIcon;

	public GameObject RankRatingContainer;

	public GameObject GoldBg;

	public GameObject SilveryBg;

	public UILabel RankRatingLabel;

	public UILabel LeftTitleRankRatingTxt;

	public UIButton BRRankRatingTip;

	public UIWidget LeftTeamBRRatingGuideWidget;

	public UIButton PostMatchTeamUpBtn;

	public UILabel PostMatchTeamUpBtnLabel;

	public UIProgressBar ProcessBar;

	public UIButton PostMatchBtnSmallDrop;

	public UIButton PostMatchQuickNextBigBtn;

	public GameObject PostMatchTeamUpBtnPopup;

	public UILabel ReasonLabel;

	public UIButton PostMatchCancelBigBtn;

	public VFXCreateHelper ThumbPos;

	public UILabel RankRatingLabelSilver;

	public GameObject CountdownContainer;

	public UILabel CountDownLabel;

	public UISprite CountdownIcon;

	public GameObject PostMatchTeammateContainerPos;

	public UILabel NewScrollLabel;

	public UIButton InviteBtn;

	public GameObject TryInviteIcon;

	public GameObject FinishInviteIcon;

	public GameObject EmulatorIcon;

	public UIButton BRMatchReviewBtn;

	public UIWidget BRMatchReviewWidget;

	public GameObject BRMatchReviewBubbleContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
