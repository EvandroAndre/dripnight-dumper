using System.Collections.Generic;
using COW.Audio;
using GCommon.Audio;
using UnityEngine;

namespace GCommon;

public class AudioEngine_Unity : IAudioEngine
{
	private readonly AudioResourceManager_Unity m_ResManager;

	private readonly AudioEmitterManager_Unity m_EmitterManager;

	private readonly AudioGameSyncManager_Unity m_GameSyncManager;

	private AudioGroupManager _003CGroupManager_003Ek__BackingField;

	private readonly MusicManager m_MusicManager;

	private readonly Dictionary<ResourceID, AudioFadeEffect> m_AudioFadeEffects;

	private readonly List<ResourceID> m_FinishFadeEffect;

	private bool m_ChangedSoundEffectVolume;

	private bool _003CMusicOn_003Ek__BackingField;

	private bool _003CSoundEffectOn_003Ek__BackingField;

	private float _003CMusicVolume_003Ek__BackingField;

	private float _003CSoundEffectVolume_003Ek__BackingField;

	private GameObject m_OwnedObject;

	private readonly ObjectPool<AudioResource> m_AudioResourcePool;

	private readonly ObjectPool<AudioResWithCallBackDefault> m_AudioResourceWithCallBackPool;

	private HashSet<AudioResource> m_RunningAudioResource;

	private readonly HashSet<AudioResWithCallBackDefault> m_PlayingAudioResourceWithCallBack;

	private readonly List<AudioResWithCallBackDefault> m_EndedSounds;

	private PlayOnAudioAsyncLoaded m_PlayOnClipAsyncLoaded;

	private readonly Queue<AudioPlaybackParams> m_PlaybackParamPool;

	private ResourceID m_AmbienceResource;

	public AudioResourceManager ResManager => null;

	public AudioEmitterManager EmitterManager => null;

	public AudioGameSyncManager GameSyncManager => null;

	public AudioGroupManager GroupManager
	{
		get
		{
			return _003CGroupManager_003Ek__BackingField;
		}
		private set
		{
			_003CGroupManager_003Ek__BackingField = value;
		}
	}

	public MusicManager MusicManager => null;

	public bool MusicOn
	{
		get
		{
			return _003CMusicOn_003Ek__BackingField;
		}
		private set
		{
			_003CMusicOn_003Ek__BackingField = value;
		}
	}

	public bool SoundEffectOn
	{
		get
		{
			return _003CSoundEffectOn_003Ek__BackingField;
		}
		private set
		{
			_003CSoundEffectOn_003Ek__BackingField = value;
		}
	}

	public float MusicVolume
	{
		get
		{
			return _003CMusicVolume_003Ek__BackingField;
		}
		private set
		{
			_003CMusicVolume_003Ek__BackingField = value;
		}
	}

	public float SoundEffectVolume
	{
		get
		{
			return _003CSoundEffectVolume_003Ek__BackingField;
		}
		private set
		{
			_003CSoundEffectVolume_003Ek__BackingField = value;
		}
	}

	public void Init(GameObject ownedObject)
	{
	}

	public void OnGameDestroy()
	{
	}

	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	private void UpdateFadeEffects(float deltaTime)
	{
	}

	public void SetMusicOn(bool value)
	{
	}

	public void SetSoundEffectOn(bool v)
	{
	}

	public void SetMusicVolume(float vol)
	{
	}

	public void SetMusicVolume(float vol, float fadeTime)
	{
	}

	public void SetSoundEffectVolume(float v)
	{
	}

	public void OnSettingChanged()
	{
	}

	public void OnAudioConfigurationChanged()
	{
	}

	public void OnMicStateChanged(bool isMute, float factor)
	{
	}

	private AudioResource AllocAndLoadAudioResourceClip(ResourceID sound, bool loop)
	{
		return null;
	}

	private AudioResWithCallBackDefault AllocAndLoadAudioResourceClip(ResourceID sound, bool loop, AudioEndInternalCallBack callBack)
	{
		return null;
	}

	public AudioClip LoadAudioClip(ResourceID sound)
	{
		return null;
	}

	public void UnloadAudio(ResourceID sound)
	{
	}

	public void UnloadAudiosByABPath(string abPath)
	{
	}

	private void RecycleAudioResources()
	{
	}

	private void SetupAsyncPlaybackDelegates()
	{
	}

	private void PlayOnClipAsyncLoaded(AudioAsyncLoadData loadData)
	{
	}

	public void CancelThreeDSoundAsync(uint playingID)
	{
	}

	public AudioPlaybackParams GetPlaybackParams()
	{
		return null;
	}

	public void ReturnPlaybackParams(AudioPlaybackParams playbackParams)
	{
	}

