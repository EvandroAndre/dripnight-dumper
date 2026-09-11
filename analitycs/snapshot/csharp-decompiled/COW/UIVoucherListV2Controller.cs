using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIVoucherListV2Controller : UIPopupWindowController, IEasyList
{
	private UIVoucherListV2View m_View;

	private List<VoucherData> m_VoucherDataList;

	private UIClickMask m_ClickMask;

	private int m_TotalGemsPrice;

	private int m_TotalCoinsPrice;

	private VoucherData m_VoucherData;

	private Func<Transform, UIVoucherItemController> m_CustomItemCreator;

	private int m_Width;

	private int[] m_VoucherBorderSize;

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

	private void OnVoucherItemClick(object[] data)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(int totalGemsPrice, int totalCoinsPrice, VoucherData selectedVoucher, Func<Transform, UIVoucherItemController> customItemCreator)
	{
	}

	private void SortVoucherList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void AdjustWidth(int width)
	{
	}

	private int _003CSortVoucherList_003Eb__16_0(VoucherData a, VoucherData b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
