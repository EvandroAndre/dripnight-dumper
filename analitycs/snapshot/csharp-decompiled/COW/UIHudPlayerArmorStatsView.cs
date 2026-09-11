using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerArmorStatsView : UIBaseView
{
	public GameObject HelmetBG;

	public UISprite FilledHelmet;

	public UISprite FilledHelmetEnhanced;

	public UISprite HelmetLevel;

	public TweenAlpha HelmetDurabilityRecoverEffect;

	public UILabel HelmetBuffCountLabel;

	public Animation HelmetVFX;

	public GameObject ArmorBG;

	public UISprite FilledArmor;

	public UISprite FilledArmorEnhanced;

	public UISprite ArmorLevel;

	public TweenAlpha ArmorDurabilityRecoverEffect;

	public UILabel VestBuffCountLabel;

	public Animation VestVFX;

	public UIWidget UseWidget;

	public UIButton BtnQuickUse;

	public ParticleSystem FlashEffect;

	public GameObject SpriteIceWall;

	public UISprite IceWallFilled;

	public UISprite SpriteIceWallLevel;

	public GameObject SpriteIceWallLevel_5;

	public UILabel IceWallBuffCountLabel;

	public GameObject IceWallVFX;

	public GameObject SpriteShieldArmor;

	public UISprite ShieldArmorFilled;

	public UISprite ShieldArmorLevel;

	public GameObject HelmetUpgradeVFX;

	public GameObject VestUpgradeVFX;

	public VFXCreateHelper VFXHelmetDamaged;

	public VFXCreateHelper VFXVestDamaged;

	public GameObject IceWallModule;

	public Animation WallAnimation;

	public GameObject vfx;

	public UISprite IceWallSprite;

	public UISprite cdSprite;

	public UIButton icewallBtn;

	public GameObject Rewards;

	public GameObject IceWallGuide;

	public VFXCreateHelper readyVfx;

	public UIHUDIceWallModuleRewardItem rewardItem;

	public GameObject levelupVfx;

	public GameObject GotGlooAirdropAwardVFX;

	public GameObject bg;

	public GameObject loadguideVfx;

	public GameObject SpriteUpgradeLine;

	public UISprite SpriteUpgradelLineLevel;

	public UISprite SpriteCSAbilityPointLevel;

	public GameObject CSAbilityPointPopPoint;

	public UIButton UpgradeTipsBtn;

	public Transform UpgradeTipsTrans;

	public GameObject HelmetDurabilityLockEffect;

	public GameObject ArmorDurabilityLockEffect;

	public UIButton BtnCSAbilityPoint;

	public UISprite SpriteCSAbilityPoint;

	public VFXCreateHelper HelmetDistrubuteUIFX;

	public VFXCreateHelper VestDistrubuteUIFX;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
