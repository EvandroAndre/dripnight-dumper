using GCommon;

namespace COW;

public class UIHudGrenadeAndCancleParentController : UIBaseController
{
	private UIHudGrenadeAndCancleParentView m_View;

	private UIHudTriggerGrenadeController m_TriggerGrenadeCtrl;

	private bool m_UGCVisible;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public UIHudTriggerGrenadeController OpenGrenadeUI()
	{
		return null;
	}

	public UIHudGrenadeCancelController OpenCancelUI()
	{
		return null;
	}

	public override void SetUGCVisibility(bool v)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetUGCVisibility(bool P0)
	{
	}
}
