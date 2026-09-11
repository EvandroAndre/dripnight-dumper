using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCustomView : UIBaseView
{
	public GameObject Top;

	public Transform RulerMark;

	public Transform SaveZoneMark;

	public UISprite SinglePlayerMark;

	public UISprite TeamMark_1;

	public UISprite TeamMark_2;

	public UISprite TeamMark_3;

	public UISprite TeamMark_4;

	public UISprite TreasureMark;

	public Transform Ruler;

	public UILabel ScaleValue_1;

	public UILabel ScaleValue_2;

	public UILabel ScaleValue_3;

	public UILabel ScaleValue_4;

	public UILabel ScaleValue_5;

	public UILabel ScaleValue_6;

	public UILabel ScaleValue_7;

	public UILabel ScaleValue_8;

	public UILabel ScaleValue_9;

	public UILabel ScaleValue_10;

	public UILabel ScaleValue_11;

	public UILabel ScaleValue_12;

	public Transform Ruler2;

	public UILabel ScaleValue_24;

	public UILabel ScaleValue_13;

	public UILabel ScaleValue_14;

	public UILabel ScaleValue_15;

	public UILabel ScaleValue_16;

	public UILabel ScaleValue_17;

	public UILabel ScaleValue_18;

	public UILabel ScaleValue_19;

	public UILabel ScaleValue_20;

	public UILabel ScaleValue_21;

	public UILabel ScaleValue_22;

	public UILabel ScaleValue_23;

	public GameObject TopLeft;

	public CustomHudItem UIHudItemMarkBtn;

	public CustomHudItem HudMiniMap;

	public CustomHudItem HudTeammatesInfo;

	public CustomHudItem HudChatBtn;

	public CustomHudItem HudQuickChatContainer;

	public GameObject Left;

	public CustomHudItem HudQuickUseMedkit;

	public CustomHudItem HudInventoryEntry;

	public CustomHudItem HudSpeedupArea;

	public CustomHudItem UIHudAuxFire;

	public EdgeDetectHudItem UIHudGrenadeBtn;

	public GameObject GrenadeRight;

	public CustomHudExpandDirection GrenadeDirectionRight;

	public GameObject GrenadeLeft;

	public CustomHudExpandDirection GrenadeDirectionLeft;

	public GameObject GrenadeTop;

	public CustomHudExpandDirection GrenadeDirectionTop;

	public GameObject GrenadeBottom;

	public CustomHudExpandDirection GrenadeDirectionBottom;

	public GrenadeDefenceHudItem UIHudGrenadeBtn2;

	public CustomHudItem UIHudEmotionEntry;

	public CustomHudItem UIHudPetAnim;

	public UISprite normal;

	public GameObject AdjustContainer;

	public UISlider AlphaSliderBar;

	public UILabel AlphaSliderValue;

	public UISlider SizeSliderBar;

	public UILabel SizeSliderValue;

	public UIToggle HideToggle;

	public UIToggleButtonGroup GrenadeDirectionBtnRoot;

	public UIToggleButton GrenadeRightBtn;

	public UIToggleButton GrenadeLeftBtn;

	public UIToggleButton GrenadeTopBtn;

	public UIToggleButton GrenadeBottomBtn;

	public UIButton CancelBtn;

	public UIButton ResetBtn;

	public UIButton ConfirmBtn;

	public GameObject ConfirmEnable;

	public GameObject ConfirmDisable;

	public TweenHeight BGTween;

	public UIButton BtnArrow;

	public GameObject TopRight;

	public CustomHudItem HudWeaponInfo;

	public BoxCollider HudWeaponInfoCollider;

	public UIWidget HudWeaponInfoWidget;

	public UIGrid HudWeaponListGrid;

	public GameObject Remaining;

	public UILabel RemainingCountText;

	public GameObject Kill;

	public UILabel KillCountText;

	public GameObject Enemy;

	public UILabel RemainingEnemyCountText;

	public GameObject KDA;

	public UILabel KdaCountText;

	public CustomHudItem HudPickupList;

	public CustomHudItem UIHudAutoFire;

	public CustomHudItem UIHudCombineWeapon;

	public GameObject BottomLeft;

	public CustomHudItem HudMovingJoystick;

	public UILabel SignalLabel;

	public UISprite SignalIcon;

	public GameObject BottomRight;

	public CustomHudItem HudFire;

	public CustomHudItem HudCreep;

	public CustomHudItem HudCrouch;

	public CustomHudItem HudJump;

	public CustomHudItem HudSight;

	public CustomHudItem HudActiveSkill;

	public UISprite BtnSprite;

	public CustomHudItem HudAuxAim;

	public GameObject Bottom;

	public UISprite HighLightCircle;

	public TweenScale TweenCircle;

	public UISprite HighLightSquare;

	public TweenScale TweenSquare;

	public CustomHudItem UIHudSwitchWeapon;

	public CustomHudItem HudSetting;

	public CustomHudItem HudVehicleHorn;

	public Transform SettingInfo1;

	public Transform SettingInfo2;

	public Transform SettingInfo3;

	public Transform SettingInfo4;

	public GameObject IcongBg;

	public Transform RemainInfo1;

	public Transform RemainInfo2;

	public Transform RemainInfo3;

	public Transform RemainInfo4;

	public UIButton SizeUpButton;

	public UIButton SizeRightButton;

	public UIButton SizeDownButton;

	public UIButton SizeLeftButton;

	public Transform TransCaseContainer;

	public Transform TransButtonGrid;

	public Transform ButtonGridTrans;

	public UIGrid ButtonGrid;

	public UIWidget WidgetBGCollider;

	public UIGroupWaitingDropItem DropBGCollider;

	public BoxCollider BGCollider;

	public Transform TransTopPanel;

	public Transform TransMoveableLogo;

	public TweenPosition TweenMoveableLogo;

	public TeamParachuteActionItem HudTeamParachuteAction;

	public BoxCollider HudTeamParachuteActionColliderCollider;

	public CustomHudItem HudExchangeItemPanel;

	public UIButton CancelBtn2;

	public UIButton PrevPreset;

	public UIButton GenShareCodeBtn;

	public UIButton UseShareCode;

	public UIButton NextPreset;

	public UILabel PresetName;

	public CustomHudItem UIHudBotAgentMarkBtn;

	public CustomHudItem UIHudHoldGrenade;

	public BoxCollider HudHoldGrenadeCollider;

	public GameObject HoldGrenadeBtnCancel;

	public GameObject InteractBtnGetOn;

	public UILabel DescLabel;

	public GameObject BottomView;

	public UIToggle WeaponSeparatedToggle;

	public BoxCollider HudWeaponSwichCollider;

	public CustomHudItem HudWeaponSwich;

	public UIWidget HudWeaponSwichWidget;

	public GameObject HudWeaponSwichUnited;

	public UIWidget HudWeaponInfoHighLightBig;

	public UIWidget HudWeaponInfoHighLightSmall;

	public UIToggle LeftAlignedToggle;

	public GameObject LeftAligned;

	public GameObject CenterAligned;

	public GameObject TraditionLayout;

	public GameObject CompactLayout;

	public BoxCollider HudPlayerSkillBuffCollider;

	public CustomHudItem HudPlayerSkillBuffItem;

	public UIWidget CompactHighLightBG;

	public UIWidget TraditionHighLightBG;

	public BoxCollider HudInteractColider;

	public CustomHudItem UIHudInteract;

	public Transform HudModeCommonEntrance;

	public GameObject GreyMaskBG;

	public GameObject PanelPreview;

	public UIButton BackButton;

	public GameObject GreyMaskColider;

	public CustomHudItem HudPresetPickEntrance;

	public CustomHudItem HudQuickChatV2Combo;

	public UIToggle SmartHudAdjustToggle;

	public UITable BottomViewTable;

	public UIButton SmartHudAdjustHelpBtn;

	public UISprite KillIcon;

	public EdgeDetectHudItem HudLoginAge18;

	public UINetworkTexture Age18Logo;

	public CustomHudItem HudPlayerFollowEmote;

	public GameObject SizeLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
