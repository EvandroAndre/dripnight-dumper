namespace TsiU;

public class TBTActionSequence : TBTAction
{
	protected class TBTActionSequenceContext : TBTActionContext
	{
		internal int currentSelectedIndex;
	}

	private bool _continueIfErrorOccors;

	public TBTActionSequence()
		: base(0)
	{
	}

	public TBTActionSequence SetContinueIfErrorOccors(bool v)
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
