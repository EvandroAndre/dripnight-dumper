using GCommon;
using UnityEngine;

namespace COW;

public class UIHudWeaponSwitchInfoView : UIBaseView
{
	public UIButton WeaponSwitchButton;

	public UIWidget WeaponSwitchWidget;

	public Transform EffectRoot;

	public UISprite PrimaryIcon;

	public UISprite SecondaryIcon;

	public UISprite NoWeapon01;

	public UISprite NoWeapon02;

	public UISprite MeleeIcon;

	public GameObject PVEAmmoInfo;

	public UILabel PVECurAmmo;

	public UISprite PVEInfiniteSprite;

	public UILabel PVEMaxAmmo;

	public GameObject PVESep;

	public UIProgressBar PVEAmmoStatusBar;

	public GameObject AmmoInfoGO;

	public UILabel MaxAmmoCount;

	public UISprite InfiniteSprite;

	public UIProgressBar AmmoStatusBar;

	public UISprite SpriteBg;

	public UISprite GoldenBg;

	public GameObject GoGradeLv1;

	public GameObject GoGradeLv2;

	public GameObject GoGradeLv3;

	public UIHudWeaponShield Shield;

	public UISprite CombineSprite;

	public VFXCreateHelper CombineSpriteVFX;

	public GameObject CombineSpriteDissolve;

	public VFXCreateHelper VFX_CombineSprite;

	public GameObject SpriteGoldPlus;

	public GameObject SpriteRedPlus;

	public GameObject QualityMark1;

	public GameObject QualityMark2;

	public GameObject QualityMark3;

	public GameObject GoGradeLv0;

	public UISprite SpriteProgMask;

	public GameObject GradeContainer;

	public UISprite GradeProgress;

	public GameObject HarmIcon;

	public GameObject GradeIcon;

	public GameObject GradeMaxBg;

	public GameObject GradeLv1;

	public GameObject GradeLv2;

	public GameObject GradeLv3;

	public UISprite SpriteSkill;

	public GameObject AllGrade;

	public GameObject ActivityInfo;

	public UISprite ActivityIcon;

	public UISprite AcitivityBg;

	public GameObject EighthInfiniteBg;

	public GameObject BgContainer;

	public GameObject EighthInfiniteBgContainer;

	public GameObject HCGradeLv1;

	public GameObject HCGradeLv2;

	public GameObject HCGradeLv3;

	public GameObject HCGradeLv4;

	public GameObject HCGradeLv5;

	public GameObject HCGradeLv6;

	public GameObject ReinforcedBg;

	public VFXCreateHelper ReinforcedVFX;

	public GameObject WeaponMountgrenade;

	public GameObject CustomGradeRoot;

	public UIGrid CustomGradeGrid;

	public UISprite CustomGradeOneSprite;

	public UISprite AwakenIcon;

	public GameObject IcewallPenetrate;

	public GameObject QTEReady;

	public GameObject CanAwakenIcon;

	public GameObject Term;

	public UISprite TermIcon;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
