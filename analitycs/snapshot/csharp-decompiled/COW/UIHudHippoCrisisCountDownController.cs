using System.Text;
using GCommon;

namespace COW;

public class UIHudHippoCrisisCountDownController : UIBaseController
{
	private UIHudHippoCrisisCountDownView m_View;

	private uint m_EndTime;

	private int mSeconds;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetEndTime(uint endTime)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
