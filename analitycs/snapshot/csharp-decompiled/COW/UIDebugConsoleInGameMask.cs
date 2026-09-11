using System;
using GCommon;

namespace COW;

internal class UIDebugConsoleInGameMask : UIBaseController
{
	public UIDebugConsoleInGameMaskView m_View;

	private Action m_CloseDelegate;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetBgVisible(bool isVisible)
	{
	}

	public int GetMainPanelDepth()
	{
		return 0;
	}

	public void SetCloseDelegate(Action action)
	{
	}

	private void OnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
