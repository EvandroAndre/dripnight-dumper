namespace COW;

public class BarrageLauncherRandomDelayCall
{
	public delegate void BarrageLauncherFunction(UIBarrageLauncher launcher);

	private UIBarrageLauncher m_Launcher;

	private float m_TimeMin;

	private float m_TimeMax;

	private GetBarrageDataFunc m_GetBarrageDataFunc;

	private uint m_DelayCall;

	private uint m_rowId;

	private bool m_EventDriven;

	private bool m_IsSleeping;

	private bool m_IsRunning;

	public UIBarrageLauncher Launcher => null;

	public BarrageLauncherRandomDelayCall(UIBarrageLauncher launcher, GetBarrageDataFunc getBarrageDataFunc, uint rowId, bool eventDriven)
	{
	}

	public void Start()
	{
	}

	private void Send()
	{
	}

	public void Wake()
	{
	}

	private float GetFirstLauncherDelay()
	{
		return 0f;
	}

	public void StopWithoutHide()
	{
	}

	public void Stop()
	{
	}

	private void HideAllBarrage()
	{
	}
}
