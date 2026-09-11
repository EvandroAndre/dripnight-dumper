using GCommon;
using proto;
using tcp;

namespace COW;

internal class ChatServiceConnectionHandler : ServiceConnectionHandler
{
	private UIModelChat m_ChatModel;

	private ulong m_ReservationReachLimitTime;

	public ChatServiceConnectionHandler(string token, AntiAddicHistoryInfo antiAddicHistoryInfo, AccessValidInfo accessValidInfo)
		: base(null, null, null, null)
	{
	}

	public override EServiceHandler GetServiceHandlerName()
	{
		return EServiceHandler.None;
	}

	private void OnRecvChannelMessage(MessageNotify res)
	{
	}

	private void OnRecvChatNty(MessageNotify res)
	{
	}

	protected override void OnServerConfirmed(TCPEmptyMessage res)
	{
	}

	public override void OnDisconnected(tcp.EAccount.Proto reason)
	{
	}

	private void LeaveAllChannels()
	{
	}

	private void JoinChannels()
	{
	}

	public EServiceHandler _003C_003EiFixBaseProxy_GetServiceHandlerName()
	{
		return EServiceHandler.None;
	}

	public void _003C_003EiFixBaseProxy_OnServerConfirmed(TCPEmptyMessage P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisconnected(tcp.EAccount.Proto P0)
	{
	}
}
