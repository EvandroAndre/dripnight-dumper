using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCPhase : UGCBasePhase
{
	private int m_StartTimeMs;

	private int m_DurationMs;

	private int m_TimeoutPhaseIndex;

	private List<IOnPhaseStartEventHandler> m_OnStartPhaseHandlers;

	private List<IOnPhaseEndEventHandler> m_OnEndPhaseHandlers;

	private List<IOnTimeoutEventHandler> m_OnTimeoutHandlers;

	public UGCPhase Create(UGCRuntime runtime, int index, int timeoutPhaseIndex)
	{
		return null;
	}

	public override void OnStartPhase(int curTimeMs)
	{
	}

	public override void OnEndPhase(int curTimeMs)
	{
	}

	public override void OnTick(int curTimeMs, out int switchPhaseIndex, out bool isKeepRun)
	{
		switchPhaseIndex = default(int);
		isKeepRun = default(bool);
	}

	public override int GetNextPhaseIndex()
	{
		return 0;
	}

	public override IUGCValue BridgingPropGetter(long bridgingProp)
	{
		return null;
	}

	public void SetDurationMs(int durationMs)
	{
	}

	public void AddPhaseStartHandler(IOnPhaseStartEventHandler handler)
	{
	}

	public void AddPhaseEndHandler(IOnPhaseEndEventHandler handler)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartPhase(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnEndPhase(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTick(int P0, out int P1, out bool P2)
	{
		P1 = default(int);
		P2 = default(bool);
	}

	public int _003C_003EiFixBaseProxy_GetNextPhaseIndex()
	{
		return 0;
	}

	public IUGCValue _003C_003EiFixBaseProxy_BridgingPropGetter(long P0)
	{
		return null;
	}
}
