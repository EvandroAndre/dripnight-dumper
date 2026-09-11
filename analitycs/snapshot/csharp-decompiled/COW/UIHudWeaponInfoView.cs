using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWeaponInfoView : UIBaseView
{
	public UIButton HeavyWidget;

	public UILabel HeavyAmmoCount;

	public UISprite HeavyWeaponIcon;

	public UIButton GrenadeWidget;

	public GameObject GrenadeLabel;

	public UIWidget NormalWidget;

	public Transform EffectRoot;

	public UILabel WeaponName;

	public GameObject GoldEffect;

	public UISprite SpriteLevelEffect;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public UISprite WeaponIcon;

	public UISprite HeatWeaponIcon;

	public GameObject AmmoInfoGO;

	public UILabel CurrentAmmoCount;

	public TweenScale TweenAmmo;

	public UILabel MaxAmmoCount;

	public UIProgressBar AmmoStatusBar;

	public Transform Reload;

	public UIGrid SwitchWeaponGrid;

	public UISprite InfiniteSprite;

	public UISprite BuffIcon;

	public UIHudWeaponShield Shield;

	public VFXCreateHelper CombineVFXCreateHelper;

	public UISprite CombineSprite;

	public GameObject CombineSpriteDissolve;

	public VFXCreateHelper VFX_CombineSprite;

	public GameObject BuildingWidget;

	public UIButton BuildingBtn;

	public GameObject BuildingLabel;

	public GameObject VehicleWidget;

	public UIGrid VehicleGrid;

	public GameObject HeatWeaponWidget;

	public UILabel HeatWeaponEnergy;

	public UIWidget TutorialWidget;

	public GameObject SpriteGoldPlus;

	public GameObject SpriteRedPlus;

	public GameObject QualityMark1;

	public GameObject QualityMark2;

	public GameObject QualityMark3;

	public VFXCreateHelper BuffEffect;

	public GameObject GoGradeLv0;

	public Transform EvoGunKillCount;

	public VFXCreateHelper LevelUp;

	public VFXCreateHelper LevelDown;

	public VFXCreateHelper Effect_Kord;

	public VFXCreateHelper AnimationReplacerVFX;

	public UISprite weaponBg;

	public UIPanel HudPanel;

	public GameObject ClickMask;

	public VFXCreateHelper VFX_SwatGuy;

	public UISprite GradeProgress;

	public GameObject GradeLv1;

	public GameObject GradeLv2;

	public GameObject GradeLv3;

	public GameObject GradeMaxBg;

	public GameObject GradeContainer;

	public GameObject GradeVFX;

	public GameObject GradeIcon;

	public GameObject HarmIcon;

	public UIPosCurve HeatGunSuperHeatPoint;

	public GameObject GradeProgressMaxLoop;

	public GameObject NormalBg;

	public UISprite ActivityBg;

	public UISprite ActivityIcon;

	public GameObject Grade;

	public GameObject InfiniteAmmo;

	public GameObject BgContainer;

	public GameObject EighthInfiniteBgContainer;

	public GameObject HCGradeLv1;

	public GameObject HCGradeLv2;

	public GameObject HCGradeLv3;

	public GameObject HCGradeLv4;

	public GameObject HCGradeLv5;

	public GameObject HCGradeLv6;

	public UISprite SpriteSkill;

	public GameObject ReinforcedBg;

	public VFXCreateHelper ReinforcedVFX;

	public GameObject WeaponMountgrenade;

	public GameObject HeavyWeaponContainer;

	public UIButton HeavyWidgetFour;

	public GameObject CustomGradeRoot;

	public UIGrid CustomGradeGride;

	public UISprite CustomGradeOneSprite;

	public UISprite AwakenIcon;

	public UIButton BotAgentHighLightNode;

	public VFXCreateHelper AwakenVFX;

	public GameObject IcewallPenetrate;

	public GameObject CanAwakenIcon;

	public VFXCreateHelper QTEFX;

	public GameObject Term;

	public UISprite TermIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
