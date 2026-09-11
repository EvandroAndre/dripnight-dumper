using System;
using GCommon;

namespace COW;

public class UIFFWS03WarmUpController : UIPopupWindowController
{
	private UIFFWS03WarmUpView m_View;

	private UICountDownController m_CountDownCtrl;

	private Action m_CloseAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void SetData(Action closeAction)
	{
	}

	public void PlayEnterAnim()
	{
	}

	public void PlayExitAnim()
	{
	}

	public void OnClickClose()
	{
	}

	private void _003COnUIInit_003Eb__4_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
