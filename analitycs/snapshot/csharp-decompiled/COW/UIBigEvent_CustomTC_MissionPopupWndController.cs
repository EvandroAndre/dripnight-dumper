using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_CustomTC_MissionPopupWndController : UIBigEvent_Template_MissionPopupWndBaseController
{
	private UIBigEvent_CustomTC_MissionPopupWndView m_View;

	protected override UICommonRewardWndController.WndStyleEnum WndStyle => UICommonRewardWndController.WndStyleEnum.COMMON;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	protected override UIBigEvent_Template_MissionItemBaseController GenerateMissionItemController(Transform parent)
	{
		return null;
	}

	public override EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public UICommonRewardWndController.WndStyleEnum _003C_003EiFixBaseProxy_get_WndStyle()
	{
		return UICommonRewardWndController.WndStyleEnum.COMMON;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnSetNavigationController()
	{
	}

	public UIBigEvent_Template_MissionItemBaseController _003C_003EiFixBaseProxy_GenerateMissionItemController(Transform P0)
	{
		return null;
	}

	public EBigEventTemplateType _003C_003EiFixBaseProxy_GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}
}
