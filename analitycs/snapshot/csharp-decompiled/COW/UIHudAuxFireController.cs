using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudAuxFireController : UIHudButtonBaseController, IUIHUDBridgeUGC
{
	private UIHudAuxFireView m_View;

	private const string SPRITE_ICON_AUX_FIRE = "UI_btn_fire";

	private const string ACTION_CANCEL_FIRE = "Action8";

	private const string ACTION_AUX_FIRE = "ACTION_AUX_FIRE";

	private const string SPRITE_ICON_GRENADE = "UI_icon_Grenade";

	private const string SPRITE_ICON_CAMPFIRE = "UI_btn_Bonfire";

	private const string SPRITE_ICON_CAREPACKAGE = "UI_icon_AirdropBar";

	private const string SPRITE_ICON_ICEWALL = "UI_icon_GlooShield";

	private const string SPRITE_ICON_LANDMINE = "UI_icon_Landmine";

	private const string SPRITE_ICON_GRAPPLINGHOOK = "UI_icon_GrapplingHook";

	private const string SPRITE_ICON_MINISENTRY = "UI_icon_MiniSentryGun";

	private const string SPRITE_ICON_FLASH = "UI_icon_EW_Flash";

	private const string SPRITE_ICON_SMOKE = "UI_icon_SmokeBomb";

	private const string SPRITE_ICON_WATERBALL = "UI_icon_waterball";

	private const string SPRITE_ICON_CANCEL_CHARGE = "UI_settle_Close";

	private const string SPRITE_ICON_PAINTSPRAYER = "Icon_paintsprayer_second_year_hud";

	private const string SPRITE_ICON_DUMMY = "UI_icon_DUMMY_2";

	private const string SPRITE_ICON_Fireworks = "UI_Icon_fireworks";

	private const string SPRITE_ICON_DICE = "UI_Icon_dice";

	private const string SPRITE_ICON_MAGNETICFIELD = "UI_icon_MagneticField";

	private const string SPRITE_ICON_FROZENGRENADE = "UI_icon_ice_grenade";

	private const string SPRITE_ICON_SNOWBALL = "Icon_HUD_Snowball";

	private const string SPRITE_ICON_FLAMEFLASK = "FF_ingame_hud_LWSO_Molotov";

	private const string SPRITE_ICON_SMOKEFLASK = "FF_ingame_hud_LWSO_Poison";

	private const string SPRITE_ICON_DREAMLANDBOY_PET_FIRE = "ui_icon_skill_DreamlandBoy";

	private const string SPRITE_ICON_JUMPPAD = "UI_icon_JumpBoard";

	private const string SPRITE_ICON_Catapult = "UI_Icon_PropCatapult";

	private const string SPRITE_ICON_Teleport = "UI_icon_PortalsforPersonal";

	private const string SPRITE_ICON_TeamGather = "UI_icon_TeamAggregator";

	private const string SPRITE_ICON_TELESCOPE = "FF_UI_Pet_Flyingcreature_icon";

	private const string SPRITE_ICON_DEICEWALL = "UI_icon_Grenade_Countericewall";

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

	private ELeftFireSetting m_ShowTiming;

	private bool m_Sighting;

	private string m_strButtonAction;

	private Color m_BtnSpriteInitColor;

	public static Color COLOR_GREY;

	private BitArrayBoolean m_IsVisible;

	public const uint AuxAimingVisible = 1u;

	public const uint VISIBILITY_STATE_IIVFloatingLand = 1073741824u;

	private BitArrayBoolean m_IsDisable;

	public const uint UGCDisable = 1u;

	public const uint InvincibleDisable = 2u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitIsNewUI()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void OnContFireChange(bool b)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnShowNewItemFire(object[] param)
	{
	}

	private void TrySetWeaponSpriteNormalFromConfig(FDAEPHMIEPC weapon)
	{
	}

	private void Update()
	{
	}

	private void UpdateDisableFire()
	{
	}

	private void OnBuildingGunIndexChange(object[] data)
	{
	}

	private void RefreshItemFire()
	{
	}

	private void OnDragUseIceWall(object[] param)
	{
	}

	private void OnChangeVisible(object[] param)
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	private void OnChargeStateChange(bool data)
	{
	}

	protected override string GetMappingName()
	{
		return null;
	}

	private void ShowTutorialFiringWhenGunSightOpening(object[] param)
	{
	}

	protected virtual void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	private void OnPlayerGetOffVehicle(object[] data)
	{
	}

	private void OnHudSettingChange(object[] param)
	{
	}

	private void OnWeaponChange(object[] param)
	{
	}

	private void UpdateShowTiming()
	{
	}

	private void OnAuxAimVisibleChanged(object[] param)
	{
	}

	private void SetVisible(uint flag, bool bVisible)
	{
	}

	private void UpdateChargeShowHide()
	{
	}

	private void UpdateShowHide()
	{
	}

	private bool IsChargeGunNotChargingOnHand()
	{
		return false;
	}

	protected override void OnBtnDown()
	{
	}

	private void OnMiniPhaseChanged(object[] data)
	{
	}

	private void OnLocalPlayerAdd(object[] data)
	{
	}

	public void ProcessUGCAttackStatus(Player.AALGCBFJHJM status)
	{
	}

	private void OnCannonStateChange(object[] data)
	{
	}

	private void OnSpectatorOBChange(object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}
}
