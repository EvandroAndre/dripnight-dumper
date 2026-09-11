using GCommon;

namespace COW;

public interface ISessionMonitor
{
	bool OnHandlePacket(TCPMsgPacket tcpPacket, object tcpMsg);
}
