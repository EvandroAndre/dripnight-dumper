using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2VeteranDiscountItemController : UIMallV2ItemBaseController, UITable2.IUITable2Item
{
	private UIMallV2ItemAdaptorView m_View;

	private UIStandardItemMAXCController m_ItemController;

	private UIStandardItemMAXCPriceController m_PriceController;

	private UIStandardItemMAXCItemTagController m_ItemTagController;

	private UIModelVeteran m_ModelVeteran;

	private VeteranStoreDesc m_DiscountItem;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void RefreshItemView()
	{
	}

	public override void RefreshItemBGState()
	{
	}

	private void RefreshUnFreeItemView()
	{
	}

	protected override void ResetState()
	{
	}

	public void HideAllTag()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	private void InitCommonWidget()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	protected override void SendClothClickEvent()
	{
	}

	protected override void OnStartToggleMove()
	{
	}

	protected override void OnFinishToggleMove()
	{
	}

	public void SetPosition(Vector2 position)
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetTable2Visible(bool visible)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}

	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartToggleMove()
	{
	}

	public void _003C_003EiFixBaseProxy_OnFinishToggleMove()
	{
	}
}
