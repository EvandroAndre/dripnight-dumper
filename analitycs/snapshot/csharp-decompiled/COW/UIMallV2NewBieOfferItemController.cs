using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMallV2NewBieOfferItemController : UIMallV2ItemBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIMallV2NewBieOfferItemView m_View;

	private StarterStoreItemDesc m_NewBieOfferItem;

	private UIStandardItemMAXCController m_ItemController;

	private bool m_IsItem;

	private bool m_UseGotoPos;

	private bool m_UseCDN;

	private bool m_IsGotoNewBieOffer;

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

	public override void SetViewData(object data, int data_index)
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

	private void OnBuyButtonClick()
	{
	}

	private void OnGotoButtonClick()
	{
	}

	private void OnPreviewButtonClick()
	{
	}

	private void RefreshLeftTag()
	{
	}

	private void RefreshPreviewImg()
	{
	}

	private void RefreshNewBieCDNLabel()
	{
	}

	private void RefreshLimitLabel()
	{
	}

	private void RefreshButtonView()
	{
	}

	private void RefreshPurchaseNode()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
