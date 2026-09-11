using GCommon;

namespace COW;

public class UIDMAInquiryWndOptionController : UIPopupWindowController
{
	private UIDMAInquiryWndOptionView m_View;

	private UIDMAInquiryWndController m_Parent;

	private bool m_OptionAnalytics;

	private bool m_OptionAdvertisement;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(UIDMAInquiryWndController parent, DMAPolicyLinkData policyLinkData)
	{
	}

	private void RefreshView()
	{
	}

	private void OptionAnalyticsBtnClick()
	{
	}

	private void OptionAdvertisementBtnClick()
	{
	}

	private void OnConfirmBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
