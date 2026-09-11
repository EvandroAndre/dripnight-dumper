using UnityEngine;

namespace COW;

public class SparkPetAnimStateEvent : StateMachineBehaviour
{
	public string stateName;

	public bool triggerOnEnter;

	public bool triggerOnExit;

	private UISparkPetAvatar m_CachedSparkPet;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	private UISparkPetAvatar GetSparkPetAvatar(Animator animator)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
