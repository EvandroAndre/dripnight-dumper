using System.Collections.Generic;
using System.Text;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryWeaponSlotItemController : UIInventoryItemControllerBase
{
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIToggle btn;

		public GIANNEDDMLL val;

		public UIHudInventoryWeaponSlotItemController _003C_003E4__this;

		internal void _003COnUIReInit_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public UIHudInventoryWeaponSlotItemController _003C_003E4__this;

		public ResourceID resid;

		internal void _003CRefreshWeaponSprite_003Eb__0(uint ticket, bool ret, Object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UIHudInventoryWeaponSlotItemController _003C_003E4__this;

		public HENEHAGJCLI itemData;

		internal void _003CSetUIData_003Eb__0(uint ticket, bool ret, Object obj)
		{
		}
	}

	protected UIHudInventoryWeaponSlotItemView m_View;

	private GameObject m_EmptyBG;

	private UIHudInventoryAttachmentSlotItemController[] m_Attachments;

	private UIHudInventoryAttachmentSlotItemController m_ActivitySlot;

	private StringBuilder m_Sb;

	private bool m_EnergyWeaponEventsRegisterd;

	private uint m_ShowingSpriteWeaponId;

	private GIANNEDDMLL m_UpgradeSlotType;

	private bool m_CanGoldUpgrade;

	private bool m_CanUpgrade;

	private float m_UpgradeProgress;

	private UIClickMask m_ClickMask;

	private WeaponTermAssignData m_WeaponTermAssignData;

	private UIDetailTipsInGameController m_DetailTipsCtrl;

	private GIANNEDDMLL m_HelightSlot;

	private VisualInstanceHolder[] m_BreathVFXHolder;

	private GameObject[] m_BreathVFXArray;

	private GameObject[] m_BtnRootArray;

	private UIWidget[] m_BtnColArray;

	private UIToggle[] m_BtnSlotArray;

	private GameObject[] m_TipTxtArray;

	private uint m_CurrentActivityAttachmentSlotId;

	private bool ShowEighthInfiniteEffect;

	private GameObject m_replaceEffect;

	private int m_LastShowLevel;

	private ResourceID m_LastShowLevelResID;

	private List<UISprite> m_CustomLevelList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool KillCamDontDestroy()
	{
		return false;
	}

	public override bool KillCamRecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	public override void OnUIReInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public UIInventoryItemDragDropContainer GetDragContatiner()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	private void RegisterEnergyWeaponEvents()
	{
	}

	private void UnRegisterEnergyWeaponEvents()
	{
	}

	private void OnEnergyWeaponEnergyChange(object[] ps)
	{
	}

	public void ShowHGGuid()
	{
	}

	public void RefreshWeaponAmmo()
	{
	}

	public void RefreshAttachmentState()
	{
	}

	public void SetDrapDropType(OOOMOIADBFJ type, GameObject emptyBG)
	{
	}

	public void RefreshWeaponSprite()
	{
	}

	private void SetLevelEffect()
	{
	}

	private void OnWeaponTermChanged(uint uniqueNetID)
	{
	}

	private void RefreshAwakenTab()
	{
	}

	private void OnAwakenTabClick()
	{
	}

	private void OnApplicationFocus(bool hasFocus)
	{
	}

	private void OnInventoryOpen(object[] data)
	{
	}

	private void OnTermIconPressed(GameObject go)
	{
	}

	private void TryDestroyClickMask()
	{
	}

	private void OnClickMaskTriggered()
	{
	}

	private void UpdataeWeaponTermState()
	{
	}

	public virtual void SetUIData(UIItem item)
	{
	}

	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public override void OnDrapStart()
	{
	}

	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return false;
	}

	public override UIToggle GetToggle()
	{
		return null;
	}

	public override GameObject GetHighlightGO()
	{
		return null;
	}

	public override void SetHighlightGoActive(bool paramActive)
	{
	}

	public override GameObject GetDragGO()
	{
		return null;
	}

	public override GameObject GetNonDragGO()
	{
		return null;
	}

	public override GameObject GetDragRedGo()
	{
		return null;
	}

	public void UpdateReplaceState(NAELPAAELNO replacer)
	{
	}

	public void RefreshGoldUpgradeStatus()
	{
	}

	public void RefreshWeaponUpgradeStatus()
	{
	}

	public void UpgradeWeapon()
	{
	}

	private void OnBtnCannotUpgradeClick()
	{
	}

	private void OnActivityAttachmentSlotBtnClick()
	{
	}

	public void RefreshUpgradeEffect(bool isShow)
	{
	}

	private void RefreshUpgradeEffect()
	{
	}

	private void PlayerRealUpgradeEffect(object[] param)
	{
	}

	public string GetAttachmentDesc()
	{
		return null;
	}

	public void StopAttachmentTip()
	{
	}

	public bool IsAttachmentValid(EJNFNOJNCPE data)
	{
		return false;
	}

	public void ShowVFXAttachment(EJNFNOJNCPE data)
	{
	}

	private void OnBtnSlotClick(GIANNEDDMLL slot, bool isInitSet = false)
	{
	}

	public void EnableBtnSlot()
	{
	}

	public void DisableBtnSlot()
	{
	}

	private void OnEighthShowInfiniteItemRewardFlyEnd(object[] param)
	{
	}

	private void RefreshEighthBg()
	{
	}

	private void InitEighthBg(bool clearFlag = true)
	{
	}

	private void RefreshShowEighthInfiniteEffect()
	{
	}

	private void RefreshReinforceState()
	{
	}

	private void OnWeaponReinforced(uint uniqueID)
	{
	}

	private void UpdateReinforceState()
	{
	}

	public void RefreshWeaponCustomLevel(UIItem item)
	{
	}

	private void ClearCustomLevel()
	{
	}

	private void _003COnUIReInit_003Eb__27_0()
	{
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return false;
	}
}
