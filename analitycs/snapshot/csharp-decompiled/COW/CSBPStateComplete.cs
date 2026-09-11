namespace COW;

public class CSBPStateComplete : CSBPStateBase
{
	public override ECSBPPhase PhaseType => ECSBPPhase.None;

	public CSBPStateComplete(CSBPStateMachine stateMachine, CSBPContext context)
		: base(null, null)
	{
	}

	public override void OnEnter()
	{
	}

	public override bool CanPerformAction()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnEnter()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanPerformAction()
	{
		return false;
	}
}
