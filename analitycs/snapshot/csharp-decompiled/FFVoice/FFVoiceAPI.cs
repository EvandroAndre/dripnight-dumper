using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using UnityEngine;

namespace FFVoice;

public class FFVoiceAPI
{
	private delegate void UnityGetMicrophoneModeCallbackDelegate(FFVoiceErrorCode errcode, FFVoiceMicrophoneMode activeMode, FFVoiceMicrophoneMode preferredMode);

	private enum CallbackType
	{
		CALLBACK_TYPE_EVENT = 0,
		CALLBACK_TYPE_REST_API_RESPONSE = 1,
		CALLBACK_TYPE_MEMBER_CHANGE = 2,
		CALLBACK_TYPE_BROADCAST = 3,
		CALLBACK_TYPE_NONE = 1000
	}

	private struct UnityPcmCallbackData
	{
		public int channelNum;

		public int samplingRateHz;

		public int bytesPerSample;

		public IntPtr data;

		public int dataSizeInByte;

		public int flag;
	}

	public struct FFVoicePcmCallbackData
	{
		public int channelNum = 0;

		public int samplingRateHz = 0;

		public int bytesPerSample = 0;

		public byte[] data = null;

		public FFVoicePcmCallBackFlag flag = (FFVoicePcmCallBackFlag)0;

		public FFVoicePcmCallbackData(int channelNum, int samplingRateHz, int bytesPerSample, IntPtr data, int dataSizeInByte, FFVoicePcmCallBackFlag flag)
		{
		}

		public FFVoicePcmCallbackData(int channelNum, int samplingRateHz, int bytesPerSample, byte[] data, FFVoicePcmCallBackFlag flag)
		{
		}
	}

	private delegate void UnityPcmCallbackDelegate(IntPtr unityPcmCallbackData);

	private struct UnityVoiceStatus
	{
		public int volumeLevel;

		public bool hasEcho;

		public bool hasHowl;
	}

	public struct FFVoiceStatus(int volumeLevel, bool hasEcho, bool hasHowl)
	{
		public int volumeLevel = 0;

		public bool hasEcho = false;

		public bool hasHowl = false;
	}

	private class FFVoiceCallbackObject : MonoBehaviour
	{
		public void Release()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void FFVoiceCallback()
		{
		}
	}

	private delegate void UnityVoiceStatusCallbackDelegate(string channelID, string userID, IntPtr unityVoiceStatus);

	private delegate void UnityFarendHighVoiceCallbackDelegate(string channelID, string userID, int volLevel);

	private delegate void UnityHighVoiceComplainCallbackDelegate(string channelID, string userID);

	private delegate void UnitySelfLowVoiceCallbackDelegate(string channelID, int volLevel);

	private delegate void UnityUploadLogProgressCallbackDelegate(int progress, FFVoiceErrorCode errcode, string message);

	private delegate void UnityServerPingCallbackDelegate(string result);

	private class AndroidPluginPcmCallback : AndroidJavaProxy
	{
		public AndroidPluginPcmCallback()
			: base((string)null)
		{
		}

		public void onPcmDataRemote(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}

		public void onPcmDataRecord(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}

		public void onPcmDataMix(int channelNum, int samplingRateHz, int bytesPerSample, AndroidJavaObject javaByteData)
		{
		}
	}

	private class AndroidPluginVoiceStatusCallback : AndroidJavaProxy
	{
		public AndroidPluginVoiceStatusCallback()
			: base((string)null)
		{
		}

		public void onVoiceStatus(string channelID, string userID, AndroidJavaObject obj)
		{
		}

		public void onFarendHighVoice(string channelID, string userID, int volLevel)
		{
		}

		public void onSelfLowVoice(string channelID, int volLevel)
		{
		}

		public void onHighVoiceComplain(string channelID, string fromUserId)
		{
		}
	}

	private class AndroidPluginServerPingCallback : AndroidJavaProxy
	{
		public AndroidPluginServerPingCallback()
			: base((string)null)
		{
		}

