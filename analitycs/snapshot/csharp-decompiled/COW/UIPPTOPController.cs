using GCommon;

namespace COW;

public class UIPPTOPController : UIPopupWindowController
{
	private UIPPTOPView m_View;

	private string m_PrivacyURL;

	private string m_ServiceURL;

	private bool m_IsAgreed;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(bool privacyShow, bool serviceShow, string privacyURL, string serviceURL)
	{
	}

	private void OnBtnPrivacyClick()
	{
	}

	private void OnBtnServiceClick()
	{
	}

	private void OnBtnAgreeClick()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
