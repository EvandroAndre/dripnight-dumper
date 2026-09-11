using System.Collections.Generic;

namespace GCommon;

public class PingCounterCustomizedInterval : PingCounterBase
{
	private Queue<int> m_CachePingSentQueue;

	private HashSet<int> m_CachedPingSentSet;

	private static int Ping_CacheSentMaxCount;

	public override void PingSent(int sendCount)
	{
	}

	public override void PushPingPack(int sendCount)
	{
	}

	public override void Clear()
	{
	}

	public override void SetParams(double pingInterval, int pingCount)
	{
	}

	public override void SetPingMax(int pingMax)
	{
	}
}
