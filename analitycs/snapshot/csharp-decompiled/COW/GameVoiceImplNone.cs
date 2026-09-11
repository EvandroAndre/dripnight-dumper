using System;
using System.Collections.Generic;
using FFVoice;

namespace COW;

public class GameVoiceImplNone : IGameVoiceInterface
{
	private bool _003CMicrophoneMute_003Ek__BackingField;

	private bool _003CSpeakerMute_003Ek__BackingField;

	public bool MicrophoneMute
	{
		get
		{
			return _003CMicrophoneMute_003Ek__BackingField;
		}
		set
		{
			_003CMicrophoneMute_003Ek__BackingField = value;
		}
	}

	public bool SpeakerMute
	{
		get
		{
			return _003CSpeakerMute_003Ek__BackingField;
		}
		set
		{
			_003CSpeakerMute_003Ek__BackingField = value;
		}
	}

	public void SetExtraConfig(object extra_config)
	{
	}

	public int Init(string callBack_object)
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

	public void SetRegion(int region_id, string region_name, string noti_region_name)
	{
	}

	public void SetAppkeySecret(string appKey, string appSecret, string magicVoiceToken, long voice_app_enc_timestamp)
	{
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

	public string ParseEventName(int event_id)
	{
		return null;
	}

	public string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	public void OnUpdate()
	{
	}

	public void SetGroupEnvironment(string environment)
	{
	}

	public void EnableVoiceCaptureCallBack(bool enable)
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

	public void SetUserVolume(string userId, uint volume)
	{
	}

	public int StartUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData)
	{
		return 0;
	}

	public int StopUploadContinuousAudio()
	{
		return 0;
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

	int IGameVoiceInterface.GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
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
