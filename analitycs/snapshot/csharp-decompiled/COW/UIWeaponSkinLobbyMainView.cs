using GCommon;
using UnityEngine;

namespace COW;

public class UIWeaponSkinLobbyMainView : UIBaseView
{
	public GameObject ThirdPanelAnchor;

	public UIScrollView ThirdScrollView;

	public UIEasyList ThirdGrid;

	public GameObject ShareUI;

	public UIWidget LeftUI;

	public UIEasyList FirstGrid;

	public UIScrollView SecondScrollView;

	public UIEasyList SecondGrid;

	public GameObject ItemDesc;

	public GameObject DescLevelObj;

	public UIWidget WidgetDescLevelObj;

	public UISprite DescLevelIcon;

	public GameObject ItemName;

	public UILabel itemNameLabel;

	public UITable IconTable;

	public UIWidget WidgetIconTable;

	public UIButton weaponskillbtn;

	public UIButton IpTagBtn;

	public UIButton ShareBtn;

	public GameObject propertyContainer;

	public GameObject pvpPropertyContainer;

	public GameObject pvePropertyContainer;

	public UIWidget RightUI;

	public UIButton switchbtn;

	public GameObject SwitchToGunSpr;

	public GameObject SwitchToPersonSpr;

	public UIButton zoomBtn;

	public UIButton ShowBtn;

	public UIButton LevelUpBtn;

	public GameObject LevelUpVfx;

	public UIWidget PreviewUI;

	public Transform notificationContainer;

	public GameObject EventTrigger;

	public Transform HotFixDownloadPos;

	public UILabel NotReadyLabel;

	public GameObject MultiSelectNode;

	public UICheckboxButton MultiCheckButton;

	public UIButton TipsBtn;

	public UIWidget MultiSelectGuideNode;

	public UIButton PokedexBtn;

	public Transform WeaponProgressBarPos;

	public GameObject LateSpr1;

	public GameObject LateSpr2;

	public UISprite TipsBtnUISprite;

	public UISprite QualityLine;

	public UIColor QualitySpot;

	public UIButton BtnJmpToProficiency;

	public UISprite SpriteProficiency;

	public UIButton BtnJmpToLadderLeaderboard;

	public Transform EvoGunKillCount;

	public UICheckboxButton SwitchSoundBtn;

	public UILabel SwitchSoundBtnLabel;

	public UILabel ShowBtnCheckLabel;

	public GameObject CheckIcon;

	public GameObject UnCheckIcon;

	public GameObject Show;

	public UIHorizontalBox ChooseBtnGroup;

	public GameObject CommonZoomSprite;

	public GameObject PrivilegeZoomSprite;

	public UITable DescTable;

	public Transform ChangeWeaponStatTrans;

	public UIButton ChangeWeaponStatIconBtn;

	public UISprite ChangeWeaponStatIconSprite;

	public UITable PrivilegeIconTable;

	public GameObject PrivilegeIconTemp;

	public UIButton PveSkinIconBtn;

	public UIButton EquipAsPveSkinBtn;

	public UILabel PveSkinBtnCheckLabel;

	public GameObject EquipAsPveSkinBtnSelect;

	public GameObject EquipAsPveSkinBtnUnSelect;

	public UILabel DescLevelLabel;

	public UITable TableTag;

	public GameObject PropertyChange;

	public UIButton ButtonPropertyChange;

	public UIToggleButton FinalShotBtn;

	public UIToggleButton WeaponSkinBtn;

	public UIButton WeaponDetailBtn;

	public UIButton MultiEquipBtn;

	public UIButton MultiUnequipBtn;

	public GameObject MultiEquipedBtn;

	public GameObject Equip;

	public UILabel btnName;

	public UIButton equipBtn;

	public GameObject CustomBtn;

	public UIButton customBtn;

	public UISprite customWidget;

	public UIGrid btnGroupGrid;

	public UIEasyList FinalShotEasyList;

	public GameObject FinalShotEquipGo;

	public UIButton FinalShotEquipBtn;

	public GameObject FinalShotUnEquip;

	public GameObject FinalShotEquip;

	public UIScrollView FinalShotScrollView;

	public UIButton TimeLimitTipBtn;

	public UILabel DetailDescription;

	public UIToggleButtonGroup ToggleButtonGroup;

	public GameObject FinalShotGoto;

	public UIButton FinalShotGotoBtn;

	public TweenPosition ThirdGridTweenAnim;

	public UILabel CustomWeaponName;

	public GameObject CustomWeapon;

	public Transform HintGuidePos;

	public UITable LevelTable;

	public GameObject LevelUpContainer;

	public GameObject SingleWeaponSkinBtn;

	public Transform WishListBtnPos;

	public GameObject BeforeGuideMask;

	public UISprite IPTag;

	public Transform killNotifyContainer;

	public UISprite LinePlus;

	public GameObject KillNotifybg;

	public UIWidget EquipGuideWidget;

	public UIWidget WeaponDetaiGuideWidget;

	public GameObject WeaponDetaiGuideGameObject;

	public UILabel MultiSelectLabel;

	public GameObject FinalshotRedTips;

	public GameObject FinalShotState;

	public UISprite FinalshotStateIcon;

	public UIButton FinalshotStateBtn;

	public VFXCreateHelper FinalshotHasButUnEquipVFX;

	public VFXCreateHelper FinalshotEquipVFX;

	public VFXCreateHelper FinalshotChangeTabVFX;

	public GameObject FinalShotBtnEnable;

	public GameObject FinalShotBtnEnableDisable;

	public GameObject FinalShotUnEquipState;

	public UILabel FinalShotBtnName;

	public UIButton ReplayBtn;

	public UIButton SkipAnimMaskBtn;

	public UICheckboxButton SickleZoomBtn;

	public UILabel SickleZoomLabel;

	public UIGrid btnGroup;

	public UICheckboxButton SwitchSightBtn;

	public UILabel SwitchSightBtnLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
