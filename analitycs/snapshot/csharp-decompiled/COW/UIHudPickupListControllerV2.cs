using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudPickupListControllerV2 : UIBaseController, IEasyList, IPickupListTagRepeatedSetProxy
{
	private UIHudPickupListV2View m_View;

	private List<ICLMFONIIKB> m_CurrentPickupList;

	private List<ICLMFONIIKB> m_EmptyList;

	private List<ICLMFONIIKB> m_OriginalPickupList;

	private LevelContainer m_CurrentContainer;

	private IOENNEBCHBF m_CurrentLContainer;

	private ICHIELDFELI m_PickupCombiner;

	private uint m_CurrentContainerID;

	private List<UIHudPickupListItemController> m_InventoryTrashItemControllers;

	private readonly Dictionary<uint, int> m_TagItemToIndexIDInTrashDic;

	private readonly Dictionary<uint, int> m_TagItemToIndexIDInPickUpDic;

	private bool m_IsInventoryOpen;

	private bool m_PendingInventoryUpdate;

	private AutoPickUpHelper m_AutoPickUp;

	private int m_ScrollViewDepth;

	private bool m_IsEnterPickUpArea;

	private int m_MaxPickupLength;

	private int pickupcellwidth;

	public const uint VISIBILITY_STATE_TRANSFERPARTIAL = 268435456u;

	public const uint VISIBILITY_STATE_ItemMarkGridWnd = 536870912u;

	public const uint VISIBILITY_STATE_TRASHPARTIAL = 1073741824u;

	private Vector3 ScrollViewRootOrgPos;

	private float m_defaultGridItemHeight;

	private float m_defaultTrashGridItemHeight;

	private List<LevelContainer> m_CurrentContainerList;

	private List<IOENNEBCHBF> m_CurrentLContainerList;

	private bool m_NeedRefresh;

	private bool m_NeedRefreshAuto;

	private EPickupListOp m_PickupOP;

	private List<ICLMFONIIKB> m_DeletedPickupList;

	private bool m_LastPickupDisabledState;

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

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private UIHudPickupListItemController GetPickupTrashListItem(int index)
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void OnShowPickUpList(object[] data)
	{
	}

	public void SetCustomTrans(Vector3 pos)
	{
	}

	public void SetCustomScale(Vector3 scale)
	{
	}

	private void OnHIdePickUpList(object[] data)
	{
	}

	private void FreezeAutoPickup(object[] data)
	{
	}

	private void FreezeAutoPickupDrop(uint id)
	{
	}

	private void RefreshPickLevel(object[] data)
	{
	}

	private void RefreshItemState(bool data)
	{
	}

	private void OnWeaponChange(object[] data)
	{
	}

	private void ForceRefreshPickUpList()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public bool IsEqualPickUp(ICLMFONIIKB pu1, ICLMFONIIKB pu2)
	{
		return false;
	}

	public static bool OnPickUpItemAction(bool isAutoPickUp, ICLMFONIIKB m_CurrentItem, bool isToSafeBox, bool equipImmediately = true)
	{
		return false;
	}

	private void OnAutoPickUp(object[] data)
	{
	}

	private void RefreshAutoPickupList()
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void SortList(List<ICLMFONIIKB> targetlist)
	{
	}

	private void OnRefreshPickupArea(GEvent param)
	{
	}

	private void OnRefreshLPickupArea(GEvent param)
	{
	}

	private void OnEnterPickupArea(GEvent param)
	{
	}

	private void OnEnterLPickupArea(GEvent param)
	{
	}

	private void DoOnEnterLPickupArea(Player.IAMEOGKAJBN curPickupLAreaEvent)
	{
	}

	private void DoOnEnterPickupArea(Player.OJOGAHIAAJM curPickupAreaEvent)
	{
	}

	private void DoOnTriggerPickupChanged()
	{
	}

	private void LateUpdate()
	{
	}

	private void OnLevelLContainerDel(object[] param)
	{
	}

	private void OnLevelContainerDel(object[] param)
	{
	}

	private void RefreshCurrentPickUpList(EPickupListOp op)
	{
	}

	private void OnExitPickupArea(object[] param)
	{
	}

	public bool IsPickupListPanelShowing()
	{
		return false;
	}

	private void DoOnTriggerPickupEmpty()
	{
	}

	private void OnSettingChange(object[] data)
	{
	}

	private void OnInventoryOpen(object[] param)
	{
	}

	private void OnInventoryClose(object[] param)
	{
	}

	private void RefreshPickupItem()
	{
	}

	private void RefreshPickupEasyListToTop()
	{
	}

	private void RefreshPickupEasyListPos()
	{
	}

	private void ChcekPickupIsDisappear(List<ICLMFONIIKB> paramPickupList)
	{
	}

	private void RefreshPickupNewItem()
	{
	}

	private void RefreshUIData()
	{
	}

	public bool CheckInScrollDrag()
	{
		return false;
	}

	private void RefreshTutorial()
	{
	}

	public int GetGridepth()
	{
		return 0;
	}

	public bool CheckShowItemTag(uint itemID, int index, out bool isInDic)
	{
		isInDic = default(bool);
		return false;
	}

	public void SetItemTagDic(uint itemID, int index)
	{
	}

	private void ProcessPickUpListV2ItemTagDic(List<ICLMFONIIKB> pickUpV2List)
	{
	}

	public bool CheckShowItemTagInV2PickUpList(uint itemID, int index)
	{
		return false;
	}

	public UIWidget GetMaskFullRegion()
	{
		return null;
	}

	public Vector3 GetPickupFirstItemPos()
	{
		return default(Vector3);
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
