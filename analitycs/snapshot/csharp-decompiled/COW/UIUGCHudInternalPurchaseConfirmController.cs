using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCHudInternalPurchaseConfirmController : UIMallPurchaseBaseController, IUIModelDataChangeObserver
{
	private UIModelUGCCommerceIAP m_Model;

	private WorkshopProductInfo m_Data;

	private string m_ItemCode;

	private static readonly Color32 m_PurchaseLimitedTextColor;

	private static readonly Color32 m_TextGreyColor;

	private bool m_NoProductTipsShown;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViewData(string itemCode)
	{
	}

	public void SetViewState(bool messageWindow, bool empty)
	{
	}

	public void SetViewData(WorkshopProductInfo data, int count = 1)
	{
	}

	private void HandleSpecialProductStatus()
	{
	}

	public void SetConfirmBtnState(bool enable)
	{
	}

	private void OnUGCTokenPurchaseBtnClick()
	{
	}

	private bool CanAffordPurchase()
	{
		return false;
	}

	private bool IsProductNotListed()
	{
		return false;
	}

	private bool IsProductSoldOut()
	{
		return false;
	}

	public uint GetTotalPrice()
	{
		return 0u;
	}

	public void OnBtnClose()
	{
	}

	public void CloseByEvent()
	{
	}

	private void InitItemInfoForUGC(BaseItemInfo baseItemInfo)
	{
	}

	private void ShowLimitedPurchaseAsItem(uint limited_purchase_times, uint account_purchase_times)
	{
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	public void RefreshViewData()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public int _003C_003EiFixBaseProxy_MinGroupDepth()
	{
		return 0;
	}
}
