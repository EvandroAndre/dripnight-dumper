using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudInventoryController : UIBaseController
{
	public enum SlotType : byte
	{
		Vest,
		Helmet,
		Bag,
		Cover,
		PrimaryW,
		SecondaryW,
		SideW,
		Melee,
		Device
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__129_1;

		public static Action _003C_003E9__201_0;

		public static Action _003C_003E9__201_1;

		internal void _003COnVisibilityChanged_003Eb__129_1()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__201_0()
		{
		}

		internal void _003CSetControllerCursorEvent_003Eb__201_1()
		{
		}
	}

	private sealed class _003CInitFCoroutine_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInventoryController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitFCoroutine_003Ed__55(int _003C_003E1__state)
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

	private sealed class _003CRefreshCorListItem_003Ed__148 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIHudInventoryController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshCorListItem_003Ed__148(int _003C_003E1__state)
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

	public static float bag_open_time_delta;

	private UIHudInventoryView m_View;

	private Dictionary<uint, List<UIHudInventoryItemController>> m_ItemControllers;

	private List<UIHudInventoryItemController> m_ListEndControllers;

	private UIHudInventoryEquipSlotItemController m_VestSlot;

	private UIHudInventoryEquipSlotItemController m_HelmetSlot;

	private UIHudInventoryEquipSlotItemController m_BagSlot;

	private UIHudInventoryEquipSlotItemController m_CamouflageSlot;

	private UIHudInventoryEquipSlotItemController m_DeviceSlot;

	private UIHudInventoryWeaponSlotItemController m_WeaponP1Slot;

	private UIHudInventoryWeaponSlotItemController m_WeaponP2Slot;

	private UIHudInventoryWeaponSlotItemController m_WeaponS1Slot;

	private UIHudInventoryWeaponSlotItemController m_WeaponM1Slot;

	private UIHudPartialTrashController m_PartialTrash;

	private UIHudInventoryTeammateItemGivenController m_TeammateItemGivenCtrl;

	private UIHudPartialTrasferController m_PartialTransferCtrl;

	private UIPanel m_ScrollViewPanel;

	private Vector2 m_CurrentClipOffset;

	private Vector3 m_CurrentPanelLocalPos;

	private Vector3 tempGridPos;

	private bool m_IsInventoryClosed;

	private bool m_IsEquipmentStateChangeEventRegistered;

	private bool inventoryTutorialShowed;

	private bool showDropTutorialPrepared;

	private bool dropCamouflageOpenBagShowed;

	private bool showDropCamouflageNoteTutorialPrepared;

	private bool m_SortState;

	private bool m_ItemDragged;

	private bool m_PendingRefreshCollectionTrialSightItems;

	private bool m_FirstGridReposition;

	public static Color m_SpareItemNameColor;

	public static Color m_NormalItemNameColor;

	protected static int m_ItemToggleGroupID;

	private UIHudWeaponAttributeTipsController m_TipCtrl;

	private List<UIItem> m_DeviceItemData;

	private float m_ValidRequestTime;

	private Dictionary<int, List<string>> SlotsKey;

	private List<UIHudInventoryTagController> m_Ctrl;

	private NAELPAAELNO m_weaponReplacer;

	private bool m_CurCombineState;

	private const string ItemCombineSpriteName = "FF_UI_bagchange";

	private const string ItemNotCombineSpriteName = "FF_UI_bagchange01";

	private UIHudWeaponPropertyListHelper m_PropertyListHelper;

	private IEnumerator InitCoroutine;

	private bool isInited;

	private bool needRefresh;

	private bool m_LastSelectIsAttachment;

	private bool m_LastSelectIsEquipAttachment;

	private bool m_IsOverTrashPartial;

	private bool m_IsFirstMoveUpDown;

	private List<UISprite> m_LineUIList;

	private List<UISprite> m_LineUIAllList;

	public float DragScale;

	public float LockedDragScale;

	public float DragFullHeight;

	public float CachedDragY;

	public float OneForHeight;

	public bool IsInLockedArea;

	public UIInventoryItemControllerBase m_CurDragItem;

	public float CurDragItemCount;

	private bool m_IsShowAmmoGuideEffectOnce;

	private UIHudInventoryItemController m_ShowGuideItem;

	private uint m_ShowGuideItemID;

	private bool ShowEighthInfiniteEffect;

	private UIHudInvUpgradeToggleBtnsController m_InvUpgradeToggleBtnsController;

	private UIHudInvUpgradeInfoPanelController m_InvUpgradeInfoPanelController;

	private bool m_IsUpgradeTabSelectedWhenInit;

	private bool m_IsPreSelectedTabWeapon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool IsSuspendingEnabled()
	{
		return false;
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

	protected IEnumerator InitFCoroutine()
	{
		return null;
	}

	protected void Init()
	{
	}

	protected void PreRegisterEvents()
	{
	}

	protected void Init_Part1()
	{
	}

	protected void Init_Part2()
	{
	}

	protected void Init_Part3()
	{
	}

	protected void Init_Part4()
	{
	}

	protected void Init_Part5()
	{
	}

	private void RegisterEquipmentStateChangeEvent()
	{
	}

	private void UnRegisterEquipmentStateChangeEvent()
	{
	}

	protected void Init_Part6()
	{
	}

	protected void Init_Part7()
	{
	}

	private void InitView1()
	{
	}

	private void InitView2()
	{
	}

	private int SortItemListGrid(Transform tr1, Transform tr2)
	{
		return 0;
	}

	private int SortItemListGridByPriority(NAELPAAELNO itemData1, NAELPAAELNO itemData2, out bool isSorted)
	{
		isSorted = default(bool);
		return 0;
	}

	private void SwitchItemCombineState()
	{
	}

	private void InitInventoryItemPool()
	{
	}

	private void InitInventoryTagPool()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void Update()
	{
	}

	private void OnInventoryTrashStateChange(object[] data)
	{
	}

	private void OnInventoryDragMove(GEvent data)
	{
	}

	private void UpdatePartialScrollInfo()
	{
	}

	private void RefreshDropInfoEffect(bool isShowPanel, bool isShowTotalNum)
	{
	}

	private void OnTrashPartialShow(object[] data)
	{
	}

	private void OnPartialTransferShow(object[] data)
	{
	}

	private void OnVestToggleChanged()
	{
	}

	private void OnHelmetToggleChanged()
	{
	}

	private void OnBagToggleChanged()
	{
	}

	private void OnCoverToggleChanged()
	{
	}

	private void OnDeviceToggleChanged()
	{
	}

	private void OnPrimaryWToggleChanged()
	{
	}

	private void OnSecondaryWToggleChanged()
	{
	}

	private void OnSideWToggleChanged()
	{
	}

	private void OnMeleeToggleChanged()
	{
	}

	private bool OnEscapeClick()
	{
		return false;
	}

	private void OnInventoryOpen(object[] param)
	{
	}

	private void CheckChangeItemColor()
	{
	}

	private void OnClickDropAllUselessItem()
	{
	}

	private void OnItemDragStart(object[] datas)
	{
	}

	private void OnShowIngameShop(object[] data)
	{
	}

	private void OnTryReplaceWeapon(object[] data)
	{
	}

	private void setTryReplaceWeapon(NAELPAAELNO replacer)
	{
	}

	private void OnRepositionGrid(object[] data)
	{
	}

	private void OnTokenChanged(int data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnBtnCloseClick()
	{
	}

	private void OnBtnCloseMask()
	{
	}

	private void OnBtnSort()
	{
	}

	public int Exchange2NewNegativeId(int type)
	{
		return 0;
	}

	public int Exchange2NewPositiveId(int type)
	{
		return 0;
	}

	private int ItemPositiveSort(UIItem a, UIItem b)
	{
		return 0;
	}

	private int ItemPositiveSortBySiblingIndex(UIHudInventoryItemController a, UIHudInventoryItemController b)
	{
		return 0;
	}

	private int ItemNegativeSort(UIItem a, UIItem b)
	{
		return 0;
	}

	private void OnAddLocalPlayer(object[] param)
	{
	}

	private void OnCapacityRefresh(bool param)
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	private void RefreshVisibilityWithType(UInt128 activeGroup)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnInventoryRefresh(object[] param)
	{
	}

	private void CloseWeaponInfoCtrls()
	{
	}

	private bool IsAttachmentValid(EJNFNOJNCPE data)
	{
		return false;
	}

	private bool IsEquipAttachmentValid(DFBPGIINGFN data)
	{
		return false;
	}

	private void ShowEquipAttachmentTip(DFBPGIINGFN data)
	{
	}

	private void StopEquipAttachmentTip()
	{
	}

	private void DisableBtnEmptySlot()
	{
	}

	private void EnableBtnEmptySlot()
	{
	}

	private void ShowAttachmentTip(EJNFNOJNCPE data)
	{
	}

	private void StopAttachmentTip()
	{
	}

	private void OnInventoryItemSelected(object[] param)
	{
	}

	private void ShowIceWallMaker(HENEHAGJCLI itemData)
	{
	}

	private void ShowIceWallMakerExp()
	{
	}

	private void OnIceWallMakerExpChange(object[] data)
	{
	}

	private void OnIceWallMakerLevelChange(object[] data)
	{
	}

	private void OnInventoryItemUnSelected(object[] param)
	{
	}

	private void ShowWeaponAttributeTips(bool show, NAELPAAELNO item)
	{
	}

	private void OnInventoryItemReleased(object[] param)
	{
	}

	private IEnumerator RefreshCorListItem()
	{
		return null;
	}

	private void OnInventoryAttachmentStateChanged(object[] param)
	{
	}

	private void OnInventoryEquipmentMinDurabilityLockChanged()
	{
	}

	private void OnInventoryEquipmentStateChanged(GEvent param)
	{
	}

	private void SetDescItemName(string txt, string typeTxt = "")
	{
	}

	private void ClearDescription()
	{
	}

	private void RemoveItemFromList(NAELPAAELNO item)
	{
	}

	private void ReSumeItemGrid()
	{
	}

	private void ReSetNewItemListGrid()
	{
	}

	private void ResetItemListGrid(bool flag = true)
	{
	}

	private void RefreshItemList(NAELPAAELNO item)
	{
	}

	private bool TryRefreshCollectionTrialSightItems(NAELPAAELNO item)
	{
		return false;
	}

	private bool IsCollectionTrialSightItem(NAELPAAELNO item)
	{
		return false;
	}

	private void RefreshCollectionTrialSightItems()
	{
	}

	private bool RemoveCollectionTrialSightControllers()
	{
		return false;
	}

	private bool RemoveCollectionTrialSightDeviceItems()
	{
		return false;
	}

	private int CompareCollectionTrialSightItem(NAELPAAELNO itemA, NAELPAAELNO itemB)
	{
		return 0;
	}

	private void RemoveAmmoGuide()
	{
	}

	private void UpdateItemGrid()
	{
	}

	private void ShowHGGuid()
	{
	}

	private void RefreshWeaponAmmo()
	{
	}

	private void RefreshWeaponUpgradeInfo()
	{
	}

	private UIHudInventoryItemController OpenInventoryItemControllerFromPool(Transform transform)
	{
		return null;
	}

	private void CloseInventoryItemController(UIHudInventoryItemController itemController, NAELPAAELNO item)
	{
	}

	private UIHudInventoryTagController OpenInventoryTagFromPool(Transform transform)
	{
		return null;
	}

	private void CloseInventoryTagItemController(UIHudInventoryTagController itemController)
	{
	}

	private void SetScrollPos()
	{
	}

	private void RessetScrollPos()
	{
	}

	private void CloseInventory(object[] data)
	{
	}

	private void OnInventoryDragAndDrop(object[] data)
	{
	}

	private void OnInventoryNoCapacityToPickup(object[] data)
	{
	}

	private void OnShowDropTutorial(object[] data)
	{
	}

	private void OnDropCamouflageOpenBagShowed(object[] data)
	{
	}

	private void OnShowTutorialDropCamouflageNote(object[] data)
	{
	}

	private void OnReplacerCountChange(object[] data)
	{
	}

	private void RefreshUpgradeWeaponStatus()
	{
	}

	private void InitToggle()
	{
	}

	private void RefreshDeviceBag(NAELPAAELNO item, uint sortId, bool isBigItem)
	{
	}

	private bool AddDeviceToBag(NAELPAAELNO item, bool isBigItem, uint sortId)
	{
		return false;
	}

	private void CreateItem(NAELPAAELNO item, bool isBigItem, uint sortId, int index)
	{
	}

	private int FindIndexInDeivce(NAELPAAELNO item)
	{
		return 0;
	}

	private bool RemoveDeviceFromBag(NAELPAAELNO item, bool isBigItem)
	{
		return false;
	}

	private void RebuildTable2View()
	{
	}

	private void OnCapactiyMenuSelected()
	{
	}

	private void OnDeviceMenuSelected()
	{
	}

	private void RefreshToggleState(bool capactiySelected)
	{
	}

	private void RefreshDeviceBag()
	{
	}

	private void OnItemClick(object[] data)
	{
	}

	private void TrySendNeedItemQuickMsg(UIInventoryItemControllerBase itemController)
	{
	}

	private void OnItemLongPress(object[] data)
	{
	}

	private void TrySendHasItemQuickMsg(UIInventoryItemControllerBase itemController)
	{
	}

	private void OnWeaponUpgradeServerChanged(int data)
	{
	}

	private void OnShowPersonalShop(object[] datas)
	{
	}

	protected override void SetControllerCursorEvent(Action OnShow, Action OnHideOrDestory)
	{
	}

	private void OnEighthShowInfiniteItemRewardFlyEnd(object[] param)
	{
	}

	private void RefreshEighthBg()
	{
	}

	private void RefreshShowEighthInfiniteEffect()
	{
	}

	private bool ShouldFilterAmmoItem(NAELPAAELNO item)
	{
		return false;
	}

	private void Init_Part8()
	{
	}

	private void CheckAndShowTutorial()
	{
	}

	private void OnInventorySelectUpgradeTab()
	{
	}

	private void RefreshWeaponPropertyLayout()
	{
	}

	private void RefreshInventoryWeaponPropertyList(FDAEPHMIEPC weapon)
	{
	}

	private void OnSelectedInventoryWeaponReinforced(uint uniqueID)
	{
	}

	private bool HasCSReinforceAbility(FDAEPHMIEPC weapon)
	{
		return false;
	}

	private bool HasBRReinforceAbility()
	{
		return false;
	}

	private void _003CInit_Part7_003Eb__66_0(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_1(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_2(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_3(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_4(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_5(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_6(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_7(GameObject obj)
	{
	}

	private void _003CInit_Part7_003Eb__66_8(GameObject obj)
	{
	}

	private void _003COnVisibilityChanged_003Eb__129_0()
	{
	}

	private UITable2.IUITable2Item _003CInitToggle_003Eb__184_0()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitToggle_003Eb__184_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitToggle_003Eb__184_2()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitToggle_003Eb__184_3()
	{
		return null;
	}

	private void _003CInit_Part8_003Eb__211_0()
	{
	}

	private void _003CInit_Part8_003Eb__211_1()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsSuspendingEnabled()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_KillCamRecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIReInit()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
