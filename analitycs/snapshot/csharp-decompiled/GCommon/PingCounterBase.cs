using System.Collections.Generic;

namespace GCommon;

public class PingCounterBase : PingCounterInterface
{
	private Queue<int> m_PingQueue;

	private int m_TotalPingValue;

	private int m_CurPingValue;

	private int m_TotalServerPingLag;

	private int m_TotalServerPingCount;

	private int m_TotalServerPingLagB500;

	private int m_TotalServerPingCountB500;

	private int m_TotalServerPingLag100_200;

	private int m_TotalServerPingCount100_200;

	private int m_TotalServerPingLag200_300;

	private int m_TotalServerPingCount200_300;

	private int m_TotalServerPingLag300_400;

	private int m_TotalServerPingCount300_400;

	private int m_TotalServerPingLag400_500;

	private int m_TotalServerPingCount400_500;

	private int m_TotalServerPingLagA500;

	private int m_TotalServerPingCountA500;

	private int m_MaxServerPing;

	private bool m_StartToCollectPing;

	private float m_StartShowTime;

	private int m_LastSendPingCount;

	private bool m_LastPingBack;

	private int _003CLastPingPushValue_003Ek__BackingField;

	public static int PING_COUNT;

	public static int PING_MAXVALUE;

	public static double PING_INVERVAL;

	public int LastPingPushValue
	{
		get
		{
			return _003CLastPingPushValue_003Ek__BackingField;
		}
		private set
		{
			_003CLastPingPushValue_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	public virtual void PingSent(int sendCount)
	{
	}

	public virtual void PushPingPack(int sendCount)
	{
	}

	protected void PushPingValue(int value)
	{
	}

	public int CurrentPingValue()
	{
		return 0;
	}

	public void StartCountToServer()
	{
	}

	public void PopPingToServer(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total)
	{
		average = default(int);
		max = default(int);
		avgB500 = default(int);
		count100200 = default(int);
		count200300 = default(int);
		count300400 = default(int);
		count400500 = default(int);
		countA500 = default(int);
		total = default(int);
	}

	public void GetPingInfo(out int average, out int max, out int avgB500, out int count100200, out int count200300, out int count300400, out int count400500, out int countA500, out int total)
	{
		average = default(int);
		max = default(int);
		avgB500 = default(int);
		count100200 = default(int);
		count200300 = default(int);
		count300400 = default(int);
		count400500 = default(int);
		countA500 = default(int);
		total = default(int);
	}

	public void GetCurrentPingStatus(out int ping, out int a500)
	{
		ping = default(int);
		a500 = default(int);
	}

	public virtual void Clear()
	{
	}

	public virtual void SetParams(double pingInterval, int pingCount)
	{
	}

	public virtual void SetPingMax(int pingMax)
	{
	}

	public double GetPingInterval()
	{
		return 0.0;
	}

	public int GetLastPushPingValue()
	{
		return 0;
	}
}
