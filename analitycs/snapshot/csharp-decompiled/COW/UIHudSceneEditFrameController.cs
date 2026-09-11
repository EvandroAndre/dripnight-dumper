using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditFrameController : UIBaseController
{
	private UIHudSceneEditFrameView m_View;

	private SceneEditAgent m_Agent;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectionModeChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
