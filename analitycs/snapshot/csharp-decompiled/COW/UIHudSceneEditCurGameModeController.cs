using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSceneEditCurGameModeController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public UIHudSceneEditCurGameModeController _003C_003E4__this;

		public HNDHJGJILHC sceneEditGame;

		internal void _003CRefreshCurMode_003Eb__0()
		{
		}
	}

	private UIHudSceneEditCurGameModeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private bool NeedShowModeHelpBtn(uint modeID)
	{
		return false;
	}

	private string HelpBtnMessage(uint modeID)
	{
		return null;
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void RefreshCurMode()
	{
	}

	private void OnGameModeChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
