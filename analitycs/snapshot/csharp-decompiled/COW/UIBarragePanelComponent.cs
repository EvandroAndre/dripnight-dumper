using System.Collections.Generic;

namespace COW;

public class UIBarragePanelComponent
{
	private List<BarrageLauncherRandomDelayCall> m_RandomCalls;

	private HashSet<int> m_BarrageTypes;

	private List<UIBarrageLauncher> m_UIBarrageLaunchers;

	private UIModelBarrage m_ModelBarrage;

	private bool m_IsInit;

	public void Init(HashSet<int> barrageTypes, List<UIBarrageLauncher> barrageLaunchers, GetBarrageDataFunc getBarrageDataFunc)
	{
	}

	public void Init(HashSet<int> barrageTypes, List<UIBarrageLauncher> barrageLaunchers, GetBarrageDataFunc getBarrageDataFunc, bool eventDriven)
	{
	}

	public void Start()
	{
	}

	public void Stop()
	{
	}

	public void StopWithoutHide()
	{
	}

	public void Wake()
	{
	}
}
