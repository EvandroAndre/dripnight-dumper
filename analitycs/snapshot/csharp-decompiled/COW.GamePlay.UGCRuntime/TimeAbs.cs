namespace COW.GamePlay.UGCRuntime;

public struct TimeAbs(float value)
{
	private readonly float value = 0f;

	public TimeAbsMS ToMiliseconds()
	{
		return default(TimeAbsMS);
	}

	public float ToFloat32()
	{
		return 0f;
	}

	public TimeAbs Forward(TimeRel t)
	{
		return default(TimeAbs);
	}

	public TimeAbs Backward(TimeRel t)
	{
		return default(TimeAbs);
	}

	public TimeRel Interval(TimeAbs t)
	{
		return default(TimeRel);
	}
}
