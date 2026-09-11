using GCommon;
using UnityEngine;

namespace COW;

public class UIGraphicSettingView : UIBaseView
{
	public UIScrollView SettingScrollView;

	public UITable Table;

	public UIWidget QUALITY;

	public UITable QualityTable;

	public GameObject QualityToggleGroup;

	public UIToggleButton UltraPlusQualityToggle;

	public UIToggleButton HighQualityToggle;

	public GameObject UltraToggleArrow;

	public UIToggleButton LowQualityToggle;

	public UIToggleButton LowestQualityToggle;

	public GameObject ExtraQualitySetting;

	public UITable ExtraQualitySettingTable;

	public GameObject resolutionObj;

	public GameObject ShadowGO;

	public UISettingToggleGroup ShadowOpToggleGroup;

	public GameObject InGameFilter;

	public UIToggleButton Filter2Btn;

	public UIToggleButton Filter3Btn;

	public UIToggleButton Filter4Btn;

	public UIToggleButton Filter1Btn;

	public GameObject HightFPSGO;

	public UISettingToggleGroup HighFPSToggleGroup;

	public UIToggle LowFPSToggle;

	public GameObject MiniMap;

	public UIToggleButtonGroup MiniMapScaleAssist;

	public UIToggleButton MiniMapScaleOff;

	public UIToggleButton MiniMapScaleOn;

	public UIToggle NorthUpBtn;

	public UIToggle ViewUpBtn;

	public GameObject NotchScreen;

	public GameObject TipsNotchScreen;

	public UILabel TipNewModeLabel;

	public GameObject EnemyFootStepHint;

	public UISettingToggleGroup EnemyFootStepToggle;

	public GameObject HighSelectUpArrow;

	public GameObject UltraSelectUpArrow;

	public GameObject LowQualityTips;

	public UIToggle HighFPSToggle;

	public UIToggle MeduimFPSToggle;

	public UISprite FPSBtnBG;

	public UIButton QualityTipBtn;

	public GameObject UltraPlusRecommendIcon;

	public GameObject HighRecommendIcon;

	public GameObject LowRecommendIcon;

	public GameObject LowestRecommendIcon;

	public GameObject CollectionEffect;

	public UISettingToggleGroup CollectionEffectToggleGroup;

	public TweenPosition CollectionEffectOnPosition;

	public TweenPosition CollectionEffectOffPosition;

	public TweenPosition CollectionEffectLabelPosition;

	public TweenPosition ResolutionPosition;

	public UISettingToggleGroup ResolutionToggleGroup;

	public TweenPosition ResolutionLabelPosition;

	public TweenPosition ShadowOnPostion;

	public TweenPosition ShadowOffPostion;

	public TweenPosition InGameFilterLabelPosition;

	public TweenPosition InGameFilterContainerPosition;

	public TweenPosition ShadowLabelPosition;

	public GameObject LobbyCamGyro;

	public UISettingToggleGroup LobbyCamGyroToggle;

	public GameObject EnergySaving;

	public UISettingToggleGroup EnergySavingToggleGroup;

	public TweenPosition EnergySavingLabelPostion;

	public UIButton EnergySavingTipBtn;

	public TweenPosition EnergySavingOnPostion;

	public TweenPosition EnergySavingOffPostion;

	public GameObject SpecialGraphicTitle;

	public UISprite GraphicBGMax;

	public UISprite GraphicBG;

	public UIToggle FPS120;

	public UISprite FPSGroupBG;

	public UIButton FPS120TipBtn;

	public GameObject SmoothHighFrameTitle;

	public UIButton SmoothHighFrameTipBtn;

	public UISettingToggleGroup SmoothHighFrameOp;

	public Transform HDLobbySetting;

	public Transform HDAnimationSetting;

	public GameObject HDInGame;

	public Transform HDEffectSetting;

	public Transform HDLobbySelfDisplaySetting;

	public Transform HDLobbyLeaderDisplaySetting;

	public GameObject HDLobbySettingContainer;

	public GameObject HDLobbySelfDisplaySettingContainer;

	public GameObject HDLobbyLeaderDisplaySettingContainer;

	public Transform HDTextureSetting;

	public UIToggle FPS144;

	public UIButton FPS144TipBtn;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
