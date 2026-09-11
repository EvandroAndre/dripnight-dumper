using proto;

namespace COW;

public class AutoTaskLeveUp : AutoPopupTask
{
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public void UpdateGuesetBindAccountKeyIfNeeded(MatchIncome incomeData)
	{
	}

	public override bool IsDone()
	{
		return false;
	}
}
