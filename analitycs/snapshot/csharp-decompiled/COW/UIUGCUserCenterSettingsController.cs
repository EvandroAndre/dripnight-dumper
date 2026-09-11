using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterSettingsController : UIPopupWindowController, IEasyList
{
	private UIUGCUserCenterSettingsView m_View;

	private EventLogger.EventTypeUGCPlatformHomeSettingChange m_SettingLogger;

	private readonly List<UIUGCUserCenterSettingsItemData> m_SettingItemDataList;

	private readonly Dictionary<UIUGCUserCenterSettingType, int> m_SettingIndexMap;

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

	protected override void OnUIClose()
	{
	}

	private void RefreshSettingItems()
	{
	}

	private void AddSettingItem(UIUGCUserCenterSettingType settingType, string title, bool value)
	{
	}

	private bool TryGetSettingItemData(UIUGCUserCenterSettingType settingType, out int index, out UIUGCUserCenterSettingsItemData itemData)
	{
		index = default(int);
		itemData = null;
		return false;
	}

	private bool TryGetSettingValue(UIUGCUserCenterSettingType settingType, out bool value)
	{
		value = default(bool);
		return false;
	}

	private void OnSettingHelpClick(UIUGCUserCenterSettingsItemData settingItemData)
	{
	}

	private void OnSettingChanged(UIUGCUserCenterSettingsItemData settingItemData)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
