namespace COW.GamePlay.UGCRuntime;

public class Timer
{
	private bool isRepeated;

	private TimeRelMS duration;

	private TimeAbsMS expiredTime;

	private TimerHandler action;

	public Timer Create(TimeAbsMS currentTime, TimeRelMS after, TimerHandler action, bool isRepeated)
	{
		return null;
	}

	public void SetExpiredTime(TimeAbsMS expiredTime)
	{
	}

	public bool IsExpired(TimeAbsMS currentTime)
	{
		return false;
	}

	public bool Update(TimeAbsMS currentTime)
	{
		return false;
	}
}
