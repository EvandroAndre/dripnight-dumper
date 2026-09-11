namespace TsiU;

public class TBTActionNonPrioritizedSelector : TBTActionPrioritizedSelector
{
	protected override bool onEvaluate(TBTWorkingData wData)
	{
		return false;
	}
}
