namespace COW;

public class AutoTaskMicPermissionDenialWnd : AutoPopupTask
{
	public override bool Do()
	{
		return false;
	}

	public override bool IsDone()
	{
		return false;
	}

	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
