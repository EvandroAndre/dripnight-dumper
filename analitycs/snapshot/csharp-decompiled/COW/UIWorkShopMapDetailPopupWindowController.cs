using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIWorkShopMapDetailPopupWindowController : UIPopupWindowController
{
	private UIWorkShopMapDetailPopupWindowView m_View;

	private int m_CurItemIdx;

	private List<UISprite> m_LightDot;

	private List<UIWorkshopMapItemController> m_WorkShopMapItems;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(SceneEditSlotInfo info, string cdnUrl, string defaultUrl, Action itemClickCallBack = null)
	{
	}

	private void OnCenterChild(GameObject centerGo)
	{
	}

	private void OnLeftBtn()
	{
	}

	private void OnRightBtn()
	{
	}

	private void RefreshDot()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
