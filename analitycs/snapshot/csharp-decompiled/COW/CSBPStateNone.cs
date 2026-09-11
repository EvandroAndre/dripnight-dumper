namespace COW;

public class CSBPStateNone : CSBPStateBase
{
	public override ECSBPPhase PhaseType => ECSBPPhase.None;

	public CSBPStateNone(CSBPStateMachine stateMachine, CSBPContext context)
		: base(null, null)
	{
	}
}
