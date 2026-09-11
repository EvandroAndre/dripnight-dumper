using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudWeaponInfoController : UIBaseController
{
	private struct AwakeWeaponIconMaterialState(UISprite sprite)
	{
		private readonly UIAtlas m_Atlas = null;

		private readonly string m_SpriteName = null;

		public bool IsSameSprite(UISprite sprite)
		{
			return false;
		}
	}

	private sealed class _003CSetKillCountView_003Ed__144 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudWeaponInfoController _003C_003E4__this;

		public uint weaponSkinID;

		public uint killCount;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CSetKillCountView_003Ed__144(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	protected UIHudWeaponInfoView m_View;

	private FDAEPHMIEPC m_LastWeaponInHand;

	private HDAEFOANBGJ m_EquipSlot;

	private HDAEFOANBGJ m_LastEquipSlot;

	private int m_LastAmmoLeft;

	private int m_LastAmmoCapacity;

	private int m_LastAmmoLeftInBag;

	private float m_UpgradeProgress;

	private bool m_lastCanUpgrade;

	private bool m_LastCombined;

	private bool m_LastSecondWeaponDataEffective;

	private bool m_LastHasGoldAttachment;

	private bool m_weaponChanged;

	private bool m_UpdateingVehicleWeapon;

	private bool m_ModeDriverCanFire;

	private int m_LastShieldHP;

	private ResourceID m_SkinChangeEffectID;

	private GameObject m_SkinChangeEffectObj;

	private const string m_CombineIcon = "UI_Icon_Double_Weapon_Dissolve_mini";

	private const string m_CombineIconHighLight = "UI_Icon_Double_Weapon_mini";

	private bool m_IsHudFourSelection;

	private Color m_WeaponIconInitColor;

	private static Material m_AwakeWeaponIconMaterial;

	private static uint m_AwakeWeaponIconMaterialLoadTicket;

	private static readonly Dictionary<int, UISprite> m_AwakeWeaponIconMaterialPendingSprites;

	private static readonly Dictionary<int, Material> m_AwakeWeaponIconMaterialInstances;

	private static readonly Dictionary<int, AwakeWeaponIconMaterialState> m_AwakeWeaponIconMaterialAppliedStates;

	public static Color COLOR_GREY;

	private UIHudWeaponEighthInfiniteVFXController m_EighthInfiniteVFXController;

	public static Color AmmoColorHigh;

	public static Color AmmoColorMid;

	public static Color AmmoColorLow;

	public static Color HeatGunNormal;

	public static Color HeatGunCooling;

	public static Color BRShopTokenHeatGunFull;

	public static Color BRShopTokenHeatGunFill;

	private GameObject m_FXLevelUpGold;

	private UIHudEvoGunKillCountController m_EvoGunKillCntCtrl;

	private uint m_DelayCallHideEvoGunKillCountID;

	private float m_DelayCallTime;

	private bool m_ObserverInfoListVisible;

	private bool m_ObserverOnVehicle;

	private bool m_ObserverInSky;

	public bool ShowEighthInfiniteEffect;

	private bool m_ShowAwakeIcon;

	private bool m_ShowTermIcon;

	private bool m_ShowSpecialWeponIcon;

	private int orignalDepth;

	private MutableString m_maxWeaponString;

	private uint m_uDelayHideKey;

	private uint m_DelayCallEffectChangeWeaponSkin;

	private bool m_PlaySwitchEffect;

	private uint m_CloseCombineSpriteDelayCall;

	private bool m_CombineMachineEffectiveTrigger;

	private bool m_IsPlayerEffectForSwithWeaponMode;

	private uint m_DelayCallEffectKord;

	private Player m_currentPlayer;

	private List<FDAEPHMIEPC> m_templist;

	private bool m_IsVehicleWeapon;

	private uint m_ReinforceAnimEffectHideDelayID;

	private Coroutine m_KillCountCoroutine;

	private int m_LastShowLevel;

	private ResourceID m_LastShowLevelResID;

	private List<UISprite> m_CustomLevelList;

	private bool HideWeaponCtrl => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
	}

	public static bool DontDestroy()
	{
		return false;
	}

	public static void SetAwakeWeaponIconMaterial(UISprite sprite, bool isAwake)
	{
	}

	private static void ApplyAwakeWeaponIconMaterial(UISprite sprite, int spriteID)
	{
	}

	private static void ClearAwakeWeaponIconMaterial(UISprite sprite, bool releaseInstance)
	{
	}

	private static void ReleaseAwakeWeaponIconMaterialInstance(int spriteID)
	{
	}

	private static Material GetOrCreateAwakeWeaponIconMaterialInstance(int spriteID)
	{
		return null;
	}

	private static void LoadAwakeWeaponIconMaterialAsync()
	{
	}

	private static void TryCancelAwakeWeaponIconMaterialLoad()
	{
	}

	private static void OnAwakeWeaponIconMaterialLoaded(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private string OnBotAgentGetRunTimeData()
	{
		return null;
	}

	private void OnShowSkillSwatGuyVfx()
	{
	}

	private void OnWeaponProgressUpdate()
	{
	}

	private void OnForceTutorialSwitchToWeapon(uint phaseID)
	{
	}

	private void HideSkillSwatGuyVfx()
	{
	}

	private void OnAddObserver(uint data)
	{
	}

	private void OnChangeDepth(uint data)
	{
	}

	private void EnableClickMask(bool enable)
	{
	}

	private void ShowLevelUpGoldFX(bool show)
	{
	}

	private void OnEquipAttachment(object[] data)
	{
	}

	protected void OnWeaponSkinChanged(object[] data)
	{
	}

	protected void OnWeaponSkinSwitched(object[] data)
	{
	}

	private void OnReloadSpeedChangeAvailable(object[] data)
	{
	}

	private void OnWeaponReloadSpeedChanged(object[] data)
	{
	}

	private void OnWeaponReloadEnd(object[] data)
	{
	}

	protected void OnWeaponBuffActive(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnObserverInfoListVisibleChanged(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnGrenadeSwitchClick()
	{
	}

	private void OnChange2LastEquipWeapon(object[] param)
	{
	}

	private void OnCombineMachineChange(bool param)
	{
	}

	private void CloseCombineSpriteEffect()
	{
	}

	private void OnCombineMachineEffective(object[] param)
	{
	}

	private void OnCanCombineChanged(object[] param)
	{
	}

	private void OnMsgReplacerRes(object[] param)
	{
	}

	private void OnWeaponModeSwitched(object[] param)
	{
	}

	private void OnSecondWeaponDataEffectiveChanged(object[] param)
	{
	}

	private void OnHeavyWeaponDrop()
	{
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	private void RefreshHeavyWeapon(bool show)
	{
	}

	private void SetLevelEffect()
	{
	}

	private void SetGameObjectActive(VFXCreateHelper go, bool flag)
	{
	}

	private void Update()
	{
	}

	private void SetTermIcon(FDAEPHMIEPC curWeapon)
	{
	}

	private void UpdateRifleGirlIcon(Player player, FDAEPHMIEPC curWeapon)
	{
	}

	private void OnCurPlayerSkillChanged(object[] data)
	{
	}

	private void UpdateRifleGirlIconByLocalPlayer()
	{
	}

	private bool CheckWeaponUpgradeInfoEqual(FDAEPHMIEPC curWeapon)
	{
		return false;
	}

	private void UpdateWeaponShowTxt(int currentweapon, int maxweapon)
	{
	}

	private bool IsHeavyWeapon(NAELPAAELNO item)
	{
		return false;
	}

	private bool ShouldUpdateVehicleWeapon(out bool vehicleWeaponStateChanged)
	{
		vehicleWeaponStateChanged = default(bool);
		return false;
	}

	private void UpdateVehicleWeapon(bool wasUpdating)
	{
	}

	private void OnLastWeaponInit(object[] data)
	{
	}

	private void OnInventoryItemChanged(object[] param)
	{
	}

	private void RefreshUIByWeaponOnHand(HDAEFOANBGJ WeaponEquipSlot)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	protected virtual bool IsOnlyShowOneWeapon()
	{
		return false;
	}

	protected virtual bool CheckSilderWeapon(NAELPAAELNO item)
	{
		return false;
	}

	private bool CheckHeaveyWeapon(NAELPAAELNO item)
	{
		return false;
	}

	protected virtual bool IsCheckSilderWeapon()
	{
		return false;
	}

	private void OnClickedGoldWeaponUpgrade()
	{
	}

	private void OnEnterFloatingLand(object[] param)
	{
	}

	private void OnLeaveFloatingLand(object[] param)
	{
	}

	private void OnWeaponReinforced(uint uniqueID)
	{
	}

	private void OnWeaponReinforcedEffect(uint uniqueID)
	{
	}

	private void TryStopAndHideReinforceAnimEffect()
	{
	}

	private void RefreshWeaponUpgradeBtnShow()
	{
	}

	private void ChangeReloadVisible(bool value)
	{
	}

	private void OnPinMark()
	{
	}

	private void OnWeaponPinMark(HDAEFOANBGJ equipSlot)
	{
	}

	private bool IsEvoGunKillCountUpdateNeeded(BHGGAEEHJCO ownerPlayerID, uint weaponSkinID, int weaponID, uint updatedKillCount)
	{
		return false;
	}

	private void OnEvoGunKillCountUpdate(GEvent data)
	{
	}

	private void DelayCallHideEvoGunKillCountView()
	{
	}

	private void HideEvoGunKillCountView()
	{
	}

	private void OnSomeoneWeaponChange(uint data)
	{
	}

	private IEnumerator SetKillCountView(uint weaponSkinID, uint killCount)
	{
		return null;
	}

	private void RefreshCtrlVisibility()
	{
	}

	private void OnObserverStatusChangeCallback(GEvent data)
	{
	}

	private bool ObserverIsInSky()
	{
		return false;
	}

	private void OnObserverGetOnVehicle(object[] data)
	{
	}

	private void OnObserverGetOffVehicle(object[] data)
	{
	}

	private void OnObserverSwitch(object[] data)
	{
	}

	private void OnLocalPlayerRevive(object[] data)
	{
	}

	private void OnPlayerInVehicleStateChanged(GEvent evt)
	{
	}

	private void TrySetExtraShowFlag()
	{
	}

	private void RefreshWeaponCustomLevel(int showLevel, ResourceID showResID)
	{
	}

	private void ClearCustomLevel()
	{
	}

	private void OnEighthShowInfiniteItemRewardFlyEnd(object[] param)
	{
	}

	private void RefreshEighthBg()
	{
	}

	public void InitEighthBg(bool clearFlag = true)
	{
	}

	private void RefreshShowEighthInfiniteEffect()
	{
	}

	private void OnShowWeaponAffixTip(object[] param)
	{
	}

	private void OnArmsRaceLevelUpdate(object[] param)
	{
	}

	private void _003COnWeaponSkinChanged_003Eb__78_0()
	{
	}

	private void _003COnSecondWeaponDataEffectiveChanged_003Eb__100_0()
	{
	}

	private void _003COnWeaponReinforcedEffect_003Eb__132_0()
	{
	}

	private void _003CDelayCallHideEvoGunKillCountView_003Eb__140_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
