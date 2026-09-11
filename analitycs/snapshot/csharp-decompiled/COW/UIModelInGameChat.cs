using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

public class UIModelInGameChat : UIBaseModel
{
	private const int MAXMESSAGECOUNT = 50;

	public const uint PropID_InGameChatReceiveNewMessage = 2u;

	public const uint PropID_InGameChatRevived = 4u;

	public const uint PropID_InGameTeamChatReceiveNewMessage = 8u;

	public const uint PropID_InGameChatReceiveNewUGCMessage = 16u;

	private List<ClientInGameChatMessage> m_ChatMessages;

	private List<ClientInGameChatMessage> m_AllChatMessages;

	private List<ClientInGameChatMessage> m_TeamChatMessages;

	private List<ClientInGameChatMessage> m_AllTeamChatMessages;

	private List<ClientInGameChatMessage> m_UGCMessages;

	private List<ClientInGameChatMessage> m_AllUGCMessages;

	private Dictionary<int, int> m_ChatType2UnreadCount;

	public override uint GetModelType()
	{
		return 0u;
	}

	public List<ClientInGameChatMessage> GetMessageList()
	{
		return null;
	}

	public List<ClientInGameChatMessage> GetAllMessageList()
	{
		return null;
	}

	public List<ClientInGameChatMessage> GetTeamChatMessageList()
	{
		return null;
	}

	public List<ClientInGameChatMessage> GetAllTeamChatMessageList()
	{
		return null;
	}

	public List<ClientInGameChatMessage> GetUGCMessageList()
	{
		return null;
	}

	public List<ClientInGameChatMessage> GetAllUGCMessageList()
	{
		return null;
	}

	public ClientInGameChatMessage GetLatestUGCMessage()
	{
		return null;
	}

	public ClientInGameChatMessage GetLatestAllUGCMessage()
	{
		return null;
	}

	public void ReturnToLobby()
	{
	}

	public void ClearTeamChatMessages()
	{
	}

	public void ClearUGCMessageList()
	{
	}

	public void OnRevived()
	{
	}

	public int GetMsgMaxCnt()
	{
		return 0;
	}

	public void OnMessageReveiced(List<ClientInGameChatMessage> messages)
	{
	}

	public void OnTeamChatMessageReceived(List<ClientInGameChatMessage> messages)
	{
	}

	public void OnUGCMessageReceived(List<ClientInGameChatMessage> messages)
	{
	}

	public int GetChatTypeUnreadCount(APJMAOJFMCF chatType)
	{
		return 0;
	}

	public void SetChatTypeUnreadCount(APJMAOJFMCF chatType, int count)
	{
	}

	public List<ClientInGameChatMessage> GetMessageList(APJMAOJFMCF chatType)
	{
		return null;
	}
}
