namespace COW;

internal class OBPlayerState_Base
{
	public bool m_IsShowTeamIcon;

	public virtual EOBPlayerStateType StateType => EOBPlayerStateType.eNone;

	public virtual void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	public virtual bool ExitState(EOBPlayerStateType next_state_type)
	{
		return false;
	}

	public virtual void IsShowTeamIcon(bool show)
	{
	}
}
