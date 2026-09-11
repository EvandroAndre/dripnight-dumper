namespace COW.GamePlay.UGCRuntime;

public struct TimeAbsMS(int value)
{
	private readonly int value = 0;

	public TimeAbs ToSeconds()
	{
		return default(TimeAbs);
	}

	public int ToInt()
	{
		return 0;
	}

	public TimeAbsMS Forward(TimeRelMS t)
	{
		return default(TimeAbsMS);
	}

	public TimeAbsMS Backward(TimeRelMS t)
	{
		return default(TimeAbsMS);
	}

	public TimeRelMS Interval(TimeAbsMS t)
	{
		return default(TimeRelMS);
	}
}
