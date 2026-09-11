using GCommon;
using UnityEngine;

namespace COW;

public class UIHudNormalMatchResultItemView : UIBaseView
{
	public GameObject SelfBG;

	public GameObject WinMVPGrade;

	public GameObject FailMVPGrade;

	public UILabel NormalGrade;

	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public UILabel Nickname;

	public UILabel ClanName;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public UILabel Info4Txt;

	public UIButton AddFriendBtn;

	public UIButton ReportBtn;

	public UIButton LikeBtn;

	public GameObject LikeIcon;

	public UILabel LikeNum;

	public GameObject VFX_Like;

	public UIHudMatchResultItemProgressBar InfoBar1;

	public UIHudMatchResultItemProgressBar InfoBar2;

	public UIHudMatchResultItemProgressBar InfoBar3;

	public UIHudMatchResultItemProgressBar InfoBar4;

	public GameObject DataRoot;

	public UICustomParamUtil DataUICustomParamUtil;

	public GameObject NormalRoot;

	public UILabel InfoDataTxt;

	public UIHudMatchResultItemProgressBar InfoBar5;

	public GameObject StatisticsTips;

	public UIButton TipsButton;

	public UIButton AvatarAttributesEntryBtn;

	public UISprite IndexBG;

	public UILabel IndexLabel;

	public UILabel Info5Txt;

	public UILabel InfoLvTxt;

	public UIButton ProfileBtn;

	public GameObject GradeContainer;

	public UICenterOnChild GradeWrapContent;

	public UIScrollView GradeScroll;

	public GameObject StreakContainer;

	public UILabel StreakTxt;

	public UISprite StreakIcon;

	public GameObject Index;

	public UISprite Sprite4;

	public Transform BadgeContainer;

	public UIGrid BadgeGrid;

	public UISprite BadgeMask;

	public UILabel SelfBadgeNumLabel;

	public UISprite BadgeMaskSelf;

	public GameObject BadgeItemTemp;

	public UIButton BadgeBtn;

	public UICustomParamUtil uiCustomParamUtil;

	public UIButton BlockBtn;

	public UISprite BadgeIconBg;

	public UISprite BadgeIconSprite;

	public UIButton VisitorBtn;

	public GameObject ToxicCheck;

	public GameObject PrivilegeIcon;

	public Transform AvatarFramePos;

	public UIHudMatchResultItemProgressBar InfoBar6;

	public UILabel InfoData2Txt;

	public GameObject RatingContainer;

	public GameObject OnlyRatingContainer;

	public GameObject MvpAndRatingContainer;

	public UILabel OnlyRatingPoint;

	public UILabel RatingPointGold;

	public GameObject FailMVPRatingGrade;

	public GameObject WinMVPRatingGrade;

	public GameObject HasRatingStreakContainer;

	public UILabel HasRatingStreakTxt;

	public UISprite HasRatingStreakIcon;

	public UISprite RatingBg;

	public GameObject UIFX_Golden;

	public GameObject UIFX_Silvery;

	public GameObject UIFX_MVPWin;

	public GameObject UIFX_MVPLose;

	public GameObject UIFX_MVPLoseMain;

	public GameObject UIFX_MVPWinMain;

	public UILabel RatingPointSilvery;

	public VFXCreateHelper GoldVFXHelper;

	public VFXCreateHelper SliverVFXHelper;

	public UIButton InviteBtn;

	public GameObject TryInviteIcon;

	public GameObject FinishInviteIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
