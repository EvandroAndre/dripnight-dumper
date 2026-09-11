using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudFireController : UIHudButtonBaseController, IUIHUDBridgeUGC
{
	private UIHudFireView m_View;

	private bool m_HasRegistedButton;

	private Vector3 m_DefaultPos;

	private const string SPRITE_ICON_FIRE = "UI_btn_fire";

	private const string SPRITE_ICON_GRENADE = "UI_icon_Grenade";

	private const string SPRITE_ICON_CAMPFIRE = "UI_btn_Bonfire";

	private const string SPRITE_ICON_CAREPACKAGE = "UI_icon_AirdropBar";

	private const string SPRITE_ICON_ICEWALL = "UI_icon_GlooShield";

	private const string SPRITE_ICON_LANDMINE = "UI_icon_Landmine";

	private const string SPRITE_ICON_FIREWORK = "UI_Icon_fireworks";

	private const string SPRITE_ICON_GRAPPLINGHOOK = "UI_icon_GrapplingHook";

	private const string SPRITE_ICON_MINISENTRY = "UI_icon_MiniSentryGun";

	private const string SPRITE_ICON_REDENVELOPE = "UI_icon_Bonus_Tree";

	private const string SPRITE_ICON_FLASH = "UI_icon_EW_Flash";

	private const string SPRITE_ICON_WATERBALL = "UI_icon_waterball";

	private const string SPRITE_ICON_CANCEL_CHARGE = "UI_settle_Close";

	private const string SPRITE_ICON_PAINTSPRAYER = "Icon_paintsprayer_second_year_hud";

	private const string SPRITE_ICON_DUMMY = "UI_icon_DUMMY_2";

	private const string SPRITE_ICON_LIGHTSTICK = "UI_btn_lightstick";

	private const string SPRITE_ICON_SKATEBOARD_JUMP = "UI_icon_hoverboard_jump";

	private const string SPRITE_ICON_SMOKE_GRENADE = "UI_icon_SmokeBomb";

	private const string SPRITE_ICON_BIGTOY_GRENADE = "UI_Icon_dice";

	private const string SPRITE_ICON_REAPER_SICKLE = "UI_CfD_btn_Kill";

	private const string SPRITE_ICON_MAGNETICFIELD = "UI_icon_MagneticField";

	private const string SPRITE_ICON_FROZENGRENADE = "UI_icon_ice_grenade";

	private const string SPRITE_ICON_SNOWBALL = "Icon_HUD_Snowball";

	private const string SPRITE_ICON_FLAMEFLASK = "FF_ingame_hud_LWSO_Molotov";

	private const string SPRITE_ICON_SMOKEFLASK = "FF_ingame_hud_LWSO_Poison";

	private const string SPRITE_ICON_DREAMLANDBOY_PET_FIRE = "ui_icon_skill_DreamlandBoy";

	private const string SPRITE_ICON_BALLOONGENERATE = "UI_btn_GenerateBalloon";

	private const string SPRITE_ICON_DEICEWALL = "UI_icon_Grenade_Countericewall";

	private const string SPRITE_ICON_JUMPPAD = "UI_icon_JumpBoard";

	private const string SPRITE_ICON_Catapult = "UI_Icon_PropCatapult";

	private const string SPRITE_ICON_Teleport = "UI_icon_PortalsforPersonal";

	private const string SPRITE_ICON_TeamGather = "UI_icon_TeamAggregator";

	private const string SPRITE_ICON_TELESCOPE = "FF_UI_Pet_Flyingcreature_icon";

	private const string SPRITE_ICON_PERSONALSHOP = "Ingame_Icon_Loadout3_TacticalStore";

	private const string SPRITE_ICON_MAPTHROWER = "Ingame_Icon_Loadout3_TacticalStore";

	private const string SPRITE_ICON_TEAMBUFFSUPPORTER = "Ingame_Icon_Loadout3_TeamEnhancer";

	private const string SPRITE_ICON_REINFORCEDANVIL = "Ingame_Icon_Loadout3_Reinforced";

	private const string SPRITE_ICON_VEHICLE_DROP = "UI_Icon_item_Vehicledrop";

	private const string SPRITE_ICON_HUD_SUPPLYBOX = "Icon_HUD_SupplyBox";

	private const string SPRITE_ICON_HUD_GAMEMISSION = "Icon_HUD_BountyDevice";

	private const string SPRITE_ICON_MULTIEXPLOSIVE = "UI_icon_Electric_grenade";

	private const string SPRITE_ICON_EMP = "UI_icon_Flash_EMP";

	private const string SPRITE_ICON_DART = "FF_ingame_hud_WL25_GP_Dart";

	private const string SPRITE_ICON_FORCEFIELD_GRENADE = "UI_btn_CoinGrenade";

	private const string CARRY_BATTLE_ATTACK_BTN_EFFECT = "UIFX_NINTH_SOCIALLOBBY_UIHUDFIRE_ATTACKBTN_LOOP";

	private const string CARRY_BATTLE_ATTACK_BTN_EFFECT_FIRST = "UIFX_NINTH_SOCIALLOBBY_UIHUDFIRE_ATTACKBTN_FRISTLOOP";

	private const string ACTION_CANCEL_FIRE = "Action8";

	private const string ACTION_FIRE = "Action1";

	private const string ACTION_SKATEBOARD_JUMP = "Action5";

	private string m_strButtonAction;

	private Vector3 m_StartPos;

	private float iconScale;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 1073741824u;

	public const uint VISIBILITY_STATE_DANCEPOOL = 536870912u;

	public const uint VISIBILITY_STATE_CARRY = 268435456u;

	private BitArrayBoolean m_IsVisible;

	public const uint ParachutingVehicleVisible = 1u;

	public const uint AuxAimingVisible = 2u;

	public const uint VehicleCanFire = 4u;

	public const uint StealthCanFire = 8u;

	private float m_BGRangeRadius;

	private float multiscale;

	private uint m_DamageBuffFlag;

	private float m_CdTime;

	private float m_LeftTime;

	private Color m_SpriteNormalInitColor;

	public static Color COLOR_GREY;

	private float m_nextBalloonCoolDownTime;

	private BitArrayBoolean m_IsDisable;

	public const uint UGCDisable = 1u;

	public const uint InvincibleDisable = 2u;

	public const uint VehicleFireDisable = 4u;

	private VisualInstanceHolder m_KisameEnableUI;

	private VisualInstanceHolder m_FireBonusUIFXHolder;

	private string m_FireIconBackSprite;

	private UIAtlas m_FireIconBackAtlas;

	private uint m_CustomItemUIEffectTicket;

	private uint m_CarryBattleAttackBtnEffectTicket;

	private bool m_CarryBattleAttackBtnShowingFirst;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	private void OnContFireChange(bool b)
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnWeaponReloadEnd(object[] data)
	{
	}

	private void OnReloadSpeedChangeAvailable(object[] data)
	{
	}

	private void OnWeaponReloadSpeedChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void UpdateAxisTouchingThroughArea()
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	private void UpdateKisameShark()
	{
	}

	private void UpdateFireBonus()
	{
	}

	private void UpdateDisableFire()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void Update()
	{
	}

	private bool ShowDamageBuffGO()
	{
		return false;
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void ActiveFirePosition(bool v)
	{
	}

	private void OnGetOnOffSkateboard(object[] data)
	{
	}

	private void OnLocalPlayerSkateboardJumpCd(object[] param)
	{
	}

	private void OnLobbySocialSetFireHud(object[] data)
	{
	}

	public void RefreshLobbySocialAreaFireHud()
	{
	}

	private void OnChargeStateChange(bool data)
	{
	}

	private void OnShowNewItemFire(object[] param)
	{
	}

	private void TrySetWeaponSpriteNormalFromConfig(FDAEPHMIEPC weapon)
	{
	}

	private void TryShowItemCustomUIEffect(NAELPAAELNO itemOnHand)
	{
	}

	private void TryShowOrHideItemCustomUIEffect(bool isShow)
	{
	}

	private void RecyleItemCustomUIEffect()
	{
	}

	private uint SpawnEffectByVisualEffectManager(ResourceID resID)
	{
		return 0u;
	}

	private void RefreshCarryBattleAttackBtnEffect()
	{
	}

	private void TryShowCarryBattleAttackBtnEffect(bool showFirst)
	{
	}

	private void RecycleCarryBattleAttackBtnEffect()
	{
	}

	private bool HasCarryBattleFireBtnBeenUsed(Player lp)
	{
		return false;
	}

	private void TryRecordCarryBattleFireBtnAndSwitchEffect()
	{
	}

	private void TryShowWeaponCustomUIEffect(FDAEPHMIEPC weapon)
	{
	}

	private void OnCannonStateChange(object[] data)
	{
	}

	private void ChangeAtlas(NAELPAAELNO itemOnHand)
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void OnShowSelf(object[] param)
	{
	}

	private void OnAuxAimVisibleChanged(object[] param)
	{
	}

	private void OnVehicleCanFireStateChanged(bool canFire)
	{
	}

	private void OnSpectatorOBChange(object[] param)
	{
	}

	private void SetVisible(uint flag, bool bVisible)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void OnAimingEnemy(object[] data)
	{
	}

	private void OnAimingEnemyInForceTutorial(object[] data)
	{
	}

	public void OnReaperTransform(bool toReaper)
	{
	}

	public void FireIconChangeWithoutItem(ResourceID spriteRes)
	{
	}

	private void OnMiniPhaseChanged(object[] data)
	{
	}

	private void HideCdBar()
	{
	}

	private void ShowCdBar(float cd, float remain)
	{
	}

	private void OnBuildingGunIndexChange(object[] data)
	{
	}

	private void RefreshItemFire()
	{
	}

	private void UpdateDamageBuff(object[] data)
	{
	}

	private void OnInfectionShowTutorial(object[] data)
	{
	}

	private void OnShootGuideTutorial(object[] data)
	{
	}

	protected override void OnBtnClick()
	{
	}

	private bool IsBalloonGeneratorOnHand(NAELPAAELNO itemOnHand = null)
	{
		return false;
	}

	private void CheckBalloonGenCDOnWeaponChange(NAELPAAELNO itemOnHand)
	{
	}

	private bool IsChargeGunNotChargingOnHand()
	{
		return false;
	}

	protected override void OnBtnDown()
	{
	}

	protected override void OnBtnUp()
	{
	}

	private void TryStopPlayerSkillMysterymanOnBtnDown()
	{
	}

	public void ProcessUGCAttackStatus(Player.AALGCBFJHJM status)
	{
	}

	private void OnVerticalCameraModeChanged(bool isVertical)
	{
	}

	private void OnPersonalShopUpgradeBuffChange()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
