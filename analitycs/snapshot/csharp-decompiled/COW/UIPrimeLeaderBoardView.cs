using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimeLeaderBoardView : UIBaseView
{
	public GameObject UIPrimeLeaderBoard;

	public UIEasyList ContentList;

	public UIToggleButton FriendToggleButton;

	public UIToggleButton RegionToggleButton;

	public UIButton Share;

	public GameObject LeaderBoardContainer;

	public GameObject TipsNoData;

	public UITable FilterTable;

	public UIGrid ToggleBtnGrid;

	public UIToggleButtonGroup ToggleBtnGroup;

	public UIButton LocalizationBtn;

	public GameObject ToggleBG;

	public UICheckboxButton DoNotUseBtn;

	public Transform TimeFilterPopMenu;

	public Transform FriendFilterPopMenu;

	public GameObject TopRightContainer;

	public UIScrollView ContentScrollView;

	public UIButton ExpandLeaderBoardBtn;

	public UIButton CloseLeaderBoardBtn;

	public UIColor SelfBG;

	public Transform SelfLBContainer;

	public GameObject SelfInfo;

	public GameObject FirstLoading;

	public GameObject SecondLoading;

	public GameObject ThirdLoading;

	public Transform ThirdPlaceBaseProfileTrans;

	public Transform SecondPlaceBaseProfileTrans;

	public GameObject FirstPlaceBaseProfileTrans;

	public GameObject FirstPlaceContainer;

	public GameObject SecondPlaceContainer;

	public GameObject ThirdPlaceContainer;

	public UILabel ThirdPlacePointsLabel;

	public UILabel SecondPlacePointsLabel;

	public UILabel FirstPlacePointsLabel;

	public GameObject ReachTopNoticeContainer;

	public Animation ReachTopNoticeAnim;

	public GameObject RankUpNoticeContainer;

	public Animation RankUpNoticeAnim;

	public UILabel NoticeRankDescLabel;

	public UILabel NoticeTitleLabel;

	public UILabel NoticeRankLabel;

	public UILabel ContinueLabel;

	public UIButton ReachTopContinueBtn;

	public UILabel NoticeRankLabelBefore;

	public UILabel NoticeTitleLabelAfter;

	public UILabel EnterLeaderBoardRankLabel;

	public GameObject EnterLeaderBoardContainer;

	public GameObject RankUpContainer;

	public GameObject Empty;

	public UINetworkTexture LeaderBoardBrd;

	public UINetworkTexture CrownCDN;

	public UINetworkTexture ReachTopLabelCDN;

	public UIButton ReachTopMask;

	public UIPanel Board;

	public GameObject TopRight;

	public GameObject MainContainer;

	public UIButton FirstCheckBtn;

	public UIButton SecondCheckBtn;

	public UIButton ThirdCheckBtn;

	public UISprite SecondPrimeBadgeIcon;

	public PrimeSmallBadgeVfxUtil SecondPrimeSmallBadgeVfxUtil;

	public UISprite ThirdPrimeBadgeIcon;

	public PrimeSmallBadgeVfxUtil ThirdPrimeSmallBadgeVfxUtil;

	public UISprite FirstPrimeBadgeIcon;

	public PrimeSmallBadgeVfxUtil FirstPrimeSmallBadgeVfxUtil;

	public UISprite ExpandArrorDown;

	public UISprite ExpandArrorUp;

	public UILabel LeaderBoardScoreLabel;

	public Transform ThirdDownloadPos;

	public Transform SecondDownloadPos;

	public Transform FirstDownloadPos;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
