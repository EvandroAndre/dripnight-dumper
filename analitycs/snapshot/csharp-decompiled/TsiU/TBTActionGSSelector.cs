namespace TsiU;

public class TBTActionGSSelector : GSTBTAction
{
	protected class TBTActionGSSelectorContext : TBTActionContext
	{
		internal int currentSelectedIndex;

		internal int lastSelectedIndex;
	}

	public TBTActionGSSelector()
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
