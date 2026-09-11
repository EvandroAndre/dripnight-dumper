namespace TsiU;

public class TBTActionLoop : TBTAction
{
	protected class TBTActionLoopContext : TBTActionContext
	{
		internal int currentCount;
	}

	public const int INFINITY = -1;

	private int _loopCount;

	public TBTActionLoop()
		: base(0)
	{
	}

	public TBTActionLoop SetLoopCount(int count)
	{
		return null;
	}

	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}

	protected override int onUpdate(TBTWorkingData wData)
	{
		return 0;
	}

	protected override void onTransition(TBTWorkingData wData)
	{
	}
}
