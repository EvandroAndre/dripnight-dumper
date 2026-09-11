namespace GCommon;

internal enum UDPMessageIDReserved : uint
{
	UDP_HELLO = 1u,
	UDP_ACK = 2u,
	UDP_PING = 3u,
	UDP_BYEBYE = 4u,
	UDP_LONGTIMENOSEE = 5u,
	MUDP_CONNECT_ACK = 6u,
	RUDP_SPLITTED_DATAGRAM = 99u
}
