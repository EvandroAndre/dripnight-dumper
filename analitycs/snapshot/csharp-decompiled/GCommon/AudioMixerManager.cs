using System.Collections.Generic;
using GCommon.Audio;
using UnityEngine;
using UnityEngine.Audio;

namespace GCommon;

public class AudioMixerManager : SingletonModule<AudioMixerManager>
{
	private class RuntimeEffectData
	{
		public readonly ResourceID PresetID;

		public readonly AudioSource OriginalSource;

		public readonly GameObject PresetPrefab;

		public RuntimeEffectData(ResourceID presetID, GameObject presetPrefab, AudioSource originalSource)
		{
		}
	}

	public const int AudioMixerGroup_None = -1;

	public const int AudioMixerGroup_LobbyMusic = 0;

	public const int AudioMixerGroup_Sound = 1;

	public const int AudioMixerGroup_CutScene = 2;

	public const int AudioMixerGroup_ShopShow = 3;

	public const int AudioMixerGroup_ShopShowWithBGM = 4;

	public const int AudioMixerGroup_UI = 5;

	public const int AudioMixerGroup_UI_Motion = 6;

	public const int AudioMixerGroup_UI_Button = 7;

	public const int AudioMixerGroup_UI_Button_Click = 8;

	public const int AudioMixerGroup_UI_Button_ClickAction = 9;

	public const int AudioMixerGroup_UI_Notice = 10;

	public const int AudioMixerGroup_UI_Page = 11;

	public const int AudioMixerGroup_LobbyUserVoice = 12;

	public const int AudioMixerGroup_CharacterVoice = 13;

	public const int AudioMixerGroup_Ingame_CharacterSpecial = 14;

	public const int AudioMixerGroup_Ingame_QucikChat = 15;

	public const int AudioMixerGroup_Parachuting = 16;

	public const int AudioMixerGroup_Parachuting_Flight_Common_Wind = 17;

	public const int AudioMixerGroup_Parachuting_Flight_Engine = 18;

	public const int AudioMixerGroup_Weapon = 19;

	public const int AudioMixerGroup_Weapon_Fire = 20;

	public const int AudioMixerGroup_Weapon_Reload = 21;

	public const int AudioMixerGroup_Ambience = 22;

	public const int AudioMixerGroup_Waiting_Phase_BGM = 23;

	public const int AudioMixerGroup_Waiting_Phase_3P_Player = 24;

	public const int AudioMixerGroup_Waiting_Phase_1P_Player = 25;

	public const int AudioMixerGroup_Waiting_Phase_Open_Door_Wind = 26;

	public const int AudioMixerGroup_Parachuting_Plane_Engine = 27;

	public const int AudioMixerGroup_Lobby_QuickMsg = 28;

	public const int AudioMixerGroup_Player_Action_FootStep_1P = 29;

	public const int AudioMixerGroup_BotAgent_Voice = 30;

	public const int AudioMixerGroup_InGameMusic = 31;

	public const int AudioMixerGroup_Player_Action_FootStep_3P = 32;

	public const int AudioMixerGroup_Emote_Normal_1P = 33;

	public const int AudioMixerGroup_Emote_Normal_3P = 34;

	public const int AudioMixerGroup_Emote_HQ_1P = 35;

	public const int AudioMixerGroup_Emote_HQ_3P = 36;

	public const int AudioMixerGroup_Weapon_Fire_1P = 37;

	public const int AudioMixerGroup_Weapon_Fire_2P = 38;

	public const int AudioMixerGroup_Weapon_Fire_3P = 39;

	public const int AudioMixerSnapshot_Default = 0;

	public const int AudioMixerSnapshot_CutScene = 1;

	public const int AudioMixerSnapshot_ShopShow = 2;

	public const int AudioMixerSnapshot_ShopShowWithBGM = 3;

	public const int AudioMixerSnapshot_GolbalControl_VoCharacters_ReplaceChat = 4;

