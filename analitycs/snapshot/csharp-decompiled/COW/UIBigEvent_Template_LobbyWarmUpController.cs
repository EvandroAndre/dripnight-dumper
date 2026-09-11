using GCommon;

namespace COW;

public class UIBigEvent_Template_LobbyWarmUpController : UIPopupWindowController
{
	private UIBigEvent_Template_LobbyWarmUpView m_View;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private EBigEventTemplateUseType m_TemplateUseType;

	protected CountDownConfig m_Config;

	private ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetTemplateUseType(EBigEventTemplateUseType useType)
	{
	}

	protected void InitUI()
	{
	}

	protected virtual void OnTimeout()
	{
	}

	protected virtual void SetCountDown()
	{
	}

	protected virtual void OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
