using proto;

namespace COW;

public class UIHudMatchResultClanState : UIHudMatchResultStateBase
{
	private FakeSubmitRes m_ClanMatchResult;

	public UIHudMatchResultClanState(UIHudMatchResultStateMachine machine)
		: base(null, EUIHudMatchResultState.None)
	{
	}

	protected override void OnInit()
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

	public void _003C_003EiFixBaseProxy_OnInit()
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
