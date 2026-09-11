using GCommon;
using UnityEngine;

namespace COW;

public class UIHudUGCTeamBattleMatchResultItemView : UIBaseView
{
	public GameObject SelfBG;

	public GameObject WinMVPGrade;

	public GameObject FailMVPGrade;

	public UISprite FailMVPSprite;

	public UILabel NormalGrade;

	public GameObject FakeBg;

	public UIEffectSprite BannerBg;

	public UIEffectSprite HeadIcon;

	public GameObject IconCelebrity;

	public UILabel Nickname;

	public UILabel ClanName;

	public UILabel Info1Txt;

	public UILabel Info2Txt;

	public UILabel Info3Txt;

	public GameObject BtnContainer;

	public UIButton AddFriendBtn;

	public UIButton ReportBtn;

	public UIButton LikeBtn;

	public GameObject LikeIcon;

	public UILabel LikeNum;

	public GameObject VFX_Like;

	public GameObject NormalRoot;

	public GameObject DataRoot;

	public UIHudMatchResultItemProgressBar InfoBar1;

	public UIHudMatchResultItemProgressBar InfoBar2;

	public UIHudMatchResultItemProgressBar InfoBar3;

	public UILabel InfoDataTxt;

	public GameObject StatisticsTips;

	public UIButton TipsButton;

	public UICenterOnChild GradeWrapContent;

	public UILabel StreakTxt;

	public GameObject GradeContainer;

	public GameObject StreakContainer;

	public UIScrollView GradeScroll;

	public UISprite IndexBG;

	public UILabel IndexLabel;

	public GameObject Index;

	public UIButton ProfileBtn;

	public UISprite StreakIcon;

	public GameObject BadgeContainer;

	public UIGrid BadgeGrid;

	public UISprite BadgeMask;

	public UILabel SelfBadgeNumLabel;

	public UICustomParamUtil uiCustomParamUtil;

	public GameObject BadgeTemplate;

	public UIButton BadgeBtn;

	public UIButton BlockBtn;

	public UISprite BadgeMaskSelf;

	public UISprite BadgeIconBg;

	public UISprite BadgeIconSprite;

	public UIButton VisitorBtn;

	public GameObject ToxicChecked;

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
