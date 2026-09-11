namespace GCommon;

public interface ISessionHanlder
{
	void OnConnected(bool result);

	void OnDisconnected(DisconnectedReason reason = DisconnectedReason.Unknown);

	void OnPingSent(int lastSentTime);

	void OnPingReceiveTimeout();

	void OnReconnect();
}
