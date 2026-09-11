using GCommon;
using UnityEngine;

namespace COW;

public class UITwentySixSeasonYearMainView : UIBaseView
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

	public GameObject BeginSelectDot;

	public Animation MainPageAnim;

	public GameObject MainContainer;

	public VFXCreateHelper UIFXBGNormal;

	public VFXCreateHelper HeroicCntUIFXOnce;

	public VFXCreateHelper HeroicCntUIFXLoop;

	public UINetworkTexture MainBGCDN;

	public UINetworkTexture SeasonYearEagle04;

	public UINetworkTexture SeasonYearEagle;

	public UINetworkTexture Seasonyear26circleRight;

	public UINetworkTexture Seasonyear26circleLeft;

	public UINetworkTexture SeasonYearEagle02;

	public UINetworkTexture SeasonYearEagle03Left;

	public UINetworkTexture SeasonYearEagle05Left;

	public UINetworkTexture SeasonYearEagle03Right;

	public UINetworkTexture SeasonYearEagle05Right;

	public Transform HeroicCntTipTrans;

	public Transform AvatarAndChairTrans;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
