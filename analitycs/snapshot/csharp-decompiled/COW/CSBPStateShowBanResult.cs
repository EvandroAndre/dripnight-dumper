namespace COW;

public class CSBPStateShowBanResult : CSBPStateBase
{
	public override ECSBPPhase PhaseType => ECSBPPhase.None;

	public CSBPStateShowBanResult(CSBPStateMachine stateMachine, CSBPContext context)
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

	public override bool NeedShowMiddleSkillList()
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

	public bool _003C_003EiFixBaseProxy_NeedShowMiddleSkillList()
	{
		return false;
	}
}
