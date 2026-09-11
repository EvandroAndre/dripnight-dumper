using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCRoundPhase : UGCBasePhase
{
	private int m_NormalPhaseIndex;

	private int m_OverflowPhaseIndex;

	private int m_RoundNumMax;

	private int m_CurRoundCount;

	private bool m_ForceDelete;

	private List<IOnRoundStartEventHandler> m_OnRoundStartHandlers;

	private List<IOnRoundEndEventHandler> m_OnRoundEndHandlers;

	public UGCRoundPhase Create(UGCRuntime ugcRuntime, int index, int roundMax, int normalPhase, int overflowPhase)
	{
		return null;
	}

	public override void OnStartPhase(int curTimeMs)
	{
	}

	public override void OnTick(int curTimeMs, out int switchPhaseIndex, out bool isKeepRun)
	{
		switchPhaseIndex = default(int);
		isKeepRun = default(bool);
	}

	public override void OnEndPhase(int curTimeMs)
	{
	}

	public override int GetNextPhaseIndex()
	{
		return 0;
	}

	public void AddRoundStartHandler(IOnRoundStartEventHandler handler)
	{
	}

	public void AddRoundEndHandler(IOnRoundEndEventHandler handler)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStartPhase(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnTick(int P0, out int P1, out bool P2)
	{
		P1 = default(int);
		P2 = default(bool);
	}

	public void _003C_003EiFixBaseProxy_OnEndPhase(int P0)
	{
	}

	public int _003C_003EiFixBaseProxy_GetNextPhaseIndex()
	{
		return 0;
	}
}
