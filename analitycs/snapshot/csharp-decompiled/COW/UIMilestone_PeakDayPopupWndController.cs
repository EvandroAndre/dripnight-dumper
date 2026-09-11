using GCommon;

namespace COW;

public class UIMilestone_PeakDayPopupWndController : UIBigEvent_Template_PeakDayPopupWndBaseController
{
	private UIMilestone_PeakDayPopupWndView m_View;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

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

	protected override void RefreshView()
	{
	}

	private void RefreshCloseBtnShowState()
	{
	}

	private void RefreshClaimBtnShowState(UIModelBigEvent.EPeakDayState state)
	{
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
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

	public void _003C_003EiFixBaseProxy_RefreshView()
	{
	}
}
