using System;
using System.Collections.Generic;

namespace COW;

public class VodkaClient
{
	public static VodkaClient Shared;

	private IChannelEventListener _channelEventListener;

	private Action<JoinChannelResult> _joinChannelCallback;

	private Action<BaseResult> _configCallback;

	private Action<string> _leaveChannelCallback;

	private Action<PcmDumpUploadStatus, string> _pcmDumpUploadCallback;

	private VodkaClient()
	{
	}

	public void Configure(string appKey, string secretKey, string accountId, VodkaConfig config, Action<BaseResult> completion)
	{
	}

	public void JoinChannel(string channelId, Action<JoinChannelResult> completion, ChannelEnvType channelEnvType)
	{
	}

	public void JoinChannel(string channelId, Action<JoinChannelResult> completion, bool isMicClosed = true, bool isMcu = true, ChannelEnvType channelEnvType = ChannelEnvType.Simple)
	{
	}

	public void LeaveChannel(Action<string> completion)
	{
	}

	public void SetChannelEventListener(IChannelEventListener listener)
	{
	}

	public void MuteOther(bool mute, List<string> userIds)
	{
	}

	public void Report(string userId)
	{
	}

	public void MicControl(bool enable)
	{
	}

	public void SpeakerControl(bool enable)
	{
	}

	public void SetPlayVolume(float volume)
	{
	}

	public void SetUserVolume(string userId, float volume)
	{
	}

	public void SetVoiceReceivers(bool isAll, List<string> userIds)
	{
	}

	public void SetReleaseMicWhenMute(bool enabled)
	{
	}

	public VodkaErrorCode PauseChannel()
	{
		return VodkaErrorCode.Ok;
	}

	public VodkaErrorCode ResumeChannel()
	{
		return VodkaErrorCode.Ok;
	}

	public bool IsMicrophoneEnabled()
	{
		return false;
	}

	public bool IsSpeakerphoneOn()
	{
		return false;
	}

	public string GetSdkVersion()
	{
		return null;
	}

	public string GetAlgorithmInfo()
	{
		return null;
	}

	public bool IsPcmDumpEnabled()
	{
		return false;
	}

	public bool UploadPcmDumpFiles()
	{
		return false;
	}

	public bool IsPcmDumpFilesExist()
	{
		return false;
	}

	public bool DeletePcmDumpFiles()
	{
		return false;
	}

	public bool UploadPcmDumpFiles(Action<PcmDumpUploadStatus, string> callback)
	{
		return false;
	}

	public bool CancelPcmDumpUploadFiles()
	{
		return false;
	}

	public string GetVoiceServerIp()
	{
		return null;
	}

	public int GetVoiceServerPort()
	{
		return 0;
	}

	public List<string> GetCurrentMemberIds()
	{
		return null;
	}

	public List<VodkaMemberInfo> GetCurrentMembers()
	{
		return null;
	}

	public string GetSdkLogContent(int maxLines = 500)
	{
		return null;
	}

	public bool DumpThreadStates(string reason)
	{
		return false;
	}

	public TrafficStats GetAverageTrafficStats()
	{
		return null;
	}

	internal void OnConfigCallbackListener(string msg)
	{
	}

	internal void OnJoinChannelCallback(string msg)
	{
	}

	internal void OnMemberEvent(string msg)
	{
	}

	internal void OnChannelError(string msg)
	{
	}

	internal void OnChannelPauseResult(string msg)
	{
	}

	internal void OnChannelResumeResult(string msg)
	{
	}

	internal void OnKickOff(string msg)
	{
	}

	internal void OnStartReconnect()
	{
	}

	internal void OnReconnectResult(string msg)
	{
	}

	internal void OnSpeakingStateChanged(bool isSpeaking)
	{
	}

	public void OnLeaveChannel(string msg)
	{
	}

	internal void OnPcmDumpUploadStatus(string msg)
	{
	}

	private static PcmDumpUploadStatus ParsePcmDumpUploadStatus(string status)
	{
		return PcmDumpUploadStatus.Started;
	}

	private void NotifyPcmDumpUploadStatus(PcmDumpUploadStatus status, string message)
	{
	}
}
