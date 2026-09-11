namespace COW;

internal class AutoTaskIAPBundlePreview : AutoPopupTask
{
	private UIIAPBundleV2PreviewController m_IAPBundlePreviewController;

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
