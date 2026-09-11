using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMinimapView : UIBaseView
{
	public TweenPosition TweenPosition;

	public Transform RootContainer;

	public GameObject MapQuad;

	public GameObject ForecastEffect;

	public UISprite FactionIcon;

	public GameObject NoSignal;

	public GameObject NoSignalGo;

	public GameObject MapContent;

	public UIPanel SafeZonePanel;

	public UISprite MapFrame;

	public Transform MapRot;

	public Transform MapContainer;

	public GameObject Enemy;

	public GameObject PlayerArrow;

	public TweenAlpha UavPlayerArrow;

	public GameObject Arrow;

	public GameObject SoundTips;

	public Transform SoundTipsContainer;

	public GameObject SpectatorCamera;

	public GameObject csEnemyBornPos;

	public UIButton BtnZoom;

	public GameObject Effect_Arrow;

	public GameObject BottomGo;

	public GameObject PartyGame;

	public UISprite PartyGameIcon;

	public UISprite PlayerArrowShadow;

	public GameObject BigMapCloseTips;

	public GameObject EnemyTriggerGrenade;

	public GameObject ScanLine;

	public UILabel BigMapCloseTipsLabel;

	public GameObject MetropolisContainer;

	public GameObject BeMarkedEffect;

	public UIButton RegionRankListBtn;

	public GameObject NewInformationEffect;

	public GameObject ReviveMissionVfxRoot;

	public GameObject GameplayModifierCarouselRoot;

	public UIFixTimeCarousel GameplayModifierCarousel;

	public UISprite TelescopeIcon;

	public Transform TopExUIRoot;

	public Transform BottomExUIRoot;

	public GameObject EnemyHelicoper;

	public Transform HippoCrisisCountDownContainer;

	public GameObject FakeMiniMapRoot;

	public UITexture FakeTexture;

	public GameObject PainUniversalPullScanEffect;

	public GameObject MapRightBottom;

	public UIScrollView TopRightIcons;

	public UIWrapContent TopRightIconsWrapContents;

	public UICenterOnChild TopRightIconsCenterOnChild;

	public UISprite BomberMakerIcon;

	public Transform FullEdgeUIFX;

	public UISprite TeamScanIcon;

	public GameObject TeamScanLine;

	public UISprite TeamScanCDmask;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
