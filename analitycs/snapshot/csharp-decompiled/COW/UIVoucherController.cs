using GCommon;

namespace COW;

public abstract class UIVoucherController : UIBaseController
{
	protected int m_TotalGemsPrice;

	protected int m_TotalCoinsPrice;

	protected VoucherData m_SelectedVoucherData;

	protected IVoucher m_Voucher;

	public abstract void OnVoucherListClose(object[] data);

	public abstract void OnVoucherItemClick(object[] data);

	public void RefreshTotalPrice(int totalGemsPrice, int totalCoinsPrice)
	{
	}

	public abstract void OnVoucherBtnClick();

	public virtual void RefreshVoucherData(int totalGemsPrice, int totalCoinsPrice, IVoucher voucher)
	{
	}

	public abstract void SetVoucher(uint gemsPrice, uint coinsPrice);

	public abstract void AdjustWidth(int width);
}
