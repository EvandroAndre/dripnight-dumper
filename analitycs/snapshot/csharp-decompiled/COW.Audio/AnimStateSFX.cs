using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW.Audio;

public class AnimStateSFX : StateMachineBehaviour
{
	public string enterSoundID;

	public string exitSoundID;

	public string staySoundID;

	public string audioSourceID;

	public bool asyncPlay;

	public bool stopStaySoundOnExit;

	public EAudioEngineType engineType;

	public int audioMixerGroup;

	private AudioPlaybackParams m_PlaybackParams;

	private ResourceID m_EnterSound;

	private ResourceID m_ExitSound;

	private ResourceID m_StaySound;

	private uint m_StaySoundPlayingID;

	private int m_LastLoopIndex;

	private void Awake()
	{
	}

	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
	}

	public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
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
