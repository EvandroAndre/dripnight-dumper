using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class PlayerAnimEventState : StateMachineBehaviour
{
	public float triggerTime;

	public INAHABPJKFG animEvent;

	public bool localPlayerOnly;

	private Player m_OwnerPlayer;

	private float m_PrevTime;

	private int m_Currentloop;

	private uint uniqueIndex;

	private AnimationID id;

	public override void OnStateEnter(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateUpdate(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateExit(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
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
