namespace COW;

internal class AutoTaskIAPBundleFirstTime : AutoPopupTask
{
	private UIIAPBundleV2Controller m_IAPBundleV2Controller;

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
