using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon.Audio;

public class AudioEmitterManager_Unity : AudioEmitterManager
{
	private class MultiPositionPlaybackData
	{
		private List<MultiPositionEmitter> _003CEmitters_003Ek__BackingField;

		private readonly float m_UpdateInterval;

		private float m_TimeFromLastUpdate;

		private AudioSource _003CAudioSource_003Ek__BackingField;

		private Vector3 _003CEmitterPosition_003Ek__BackingField;

		public List<MultiPositionEmitter> Emitters
		{
			get
			{
				return _003CEmitters_003Ek__BackingField;
			}
			private set
			{
				_003CEmitters_003Ek__BackingField = value;
			}
		}

		public AudioSource AudioSource
		{
			get
			{
				return _003CAudioSource_003Ek__BackingField;
			}
			private set
			{
				_003CAudioSource_003Ek__BackingField = value;
			}
		}

		public Vector3 EmitterPosition
		{
			get
			{
				return _003CEmitterPosition_003Ek__BackingField;
			}
			private set
			{
				_003CEmitterPosition_003Ek__BackingField = value;
			}
		}

		public MultiPositionPlaybackData(float updateInterval)
		{
		}

		public uint AddEmitter(Vector3 position, float maxAttenuation)
		{
			return 0u;
		}

		public void RemoveEmitter(uint playingID)
		{
		}

		public void ClearAll()
		{
		}

		public void UpdatePosition(uint playingID, Vector3 position)
		{
		}

		private MultiPositionEmitter GetEmitterFromID(uint playingID)
		{
			return null;
		}

		public void RunOneFrame(float deltaTime)
		{
		}

		private void UpdateEmitterPosition()
		{
		}
	}

	private class MultiPositionEmitter
	{
		public readonly uint PlayingID;

		public readonly float MaxAttenuation;

		public Vector3 Position;

		public Vector3 DirectionToListener;

		public float DistanceToListener;

		public float VolumeWeight;

		public MultiPositionEmitter(Vector3 position, float maxAttenuation)
		{
		}
	}

	internal readonly SoundInstancePool_Unity Audio2DObjectPool;

	internal readonly SoundInstancePool_Unity Audio3DObjectPool;

	private AudioListener m_AudioListener;

	private readonly Dictionary<ResourceID, int> m_OneShotCountInFrame;

	public static bool EnableMaxDistCheckForDefaultAudioSource;

	public static float MaxDistForDefaultAudioSource;

	private readonly Dictionary<ResourceID, MultiPositionPlaybackData> m_MultiPositionSounds;

	public static ResourceID DEFAULT_AUDIOSOURCE_3D => default(ResourceID);

	public static ResourceID DEFAULT_AUDIOSOURCE_2D => default(ResourceID);

	public override void RunOneFrame(float deltaTime)
	{
	}

	public override void OnGameDestroy()
	{
	}

	protected override void CreateGlobalEmitters()
	{
	}

	public SoundInstance_Unity Create2DSoundInstance(ResourceID soundID, AudioManager.AudioEndCallBack endCallback = null)
	{
		return null;
	}

	public SoundInstance_Unity Create3DSoundInstance(ResourceID soundID, ResourceID audioSourceID, AudioManager.AudioEndCallBack endCallback = null)
	{
		return null;
	}

	public override bool IsPlaying(uint playingID)
	{
		return false;
	}

	internal void RegisterRunningSound(uint playingID, SoundInstance_Unity instance)
	{
	}

	public List<SoundInstance_Unity> FindSoundInstances(bool is3D, Predicate<SoundInstance_Unity> predicate = null)
	{
		return null;
	}

	public AudioSource GetRunningAudioSource(uint playingID)
	{
		return null;
	}

	private void AutoRemoveStoppedInstances()
	{
	}

	public void OnSoundVolumeChanged(float volume)
	{
	}

	public AudioListener GetCurrentListener()
	{
		return null;
	}

	public override Vector3 GetListenerPosition()
	{
		return default(Vector3);
	}

	public bool IsOneShotLimitExceeded(ResourceID sound)
	{
		return false;
	}

	public bool Should3DSoundBeDistanceCulled(Vector3 emitterPos, ResourceID audioSourceID)
	{
		return false;
	}

	private bool WithinDefaultAudioSourceMaxDist(Vector3 worldPos, ResourceID audioSourceID)
	{
		return false;
	}

	public AudioSource GetOrCreateMultiPositionEmitter(ResourceID sound, float updateInterval)
	{
		return null;
	}

	public uint AddMultiPositionSource(ResourceID sound, Vector3 position, float maxAttenuation)
	{
		return 0u;
	}

	public void UpdateMultiPositionSound(ResourceID sound, uint playingID, Vector3 newPosition)
	{
	}

	public bool RemoveMultiPositionSource(ResourceID sound, uint playingID)
	{
		return false;
	}

	public void StopMultiPositionSound(ResourceID sound)
	{
	}

	public Vector3 GetMultiPositionSoundPosition(ResourceID sound)
	{
		return default(Vector3);
	}
}
