namespace TsiU;

public class TBTActionInverter : GSTBTAction
{
	public TBTActionInverter()
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

	protected override void OnClose(TBTWorkingData wData)
	{
	}
}
