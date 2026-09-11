using GCommon;

namespace COW;

public class UIHudGetOffSlideController : UIBaseController
{
	public const uint VISIBILITY_STATE_NoSighting = 1073741824u;

	private UIHudGetOffSlideView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void GetOff()
	{
	}

	private void OnSightingStateChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
