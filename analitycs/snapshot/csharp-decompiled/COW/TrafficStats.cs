using System;

namespace COW;

[Serializable]
public class TrafficStats
{
	public long avgSendBytesPerSecond;

	public long avgReceiveBytesPerSecond;

	public TrafficStats(long avgSendBytesPerSecond, long avgReceiveBytesPerSecond)
	{
	}
}
