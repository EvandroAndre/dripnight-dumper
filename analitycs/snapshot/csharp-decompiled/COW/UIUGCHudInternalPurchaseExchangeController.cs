using GCommon;
using proto;

namespace COW;

public class UIUGCHudInternalPurchaseExchangeController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIUGCHudInternalPurchaseExchangeView m_View;

	private UIModelUGCCommerceIAP m_Model;

	private uint m_TokenID;

	private uint m_Count;

	private uint m_Price;

	private WorkshopProductInfo m_Data;

	private uint m_ExchangeCount;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetViewData(uint count, uint price, WorkshopProductInfo data)
	{
	}

	public void RefreshViewData()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	public void OnBtnClose()
	{
	}

	public void CloseByEvent()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
