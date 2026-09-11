using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMallVoucherController : UIVoucherController
{
	private UIMallVoucherView m_View;

	private UIVoucherListController m_Ctrl;

	private List<VoucherData> m_VoucherData;

	private const uint ITEM_GREY = 1280068863u;

	private int m_Width;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetVoucher(uint gemsPrice, uint coinsPrice)
	{
	}

	public override void OnVoucherListClose(object[] data)
	{
	}

	public override void OnVoucherItemClick(object[] data)
	{
	}

	public override void OnVoucherBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetWidth()
	{
	}

	public override void AdjustWidth(int width)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
