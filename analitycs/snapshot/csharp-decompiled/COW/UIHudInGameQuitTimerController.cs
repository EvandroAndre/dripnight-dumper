using System.Text;
using GCommon;

namespace COW;

public class UIHudInGameQuitTimerController : UIBaseController
{
	private UIHudInGameQuitTimerView m_View;

	private float m_GameEndTimeMS;

	private bool m_IsEndTimeCome;

	private uint mSeconds;

	private StringBuilder m_Timer;

	private bool m_RoomClose;

	private float m_RoomCloseEndTimeMs;

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

	public void StopCountDown()
	{
	}

	public void OnEndTimeCome(uint value, bool isQuit)
	{
	}

	private bool ShouldSkipAfkTip()
	{
		return false;
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
