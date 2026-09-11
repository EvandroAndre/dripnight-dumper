using UnityEngine;

namespace COW.GamePlay;

public class PlayerAnimEventStateLobby : StateMachineBehaviour
{
	public static int EmotionHash;

	public static int FreezeEmoteHash;

	public static int EmoteIdleHashFemale;

	public static int EmoteIdleHashMale;

	public float triggerTime;

	public BFNFCKGEHDI animEvent;

	public bool IsIgnoreEmotionExitEvent;

	private UIMaleAvatar m_OwnerPlayer;

	private float m_PrevTime;

	public override void OnStateEnter(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateUpdate(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	public override void OnStateExit(Animator LBFLOFBKDJG, AnimatorStateInfo ALKFJBNKHIC, int KEPNPINHFJP)
	{
	}

	private static bool JHOLKJBBMLL(Animator LBFLOFBKDJG, AnimatorStateInfo FJAOHJJDHJC, int KEPNPINHFJP)
	{
		return false;
	}

	private void OnDisable()
	{
	}

	public static bool FLKHLBKPAPJ(int GIAMEJNKGPN)
	{
		return false;
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
