using UnityEngine;

namespace COW;

internal class OBCSPlayerState_Alive : OBPlayerState_Alive
{
	public UISprite PlayerSkillIcon;

	public OBCSPlayerState_Alive(Transform arrowContainer, UILabel indexLabel, UISprite playerSkillIcon)
		: base(null, null)
	{
	}

	public override void EnterState(EOBPlayerStateType next_state_type)
	{
	}

	public override void IsShowTeamIcon(bool show)
	{
	}

	public new void _003C_003EiFixBaseProxy_EnterState(EOBPlayerStateType P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_IsShowTeamIcon(bool P0)
	{
	}
}
