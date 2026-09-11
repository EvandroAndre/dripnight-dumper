using System;
using GCommon;

namespace COW;

public class UIRoomPasswordConfirmController : UIPopupWindowController
{
	public enum UIStyle
	{
		PasswordOnly,
		GroupNameAndPassword
	}

	private UIRoomPasswordConfirmView m_View;

	private Action<string, string, string> m_ConfirmCallback;

	private UIStyle m_Style;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIStyle(UIStyle style)
	{
	}

	private void RefreshCacheGroupName()
	{
	}

	public void SetConfirmCallback(Action<string, string, string> callback)
	{
	}

	private void OnBtnConfirm()
	{
	}

	private void OnBtnClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
