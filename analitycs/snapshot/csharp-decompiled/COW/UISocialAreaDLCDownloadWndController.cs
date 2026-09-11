using System;
using GCommon;

namespace COW;

public class UISocialAreaDLCDownloadWndController : UIPopupWindowController
{
	private UISocialAreaDLCDownloadWndView m_View;

	private bool m_NoShow;

	private Action m_Act;

	public static string UISocialAreaDLCDownloadWndVersion;

	public static string UISocialAreaDLCDownloadWndNoShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetNoShowLabelActive(bool active)
	{
	}

	public void SetDownloadText(string txt)
	{
	}

	public void SetContentText(string txt)
	{
	}

	public void SetAction(Action act)
	{
	}

	private void OnDownladBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnNoShowBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
