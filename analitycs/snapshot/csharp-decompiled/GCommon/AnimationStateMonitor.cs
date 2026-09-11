using UnityEngine;

namespace GCommon;

public class AnimationStateMonitor : StateMachineBehaviour
{
	public string AnimIDString;

	public float EndCutTime;

	public bool AutoTransitionToDefaultState;

	protected AnimationID m_AnimID;

	protected AnimationSystemComponent m_AnimSystem;

	protected float m_LastTime;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}
}
