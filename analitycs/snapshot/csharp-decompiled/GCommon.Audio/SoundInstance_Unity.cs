using UnityEngine;
using UnityEngine.Audio;

namespace GCommon.Audio;

public class SoundInstance_Unity : SoundInstance
{
	public ResourceID AudioSourceID;

	public AudioSource AudioSource;

	public AudioMixerGroup VirtualVoiceCachedBus;

	private bool m_PlayStarted;

	private float m_FadeOutStartTime;

	private float m_FadeOutDuration;

	private float m_VolumeBeforeFadeOut;

	public override GameObject Emitter => null;

	public override bool IsPlaying => false;

	public bool IsLooping => false;

	public bool IsFadingOut => false;

	public void UpdateVolume(float newVolume)
	{
	}

	public void UpdatePitch(float newPitch)
	{
	}

	internal void UpdateFade()
	{
	}

	public override void SeekByTime(float time)
	{
	}

	public override void SeekByPercent(float percent)
	{
	}

	public override void Pause(bool paused)
	{
	}

	public override void Break()
	{
	}

	public override void Stop(float fadeOutTime = 0f)
	{
	}

	private void StopAudioSource()
	{
	}

	private void UnloadAudioData(AudioClip clip)
	{
	}

	public override void OnEndedOrStopped()
	{
	}

	public override void Reset()
	{
	}
}