	public const int AudioMixerSnapshot_Menu01 = 5;

	public const int AudioMixerSnapshot_Menu02 = 6;

	public const int AudioMixerSnapshot_ParachuteConrol_Flight_Slowdown_Normal = 7;

	public const int AudioMixerSnapshot_ParachuteConrol_Flight_Normal = 8;

	public const int AudioMixerSnapshot_ParachuteConrol_Flight_Dive = 9;

	public const int AudioMixerSnapshot_BR_Indoor_Default = 10;

	public const int AudioMixerSnapshot_ParachuteConrol_Flight_With_Plane = 11;

	public const int AudioMixerSnapshot_BR_Waiting_Phase_Normal = 12;

	public const int AudioMixerSnapshot_BR_Waiting_Phase_Open_Door = 13;

	private const int SnapShotCount = 14;

	private static readonly Dictionary<int, string> s_AudioMixerGroupsDict;

	private AudioMixer m_Mixer;

	private Dictionary<int, AudioMixerGroup> m_Groups;

	public AudioMixerGroup AudioMixerGroup_VirtualVoice;

	private AudioMixerSnapshot[] m_Snapshots;

	private Stack<int> m_BasicSnapshotStack;

	private bool m_UseBasicSnapshot;

	private EAudioSnapshotPriorityLayer m_CurrentPriorityLayer;

	private AudioMixerSnapshot m_CurrentSnapshot;

	private int m_NonBasicSnapshotIdx;

	private bool m_IsInit;

	public const float SnapshotFadeEffectTime = 0.2f;

	private readonly Dictionary<AudioResource, RuntimeEffectData> m_EffectData;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public void DoInit()
	{
	}

	public AudioMixerGroup GetAudioMixerGroup(int groupID)
	{
		return null;
	}

	public bool IsInGameMixerGroup(int groupID)
	{
		return false;
	}

	public bool IsUIMixerGroup(int groupID)
	{
		return false;
	}

	public void GetRealBus(EUIAudioSubBusType busType, ref int defaultMixerGroup)
	{
	}

	public void SwitchBusByFaction(SoundInstance_Unity sound, ESoundOwner faction)
	{
	}

	private bool SetSnapshotInternal(int snapshotIdx, float fadeTime = 0.2f)
	{
		return false;
	}

	public void ResetSnapshotStack()
	{
	}

	public void PushBasicSnapshot(int snapshotIdx)
	{
	}

	public void PopBasicSnapshot()
	{
	}

	public bool SwitchDefault(float fadeTime = 0.2f)
	{
		return false;
	}

	public bool SetSnapshotByPriority(int snapshotIdx, EAudioSnapshotPriorityLayer priorityLayer, float fadeTime = 0.2f)
	{
		return false;
	}

	public bool SwitchCutScene()
	{
		return false;
	}

	public bool SwitchShopShowNoBGM()
	{
		return false;
	}

	public bool SwitchShopShowWithBGM()
	{
		return false;
	}

	public bool SwitchFlightNormal()
	{
		return false;
	}

	public bool SwitchFlightNormalSlowDown()
	{
		return false;
	}

	public bool SwitchFlightDive()
	{
		return false;
	}

	public bool SwitchFlightWithPlane()
	{
		return false;
	}

	public bool SwitchBRIndoor()
	{
		return false;
	}

	public bool SwitchBRWaitingPhaseNormal(float fadeTime = 0.2f)
	{
		return false;
	}

	public bool SwitchBRWaitingPhaseOpenDoor(float fadeTime = 0.2f)
	{
		return false;
	}

	public void SetMixerParameter(string name, float value)
	{
	}

	public void SetWaitingPhase3PSelfRestrictThres(float thres)
	{
	}

	public void SetWaitingPhaseWindRestrictThres(float thres)
	{
	}

	public void SetEffectPreset(ResourceID effectPresetID, AudioResource audioResource)
	{
	}

	public void RemoveEffectPreset(AudioResource audioResource)
	{
	}
}
