using System.Collections.Generic;
using message;

namespace COW.GamePlay.UGCRuntime;

public class UGCWorkflowFSM : IOnRoundStartEventHandler, IOnRoundEndEventHandler, IOnPhaseStartEventHandler, IOnPhaseEndEventHandler
{
	private UGCRuntime m_UGCRuntime;

	private Dictionary<int, IUGCPhase> m_PhaseMap;

	private IUGCPhase m_CurPhase;

	private int m_FirstPhaseIndex;

	private bool m_IsStarted;

	private int m_NextPhaseFlag;

	private int m_EndPhaseFlag;

	private int m_TryNextPhaseCmdFlag;

	private List<IOnRoundStartEventHandler> m_OnRoundStartEventHandlers;

	private List<IOnRoundEndEventHandler> m_OnRoundEndEventHandlers;

	private List<IOnPhaseStartEventHandler> m_OnPhaseStartEventHandlers;

	private List<IOnPhaseEndEventHandler> m_OnPhaseEndEventHandlers;

	public UGCWorkflowFSM Create(UGCRuntime ugcRuntime, OHCGHBFNOFA workflowData, OHCGHBFNOFA overrideWorkflowData)
	{
		return null;
	}

	public void Run(int curTimeMs)
	{
	}

	public void Stop(int curTimeMs)
	{
	}

	public void OnTick(int curTimeMs)
	{
	}

	public void OnPostTick(int curTimeMs)
	{
	}

	private void SwitchPhase(int curTimeMs)
	{
	}

	private void SetNextPhaseInternal(int phaseIndex)
	{
	}

	public void TrySetNextPhase(int phaseIndex)
	{
	}

	public IUGCPhase GetCurPhase()
	{
		return null;
	}

	public bool IsStopped()
	{
		return false;
	}

	public IUGCPhase FindPhaseEntity(string entityID)
	{
		return null;
	}

	public void AddRoundStartEventHandler(IOnRoundStartEventHandler handler)
	{
	}

	public void AddRoundEndEventHandler(IOnRoundEndEventHandler handler)
	{
	}

	public void AddPhaseStartEventHandler(IOnPhaseStartEventHandler handler)
	{
	}

	public void AddPhaseEndEventHandler(IOnPhaseEndEventHandler handler)
	{
	}

	public void EndCurrentPhase()
	{
	}

	private void AddPhase(IUGCPhase phase)
	{
	}

	private void SetFirstPhase(int phaseIndex)
	{
	}

	private NCDHEONIPEN GetNextWorkflowSequenceItem(OHCGHBFNOFA workflowData, int curSeqIndex)
	{
		return null;
	}

	private int GetPhaseIndexByWorkflowSequenceItem(OHCGHBFNOFA workflowData, NCDHEONIPEN seqItem)
	{
		return 0;
	}

	public void OnRoundStartEventHandle(IUGCPhase phase, int curTimeMs)
	{
	}

	public void OnRoundEndEventHandle(IUGCPhase phase, int curTimeMs)
	{
	}

	public void OnPhaseStartEventHandle(IUGCPhase phase)
	{
	}

	public void OnPhaseEndEventHandle(IUGCPhase phase)
	{
	}
}
