namespace COW;

public class UIHudMatchResultStateBase
{
	private EUIHudMatchResultState m_State;

	private UIHudMatchResultStateMachine m_StateMachine;

	private bool m_IsInit;

	public EUIHudMatchResultState State => EUIHudMatchResultState.None;

	public UIHudMatchResultStateMachine StateMachine => null;

	public UIHudMatchResultStateBase(UIHudMatchResultStateMachine machine, EUIHudMatchResultState state)
	{
	}

	public void Enter()
	{
	}

	public void Exit()
	{
	}

	public void Finish()
	{
	}

	protected virtual void OnInit()
	{
	}

	protected virtual bool OnCheck()
	{
		return false;
	}

	protected virtual bool OnEnter()
	{
		return false;
	}

	protected virtual void OnFinish()
	{
	}

	protected virtual void OnExit()
	{
	}
}
