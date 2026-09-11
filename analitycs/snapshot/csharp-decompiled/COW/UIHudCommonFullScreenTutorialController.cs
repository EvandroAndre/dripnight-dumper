using System;
using GCommon;

namespace COW;

internal class UIHudCommonFullScreenTutorialController : UIPopupWindowController
{
	private UIHudCommonFullScreenTutorialView m_View;

	private uint m_BtnEnabledDelayCall;

	private Action m_CloseCallBack;

	private bool m_CloseEnabled;

	private int m_StartCountDown;

	private const int MASK_CLOSE_TIME = 3;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnMaskBtnClick()
	{
	}

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
