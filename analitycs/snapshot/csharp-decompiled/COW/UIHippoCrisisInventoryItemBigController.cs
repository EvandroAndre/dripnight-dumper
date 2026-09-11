using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisInventoryItemBigController : UIBaseController, UITable2.IUITable2Item
{
	private UIHippoCrisisInventoryItemBigView m_View;

	private HippoCrisisStoreItemData m_StoreData;

	private HippoCrisisOutGameItemUIData m_InventoryData;

	private HENEHAGJCLI m_ItemData;

	private UIHippoCrisisInventoryDragDropItem m_DropItem;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private bool m_Selected;

	private bool m_IsInventoryItem;

	private UIHippoCrisisPreStartController m_ParentCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	private void SetViewData(HippoCrisisOutGameItemUIData inventoryData)
	{
	}

	private void SetViewData(HippoCrisisStoreItemData storeData)
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void OnSelected()
	{
	}

	public void SelectItem()
	{
	}

	public void RefreshSelectState()
	{
	}

	public ulong GetInstIDOrStoreId()
	{
		return 0uL;
	}

	public bool GetIsInvnetoryItem()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
