using System.Collections.Generic;
using System.IO;
using System.Threading;
using COW;

namespace GCommon;

internal class MatchGameClient : NetworkClient, ISessionHanlder
{
	protected INetworkSession m_UDPSession;

	protected MemoryStream m_SendMemoryStream;

	protected MemoryStream m_RecvMemoryStream;

	protected FastBinaryReader m_BinaryReader;

	protected FastBinaryWriter m_BinaryWriter;

	protected MemoryStream m_PriDataMemoryStream;

	protected FastBinaryReader m_PriDataBinaryReader;

	protected List<UDPMsgPacket> m_RecvUDPMsgList;

	protected List<UDPMsgPacket> m_RecvUDPMsgListToRemove;

	protected Queue<UDPClientMessageBase> m_UnSerializedMsgList;

	protected Queue<ushort> m_UnSerializedMsgCmdList;

	protected Queue<UDPMsgPacket> m_UnSerializedMsgPacketList;

	protected List<UDPClientMessageBase> m_HandleMsgList;

	protected List<ushort> m_HandleMsgCmdList;

	protected List<UDPMsgPacket> m_HandleMsgPacketList;

	protected Dictionary<ushort, float> m_HandleMsgPacketRecTime;

	protected List<int> m_HandleMsgPacketListToRemove;

	protected ISessionHanlder m_SessionHandler;

	protected float m_LastRecvPingPacketTime;

	protected bool m_UseMUDP;

	protected Thread m_UnSerializeMsgThread;

	protected Thread m_SerializeMsgThread;

	protected AutoResetEvent m_SendMsgGotSignal;

	protected MobileReplayManager m_ReplayMgr;

	protected KillCamManager m_KillCamMgr;

	protected bool m_ReplayUsingOptimized1P;

	public int LastHandledRecvPacketCnt;

	public ulong m_RudpMaxDelayTime;

	public ulong m_RudpAllDelayTime;

	public ulong m_RudpAllDelayProcessTime;

	public ulong m_RudpReceivedCount;

	public ulong m_RudpDelayReceivedCount;

	protected HashSet<ushort> m_DelayedRudpOrderId;

	public List<ushort> m_CurFrameHandleMsgCmdList;

	public float m_CurFrameHandleTime;

	public List<ushort> m_LastFrameHandleMsgCmdList;

	public float m_LastFrameHandleTime;

	protected bool m_CanDisableHandleUDPPackets;

	protected bool m_HandleUDPPackets;

	protected bool m_HandleUDPPacketsTimeLimit;

	protected bool m_HandleUDPPacketsWaitTimeMaxMs;

	private FTimer m_Timer;

	protected bool mEnableUnSerializeRudpMsgThread;

	protected bool mEnableSerializeRudpMsgThread;

	protected bool mHasUnserializeException;

	protected HashSet<uint> m_UdpCmdHandleAtFrameEndList;

	private ushort m_lastRudpOrderID;

	private ushort m_lastRudpCmd;

	private bool m_HasCleared;

	private Dictionary<uint, List<S2C_C2S_RUDP_SPLITTED_DATAGRAM>> m_cachedSplittedDatagram;

	private MemoryStream m_splittedMsgStream;

	private BinaryWriter m_splittedMsgWriter;

	private FastBinaryReader m_splittedMsgReader;

	protected Queue<UDPClientMessageBase> m_SendMsgQueue;

	protected Queue<ulong> m_SendMsgCmdQueue;

	public bool HasUnserializeException
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public float MLastRecvPingPacketTime => 0f;

	public MatchGameClient(ISessionHanlder sessionHanlder)
	{
	}

	protected void StartUnSerializeMsgThread()
	{
	}

	protected void StartSerializeMsgThread()
	{
	}

	public override void Close(bool isSendNotification = true)
	{
	}

	public void ResetIsPendingResend()
	{
	}

	public void SetKeepAliveInterval(double interval)
	{
	}

	public void ClearRudpLog()
	{
	}

	public void SaveLastPing()
	{
	}

	public int GetLastPing()
	{
		return 0;
	}

	public void CanDisableNetworkProcess(bool enable)
	{
	}

	public void EnableNetworkProcess(bool enable)
	{
	}

	public void EnableNetworkLimitTime(bool enable)
	{
	}

	public void EnableNetworkWaitTimeMax(bool enable)
	{
	}

	public void SetNetworkLimitTime(uint milliSeconds)
	{
	}

	public virtual void Update()
	{
	}

	public void OnPingReceiveTimeout()
	{
	}

	public void OnReconnect()
	{
	}

	public virtual bool Send(uint messageID, UDPClientMessageBase msg, byte sendOption = 0, bool cacheMsgAnyWay = false)
	{
		return false;
	}

	public virtual void OnConnected(bool result)
	{
	}

	public virtual void OnDisconnected(DisconnectedReason reason)
	{
	}

	public virtual void OnPingSent(int lastSentTime)
	{
	}

	protected virtual UDPMsgPacket OnSplittedDatagram(S2C_C2S_RUDP_SPLITTED_DATAGRAM msg, ref UDPClientMessageBase bigMsg)
	{
		return null;
	}

	public void OnApplicationQuit()
	{
	}

	private void ClearThreadAndSignal()
	{
	}

	protected void OnSerializeMessageThread()
	{
	}

	protected void OnUnSerializeMessageThread()
	{
	}

	protected void GetHandleMsgList(List<UDPClientMessageBase> msgList, List<ushort> cmdList, List<UDPMsgPacket> packetList)
	{
	}

	public void ForceUpdateLastRecPingPacketTime()
	{
	}

	public void ResetLastRudpOrderID()
	{
	}

	protected virtual void HandleRecvPacket()
	{
	}

	protected virtual void HandleRecvPacketOld()
	{
	}

	protected void OnNetworkChanged(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after)
	{
	}

	public virtual void DebugForceReconnect()
	{
	}

	protected virtual void OnSplittedDatagramOld(S2C_C2S_RUDP_SPLITTED_DATAGRAM msg)
	{
	}

	private void DispatchMsg(ushort cmd, FastBinaryReader reader, bool isDynamicSize)
	{
	}
}
