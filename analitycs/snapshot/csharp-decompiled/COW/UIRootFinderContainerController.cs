using GCommon;

namespace COW;

public class UIRootFinderContainerController : UIBaseController
{
	private UIRootFinderContainerView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public FrontEndSceneRootFinder GetFrontEndSceneRootFinder()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
