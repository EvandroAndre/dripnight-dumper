using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW;

public class FFAudioManager : SingletonModule<FFAudioManager>, IPausable
{
	private class EmoteSoundInstance
	{
		public uint PlayingID;

		public readonly BHGGAEEHJCO OwnerID;

		public BHGGAEEHJCO FollowLeaderID;

		public EmoteSoundInstance(BHGGAEEHJCO ownerID)
		{
		}
	}

	public const int InVaildTicket = -1;

	public const int VolumeIsMuteTicket = -2;

	private const int ForcePositive = int.MaxValue;

	private EAudioEngineType m_DefaultEngineType;

	private FFAudioEngine_Unity m_Engine;

	private CreateCurveConfig m_AudioBalanceCurve;

	private readonly Dictionary<uint, EmoteSoundInstance> m_RunningInGameEmoteSounds;

	private readonly List<uint> m_RunningLobbyEmoteSounds;

	private uint m_CutScenePlayingID;

	private bool m_IsSoundMuted;

	private static float m_lastPlayEquipAudioTime;

	private const float c_PlayEquipAudioTimeDelay = 0.3f;

	private RegionMaskQuery m_MaskData;

	private static readonly Dictionary<uint, ResourceID> s_MapIDToRegionID;

	public EAudioEngineType DefaultEngineType => EAudioEngineType.eUnity;

	public CreateCurveConfig AudioBalanceCurve => null;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void RunOneFrame(float gameTime, float deltaTime)
	{
	}

	public void OnGameLoaded()
	{
	}

	public void PlaySoundEffect(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, int audioMixerGroup = 5)
	{
	}

	public void StopSoundEffect(int ticket)
	{
	}

	public int PlaySoundEffectTicket(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, int audioMixerGroup = 5)
	{
		return 0;
	}

	public void PlayUserVoice(ResourceID resourceID)
	{
	}

	public int PlayCharacterVoice(ResourceID resourceID, Action endCallBack, bool isQuickMsg = true)
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

	public int Start2DLoop(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity)
	{
		return 0;
	}

	public bool End2DLoop(int ticket)
	{
		return false;
	}

	internal void OnObserverTargetChanged(Player player, bool isNewTarget)
	{
	}

	public void ToggleEmote3PAudible(bool audible)
	{
	}

	private void OnLobbyEmote2DEnd(uint playingID, bool endByCancel, ResourceID resID)
	{
	}

	public uint PlayLobbyEmoteSound(ResourceID soundId, GameObject avatar, uint emoteID, bool isLoop)
	{
		return 0u;
	}

	public uint PlayLobbyEmoteSound(ResourceID resourceID, GameObject avatar = null, bool isLoop = false, float volume = 1f)
	{
		return 0u;
	}

	internal uint PlayInGameEmoteSound(ResourceID soundID, Player owner, uint emoteID = 0u, bool isLoop = false, float seekPercent = 0f)
	{
		return 0u;
	}

	internal uint PlayInGameEmoteSound(ResourceID soundID, Player owner, float volume, bool isLoop = false)
	{
		return 0u;
	}

	internal uint PlayInGameEmoteSound(ResourceID soundID, GameObject emitter, bool isLoop)
	{
		return 0u;
	}

	private EmoteSoundInstance PlayInGameEmoteSoundInternal(ResourceID soundID, Player owner, uint emoteID = 0u, bool isLoop = false, float seekPercent = 0f)
	{
		return null;
	}

	private EmoteSoundInstance PlayInGameEmoteSoundInternal(ResourceID resourceID, GameObject emitter, BHGGAEEHJCO ownerID, bool is1P, bool isLoop = false, float volume = 1f, float seekPercent = 0f)
	{
		return null;
	}

	internal void OnJoinCoopEmote(Player player, BHGGAEEHJCO emoteOwnerID, uint emoteID)
	{
	}

	internal void OnLeaveCoopEmote(Player player, BHGGAEEHJCO emoteOwnerID)
	{
	}

	internal uint OnJoinFollowEmote(uint emoteID, ResourceID soundID, Player joinedPlayer, BHGGAEEHJCO leaderID, int indexInQueue)
	{
		return 0u;
	}

	internal void OnLeaveFollowEmote(Player player, BHGGAEEHJCO leaderID)
	{
	}

	private uint PlayFollowEmoteSound(uint emoteID, ResourceID soundID, Player joinedPlayer, BHGGAEEHJCO leaderID)
	{
		return 0u;
	}

	private void ReroutePlayingEmoteSound(uint playingID, bool to1P)
	{
	}

	private void ReroutePlayingEmoteSoundByPlayer(BHGGAEEHJCO playerID, bool to1P)
	{
	}

	private float GetFollowEmotePlaybackTime(uint playingID)
	{
		return 0f;
	}

	private EmoteSoundInstance QueryInGameEmoteByPlayer(BHGGAEEHJCO ownerID)
	{
		return null;
	}

	private List<uint> QueryInGameFollowEmotesByLeader(BHGGAEEHJCO leaderID)
	{
		return null;
	}

	public void StopFollowEmoteSounds(BHGGAEEHJCO leaderID)
	{
	}

	public void StopEmoteSound(ref uint playingID)
	{
	}

	public void StopAllEmoteSounds()
	{
	}

	public void PlaySoundByAnimAudioBus(ResourceID soundID, EAnimAudioBusType audioBus)
	{
	}

	public bool PlayShopshow(ResourceID resourceID, bool isLoop = false)
	{
		return false;
	}

	public bool StopShopShow()
	{
		return false;
	}

	public bool PlayShopShowWithBGM(ResourceID resourceID, EAudioEngineType engine = EAudioEngineType.eUnity, bool isLoop = false)
	{
		return false;
	}

	public bool StopShopShowWithBGM()
	{
		return false;
	}

	public bool PlayCutScene(ResourceID resourceID, bool isLoop = false)
	{
		return false;
	}

	public bool StopCutScene()
	{
		return false;
	}

	private bool PlayCutSceneInternal(ResourceID resourceID, int audioMixerGroup, bool isLoop = false)
	{
		return false;
	}

	private void OnCutsceneStopped(uint playingID, bool manuallyStopped, ResourceID soundID)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	public void SetSoundEffectOn(bool isOn)
	{
	}

	public void SetSoundVolume(float vol)
	{
	}

	public void SetVoiceVolume(float vol)
	{
	}

	public void SetDefaultEngine(EAudioEngineType engine)
	{
	}

	public void OnMicStateChange()
	{
	}

	public void PlayEquipOneShot(ResourceID soundID)
	{
	}

	public bool IsRegionMaskEnabledInCurrentMap()
	{
		return false;
	}

	public FootstepMaterial QueryFootstepMaterial(Vector3 worldPos)
	{
		return FootstepMaterial.Default;
	}

	private void LoadRegionMask()
	{
	}
}
