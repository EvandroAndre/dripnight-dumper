namespace COW;

internal class AutoTaskDeepLink : AutoPopupTask
{
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}
}
