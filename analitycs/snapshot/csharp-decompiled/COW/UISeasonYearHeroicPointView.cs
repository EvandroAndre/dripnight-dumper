using GCommon;
using UnityEngine;

namespace COW;

public class UISeasonYearHeroicPointView : UIBaseView
{
	public GameObject LightUpContainer;

	public VFXCreateHelper UIFXLightUp;

	public GameObject UnLightUpContainer;

	public GameObject InProgressContainer;

	public UILabel SeasonLabel;

	public VFXCreateHelper UIFXInProgress;

	public GameObject UnOpenContainer;

	public UISprite LightUpIcon;

	public UISprite UnLightUpIcon;

	public UISprite LightUpBeforeIcon;

	public UIButton ShowMoreBtn;

	public Transform TipsTrans;

	public GameObject PointSortName;

	public UISprite UnOpenIcon;

	public UISprite UnLightUpRankIcon;

	public Animation LightUpIcon_Ani;

	public Transform CSPeakRankContainer;

	public UILabel LightUpSeasonLabel;

	public UILabel UnLightUpSeasonLabel;

	public UISprite InProgressIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
