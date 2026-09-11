using UnityEngine;

namespace COW;

public class UIHDStandAnimState : StateMachineBehaviour
{
	public enum EHDStandAnimEvent
	{
		GunDoorMove,
		GunDoorOpend,
		MoveToGunDoor,
		MoveFromGunDoor,
		MoveToCarPlat,
		MoveFromCarPlat,
		MoveToIcePlat,
		MoveFromIcePlat,
		MoveToSkyboardPlat,
		MoveFromSkyboardPlat
	}

	public EHDStandAnimEvent animEvent;

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateEnter(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStateExit(Animator P0, AnimatorStateInfo P1, int P2)
	{
	}
}
