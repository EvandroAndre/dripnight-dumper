using System.Collections.Generic;
using System.Threading;

namespace GCommon;

public interface INetworkSession
{
	bool IsConnected();

	void ForceToRecconnect();

	void GetUDPPackets(List<UDPMsgPacket> outPackets);

	void SetKeepAliveInterval(double interval);

	void Update();

	void Send(uint cmd, byte[] data, int byteCount, byte sendOption = 0);

	bool Connect(string serverAddr, int port, string proxyAddr = "", int proxyPort = 0, bool connectProxy = false);

	void Close(bool isSendNotification = true);

	void SaveLastPing();

	int GetLastPing();

	void OnNetworkChanged(PlatformUtility.NetworkCallbackStatus before, PlatformUtility.NetworkCallbackStatus after);

	AutoResetEvent ReceiveNewMsgSignal();

	void CloseReceiveNewMsgSignal();
}
