using System.Collections.Generic;
using System.IO;
using GCommon;

namespace COW;

internal class MobileMatchGameClient : MatchGameClient, PlatformUtility.INetworkCallback
{
	private float mLastForceToReconnectTime;

	private Dictionary<uint, S2C_C2S_RUDP_SPLITTED_DATAGRAM[]> m_cachedSplittedDatagram;

	private MemoryStream m_splittedMsgStream;

	private BinaryWriter m_splittedMsgWriter;

	private FastBinaryReader m_splittedMsgReader;

	public MobileMatchGameClient(ISessionHanlder sessionHanlder)
		: base(null)
	{
	}

	public void FixDeviceID()
	{
	}

	public override void OnConnected(bool result)
	{
	}

	public override void OnDisconnected(DisconnectedReason reason)
	{
	}

	public override void OnPingSent(int lastSentTime)
	{
	}

	public void OnNetworkCallback(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}

	public override void DebugForceReconnect()
	{
	}

	protected override UDPMsgPacket OnSplittedDatagram(S2C_C2S_RUDP_SPLITTED_DATAGRAM msg, ref UDPClientMessageBase bigMsg)
	{
		return null;
	}

	public override void Close(bool isSendNotification = true)
	{
	}

	protected override void OnSplittedDatagramOld(S2C_C2S_RUDP_SPLITTED_DATAGRAM msg)
	{
	}

	private void DispatchMsg(ushort cmd, FastBinaryReader reader, bool isDynamicSize)
	{
	}

	public void _003C_003EiFixBaseProxy_OnConnected(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDisconnected(DisconnectedReason P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPingSent(int P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DebugForceReconnect()
	{
	}

	public UDPMsgPacket _003C_003EiFixBaseProxy_OnSplittedDatagram(S2C_C2S_RUDP_SPLITTED_DATAGRAM P0, ref UDPClientMessageBase P1)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Close(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSplittedDatagramOld(S2C_C2S_RUDP_SPLITTED_DATAGRAM P0)
	{
	}
}
