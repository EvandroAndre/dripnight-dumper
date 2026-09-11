using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIMallVoucherV2Controller : UIVoucherController
{
	private UIMallVoucherV2View m_View;

	private UIVoucherListV2Controller m_Ctrl;

	private List<VoucherData> m_VoucherData;

	private int m_Width;

	private bool _003CHasVoucher_003Ek__BackingField;

	private bool m_IsShowIcon;

	public bool HasVoucher
	{
		get
		{
			return _003CHasVoucher_003Ek__BackingField;
		}
		private set
		{
			_003CHasVoucher_003Ek__BackingField = value;
		}
	}

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