		public void onGetServerPingComplete(string result)
		{
		}
	}

	private const string LibName = "ff_voice_engine";

	private MutableString mutableString;

	private Dictionary<string, string> dic;

	private static FFVoiceAPI mInstance;

	private static FFVoiceCallbackObject mCallbackScript;

	private string mCallbackObjName;

	private static Action<FFVoicePcmCallbackData> mPcmCallback;

	private static Action<string, string, FFVoiceStatus> mVoiceStatusCallback;

	private static Action<string, string, int> mFarendHighVoiceCallback;

	private static Action<string, int> mSelfLowVoiceCallback;

	private static Action<string, string> mHighVoiceComplainCallback;

	private static Action<int, FFVoiceErrorCode, string> mUploadLogProgressCallback;

	private static Action<FFVoiceErrorCode, FFVoiceMicrophoneMode, FFVoiceMicrophoneMode> mGetMicrophoneModeCallback;

	private static Action<string> mServerPingCallback;

	private bool mAndroidInited;

	private bool mAndroidInitOK;

	private AndroidJavaClass instance_FFVoice_java;

	private string mAndroidLibPath;

	private IFFVoiceObserver VoiceObserver;

	private bool _withInternalPermissionRequest;

	[PreserveSig]
	private static extern int FFVoice_init(string strAPPKey, string strAPPSecret, int serverRegionId, string strExtServerRegionName, int iAreaOpt);

	[PreserveSig]
	private static extern int FFVoice_setConfig(string sdkValidDomain, string QoSReportDomain, string APIDomain, string backupSDKValidIP, int sdkValidatePreferredMethod);

	[PreserveSig]
	private static extern int FFVoice_setCbMessageProto(int proto);

	[PreserveSig]
	private static extern int FFVoice_unInit();

	[PreserveSig]
	private static extern int FFVoice_getCbMessage(out IntPtr pMsg, out int proto);

	[PreserveSig]
	private static extern void FFVoice_freeCbMessage(IntPtr pMsg);

	[PreserveSig]
	private static extern int FFVoice_setServerPingCallback(UnityServerPingCallbackDelegate cbServerPing);

	[PreserveSig]
	private static extern int FFVoice_getServerPing(string strAreas);

