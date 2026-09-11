using GCommon;

namespace COW;

internal class UIHudGamePhaseCountdownTimeController : UIBaseController
{
	private UIHudGamePhaseCountdownHintView m_View;

	private UITimeLabelHelper m_TimeHelper;

	private GamePhaseCountdownData m_ViewData;

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

	private void OnPhaseChange(object[] data)
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
