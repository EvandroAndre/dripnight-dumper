using System;
using GCommon;

namespace COW;

public class UISocialAreaOptionalDownloadWndController : UIPopupWindowController
{
	private UISocialAreaOptionalDownloadWndView m_View;

	private Action m_ActionA;

	private Action m_ActionB;

	private bool m_IsDLC;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetText(string TxtA, string TxtB)
	{
	}

	public void SetAction(Action actionA, Action actionB)
	{
	}

	private void OnDownladBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnOptionAClick()
	{
	}

	private void OnOptionBClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
