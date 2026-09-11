using GCommon;
using proto;

namespace COW;

public class UIGachaTokenExchangeItemController : UIEasyListItemController
{
	protected ChestSpecialExchangeDesc m_ExchangeItem;

	protected UIGachaTokenExchangeController m_GachaTokenExchangeController;

	protected UIStandardItemMAXBPriceController m_ItemPriceController;

	protected UIStandardItemMAXBController m_ItemController;

	protected CSSharedItemData m_ItemData;

	protected UIModelMall m_ModelMall;

	private UIGachaTokenExchangeItemView m_View;

	protected bool m_IsUniqueAndOwned;

	protected bool m_HavePurchaseTimes;

	protected bool m_IsItemABReady;

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

	public override void SetViewData(object data, int data_index)
	{
	}

	protected void RefreshItemView()
	{
	}

	protected void ResetState()
	{
	}

	private void SetExchangeInfo()
	{
	}

	protected void SetPreviewTitle()
	{
	}

	protected void SetLimitedTitleState()
	{
	}

	protected virtual void SetUniquedTitleState()
	{
	}

	public virtual void RefreshItemBGState()
	{
	}

	public void CheckItemABReady()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
