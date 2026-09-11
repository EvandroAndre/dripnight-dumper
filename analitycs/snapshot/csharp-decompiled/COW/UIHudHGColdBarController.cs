using GCommon;

namespace COW;

public class UIHudHGColdBarController : UIBaseController
{
	public const uint VISIBILITY_STATE_NoSighting = 1073741824u;

	private UIHudHGColdBarView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateShowData(float coldValue)
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
