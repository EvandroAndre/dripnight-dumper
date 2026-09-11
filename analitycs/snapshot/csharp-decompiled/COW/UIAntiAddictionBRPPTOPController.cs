using GCommon;

namespace COW;

public class UIAntiAddictionBRPPTOPController : UIPopupWindowController
{
	private UIAntiAddictionBRPPTOPView m_View;

	private string m_PrivacyURL;

	private string m_ServiceURL;

	private bool m_IsAgreed;

	public const string PREFS_KEY_AGREE_PP = "BR_AgreePrivacyPolicy";

	public const string PREFS_KEY_AGREE_TOS = "BR_AgreeTermsOfService";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitBRMode()
	{
	}

	private void LoadToggleStates()
	{
	}

	private void SaveToggleStates()
	{
	}

	private void OnToggleChanged()
	{
	}

	private void RefreshBRButtonState()
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

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
