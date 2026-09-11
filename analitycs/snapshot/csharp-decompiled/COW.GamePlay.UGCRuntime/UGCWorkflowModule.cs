using System.Collections.Generic;

namespace COW.GamePlay.UGCRuntime;

public class UGCWorkflowModule : IUGCWorkflowModule, IUGCModule
{
	private UGCRuntime m_UGCRuntime;

	private UGCMatchWorkflowState m_State;

	private UGCWorkflowFSM m_WorkflowFSM;

	public UGCWorkflowModule Create(UGCRuntime ugcRuntime)
	{
		return null;
	}

	public void Init(object[] args)
	{
	}

	public void LoadParameters(Dictionary<object, object> parameters)
	{
	}

	public void Destroy()
	{
	}

	public void SetWorkflowFSM(UGCWorkflowFSM fsm)
	{
	}

	public void StartMatch(int curTimeMs)
	{
	}

	public void EndMatch(int curTimeMs)
	{
	}

	public void OnTickEventHandle()
	{
	}

	public void OnPostTickEventHandle()
	{
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

	public IUGCPhase FindPhaseEntity(string entityID)
	{
		return null;
	}

	public int GetCurrPhaseIndex()
	{
		return 0;
	}

	public void EndCurrentPhase()
	{
	}

	public void SetNextPhase(int phaseIndex)
	{
	}

	public bool IsWorkflowEnd()
	{
		return false;
	}
}
