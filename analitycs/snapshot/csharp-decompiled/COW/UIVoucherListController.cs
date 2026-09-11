using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIVoucherListController : UIPopupWindowController, IEasyList
{
	private UIVoucherListView m_View;

	private List<VoucherData> m_VoucherDataList;

	private UIClickMask m_ClickMask;

	private int m_TotalGemsPrice;

	private int m_TotalCoinsPrice;

	private VoucherData m_VoucherData;

	private Func<Transform, UIVoucherItemController> m_CustomItemCreator;

	private int m_Width;

	private int[] m_VoucherBorderSize;

	private const int m_VoucherItemSize = 50;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	private int _003CSetData_003Eb__15_0(VoucherData a, VoucherData b)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
