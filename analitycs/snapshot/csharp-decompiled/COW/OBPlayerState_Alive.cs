using UnityEngine;

namespace COW;

internal class OBPlayerState_Alive : OBPlayerState_Base
{
	public Transform ArrowContainer;

	public UILabel IndexLabel;

	public override EOBPlayerStateType StateType => EOBPlayerStateType.eNone;

	public OBPlayerState_Alive(Transform arrowContainer, UILabel indexLabel)
	{
	}

	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	public override bool ExitState(EOBPlayerStateType next_state_type)
	{
		return false;
	}

	public override void IsShowTeamIcon(bool show)
	{
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

	public void _003C_003EiFixBaseProxy_IsShowTeamIcon(bool P0)
	{
	}
}
