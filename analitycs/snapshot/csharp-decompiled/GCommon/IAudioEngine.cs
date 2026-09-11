using GCommon.Audio;
using UnityEngine;

namespace GCommon;

public interface IAudioEngine
{
	AudioEmitterManager EmitterManager { get; }

	AudioGameSyncManager GameSyncManager { get; }

	AudioResourceManager ResManager { get; }

	bool SoundEffectOn { get; }

	float SoundEffectVolume { get; }

	bool MusicOn { get; }

	float MusicVolume { get; }

	void Init(GameObject ownedObject);

	void RunOneFrame(float gameTime, float deltaTime);

	void OnGameDestroy();

	void SetSoundEffectVolume(float v);

	void SetSoundEffectOn(bool v);

	void OnSettingChanged();

	AudioPlaybackParams GetPlaybackParams();

	void ReturnPlaybackParams(AudioPlaybackParams playbackParams);

	uint PlaySound2D(ResourceID soundID, bool async, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null);

	uint PlaySound3D(ResourceID soundID, GameObject emitter, bool async = false, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null);

	uint PlaySoundAtLocation(ResourceID soundID, Vector3 location, bool async = false, AudioPlaybackParams optionalParams = null, AudioManager.AudioEndCallBack endCallback = null);

	void PauseSound(uint playingID, bool isPaused);

	void BreakSound(uint playingID);

	void SeekSoundByTime(uint playingID, float time = 0f);

	void SeekSoundByPercent(uint playingID, float percent = 0f);

	GameObject Play3DShot(ResourceID sound, Transform parent, Vector3 worldPos, AudioPlaybackParams optionalParams = null, bool allowAsync = true, bool isStoppable = false);

	void Stop3DShot(GameObject emitter);

	AudioResource Play2DLoopStart(ResourceID sound, AudioPlaybackParams optionalParams = null);

	void Play2DLoopStop(AudioResource audioSourceObj, bool fade, bool isNeedUnloadAudioData = false, float volumeChangeSpeed = 1f);

	GameObject Play3DLoopStart(ResourceID sound, Transform parent, AudioPlaybackParams optionalParams = null);

	void Play3DLoopStop(GameObject emitter);

	GameObject PlayOneShot(ResourceID sound, AudioPlaybackParams optionalParams = null);

	void PlayOneShotAsync(ResourceID sound, AudioPlaybackParams optionalParams = null, ResourceManager.LoadPriority lp = ResourceManager.LoadPriority.Normal);

	AudioResWithCallBackBase PlayOneShotWithCallBack(ResourceID sound, AudioEndInternalCallBack callBack, float volume = 1f);

	void StopPlayShot();

	void StopPlayShot(GameObject emitter);

	void StopSoundByPlayingID(uint playingID, float fadeOutTime = 0f, bool autoUnload = false);

	void StopOneShotWithCallBack(AudioResWithCallBackBase resource);

	void StopAllSounds();

	uint PlayMultiPositionSound(ResourceID sound, Vector3 position, float maxAttenuation, int mixerGroup, float updateInterval);

	void UpdateMultiPositionSound(ResourceID sound, uint playingID, Vector3 newPosition);

	bool StopMultiPositionSound(ResourceID sound, uint playingID);

	void SetMusicOn(bool value);

	void SetMusicVolume(float v);

	void PlayMusic(ResourceID musicID, bool loop, int mixerGroup);

	void StopMusic(float fadeOutTime);

	ResourceID GetCurrentPlayingMusic();

	bool IsMusicPlaying(ResourceID audioID);

	void UnloadAudio(ResourceID soundID);

	void UnloadAudiosByABPath(string abPath);

	void OnMicStateChanged(bool isMute, float factor);
}
