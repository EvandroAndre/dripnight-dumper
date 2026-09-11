using System;
using GCommon;
using proto;

namespace COW;

public class UIRelayMartDiscountCodeGeneratePopupWindowController : UIPopupWindowController
{
	private UIRelayMartDiscountCodeGeneratePopupWindowView m_View;

	private UIModelRelayMart m_ModelRelayMart;

	private RelayMartDiscountCodeInfo m_ItemData;

	private UIStandardItemMiniController m_ItemCtrl;

	private Action m_CloseAction;

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

	protected override void OnUIDestroy()
	{
	}

	public override void OnPopupWindowListChange()
	{
	}

	public void SetUIData()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnShareFriendBtnClick()
	{
	}

	private void OnSharePublicBtnClick()
	{
	}

	private void OnCopyBtnClick()
	{
	}

	private void RefreshBGCDN()
	{
	}

	private void RequestSharePublicDiscountCode(bool isShared)
	{
	}

	public void SetCloseAction(Action closeAction)
	{
	}

	private void _003COnUIInit_003Eb__6_0(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
