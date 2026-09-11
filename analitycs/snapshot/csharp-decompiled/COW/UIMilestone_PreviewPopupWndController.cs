using GCommon;

namespace COW;

public class UIMilestone_PreviewPopupWndController : UIBigEvent_Template_PreviewPopupWndController
{
	private UIMilestone_PreviewPopupWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}
}
