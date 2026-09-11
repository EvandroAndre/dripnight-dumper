using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2ShoppingMallItemController : UIMallV2ItemBaseController, UITable2.IUITable2Item
{
	protected new CSSharedItemData m_ItemData;

	protected UIModelShoppingMall m_ModelShoppingMall;

	private UIModelVeteran m_ModelVeteran;

	private ShoppingMallScreenDesc m_ShoppingMallItemData;

	private uint? m_IsSelectIndex;

	private UIMallV2ShoppingMallItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SelectItemByContainerSelect()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private void ShowCDNBG(string URL)
	{
	}

	public void SetHighLightState(bool state)
	{
	}

	public void SetSelectState(uint? state)
	{
	}

	public uint? GetItemSelectState()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
