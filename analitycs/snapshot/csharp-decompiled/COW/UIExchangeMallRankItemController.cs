using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIExchangeMallRankItemController : UIMallItemWidgetController
{
	protected ExchangeStoreItemDesc m_ExchangeItem;

	private Dictionary<int, bool> m_ChildTransformActiveDict;

	private bool m_isFirstTimeInit;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetWidgetIgnoreBound(bool value)
	{
	}

	private void ShowObject()
	{
	}

	private void HideObject()
	{
	}

	protected override void RefreshItemView()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	protected override void ResetState()
	{
	}

	protected void SetExchangePriceLabel()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	private void SetExchangeIcon()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
