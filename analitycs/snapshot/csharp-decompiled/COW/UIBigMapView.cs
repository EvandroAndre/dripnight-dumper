using GCommon;
using UnityEngine;

namespace COW;

public class UIBigMapView : UIBaseView
{
	public GameObject Container;

	public UISprite Bg;

	public UIButton BtnTapClose;

	public UIPanel MapContainer;

	public GameObject DebugCatapultContainer;

	public UILabel CatapultMarkLabel;

	public SetRelativeDepth MapEffectDepth;

	public GameObject eventIcon;

	public GameObject rankingContainer;

	public GameObject RevivePointEndTimeInfo;

	public UILabel ReviveEndTimeLabel;

	public GameObject BtnJump;

	public GameObject ToggleContainer;

	public UIToggle BtnToggleShopIcon;

	public UIToggle BtnToggleRevivePointIcon;

	public GameObject RightReviveWidget;

	public UIButton BtnRevive;

	public UICountDownLabel CountDown;

	public UIButton BtnQuitRevive;

	public GameObject FateRandomSubModeInfo;

	public UISprite FateRandomSubModeIcon;

	public UILabel FateRandomSubModeName;

	public UIEventListener FateRandomSubModeDetailIcon;

	public UILabel FateRandomSubModeDetailTip;

	public GameObject FateRandomBornIconTip;

	public UIEventListener FateRandomSubModeDetailTipMask;

	public UIWidget InputRegion;

	public UIButton ZoomInBtn;

	public UIButton ZoomOutBtn;

	public UISlider SliderNode;

	public UIButton SwitchToggleBtn;

	public UIToggle BtnToggleAirLine;

	public UIButton MarkSelfBtn;

	public UIWidget MarkSelfBtnUIWidget;

	public UIButton DeleteMarkBtn;

	public Transform Right;

	public Animation InAndOutAnim;

	public GameObject GameMissionNode;

	public UITable BtnToggles;

	public UIButton CloseMapBtn;

	public UIWidget CloseMapBtnUIWidget;

	public GameObject SwitchToggleBtnBG;

	public GameObject TeleScopeUseTips;

	public UILabel Label;

	public UIColor RightMask;

	public UIButton BtnReviveRight;

	public UICountDownLabel BtnReviveRightLabel;

	public GameObject ReviveTips;

	public UILabel ReiveTipsLabel;

	public UIButton BtnRadar;

	public UILabel RadarBtnlabel;

	public UIButton BtnRadarRefresh;

	public GameObject RadarCost;

	public UILabel RadarCostCount;

	public GameObject RadarCD;

	public UILabel RadarCDLabel;

	public GameObject RadarTips;

	public GameObject RightSliderArea;

	public GameObject ReviveTipsFateRandom;

	public UILabel ReiveTipsFateRandomLabel;

	public UIButton BtnReviveFateRandom;

	public UICountDownLabel ReviveCountDownFateRandom;

	public UILabel ReviveCoinCountFateRandom;

	public GameObject MetropolisAreaContainer;

	public GameObject DetectorPos;

	public Transform MapBottom;

	public UISprite TeleScopeIcon;

	public UILabel TeleScopeTxt;

	public GameObject gameplayTips;

	public TweenPosition move;

	public UISprite ZoneSetIcon;

	public Transform MarkIconDetailPopNode;

	public Transform MapTop;

	public Transform MapThrowerContainer;

	public Transform MapThrowerTips;

	public GameObject ChooseSafeZoneTips;

	public UILabel ChooseSafeZoneTipsLabel;

	public GameObject MapThrowerBtn;

	public GameObject RoutePlanningModeEntryGroup;

	public UIButton RoutePlanningModeEntryBtn;

	public GameObject RoutePlanningModeExitGroup;

	public UIButton RoutePlanningModeExitBtn;

	public UIButton RoutePlanningRemoveLastBtn;

	public UIButton RoutePlanningRemoveAllBtn;

	public GameObject RoutePlanningModeTips;

	public GameObject SharedEnterInteractionModeUIFX;

	public UISprite RoutePlanningModeEntryBg;

	public UITable BottomIconList;

	public GameObject BomberMakerEnterInteractionModeUIFX;

	public UITable DefaultModeRightBottomTable;

	public UITable RoutePlanningModeRightBottomTable;

	public UIButton MapThrowerRecommendBtn;

	public UIButton MapThrowerConfirmBtn;

	public GameObject HudMapTeamScanUIFX;

	public Transform FloatingLandContainer;

	public Transform CameraArrow;

	public Transform PlayerArrow;

	public UISprite PlayerArrowUI;

	public UISprite GuideToMark;

	public TweenAlpha GuideToMarkTween;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
