using System.Text;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudBombCountDownTimeController : UIBaseController
{
	private UIHudBombCountDownTimeView m_View;

	private uint m_BombExplodeTime;

	private StringBuilder m_Timer;

	private uint min;

	private uint sec;

	private IIBMILKCJMH bombGame;

	private static string ZoneAStr;

	private static string ZoneBStr;

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

	private void OnBombSettingPhaseSync(object[] data)
	{
	}

	private void OnBombPlantTimeSync(object[] data)
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
