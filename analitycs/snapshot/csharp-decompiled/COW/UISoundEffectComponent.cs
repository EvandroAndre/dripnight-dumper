using GCommon;
using UnityEngine;

namespace COW;

internal class UISoundEffectComponent : MonoBehaviour
{
	public string AnimationSound;

	public string SoundOnStart;

	public string SoundOnEnable;

	public string SoundOnClose;

	public EAudioMixerSnapshotType SnapshotOnOpen;

	public bool CustomSoundForEnable;

	public EUIAudioSubBusType CustomBusName;

	private bool m_IsNeedInit;

	private bool m_IsOnEnable;

	private bool m_IsOnEnableExcuted;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	private void HandOnEnable()
	{
	}

	public void PlayAnimationSound()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}
}
