using System;
using System.Collections.Generic;
using GCommon;

namespace COW.Audio;

public class MusicManager
{
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public MusicManager _003C_003E4__this;

		public AudioResource stinger;

		public float fadeTime;

		internal void _003CPlayHorizontalStinger_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public MusicManager _003C_003E4__this;

		public float fadeTime;

		internal void _003CInterruptHorizontalStinger_003Eb__0()
		{
		}
	}

	private MusicTransport _003CCurrentMusic_003Ek__BackingField;

	private MusicTransport _003CNextMusic_003Ek__BackingField;

	private MusicTransport m_Stinger;

	private readonly Dictionary<ResourceID, int> m_StoppedTimeDict;

	private PlaybackStatus _003CPlaybackStatus_003Ek__BackingField;

	public Action TransitionInitCallback;

	public Action TransitionFinishCallback;

	public Action PlayCallback;

	public Action StopCallback;

	private MusicTransitionData _003CTransitionData_003Ek__BackingField;

	private AudioResource m_CachedMusicInQueue;

	public MusicTransport CurrentMusic
	{
		get
		{
			return _003CCurrentMusic_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentMusic_003Ek__BackingField = value;
		}
	}

	public MusicTransport NextMusic
	{
		get
		{
			return _003CNextMusic_003Ek__BackingField;
		}
		private set
		{
			_003CNextMusic_003Ek__BackingField = value;
		}
	}

	public PlaybackStatus PlaybackStatus
	{
		get
		{
			return _003CPlaybackStatus_003Ek__BackingField;
		}
		private set
		{
			_003CPlaybackStatus_003Ek__BackingField = value;
		}
	}

	public bool IsPlaying => false;

	private RhythmSection RhythmSection => RhythmSection.Intro;

	public ResourceID PlayingMusicID => default(ResourceID);

	public ResourceID NextMusicID => default(ResourceID);

	public ResourceID StingerID => default(ResourceID);

	public float PlayHeadTime => 0f;

	public MusicTransitionData TransitionData
	{
		get
		{
			return _003CTransitionData_003Ek__BackingField;
		}
		private set
		{
			_003CTransitionData_003Ek__BackingField = value;
		}
	}

	public bool PlayMusic(AudioResource newMusic, uint transitionRuleID = 0u)
	{
		return false;
	}

	public void PlayHorizontalStinger(AudioResource stinger, bool crossFade = true, float fadeTime = 0.2f)
	{
	}

	public bool InterruptHorizontalStinger(bool crossFade = true, float fadeTime = 0.2f)
	{
		return false;
	}

	public bool IsMusicPlaying(ResourceID musicID)
	{
		return false;
	}

	private void ClearStinger()
	{
	}

	public void Play(float fadeTime = 0f)
	{
	}

	public void Pause(float fadeTime = 0f, Action onPaused = null)
	{
	}

	public void Resume(float fadeTime = 0f)
	{
	}

	public void Stop(float fadeTime = 1f)
	{
	}

	public void Seek(int sampleIndex)
	{
	}

	public void SetVolume(float volume, float fadeTime = 0f)
	{
	}

	private MusicTransport CreateTransportData(AudioResource musicRes)
	{
		return null;
	}

	private void ResetToIdle()
	{
	}

	public void RunOneFrame()
	{
	}

	private void PlayCachedMusic()
	{
	}

	private void InitTransition(uint transitionRuleID)
	{
	}

	private MusicTransitionRule FindMatchingTransitionRule(uint transitionRuleID)
	{
		return null;
	}

	private int GetTransitionBaseSamples()
	{
		return 0;
	}

	private void CheckTransitionStatus()
	{
	}

	private void OnTransitionExit()
	{
	}

	private void OnTransitionEnter()
	{
	}

	private void OnTransitionFinished()
	{
	}

	private void SeekEnterPosition()
	{
	}

	private void _003COnTransitionExit_003Eb__54_0()
	{
	}

	private void _003COnTransitionEnter_003Eb__55_0()
	{
	}
}
