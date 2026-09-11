namespace TsiU;

public class TBTActionGSSequence : GSTBTAction
{
	protected class TBTActionGSSequenceContext : TBTActionContext
	{
		internal int lastExecuteIndex;
	}

	public TBTActionGSSequence()
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

	protected override void OnClose(TBTWorkingData wData)
	{
	}
}
