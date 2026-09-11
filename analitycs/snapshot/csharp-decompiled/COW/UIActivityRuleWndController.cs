using GCommon;

namespace COW;

public class UIActivityRuleWndController : UIPopupWindowController
{
	private UIActivityRuleWndView m_View;

	private string m_RuleDescKey;

	private string m_CdnUrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public void SetData(string ruleDescKey, string cdnUrl)
	{
	}

	private void OnCloseBtnClicked()
	{
	}

	private void RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}
}
