using System;
using System.Collections.Generic;
using FFVoice;

namespace COW;

public class GameVoiceImpl_Vodka : IGameVoiceInterface, IChannelEventListener
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__15_1;

		public static Action<BaseResult> _003C_003E9__15_0;

		public static Action<JoinChannelResult> _003C_003E9__16_0;

		public static Action<string> _003C_003E9__17_0;

		public static Action<PcmDumpUploadStatus, string> _003C_003E9__39_0;

		internal void _003CInit_003Eb__15_0(BaseResult result)
		{
		}

		internal void _003CInit_003Eb__15_1()
		{
		}

		internal void _003CJoinRoom_003Eb__16_0(JoinChannelResult result)
		{
		}

		internal void _003CLeaveRoom_003Eb__17_0(string channelId)
		{
		}

		internal void _003CUploadLog_003Eb__39_0(PcmDumpUploadStatus status, string msg)
		{
		}

		internal void _003C_002Ecctor_003Eb__73_0()
		{
		}

		internal void _003C_002Ecctor_003Eb__73_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public BaseResult result;

		internal void _003CInit_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public JoinChannelResult result;

		internal void _003CJoinRoom_003Eb__1()
		{
		}

		internal void _003CJoinRoom_003Eb__2()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public string channelId;

		internal void _003CLeaveRoom_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass60_0
	{
		public MemberEvent memberEvent;

		internal void _003COnMemberEvent_003Eb__0()
		{
		}
	}

	private static string VodkaAppKey;

	private static string VodkaAppSecret;

	private static string VodkaServer;

	private string ExtServerRegionName;

	private bool m_IsMicrophoneMute;

	private bool m_IsSpeakerMute;

	private static readonly Action s_OwnVoiceOnAction;

	private static readonly Action s_OwnVoiceOffAction;

	public bool MicrophoneMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool SpeakerMute
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static void SetServer(string url)
	{
	}

	public int Init(string callBack_objectName)
	{
		return 0;
	}

	public int JoinRoom(RoomInfo info)
	{
		return 0;
	}

	public int LeaveRoom()
	{
		return 0;
	}

	public bool HasError(int error_code)
	{
		return false;
	}

	public void SetVolume(uint volume)
	{
	}

	public void PauseChannel(bool is_pause)
	{
	}

	public int UnInit()
	{
		return 0;
	}

	public EGameVoiceEvent ParseEventType(int event_id, string param)
	{
		return EGameVoiceEvent.None;
	}

	public void OnInited()
	{
	}

	public void OnJoined(string room_id)
	{
	}

	public void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	private void OnPcmCallBack(FFVoiceAPI.FFVoicePcmCallbackData data)
	{
	}

	private void OnPcmCallBack_Empty(FFVoiceAPI.FFVoicePcmCallbackData data)
	{
	}

	public string ParseEventName(int event_id)
	{
		return null;
	}

	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	public void SetGroupEnvironment(string environment)
	{
	}

	public void OnUpdate()
	{
	}

	public int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return 0;
	}

	public int SetReportInfo(int nTimeSec, string language)
	{
		return 0;
	}

	public int ReportUserAudio(string reportUserID, string customData)
	{
		return 0;
	}

	public int StartUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData)
	{
		return 0;
	}

	public int StopUploadContinuousAudio()
	{
		return 0;
	}

	public void SetUserVolume(string userId, uint volume)
	{
	}

	public int SetReciver(string roomId, string reciver)
	{
		return 0;
	}

	public int UploadLog(string userID, int timeout, Action<int, FFVoiceErrorCode, string> cbProgress, int msCdProgress)
	{
		return 0;
	}

	public int AbortUploadLog()
	{
		return 0;
	}

	public bool GetMagicVoiceEffectEnabled()
	{
		return false;
	}

	public int ClearMagicVoiceInfo()
	{
		return 0;
	}

	public int SetMagicVoiceInfo(int effectId)
	{
		return 0;
	}

	public int SetMagicVoiceEnable(bool enabled)
	{
		return 0;
	}

	public void InitMagicVoice()
	{
	}

	public bool SetMagicVoiceConfig(string validDomain, string reportIP)
	{
		return false;
	}

	public int GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
	{
		return 0;
	}

	public int StartPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public int StopPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public int SetPreviewMagicVoiceInfo(int effectId)
	{
		return 0;
	}

	public int GetUserMagicVoiceEffectId(ulong aid)
	{
		return 0;
	}

	public void SetSelfVolumeLevel(int maxVolLevel)
	{
	}

	public void SetFarendVolumeLevel(int maxVolLevel)
	{
	}

	public void SetSelfLowVolumeLevel(int threshold)
	{
	}

	public void SetFarendHighVolumeLevel(int threshold)
	{
	}

	public void SetVoiceStatusCallbacks(Action<string, string, FFVoiceAPI.FFVoiceStatus> cbVoiceStatus, int msCdVoiceStatus, Action<string, string, int> cbFarendHighVoice, int msCdFarendHighVoice, Action<string, int> cbSelfLowVoice, int msCdSelfLowVoice)
	{
	}

	public void SetRegion(int region_id, string region_name, string noti_region_name)
	{
	}

	public void SetAppkeySecret(string appKey, string appSecret, string magicVoiceToken, long voice_app_enc_timestamp)
	{
	}

	public void SetExtraConfig(object extra_config)
	{
	}

	public void OnMemberEvent(MemberEvent memberEvent)
	{
	}

	public void OnKickOff(BaseResult error)
	{
	}

	public void OnStartReconnect()
	{
	}

	public void OnReconnectResult(ReconnectResult result)
	{
	}

	public void OnSpeakingStateChanged(bool isSpeaking)
	{
	}

	public void OnChannelError(BaseResult error)
	{
	}

	public void OnChannelPauseResult(BaseResult result)
	{
	}

	public void OnChannelResumeResult(BaseResult result)
	{
	}

	public void DeletePcmFiles()
	{
	}

	public bool IsPcmFileExist()
	{
		return false;
	}

	public FFVoiceErrorCode SetServerPingCallback(Action<string> cbServerPing)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode GetServerPing(string strAreas)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}
}
