using System;
using System.Collections.Generic;
using FFVoice;

namespace COW;

public static class GameVoiceFacade
{
	public static int SDKTag_Vodka;

	public static int SDKTag_FFVoice;

	private static IGameVoiceInterface m_Impl;

	private static GameVoiceImpl_FreeFireVoice _mFreeFireVoiceImpl;

	private static GameVoiceImpl_Vodka _mVodkaVoiceImpl;

	public static GameVoiceImpl_FreeFireVoice FreeFireVoiceImpl => null;

	public static GameVoiceImpl_Vodka VodkaVoiceImpl => null;

	public static void SetImpl(IGameVoiceInterface impl)
	{
	}

	public static void SetGroupEnvironment(string environment)
	{
	}

	public static void SetRegion(int region_id, string region_name, string noti_region_name)
	{
	}

	public static void SetAppkeySecret(string appKey, string appSecret, string magicVoiceToken, long voice_app_enc_timestamp)
	{
	}

	public static void SetExtraConfig(object extra_config)
	{
	}

	public static int Init(string callBack_objectName)
	{
		return 0;
	}

	public static int GetSDKTag()
	{
		return 0;
	}

	public static void OnInited()
	{
	}

	public static int JoinRoom(RoomInfo info)
	{
		return 0;
	}

	public static void OnJoined(string room_id)
	{
	}

	public static int LeaveRoom()
	{
		return 0;
	}

	public static void PauseChannel(bool is_pause)
	{
	}

	public static int UnInit()
	{
		return 0;
	}

	public static bool HasError(int error_code)
	{
		return false;
	}

	public static EGameVoiceEvent ParseEventType(int event_id, string param)
	{
		return EGameVoiceEvent.None;
	}

	public static string ParseEventName(int event_id)
	{
		return null;
	}

	public static string ParseErrorCodeName(int error_code)
	{
		return null;
	}

	public static void SetVolume(uint volume)
	{
	}

	public static void SetMicAndSpeakerMute(bool micro_mute, bool speaker_mute)
	{
	}

	public static void OnUpdate()
	{
	}

	public static void EnableVoiceCaptureCallBack(bool enable)
	{
	}

	public static int MuteTargetPlayer(string player_id, bool is_mute)
	{
		return 0;
	}

	public static int SetReportInfo(int nTimeSec, string language)
	{
		return 0;
	}

	public static int ReportUserAudio(string reportUserID, string customData)
	{
		return 0;
	}

	public static int StartUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData)
	{
		return 0;
	}

	public static int StopUploadContinuousAudio()
	{
		return 0;
	}

	public static void SetUserVolume(string userId, uint volume)
	{
	}

	public static int SetVoiceReciver(string roomId, string userList)
	{
		return 0;
	}

	public static int UploadLog(string userID, int timeout, Action<int, FFVoiceErrorCode, string> cbProgress, int msCdProgress)
	{
		return 0;
	}

	public static int AbortUploadLog()
	{
		return 0;
	}

	public static bool GetMagicVoiceEffectEnabled()
	{
		return false;
	}

	public static int ClearMagicVoiceInfo()
	{
		return 0;
	}

	public static int SetMagicVoiceInfo(int effectId)
	{
		return 0;
	}

	public static int SetMagicVoiceEnable(bool enabled)
	{
		return 0;
	}

	public static void InitMagicVoice()
	{
	}

	public static bool SetMagicVoiceConfig(string validDomain, string reportIP)
	{
		return false;
	}

	public static int GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList)
	{
		return 0;
	}

	public static int StartPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public static int StopPreviewMagicVoiceEffect()
	{
		return 0;
	}

	public static int SetPreviewMagicVoiceInfo(int effectId)
	{
		return 0;
	}

	public static int GetUserMagicVoiceEffectId(ulong aid)
	{
		return 0;
	}

	public static void SetSelfVolumeLevel(int localUserVoiceMaxLevel)
	{
	}

	public static void SetFarendVolumeLevel(int otherUserVoiceMaxLevel)
	{
	}

	public static void SetSelfLowVolumeLevel(int threshold)
	{
	}

	public static void SetFarendHighVolumeLevel(int threshold)
	{
	}

	public static void SetVoiceStatusCallbacks(Action<string, string, FFVoiceAPI.FFVoiceStatus> cbVoiceStatus, int msCdVoiceStatus, Action<string, string, int> cbFarendHighVoice, int msCdFarendHighVoice, Action<string, int> cbSelfLowVoice, int msCdSelfLowVoice)
	{
	}

	public static bool IsInvalidImpl()
	{
		return false;
	}

	public static void DeletePcmFiles()
	{
	}

	public static bool IsPcmFileExist()
	{
		return false;
	}

	public static FFVoiceErrorCode SetServerPingCallback(Action<string> cbServerPing)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public static FFVoiceErrorCode GetServerPing(string strAreas)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public static void ClearImp()
	{
	}
}
