using System;
using GCommon;

namespace COW;

public class UISceneEditSettingItemController : UIBaseController
{
	private UISceneEditSettingItemView m_View;

	private Action m_HelpAction;

	private Action m_ChangedAction;

	public UIWidget BG => null;

	public UIToggle ToggleButton => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(string title, bool value, string picUrl, Action helpAction, Action changedAction)
	{
	}

	private void OnClickHelp()
	{
	}

	private void OnSwitchChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
