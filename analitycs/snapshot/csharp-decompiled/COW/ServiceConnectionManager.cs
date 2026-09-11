using System;
using GCommon;
using tcp;

namespace COW;

internal class ServiceConnectionManager : SingletonModule<ServiceConnectionManager>
{
	private AccessValidInfo m_AccessValidInfo;

	private LobbyServiceConnectionHandler m_LobbyServiceConnection;

	private ChatServiceConnectionHandler m_ChatServiceConnection;

	public bool HighReleaseVersionLogin;

	private bool m_MatchGameNeedLogout;

	public bool MatchGameNeedLogout
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void UpdateAccessValidInfo(uint kts, byte[] ak, byte[] aiv, ulong accountD)
	{
	}

	public bool ConnectToLobbyService(string url)
	{
		return false;
	}

	public bool ConnectToChatService(string url)
	{
		return false;
	}

	public bool IsServiceConnected()
	{
		return false;
	}

	public bool IsChatServiceConnected()
	{
		return false;
	}

	public bool SendMessageToLobby(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0, bool ignoreDisconnetWnd = true)
	{
		return false;
	}

	public bool SendMessageToChatChannel(EProtocol.Proto cmdType, uint subCmdType, object message, byte regionID = 0)
	{
		return false;
	}

	public void SendAntiAddictionInfoToLobby(EAntiAddiction.Proto proto)
	{
	}

	public string CheckProtoType(EProtocol.Proto cmd, uint res_cmd)
	{
		return null;
	}

	public void Update(float gameTime)
	{
	}

	public bool NeedLogout()
	{
		return false;
	}

	public EAccount.Proto GetDisconnectionReason()
	{
		return EAccount.Proto.Proto_NONE;
	}

	public void Close()
	{
	}

	public void DebugDisconnect(DisconnectedReason reason)
	{
	}

	public void OnApplicationPause(bool paused)
	{
	}

	public void SceneChange(Type m_PendingGameType)
	{
	}

	private void SetServiceClientMsgHandleMode(EMsgHandleMode mode)
	{
	}

	private void _003CSendMessageToLobby_003Eb__15_0()
	{
	}
}
