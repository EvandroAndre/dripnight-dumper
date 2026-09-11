namespace COW;

public abstract class CSBPStateBase
{
	protected CSBPStateMachine m_StateMachine;

	protected CSBPContext m_Context;

	public abstract ECSBPPhase PhaseType { get; }

	public CSBPStateBase(CSBPStateMachine stateMachine, CSBPContext context)
	{
	}

	public virtual void OnEnter()
	{
	}

	public virtual void OnExit()
	{
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	public virtual bool CanPerformAction()
	{
		return false;
	}

	public virtual bool NeedShowPhaseChangeUI()
	{
		return false;
	}

	public virtual string GetPhaseNameLabel()
	{
		return null;
	}

	public virtual bool NeedShowMiddleSkillList()
	{
		return false;
	}
}
