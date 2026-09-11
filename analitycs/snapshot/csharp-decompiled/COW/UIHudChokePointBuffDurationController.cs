using GCommon;

namespace COW;

internal class UIHudChokePointBuffDurationController : UIBaseController
{
	private UIHudChokePointBuffDurationView m_View;

	private float m_BuffDurationTime;

	private float m_BuffEndTime;

	private float m_Duration;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetDurationEndTime(float lifeTime, float duration)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
