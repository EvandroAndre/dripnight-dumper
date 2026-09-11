using System;
using System.Collections.Generic;
using FFVoice;

namespace COW;

public interface IGameVoiceInterface
{
	bool MicrophoneMute { get; set; }

	bool SpeakerMute { get; set; }

	void SetRegion(int region_id, string region_name, string noti_region_name);

	void SetAppkeySecret(string appKey, string appSecret, string magicVoiceToken, long voice_app_enc_timestamp);

	void SetExtraConfig(object extra_config);

	int Init(string callBack_object);

	int JoinRoom(RoomInfo info);

	int LeaveRoom();

	EGameVoiceEvent ParseEventType(int event_id, string param);

	string ParseEventName(int event_id);

	string ParseErrorCodeName(int error_code);

	bool HasError(int error_code);

	void SetVolume(uint volume);

	void PauseChannel(bool is_pause);

	int UnInit();

	void OnInited();

	void OnJoined(string room_id);

	void OnUpdate();

	void SetGroupEnvironment(string environment);

	void EnableVoiceCaptureCallBack(bool enable);

	int MuteTargetPlayer(string player_id, bool is_mute);

	int SetReportInfo(int nTimeSec, string language);

	int ReportUserAudio(string reportUserID, string customData);

	int StartUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData);

	int StopUploadContinuousAudio();

	void SetUserVolume(string userId, uint volume);

	int SetReciver(string roomId, string reciver);

	int UploadLog(string userID, int timeout, Action<int, FFVoiceErrorCode, string> cbProgress, int msCdProgress);

	int AbortUploadLog();

	bool GetMagicVoiceEffectEnabled();

	int ClearMagicVoiceInfo();

	int SetMagicVoiceInfo(int effectId);

	int SetMagicVoiceEnable(bool enabled);

	void InitMagicVoice();

	bool SetMagicVoiceConfig(string validDomain, string reportIP);

	int GetMagicVoiceEffectInfoList(List<FFMagicVoiceEffectInfo> effectList);

	int StartPreviewMagicVoiceEffect();

	int StopPreviewMagicVoiceEffect();

	int SetPreviewMagicVoiceInfo(int effectId);

	int GetUserMagicVoiceEffectId(ulong aid);

	void SetSelfVolumeLevel(int maxVolLevel);

	void SetFarendVolumeLevel(int maxVolLevel);

	void SetSelfLowVolumeLevel(int threshold);

	void SetFarendHighVolumeLevel(int threshold);

	void SetVoiceStatusCallbacks(Action<string, string, FFVoiceAPI.FFVoiceStatus> cbVoiceStatus, int msCdVoiceStatus, Action<string, string, int> cbFarendHighVoice, int msCdFarendHighVoice, Action<string, int> cbSelfLowVoice, int msCdSelfLowVoice);

	void DeletePcmFiles();

	bool IsPcmFileExist();

	FFVoiceErrorCode SetServerPingCallback(Action<string> cbServerPing);

	FFVoiceErrorCode GetServerPing(string strAreas);
}
