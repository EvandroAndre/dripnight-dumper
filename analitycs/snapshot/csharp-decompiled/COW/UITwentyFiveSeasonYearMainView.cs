using GCommon;
using UnityEngine;

namespace COW;

public class UITwentyFiveSeasonYearMainView : UIBaseView
{
	public UILabel HeroicCntLabel;

	public UILabel SeasonYearDataDescLabel;

	public GameObject BRPoints;

	public GameObject CSPoints;

	public UILabel BRLabel;

	public UILabel CSLabel;

	public UISeasonYearRankPointsView HeroicPointsContainer;

	public UIGrid RewardGrid;

	public GameObject RewardContainer;

	public VFXCreateHelper UIFXBGAnim;

	public UIProgressBar HeroicProgreessBar;

	public GameObject SeasonYearHeroicContainer;

	public UIButton HeroicCntBtn;

	public UISprite guideWidget;

	public GameObject FirstSelectDot;

	public GameObject SecondSelectDot;

	public GameObject ThirdSelectDot;

	public GameObject FourthSelectDot;

	public UINetworkTexture HawkCdn;

	public UINetworkTexture RightCircleCdn;

	public UINetworkTexture LeftCircleCdn;

	public GameObject BeginSelectDot;

	public Animation MainPageAnim;

	public GameObject MainContainer;

	public Animation HawkAnim;

	public GameObject HawkContainer;

	public VFXCreateHelper UIFXBGNormal;

	public VFXCreateHelper HeroicCntUIFXOnce;

	public VFXCreateHelper HeroicCntUIFXLoop;

	public UINetworkTexture MainBGCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
