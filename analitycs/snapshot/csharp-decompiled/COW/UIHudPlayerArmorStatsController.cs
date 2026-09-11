using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudPlayerArmorStatsController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__87_0;

		internal void _003CDelayShowGuide_003Eb__87_0()
		{
		}
	}

	private sealed class _003CCreateClickMask_003Ed__114 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudPlayerArmorStatsController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCreateClickMask_003Ed__114(int _003C_003E1__state)
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

	private UIHudPlayerArmorStatsView m_View;

	private Player m_Player;

	private Player.IJJFLMLECCJ m_FoldingWingStatus;

	private bool m_IsSkateboarding;

	private int curHelmetLevel;

	private int curArmorLevel;

	private string FilledArmorIcon;

	private string FilledArmorIconBG;

	private string FilledArmorIconExplode;

	private string FilledArmorIconExplodeBG;

	private string FilledHeadIcon;

	private string FilledHeadIconBG;

	private string FilledHeadIconProtect;

	private string FilledHeadIconProtectBG;

	private Color NormalColor;

	private Color InRecoverColor;

	private Color LockColor;

	private uint m_HelmetVFXDelayCall;

	private uint m_VestVFXDelayCall;

	private uint m_IceWallVFXDelayCall;

	private uint m_VestUpgradeVFXDelayCall;

	private uint m_HelmetUpgradeVFXDelayCall;

	private UIHUDIceWallModuleTipPopOverController m_DetailTipPopoverCtrl;

	private GameObject m_curIceWallVFX;

	private bool m_PlayerStatsCanShow;

	private bool m_UIGroupStatsCanShow;

	private BitArrayBoolean m_IceWallModuleVisibility;

	private const uint ABANDONLIFE_VISIBILITY_MODULE_OPEN = 1u;

	private const uint ABANDONLIFE_VISIBILITY_UPGRADE_NOT_OPEN = 2u;

	private Dictionary<int, VisualInstanceHolder> m_SpriteArmorVfxHolderDic;

	private Dictionary<int, VisualInstanceHolder> m_SpriteArmorFullVfxHolderDic;

	private UIHudCSAbilityPointPopPanelController m_CSAbilityPointPopPanel;

	private const string DEFAULT_CS_ABILITY_POINT_ICON_NAME = "UI_CS_Grow_Icon_Crystal_01";

	private uint m_VestDistributeUIFXDelayCall;

	private uint m_HelmetDistrubuteUIFXDelayCall;

	private uint m_VFXVestDamagedDelayCall;

	private uint m_VFXHelmetDamagedDelayCall;

	private const float VFX_BREAK_BY_EXTRA_DAMAGE_DURATION = 3f;

	private uint m_IcewallAudioDelayCall;

	private uint m_IceWallModuleDelayCall;

	private float m_icewallModuleCD;

	private float m_StartTime;

	private OB46IceWallModule m_Config;

	private bool m_NeedShowGuide;

	private List<UIHUDIceWallModuleRewardItem> m_RewardItems;

	private Coroutine m_CreateClickMaskCoroutine;

	private UIClickMask m_PopupClickMask;

	private UIHudUpgradeLinePopOverController m_UpgradePopoverCtrl;

	private UIHudUpgradeGemGetController m_UpgradeGemGetCtrl;

	private bool CanDriverUse => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnQuickUse()
	{
	}

	private void OnClickCSAbilityPointBtn()
	{
	}

	private void RefreshCSAbilityPointUI()
	{
	}

	private string GetCSAbilityPointIconName()
	{
		return null;
	}

	private void OnIceWallMakerActivate(object[] data)
	{
	}

	private void OnSPChanged(GEvent data)
	{
	}

	private void OnInventoryRepairArmorChanged(object[] param)
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void UpdatetVisibility()
	{
	}

	private void OnReadyToGlide(int data)
	{
	}

	private void OnGetOnOffSkateboard(object[] data)
	{
	}

	private void UpdateUseBtnStatust(GEvent InParams)
	{
	}

	private void OnAttachmentChanged(object[] data)
	{
	}

	private void OnShowHudOnceEffect(object[] data)
	{
	}

	private void OnMaxDurabilityChanged(uint playerID)
	{
	}

	private void OnUseArmorTool()
	{
	}

	private void HideVestUpgradeVFX()
	{
	}

	private void HideHelmetUpgradeVFX()
	{
	}

	private void BindPlayer(Player p)
	{
	}

	private void OnAddPlayer(object[] data)
	{
	}

	private void OnObservePlayer(object[] data)
	{
	}

	private void OnPlayerPostInit(object[] data)
	{
	}

	private void RefreshEquipmentStats(HDAEFOANBGJ InSlot = HDAEFOANBGJ.Unknown)
	{
	}

	private void OnInventoryEquipmentMinDurabilityLockChanged()
	{
	}

	private void RefreshDurabilityLockEffect()
	{
	}

	private void OnEnquipmentEquipStateChanged(GEvent InParams)
	{
	}

	public void RefreshStrengthenArmorUI()
	{
	}

	private void OnIceWallMakerLevelChange(object[] data)
	{
	}

	private void RefreshIceWallIcon()
	{
	}

	private void SetIceWallIcon(int level)
	{
	}

	private void OnPersonaHit(GEvent evt)
	{
	}

	private void OnPersonaBreak(GEvent evt)
	{
	}

	private void OnGotGlooAirdropAward(uint num)
	{
	}

	private void ShowIceWallModule(bool hasIceWallMaker)
	{
	}

	private void TryShowGuide()
	{
	}

	private void OnOpeningEnd(object[] param)
	{
	}

	private void ShowIceWallModuleGuide()
	{
	}

	private void DelayShowGuide()
	{
	}

	private void ShowIceWallModuelStep()
	{
	}

	private void OnRefreshByData(ulong newValue)
	{
	}

	private void OnRefreshCD(uint startTime, uint cd)
	{
	}

	private void Update()
	{
	}

	private void UpdateCd()
	{
	}

	private void ShowIceWallGifts(object[] data)
	{
	}

	private ResourceID GetRewardEffectID(int level)
	{
		return default(ResourceID);
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void OnPlayerStatsVisibilityChanged(bool isVisible)
	{
	}

	private void RefreshVisibility()
	{
	}

	private void OnShowPlayerArmorStatsVFX(GEvent gEvent)
	{
	}

	private void SetActiveArmorStatsCustomVFX(HDAEFOANBGJ eSlot, bool isShow)
	{
	}

	private void LoadArmorStatsCustomVFX(ResourceID resID, HDAEFOANBGJ eSlot)
	{
	}

	private void LoadArmorStatsCustomFullVFX(ResourceID resID, HDAEFOANBGJ eSlot)
	{
	}

	private void ReleaseArmorStatsCustomVFX(HDAEFOANBGJ eSlot)
	{
	}

	private void ReleaseArmorStatsCustomFullVFX(HDAEFOANBGJ eSlot)
	{
	}

	private void ReleaseAllArmorStatsCustomVFX()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void TryCloseDetailTipPopover()
	{
	}

	private void StartCreateClickMaskCoroutine()
	{
	}

	private void TryStopCreateClickMaskCoroutine()
	{
	}

	private IEnumerator CreateClickMask()
	{
		return null;
	}

	private void OnClickIceWallModuleBtn()
	{
	}

	private void ShowDetailTipPopoverWithClickMask()
	{
	}

	private void OnClickMaskTriggered()
	{
	}

	private void OnClickUpgradeTipsBtn()
	{
	}

	private void OnUpgradeLevelChanged(int level)
	{
	}

	private void HideUpgradePopover()
	{
	}

	private void InitUpgradeGemGetCtrl()
	{
	}

	private void _003COnAttachmentChanged_003Eb__53_0()
	{
	}

	private void _003COnAttachmentChanged_003Eb__53_1()
	{
	}

	private void _003COnShowHudOnceEffect_003Eb__54_0()
	{
	}

	private void _003COnShowHudOnceEffect_003Eb__54_1()
	{
	}

	private void _003COnIceWallMakerLevelChange_003Eb__68_0()
	{
	}

	private void _003COnPersonaHit_003Eb__74_0()
	{
	}

	private void _003COnPersonaHit_003Eb__74_1()
	{
	}

	private void _003COnPersonaBreak_003Eb__75_0()
	{
	}

	private void _003COnPersonaBreak_003Eb__75_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
