using System;
using GCommon;

namespace COW;

public class UILauncherConfirmWnd : UIPopupWindowController
{
	private UILauncherConfirmWndView m_View;

	private Action m_ConfirmAction;

	private Action m_CancelAction;

	protected override void OnUIInit()
	{
	}

	protected void OnCancelClick()
	{
	}

	private void OnConfirmClick()
	{
	}

	public void SetData(string text = "")
	{
	}

	public void SetOneTextOverflow(UILabel.Overflow overflow)
	{
	}

	public void SetTitle(string title)
	{
	}

	public void ShowCancelButton()
	{
	}

	public void SetConfirmBtnLabel(string key)
	{
	}

	public void SetCancelBtnLabel(string key)
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetCancelCallback(Action action)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