	public AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f)
	{
		return null;
	}

	public void StopOneShotWithCallBack(AudioResWithCallBackBase resource)
	{
	}

	public void PlayOneShotAsync(ResourceID sound, AudioPlaybackParams optionalParams, ResourceManager.LoadPriority lp = ResourceManager.LoadPriority.Normal)
	{
	}

	public GameObject PlayOneShot(ResourceID sound, AudioPlaybackParams optionalParams)
	{
		return null;
	}

	public GameObject UGCPlayOneShot(AudioClip soundClip, float volume = 1f, int inGameGroup = -1, float speed = 1f)
	{
		return null;
	}

	public void StopPlayShot()
	{
	}

	public void StopPlayShot(GameObject emitter)
	{
	}

	public void StopSoundByPlayingID(uint playingID, float fadeOutTime = 0f, bool autoUnload = false)
	{
	}

	internal void StopSoundInstance(SoundInstance_Unity sound, float fadeOutTime = 0f, bool autoUnload = false)
	{
	}

	public void PauseSound(uint playingID, bool isPaused)
	{
	}

	public void BreakSound(uint playingID)
	{
	}

	public void SeekSoundByTime(uint playingID, float time = 0f)
	{
	}

	public void SeekSoundByPercent(uint playingID, float percent = 0f)
	{
	}

	public AudioResource Play2DLoopStart(ResourceID sound, AudioPlaybackParams optionalParams = null)
	{
		return null;
	}

	public bool IsRunning2DResource(AudioResource sound)
	{
		return false;
	}

	public AudioResource UGCPop2DLoopAudioSource(float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, int inGameGroup = -1)
	{
		return null;
	}

	public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumeChangeSpeed = 1f)
	{
	}

	private void StopAll2DLoopSound()
	{
	}

	private bool Can2DSoundPlay(ResourceID soundID, AudioGroup group, AudioPlaybackParams_Unity optionalParams)
	{
		return false;
	}

	public uint PlaySound2D(ResourceID soundID, bool async = false, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	private SoundInstance_Unity PlaySound2DInternal(uint playingID, ResourceID soundID, AudioClip clip, AudioGroup group, AudioPlaybackParams_Unity optionalParams, AudioManager.AudioEndCallBack endCallback)
	{
		return null;
	}

	private PlaySoundResult Can3DSoundPlay(ResourceID soundID, Vector3 worldPos, AudioGroup group, AudioPlaybackParams_Unity optionalParams)
	{
		return PlaySoundResult.Success;
	}

	public uint PlaySound3D(ResourceID soundID, GameObject emitter, bool async = false, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	private SoundInstance_Unity PlaySound3DInternal(uint playingID, ResourceID soundID, AudioClip clip, GameObject emitter, Vector3 worldPos, AudioGroup group, bool isVirtualized, AudioPlaybackParams_Unity optionalParams, AudioManager.AudioEndCallBack endCallback)
	{
		return null;
	}

	public uint PlaySoundAtLocation(ResourceID soundID, Vector3 worldPos, bool async = false, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	public void Play3DLoopStop(GameObject emitter)
	{
	}

	public GameObject Play3DShot(ResourceID sound, Transform parent, Vector3 worldPos, AudioPlaybackParams optionalParams = null, bool allowAsync = true, bool isStoppable = false)
	{
		return null;
	}

	public GameObject Play3DLoopStart(ResourceID sound, Transform parent, AudioPlaybackParams optionalParams = null)
	{
		return null;
	}

	public AudioSource UGCPop3DLoopAudioSource(Transform parent, ResourceID audioSourceID, float volume = 1f, float distance = -1f)
	{
		return null;
	}

	public void StopAllSounds()
	{
	}

	public void Stop3DShot(GameObject emitter)
	{
	}

	public uint PlayMultiPositionSound(ResourceID sound, Vector3 position, float maxAttenuation, int mixerGroup = 22, float updateInterval = 0.5f)
	{
		return 0u;
	}

	public void UpdateMultiPositionSound(ResourceID sound, uint playingID, Vector3 newPosition)
	{
	}

	public bool StopMultiPositionSound(ResourceID sound, uint playingID)
	{
		return false;
	}

	private void PlaySoundEffectInternal(ResourceID soundID, AudioSource audioSource, AudioClip clip, AudioPlaybackParams_Unity optionalParams)
	{
	}

	internal MultiSound LoadMultiSound(ResourceID soundID)
	{
		return null;
	}

	internal uint PlayMultiSound(ResourceID soundID, GameObject emitter, bool isLowMemory = false, bool async = false, AudioPlaybackParams_Unity playParams = null)
	{
		return 0u;
	}

	internal void ResetMultiSound(ResourceID soundID, GameObject emitter)
	{
	}

	public void PlayMusic(ResourceID resourceID, bool loop, int mixerGroup)
	{
	}

	public void StopMusic(float fadeOutTime = 1f)
	{
	}

	public void PlayHorizontalStinger(ResourceID resourceID)
	{
	}

	public bool InterruptHorizontalStinger(bool crossFade = true, float fadeTime = 0.2f)
	{
		return false;
	}

	public ResourceID GetCurrentPlayingMusic()
	{
		return default(ResourceID);
	}

	public bool IsMusicPlaying(ResourceID resourceID)
	{
		return false;
	}

	public AudioResource PlayAmbience(ResourceID sound, float fadeTime = 2f, bool isNeedUnloadAudioData = false)
	{
		return null;
	}

	public void StopAmbience(AudioResource sound, float volChangeTime = 2f)
	{
	}
}
