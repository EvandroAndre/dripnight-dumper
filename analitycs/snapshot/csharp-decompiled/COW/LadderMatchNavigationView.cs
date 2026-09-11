using GCommon;
using UnityEngine;

namespace COW;

public class LadderMatchNavigationView : UIBaseView
{
	public GameObject LadderMatchNavigation;

	public Animator Anim;

	public GameObject RewardContainer;

	public UINetworkTextureExt CdnReward;

	public UIButton BtnRewardDetail;

	public UIButton BtnViewAll;

	public GameObject Left;

	public GameObject Center;

	public GameObject Right;

	public Transform SeasonMiniInfoContainer;

	public Transform SeasonStatsContainer;

	public GameObject GoRootPopMenuSelectGameMode;

	public UIButton BtnSelectGameMode;

	public UILabel LabelSelectedGameMode;

	public UINetworkTexture TextureBtnSelectGameMode;

	public UIButton ExchangeCurrencyBtn;

	public UILabel ExchangeCurrencyNum;

	public UISprite ExchangeIcon;

	public UILabel OpenTimeLabel;

	public UILabel SeasonLabel;

	public UIScrollView StageRewardScrollView;

	public UIEasyList RewardEasyList;

	public UILabel ExchangeStoreLabel;

	public UIButton ExchangeStoreBtn;

	public UILabel RankTypeLabel;

	public GameObject StageRewardContainer;

	public GameObject LabelRewardName;

	public UILabel FakePlayerBeatLabel;

	public UITable SeasonLabelTable;

	public GameObject UnlockRewardBtn;

	public UIWidget PreviewWidget;

	public UIButton BtnHistory;

	public UIButton BtnShare;

	public UIButton BooyahPassBtn;

	public UINetworkTexture BooyahpassTexture;

	public BoxCollider BooyahsPassCollider;

	public UILabel SeasonNameLabel;

	public GameObject BooyahPassBubble;

	public GameObject SeasonEndCountDownContainer;

	public GameObject SeasonSwitchContainer;

	public GameObject NormalContainer;

	public GameObject BtnHistoryRedPoint;

	public GameObject Line;

	public UICountDownLabel SeasonEndCountDownLabel;

	public UIButton BtnSeasonYear;

	public UILabel SeasonYearLabel;

	public UIButton BtnSeasonReplay;

	public UIWidget BtnSeasonReplayWidget;

	public GameObject SeasonYearContainer;

	public GameObject NextFirstRankRewardContainer;

	public UISprite NextFirstRankIcon;

	public Transform RankUpRewardRedPoint;

	public Transform SeasonYearRedPointTrans;

	public UIButton LadderMatchLeaderboardBtn;

	public UILabel NextFirstRankRewardLabel;

	public Transform SeasonSwitchCenter;

	public UITable NextFirstRankTable;

	public UIButton BtnRankMission;

	public UITable BtnTable;

	public GameObject SeasonReplayGuidContainer;

	public UIButton BtnJmpToLeaderboard;

	public Transform ExchangeMallTipTransform;

	public UISprite SeasonYearIcon;

	public VFXCreateHelper SeasonYearIconVFX;

	public UIWidget NewBieLadderGuideWidget;

	public UIWidget NewBieLadderGuideWidgetWithLWRank;

	public Transform TopTapContainer;

	public GameObject NormalSeasonLabel;

	public GameObject HippoCrisisSeasonLabel;

	public UITable HCLabelTable;

	public UILabel HCRankTypeLabel;

	public UILabel HCSeasonLabel;

	public UILabel HCOpenTimeLabel;

	public UILabel HCExtraInfoLabel;

	public UILabel HCRankTypeBGLabel;

	public UILabel HCSeasonBGLabel;

	public UILabel SeasonThemeGradientLabel;

	public UINetworkTexture SeasonThemeLabelBgTexture;

	public GameObject TopRight;

	public GameObject TopTab;

	public GameObject RightContainer;

	public GameObject TopLeft;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
