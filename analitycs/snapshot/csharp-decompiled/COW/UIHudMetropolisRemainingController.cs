using GCommon;

namespace COW;

public class UIHudMetropolisRemainingController : UIBaseController
{
	private UIHudMetropolisRemainingView m_View;

	private UIModelMetropolis m_ModelMetropolis;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnFactionCountUpdate(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
