using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEvent_PersonalProgress_MissionPopupWndController : UIBigEvent_Template_MissionPopupWndBaseController
{
	private UIBigEvent_PersonalProgress_MissionPopupWndView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
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

	public new void _003C_003EiFixBaseProxy_OnUIInit()
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
