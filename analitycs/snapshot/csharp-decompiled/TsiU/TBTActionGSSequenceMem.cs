namespace TsiU;

public class TBTActionGSSequenceMem : GSTBTAction
{
	protected class TBTActionGSSequenceMemContext : TBTActionContext
	{
		internal int currExecuteIndex;
	}

	public TBTActionGSSequenceMem()
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
