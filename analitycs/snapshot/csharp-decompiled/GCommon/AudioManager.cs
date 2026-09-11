using System;
using System.Collections.Generic;
using System.IO;
using COW.GamePlay;
using GCommon.Audio;
using UnityEngine;

namespace GCommon;

public class AudioManager : MonoBehaviour
{
	public delegate void AudioEndCallBack(uint playingID, bool endByCancel, ResourceID resID);

	public static bool EnablePlayOneShot;

	private static bool s_EnableAsyncLoadForLowest;

	private static bool s_EnableAsyncLoadForLow;

	private static bool s_EnableAsyncLoadForUltra;

	private static float s_AsyncLoadMaxDelay;

	private static AudioManager m_Instance;

	private MNMBLBKENMK m_Quality;

	private static float m_KillSoundEffectVolume;

	private EAudioEngineType m_DefaultEngineType;

	private readonly Dictionary<int, IAudioEngine> m_AudioEngineMap;

	private AudioChannel[] m_ChannelMap;

	private bool m_WwiseDownloadState;

	private bool m_HaveInitNeedDuplicateAudio;

	private readonly List<ResourceID> m_NeedExceptDuplicateAudio;

	private readonly Dictionary<ResourceID, float> m_LastPlaySoundTimeStamp;

	private AudioSource m_BotAgentAudioSource;

	private bool m_IsBotAgentAudioCSMode;

	private AudioClip m_StreamingClip;

	private MemoryStream m_StreamingVoiceAudioData;

	private int m_StreamingVoiceAudioDataReadPos;

	private readonly int m_StreamingVoiceFrequency;

	public static AudioManager instance => null;

	public bool MusicOn => false;

	public bool SoundEffectOn => false;

	public float MusicVolume => 0f;

	public float SoundEffectVolume => 0f;

	public EAudioEngineType DefaultEngineType
	{
		get
		{
			return EAudioEngineType.eUnity;
		}
		set
		{
		}
	}

	private void Awake()
	{
	}

	private void InitAudioChannel()
	{
	}

	public void OnGameDestroy()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearAllSound()
	{
	}

	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	public void SetMusicOn(bool v)
	{
	}

	public void SetMusicVolume(float v)
	{
	}

	public void SetSoundEffectVolume(float v)
	{
	}

	public void SetSoundEffectOn(bool v)
	{
	}

	public void OnSettingChanged()
	{
	}

	public void OnMicStateChange(bool isMute, float factor)
	{
	}

	public void SetQualityLevel(MNMBLBKENMK quality)
	{
	}

	public static void SetAsyncLoad(float maxDelay, bool enableForLowest, bool enableForLow, bool enableForUltra)
	{
	}

	private void UpdateEngineAsyncLoad()
	{
	}

	private void OnAudioConfigurationChanged(bool deviceWasChanged)
	{
	}

	public static T GetInstanceByEngineType<T>() where T : IAudioEngine
	{
		return default(T);
	}

	private static EAudioEngineType GetAudioEngineKeyByType(Type type)
	{
		return EAudioEngineType.eUnity;
	}

	public IAudioEngine GetAudioEngineByType(EAudioEngineType targetEngine)
	{
		return null;
	}

	public AudioEngine_Unity GetUnityEngine()
	{
		return null;
	}

	public void InitWwiseSoundDownloadState()
	{
	}

	public bool UsedWwiseSound(bool specialProcessForAim = false)
	{
		return false;
	}

	public float GetAudioClipLengthBySoundRes(ResourceID sound)
	{
		return 0f;
	}

