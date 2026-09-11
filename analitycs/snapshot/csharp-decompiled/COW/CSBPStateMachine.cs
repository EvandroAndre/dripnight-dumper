using System.Collections.Generic;

namespace COW;

public class CSBPStateMachine
{
	private Dictionary<ECSBPPhase, CSBPStateBase> m_States;

	private CSBPStateBase m_CurrentState;

	private CSBPContext m_Context;

	public ECSBPPhase CurrentPhase => ECSBPPhase.None;

	public CSBPStateMachine(CSBPContext context)
	{
	}

	private void InitStates()
	{
	}

	private void AddState(CSBPStateBase state)
	{
	}

	public void TransitionTo(ECSBPPhase newPhase, ulong phaseEndServerTime)
	{
	}

	public void Update(float deltaTime)
	{
	}

	public void Reset()
	{
	}

	public bool CanPerformAction()
	{
		return false;
	}

	public bool NeedShowPhaseChangeUI()
	{
		return false;
	}

	public string GetPhaseNameLabel()
	{
		return null;
	}

	public bool NeedShowMiddleSkillList()
	{
		return false;
	}
}
