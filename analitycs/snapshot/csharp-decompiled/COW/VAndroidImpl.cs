using System.Collections.Generic;
using UnityEngine;

namespace COW;

public static class VAndroidImpl
{
	private static readonly AndroidJavaClass AndroidApis;

	public static void Configure(string appKey, string secretKey, string accountId, VodkaConfig config)
	{
	}

	public static void JoinChannel(string channelId)
	{
	}

	public static void JoinChannel(string channelId, ChannelEnvType channelEnvType)
	{
	}

	public static void LeaveChannel()
	{
	}

	public static void MuteOther(bool mute, List<string> userIds)
	{
	}

	public static void Report(string userId)
	{
	}

	public static int PauseChannel()
	{
		return 0;
	}

	public static int ResumeChannel()
	{
		return 0;
	}

	public static bool IsMicrophoneEnabled()
	{
		return false;
	}

	public static bool IsSpeakerphoneOn()
	{
		return false;
	}

	public static string GetSdkVersion()
	{
		return null;
	}

	public static void MicControl(bool enable)
	{
	}

	public static void SpeakerControl(bool enable)
	{
	}

	public static void SetPlayVolume(float volume)
	{
	}

	public static void SetUserVolume(string userId, float volume)
	{
	}

	public static void SetVoiceReceivers(bool isAll, List<string> userIds)
	{
	}

	public static void SetReleaseMicWhenMute(bool enabled)
	{
	}

	public static string GetAlgorithmInfo()
	{
		return null;
	}

	public static bool IsPcmDumpEnabled()
	{
		return false;
	}

	public static bool IsPcmDumpFilesExist()
	{
		return false;
	}

	public static bool DeletePcmDumpFiles()
	{
		return false;
	}

	public static bool UploadPcmDumpFiles()
	{
		return false;
	}

	public static bool CancelPcmDumpUploadFiles()
	{
		return false;
	}

	public static string GetVoiceServerIp()
	{
		return null;
	}

	public static int GetVoiceServerPort()
	{
		return 0;
	}

	public static string GetCurrentMemberIds()
	{
		return null;
	}

	public static string GetCurrentMemberInfos()
	{
		return null;
	}

	public static string GetSdkLogContent(int maxLines = 500)
	{
		return null;
	}

	public static bool DumpThreadStates(string reason)
	{
		return false;
	}

	public static TrafficStats GetAverageTrafficStats()
	{
		return null;
	}

	private static bool ValidateStringParameter(string parameter, string parameterName)
	{
		return false;
	}

	private static bool ValidateConfig(VodkaConfig config)
	{
		return false;
	}

	private static AndroidJavaObject CreateVodkaConfigBuilder(string appKey, string secretKey, VodkaConfig config)
	{
		return null;
	}

	private static void DisposeSafely(AndroidJavaObject javaObject)
	{
	}
}
