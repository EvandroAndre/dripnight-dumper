using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public abstract class SoundInstance
{
	public HashSet<ISoundInstanceOwner> Owners;

	public ResourceID SoundID;

	public uint PlayingID;

	public float PlayStartTime;

	public bool ManuallyStopped;

	public bool AutoUnload;

	public AudioManager.AudioEndCallBack EndCallback;

	private bool _003CIsPaused_003Ek__BackingField;

	private GameObject _003CEmitter_003Ek__BackingField;

	public abstract bool IsPlaying { get; }

	public bool IsPaused
	{
		get
		{
			return _003CIsPaused_003Ek__BackingField;
		}
		private set
		{
			_003CIsPaused_003Ek__BackingField = value;
		}
	}

	public virtual GameObject Emitter
	{
		get
		{
			return _003CEmitter_003Ek__BackingField;
		}
		set
		{
			_003CEmitter_003Ek__BackingField = value;
		}
	}

	public Vector3 WorldPos => default(Vector3);

	public abstract void SeekByTime(float time);

	public abstract void SeekByPercent(float percent);

	public virtual void Pause(bool paused)
	{
	}

	public abstract void Break();

	public virtual void Stop(float fadeOutTime = 0f)
	{
	}

	public virtual void OnEndedOrStopped()
	{
	}

	public virtual void Reset()
	{
	}
}
