using System;
using GCommon;

namespace COW;

public class UIUGCUserCenterSettingsItemController : UIEasyListItemController
{
	private UIUGCUserCenterSettingsItemView m_View;

	private UIUGCUserCenterSettingsItemData m_ItemData;

	private Action<UIUGCUserCenterSettingsItemData> m_HelpAction;

	private Action<UIUGCUserCenterSettingsItemData> m_ChangedAction;

	public bool IsSwitchOn => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object viewData, int data_index)
	{
	}

	private void OnClickHelp()
	{
	}

	private void OnSwitchChanged(UIToggleButton button)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
