using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCrosshairsView : UIBaseView
{
	public GameObject AimSprite;

	public UISprite NoSightingChargeProgressSprite;

	public TweenAlpha NoSightingChargeProgressTween;

	public GameObject ChargingVfx;

	public GameObject ChargeMaxVfx;

	public GameObject MedicalAimSprite;

	public UISprite AimClosePosSprite;

	public GameObject HitEnhanced;

	public GameObject IngameHudEnhancedHit;

	public Animation IngameHudEnhancedHitAnimation;

	public GameObject IngameHudEnhancedKill;

	public Animation IngameHudEnhancedKillAnimation;

	public GameObject Hit;

	public GameObject SpriteGunSight;

	public UILabel ChargeRateTxt;

	public UISprite ChargeRate1;

	public UISprite ChargeRate2;

	public UISprite ChargeRate3;

	public GameObject ChargeVFX;

	public ParticleSystemRenderer ChargePS;

	public GameObject ChargeBurst;

	public ParticleSystem ChargeFire;

	public UISprite SpriteGunSightCenter;

	public UISprite SightCenterLight;

	public UISprite SpriteHealingGunSightCenter;

	public UISprite HealingGunSightCenterLight;

	public UITexture ThermalView;

	public UITexture PenetrableView;

	public UISprite Sight;

	public GameObject GunShield;

	public UISprite GunShieldLeft;

	public UISprite GunShieldRight;

	public ParticleSystem SightFireEffect01;

	public ParticleSystem SightFireEffect02;

	public TweenAlpha AimBanSprite;

	public GameObject FlashHit;

	public UISprite GrenadeHitProtection;

	public UISprite Rifle;

	public UISprite PrecisionRifle;

	public GameObject Shotgun;

	public UISprite shotgun01;

	public UISprite shotgun02;

	public UISprite shotgun03;

	public UISprite shotgun04;

	public UISprite GrenadeGun;

	public UISprite GrenadeGun01;

	public UISprite GrenadeGun02;

	public GameObject MedicalNormal;

	public GameObject ChangeBullets;

	public UISprite Progressbar;

	public UISprite Hand;

	public GameObject MedicalNormalScale;

	public GameObject MedicalAimingScale;

	public UISprite ShotgunPoint;

	public UISprite PrecisionRiflePoint;

	public UISprite RiflePoint;

	public UISprite AimHookUnable;

	public UISprite ReloadAimIcon;

	public UISprite AimOld;

	public UISprite MedicalAimOld;

	public GameObject MedicalAimTarget;

	public GameObject IngameHudEnhancedKeepingHit;

	public Animation IngameHudEnhancedKeepingHitAnimation;

	public Transform HighShootArrow;

	public UISprite Helmet;

	public UISprite H_Level_01;

	public UISprite H_Level_02;

	public UISprite H_Level_03;

	public UISprite H_Level_04;

	public UISprite Vest;

	public UISprite V_Level_01;

	public UISprite V_Level_02;

	public UISprite V_Level_03;

	public UISprite V_Level_04;

	public UISprite ShieldIcon;

	public Transform WeaponBar;

	public VFXCreateHelper UIFXShieldBreak;

	public VFXCreateHelper UIFXHelmetBreak;

	public VFXCreateHelper UIFXVestBreak;

	public UISprite AirBurstPoint;

	public UILabel ReloadTime;

	public UITexture TechAttachmentView;

	public UISprite TechCrossHair;

	public UITexture TechRoundHotscanView;

	public Transform SkinSightVFX;

	public Transform SkinOpeningSightVFX;

	public TweenAlpha HitmarkerTotal;

	public GameObject Pellet;

	public NewSightHelper NewSightCenterHelper;

	public UISprite NewSightCenter;

	public GameObject Light;

	public GameObject IngameHudEnhancedHeadshot;

	public Animation IngameHudEnhancedHeadshotAnimation;

	public GameObject IngameHudEnhancedKnockDownHeadShot;

	public Animation IngameHudEnhancedKnockDownHeadShotAnimation;

	public GameObject IngameHudEnhancedKnockDown;

	public Animation IngameHudEnhancedKnockDownAnimation;

	public UISprite LockFireProgress;

	public UIWidget LockFire;

	public UISprite LockFireIcon;

	public GameObject IcewallPenetrate;

	public GameObject AimTraceCloseMark;

	public GameObject LaserSight;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
