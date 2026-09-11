namespace COW;

public class PerformacneMonitor
{
	private int m_latestGameAvgFPS;

	private uint m_latestGameMatchTime;

	private uint m_latestGameJankCount;

	private float m_latestGameJankStutter;

	private int m_latestGameJitterPerMinute;

	public bool IsLatestBattleGameHighFrameRateNormal()
	{
		return false;
	}

	public bool IsLatestBattleGameGraphicsQualityNormal()
	{
		return false;
	}

	public void LogBattleGamePerformance(int globalFPS, int fps2, uint jitterCount, float stutter, uint matchTime)
	{
	}
}
