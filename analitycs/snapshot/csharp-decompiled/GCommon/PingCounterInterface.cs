namespace GCommon;

public interface PingCounterInterface
{
	void PingSent(int sendCount);

	void PushPingPack(int sendCount);

	void GetCurrentPingStatus(out int ping, out int a500);

	void Clear();

	int CurrentPingValue();

	void StartCountToServer();

	void PopPingToServer(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total);

	void GetPingInfo(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total);

	void SetParams(double interval, int count);

	void SetPingMax(int pingMax);

	double GetPingInterval();

	int GetLastPushPingValue();
}
