using System;
using System.Collections.Generic;

namespace GCommon.Audio;

public class FFAudioEngine_Unity
{
	private AudioResourceManager_Unity m_ResManager;

	private float m_SoundVolume;

	private Dictionary<int, AudioResource> m_RunningAudioResource;

	private const int ForcePositive = int.MaxValue;

	private bool m_IsSoundMuted;

	public AudioResourceManager_Unity ResManager => null;

	public void StopSoundEffect(int ticket)
	{
	}

	public void PlaySoundEffect(ResourceID resourceID, int audioMixerGroup = 5)
	{
	}

	public int PlaySoundEffectTicket(ResourceID resourceID, int audioMixerGroup = 5)
	{
		return 0;
	}

	public void PlayUserVoice()
	{
	}

	public int PlayCharacterVoice(ResourceID resourceID, Action endCallback = null, bool isQuickMsg = true)
	{
		return 0;
	}

	public bool StopCharacterVoice(int ticket)
	{
		return false;
	}

	public bool IsCharacterVoicePlaying(int ticket)
	{
		return false;
	}

	public int Start2DLoop(ResourceID resourceID)
	{
		return 0;
	}

	public bool End2DLoop(int ticket)
	{
		return false;
	}

	public void SetSoundVolume(float vol)
	{
	}

	public void SetSoundOn(bool isOn)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}
}
