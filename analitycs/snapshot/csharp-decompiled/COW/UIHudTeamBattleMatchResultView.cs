using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTeamBattleMatchResultView : UIBaseView
{
	public Animator HudTeamBattleAni;

	public GameObject Defeat;

	public UILabel DefeatTxt;

	public UILabel ResultDesc;

	public UILabel GameModeTxt;

	public UILabel GameMapTxt;

	public GameObject WorkShopGo;

	public GameObject Victory;

	public UILabel VictoryTxt;

	public GameObject Draw;

	public UILabel DrawTxt;

	public UISprite LeftTeamScoreBG;

	public UILabel LeftTeamScore;

	public GameObject LeftTeamDividingLine;

	public GameObject LeftTeamDefaultIconOB;

	public GameObject LeftTeamDefaultIcon;

	public UISprite LeftTeamClanIcon;

	public UISprite LeftTeamIcon;

	public UILabel LeftTeamName;

	public UISprite LeftTeamCustomIcon;

	public UILabel LeftTitleInfo1Txt;

	public UILabel LeftTitleInfo2Txt;

	public UILabel LeftTitleInfo3Txt;

	public Transform LeftTeammate1;

	public Transform LeftTeammate2;

	public Transform LeftTeammate3;

	public Transform LeftTeammate4;

	public UISprite RightTeamScoreBG;

	public UILabel RightTeamScore;

	public GameObject RightTeamDividingLine;

	public GameObject RightTeamDefaultIconOB;

	public GameObject RightTeamDefaultIcon;

	public UISprite RightTeamClanIcon;

	public UISprite RightTeamIcon;

	public UILabel RightTeamName;

	public UISprite RightTeamCustomIcon;

	public UILabel RightTitleInfo1Txt;

	public UILabel RightTitleInfo2Txt;

	public UILabel RightTitleInfo3Txt;

	public Transform RightTeammate1;

	public Transform RightTeammate2;

	public Transform RightTeammate3;

	public Transform RightTeammate4;

	public UIButton ShareBtn;

	public UIButton NextBtn;

	public UILabel NextBtnTime;

	public UILabel NextBtnLable;

	public UIButton ReplayBtn;

	public UIGrid RewardBtnGrid;

	public UIButton LikeBtn;

	public Transform LikeBtnTransform;

	public UIButton AddFriendBtn;

	public Transform AddFriendBtnTransform;

	public UIButton ReportBtn;

	public Transform ReportBtnTransform;

	public UIButton VideoGiftBtn;

	public UIButton FastSendGiftBtn;

	public Transform CallSignContainer;

	public GameObject MultiDetailInfo;

	public UIScrollView TeamInfoScrollViewLeft;

	public UIGrid GridLeft;

	public UIScrollView TeamInfoScrollViewRight;

	public UIGrid GridRight;

	public GameObject MoreKill;

	public GameObject OppTeamMoreInfo;

	public UILabel MyTeamMoreLabel;

	public GameObject MyTeamMoreInfo;

	public UILabel OppTeamMoreLabel;

	public GameObject ShareInfoContainer;

	public UILabel ShareGameModeTxt;

	public UIButton DataBtn;

	public GameObject LeftNormalTitleRoot;

	public UILabel LeftTitleDataTxt;

	public GameObject RightNormalTitleRoot;

	public UILabel RightTitleDataTxt;

	public GameObject LeftTitlePlayerTxt;

	public GameObject RightTitlePlayerTxt;

	public UISprite DataBtnIcon;

	public UILabel DataBtnLabel;

	public UITable BottomLeftTable;

	public GameObject WinStreakContainer;

	public UITexture BGInFrontEndScene;

	public GameObject MaskBG;

	public GameObject icon;

	public UIGrid BattleTagGrid;

	public UIGrid HQPageSwtichBtnGrid;

	public UIButton AvatarPageBtn;

	public UIButton NormalPageBtn;

	public UIButton DataPageBtn;

	public UIColor AvatarPageBG;

	public UIColor NormalPageBG;

	public UIColor DataPageBG;

	public UISprite AvatarPageIcon;

	public UISprite NormalPageIcon;

	public UISprite DataPageIcon;

	public UIButton SoloQuickNextBtn;

	public UIButton ReadyBtn;

	public GameObject ReadyLabel;

	public GameObject CancelReadyLabel;

	public UIButton MultQuickNextBtn;

	public GameObject MatchMaking;

	public UIButton DisableBtn;

	public UILabel MentionLabel;

	public GameObject MatchFeedbackContainer;

	public UIButton MatchFeedbackBtn;

	public UIButton DetailBtn;

	public UISprite DetailBtnIcon;

	public GameObject ScreenshotContainer;

	public UILabel DisableBtnLabel;

	public UILabel MatchIdAndAccountId;

	public GameObject NoticeVFX;

	public UISprite LeftTeamCSIcon;

	public UIButton LeftTeamRankBtn;

	public UISprite RightTeamCSIcon;

	public UIButton RightTeamRankBtn;

	public Transform LeftTeamIconNewStyle;

	public Transform RightTeamIconNewStyle;

	public GameObject Invalid;

	public UIGrid GroupMedals;

	public UIWidget MedalsWidget;

	public GameObject PopContainer;

	public UIButton BlockBtn;

	public Transform BlockBtnTransform;

	public GameObject DefeatMVP;

	public UISprite SpecialLabelIcon;

	public UILabel SpecialLabel;

	public TweenAlpha BlockIcon;

	public GameObject BlockTips;

	public Transform ReplayDisplay;

	public GameObject LeftClanInfo;

	public UISprite LeftClanIconFrame;

	public UISprite LeftClanIcon;

	public UINetworkTexture LeftClanCDNIcon;

	public GameObject RightClanInfo;

	public UINetworkTexture RightClanCDNIcon;

	public UISprite RightClanIcon;

	public UISprite RightClanFrame;

	public Transform RankingTipsTransForm;

	public GameObject CSRankRatingContainer;

	public UILabel CSRankRatingSilverLabel;

	public GameObject CSRankRatingSilverGameObject;

	public UILabel LeftTitleRankRatingTxt;

	public UIButton CSRankRatingTip;

	public UILabel RightTitleRankRatingTxt;

	public GameObject DetailDataInfoUI;

	public GameObject DataLeftTeamContainer;

	public UISprite DataLeftTeamIcon;

	public UILabel DataLeftTeamName;

	public UIButton DataLeftTeamBtn;

	public GameObject DataLeftTeamSelectedContainer;

	public GameObject DataLeftTeamUnSelectedContainer;

	public GameObject DataRightTeamContainer;

	public UISprite DataRightTeamIcon;

	public UILabel DataRightTeamName;

	public UIButton DataRightTeamBtn;

	public GameObject DataRightTeamSelectedContainer;

	public GameObject DataRightTeamUnSelectedContainer;

	public UILabel DataTitleRankRatingTxt;

	public UILabel DataTitleInfo1Txt;

	public UILabel DataTitleInfo2Txt;

	public UILabel DataTitleInfo3Txt;

	public UIButton DataTitleInfo3Tip;

	public UILabel DataTitleInfo4Txt;

	public UILabel DataTitleInfo5Txt;

	public UILabel DataTitleInfo6Txt;

	public UILabel DataTitleInfo7Txt;

	public Transform DataPlayerItemInfo1;

	public Transform DataPlayerItemInfo2;

	public Transform DataPlayerItemInfo3;

	public Transform DataPlayerItemInfo4;

	public UIButton DataRankRatingTip;

	public GameObject DataLeftClanInfo;

	public UISprite DataLeftClanIconFrame;

	public UISprite DataLeftClanIcon;

	public GameObject DataRightClanInfo;

	public UISprite DataRightClanIconFrame;

	public UISprite DataRightClanIcon;

	public Transform DataPageRedTipsContainer;

	public GameObject DetailInfoUI;

	public UIWidget LeftTeamCSRatingGuideWidget;

	public Animation QuickReportAnim;

	public UILabel QuickReportLabel;

	public UIButton QuickReportBtn;

	public Transform DataLeftTeamIconPos;

	public Transform DataRightTeamIconPos;

	public UISprite LeftTeamInfoBG;

	public UISprite LeftTeamLine01;

	public UISprite LeftTeamLine02;

	public UISprite RightTeamInfoBG;

	public UISprite RightTeamLine01;

	public UISprite RightTeamLine02;

	public GameObject PosterShareIcon;

	public GameObject NormalShareIcon;

	public UITable ShareInfoBottom;

	public UILabel ClanName;

	public UISprite ClanInfoFrameIcon;

	public UISprite ClanInfoIcon;

	public UISprite DetailDataBgLeft;

	public UISprite DetailDataBgRight;

	public UISprite DetailDataBgLeftChange;

	public UISprite DetailDataBgRightChange;

	public UISprite TeamHeadIcon_L;

	public UISprite TeamHeadIcon_R;

	public UISprite SilveryBg;

	public UISprite GoldBg;

	public UISprite GrayBg;

	public UIButton InviteDuelBtn;

	public GameObject WaitingDuelWidget;

	public UIButton AcceptDuelBtn;

	public GameObject RefuseDuelWidget;

	public UIButton CSRankRatingTipRight;

	public UIButton PostMatchTeamUpBtn;

	public UILabel PostMatchTeamUpBtnLabel;

	public UIProgressBar ProcessBar;

	public GameObject PostMatchTeamUpBtnPopup;

	public UILabel ReasonLabel;

	public UIButton PostMatchBtnSmallDrop;

	public UIButton PostMatchQuickNextBigBtn;

	public GameObject CSRankRatingGoldGameObject;

	public UILabel CSRankRatingGoldLabel;

	public UIButton PostMatchCancelBigBtn;

	public VFXCreateHelper ThumbPos;

	public GameObject CountdownContainer;

	public UILabel CountDownLabel;

	public UISprite CountdownIcon;

	public GameObject PostMatchTeammateContainerPos;

	public UILabel NewScrollLabel;

	public UIButton InviteBtn;

	public GameObject TryInviteIcon;

	public GameObject FinishInviteIcon;

	public GameObject EmulatorIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
