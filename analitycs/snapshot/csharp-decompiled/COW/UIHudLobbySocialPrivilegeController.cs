using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudLobbySocialPrivilegeController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass101_0
	{
		public UIHudLobbySocialPrivilegeController _003C_003E4__this;

		public uint dataId;

		public ulong endUnix;

		internal void _003CApplyMainEntryRemainTimeCountdown_003Eb__0()
		{
		}

		internal void _003CApplyMainEntryRemainTimeCountdown_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass112_0
	{
		public bool waitForTargetEquip;

		public NAELPAAELNO slotItem;

		public Func<bool> canSwapToHand;

		public Player localPlayer;

		public HDAEFOANBGJ targetSlot;

		public UIHudLobbySocialPrivilegeController _003C_003E4__this;

		public OMELKCOGCBK inventoryManager;

		public Action<bool> onEquipFinished;

		internal bool _003CTryEquipSlotItemToHand_003Eb__0(NAELPAAELNO equipedItem)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass119_0
	{
		public UIHudLobbySocialPrivilegeController _003C_003E4__this;

		public LobbySocialPropType propType;

		internal bool _003CTryEnterPrivilegeReleaseState_003Eb__0()
		{
			return false;
		}

		internal void _003CTryEnterPrivilegeReleaseState_003Eb__1(bool equipSuccess)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass79_0
	{
		public UIHudLobbySocialPrivilegeController _003C_003E4__this;

		public GameObject vfx;

		public Action onAction;

		internal void _003CPlayFirstPrivilegeVfx_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass80_0
	{
		public UIHudLobbySocialPrivilegeController _003C_003E4__this;

		public GameObject vfx;

		internal void _003CPlaySwitchPrivilegeVfx_003Eb__0()
		{
		}
	}

	public const int SubSlotCount = 15;

	public const int SocialLobbyExpireProgressThresholdSec = 120;

	public const int SocialLobbyExpireCountdownThresholdSec = 10;

	public const uint VISIBILITY_STATE_CARRY = 134217728u;

	private const int OpenBgHeightExtraPadding = 20;

	private const float PrivilegeVfxShowDuration = 3f;

	private const float PrivilegeAcquireVfxCooldown = 1f;

	private const string PrivilegeViewInAnimName = "UIFX_Ninth_SYS_UIHudLobbySocialPrivilege_In";

	private const string PrivilegeViewOutAnimName = "UIFX_Ninth_SYS_UIHudLobbySocialPrivilege_Out";

	private const string SelectedTypePrefsKeySegment = "SocialLobbyPrivilegeSelectedType";

	private static readonly Color MainEntryUsageIconColor;

	protected UIHudLobbySocialPrivilegeView m_View;

	private List<UIHudLobbySocialPrivilegeSubBtnController> m_SubBtns;

	private bool m_SubListOpen;

	private LobbySocialPropType m_SelectedType;

	private bool m_InMainUsageState;

	private Color m_MainEntryNormalIconColor;

	private UIHudLobbySocialPrivilegeManager m_PrivilegePropMgr;

	private bool m_MainEntryRemainTimeHeartbeatActive;

	private ulong m_MainEntryRemainTimeHeartbeatEndUnix;

	private uint m_MainEntryRemainTimeHeartbeatDelayCallId;

	private uint m_SendExpiredPrivilegeItemsDelayCallId;

	private List<uint> m_PendingExpiredPrivilegeItemIds;

	private uint m_FirstPrivilegeVfxDelayCallId;

	private uint m_SwitchPrivilegeVfxDelayCallId;

	private uint m_SubListCloseDelayCallId;

	private uint m_DelayedPrivilegeSwitchDelayCallId;

	private LobbySocialPropType m_DelayedPrivilegeSwitchType;

	private Dictionary<uint, int> m_LastAvailablePrivilegeItemCounts;

	private bool m_hasSyncPrivilegeItemTable;

	private float m_LastPrivilegeAcquireVfxTime;

	public const uint VISIBILITY_STATE_DANCEPOOL = 1073741824u;

	public const uint VISIBILITY_STATE_CHANGE = 536870912u;

	private UIClickMask m_ClickMask;

	private bool m_isWaitingVisible;

	private readonly string GuideKey;

	private readonly float GuideDuration;

	private uint m_GuideDelayCallKey;

	private string m_GuideKey;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	private void TryAddClickMask()
	{
	}

	private void TryCloseClickMask()
	{
	}

	private void ResetClickMask()
	{
	}

	private void OnCloseSubListPanel()
	{
	}

	private void OnNinthMainUIIn()
	{
	}

	private void ResetStatueAnimation()
	{
	}

	private void OnLobbySocialHudStateChanged(bool visible)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnCarryStateChanged()
	{
	}

	private void RefreshCarryStateVisibility()
	{
	}

	private bool IsPrivilegeUsageBlockedByCarry()
	{
		return false;
	}

	public override void Hide()
	{
	}

	private void CreateSubGridView()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnAddLocalPlayer(object[] data)
	{
	}

	private void OnPlayerAliveStateChanged(uint playerID)
	{
	}

	private void OnInventoryOrPlayerChanged(object[] data)
	{
	}

	private void OnInventoryItemCountChangedByDataId(uint dataId)
	{
	}

	private void OnPrivilegeItemExchange(object[] data)
	{
	}

	private void OnNewItemOnHandExitPrivilege(object[] data)
	{
	}

	public bool SlotSupportsResetBtnUI(LobbySocialPropType slot)
	{
		return false;
	}

	public bool ShouldEquipToHandWhenMainEntryUse(LobbySocialPropType slot)
	{
		return false;
	}

	private void OnExitSelectionRequested(object[] data)
	{
	}

	private void OnDeformResetEvent(object[] data)
	{
	}

	private void OnDeformAppliedEvent(object[] data)
	{
	}

	private void OnSlotClickEvent(object[] data)
	{
	}

	private void OnArrowClick()
	{
	}

	private void OpenSubListPanel()
	{
	}

	private void CloseSubListPanel(bool playAnimation = true)
	{
	}

	private void HideSubListPanelNodes()
	{
	}

	private void CancelSubListCloseDelayCall()
	{
	}

	private void PlayPrivilegeViewAnimation(string animName)
	{
	}

	private float GetPrivilegeViewAnimationLength(string animName)
	{
		return 0f;
	}

	public void RefreshAllSlots()
	{
	}

	private void ForceRefreshSubListLayout()
	{
	}

	private void StopSubListSpringPositions(UIGrid grid)
	{
	}

	private void ApplySocialLobbyEntranceAndArrowVisibility(int visibleCount)
	{
	}

	private void GetAvailablePrivilegeItemCounts(Dictionary<uint, int> itemCounts)
	{
	}

	private void RefreshAvailablePrivilegeItemCountCache()
	{
	}

	private void CheckAndPlayPrivilegeAcquireVfx()
	{
	}

	private void CheckFirstPrivilegeVfx(Action onAction)
	{
	}

	private void PlayFirstPrivilegeVfx(Action onAction)
	{
	}

	private void PlaySwitchPrivilegeVfx()
	{
	}

	private void HidePrivilegeVfx(bool cancelDelayCall)
	{
	}

	private void HidePrivilegeVfx(GameObject vfx, ref uint delayCallId, bool cancelDelayCall)
	{
	}

	private bool RefreshSubSlotAtIndex(LobbySocialPropType slotIndex)
	{
		return false;
	}

	private void RefreshOpenBgHeightByVisibleCount(int visibleCount)
	{
	}

	private LobbySocialPropType ResolveSavedSlotTypeItemInBag(LobbySocialPropType saved)
	{
		return LobbySocialPropType.None;
	}

	private void CheckAndSendExpiredPrivilegeItems()
	{
	}

	private void AddExpiredPrivilegeItem(uint dataId, List<uint> expiredItemIds)
	{
	}

	private void OnPrivilegeItemCountdownFinished()
	{
	}

	private void DelaySendPrivilegeItemExpired(List<uint> expiredItemIds)
	{
	}

	private void ScheduleSendPendingExpiredPrivilegeItems()
	{
	}

	private void SendPendingExpiredPrivilegeItems()
	{
	}

	private void ClearExpiredPrivilegeItemCallbacks(List<uint> expiredItemIds)
	{
	}

	private void ClearDelayedExpiredPrivilegeItems()
	{
	}

	private void ClearMainEntryRemainTimeCountdown()
	{
	}

	private void SetMainEntryProgressActive(bool active)
	{
	}

	private void StartMainEntryRemainTimeHeartbeat(ulong endUnix)
	{
	}

	private void StopMainEntryRemainTimeHeartbeat()
	{
	}

	private void ScheduleMainEntryRemainTimeHeartbeat()
	{
	}

	private void OnMainEntryRemainTimeHeartbeatTick()
	{
	}

	private void UpdateMainEntryRemainTimeProgressFill()
	{
	}

	private void ApplyMainEntryRemainTimeCountdown(uint dataId)
	{
	}

	private void NotifyRemainTimeView(bool visible, ulong endUnix, uint dataId)
	{
	}

	private bool SelectAvailablePrivilegeToMainEntryView()
	{
		return false;
	}

	private void RefreshMainEntryView()
	{
	}

	private void OnSlotSelected(LobbySocialPropType slot)
	{
	}

	private string GetSelectedTypePrefsKey()
	{
		return null;
	}

	private void LoadSavedSelectedType()
	{
	}

	private static bool IsValidSavedPropType(int propType)
	{
		return false;
	}

	private void SaveSelectedType(LobbySocialPropType propType)
	{
	}

	private void ApplyMainButtonIcon(LobbySocialPropType propType)
	{
	}

	private void ApplyMainButtonIconColor()
	{
	}

	private bool TryEquipSlotItemToHand(LobbySocialPropType propType, Func<bool> canSwapToHand = null, Action<bool> onEquipFinished = null, bool unequipCurrentPrivilegeBeforeSwitch = true)
	{
		return false;
	}

	private HDAEFOANBGJ ResolveEquipSlotForPrivilegeItem(OMELKCOGCBK inventoryManager, NAELPAAELNO slotItem)
	{
		return HDAEFOANBGJ.PrimaryWeapon1;
	}

	private bool TryUnequipCurrentPrivilegeItemBeforeSwitch(OMELKCOGCBK inv, NAELPAAELNO targetPrivilegeItem)
	{
		return false;
	}

	private bool TryScheduleDelayedPrivilegeSwitchAfterUnequip(LobbySocialPropType targetType)
	{
		return false;
	}

	private void OnDelayedPrivilegeSwitchTick()
	{
	}

	private void CancelDelayedPrivilegeSwitch()
	{
	}

	private void TryEnterCurrentPrivilegeReleaseState()
	{
	}

	private void TryEnterPrivilegeReleaseState(LobbySocialPropType propType, bool unequipCurrentPrivilegeBeforeSwitch = true)
	{
	}

	private void OnPrivilegeEquipFinishedForReleaseState(LobbySocialPropType propType, bool equipSuccess)
	{
	}

	private void ShowPrivilegeEquipTips(LobbySocialPropType propType)
	{
	}

	private bool CanEnterPrivilegeReleaseState(LobbySocialPropType propType)
	{
		return false;
	}

	private void EnterCurrentPrivilegeReleaseState()
	{
	}

	private void ExitMainEntryUsageState(bool clearLocalPlayerState = false, bool unequipPrivilegeItem = true, bool restoreFireHud = true)
	{
	}

	private void SetMainEntryUsageState(bool inUsageState)
	{
	}

	private void TryUnequipCurrentPrivilegeItem()
	{
	}

	private bool TryGetCurrentEquippedPrivilegeItem(OMELKCOGCBK inv, out NAELPAAELNO privilegeItem)
	{
		privilegeItem = null;
		return false;
	}

	private bool TryGetEquippedPrivilegeItem(LobbySocialPropType propType, OMELKCOGCBK inv, out NAELPAAELNO privilegeItem)
	{
		privilegeItem = null;
		return false;
	}

	private void TryCancelEquippedPrivilegeItem(OMELKCOGCBK inv, NAELPAAELNO privilegeItem)
	{
	}

	private void OnMainBtnClick()
	{
	}

	public void ClearSocialLobbyLocalPlayerState()
	{
	}

	public void LogClick(string posfix)
	{
	}

	private void InitGuideKey()
	{
	}

	private void SaveGuideKey()
	{
	}

	private void CheckGuide()
	{
	}

	private void OnNinthTokenVFXFlyFinishedCallback()
	{
	}

	private void PlayTokenVFXFlyEffect()
	{
	}

	private void ClearGuide()
	{
	}

	private void _003CCheckGuide_003Eb__139_0()
	{
	}

	private void _003COnNinthTokenVFXFlyFinishedCallback_003Eb__140_0()
	{
	}

	private void _003CPlayTokenVFXFlyEffect_003Eb__141_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
