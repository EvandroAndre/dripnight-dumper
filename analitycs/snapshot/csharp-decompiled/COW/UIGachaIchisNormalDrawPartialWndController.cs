using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIGachaIchisNormalDrawPartialWndController : UIPopupWindowController
{
	private UIGachaIchisNormalDrawPartialWndView m_View;

	private Action m_OnClose;

	private bool m_HasInvokedOnClose;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshContent()
	{
	}

	private void RefreshRefundState(UIModelIchis modelIchis)
	{
	}

	private static uint SafeDelta(uint requested, uint actual)
	{
		return 0u;
	}

	private static uint GetActualCouponConsumed(List<ExchangeItemNum> list, uint[] couponItemIds)
	{
		return 0u;
	}

	private static void SetActiveSafe(GameObject go, bool active)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetCloseAction(Action onClose)
	{
	}

	private void OnClickMask()
	{
	}

	private void InvokeOnCloseOnce()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
