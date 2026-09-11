using System.Text;
using GCommon;

namespace COW;

public class UIHUDPVEGameCountdownController : UIBaseController
{
	private UIHUDPVEGameCountdownView m_View;

	private uint m_GameEndTimeMS;

	private bool m_IsEndTimeCome;

	private uint mSeconds;

	private StringBuilder m_Timer;

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

	private void OnEndTimeCome(object[] data)
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
