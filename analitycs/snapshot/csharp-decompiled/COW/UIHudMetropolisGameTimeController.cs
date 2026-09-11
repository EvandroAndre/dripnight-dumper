using GCommon;

namespace COW;

public class UIHudMetropolisGameTimeController : UIBaseController
{
	private UIHudMetropolisGameTimeView m_View;

	private float m_KeepTime;

	private float m_TotalTime;

	private bool m_IsNight;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnWeatherChange(object[] data)
	{
	}

	public void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
