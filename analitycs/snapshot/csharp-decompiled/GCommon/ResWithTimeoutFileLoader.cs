namespace GCommon;

public class ResWithTimeoutFileLoader : ResFileLoader
{
	private class TimeoutTimer
	{
		private float m_EndTime;

		public void Start(float gameTime, float timeout)
		{
		}

		public bool IsExpired(float gameTime)
		{
			return false;
		}
	}

	protected const float DEFAULT_TIMEOUT = 5f;

	private TimeoutTimer m_Timeout;

	protected override void OnStart(float time)
	{
	}

	public override bool IsTimeout(float time)
	{
		return false;
	}

	protected void ResetTimer(float time, float time_out = 5f)
	{
	}
}
