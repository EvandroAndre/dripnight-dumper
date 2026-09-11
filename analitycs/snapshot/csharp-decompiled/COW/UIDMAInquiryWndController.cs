using System;
using GCommon;

namespace COW;

public class UIDMAInquiryWndController : UIPopupWindowController
{
	public class WndInfo
	{
		public Action<bool, bool> m_Allow;

		public Action m_Reject;

		public bool m_IsOpenFromSetting;
	}

	private UIDMAInquiryWndView m_View;

	public bool OptionAnalytics;

	public bool OptionAdvertisement;

	private WndInfo m_Config;

	private UIModelLogin m_ModelLogin;

	private DMAPolicyLinkData m_DMAPolicyLinkData;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRejectBtnClick()
	{
	}

	public void OnAllowBtnClick()
	{
	}

	public void OnConfirmBtnClick()
	{
	}

	private void OnMoreOptionBtnClick()
	{
	}

	public void SetData(WndInfo config)
	{
	}

	private void RefreshView()
	{
	}

	public void ChangeOption(bool optionAnalytics, bool optionAdvertisement)
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
