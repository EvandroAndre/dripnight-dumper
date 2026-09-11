namespace COW;

public class UIHudMatchResultTransitionState : UIHudMatchResultStateBase
{
	public UIHudMatchResultTransitionState(UIHudMatchResultStateMachine machine)
		: base(null, EUIHudMatchResultState.None)
	{
	}

	protected override bool OnCheck()
	{
		return false;
	}

	protected override bool OnEnter()
	{
		return false;
	}

	protected override void OnFinish()
	{
	}

	protected override void OnExit()
	{
	}

	private void OnSwitchCamera()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnExit()
	{
	}
}
