using GCommon;

namespace COW;

internal class UIHudSimpleCountdownController : UIBaseController
{
	private UITimeLabelHelper m_TimeHelper;

	private UIHudSimpleCountdownView m_View;

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

	private void OnPhaseTimeChange(object[] data)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
