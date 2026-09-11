using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudSceneEditCrosshairController : UIBaseController
{
	private SceneEditAgent m_Agent;

	private SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
