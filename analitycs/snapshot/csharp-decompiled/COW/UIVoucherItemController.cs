using GCommon;

namespace COW;

public abstract class UIVoucherItemController : UIEasyListItemController
{
	protected EVoucherState m_State;

	protected VoucherData m_Data;

	protected uint m_ItemPrice;

	protected uint m_ItemGemsPrice;

	protected uint m_ItemCoinsPrice;

	protected VoucherData m_SelectedVoucher;

	protected const uint ITEM_GREY = 2139062271u;

	public override void OnItemBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public abstract void RefreshView();

	public void SetVoucherData(uint itemGemsPrice, uint itemCoinsPrice, VoucherData selectedVoucher)
	{
	}

	public abstract void AdjustWidth(int width);

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}
}
