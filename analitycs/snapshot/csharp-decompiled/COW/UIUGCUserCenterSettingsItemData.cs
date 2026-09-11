using System;

namespace COW;

public class UIUGCUserCenterSettingsItemData
{
	public UIUGCUserCenterSettingType settingType;

	public string title;

	public bool value;

	public Action<UIUGCUserCenterSettingsItemData> helpAction;

	public Action<UIUGCUserCenterSettingsItemData> changedAction;
}
