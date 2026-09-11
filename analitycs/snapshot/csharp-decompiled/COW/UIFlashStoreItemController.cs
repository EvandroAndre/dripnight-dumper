using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIFlashStoreItemController : UIMallItemWidgetController
{
	protected FlashStoreGoodsDesc m_ExchangeItem;

	private Dictionary<int, bool> m_ChildTransformActiveDict;

	protected UIModelFlashStore.EFlashStoreItemPriceState m_PriceState;

	private UIFlashStorePriceController m_PriceController;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	protected override void RefreshItemView()
	{
	}

	protected override void ResetState()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void SetPreviewTitle()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void SetGenderView()
	{
	}

	private void SetDefaultState()
	{
	}

	public void SetWidgetIgnoreBound(bool value)
	{
	}

	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
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

	public void _003C_003EiFixBaseProxy_SetPreviewTitle()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
