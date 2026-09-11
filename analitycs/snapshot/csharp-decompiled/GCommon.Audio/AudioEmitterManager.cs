using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public abstract class AudioEmitterManager : AudioSubSystem, ISoundInstanceOwner
{
	private GameObject _003CGlobalEmitterRoot_003Ek__BackingField;

	private GameObject _003CMusicEmitter_003Ek__BackingField;

	private static uint s_PlayingID;

	public const uint INVALID_PLAYING_ID = 0u;

	protected readonly Dictionary<uint, SoundInstance> m_RunningSoundInstances;

	public GameObject GlobalEmitterRoot
	{
		get
		{
			return _003CGlobalEmitterRoot_003Ek__BackingField;
		}
		protected set
		{
			_003CGlobalEmitterRoot_003Ek__BackingField = value;
		}
	}

	public GameObject MusicEmitter
	{
		get
		{
			return _003CMusicEmitter_003Ek__BackingField;
		}
		protected set
		{
			_003CMusicEmitter_003Ek__BackingField = value;
		}
	}

	public override void OnInit()
	{
	}

	public override void OnCleanUp()
	{
	}

	protected abstract void CreateGlobalEmitters();

	private void RemoveGlobalEmitters()
	{
	}

	public static uint GetIncrementalPlayingID()
	{
		return 0u;
	}

	public abstract bool IsPlaying(uint playingID);

	public SoundInstance GetSoundInstance(uint playingID)
	{
		return null;
	}

	public void OnSoundInstanceStopped(SoundInstance instance)
	{
	}

	public GameObject GetEmitterFromPlayingID(uint playingID)
	{
		return null;
	}

	public abstract Vector3 GetListenerPosition();

	public float GetSquareDistanceToListener(Vector3 worldPos)
	{
		return 0f;
	}
}
