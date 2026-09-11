using System;
using UnityEngine;

namespace GCommon;

public class AudioResource : ObjectPoolCallbackBase
{
	public ResourceID AudioID;

	public AudioSource Audio;

	public bool IsNeedUnloadAudioData;

	public float TargetVolume;

	public AudioClip AudioClip => null;

	public string ClipName => null;

	public float Duration => 0f;

	private void Collect()
	{
	}

	public override void OnCollected()
	{
	}

	private void UnloadAudioData()
	{
	}

	public void Play(float fadeTime = 0f, Action onFadeEnd = null)
	{
	}

	public void Stop(float fadeTime = 0f, Action onFadeEnd = null)
	{
	}

	public void Pause(float fadeTime = 0f, Action onPaused = null)
	{
	}

	public void Resume(float fadeTime = 0f)
	{
	}

	public void SetVolume(float volume, float fadeTime)
	{
	}

	public void Seek(int sampleIndex)
	{
	}
}
