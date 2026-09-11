using UnityEngine;

namespace COW;

public class VodkaHandler : MonoBehaviour
{
	private const string Name = "VodkaHandler";

	public static VodkaHandler Instance;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	public void OnConfigResult(string msg)
	{
	}

	public void OnJoinResult(string msg)
	{
	}

	public void OnKickoff(string msg)
	{
	}

	public void OnMemberChange(string msg)
	{
	}

	public void OnChannelError(string msg)
	{
	}

	public void OnChannelPauseResult(string msg)
	{
	}

	public void OnChannelResumeResult(string msg)
	{
	}

	public void OnStartReconnect(string msg)
	{
	}

	public void OnReconnectResult(string msg)
	{
	}

	public void OnSpeakingStart(string msg)
	{
	}

	public void OnSpeakingStop(string msg)
	{
	}

	public void OnLeaveChannel(string msg)
	{
	}

	public void OnPcmDumpUploadStatus(string msg)
	{
	}

	public void OnNativeLog(string msg)
	{
	}
}
