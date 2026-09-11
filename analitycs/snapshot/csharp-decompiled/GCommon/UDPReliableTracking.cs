using System.Collections.Generic;

namespace GCommon;

public class UDPReliableTracking
{
	public class CircularValue
	{
		public static ushort Inc(ushort v, ushort step, ushort maxValue = ushort.MaxValue)
		{
			return 0;
		}

		public static bool Greater(ushort v1, ushort v2, ushort maxValue = ushort.MaxValue)
		{
			return false;
		}
	}

	public enum RECVRET
	{
		ENQUEUE,
		PENDING,
		DROP
	}

	public const ushort MAX_ORDER_ID = ushort.MaxValue;

	private ushort m_LocalOrderID;

	private ushort m_RequiredOrderID;

	private object m_Locker;

	private bool m_FlushForLongDeactiveTime;

	private double m_LastFlushTime;

	private LinkedList<UDPMsgPacket> m_PendingAckPacket;

	private static readonly byte[] s_EmptyAckBits;

	private byte[] m_AckBitsBuffer;

	public bool NeedFlushForLongDeactiveTime => false;

	public bool Update(ref List<UDPMsgPacket> packetToResend)
	{
		return false;
	}

	private void FastResendOldRUDP(UDPMsgPacket msg)
	{
	}

	private bool CheckAck(ushort msgOrderID, ushort firstBitOrderID, byte[] ackOrderBits)
	{
		return false;
	}

	public void HandleAck(ushort firstBitOrderID, byte[] ackOrderBits)
	{
	}

	public RECVRET PacketRecv(UDPMsgPacket packet)
	{
		return RECVRET.ENQUEUE;
	}

	public void ApplyReliableInfo(UDPMsgPacket packet)
	{
	}

	private bool checkAckBits(byte[] ackBits, int bitIndex)
	{
		return false;
	}

	private void addAckBits(ref byte[] ackBits, int bitIndex, ref int usedLength)
	{
	}

	public void GenAckBits(UDPMsgPacket newMsgPacket, LinkedList<UDPMsgPacket> pendingReliableRecvPacket, ref ushort firstBitOrderID, ref byte[] ackOrderBits)
	{
	}

	public void GenSingleAckBits(UDPMsgPacket v, ushort firstBitOrderID, ref byte[] ackOrderBits, ref int usedAckBitsLength)
	{
	}

	public void UpdateActiveTime(double last, double current)
	{
	}

	public void ResetIsPendingResend()
	{
	}

	private static void Sort<T>(LinkedListNode<T> head, LinkedListNode<T> tail, IComparer<T> comparer)
	{
	}

	private static void Swap<T>(LinkedListNode<T> a, LinkedListNode<T> b)
	{
	}
}