	[PreserveSig]
	private static extern int FFVoice_allowHapticsDuringRecording(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_getMicrophoneMode(UnityGetMicrophoneModeCallbackDelegate cb);

	[PreserveSig]
	private static extern int FFVoice_showMicrophoneModeSystemUI();

	[PreserveSig]
	private static extern int FFVoice_setOutputToSpeaker(bool bOutputToSpeaker);

	[PreserveSig]
	private static extern int FFVoice_setSpeakerMute(bool bOn);

	[PreserveSig]
	private static extern bool FFVoice_getSpeakerMute();

	[PreserveSig]
	private static extern bool FFVoice_getMicrophoneMute();

	[PreserveSig]
	private static extern int FFVoice_setMicrophoneMute(bool mute);

	[PreserveSig]
	private static extern void FFVoice_setAutoSendStatus(bool bAutoSend);

	[PreserveSig]
	private static extern int FFVoice_getVolume();

	[PreserveSig]
	private static extern void FFVoice_setVolume(uint uiVolume);

	[PreserveSig]
	private static extern int FFVoice_getMicVolume();

	[PreserveSig]
	private static extern void FFVoice_setMicVolume(uint uiVolume);

	[PreserveSig]
	private static extern void FFVoice_setUserVolume(string strUserID, uint uiVolume);

	[PreserveSig]
	private static extern bool FFVoice_getUseMobileNetworkEnabled();

	[PreserveSig]
	private static extern void FFVoice_setUseMobileNetworkEnabled(bool bEnabled);

	[PreserveSig]
	private static extern int FFVoice_joinChannel(string strUserID, string strChannelID, int userRole, bool bSingleMode, bool bCheckRoomExist, string strArea);

	[PreserveSig]
	private static extern int FFVoice_joinAIChannel(string strUserID, string strChannelID, string strAIName, string strAILanguage, int nAIEngineID, bool bSingleMode, string strArea);

	[PreserveSig]
	private static extern int FFVoice_speakToChannel(string strChannelID);

	[PreserveSig]
	private static extern int FFVoice_setAIChatMicVolumeGain(uint uiGain);

	[PreserveSig]
	private static extern uint FFVoice_getAIChatMicVolumeGain();

	[PreserveSig]
	private static extern int FFVoice_leaveChannel(string strChannelID);

	[PreserveSig]
	private static extern int FFVoice_leaveChannelAll();

	[PreserveSig]
	private static extern int FFVoice_setPcmCallbackEnable(UnityPcmCallbackDelegate unityPcmCallback, int flag);

	[PreserveSig]
	private static extern int FFVoice_setOtherMicMute(string userID, bool mute);

	[PreserveSig]
	private static extern int FFVoice_setOtherSpeakerMute(string userID, bool mute);

	[PreserveSig]
	private static extern int FFVoice_setListenOtherVoice(string userID, bool isOn);

	[PreserveSig]
	private static extern void FFVoice_setServerRegion(int regionId, string strExtRegionId, bool bAppend);

	[PreserveSig]
	private static extern int FFVoice_playBackgroundMusic(string pFilePath, bool bRepeat);

	[PreserveSig]
	private static extern int FFVoice_pauseBackgroundMusic();

	[PreserveSig]
	private static extern int FFVoice_resumeBackgroundMusic();

	[PreserveSig]
	private static extern int FFVoice_stopBackgroundMusic();

	[PreserveSig]
	private static extern int FFVoice_setBackgroundMusicVolume(int volume);

	[PreserveSig]
	private static extern int FFVoice_getBackgroundMusicVolume();

	[PreserveSig]
	private static extern int FFVoice_setHeadsetMonitorOn(bool micEnabled, bool bgmEnabled);

	[PreserveSig]
	private static extern int FFVoice_setReverbEnabled(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_setVadCallbackEnabled(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_setSpeakerRecordOn(bool enabled);

	[PreserveSig]
	private static extern bool FFVoice_isSpeakerRecording();

	[PreserveSig]
	private static extern bool FFVoice_isInAnyChannel();

	[PreserveSig]
	private static extern bool FFVoice_isInited();

	[PreserveSig]
	private static extern int FFVoice_cleanSpeakerRecordCache();

	[PreserveSig]
	private static extern int FFVoice_setSelfVolumeLevel(int maxLevel);

	[PreserveSig]
	private static extern int FFVoice_setSelfLowVolumeLevel(string channelID, int volLevel);

	[PreserveSig]
	private static extern int FFVoice_setFarendVolumeLevel(int maxLevel, int maxMixedVolLevel);

	[PreserveSig]
	private static extern int FFVoice_setFarendHighVolumeLevel(string channelID, int volLevel);

	[PreserveSig]
	private static extern int FFVoice_complainHighVolume(string channelID, string userID);

	[PreserveSig]
	private static extern int FFVoice_setVoiceStatusCallbacks(UnityVoiceStatusCallbackDelegate cbVoiceStatus, int msCdVoiceStatus, UnityFarendHighVoiceCallbackDelegate cbHighVoice, int msCdFarendHighVoice, UnitySelfLowVoiceCallbackDelegate cbLowVoice, int msCdSelfLowVoice, UnityHighVoiceComplainCallbackDelegate cbHighVoiceComplain);

	[PreserveSig]
	private static extern int FFVoice_pauseChannel();

	[PreserveSig]
	private static extern int FFVoice_resumeChannel();

	[PreserveSig]
	private static extern float FFVoice_getSoundtouchPitchSemiTones();

	[PreserveSig]
	private static extern int FFVoice_setSoundtouchPitchSemiTones(float fPitchSemiTones);

	[PreserveSig]
	private static extern void FFVoice_setRecordingTimeMs(uint timeMs);

	[PreserveSig]
	private static extern void FFVoice_setPlayingTimeMs(uint timeMs);

	[PreserveSig]
	private static extern int FFVoice_getSDKVersion();

	[PreserveSig]
	private static extern int FFVoice_requestRestApi(string strCommand, string strQueryBody, ref int requestID);

	[PreserveSig]
	private static extern int FFVoice_getChannelUserList(string strChannelID, int maxCount, bool notifyMemChange);

	[PreserveSig]
	private static extern int FFVoice_setToken(string strToken);

	[PreserveSig]
	private static extern int FFVoice_setReleaseMicWhenMute(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_setExitCommModeWhenHeadsetPlugin(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_setGrabMicOption(string pChannelID, int mode, int maxAllowCount, int maxTalkTime, uint voteTime);

	[PreserveSig]
	private static extern int FFVoice_startGrabMicAction(string pChannelID, string pContent);

	[PreserveSig]
	private static extern int FFVoice_stopGrabMicAction(string pChannelID, string pContent);

	[PreserveSig]
	private static extern int FFVoice_requestGrabMic(string pChannelID, int score, bool isAutoOpenMic, string pContent);

	[PreserveSig]
	private static extern int FFVoice_releaseGrabMic(string pChannelID);

	[PreserveSig]
	private static extern int FFVoice_setInviteMicOption(string pChannelID, int waitTimeout, int maxTalkTime);

	[PreserveSig]
	private static extern int FFVoice_requestInviteMic(string pChannelID, string pUserID, string pContent);

	[PreserveSig]
	private static extern int FFVoice_responseInviteMic(string pUserID, bool isAccept, string pContent);

	[PreserveSig]
	private static extern int FFVoice_stopInviteMic();

	[PreserveSig]
	private static extern int FFVoice_sendMessage(string pChannelID, string pContent, ref int requestID);

	[PreserveSig]
	private static extern int FFVoice_setWhiteUserList(string pChannelID, string pWhiteUserList);

	[PreserveSig]
	private static extern int FFVoice_setUserRole(int userRole);

	[PreserveSig]
	private static extern int FFVoice_getUserRole();

	[PreserveSig]
	private static extern int FFVoice_kickOtherFromChannel(string pUserID, string pChannelID, int lastTime);

	[PreserveSig]
	private static extern bool FFVoice_releaseMicSync();

	[PreserveSig]
	private static extern bool FFVoice_resumeMicSync();

	[PreserveSig]
	private static extern int FFVoice_setMagicVoiceEnable(bool enabled);

	[PreserveSig]
	private static extern int FFVoice_getUserMagicVoiceEffectId(string userID);

	[PreserveSig]
	private static extern int FFVoice_setReportInfo(int nTimeSec, string language);

	[PreserveSig]
	private static extern int FFVoice_reportUserAudio(string reportUserID, string customData);

	[PreserveSig]
	private static extern int FFVoice_startUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData);

	[PreserveSig]
	private static extern int FFVoice_stopUploadContinuousAudio();

	[PreserveSig]
	private static extern int FFVoice_uploadLog(string userID, int timeout, UnityUploadLogProgressCallbackDelegate cbProgress, int msCdProgress);

	[PreserveSig]
	private static extern int FFVoice_abortUploadLog();

	private static void UnityGetMicrophoneModeCallbackFunc(FFVoiceErrorCode errcode, FFVoiceMicrophoneMode activeMode, FFVoiceMicrophoneMode preferredMode)
	{
	}

	[PreserveSig]
	private static extern int FFVoice_interruptAIAgent(string aiChannel, string aiName);

	private void procCallbackMessage(CallbackType cbType, FFVoiceCallbackMsgProto proto, string msg)
	{
	}

	private void ParseJsonCallbackMessageV3(string strMessage, CallbackType callbackType)
	{
	}

	public int ConvertStrToInt(string s, int startIdx, int endIdx)
	{
		return 0;
	}

	private void ParseJsonCallbackMessageV2(string strMessage, CallbackType cbType)
	{
	}

	private static void UnityPcmCallBackFunc(IntPtr param)
	{
	}

	private static void UnityVoiceStatusCallBackFunc(string channelID, string userID, IntPtr param)
	{
	}

	private static void UnityFarendHighVoiceCallBackFunc(string channelID, string userID, int volLevel)
	{
	}

	private static void UnityHighVoiceComplainCallBackFunc(string channelID, string userID)
	{
	}

	private static void UnitySelfLowVoiceCallBackFunc(string channelID, int volLevel)
	{
	}

	private static void UnityUploadLogProgressCallbackFunc(int progress, FFVoiceErrorCode errcode, string message)
	{
	}

	private static void UnityServerPingCallbackFunc(string result)
	{
	}

	public static FFVoiceAPI GetInstance()
	{
		return null;
	}

	private FFVoiceAPI()
	{
	}

	private void InitAndroidJava()
	{
	}

	public void SetAndroidLibPath(string libPath)
	{
	}

	public void SetCallback(string strObjName)
	{
	}

	public FFVoiceErrorCode Init(string strAppKey, string strAPPSecret, int serverRegionId, string strExtServerRegionName, IFFVoiceObserver voiceObserver, bool withInternalPermissionRequest = false, int iAreaOpt = 0)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public bool IsInited()
	{
		return false;
	}

	public bool IsInAnyChannel()
	{
		return false;
	}

	public FFVoiceErrorCode SetConfig(string sdkValidDomain, string QoSReportDomain, string APIDomain, string backupSDKValidIP, bool withInternalPermissionRequest = false, FFVoiceValidateMethod preferredMethod = FFVoiceValidateMethod.FFVoice_VALIDATE_METHOD_TCP)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetCbMessageProto(FFVoiceCallbackMsgProto proto)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode UnInit()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public void SetServerRegion(int regionId, string strExtRegionName)
	{
	}

	public FFVoiceErrorCode SetServerPingCallback(Action<string> cbServerPing)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode GetServerPing(string strAreas)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode AllowHapticsDuringRecording(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode ShowMicrophoneModeSystemUI()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode GetMicrophoneMode(Action<FFVoiceErrorCode, FFVoiceMicrophoneMode, FFVoiceMicrophoneMode> cb)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetOutputToSpeaker(bool bOutputToSpeaker)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetSpeakerMute(bool bMute)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public bool GetSpeakerMute()
	{
		return false;
	}

	public FFVoiceErrorCode SetMicrophoneMute(bool mute)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public bool GetMicrophoneMute()
	{
		return false;
	}

	public void SetAutoSendStatus(bool bAutoSend)
	{
	}

	public void SetVolume(uint uiVolume)
	{
	}

	public int GetVolume()
	{
		return 0;
	}

	public void SetMicVolume(uint uiVolume)
	{
	}

	public void SetUserVolume(string strUserID, uint uiVolume)
	{
	}

	public int GetMicVolume()
	{
		return 0;
	}

	public void SetUseMobileNetworkEnabled(bool bEnabled)
	{
	}

	public bool GetUseMobileNetworkEnabled()
	{
		return false;
	}

	public FFVoiceErrorCode JoinChannel(string strUserID, string strChannelID, FFVoiceUserRole userRole, bool bSingleMode = false, bool bCheckRoomExist = false, string strArea = "")
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode JoinAIChannel(string strUserID, string strChannelID, string strAIName, string strAILanguage, int nAIEngineID, bool bSingleMode, string strArea)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SpeakToChannel(string strChannelID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode LeaveChannel(string strChannelID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode LeaveChannelAll()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetPcmCallbackEnable(Action<FFVoicePcmCallbackData> callback, int flag)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetPcmCallback(Action<FFVoicePcmCallbackData> callback, bool bOutputToSpeaker = true)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetOtherMicMute(string userID, bool mute)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetOtherSpeakerMute(string userID, bool mute)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetListenOtherVoice(string userID, bool isOn)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode PlayBackgroundMusic(string strFilePath, bool bRepeat)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode PauseBackgroundMusic()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode ResumeBackgroundMusic()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode StopBackgroundMusic()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetBackgroundMusicVolume(int volume)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public int GetBackgroundMusicVolume()
	{
		return 0;
	}

	public FFVoiceErrorCode SetHeadsetMonitorOn(bool micEnabled, bool bgmEnabled = true)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetReverbEnabled(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetVadCallbackEnabled(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetSpeakerRecordOn(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public bool IsSpeakerRecording()
	{
		return false;
	}

	public FFVoiceErrorCode CleanSpeakerRecordCache()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetSelfVolumeLevel(int maxVolLevel)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetFarendVolumeLevel(int maxVolLevel, int maxMixedVolLevel)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetFarendHighVolumeLevel(string channelID, int volLevel)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetSelfLowVolumeLevel(string channelID, int volLevel)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode ComplainHighVolume(string channelID, string userID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetVoiceStatusCallbacks(Action<string, string, FFVoiceStatus> cbVoiceStatus, int msCdVoiceStatus, Action<string, string, int> cbFarendHighVoice, int msCdFarendHighVoice, Action<string, int> cbSelfLowVoice, int msCdSelfLowVoice, Action<string, string> cbHighVoiceComplain)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode PauseChannel()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode ResumeChannel()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public float GetSoundtouchPitchSemiTones()
	{
		return 0f;
	}

	public FFVoiceErrorCode SetSoundtouchPitchSemiTones(float fPitchSemiTones)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public void SetRecordingTimeMs(uint timeMs)
	{
	}

	public void SetPlayingTimeMs(uint timeMs)
	{
	}

	public int GetSDKVersion()
	{
		return 0;
	}

	public FFVoiceErrorCode RequestRestApi(string command, string queryBody, ref int requestID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode GetChannelUserList(string channelID, int maxCount, bool notifyMemChange)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public void SetToken(string strToken)
	{
	}

	public FFVoiceErrorCode SetReleaseMicWhenMute(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetExitCommModeWhenHeadsetPlugin(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetGrabMicOption(string pChannelID, int mode, int maxAllowCount, int maxTalkTime, uint voteTime)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode StartGrabMicAction(string pChannelID, string pContent)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode StopGrabMicAction(string pChannelID, string pContent)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode requestGrabMic(string pChannelID, int score, bool isAutoOpenMic, string pContent)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode releaseGrabMic(string pChannelID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode setInviteMicOption(string pChannelID, int waitTimeout, int maxTalkTime)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode requestInviteMic(string pChannelID, string pUserID, string pContent)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode responseInviteMic(string pUserID, bool isAccept, string pContent)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode stopInviteMic()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SendMessage(string channelID, string content, ref int requestID)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetWhiteUserList(string channelID, string whiteUserList)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode SetUserRole(FFVoiceUserRole userRole)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceUserRole GetUserRole()
	{
		return FFVoiceUserRole.FFVoice_USER_NONE;
	}

	public FFVoiceErrorCode KickOtherFromChannel(string userID, string channelID, int lastTime)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public bool ReleaseMicSync()
	{
		return false;
	}

	public bool ResumeMicSync()
	{
		return false;
	}

	public FFVoiceErrorCode SetMagicVoiceEnable(bool enabled)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public int GetUserMagicVoiceEffectId(string userID)
	{
		return 0;
	}

	public FFVoiceErrorCode SetReportInfo(int nTimeSec, string language)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode ReportUserAudio(string reportUserID, string customData)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode startUploadContinuousAudio(int audioSliceDuration, string fixedReportUser, string language, string customData)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode stopUploadContinuousAudio()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode UploadLog(string userID, int timeout, Action<int, FFVoiceErrorCode, string> cbProgress, int msCdProgress)
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}

	public FFVoiceErrorCode AbortUploadLog()
	{
		return FFVoiceErrorCode.FFVoice_SUCCESS;
	}
}
