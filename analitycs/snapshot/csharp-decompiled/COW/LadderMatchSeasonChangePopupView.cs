using GCommon;
using UnityEngine;

namespace COW;

public class LadderMatchSeasonChangePopupView : UIBaseView
{
	public Animator ViewAnimator;

	public GameObject SeasonRankContainer;

	public GameObject RankIconAnim;

	public UILadderMatchHeroicLevelView HeroicLevelView;

	public GameObject RankIconRoot;

	public UILabel RankLabel;

	public UILabel RankSeasonLabel;

	public GameObject SeverRankRoot;

	public UILabel PeakRankPosition;

	public UILabel NickName;

	public UINetworkTexture SelfIcon;

	public UIEffectSprite HeadSprite;

	public GameObject NewSeasonInfoContainer;

	public GameObject NewSeasonInfo;

	public UILabel Txt_NewSeasonTime;

	public UILabel SeasonIconLabel;

	public GameObject ContinueBtnAnim;

	public UILabel BtnLabel;

	public UIButton ContinueBtn;

	public UINetworkTexture SeasonRewardBGCDN;

	public UIScrollView SeasonExchangeRewardScrollView;

	public UIScrollView SeasonAwardScrollView;

	public UIEasyList SeasonAwardEasyList;

	public UIEasyList SeasonExchangeRewardEasyList;

	public GameObject SeasonExchangeRewardContainer;

	public GameObject SeasonAwardContainer;

	public UILabel SeasonNameLabel;

	public UILabel SeasonPeriodLabel;

	public GameObject NewSeasonRewardContainer;

	public Transform RewardPreviewDescNode;

	public UILabel Txt_RankSeasonTime;

	public UILabel RankTypeLabel;

	public UILabel GameModeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
