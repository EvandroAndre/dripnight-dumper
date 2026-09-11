using GCommon;
using UnityEngine;

namespace COW;

internal class UINewVaultEmoteItemController : UIEasyListItemController, IUIModelDataChangeObserver, IUINewVaultLovableItem
{
	private UINewVaultEmoteItemView m_View;

	private UINewVaultItemViewData m_data;

	private ResourceID m_EmoteIconRes;

	private uint m_ItemIconGrey;

	private UINewVaultController m_ParentController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public int GetEmoteID()
	{
		return 0;
	}

	private void SetIPTag()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void OnDragDropRelease(uint slotIndex, uint emoteID)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void RefreshEquipState()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void RefreshNewGetState()
	{
	}

	public void RefreshIsLoved(bool playVFX = false)
	{
	}

	public void SetDragPanel()
	{
	}

	public void SetDragDropConActive(bool show)
	{
	}

	public void SetDragDropIcon()
	{
	}

	public void SetDragMove(Vector3 pos)
	{
	}

	public void SetEmoteTrashContainerActive(bool show)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