	public void UnloadAudio(ResourceID sound, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	public void UnloadAudiosByABPath(string abPath)
	{
	}

	public AudioPlaybackParams GetPlaybackParams(EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return null;
	}

	public void ReturnPlaybackParams(AudioPlaybackParams optionalParams)
	{
	}

	public uint PlaySound2D(ResourceID soundID, bool async = false, AudioPlaybackParams optionalParams = null, AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	public uint PlaySound3D(ResourceID soundID, GameObject emitter, bool async = false, AudioPlaybackParams optionalParams = null, AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	public uint PlaySoundAtLocation(ResourceID soundID, Vector3 location, bool async = false, AudioPlaybackParams optionalParams = null, AudioEndCallBack endCallback = null)
	{
		return 0u;
	}

	public uint PlayMultiSound(ResourceID soundID, GameObject emitter = null, bool isLowMemory = false, bool async = false, AudioPlaybackParams optionalParams = null)
	{
		return 0u;
	}

	public void ResetMultiSound(ResourceID soundID, GameObject emitter = null)
	{
	}

	public void StopSoundByPlayingID(ref uint playingID, float fadeOutTime = 0f, bool autoUnload = false)
	{
	}

	public void PauseSound(uint playingID, bool isPaused)
	{
	}

	public void SeekOnSound(uint playingID, float time = 0f, bool byPercent = false)
	{
	}

	public void BreakSound(uint playingID)
	{
	}

	public bool IsSoundPlaying(uint playingID)
	{
		return false;
	}

	public void UpdateVolume(uint playingID, float volume)
	{
	}

	public void UpdatePitch(uint playingID, float pitch)
	{
	}

	public GameObject Play3DShot(ResourceID sound, Vector3 worldPos, ResourceID audioSourceID, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity, bool allowAsync = true, bool isStoppable = false, int inGameGroup = -1)
	{
		return null;
	}

	public GameObject Play3DShot(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity, bool allowAsync = true, bool isStoppable = false, int inGameGroup = -1)
	{
		return null;
	}

	public void Stop3DShot(GameObject emitter)
	{
	}

	public void InitAudioGroupInfo(uint groupID, int limitCount, int maxRange = 25)
	{
	}

	public void ClearAudioGroupMap()
	{
	}

	public void ClearAudio3DPool()
	{
	}

	public AudioResource Play2DLoopStart(ResourceID sound, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity, int mixerGroup = -1)
	{
		return null;
	}

	public void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, EAudioEngineType targetEngine = EAudioEngineType.eUnity, float volumeChangeSpeed = 1f)
	{
	}

	private void Play2DLoopStopInternal(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData, EAudioEngineType targetEngine, float volumeChangeSpeed = 1f)
	{
	}

	public GameObject Play3DLoopStart(ResourceID sound, Transform parent, ResourceID audioSourceID, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return null;
	}

	public void Play3DLoopStop(GameObject audioSourceObj, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	private void Play3DLoopStopInternal(GameObject audioSourceObj, EAudioEngineType targetEngine)
	{
	}

	public void PlayOneShotWithChannel(ResourceID sound, EAudioChannel channel, AudioEndCallBack callBack, float volume = 1f, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	public GameObject PlayOneShot(ResourceID sound, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity, int inGameGroup = -1, ResourceID audioSourceRes = default(ResourceID))
	{
		return null;
	}

	public void PlayOneShotAsync(ResourceID sound, ResourceManager.LoadPriority lp = ResourceManager.LoadPriority.Normal, float volume = 1f, ESoundOwner ownerType = ESoundOwner.Default, EAudioEngineType targetEngine = EAudioEngineType.eUnity, int inGameGroup = -1, ResourceID audioSourceRes = default(ResourceID))
	{
	}

	public void RecordPlayingSound(GameObject result, EAudioEngineType targetEngine)
	{
	}

	internal AudioResWithCallBackBase PlayOneShotInternal(ResourceID sound, ref EAudioEngineType targetEngine, AudioEndInternalCallBack callback = null, float volume = 1f)
	{
		return null;
	}

	public void StopPlayShot()
	{
	}

	public void StopPlayShot(GameObject obj, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	public void StopPlayShotWithChannel(EAudioChannel channel)
	{
	}

	internal void StopPlayShotInternal(AudioResWithCallBackBase resource, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
	}

	public uint PlayMultiPositionSound(ResourceID sound, Vector3 position, float attenuation, int mixerGroup = 22, float updateInterval = 0.5f)
	{
		return 0u;
	}

	public void UpdateMultiPositionSound(ResourceID sound, uint playingID, Vector3 position)
	{
	}

	public bool StopMultiPositionSound(ResourceID sound, uint playingID)
	{
		return false;
	}

	public AudioResource PlayAmbience(ResourceID sound, float fadeTime = 2f)
	{
		return null;
	}

	public void StopAmbience(AudioResource sound, float fadeTime = 2f)
	{
	}

	public void PlayMusic(ResourceID musicID, bool loop = true, EAudioEngineType targetEngine = EAudioEngineType.eUnity, int mixerGroup = 0)
	{
	}

	public ResourceID GetCurrentPlayingMusic(EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return default(ResourceID);
	}

	public bool IsMusicPlaying(ResourceID audioID, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return false;
	}

	public void StopMusic(float fadeOutTime = 1f)
	{
	}

	public void PlayCurrentMusicFadeEffect(float targetVolume, bool needOverride = false, EAudioEngineType targetEngine = EAudioEngineType.eUnity, float fadeTime = 0f)
	{
	}

	public void PlayHorizontalStinger(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
	}

	public void InterruptHorizontalStinger(bool crossFade = true, float fadeTime = 0.2f)
	{
	}

	public GameObject GetGlobalEmitter(EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return null;
	}

	public GameObject GetEmitterFromPlayingID(uint playingID, EAudioEngineType targetEngine = EAudioEngineType.eUnity)
	{
		return null;
	}

	public SoundInstance GetSoundInstance(uint playingID)
	{
		return null;
	}

	public Vector3 GetListenerPosition(EAudioEngineType targetEngine = EAudioEngineType.eNone)
	{
		return default(Vector3);
	}

	public float GetSquareDistanceToListener(Vector3 worldPos, EAudioEngineType targetEngine = EAudioEngineType.eNone)
	{
		return 0f;
	}

	public void SetGlobalParameter(uint parameterID, float value, EAudioEngineType engineType)
	{
	}

	public void SetState<TGroupType>(TGroupType value, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
	}

	public TGroupType GetState<TGroupType>(EAudioEngineType engineType = EAudioEngineType.eNone)
	{
		return default(TGroupType);
	}

	public void SetSwitch<TGroupType>(TGroupType value, GameObject emitter, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
	}

	public void SetSwitch(string groupName, string value, GameObject emitter, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
	}

	public TGroupType GetSwitch<TGroupType>(GameObject emitter, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
		return default(TGroupType);
	}

	public void SetParameter(uint parameterID, float value, GameObject emitter = null, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
	}

	public float GetParameter(uint parameterID, GameObject emitter = null, EAudioEngineType engineType = EAudioEngineType.eNone)
	{
		return 0f;
	}

	private bool CheckCanPlayThisSound(ResourceID resID)
	{
		return false;
	}

	private void InitNeedDuplicateExceptAudio()
	{
	}

	public void InitBotAgentVoice(bool UGCLLMInit = false, bool isCSMode = false)
	{
	}

	private void OnStreamVoiceAudioRead(float[] data)
	{
	}

	private void OnStreamVoiceAudioSetPosition(int newPosition)
	{
	}

	public void PlayStreamVoice()
	{
	}

	public float GetRemainingStreamingVoiceTime()
	{
		return 0f;
	}

	public void UploadStreamingVoiceData(byte[] data)
	{
	}

	public void UploadStreamingVoiceData(int length, byte[] data)
	{
	}

	public void UploadStreamingVoiceData(int length, byte[] data, int offset)
	{
	}

	public void StopStreamingVoice()
	{
	}

	public void PlayClip(AudioClip clip)
	{
	}

	public bool IsBotAgentVoicePlaying()
	{
		return false;
	}

	public bool IsStreamingAudioClipPlaying()
	{
		return false;
	}

	public bool IsBotAgentAduioClipPlaying()
	{
		return false;
	}

	public void SetBotAgentVoiceVolume(float volume)
	{
	}

	public bool IsBotAgentVoiceCSMode()
	{
		return false;
	}

	public void ClearBotAgentVoice()
	{
	}
}
