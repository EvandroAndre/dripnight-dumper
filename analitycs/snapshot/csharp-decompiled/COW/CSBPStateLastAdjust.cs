namespace COW;

public class CSBPStateLastAdjust : CSBPStateBase
{
	public override ECSBPPhase PhaseType => ECSBPPhase.None;

	public CSBPStateLastAdjust(CSBPStateMachine stateMachine, CSBPContext context)
		: base(null, null)
	{
	}

	public override void OnEnter()
	{
	}

	public override bool NeedShowPhaseChangeUI()
	{
		return false;
	}

	public override string GetPhaseNameLabel()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnEnter()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedShowPhaseChangeUI()
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_GetPhaseNameLabel()
	{
		return null;
	}
}
