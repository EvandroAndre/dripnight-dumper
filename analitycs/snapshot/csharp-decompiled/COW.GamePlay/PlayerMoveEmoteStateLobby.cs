using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class PlayerMoveEmoteStateLobby : StateMachineBehaviour
{
	private UIMaleAvatar m_OwnerPlayer;

	private float m_PrevTime;

	private uint m_EmoteID;

	private bool m_IsMoveEmote;

	private float[] m_MoveEmoteFootStepTriggerTime;

	private ResourceID m_FootStepRes;

	private uint m_FootStepPlayingID;

	public override void OnStateEnter(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateUpdate(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateExit(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	private void OnDisable()
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateUpdate(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
