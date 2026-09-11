using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentHallOfFameView : UIBaseView
{
	public UIEasyList ContentList;

	public UIButton Share;

	public GameObject LeaderBoardContainer;

	public GameObject TipsNoData;

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

	public GameObject Empty;

	public UINetworkTexture LeaderBoardBrd;

	public UIPanel Board;

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

	public UIButton ScrollBtn;

	public GameObject ScrollTopIcon;

	public GameObject ScrollDownIcon;

	public GameObject TopLeft;

	public GameObject TopRight;

	public UIButton CloseBtn;

	public UILabel Title;

	public UIButton TipsBtn;

	public UILabel ShareTitle;

	public UILabel ShareTimeLabel;

	public GameObject TabContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
