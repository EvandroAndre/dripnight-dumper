using GCommon;
using proto;

namespace COW;

public class UIClanActiveExchangeMallItemController : UIMallItemWidgetController
{
	protected ExchangeStoreItemDesc m_ExchangeItem;

	private bool m_IsReachClanLevel;

	private uint m_MyClanLevel;

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

	public override void RefreshItemBGState()
	{
	}

	private void CheckIsReachClanLevel()
	{
	}

	protected override void SetLimitedTitleState()
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

	protected void SetDiamondPrice()
	{
	}

	protected override void SendItemClickEvent()
	{
	}

	private void SetExchangeIcon()
	{
	}

	private void SetLimitedState()
	{
	}

	private void RefreshClanLevelTitle()
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

	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}

	public void _003C_003EiFixBaseProxy_SetLimitedTitleState()
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
}
