using GCommon;
using UnityEngine;

namespace COW;

public class UITwentyFourSeasonYearMainView : UIBaseView
{
	public UINetworkTextureExt SeasonYearNameCDN;

	public UILabel HeroicCntLabel;

	public UILabel SeasonYearDataDescLabel;

	public UIGrid BRPointsGrid;

	public UIGrid CSPointsGrid;

	public UILabel BRLabel;

	public UILabel CSLabel;

	public Transform HeroicPointsShareTrans;

	public GameObject TopLeft;

	public GameObject Right;

	public Transform HeroicPointsTrans;

	public GameObject HeroicPointsContainer;

	public UIGrid RewardGrid;

	public GameObject RewardContainer;

	public Transform TitleShareTrans;

	public Transform TitleNormalTrans;

	public Animation MainAnim;

	public GameObject ProgreessBarContainer;

	public GameObject Thumb;

	public UISprite FrontProgressBg;

	public GameObject FirstCircleFull;

	public GameObject SecondCircleFull;

	public GameObject ThirdCircleFull;

	public GameObject FourthCircleFull;

	public GameObject ProgressFullBgTop;

	public GameObject ProgressBgBottom;

	public VFXCreateHelper UIFXThumb;

	public Transform SeasonDataTrans;

	public GameObject SeasonYearDataContainer;

	public Transform SeasonYearDataShareTrans;

	public VFXCreateHelper UIFXTitle;

	public VFXCreateHelper UIFXCircleClaimHelp;

	public Transform UIFXCircleClaim;

	public TweenPosition ThumbTween;

	public UISprite guideWidget;

	public UINetworkTexture MainBGCDN;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
