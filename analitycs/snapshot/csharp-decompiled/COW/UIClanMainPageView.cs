using GCommon;
using UnityEngine;

namespace COW;

public class UIClanMainPageView : UIBaseView
{
	public UILabel MemberCnt;

	public UILabel MemberMaxCnt;

	public UIButton SettingBtn;

	public UISprite ClanIcon;

	public UILabel LabelClanName;

	public UILabel LevelLabel;

	public UIButton BuffBtn;

	public UILabel TotalProgress;

	public UILabel ClanId;

	public UIButton LeaderboardBtn;

	public UIButton InviteBtn;

	public UIButton ClanShopBtn;

	public UITable ClanContributionTable;

	public GameObject RealtimeContribution;

	public GameObject ClanWarLeaderBoard;

	public UICountDownLabel ClanWarLeaderBoardTimeLabel;

	public UIButton WeeklyTeamworkRewardRuleBtn;

	public UILabel CurrentActiveLabel;

	public UIButton InviteFriendBtn;

	public UIGrid ProgressBarGrid;

	public Transform ClanWarLeaderBoardPosition;

	public UILabel RegionLabel;

	public GameObject RegionContainer;

	public GameObject EmptyStateContainer;

	public UIButton InfoBtn;

	public UIButton ClanWarLeaderboardBtn;

	public UIButton ObtainBtn;

	public UINetworkTexture ClanIconCDN;

	public UISprite ClanIconLeftFrame;

	public GameObject Upgrading;

	public GameObject DownGrading;

	public UISprite ClanIconRightFrame;

	public UILabel ClanWarRoundDescLabel;

	public GameObject ActivenessBG;

	public GameObject ClanWarBG;

	public Transform ClanWarHistoryTitlePosition;

	public UITable NameContainerTable;

	public UIButton ClanIdCopyBtn;

	public UITable ClanIdTable;

	public GameObject IconCelebrity;

	public Transform ClanInfoContainer;

	public UIButton RegionBtn;

	public UIWidget ProgressBarGuideWidget;

	public GameObject ProgressBarUpgrading;

	public UIWidget ClanMallGuide;

	public GameObject SettingBtnTips;

	public GameObject ProgressBars;

	public UIProgressBar NormalLevelBar;

	public UIProgressBar MinLevelBar;

	public UIProgressBar DegradeLevelBar;

	public UIButton BtnApply;

	public GameObject Division01;

	public GameObject DegradeMention;

	public UILabel DegradingLabel;

	public GameObject Max;

	public UILabel LowActivityRemindLabel;

	public GameObject LowActivityRemindContainer;

	public GameObject CommonState;

	public Animation PrivilegeState;

	public UIButton PrivilegeClaimBtn;

	public GameObject MoreContainer;

	public UIButton GotoBtn;

	public GameObject PrivilegeExpireBubble;

	public GameObject UIFX_ClanShopBtn;

	public UILabel EffectiveLabel;

	public GameObject PrivilegeEffectiveBubble;

	public GameObject ClanHackerRemindContainer;

	public UILabel ClanHackerRemindLabel;

	public UIButton ClanHackerRemindRuleBtn;

	public GameObject PrivilegeClaimBtnUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
