namespace COW;

internal class OBPlayerState_KnockDown : OBPlayerState_Base
{
	public UISprite KnockDownIcon;

	public override EOBPlayerStateType StateType => EOBPlayerStateType.eNone;

	public OBPlayerState_KnockDown(UISprite knockDownIcon)
	{
	}

	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	public override bool ExitState(EOBPlayerStateType next_state_type)
	{
		return false;
	}

	public EOBPlayerStateType _003C_003EiFixBaseProxy_get_StateType()
	{
		return EOBPlayerStateType.eNone;
	}

	public void _003C_003EiFixBaseProxy_EnterState(EOBPlayerStateType P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_ExitState(EOBPlayerStateType P0)
	{
		return false;
	}
}
