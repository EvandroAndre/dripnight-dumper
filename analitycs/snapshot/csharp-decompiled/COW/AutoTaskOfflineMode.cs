namespace COW;

public class AutoTaskOfflineMode : AutoPopupTask
{
	private UIHudSceneEditOfflineModeMainController m_Controller;

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
