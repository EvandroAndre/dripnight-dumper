using System.Text;
using GCommon;

namespace COW;

public class UIHudWeRunRetreatRetreatCountdownController : UIBaseController
{
	private UIHudWeRunRetreatCountdownView m_View;

	private float m_EndTime;

	private float m_Duration;

	private StringBuilder m_Timer;

	private float mSeconds;

	private float mDuration;

	private uint sec;

	private float m_LastPlayCountDownTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnLocalPawnGameEnd()
	{
	}

	public void UpdateCountDown(uint endTimeMS)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
