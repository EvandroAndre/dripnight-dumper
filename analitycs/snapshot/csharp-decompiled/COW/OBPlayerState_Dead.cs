namespace COW;

internal class OBPlayerState_Dead : OBPlayerState_Base
{
	public UISprite DeadIcon;

	public UIWidget TeamIconGo;

	public override EOBPlayerStateType StateType => EOBPlayerStateType.eNone;

	public OBPlayerState_Dead(UISprite deadIcon, UIWidget teamIconGo)
	{
	}

	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	public override bool ExitState(EOBPlayerStateType next_state)
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
