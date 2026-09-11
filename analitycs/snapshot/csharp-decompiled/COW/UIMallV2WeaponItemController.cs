using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIMallV2WeaponItemController : UIMallV2WeaponWidgetItemController
{
	private StoreDesc m_StoreItem;

	private bool m_NeedPlay;

	private List<StoreDesc> m_MixStoreItem;

	private uint m_WeaponType;

	private uint m_WeaponId;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void RefreshItemView()
	{
	}

	public void SetShowItem(uint weaponType, uint weaponId)
	{
	}

	public void RefreshBoxTag()
	{
	}

	protected virtual void SetPriceLabel()
	{
	}

	private StoreDesc GetMixDiscountItem(List<StoreDesc> itemList)
	{
		return null;
	}

	protected override bool CanShowDiscountTag()
	{
		return false;
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void ResetState()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void OnStartToggleMove()
	{
	}

	protected override void OnFinishToggleMove()
	{
	}

	private void _003CSetViewData_003Eb__16_0()
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanShowDiscountTag()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
