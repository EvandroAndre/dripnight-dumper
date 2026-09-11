using System;
using GCommon;
using UnityEngine;

namespace COW.Audio;

public class MusicTransport
{
	public enum TransportStatus
	{
		Stopped,
		WaitingToPlay,
		Playing,
		Paused
	}

	public readonly MusicRhythmData RhythmData;

	private AudioResource _003CAudioRes_003Ek__BackingField;

	private int _003CBarNumber_003Ek__BackingField;

	private int _003CBeatNumber_003Ek__BackingField;

	private int _003CLastBeatSample_003Ek__BackingField;

	private int _003CLastBarSample_003Ek__BackingField;

	private int _003CLastPlayHeadSample_003Ek__BackingField;

	private RhythmSection _003CRhythmSection_003Ek__BackingField;

	private TransportStatus _003CStatus_003Ek__BackingField;

	private int _003CBeatDurationSamples_003Ek__BackingField;

	private int _003CBarDurationSamples_003Ek__BackingField;

	private int _003CIntroDurationSamples_003Ek__BackingField;

	private int _003CTailDurationSamples_003Ek__BackingField;

	private float _003CBaseVolume_003Ek__BackingField;

	public AudioResource AudioRes
	{
		get
		{
			return _003CAudioRes_003Ek__BackingField;
		}
		private set
		{
			_003CAudioRes_003Ek__BackingField = value;
		}
	}

	public int BarNumber
	{
		get
		{
			return _003CBarNumber_003Ek__BackingField;
		}
		private set
		{
			_003CBarNumber_003Ek__BackingField = value;
		}
	}

	public int BeatNumber
	{
		get
		{
			return _003CBeatNumber_003Ek__BackingField;
		}
		private set
		{
			_003CBeatNumber_003Ek__BackingField = value;
		}
	}

	public int LastBeatSample
	{
		get
		{
			return _003CLastBeatSample_003Ek__BackingField;
		}
		private set
		{
			_003CLastBeatSample_003Ek__BackingField = value;
		}
	}

	public int LastBarSample
	{
		get
		{
			return _003CLastBarSample_003Ek__BackingField;
		}
		private set
		{
			_003CLastBarSample_003Ek__BackingField = value;
		}
	}

	public int LastPlayHeadSample
	{
		get
		{
			return _003CLastPlayHeadSample_003Ek__BackingField;
		}
		private set
		{
			_003CLastPlayHeadSample_003Ek__BackingField = value;
		}
	}

	public RhythmSection RhythmSection
	{
		get
		{
			return _003CRhythmSection_003Ek__BackingField;
		}
		private set
		{
			_003CRhythmSection_003Ek__BackingField = value;
		}
	}

	public TransportStatus Status
	{
		get
		{
			return _003CStatus_003Ek__BackingField;
		}
		private set
		{
			_003CStatus_003Ek__BackingField = value;
		}
	}

	public ResourceID MusicID => default(ResourceID);

	public string ClipName => null;

	public AudioSource AudioSource => null;

	public AudioClip AudioClip => null;

	public bool IsPlaying => false;

	private bool IsLoop => false;

	public float PlayHeadTime => 0f;

	public int PlayHeadSample => 0;

	public int TotalSamples => 0;

	public float TotalDuration => 0f;

	public int SampleRate => 0;

	public string Category => null;

	public float Tempo => 0f;

	public float BeatDuration => 0f;

	public float BarDuration => 0f;

	public int BeatsPerBar => 0;

	public float IntroDuration => 0f;

	public float TailDuration => 0f;

	public int BeatDurationSamples
	{
		get
		{
			return _003CBeatDurationSamples_003Ek__BackingField;
		}
		private set
		{
			_003CBeatDurationSamples_003Ek__BackingField = value;
		}
	}

	public int BarDurationSamples
	{
		get
		{
			return _003CBarDurationSamples_003Ek__BackingField;
		}
		private set
		{
			_003CBarDurationSamples_003Ek__BackingField = value;
		}
	}

	public int IntroDurationSamples
	{
		get
		{
			return _003CIntroDurationSamples_003Ek__BackingField;
		}
		private set
		{
			_003CIntroDurationSamples_003Ek__BackingField = value;
		}
	}

	public int TailDurationSamples
	{
		get
		{
			return _003CTailDurationSamples_003Ek__BackingField;
		}
		private set
		{
			_003CTailDurationSamples_003Ek__BackingField = value;
		}
	}

	public float BaseVolume
	{
		get
		{
			return _003CBaseVolume_003Ek__BackingField;
		}
		private set
		{
			_003CBaseVolume_003Ek__BackingField = value;
		}
	}

	public MusicTransport(AudioResource audioResource, MusicRhythmData rhythmData)
	{
	}

	private RhythmSection LocateRhythmSection(int sampleIndex)
	{
		return RhythmSection.Intro;
	}

	public void Play(float fadeTime, Action onFadeEnd = null)
	{
	}

	public void Stop(float fadeTime, Action onFadeEnd = null)
	{
	}

	public void Pause(float fadeTime, Action onFadeEnd = null)
	{
	}

	public void Resume(float fadeTime)
	{
	}

	public void SetVolume(float volume, float fadeTime)
	{
	}

	public void Seek(int sample)
	{
	}

	public int FindNearestBarSample(int sample)
	{
		return 0;
	}

	public void UpdatePlayHead()
	{
	}

	private void OnBeat()
	{
	}

	private void OnBar()
	{
	}

	internal void OnIntro()
	{
	}

	private void OnLoop()
	{
	}

	private void OnTail()
	{
	}
}
