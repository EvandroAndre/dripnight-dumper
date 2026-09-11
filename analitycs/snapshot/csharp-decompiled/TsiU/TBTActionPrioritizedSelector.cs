namespace TsiU;

public class TBTActionPrioritizedSelector : TBTAction
{
	protected class TBTActionPrioritizedSelectorContext : TBTActionContext
	{
		internal int currentSelectedIndex;

		internal int lastSelectedIndex;
	}

	public TBTActionPrioritizedSelector()
		: base(0)
	{
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
