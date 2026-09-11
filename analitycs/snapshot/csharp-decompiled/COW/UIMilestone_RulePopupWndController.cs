using GCommon;

namespace COW;

public class UIMilestone_RulePopupWndController : UIBigEvent_Template_RulePopupWndBaseController
{
	private UIMilestone_RulePopupWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnSetNavigationController()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}
}
