using System;
using System.Collections.Generic;
using FFVoice;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class GameVoiceEngine : MonoBehaviour, IFFVoiceObserver, IFFMagicVoiceMgrCallback
{
	private enum EChannelPauseReason
	{
		eNone,
		eAppPause,
		eMute
	}

	private delegate void OnLeavedRoom();

	private delegate void OnJoinedRoom();

	private class Json_MemberChangeInfo
	{
		public string channelid;

		public Json_MemberInfo[] memchange;

		public int type;
	}

	public class Json_MemberInfo
	{
		public bool isJoin;

		public string userid;
	}

	public class Json_ReportAudio
	{
		public string report_id;

		public string user_id;

		public string report_user_id;

		public string room_id;

		public uint mask_time;

		public int mask_timestamp;

		public int report_timestamp;

		public string business_param;

		public string custom_data;
	}

	public class Json_Business_Param
	{
		public int behavior_ruleid;
	}

	public class Json_Custom_Data
	{
		public string match_id;

		public string match_create_time;
	}

	public class Json_Mute_Data
	{
		public uint mask_timestamp;
	}

	public class FFVoicePingInfos
	{
		public List<FFVoicePingInfo> result;
	}

	public class FFVoicePingInfo
	{
		public string area;

		public int avgRtt;

		public float lossPer;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<HttpErrorCode, object> _003C_003E9__170_0;

		internal void _003CReportAudioAck_003Eb__170_0(HttpErrorCode errCode, object obj)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass123_0
	{
		public GameVoiceEngine _003C_003E4__this;

		public RoomInfo joinRequest;

		public bool isRetry;

		public PermissionUtility.OnPermissionsResult _003C_003E9__1;

		internal void _003CJoinRoom_003Eb__0(bool result)
		{
		}

		internal void _003CJoinRoom_003Eb__1(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass136_0
	{
		public string strParam;

		public GameVoiceEngine _003C_003E4__this;

		internal void _003COnMemberChange_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass219_0
	{
		public FFMagicVoiceEvent evt;

		public FFMagicVoiceErrorCode errorCode;

		public string param;

		public GameVoiceEngine _003C_003E4__this;

		public Action _003C_003E9__3;

		internal void _003COnMagicVoiceEvent_003Eb__0()
		{
		}

		internal void _003COnMagicVoiceEvent_003Eb__1()
		{
		}

		internal void _003COnMagicVoiceEvent_003Eb__3()
		{
		}

		internal void _003COnMagicVoiceEvent_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass228_0
	{
		public GameVoiceEngine _003C_003E4__this;

		public Action<EMagicVoicePreviewResult> callback;

		public PermissionUtility.OnPermissionsResult _003C_003E9__1;

		internal void _003CTryPreviewMagicVoice_003Eb__0(bool result)
		{
		}

		internal void _003CTryPreviewMagicVoice_003Eb__1(Dictionary<int, bool> results)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass235_0
	{
		public FFMagicVoiceErrorCode errorCode;

		public FFMagicVoiceVipInfo vipInfo;

		internal void _003ConGetVipInfo_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public GameVoiceEngine _003C_003E4__this;

		public bool backEndMute;

		public EGameVoiceListenMode target_mode;

		internal void _003CToggleMicrophoneMute_003Eb__0(Dictionary<int, bool> results)
		{
		}

		internal void _003CToggleMicrophoneMute_003Eb__1(bool hasMicPermissions)
		{
		}
	}

	public const int SnowSlideCustomParamMask = 3;

	private const int LobbySocialVoiceModeCustomParamShift = 2;

	private const int LobbySocialVoiceModeCustomParamMask = 12;

	private int InitMagicVoiceFailCnt;

	private uint RetryInitMagicVoiceDelayCall;

	private bool m_AlreadySetMagicVoiceConfig;

	private bool m_IsMagicVoicePreview;

	private bool m_IsMagicVoiceIsIniting;

	private bool m_IsMagicVoiceInited;

	private static readonly int[] _VoicePermissions;

	private static readonly int[] _MicPermissions;

	private static string MagicVoiceValidDomain;

	private static string MagicVoiceReportIP;

	private ChannelState m_CurrentState;

	private bool m_EngineInited;

	public bool IsEngineInitOk;

	private bool m_IsTeamVoiceEnable;

	private List<string> m_TempOnTimePlayIdList;

	private EGameVoiceListenMode m_MicrophoneMode;

	private EGameVoiceListenMode m_SpeakerMode;

	public bool IsUploadingVoiceLog;

	public int UploadingProgress;

	public FFVoiceErrorCode UploadingErrorCode;

	private int m_LocalMicrophoneVolumeLevel;

	private string m_LocalPlayerUserID;

	private HashSet<string> m_PreMatchTeammates;

	private HashSet<string> m_OtherTeammates;

	private int m_RoomMemberCount;

	private OnLeavedRoom onLeavedRoom;

	private OnJoinedRoom onJoinedRoom;

	private static readonly int MAX_JOIN_RETRY_COUNT;

	private static readonly int MAX_INIT_RETRY_COUNT;

	private static readonly int MAX_RESUME_RETRY_COUNT;

	public static bool NeedShowMicPermissionDenialWnd;

	private float m_VolumeBalanceFactor;

	private uint m_GameVoiceVolume;

	private static GameVoiceEngine _instance;

	private List<Action> _actions;

	private int m_JoinRetryCount;

	private int m_InitRetryCount;

	private int m_ResumeRetryCount;

	private RoomInfo m_CurrentRoomInfo;

	private RoomInfo m_LastJoinRequest;

	private uint m_CurrentRetryJoinDelayID;

	private uint m_CurrentRetryResumeDelayID;

	private bool m_ChannelResumed;

	private EChannelPauseReason m_ChannelPauseReason;

	private Dictionary<string, bool> m_PlayerVadDict;

	private Dictionary<string, bool> m_PlayerMuteDict;

	private Dictionary<string, uint> m_PlayerVolumeDict;

	private Dictionary<string, bool> m_PlayerMutePassiveDict;

	private HashSet<string> m_PlayerVadSet;

	private Dictionary<string, float> m_PlayerVoiceOnTimeDict;

	private float m_OwnVoiceOnTime;

	private bool m_OwnVoiceIsOn;

	private Dictionary<string, ChatRestrictionReason> m_BRRestrictedPlayers;

	private ulong m_LastBRRestrictedTipsTime;

	private const ulong BR_RESTRICTED_TIPS_COOLDOWN = 5uL;

	private bool isVoiceStatusRegisted;

	private List<AccountIDCPingInfo> PingIDCs;

	private AccountIDCPingInfo BestIDCInfo;

	private bool m_IsTeammateHighVoice;

	private string m_TeammateHighVoiceUserID;

	private bool m_IsSelfLowVoice;

	public bool EnableBackgroundService;

	private float PressStartTime;

	private uint LongPressOpenMicDelayCall;

	private bool m_IsPressTalking;

	private bool m_PendingPressOpen;

	private EGameVoiceListenMode m_PendingPressMode;

	private bool m_IsMicBtnHolding;

	public bool IsMagicVoicePreview => false;

	public bool IsMagicVoiceInited => false;

	public ChannelState CurrentState => ChannelState.CHANNEL_STATE_JOINING;

	public bool IsTeamVoiceEnable => false;

	public int LocalMicrophoneVolumeLevel => 0;

	private string LocalPlayerUserID => null;

	private EGameVoiceListenMode MicroPhoneModeWithLogRecord
	{
		set
		{
		}
	}

	private EGameVoiceListenMode SpeakerModeWithLogRecord
	{
		set
		{
		}
	}

	public bool Inited => false;

	private static float RETRY_DEALY_SECOUND => 0f;

	public bool IsMicroPhoneMute => false;

	public float VolumeBalanceFactor
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public bool VolumeBalanceOn => false;

	public bool IsSpeakerMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public uint GameVoiceVolume
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public bool OwnVoiceOn => false;

	public static GameVoiceEngine Instance => null;

	public static bool HasInitedInstance => false;

	public RoomInfo CurrentRoomInfo => null;

	public RoomInfo LastJoinRequest => null;

	public bool ChannelResumed
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IsVoiceStatusRegisted => false;

	public static byte PackLobbySocialVoiceModeCustomParam(byte customParam, EGameVoiceListenMode mode)
	{
		return 0;
	}

	public static EGameVoiceListenMode GetLobbySocialVoiceModeFromCustomParam(int customParam)
	{
		return EGameVoiceListenMode.None;
	}

	private static void NotifyInstantSurveyLocalSpeakerMode(EGameVoiceListenMode value)
	{
	}

	public void ToggleMicrophoneMute(bool mute, bool request = true, bool needTips = true, EGameVoiceListenMode target_mode = EGameVoiceListenMode.All, bool needShowBRWarningNorice = false)
	{
	}

	public void SetSpeakerModeAndRefresh(EGameVoiceListenMode newMode)
	{
	}

	public bool SyncMicToSpeakerChannel(EGameVoiceListenMode channel)
	{
		return false;
	}

	public bool DriveSpeakerByMicChannel(EGameVoiceListenMode channel)
	{
		return false;
	}

	public void InitEngine()
	{
	}

	public void JoinRoom(string roomID, string playerID, string tag = "", bool is_for_loading = false, RoomInfo.EVoiceJoinScene join_scene = RoomInfo.EVoiceJoinScene.Other, RoomInfo.ERoomType roomType = RoomInfo.ERoomType.None)
	{
	}

	public bool IsInRoom()
	{
		return false;
	}

	private void JoinRoom(RoomInfo joinRequest, bool isRetry = false)
	{
	}

	private void _JoinRoom(RoomInfo joinRequest, bool isRetry = false)
	{
	}

	public void RegisterVoiceStatus()
	{
	}

	public void UnRegisterVoiceStatus()
	{
	}

	public void LeaveRoom(bool no_clear_lastJoin = false, string tag = "")
	{
	}

	private void JoinLastRequest()
	{
	}

	private void RetryJoinRoomLater(string roomID)
	{
	}

	private void RetryInitLater()
	{
	}

	private void RetryResumeLater()
	{
	}

	private void OnEvent(string strParam)
	{
	}

	public void OnMemberChange(string strParam)
	{
	}

	public void OnMemberChange(IEnumerable<Json_MemberInfo> memberInfoList)
	{
	}

	public void GetPingIDCs(ref List<AccountIDCPingInfo> target)
	{
	}

	private void PingIDC(string idcs)
	{
	}

	private void PingIDC_CB(string result)
	{
	}

	public void SetBestIDCInfo(AccountIDCPingInfo info)
	{
	}

	public string GetBestIDC()
	{
		return null;
	}

	private void OnVoiceStatusChange(string channelId, string userId, FFVoiceAPI.FFVoiceStatus status)
	{
	}

	public void OnEvent(int event_id, int errorCode, string channelID, string param)
	{
	}

	private void OnTeammateHighVoice(string channelId, string userid, int volume)
	{
	}

	private void OnSelfLowVoice(string channelId, int volume)
	{
	}

	private void OnJoinOk(string channelID, string param)
	{
	}

	private bool IsCustomRoomPrivilegeVoiceChannel(string channelID)
	{
		return false;
	}

	private void ClearVoiceOnOffData()
	{
	}

	private void OwnVoiceOffCallBack()
	{
	}

	private void OtherVoiceOffCallBack(string player_id)
	{
	}

	private void CacheMinorVoiceReportIfNeeded(string player_id)
	{
	}

	private void DispatchUGCPlayerSpeakEventForLocal(bool isStart)
	{
	}

	private void DispatchUGCPlayerSpeakEventForUser(string userId, bool isStart)
	{
	}

	public void SetPlayerVadFlag(string player_id, bool flag)
	{
	}

	public bool GetPlayerVadFlag(string player_id)
	{
		return false;
	}

	public bool GetPlayerVadSet(string player_id)
	{
		return false;
	}

	public void MuteTargetPlayer(string player_id, bool is_mute, bool needBRWarningTweenTipsNotice = true)
	{
	}

	public void MuteTargetPlayerPassive(string player_id, bool is_mute)
	{
	}

	public bool GetPlayerMutePassives(string player_id)
	{
		return false;
	}

	public void SetPlayerMuteFlag(string player_id, bool is_mute, bool actionCall = false, bool needBRWarningTweenTipsNotice = true)
	{
	}

	public bool GetPlayerMuteFlag(string player_id)
	{
		return false;
	}

	public void ReportAudioAck(string param)
	{
	}

	private void Update()
	{
	}

	public List<string> GetPlayerExpectSomeIDs(HashSet<string> expectIds)
	{
		return null;
	}

	private void UpdateUploadingLog()
	{
	}

	private void OnChannelResumed()
	{
	}

	private void SetMicAndSpeakerMute()
	{
	}

	private void CheckMicAndSpeakerState()
	{
	}

	public bool TryPauseChannel(bool isPause)
	{
		return false;
	}

	public uint GetUserVolume(string userId)
	{
		return 0u;
	}

	public void SetUserVolume(string userId, uint volume)
	{
	}

	public void OnLeaveGroup(bool isByDisconnected = false)
	{
	}

	public void OnUpdateGroup(GroupInfo group)
	{
	}

	private void OnApplicationPause(bool pause)
	{
	}

	public void DestroyGameVoiceEngine()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public EGameVoiceListenMode GetCurrentMicrophoneMode()
	{
		return EGameVoiceListenMode.None;
	}

	public EGameVoiceListenMode GetCurrentSpeakerMode()
	{
		return EGameVoiceListenMode.None;
	}

	public void SetMicrophoneSpeakerListenMode(EGameVoiceListenMode microphoneMode, EGameVoiceListenMode speakerMode)
	{
	}

	public bool SetCurrentMicrophoneMode(EGameVoiceListenMode newMode, bool force = false)
	{
		return false;
	}

	public bool SetCurrentSpeakerListenMode(EGameVoiceListenMode newMode, bool isNeedCallSDKMute = false)
	{
		return false;
	}

	public void RefreshByMicrophoneListenMode()
	{
	}

	public void RefreshPressedMicStateOnJoinMatch()
	{
	}

	private void RefreshBySpeakerListenMode(bool isNeedCallSDKMute = false)
	{
	}

	public void OnMatchEnd()
	{
	}

	public void OnGroupEnd(bool isByDisconnected = false)
	{
	}

	public void OnAddMatchTeammate(ulong playerId)
	{
	}

	public void OnAddGroupTeammate(ulong playerId)
	{
	}

	public void UpdateGroupTeammate(List<GroupMemberInfo> members)
	{
	}

	public bool IsPreMatchTeammate(string playerId)
	{
		return false;
	}

	public int PreMatchTeammateCount()
	{
		return 0;
	}

	public bool IsFullPreMatchTeam()
	{
		return false;
	}

	public bool IsShowSingleMode()
	{
		return false;
	}

	public int SetRoomPrivilegeVoiceReciver(List<string> reciverIDs = null)
	{
		return 0;
	}

	public int SetReciver(bool isAll)
	{
		return 0;
	}

	public void UpdateAreaReciver(string req)
	{
	}

	public List<string> GetCurMutePlayer()
	{
		return null;
	}

	public void SetCurMutePlayer(List<string> list)
	{
	}

	public void ClearMutePlayers()
	{
	}

	public int GetRoomMemberCount()
	{
		return 0;
	}

	public void RecordMicVoiceTime()
	{
	}

	public bool TryAdaptMicToSpeaker()
	{
		return false;
	}

	public bool TryAdaptSpeakerToMic()
	{
		return false;
	}

	public void ShowMicPermissionDenialTip(bool needInGameTips = true)
	{
	}

	public void StartUploadVoiceLog()
	{
	}

	public void UploadLogCB(int progress, FFVoiceErrorCode errCode, string desc)
	{
	}

	public void AbortUploadVoiceLog()
	{
	}

	public bool GetEnableGameVoiceEngineCallbackMessageV2()
	{
		return false;
	}

	private void SetCurrentMagicVoiceInfo()
	{
	}

	public void OnMagicVoiceEvent(FFMagicVoiceEvent evt, FFMagicVoiceErrorCode errorCode, string param)
	{
	}

	public int GetCurrentMagicEffectId()
	{
		return 0;
	}

	public void TryInitMagicVoice()
	{
	}

	private void InitMagicVoice()
	{
	}

	private int SetMagicVoiceInfo(int effectId)
	{
		return 0;
	}

	private int SetMagicVoiceEnable(bool enabled, bool needTip = false)
	{
		return 0;
	}

	public int GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
	{
		return 0;
	}

	private int StartPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public int StopPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public void TryPreviewMagicVoice(Action<EMagicVoicePreviewResult> callback)
	{
	}

	private void _TryPreviewMagicVoice(Action<EMagicVoicePreviewResult> callback)
	{
	}

	private void PreviewMagicVoiceInteral()
	{
	}

	public bool GetUserIsEnableMagicVoice(ulong aid)
	{
		return false;
	}

	public void SetIsSpeakingSprite(UISprite sprite, ulong aid)
	{
	}

	public static void SetMagicVoiceIP(string magicVoiceValidDomain, string magicVoiceReportIP)
	{
	}

	public void onEvent(FFMagicVoiceEvent evt, FFMagicVoiceErrorCode errorCode, string param)
	{
	}

	public void onGetVipInfo(FFMagicVoiceErrorCode errorCode, FFMagicVoiceVipInfo vipInfo)
	{
	}

	public bool IsInitedAndInRoom()
	{
		return false;
	}

	public void OnMagicVoiceSettingChange()
	{
	}

	public void TryJoinLobbyPreMatchRoom()
	{
	}

	public void ClearPendingPressState()
	{
	}

	public void OnMicBtnPressed(GameObject go, bool pressed)
	{
	}

	public void OnPressedVoiceSettingChange()
	{
	}

	public bool IsBRRestrictedPlayer(string playerId)
	{
		return false;
	}

	public ChatRestrictionReason GetBRRestrictionReason(string playerId)
	{
		return ChatRestrictionReason.None;
	}

	private string GetBRVoiceRestrictionTips(string playerId)
	{
		return null;
	}

	public bool IsPlayerInVoiceChannel(string playerId)
	{
		return false;
	}

	public void ApplyBRVoiceRestrictionsOnJoin()
	{
	}

	public void ApplyBRVoiceRestrictionsForJoiningPlayer(string joiningPlayerId)
	{
	}

	private void CheckAndApplyBRVoiceRestriction(string targetPlayerId, UIModelAntiAddiction antiAddictionModel)
	{
	}

	private bool GetPlayerBRAuthInfo(ulong targetAccountId, out AntiAddictionAgeAuthInfo authInfo, out GuardianVoiceChatSetting voiceSetting)
	{
		authInfo = null;
		voiceSetting = null;
		return false;
	}

	private bool GetPlayerBRAuthInfoFromCache(ulong targetAccountId, out AntiAddictionAgeAuthInfo authInfo, out GuardianVoiceChatSetting voiceSetting)
	{
		authInfo = null;
		voiceSetting = null;
		return false;
	}

	private List<string> GetAllPlayersInVoiceChannel()
	{
		return null;
	}

	public void ClearBRVoiceRestrictions()
	{
	}

	public void RemoveBRVoiceRestriction(string playerId)
	{
	}

	public void AddBRVoiceRestriction(string playerId, ChatRestrictionReason reason)
	{
	}

	private void CheckAndShowBRVoiceRestrictionTips(bool forceShow = false)
	{
	}

	private void _003CRetryJoinRoomLater_003Eb__132_0()
	{
	}

	private void _003CRetryInitLater_003Eb__133_0()
	{
	}

	private void _003CRetryResumeLater_003Eb__134_0()
	{
	}

	private void _003COnMicBtnPressed_003Eb__246_0()
	{
	}
}
