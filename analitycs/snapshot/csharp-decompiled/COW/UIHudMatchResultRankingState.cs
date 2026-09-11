namespace COW;

public class UIHudMatchResultRankingState : UIHudMatchResultStateBase
{
	public UIHudMatchResultRankingState(UIHudMatchResultStateMachine machine)
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
}
