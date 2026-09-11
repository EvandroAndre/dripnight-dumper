using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditCameraViewportController : UIBaseController
{
	private UIHudSceneEditCameraViewportView m_View;

	private SceneEditAgent m_Agent;

	public SceneEditAgent Agent => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnDescChange()
	{
	}

	private void OnPaintModeChange(bool value)
	{
	}

	private void OnClickResetAngleBtn()
	{
	}

	private void OnCameraProjectionClick()
	{
	}

	private void OnCameraProjectionChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
